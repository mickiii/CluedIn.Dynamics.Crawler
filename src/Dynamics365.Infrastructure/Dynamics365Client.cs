using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

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

        public async Task<T> GetAsync<T>(string url)
        {
            T data = default(T);
            try
            {
                // set up client
                var client = new HttpClient();
                client.BaseAddress = new Uri(dynamics365CrawlJobData.BaseUrl);
                client.Timeout = new TimeSpan(0, 2, 0);
                client.DefaultRequestHeaders.Add("Prefer", "odata.maxpagesize=100");
                client.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                client.DefaultRequestHeaders.Add("OData-Version", "4.0");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", dynamics365CrawlJobData.TargetApiKey);

                // set up request uri
                var filters = new List<string>();
                if (dynamics365CrawlJobData.LastCrawlFinishTime != default(DateTimeOffset) && dynamics365CrawlJobData.DeltaCrawlEnabled)
                {
                    filters.Add($"(createdon ge {dynamics365CrawlJobData.LastCrawlFinishTime:yyyy-MM-ddThh:mm:ssZ} or modifiedon ge {dynamics365CrawlJobData.LastCrawlFinishTime:yyyy-MM-ddThh:mm:ssZ})");
                }

                var requestUri = url;
                if (filters.Count > 0)
                {
                    requestUri += "$filter=" + string.Join(" and ", filters);
                }

                // request
                var response = await client.GetAsync(url);
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
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
                var authenticationParameters =  AuthenticationParameters.CreateFromUrlAsync(new Uri(dynamics365CrawlJobData.BaseUrl)).Result;
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
            return new AccountInformation("", "");
        }
    }
}
