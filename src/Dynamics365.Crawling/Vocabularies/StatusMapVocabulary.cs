using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class StatusMapVocabulary : SimpleVocabulary
    {
        public StatusMapVocabulary()
        {
            VocabularyName = "Dynamics365 StatusMap";
            KeyPrefix = "dynamics365.statusmap";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("StatusMap", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey State { get; private set; }

        public VocabularyKey Status { get; private set; }

        public VocabularyKey IsDefault { get; private set; }

        public VocabularyKey IsDefaultName { get; private set; }

        public VocabularyKey ObjectTypeCodeName { get; private set; }

        public VocabularyKey StatusMapId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }


    }
}

