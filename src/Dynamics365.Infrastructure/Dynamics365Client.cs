using System;
using System.Collections.Generic;
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

        private readonly ILogger<Dynamics365Client> _log;
        private readonly IRestClient _client;
        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public Dynamics365Client(ILogger<Dynamics365Client> log, Dynamics365CrawlJobData dynamics365CrawlJobData, IRestClient client) // TODO: pass on any extra dependencies
        {
            if (dynamics365CrawlJobData == null)
            {
                throw new ArgumentNullException(nameof(dynamics365CrawlJobData));
            }

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            _log = log ?? throw new ArgumentNullException(nameof(log));
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _dynamics365CrawlJobData = dynamics365CrawlJobData ?? throw new ArgumentNullException(nameof(dynamics365CrawlJobData));


            // TODO use info from dynamics365CrawlJobData to instantiate the connection
            client.BaseUrl = new Uri(BaseUri);
            client.AddDefaultParameter("api_key", dynamics365CrawlJobData.ApiKey, ParameterType.QueryString);
        }

        public static async void RefreshToken(Dynamics365CrawlJobData dynamics365CrawlJobData)
        {
            string apiVersion = "9.1";
            string webApiUrl = $"{dynamics365CrawlJobData.Url}/api/data/v{apiVersion}/";

            try
            {
                var authenticationParameters = await AuthenticationParameters.CreateFromUrlAsync(new Uri(dynamics365CrawlJobData.Url + "/api/data/v9.0"));
                //Workaround. Current version of AD library creates a wrong authority
                authenticationParameters.Authority = authenticationParameters.Authority.Substring(0, authenticationParameters.Authority.Length - 16);
                AuthenticationContext authenticationContext = new AuthenticationContext(authenticationParameters.Authority);
                var token = authenticationContext.AcquireTokenAsync(authenticationParameters.Resource, new ClientCredential(dynamics365CrawlJobData.ClientId, dynamics365CrawlJobData.ClientSecret)).Result;
                dynamics365CrawlJobData.TargetApiKey = token.AccessToken;
            }
            catch
            {
                throw new Exception("Unable to fetch token");
            }
        }

        public IEnumerable<T> Get<T>(string endpoint, Dynamics365CrawlJobData dynamics365CrawlJobData)
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

            string url;
            if (_dynamics365CrawlJobData.DeltaCrawlEnabled)
            {
                url = _dynamics365CrawlJobData.Url + string.Format("/api/data/v9.1/{0}?$filter={1}", endpoint, filter);
            }
            else
            {
                url = _dynamics365CrawlJobData.Url + string.Format("/api/data/v9.1/{0}", endpoint);
            }

            ResultList<T> resultList = null;
            while (true)
            {
                using HttpClient httpClient = new HttpClient();
                try
                {
                    httpClient.Timeout = new TimeSpan(0, 2, 0);
                    httpClient.DefaultRequestHeaders.Add("Prefer", "odata.maxpagesize=100");
                    httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                    httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", dynamics365CrawlJobData.TargetApiKey);
                    HttpResponseMessage responseMessage = httpClient.GetAsync(url).Result;
                    var content = responseMessage.Content.ReadAsStringAsync().Result;
                    if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        RefreshToken(dynamics365CrawlJobData);
                        continue;
                    }
                    else if (responseMessage.StatusCode != HttpStatusCode.OK)
                    {
                        _log.LogError("Connection failed " + responseMessage.StatusCode);
                    }
                    resultList = JsonConvert.DeserializeObject<ResultList<T>>(content, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                }
                catch (Exception e)
                {
                    _log.LogError(e.Message);
                }


                if (resultList?.Value != null)
                {
                    foreach (var item in resultList.Value)
                        yield return item;
                }
                else
                {
                    yield break;
                }
                if (resultList.NextLink == null)
                {
                    yield break;
                }
            }
        }

        public AccountInformation GetAccountInformation()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _dynamics365CrawlJobData.TargetApiKey);

                HttpResponseMessage response = httpClient.GetAsync(_dynamics365CrawlJobData.Url + "/api/data/v9.1/WhoAmI").Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    return new AccountInformation(content, content);
                }
            }
            return new AccountInformation("", "");
        }

    }
}
