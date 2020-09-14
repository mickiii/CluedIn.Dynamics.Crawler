using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DisplayStringMapVocabulary : SimpleVocabulary
    {
        public DisplayStringMapVocabulary()
        {
            VocabularyName = "Dynamics365 DisplayStringMap";
            KeyPrefix = "dynamics365.displaystringmap";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("DisplayStringMap", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey DisplayStringMapId { get; private set; }

        public VocabularyKey DisplayStringId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey DisplayStringMapIdUnique { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }


    }
}

