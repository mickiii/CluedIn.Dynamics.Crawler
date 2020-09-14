using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class FilterTemplateVocabulary : SimpleVocabulary
    {
        public FilterTemplateVocabulary()
        {
            VocabularyName = "Dynamics365 FilterTemplate";
            KeyPrefix = "dynamics365.filtertemplate";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("FilterTemplate", group =>
            {
                this.FetchXml = group.Add(new VocabularyKey("FetchXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"String that specifies the filter template in Fetch XML language.")
                    .WithDisplayName("FetchXml")
                    .ModelProperty("fetchxml", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.QueryType = group.Add(new VocabularyKey("QueryType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("QueryType")
                    .ModelProperty("querytype", typeof(long)));

                this.FilterTemplateId = group.Add(new VocabularyKey("FilterTemplateId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the filter template.")
                    .WithDisplayName("FilterTemplateId")
                    .ModelProperty("filtertemplateid", typeof(Guid)));

                this.ReturnedTypeCode = group.Add(new VocabularyKey("ReturnedTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("ReturnedTypeCode")
                    .ModelProperty("returnedtypecode", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the filter template.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey FetchXml { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey QueryType { get; private set; }

        public VocabularyKey FilterTemplateId { get; private set; }

        public VocabularyKey ReturnedTypeCode { get; private set; }

        public VocabularyKey Name { get; private set; }


    }
}

