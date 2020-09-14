using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class TimeStampDateMappingVocabulary : SimpleVocabulary
    {
        public TimeStampDateMappingVocabulary()
        {
            VocabularyName = "Dynamics365 TimeStampDateMapping";
            KeyPrefix = "dynamics365.timestampdatemapping";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("TimeStampDateMapping", group =>
            {

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey TimeStampDateMappingId { get; private set; }

        public VocabularyKey TimeStamp { get; private set; }

        public VocabularyKey Date { get; private set; }


    }
}

