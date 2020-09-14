using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DependencyNodeVocabulary : SimpleVocabulary
    {
        public DependencyNodeVocabulary()
        {
            VocabularyName = "Dynamics365 DependencyNode";
            KeyPrefix = "dynamics365.dependencynode";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("DependencyNode", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey DependencyNodeId { get; private set; }

        public VocabularyKey ComponentType { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey BaseSolutionId { get; private set; }

        public VocabularyKey TopSolutionId { get; private set; }

        public VocabularyKey ParentId { get; private set; }

        public VocabularyKey ComponentTypeName { get; private set; }

        public VocabularyKey IsSharedComponent { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }


    }
}

