using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SubscriptionSyncEntryOfflineVocabulary : SimpleVocabulary
    {
        public SubscriptionSyncEntryOfflineVocabulary()
        {
            VocabularyName = "Dynamics365 SubscriptionSyncEntryOffline";
            KeyPrefix = "dynamics365.subscriptionsyncentryoffline";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SubscriptionSyncEntryOffline", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey SubscriptionId { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey SyncState { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }


    }
}
