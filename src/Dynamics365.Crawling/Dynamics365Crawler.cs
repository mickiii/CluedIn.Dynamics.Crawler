using System.Collections.Generic;

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

            foreach (var obj in client.Get<Account>("accounts", dynamics365crawlJobData))
            {
                yield return obj;
            }

            foreach (var obj in client.Get<AccountLead>("accountleadscollection", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<ActivityParty>("activityparties", dynamics365crawlJobData))
            {
                yield return obj;
            }

            foreach (var obj in client.Get<ActivityPointer>("activitypointers", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<Appointment>("appointments", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<CampaignActivity>("campaignactivities", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<CampaignItem>("campaignitems", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<Contact>("contacts", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<ContactLead>("contactleadscollection", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<CustomerAddress>("customeraddresses", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<Lead>("leads", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<LeadAddress>("leadaddresses", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<Opportunity>("opportunities", dynamics365crawlJobData))
            {
                yield return obj;
            }
            
            foreach (var obj in client.Get<Task>("tasks", dynamics365crawlJobData))
            {
                yield return obj;
            }

        }
    }
}
