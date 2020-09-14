using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SubscriptionTrackingDeletedObjectVocabulary : SimpleVocabulary
    {
        public SubscriptionTrackingDeletedObjectVocabulary()
        {
            VocabularyName = "Dynamics365 SubscriptionTrackingDeletedObject";
            KeyPrefix = "dynamics365.subscriptiontrackingdeletedobject";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SubscriptionTrackingDeletedObject", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey TimeStamp { get; private set; }

        public VocabularyKey IsLogicalDelete { get; private set; }

        public VocabularyKey DeleteTime { get; private set; }

        public VocabularyKey CrmCreatedOn { get; private set; }


    }
}

