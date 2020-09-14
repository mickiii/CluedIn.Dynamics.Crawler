using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class RollupJobVocabulary : SimpleVocabulary
    {
        public RollupJobVocabulary()
        {
            VocabularyName = "Dynamics365 RollupJob";
            KeyPrefix = "dynamics365.rollupjob";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("RollupJob", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey RollupJobId { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey RollupPropertiesId { get; private set; }

        public VocabularyKey PostponeUntil { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey RetryCount { get; private set; }

        public VocabularyKey SourceEntityTypeCode { get; private set; }

        public VocabularyKey RecordCreatedOn { get; private set; }

        public VocabularyKey DepthProcessed { get; private set; }


    }
}

