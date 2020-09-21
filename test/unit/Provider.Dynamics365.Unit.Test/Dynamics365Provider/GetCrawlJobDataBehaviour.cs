using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFixture.Xunit2;
using CluedIn.Core.Crawling;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Dynamics365.Core;
using Xunit;

namespace CluedIn.Provider.Dynamics365.Unit.Test.Dynamics365Provider
{
    public class GetCrawlJobDataBehaviour : Dynamics365ProviderTest
    {
        private readonly ProviderUpdateContext _context;

        public GetCrawlJobDataBehaviour()
        {
            _context = null;
        }

        [Theory(Skip = "Throws exception")]
        [InlineAutoData]
        public async Task ReturnsData(Dictionary<string, object> dictionary, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            Assert.NotNull(
                await Sut.GetCrawlJobData(_context, dictionary, organizationId, userId, providerDefinitionId));
        }

        [Theory(Skip = "Throws exception")]
        [InlineAutoData(Dynamics365Constants.KeyName.ApiKey, nameof(Dynamics365CrawlJobData.ApiKey))]
        public async Task InitializesProperties(string key, string propertyName, string sampleValue, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            var dictionary = new Dictionary<string, object>()
            {
                [key] = sampleValue
            };

            var sut = await Sut.GetCrawlJobData(_context, dictionary, organizationId, userId, providerDefinitionId);
            Assert.Equal(sampleValue, sut.GetType().GetProperty(propertyName).GetValue(sut));
        }

        [Theory(Skip = "Throws exception")]
        [InlineAutoData]
        public async Task Dynamics365CrawlJobDataReturned(Dictionary<string, object> dictionary, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            Assert.IsType<CluedIn.Crawling.Dynamics365.Core.Dynamics365CrawlJobData>(
                await Sut.GetCrawlJobData(_context, dictionary, organizationId, userId, providerDefinitionId));
        }
    }
}
