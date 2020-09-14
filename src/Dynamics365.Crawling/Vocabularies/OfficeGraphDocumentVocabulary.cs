using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class OfficeGraphDocumentVocabulary : SimpleVocabulary
    {
        public OfficeGraphDocumentVocabulary()
        {
            VocabularyName = "Dynamics365 OfficeGraphDocument";
            KeyPrefix = "dynamics365.officegraphdocument";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("OfficeGraphDocument", group =>
            {
                this.OfficeGraphDocumentId = group.Add(new VocabularyKey("OfficeGraphDocumentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("OfficeGraphDocument")
                    .ModelProperty("officegraphdocumentid", typeof(Guid)));

                this.Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The title of the entity.")
                    .WithDisplayName("Title")
                    .ModelProperty("title", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the organization")
                    .WithDisplayName("Organization Id")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Exchange rate for the currency associated with the Office Graph Document with respect to the base currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.PreviewImageUrl = group.Add(new VocabularyKey("PreviewImageUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows the Preview Image Url Office Graph Document.")
                    .WithDisplayName("Preview Image Url")
                    .ModelProperty("previewimageurl", typeof(string)));

                this.FileType = group.Add(new VocabularyKey("FileType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows the File Type of Office Graph Document.")
                    .WithDisplayName("File Type")
                    .ModelProperty("filetype", typeof(string)));

                this.WebLocationUrl = group.Add(new VocabularyKey("WebLocationUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows the Web Location Url of Office Graph Document.")
                    .WithDisplayName("Web Location Url")
                    .ModelProperty("weblocationurl", typeof(string)));

                this.ViewCount = group.Add(new VocabularyKey("ViewCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows View Count of child folders.")
                    .WithDisplayName("View Count")
                    .ModelProperty("viewcount", typeof(long)));

                this.AuthorNames = group.Add(new VocabularyKey("AuthorNames", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows Author Names of Office Graph Document.")
                    .WithDisplayName("Author Names")
                    .ModelProperty("authornames", typeof(string)));

                this.QueryType = group.Add(new VocabularyKey("QueryType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows Query Type of child folders")
                    .WithDisplayName("Query Type")
                    .ModelProperty("querytype", typeof(long)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows Created By of Office Graph Document.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedTime = group.Add(new VocabularyKey("CreatedTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created Time")
                    .ModelProperty("createdtime", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Shows modified by of Office Graph Document.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedTime = group.Add(new VocabularyKey("ModifiedTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was modified.")
                    .WithDisplayName("Modified Time")
                    .ModelProperty("modifiedtime", typeof(DateTime)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the record.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the Office Graph Document with respect to the base currency.")
                    .WithDisplayName("ExchangeRate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the record.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.DocumentId = group.Add(new VocabularyKey("DocumentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Document Id.")
                    .WithDisplayName("Document Id")
                    .ModelProperty("documentid", typeof(string)));

                this.Rank = group.Add(new VocabularyKey("Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The relevancy rank of the document retrieved")
                    .WithDisplayName("Relevancy Rank of the Document")
                    .ModelProperty("rank", typeof(long)));

                this.SiteUrl = group.Add(new VocabularyKey("SiteUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"The site url for the parent document site")
                    .WithDisplayName("Site Url")
                    .ModelProperty("siteurl", typeof(string)));

                this.ReadUrl = group.Add(new VocabularyKey("ReadUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"The online read url")
                    .WithDisplayName("Read Url")
                    .ModelProperty("readurl", typeof(string)));

                this.SiteTitle = group.Add(new VocabularyKey("SiteTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"The title of the parent document site")
                    .WithDisplayName("Parent Site Title")
                    .ModelProperty("sitetitle", typeof(string)));

                this.DocumentLastModifiedBy = group.Add(new VocabularyKey("DocumentLastModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Document Last Modified By")
                    .WithDisplayName("Document Last Modified By")
                    .ModelProperty("documentlastmodifiedby", typeof(string)));

                this.DocumentLastModifiedOn = group.Add(new VocabularyKey("DocumentLastModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Document Last Modified On")
                    .WithDisplayName("Document Last Modified On")
                    .ModelProperty("documentlastmodifiedon", typeof(DateTime)));

                this.FileExtension = group.Add(new VocabularyKey("FileExtension", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"File Extension of Office Graph Document.")
                    .WithDisplayName("File Extension")
                    .ModelProperty("fileextension", typeof(string)));

                this.SecondaryFileExtension = group.Add(new VocabularyKey("SecondaryFileExtension", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Secondary File Extension of Office Graph Document.")
                    .WithDisplayName("Secondary File Extension")
                    .ModelProperty("secondaryfileextension", typeof(string)));

                this.DocumentPreviewMetadata = group.Add(new VocabularyKey("DocumentPreviewMetadata", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"document preview metadata")
                    .WithDisplayName("document preview metadata")
                    .ModelProperty("documentpreviewmetadata", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey OfficeGraphDocumentId { get; private set; }

        public VocabularyKey Title { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey PreviewImageUrl { get; private set; }

        public VocabularyKey FileType { get; private set; }

        public VocabularyKey WebLocationUrl { get; private set; }

        public VocabularyKey ViewCount { get; private set; }

        public VocabularyKey AuthorNames { get; private set; }

        public VocabularyKey QueryType { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedTime { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedTime { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey DocumentId { get; private set; }

        public VocabularyKey Rank { get; private set; }

        public VocabularyKey SiteUrl { get; private set; }

        public VocabularyKey ReadUrl { get; private set; }

        public VocabularyKey SiteTitle { get; private set; }

        public VocabularyKey DocumentLastModifiedBy { get; private set; }

        public VocabularyKey DocumentLastModifiedOn { get; private set; }

        public VocabularyKey FileExtension { get; private set; }

        public VocabularyKey SecondaryFileExtension { get; private set; }

        public VocabularyKey DocumentPreviewMetadata { get; private set; }


    }
}

