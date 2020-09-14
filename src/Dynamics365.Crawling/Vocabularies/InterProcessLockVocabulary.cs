using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class InterProcessLockVocabulary : SimpleVocabulary
    {
        public InterProcessLockVocabulary()
        {
            VocabularyName = "Dynamics365 InterProcessLock";
            KeyPrefix = "dynamics365.interprocesslock";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("InterProcessLock", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey InterProcessLockId { get; private set; }

        public VocabularyKey Token { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }


    }
}

