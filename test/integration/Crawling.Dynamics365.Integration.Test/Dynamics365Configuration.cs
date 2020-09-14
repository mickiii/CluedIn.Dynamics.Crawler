using System.Collections.Generic;
using CluedIn.Crawling.Dynamics365.Core;

namespace CluedIn.Crawling.Dynamics365.Integration.Test
{
  public static class Dynamics365Configuration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { Dynamics365Constants.KeyName.ApiKey, "apiKey" },
                { Dynamics365Constants.KeyName.Url, "www.demo.com" },
                { Dynamics365Constants.KeyName.DeltaCrawlEnabled, false },
                { Dynamics365Constants.KeyName.UserName, "username"},
                { Dynamics365Constants.KeyName.Password, "password" },
                { Dynamics365Constants.KeyName.ClientId, "clientId" },
                { Dynamics365Constants.KeyName.ClientSecret, "clientSecret" },
            };
    }
  }
}
