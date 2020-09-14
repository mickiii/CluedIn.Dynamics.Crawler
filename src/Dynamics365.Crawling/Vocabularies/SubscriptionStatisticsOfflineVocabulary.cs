using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SubscriptionStatisticsOfflineVocabulary : SimpleVocabulary
    {
        public SubscriptionStatisticsOfflineVocabulary()
        {
            VocabularyName = "Dynamics365 SubscriptionStatisticsOffline";
            KeyPrefix = "dynamics365.subscriptionstatisticsoffline";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SubscriptionStatisticsOffline", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey SubscriptionId { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey FullSyncRequired { get; private set; }


    }
}

