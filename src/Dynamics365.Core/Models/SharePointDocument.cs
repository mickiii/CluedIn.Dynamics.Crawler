using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SharePointDocument : DynamicsModel
    {
        [JsonProperty("absoluteurl")]
        public string AbsoluteUrl { get; set; }

        [JsonProperty("appcreatedby")]
        public string AppCreatedBy { get; set; }

        [JsonProperty("appmodifiedby")]
        public string AppModifiedBy { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("businessunitid")]
        public string BusinessUnitId { get; set; }

        [JsonProperty("businessunitidname")]
        public string BusinessUnitIdName { get; set; }

        [JsonProperty("checkedoutto")]
        public string CheckedOutTo { get; set; }

        [JsonProperty("checkincomment")]
        public string CheckInComment { get; set; }

        [JsonProperty("contenttype")]
        public string ContentType { get; set; }

        [JsonProperty("contenttypeid")]
        public long? ContentTypeId { get; set; }

        [JsonProperty("copysource")]
        public string CopySource { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("documentid")]
        public long? DocumentId { get; set; }

        [JsonProperty("editurl")]
        public string EditUrl { get; set; }

        [JsonProperty("edit")]
        public string Edit { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("filesize")]
        public long? FileSize { get; set; }

        [JsonProperty("filetype")]
        public string FileType { get; set; }

        [JsonProperty("childfoldercount")]
        public long? ChildFolderCount { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("ischeckedout")]
        public bool? IsCheckedOut { get; set; }

        [JsonProperty("isfolder")]
        public bool? IsFolder { get; set; }

        [JsonProperty("childitemcount")]
        public long? ChildItemCount { get; set; }

        [JsonProperty("modified")]
        public DateTimeOffset? Modified { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("readurl")]
        public string ReadUrl { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("sharepointcreatedon")]
        public DateTimeOffset? SharePointCreatedOn { get; set; }

        [JsonProperty("sharepointdocumentid")]
        public Guid? SharePointDocumentId { get; set; }

        [JsonProperty("locationid")]
        public string LocationId { get; set; }

        [JsonProperty("sharepointmodifiedby")]
        public string SharePointModifiedBy { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("relativelocation")]
        public string RelativeLocation { get; set; }

        [JsonProperty("documentlocationtype")]
        public string DocumentLocationType { get; set; }

        [JsonProperty("documentlocationtypename")]
        public string DocumentLocationTypeName { get; set; }

        [JsonProperty("isrecursivefetch")]
        public bool? IsRecursiveFetch { get; set; }

        [JsonProperty("servicetype")]
        public string ServiceType { get; set; }

        [JsonProperty("servicetypename")]
        public string ServiceTypeName { get; set; }

        [JsonProperty("iconclassname")]
        public string IconClassName { get; set; }

        [JsonProperty("locationname")]
        public string LocationName { get; set; }


    }
}

