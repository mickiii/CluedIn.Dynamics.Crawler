using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Dynamics365;
using CluedIn.Crawling.Dynamics365.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Dynamics365.Unit.Test
{
    public class Dynamics365CrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public Dynamics365CrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IDynamics365ClientFactory>();

            _sut = new Dynamics365Crawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
