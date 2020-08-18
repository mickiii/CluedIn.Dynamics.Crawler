using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CluedIn.Core.Logging;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
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
        private const string BaseUri = "http://sample.com";

        private readonly ILogger log;

        private readonly IRestClient client;
        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public Dynamics365Client(ILogger log, Dynamics365CrawlJobData dynamics365CrawlJobData, IRestClient client) // TODO: pass on any extra dependencies
        {
            if (dynamics365CrawlJobData == null)
            {
                throw new ArgumentNullException(nameof(dynamics365CrawlJobData));
            }

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.log = log ?? throw new ArgumentNullException(nameof(log));
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            _dynamics365CrawlJobData = dynamics365CrawlJobData ?? throw new ArgumentNullException(nameof(dynamics365CrawlJobData));


            // TODO use info from dynamics365CrawlJobData to instantiate the connection
            client.BaseUrl = new Uri(BaseUri);
            client.AddDefaultParameter("api_key", dynamics365CrawlJobData.Url, ParameterType.QueryString);
        }

        private async Task<T> GetAsync<T>(string url)
        {
            var request = new RestRequest(url, Method.GET);

            var response = await client.ExecuteTaskAsync(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                var diagnosticMessage = $"Request to {client.BaseUrl}{url} failed, response {response.ErrorMessage} ({response.StatusCode})";
                log.Error(() => diagnosticMessage);
                throw new InvalidOperationException($"Communication to jsonplaceholder unavailable. {diagnosticMessage}");
            }

            var data = JsonConvert.DeserializeObject<T>(response.Content);

            return data;
        }

        public AccountInformation GetAccountInformation()
        {
            //TODO - return some unique information about the remote data source
            // that uniquely identifies the account
            return new AccountInformation("", "");
        }

        public static void RefreshToken(Dynamics365CrawlJobData dynamics365CrawlJobData)
        {
            string apiVersion = "9.1";
            string webApiUrl = $"{dynamics365CrawlJobData.Url}/api/data/v{apiVersion}/";

            var userCredential = new UserCredential(dynamics365CrawlJobData.UserName, dynamics365CrawlJobData.Password);
            var authParameters = AuthenticationParameters.CreateFromResourceUrlAsync(new Uri(webApiUrl)).Result;
            var authContext = new AuthenticationContext(authParameters.Authority, false);
            var authResult = authContext.AcquireTokenAsync(authParameters.Resource, dynamics365CrawlJobData.ClientId, userCredential).Result;
            var refreshToken = authContext.AcquireTokenByRefreshTokenAsync(authResult.RefreshToken, dynamics365CrawlJobData.ClientId).Result;
            dynamics365CrawlJobData.ApiKey = refreshToken.AccessToken;
        }

        public IEnumerable<T> Get<T>(string value, Dynamics365CrawlJobData dynamics365CrawlJobData)
        {
            DateTimeOffset lastCrawlFinishTime;
            if (_dynamics365CrawlJobData.LastCrawlFinishTime == DateTimeOffset.Parse("1/1/0001 12:00:00 AM +00:00"))
            {
                lastCrawlFinishTime = DateTimeOffset.Parse("01/01/1753 00:00:00");
            }
            else
            {
                lastCrawlFinishTime = _dynamics365CrawlJobData.LastCrawlFinishTime;
            }

            var filter = $"(createdon ge {lastCrawlFinishTime:yyyy-MM-ddThh:mm:ssZ} or modifiedon ge {lastCrawlFinishTime:yyyy-MM-ddThh:mm:ssZ})";

            var url = _dynamics365CrawlJobData.Url;

            if (_dynamics365CrawlJobData.DeltaCrawlEnabled)
            {
                url = _dynamics365CrawlJobData.Url + string.Format("/api/data/v9.1/{0}?$filter={1}", value, filter);
            }

            ResultList<T> resultList = null;
            while (true)
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    try
                    {

                        httpClient.Timeout = new TimeSpan(0, 2, 0);
                        httpClient.DefaultRequestHeaders.Add("Prefer", "odata.maxpagesize=100");
                        httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                        httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", dynamics365CrawlJobData.ApiKey);
                        HttpResponseMessage responseMessage = httpClient.GetAsync(url).Result;
                        var content = responseMessage.Content.ReadAsStringAsync().Result;
                        if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            RefreshToken(dynamics365CrawlJobData);
                            continue;
                        }
                        else if (responseMessage.StatusCode != HttpStatusCode.OK)
                        {
                            log.Error(() => "Connection failed " + responseMessage.StatusCode);
                        }
                        resultList = JsonConvert.DeserializeObject<ResultList<T>>(content, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                    }
                    catch (Exception e)
                    {
                        log.Error(() => e.Message);
                    }


                    if (resultList?.Value != null)
                    {
                        foreach (var item in resultList.Value)
                            yield return item;
                    }
                    else
                    {
                        break;
                    }
                    if (resultList.NextLink == null)
                    {
                        break;
                    }
                }
            }
        }
    }
}
