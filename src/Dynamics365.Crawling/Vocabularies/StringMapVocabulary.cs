using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class StringMapVocabulary : SimpleVocabulary
    {
        public StringMapVocabulary()
        {
            VocabularyName = "Dynamics365 StringMap";
            KeyPrefix = "dynamics365.stringmap";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("StringMap", group =>
            {
                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ObjectTypeCode")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.AttributeName = group.Add(new VocabularyKey("AttributeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AttributeName")
                    .ModelProperty("attributename", typeof(string)));

                this.AttributeValue = group.Add(new VocabularyKey("AttributeValue", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AttributeValue")
                    .ModelProperty("attributevalue", typeof(long)));

                this.LangId = group.Add(new VocabularyKey("LangId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LangId")
                    .ModelProperty("langid", typeof(long)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(Guid)));

                this.Value = group.Add(new VocabularyKey("Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4000))
                    .WithDescription(@"")
                    .WithDisplayName("Value")
                    .ModelProperty("value", typeof(string)));

                this.DisplayOrder = group.Add(new VocabularyKey("DisplayOrder", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("DisplayOrder")
                    .ModelProperty("displayorder", typeof(long)));

                this.ObjectTypeCodeName = group.Add(new VocabularyKey("ObjectTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ObjectTypeCodeName")
                    .ModelProperty("objecttypecodename", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.StringMapId = group.Add(new VocabularyKey("StringMapId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the string map.")
                    .WithDisplayName("StringMapId")
                    .ModelProperty("stringmapid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey AttributeName { get; private set; }

        public VocabularyKey AttributeValue { get; private set; }

        public VocabularyKey LangId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey Value { get; private set; }

        public VocabularyKey DisplayOrder { get; private set; }

        public VocabularyKey ObjectTypeCodeName { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey StringMapId { get; private set; }


    }
}

