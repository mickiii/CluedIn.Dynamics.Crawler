using CluedIn.Crawling.Dynamics365.Core;

namespace CluedIn.Crawling.Dynamics365
{
    public class Dynamics365CrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<Dynamics365CrawlJobData>
    {
        public Dynamics365CrawlerJobProcessor(Dynamics365CrawlerComponent component) : base(component)
        {
        }
    }
}
