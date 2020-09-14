using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class MultiSelectAttributeOptionValuesVocabulary : SimpleVocabulary
    {
        public MultiSelectAttributeOptionValuesVocabulary()
        {
            VocabularyName = "Dynamics365 MultiSelectAttributeOptionValues";
            KeyPrefix = "dynamics365.multiselectattributeoptionvalues";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("MultiSelectAttributeOptionValues", group =>
            {
                this.ObjectId = group.Add(new VocabularyKey("ObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Object Id")
                    .WithDisplayName("ObjectId")
                    .ModelProperty("objectid", typeof(string)));

                this.ObjectIdTypeCode = group.Add(new VocabularyKey("ObjectIdTypeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"ObjectId Type Code")
                    .WithDisplayName("ObjectIdTypeCode")
                    .ModelProperty("objectidtypecode", typeof(long)));

                this.ObjectColumnNumber = group.Add(new VocabularyKey("ObjectColumnNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Object Column Number")
                    .WithDisplayName("ObjectColumnNumber")
                    .ModelProperty("objectcolumnnumber", typeof(long)));

                this.SelectedOptionValues = group.Add(new VocabularyKey("SelectedOptionValues", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Multi Select Option Values")
                    .WithDisplayName("SelectedOptionValues")
                    .ModelProperty("selectedoptionvalues", typeof(string)));

                this.MultiSelectFullTextIdKey = group.Add(new VocabularyKey("MultiSelectFullTextIdKey", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MultiSelectFullTextIdKey")
                    .ModelProperty("multiselectfulltextidkey", typeof(int)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey ObjectIdTypeCode { get; private set; }

        public VocabularyKey ObjectColumnNumber { get; private set; }

        public VocabularyKey SelectedOptionValues { get; private set; }

        public VocabularyKey MultiSelectFullTextIdKey { get; private set; }


    }
}

