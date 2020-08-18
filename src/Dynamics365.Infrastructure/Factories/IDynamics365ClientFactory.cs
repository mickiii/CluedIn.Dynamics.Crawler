using CluedIn.Crawling.Dynamics365.Core;

namespace CluedIn.Crawling.Dynamics365.Infrastructure.Factories
{
    public interface IDynamics365ClientFactory
    {
        Dynamics365Client CreateNew(Dynamics365CrawlJobData dynamics365CrawlJobData);
    }
}
