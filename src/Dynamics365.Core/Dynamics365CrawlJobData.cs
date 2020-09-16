using System.Collections.Generic;
using System.Configuration;
using CluedIn.Core;
using CluedIn.Core.Configuration;
using CluedIn.Core.Crawling;

namespace CluedIn.Crawling.Dynamics365.Core
{
    public class Dynamics365CrawlJobData : CrawlJobData
    {
        public Dynamics365CrawlJobData()
        {

        }

        public Dynamics365CrawlJobData(IDictionary<string, object> configuration)
        {
            Url = configuration.GetValue(Dynamics365Constants.KeyName.Url, default(string));
            DeltaCrawlEnabled = configuration.GetValue(Dynamics365Constants.KeyName.DeltaCrawlEnabled, true);
            UserName = configuration.GetValue(Dynamics365Constants.KeyName.UserName, default(string));
            Password = configuration.GetValue(Dynamics365Constants.KeyName.Password, default(string));
            ClientId = configuration.GetValue(Dynamics365Constants.KeyName.ClientId, ConfigurationManager.AppSettings.GetValue<string>("Providers.Dynamics365ClientId", "cca0f097-58ec-4412-b975-43150326e34d"));
            ClientSecret = configuration.GetValue(Dynamics365Constants.KeyName.ClientSecret, ConfigurationManager.AppSettings.GetValue<string>("Providers.Dynamics365ClientSecret", "4w12-_3.rL0ezV2Y~F9Yg3g.CK9Cr1.gqh"));
            APIVersion = configuration.GetValue(Dynamics365Constants.KeyName.APIVersion, "9.1");
            if (Url != null)
            {
                BaseUrl = string.Format("{0}/api/data/v{1}/", Url, APIVersion);
            }
        }

        public string ApiKey { get; set; }

        public string Url { get; set; }

        public bool DeltaCrawlEnabled { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string APIVersion { get; set; }

        public string BaseUrl { get; set; }
    }
}
