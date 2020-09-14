using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AppModuleMetadataVocabulary : SimpleVocabulary
    {
        public AppModuleMetadataVocabulary()
        {
            VocabularyName = "Dynamics365 AppModuleMetadata";
            KeyPrefix = "dynamics365.appmodulemetadata";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("AppModuleMetadata", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey AppModuleMetadataId { get; private set; }

        public VocabularyKey AppModuleId { get; private set; }

        public VocabularyKey ComponentType { get; private set; }

        public VocabularyKey ComponentSubType { get; private set; }

        public VocabularyKey ComponentId { get; private set; }

        public VocabularyKey ComponentVersion { get; private set; }

        public VocabularyKey ParentComponentId { get; private set; }

        public VocabularyKey State { get; private set; }

        public VocabularyKey ComponentIsDefault { get; private set; }

        public VocabularyKey ComponentIsQuickFindQuery { get; private set; }

        public VocabularyKey ComponentIsUserView { get; private set; }

        public VocabularyKey ComponentIsUserChart { get; private set; }

        public VocabularyKey ComponentIsUserForm { get; private set; }

        public VocabularyKey ComponentIsTabletEnabled { get; private set; }

        public VocabularyKey ComponentStateCode { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }


    }
}

