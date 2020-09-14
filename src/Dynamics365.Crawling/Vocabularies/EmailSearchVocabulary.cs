using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class EmailSearchVocabulary : SimpleVocabulary
    {
        public EmailSearchVocabulary()
        {
            VocabularyName = "Dynamics365 EmailSearch";
            KeyPrefix = "dynamics365.emailsearch";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("EmailSearch", group =>
            {
                this.EmailSearchId = group.Add(new VocabularyKey("EmailSearchId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the email search entry.")
                    .WithDisplayName("EmailSearchId")
                    .ModelProperty("emailsearchid", typeof(Guid)));

                this.EmailAddress = group.Add(new VocabularyKey("EmailAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The email address")
                    .WithDisplayName("EmailAddress")
                    .ModelProperty("emailaddress", typeof(string)));

                this.EmailColumnNumber = group.Add(new VocabularyKey("EmailColumnNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Email Column Number")
                    .ModelProperty("emailcolumnnumber", typeof(long)));

                this.ParentObjectId = group.Add(new VocabularyKey("ParentObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the parent object with which the email address is associated.")
                    .WithDisplayName("Parent")
                    .ModelProperty("parentobjectid", typeof(string)));

                this.ParentObjectTypeCode = group.Add(new VocabularyKey("ParentObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Parent Object Type")
                    .ModelProperty("parentobjecttypecode", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey EmailSearchId { get; private set; }

        public VocabularyKey EmailAddress { get; private set; }

        public VocabularyKey EmailColumnNumber { get; private set; }

        public VocabularyKey ParentObjectId { get; private set; }

        public VocabularyKey ParentObjectTypeCode { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }


    }
}

