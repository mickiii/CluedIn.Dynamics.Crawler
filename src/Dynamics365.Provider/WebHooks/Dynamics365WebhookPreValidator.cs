using CluedIn.Core.Webhooks;
using CluedIn.Crawling.Dynamics365.Core;

namespace CluedIn.Provider.Dynamics365.WebHooks
{
    public class Name_WebhookPreValidator : BaseWebhookPrevalidator
    {
        public Name_WebhookPreValidator()
            : base(Dynamics365Constants.ProviderId, Dynamics365Constants.ProviderName)
        {
        }
    }
}
