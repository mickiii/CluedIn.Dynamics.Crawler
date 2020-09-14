using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SubscriptionStatisticsOutlookVocabulary : SimpleVocabulary
    {
        public SubscriptionStatisticsOutlookVocabulary()
        {
            VocabularyName = "Dynamics365 SubscriptionStatisticsOutlook";
            KeyPrefix = "dynamics365.subscriptionstatisticsoutlook";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SubscriptionStatisticsOutlook", group =>
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

