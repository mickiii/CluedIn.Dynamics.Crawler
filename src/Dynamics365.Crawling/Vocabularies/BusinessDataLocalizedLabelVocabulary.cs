using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class BusinessDataLocalizedLabelVocabulary : SimpleVocabulary
    {
        public BusinessDataLocalizedLabelVocabulary()
        {
            VocabularyName = "Dynamics365 BusinessDataLocalizedLabel";
            KeyPrefix = "dynamics365.businessdatalocalizedlabel";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("BusinessDataLocalizedLabel", group =>
            {
                this.BusinessDataLocalizedLabelId = group.Add(new VocabularyKey("BusinessDataLocalizedLabelId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the Business Data Localized Label.")
                    .WithDisplayName("BusinessDataLocalizedLabelId")
                    .ModelProperty("businessdatalocalizedlabelid", typeof(Guid)));

                this.LanguageId = group.Add(new VocabularyKey("LanguageId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Language Id")
                    .WithDisplayName("LanguageId")
                    .ModelProperty("languageid", typeof(long)));

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

                this.ObjectColumnName = group.Add(new VocabularyKey("ObjectColumnName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(128))
                    .WithDescription(@"Object Column Name")
                    .WithDisplayName("ObjectColumnName")
                    .ModelProperty("objectcolumnname", typeof(string)));

                this.ObjectColumnNumber = group.Add(new VocabularyKey("ObjectColumnNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Object Column Number")
                    .WithDisplayName("ObjectColumnNumber")
                    .ModelProperty("objectcolumnnumber", typeof(long)));

                this.Label = group.Add(new VocabularyKey("Label", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(4000))
                    .WithDescription(@"Label")
                    .WithDisplayName("Label")
                    .ModelProperty("label", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey BusinessDataLocalizedLabelId { get; private set; }

        public VocabularyKey LanguageId { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey ObjectIdTypeCode { get; private set; }

        public VocabularyKey ObjectColumnName { get; private set; }

        public VocabularyKey ObjectColumnNumber { get; private set; }

        public VocabularyKey Label { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }


    }
}

