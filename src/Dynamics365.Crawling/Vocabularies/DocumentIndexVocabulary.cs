using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DocumentIndexVocabulary : SimpleVocabulary
    {
        public DocumentIndexVocabulary()
        {
            VocabularyName = "Dynamics365 DocumentIndex";
            KeyPrefix = "dynamics365.documentindex";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("DocumentIndex", group =>
            {
                this.DocumentIndexId = group.Add(new VocabularyKey("DocumentIndexId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the indexed article.")
                    .WithDisplayName("Document Index")
                    .ModelProperty("documentindexid", typeof(Guid)));

                this.SubjectId = group.Add(new VocabularyKey("SubjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the subject record selected on the parent knowledge base article. The ID is updated in the search index every time the article is published.")
                    .WithDisplayName("Subject")
                    .ModelProperty("subjectid", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Choose the ID of the organization that the record is associated with.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.IsPublished = group.Add(new VocabularyKey("IsPublished", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Tells whether the parent knowledge base article is published in Microsoft Dynamics 365, so that the keywords and article content are added to the search index.")
                    .WithDisplayName("Is Published")
                    .ModelProperty("ispublished", typeof(bool)));

                this.DocumentTypeCode = group.Add(new VocabularyKey("DocumentTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Document Type ")
                    .ModelProperty("documenttypecode", typeof(string)));

                this.DocumentId = group.Add(new VocabularyKey("DocumentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the parent article for the document index item. The ID links the index to article information such as the article number, title, and keywords.")
                    .WithDisplayName("Document")
                    .ModelProperty("documentid", typeof(string)));

                this.Location = group.Add(new VocabularyKey("Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"For system use only.")
                    .WithDisplayName("Location")
                    .ModelProperty("location", typeof(string)));

                this.Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Type the title of the parent knowledge base article. This is updated in the search index every time the article is published.")
                    .WithDisplayName("Title")
                    .ModelProperty("title", typeof(string)));

                this.Number = group.Add(new VocabularyKey("Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Number")
                    .ModelProperty("number", typeof(string)));

                this.KeyWords = group.Add(new VocabularyKey("KeyWords", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100000))
                    .WithDescription(@"Type the keywords for the article. The keywords are updated in the search index every time the article is published.")
                    .WithDisplayName("Key Words")
                    .ModelProperty("keywords", typeof(string)));

                this.SearchText = group.Add(new VocabularyKey("SearchText", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5242880))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Search Text")
                    .ModelProperty("searchtext", typeof(string)));

                this.IsPublishedName = group.Add(new VocabularyKey("IsPublishedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPublishedName")
                    .ModelProperty("ispublishedname", typeof(string)));

                this.DocumentTypeCodeName = group.Add(new VocabularyKey("DocumentTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DocumentTypeCodeName")
                    .ModelProperty("documenttypecodename", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the indexed article.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the indexed article was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the indexed article was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the indexed article.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the documentindex.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who last modified the documentindex.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.IsLatestVersion = group.Add(new VocabularyKey("IsLatestVersion", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows which version of the knowledge article is the latest version.")
                    .WithDisplayName("Is Latest Version")
                    .ModelProperty("islatestversion", typeof(bool)));

                this.IsLatestVersionName = group.Add(new VocabularyKey("IsLatestVersionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsLatestVersionName")
                    .ModelProperty("islatestversionname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey DocumentIndexId { get; private set; }

        public VocabularyKey SubjectId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey IsPublished { get; private set; }

        public VocabularyKey DocumentTypeCode { get; private set; }

        public VocabularyKey DocumentId { get; private set; }

        public VocabularyKey Location { get; private set; }

        public VocabularyKey Title { get; private set; }

        public VocabularyKey Number { get; private set; }

        public VocabularyKey KeyWords { get; private set; }

        public VocabularyKey SearchText { get; private set; }

        public VocabularyKey IsPublishedName { get; private set; }

        public VocabularyKey DocumentTypeCodeName { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey IsLatestVersion { get; private set; }

        public VocabularyKey IsLatestVersionName { get; private set; }


    }
}

