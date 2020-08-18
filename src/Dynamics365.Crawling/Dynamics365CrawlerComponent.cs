using CluedIn.Core;
using CluedIn.Crawling.Dynamics365.Core;

using ComponentHost;

namespace CluedIn.Crawling.Dynamics365
{
    [Component(Dynamics365Constants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class Dynamics365CrawlerComponent : CrawlerComponentBase
    {
        public Dynamics365CrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

