using System.Collections.Generic;
using System.Linq;
using CluedIn.Core.Crawling;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Infrastructure.Factories;

namespace CluedIn.Crawling.Dynamics365
{
    public class Dynamics365Crawler : ICrawlerDataGenerator
    {
        private readonly IDynamics365ClientFactory clientFactory;
        public Dynamics365Crawler(IDynamics365ClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is Dynamics365CrawlJobData dynamics365crawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(dynamics365crawlJobData);


            foreach (var item in client.GetAsync<Rootobject>("EntityDefinitions").Result?.value)
            {
                var relationships = client.GetAsync<Rootobject<RelationshipDefinition>>(string.Format("RelationshipDefinitions/Microsoft.Dynamics.CRM.OneToManyRelationshipMetadata?$filter=ReferencingEntity eq '{0}'", item.LogicalName)).Result.value;

                foreach (var entity in client.GetAsync<ResultList<DynamicsModel>>(item.LogicalCollectionName).Result?.Value)
                {
                    if (entity.Custom.FirstOrDefault(custom => custom.Key == entity.EntityDefinition.PrimaryIdAttribute).Value != null)
                    {
                        entity.RelationshipDefinitions = relationships.Where(r => r.ReferencingEntity == item.SchemaName).ToList();
                        entity.EntityDefinition = item;
                        yield return entity;
                    } 
                }
            }

            foreach (var obj in  client.GetAsync<ResultList<Account>>("accounts").Result?.Value)
            {
                yield return obj;
            }
        }
    }
}
