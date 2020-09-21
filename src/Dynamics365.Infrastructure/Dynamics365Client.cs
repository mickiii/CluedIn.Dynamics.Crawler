using System;
using System.Linq;
using System.Collections.Generic;
using System.Dynamic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using Castle.Core.Internal;

namespace CluedIn.Crawling.Dynamics365.Infrastructure
{
    // TODO - This class should act as a client to retrieve the data to be crawled.
    // It should provide the appropriate methods to get the data
    // according to the type of data source (e.g. for AD, GetUsers, GetRoles, etc.)
    // It can receive a IRestClient as a dependency to talk to a RestAPI endpoint.
    // This class should not contain crawling logic (i.e. in which order things are retrieved)
    public class Dynamics365Client
    {
        private readonly ILogger<Dynamics365Client> _log;
        private Dynamics365CrawlJobData dynamics365CrawlJobData;

        public Dynamics365Client(ILogger<Dynamics365Client> log, Dynamics365CrawlJobData dynamics365CrawlJobData)
        {
            _log = log ?? throw new ArgumentNullException(nameof(log));
            this.dynamics365CrawlJobData = dynamics365CrawlJobData ?? throw new ArgumentNullException(nameof(dynamics365CrawlJobData));
        }

        public async Task<ResultList<T>> GetList<T>(string url, int? top = null, string select = null, string filter = null, string expand = null, string next = null) where T : DynamicsModel
        {
            _log.LogInformation("Getting " + Dynamics365Constants.ProviderName + "...." + url + " ............");
            var data = await GetAsync<ResultList<T>>(url, true, next, true, top, select, filter, expand);
            if (data != null)
            {
                if (data.NextLink != null)
                    return await GetList<T>(url, top, select, filter, expand, data.NextLink);
            }
            else
                data = new ResultList<T>() { Value = new List<T>() };

            var definition = Get<ResultList<EntityDefinition>>("EntityDefinitions",
                  null,
                  string.Format("LogicalCollectionName eq '{0}'", url),
                  "Attributes").Result?.Value?.FirstOrDefault();

            if (definition == null)
                return data;

            var relationships = Get<ResultList<RelationshipDefinition>>
                  (
                  "RelationshipDefinitions/Microsoft.Dynamics.CRM.OneToManyRelationshipMetadata",
                  null,
                  string.Format("ReferencingEntity eq '{0}'", definition.LogicalName),
                  null
                  )?.Result?.Value;

            foreach (var item in data.Value)
            {
                item.EntityDefinition = definition;
                item.RelationshipDefinitions = relationships;
            }
            return data;
        }

        public async Task<T> Get<T>(string url, string select = null, string filter = null, string expand = null)
        {
            return await GetAsync<T>(url, false, null, false, null, select, filter, expand);
        }

        private async Task<T> GetAsync<T>(string url, bool page = true, string nextPageUrl = null, bool delta = true, int? top = null, string select = null, string filter = null, string expand = null)
        {
            T data = default(T);
            try
            {
                // set up client
                var client = new HttpClient();
                client.Timeout = new TimeSpan(0, 2, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                client.DefaultRequestHeaders.Add("OData-Version", "4.0");
                if (page && top == null)
                    client.DefaultRequestHeaders.Add("Prefer", "odata.maxpagesize=100");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", dynamics365CrawlJobData.TargetApiKey);

                // set up request uri
                var requestUri = nextPageUrl ?? url;

                // if this is the first call then construct the request Uri
                if (nextPageUrl == null)
                {
                    client.BaseAddress = new Uri(dynamics365CrawlJobData.BaseUrl);
                    var parameters = new List<string>();
                    string filterParameter = null;

                    if (select != null)
                        parameters.Add("$select=" + select);

                    if (expand != null)
                        parameters.Add("$expand=" + expand);

                    if (top != null)
                        parameters.Add("$top=" + top);

                    var filters = new List<string>();
                    if (filter != null)
                        filters.Add(filter);

                    if (delta && dynamics365CrawlJobData.LastCrawlFinishTime != default(DateTimeOffset) && dynamics365CrawlJobData.DeltaCrawlEnabled)
                    {
                        filters.Add($"(createdon ge {dynamics365CrawlJobData.LastCrawlFinishTime:yyyy-MM-ddThh:mm:ssZ} " +
                            $"or modifiedon ge {dynamics365CrawlJobData.LastCrawlFinishTime:yyyy-MM-ddThh:mm:ssZ})");
                    }

                    if (filters.Count > 0)
                    {
                        filterParameter = "$filter=" + string.Join(" and ", filters);
                        parameters.Add(filterParameter);
                    }
                    requestUri += "?" + string.Join("&", parameters);
                }

                // request
                var response = await client.GetAsync(requestUri);
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    //TODO: Retry 
                    RefreshToken(dynamics365CrawlJobData);
                }
                else if (response.StatusCode != HttpStatusCode.OK)
                {
                    var diagnosticMessage = $"Request to {dynamics365CrawlJobData.BaseUrl}{url} failed, response {response.ReasonPhrase} ({response.StatusCode})";
                    _log.LogError(diagnosticMessage);
                    throw new InvalidOperationException($"Communication to jsonplaceholder unavailable. {diagnosticMessage}");
                }

                var body = await response.Content.ReadAsStringAsync();

                data = JsonConvert.DeserializeObject<T>(body);
            }
            catch (Exception exception)
            {
                _log.LogError("Could not get data", exception);
            }
            return data;
        }

        public void RefreshToken(Dynamics365CrawlJobData dynamics365CrawlJobData)
        {
            try
            {
                var authenticationParameters = AuthenticationParameters.CreateFromUrlAsync(new Uri(dynamics365CrawlJobData.BaseUrl)).Result;
                //Workaround. Current version of AD library creates a wrong authority
                authenticationParameters.Authority = authenticationParameters.Authority.Substring(0, authenticationParameters.Authority.Length - 16);
                AuthenticationContext authenticationContext = new AuthenticationContext(authenticationParameters.Authority);
                var token = authenticationContext.AcquireTokenAsync(authenticationParameters.Resource, new ClientCredential(dynamics365CrawlJobData.ClientId, dynamics365CrawlJobData.ClientSecret)).Result;
                dynamics365CrawlJobData.TargetApiKey = token.AccessToken;
            }
            catch (Exception exception)
            {
                _log.LogError("Could not get access token", exception);
            }
        }

        public AccountInformation GetAccountInformation()
        {
            var whoAmI = Get<WhoAmI>("WhoAmI").Result;
            if (whoAmI != null)
                return new AccountInformation(whoAmI.UserId, whoAmI.UserId);
            return new AccountInformation(string.Empty, string.Empty);
        }
    }
}
