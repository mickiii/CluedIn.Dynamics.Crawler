using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AppModuleMetadataOperationLogVocabulary : SimpleVocabulary
    {
        public AppModuleMetadataOperationLogVocabulary()
        {
            VocabularyName = "Dynamics365 AppModuleMetadataOperationLog";
            KeyPrefix = "dynamics365.appmodulemetadataoperationlog";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("AppModuleMetadataOperationLog", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey AppModuleMetadataOperationLogId { get; private set; }

        public VocabularyKey AppModuleId { get; private set; }

        public VocabularyKey State { get; private set; }

        public VocabularyKey RetryCount { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey StartedOn { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }


    }
}

