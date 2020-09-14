using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SystemUserManagerMapVocabulary : SimpleVocabulary
    {
        public SystemUserManagerMapVocabulary()
        {
            VocabularyName = "Dynamics365 SystemUserManagerMap";
            KeyPrefix = "dynamics365.systemusermanagermap";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SystemUserManagerMap", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey SystemUserManagerMapId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ParentSystemUserId { get; private set; }

        public VocabularyKey SystemUserId { get; private set; }

        public VocabularyKey HierarchyLevel { get; private set; }


    }
}

