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

            int? top = null; //set to null if you're not testing

            foreach (var item in client.GetList<Account>("accounts", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<AccountLead>("accountleadscollection", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<ActivityParty>("activityparties", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<ActivityPointer>("activitypointers", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<Appointment>("appointments", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<CampaignActivity>("campaignactivities", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<CampaignItem>("campaignitems", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<Contact>("contacts", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<ContactLead>("contactleadscollection", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<CustomerAddress>("customeraddresses", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<Lead>("leads", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<LeadAddress>("leadaddresses", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<Opportunity>("opportunities", top).Result?.Value)
            {
                yield return item;
            }

            foreach (var item in client.GetList<Task>("tasks", top).Result?.Value)
            {
                yield return item;
            }

            //foreach (var item in client.GetList<EntityDefinition>("EntityDefinitions?$expand=Attributes")?.Result?.Value)
            //{
            //    var relationships = client.GetList<RelationshipDefinition>
            //        (
            //        "RelationshipDefinitions/Microsoft.Dynamics.CRM.OneToManyRelationshipMetadata",
            //        null,
            //        null,
            //        string.Format("ReferencingEntity eq '{0}'", item.LogicalName),
            //        null
            //        )?.Result?.Value;

            //    if (item.LogicalCollectionName != null)
            //    {
            //        var entities = client.GetList<DynamicsModel>(item.LogicalCollectionName, top).Result;
            //        if (entities == null || entities.Value == null)
            //            continue;
            //        foreach (var entity in entities.Value)
            //        {
            //            entity.EntityDefinition = item;
            //            if (entity.Custom.FirstOrDefault(custom => custom.Key == entity.EntityDefinition.PrimaryIdAttribute).Value != null)
            //            {
            //                entity.RelationshipDefinitions = relationships?.Where(r => r.ReferencingEntity == item.SchemaName)?.ToList();
            //            }
            //            if (entity.Custom.FirstOrDefault(custom => custom.Key == entity.EntityDefinition.PrimaryIdAttribute).Value != null)
            //                yield return entity;
            //        }
            //    }
            //}
        }

    }
}
