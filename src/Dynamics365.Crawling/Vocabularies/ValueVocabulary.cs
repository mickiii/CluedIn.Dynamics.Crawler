using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ValueVocabulary : SimpleVocabulary
    {
        public ValueVocabulary()
        {
            VocabularyName = "Dynamics365 Value"; // TODO: Set value
            KeyPrefix = "dynamics365.value"; // TODO: Set value
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            AddGroup("Dynamics365 Value Details", group =>
            {
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey Name { get; internal set; }
    }
}
