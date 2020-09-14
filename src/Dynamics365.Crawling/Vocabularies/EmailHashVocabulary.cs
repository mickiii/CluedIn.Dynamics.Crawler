using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class EmailHashVocabulary : SimpleVocabulary
    {
        public EmailHashVocabulary()
        {
            VocabularyName = "Dynamics365 EmailHash";
            KeyPrefix = "dynamics365.emailhash";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("EmailHash", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey HashType { get; private set; }

        public VocabularyKey Hash { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey EmailHashId { get; private set; }

        public VocabularyKey ActivityId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }


    }
}

