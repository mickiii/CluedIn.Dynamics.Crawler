using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DependencyVocabulary : SimpleVocabulary
    {
        public DependencyVocabulary()
        {
            VocabularyName = "Dynamics365 Dependency";
            KeyPrefix = "dynamics365.dependency";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Dependency", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey DependencyId { get; private set; }

        public VocabularyKey DependencyType { get; private set; }

        public VocabularyKey RequiredComponentNodeId { get; private set; }

        public VocabularyKey RequiredComponentObjectId { get; private set; }

        public VocabularyKey RequiredComponentType { get; private set; }

        public VocabularyKey RequiredComponentBaseSolutionId { get; private set; }

        public VocabularyKey RequiredComponentParentId { get; private set; }

        public VocabularyKey DependentComponentNodeId { get; private set; }

        public VocabularyKey DependentComponentObjectId { get; private set; }

        public VocabularyKey DependentComponentType { get; private set; }

        public VocabularyKey DependentComponentBaseSolutionId { get; private set; }

        public VocabularyKey DependentComponentParentId { get; private set; }

        public VocabularyKey DependencyTypeName { get; private set; }

        public VocabularyKey RequiredComponentTypeName { get; private set; }

        public VocabularyKey DependentComponentTypeName { get; private set; }

        public VocabularyKey RequiredComponentIntroducedVersion { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }


    }
}

