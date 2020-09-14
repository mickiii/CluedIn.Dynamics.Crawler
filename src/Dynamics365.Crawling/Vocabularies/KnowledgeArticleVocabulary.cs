using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class KnowledgeArticleVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleVocabulary()
        {
            VocabularyName = "Dynamics365 KnowledgeArticle";
            KeyPrefix = "dynamics365.knowledgearticle";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("KnowledgeArticle", group =>
            {
                this.knowledgearticleId = group.Add(new VocabularyKey("knowledgearticleId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("Knowledge Article")
                    .ModelProperty("knowledgearticleid", typeof(Guid)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who modified the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the record.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the record.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

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

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

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

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the user or team who owns the record.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Owner Id Type")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the owner")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Yomi name of the owner")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the business unit that owns the record")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the user that owns the record.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the team that owns the record.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the article is a draft or is published, archived, or discarded. Draft articles aren't available externally and can be edited. Published articles are available externally, based on applicable permissions, but can't be edited. All metadata changes are reflected in the published version. Archived and discarded articles aren't available externally and can't be edited.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the article's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Sequence number of the import that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.processid = group.Add(new VocabularyKey("processid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the id of the process associated with the entity.")
                    .WithDisplayName("Process Id")
                    .ModelProperty("processid", typeof(Guid)));

                this.stageid = group.Add(new VocabularyKey("stageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the id of the stage where the entity is located.")
                    .WithDisplayName("Stage Id")
                    .ModelProperty("stageid", typeof(Guid)));

                this.traversedpath = group.Add(new VocabularyKey("traversedpath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.")
                    .WithDisplayName("(Deprecated) Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.")
                    .WithDisplayName("ExchangeRate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4000))
                    .WithDescription(@"Type a title for the article.")
                    .WithDisplayName("Title")
                    .ModelProperty("title", typeof(string)));

                this.Content = group.Add(new VocabularyKey("Content", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Shows the body of the article stored in HTML format.")
                    .WithDisplayName("Content")
                    .ModelProperty("content", typeof(string)));

                this.Keywords = group.Add(new VocabularyKey("Keywords", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4000))
                    .WithDescription(@"Type keywords to be used for searches in knowledge base articles. Separate keywords by using commas.")
                    .WithDisplayName("Keywords")
                    .ModelProperty("keywords", typeof(string)));

                this.PublishOn = group.Add(new VocabularyKey("PublishOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Date and time when the record was published.")
                    .WithDisplayName("Publish On")
                    .ModelProperty("publishon", typeof(DateTime)));

                this.ExpirationDate = group.Add(new VocabularyKey("ExpirationDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter an expiration date for the article. Leave this field blank for no expiration date.")
                    .WithDisplayName("Expiration Date")
                    .ModelProperty("expirationdate", typeof(DateTime)));

                this.ParentArticleContentIdName = group.Add(new VocabularyKey("ParentArticleContentIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(500))
                    .WithDescription(@"")
                    .WithDisplayName("ParentArticleContentIdName")
                    .ModelProperty("parentarticlecontentidname", typeof(string)));

                this.ParentArticleContentId = group.Add(new VocabularyKey("ParentArticleContentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the id of the parent article content associated with the entity.")
                    .WithDisplayName("Parent Article Content Id")
                    .ModelProperty("parentarticlecontentid", typeof(string)));

                this.KnowledgeArticleViews = group.Add(new VocabularyKey("KnowledgeArticleViews", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the total number of article views.")
                    .WithDisplayName("Knowledge Article Views")
                    .ModelProperty("knowledgearticleviews", typeof(long)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(155))
                    .WithDescription(@"A short overview of the article, primarily used in search results and for search engine optimization.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.MajorVersionNumber = group.Add(new VocabularyKey("MajorVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the major version number of this article's content.")
                    .WithDisplayName("Major Version Number")
                    .ModelProperty("majorversionnumber", typeof(long)));

                this.MinorVersionNumber = group.Add(new VocabularyKey("MinorVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the minor version number of this article's content.")
                    .WithDisplayName("Minor Version Number")
                    .ModelProperty("minorversionnumber", typeof(long)));

                this.LanguageLocaleId = group.Add(new VocabularyKey("LanguageLocaleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the language that the article's content is in.")
                    .WithDisplayName("Language")
                    .ModelProperty("languagelocaleid", typeof(string)));

                this.LanguageLocaleIdName = group.Add(new VocabularyKey("LanguageLocaleIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(500))
                    .WithDescription(@"")
                    .WithDisplayName("LanguageLocaleIdName")
                    .ModelProperty("languagelocaleidname", typeof(string)));

                this.ScheduledStatusId = group.Add(new VocabularyKey("ScheduledStatusId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the id of the scheduled status of the entity.")
                    .WithDisplayName("Scheduled Status")
                    .ModelProperty("scheduledstatusid", typeof(long)));

                this.ExpirationStatusId = group.Add(new VocabularyKey("ExpirationStatusId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the id of the expiration status of the entity.")
                    .WithDisplayName("Expired Status")
                    .ModelProperty("expirationstatusid", typeof(long)));

                this.PublishStatusId = group.Add(new VocabularyKey("PublishStatusId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Publish Status of the Article.")
                    .WithDisplayName("Published Status")
                    .ModelProperty("publishstatusid", typeof(long)));

                this.IsPrimaryName = group.Add(new VocabularyKey("IsPrimaryName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPrimaryName")
                    .ModelProperty("isprimaryname", typeof(string)));

                this.LanguageLocaleIdLocaleId = group.Add(new VocabularyKey("LanguageLocaleIdLocaleId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LanguageLocaleIdLocaleId")
                    .ModelProperty("languagelocaleidlocaleid", typeof(long)));

                this.IsPrimary = group.Add(new VocabularyKey("IsPrimary", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the article is the primary article.")
                    .WithDisplayName("Primary Article")
                    .ModelProperty("isprimary", typeof(bool)));

                this.ReadyForReview = group.Add(new VocabularyKey("ReadyForReview", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Ready For Review")
                    .WithDisplayName("Ready For Review")
                    .ModelProperty("readyforreview", typeof(bool)));

                this.isReadyForReview = group.Add(new VocabularyKey("isReadyForReview", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("isReadyForReview")
                    .ModelProperty("isreadyforreview", typeof(string)));

                this.Review = group.Add(new VocabularyKey("Review", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Review")
                    .WithDisplayName("Review")
                    .ModelProperty("review", typeof(string)));

                this.isReview = group.Add(new VocabularyKey("isReview", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("isReview")
                    .ModelProperty("isreview", typeof(string)));

                this.UpdateContent = group.Add(new VocabularyKey("UpdateContent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Update Content")
                    .WithDisplayName("Update Content")
                    .ModelProperty("updatecontent", typeof(bool)));

                this.isUpdateContent = group.Add(new VocabularyKey("isUpdateContent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("isUpdateContent")
                    .ModelProperty("isupdatecontent", typeof(string)));

                this.SetProductAssociations = group.Add(new VocabularyKey("SetProductAssociations", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Set Product Associations")
                    .WithDisplayName("Set Product Associations")
                    .ModelProperty("setproductassociations", typeof(bool)));

                this.isProductAssociations = group.Add(new VocabularyKey("isProductAssociations", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("isProductAssociations")
                    .ModelProperty("isproductassociations", typeof(string)));

                this.ExpiredReviewOptions = group.Add(new VocabularyKey("ExpiredReviewOptions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Expired Review Options")
                    .WithDisplayName("Expired Review Options")
                    .ModelProperty("expiredreviewoptions", typeof(string)));

                this.isExpiredReviewOptions = group.Add(new VocabularyKey("isExpiredReviewOptions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("isExpiredReviewOptions")
                    .ModelProperty("isexpiredreviewoptions", typeof(string)));

                this.SubjectId = group.Add(new VocabularyKey("SubjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the subject of the article to assist with article searches. You can configure subjects under Business Management in the Settings area.")
                    .WithDisplayName("Subject")
                    .ModelProperty("subjectid", typeof(string)));

                this.SubjectIdDsc = group.Add(new VocabularyKey("SubjectIdDsc", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SubjectIdDsc")
                    .ModelProperty("subjectiddsc", typeof(long)));

                this.SubjectIdName = group.Add(new VocabularyKey("SubjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SubjectIdName")
                    .ModelProperty("subjectidname", typeof(string)));

                this.primaryauthorid = group.Add(new VocabularyKey("primaryauthorid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the id of the primary author associated with the article.")
                    .WithDisplayName("Primary Author Id")
                    .ModelProperty("primaryauthorid", typeof(string)));

                this.primaryauthoridName = group.Add(new VocabularyKey("primaryauthoridName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("primaryauthoridName")
                    .ModelProperty("primaryauthoridname", typeof(string)));

                this.IsRootArticle = group.Add(new VocabularyKey("IsRootArticle", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select whether the article is the root article.")
                    .WithDisplayName("Root Article")
                    .ModelProperty("isrootarticle", typeof(bool)));

                this.IsRootArticleName = group.Add(new VocabularyKey("IsRootArticleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsRootArticleName")
                    .ModelProperty("isrootarticlename", typeof(string)));

                this.PreviousArticleContentId = group.Add(new VocabularyKey("PreviousArticleContentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the version that the current article was restored from.")
                    .WithDisplayName("Previous Article Content ID")
                    .ModelProperty("previousarticlecontentid", typeof(string)));

                this.PreviousArticleContentIdName = group.Add(new VocabularyKey("PreviousArticleContentIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PreviousArticleContentIdName")
                    .ModelProperty("previousarticlecontentidname", typeof(string)));

                this.ArticlePublicNumber = group.Add(new VocabularyKey("ArticlePublicNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(4000))
                    .WithDescription(@"Shows the automatically generated ID exposed to customers, partners, and other external users to reference and look up articles.")
                    .WithDisplayName("Article Public Number")
                    .ModelProperty("articlepublicnumber", typeof(string)));

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

                this.RootArticleId = group.Add(new VocabularyKey("RootArticleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the id of the root article.")
                    .WithDisplayName("Root Article Id")
                    .ModelProperty("rootarticleid", typeof(string)));

                this.RootArticleIdName = group.Add(new VocabularyKey("RootArticleIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RootArticleIdName")
                    .ModelProperty("rootarticleidname", typeof(string)));

                this.KnowledgeArticleViews_Date = group.Add(new VocabularyKey("KnowledgeArticleViews_Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The date time for Knowledge Article View.")
                    .WithDisplayName("Knowledge Article View(Last Updated Time)")
                    .ModelProperty("knowledgearticleviews_date", typeof(DateTime)));

                this.KnowledgeArticleViews_State = group.Add(new VocabularyKey("KnowledgeArticleViews_State", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"State of Knowledge Article View.")
                    .WithDisplayName("Knowledge Article View(State)")
                    .ModelProperty("knowledgearticleviews_state", typeof(long)));

                this.Rating = group.Add(new VocabularyKey("Rating", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information which specifies how helpful the related record was.")
                    .WithDisplayName("Rating")
                    .ModelProperty("rating", typeof(decimal)));

                this.Rating_Date = group.Add(new VocabularyKey("Rating_Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The date time for Rating.")
                    .WithDisplayName("Rating(Last Updated Time)")
                    .ModelProperty("rating_date", typeof(DateTime)));

                this.Rating_State = group.Add(new VocabularyKey("Rating_State", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"State of Rating")
                    .WithDisplayName("Rating(State)")
                    .ModelProperty("rating_state", typeof(long)));

                this.Rating_Sum = group.Add(new VocabularyKey("Rating_Sum", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Total sum of Rating")
                    .WithDisplayName("Rating(sum)")
                    .ModelProperty("rating_sum", typeof(decimal)));

                this.Rating_Count = group.Add(new VocabularyKey("Rating_Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Rating Count")
                    .WithDisplayName("Rating(Count)")
                    .ModelProperty("rating_count", typeof(long)));

                this.IsInternal = group.Add(new VocabularyKey("IsInternal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether this article is only visible internally.")
                    .WithDisplayName("Internal")
                    .ModelProperty("isinternal", typeof(bool)));

                this.IsInternalName = group.Add(new VocabularyKey("IsInternalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsInternalName")
                    .ModelProperty("isinternalname", typeof(string)));

                this.SetCategoryAssociations = group.Add(new VocabularyKey("SetCategoryAssociations", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether category associations have been set")
                    .WithDisplayName("Set Category Associations")
                    .ModelProperty("setcategoryassociations", typeof(bool)));

                this.SetCategoryAssociationsName = group.Add(new VocabularyKey("SetCategoryAssociationsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SetCategoryAssociationsName")
                    .ModelProperty("setcategoryassociationsname", typeof(string)));

                this.ExpirationStateId = group.Add(new VocabularyKey("ExpirationStateId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the id of the expiration state of the entity.")
                    .WithDisplayName("Expiration State Id")
                    .ModelProperty("expirationstateid", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey knowledgearticleId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey processid { get; private set; }

        public VocabularyKey stageid { get; private set; }

        public VocabularyKey traversedpath { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey Title { get; private set; }

        public VocabularyKey Content { get; private set; }

        public VocabularyKey Keywords { get; private set; }

        public VocabularyKey PublishOn { get; private set; }

        public VocabularyKey ExpirationDate { get; private set; }

        public VocabularyKey ParentArticleContentIdName { get; private set; }

        public VocabularyKey ParentArticleContentId { get; private set; }

        public VocabularyKey KnowledgeArticleViews { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey MajorVersionNumber { get; private set; }

        public VocabularyKey MinorVersionNumber { get; private set; }

        public VocabularyKey LanguageLocaleId { get; private set; }

        public VocabularyKey LanguageLocaleIdName { get; private set; }

        public VocabularyKey ScheduledStatusId { get; private set; }

        public VocabularyKey ExpirationStatusId { get; private set; }

        public VocabularyKey PublishStatusId { get; private set; }

        public VocabularyKey IsPrimaryName { get; private set; }

        public VocabularyKey LanguageLocaleIdLocaleId { get; private set; }

        public VocabularyKey IsPrimary { get; private set; }

        public VocabularyKey ReadyForReview { get; private set; }

        public VocabularyKey isReadyForReview { get; private set; }

        public VocabularyKey Review { get; private set; }

        public VocabularyKey isReview { get; private set; }

        public VocabularyKey UpdateContent { get; private set; }

        public VocabularyKey isUpdateContent { get; private set; }

        public VocabularyKey SetProductAssociations { get; private set; }

        public VocabularyKey isProductAssociations { get; private set; }

        public VocabularyKey ExpiredReviewOptions { get; private set; }

        public VocabularyKey isExpiredReviewOptions { get; private set; }

        public VocabularyKey SubjectId { get; private set; }

        public VocabularyKey SubjectIdDsc { get; private set; }

        public VocabularyKey SubjectIdName { get; private set; }

        public VocabularyKey primaryauthorid { get; private set; }

        public VocabularyKey primaryauthoridName { get; private set; }

        public VocabularyKey IsRootArticle { get; private set; }

        public VocabularyKey IsRootArticleName { get; private set; }

        public VocabularyKey PreviousArticleContentId { get; private set; }

        public VocabularyKey PreviousArticleContentIdName { get; private set; }

        public VocabularyKey ArticlePublicNumber { get; private set; }

        public VocabularyKey IsLatestVersion { get; private set; }

        public VocabularyKey IsLatestVersionName { get; private set; }

        public VocabularyKey RootArticleId { get; private set; }

        public VocabularyKey RootArticleIdName { get; private set; }

        public VocabularyKey KnowledgeArticleViews_Date { get; private set; }

        public VocabularyKey KnowledgeArticleViews_State { get; private set; }

        public VocabularyKey Rating { get; private set; }

        public VocabularyKey Rating_Date { get; private set; }

        public VocabularyKey Rating_State { get; private set; }

        public VocabularyKey Rating_Sum { get; private set; }

        public VocabularyKey Rating_Count { get; private set; }

        public VocabularyKey IsInternal { get; private set; }

        public VocabularyKey IsInternalName { get; private set; }

        public VocabularyKey SetCategoryAssociations { get; private set; }

        public VocabularyKey SetCategoryAssociationsName { get; private set; }

        public VocabularyKey ExpirationStateId { get; private set; }


    }
}

