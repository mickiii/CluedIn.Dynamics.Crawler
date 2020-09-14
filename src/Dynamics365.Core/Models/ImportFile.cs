using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ImportFile : DynamicsModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isfirstrowheader")]
        public bool? IsFirstRowHeader { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("successcount")]
        public long? SuccessCount { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("additionalheaderrow")]
        public string AdditionalHeaderRow { get; set; }

        [JsonProperty("processcode")]
        public string ProcessCode { get; set; }

        [JsonProperty("parsedtablecolumnsnumber")]
        public long? ParsedTableColumnsNumber { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("recordsownerid")]
        public string RecordsOwnerId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("sourceentityname")]
        public string SourceEntityName { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("parsedtablecolumnprefix")]
        public string ParsedTableColumnPrefix { get; set; }

        [JsonProperty("parsedtablename")]
        public string ParsedTableName { get; set; }

        [JsonProperty("progresscounter")]
        public long? ProgressCounter { get; set; }

        [JsonProperty("enableduplicatedetection")]
        public bool? EnableDuplicateDetection { get; set; }

        [JsonProperty("importid")]
        public string ImportId { get; set; }

        [JsonProperty("failurecount")]
        public long? FailureCount { get; set; }

        [JsonProperty("fielddelimitercode")]
        public string FieldDelimiterCode { get; set; }

        [JsonProperty("targetentityname")]
        public string TargetEntityName { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("headerrow")]
        public string HeaderRow { get; set; }

        [JsonProperty("completedon")]
        public DateTimeOffset? CompletedOn { get; set; }

        [JsonProperty("datadelimitercode")]
        public string DataDelimiterCode { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("totalcount")]
        public long? TotalCount { get; set; }

        [JsonProperty("processingstatus")]
        public string ProcessingStatus { get; set; }

        [JsonProperty("importfileid")]
        public Guid? ImportFileId { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("importmapid")]
        public string ImportMapId { get; set; }

        [JsonProperty("usesystemmap")]
        public bool? UseSystemMap { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("recordsowneridtype")]
        public string RecordsOwnerIdType { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("recordsowneridname")]
        public string RecordsOwnerIdName { get; set; }

        [JsonProperty("datadelimitername")]
        public string DataDelimiterName { get; set; }

        [JsonProperty("isfirstrowheadername")]
        public string IsFirstRowHeaderName { get; set; }

        [JsonProperty("importmapidname")]
        public string ImportMapIdName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("processcodename")]
        public string ProcessCodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("usesystemmapname")]
        public string UseSystemMapName { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("importidname")]
        public string ImportIdName { get; set; }

        [JsonProperty("processingstatusname")]
        public string ProcessingStatusName { get; set; }

        [JsonProperty("fielddelimitername")]
        public string FieldDelimiterName { get; set; }

        [JsonProperty("enableduplicatedetectionname")]
        public string EnableDuplicateDetectionName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("relatedentitycolumns")]
        public string RelatedEntityColumns { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("filetypecode")]
        public string FileTypeCode { get; set; }

        [JsonProperty("filetypename")]
        public string FileTypeName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("partialfailurecount")]
        public long? PartialFailureCount { get; set; }

        [JsonProperty("upsertmodecode")]
        public string UpsertModeCode { get; set; }

        [JsonProperty("upsertmodename")]
        public string UpsertModeName { get; set; }

        [JsonProperty("entitykeyid")]
        public Guid? EntityKeyId { get; set; }


    }
}

