using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Report : DynamicsModel
    {
        [JsonProperty("defaultfilter")]
        public string DefaultFilter { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iscustomreport")]
        public bool? IsCustomReport { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("signaturemajorversion")]
        public long? SignatureMajorVersion { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("bodytext")]
        public string BodyText { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("ispersonal")]
        public bool? IsPersonal { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("signaturelcid")]
        public long? SignatureLcid { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("filesize")]
        public long? FileSize { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("customreportxml")]
        public string CustomReportXml { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schedulexml")]
        public string ScheduleXml { get; set; }

        [JsonProperty("signaturedate")]
        public DateTimeOffset? SignatureDate { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("parentreportid")]
        public string ParentReportId { get; set; }

        [JsonProperty("bodybinary")]
        public string BodyBinary { get; set; }

        [JsonProperty("queryinfo")]
        public string QueryInfo { get; set; }

        [JsonProperty("languagecode")]
        public long? LanguageCode { get; set; }

        [JsonProperty("signatureid")]
        public Guid? SignatureId { get; set; }

        [JsonProperty("bodyurl")]
        public string BodyUrl { get; set; }

        [JsonProperty("mimetype")]
        public string MimeType { get; set; }

        [JsonProperty("signatureminorversion")]
        public long? SignatureMinorVersion { get; set; }

        [JsonProperty("reportid")]
        public Guid? ReportId { get; set; }

        [JsonProperty("isscheduledreport")]
        public bool? IsScheduledReport { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("reporttypecode")]
        public string ReportTypeCode { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("isscheduledreportname")]
        public string IsScheduledReportName { get; set; }

        [JsonProperty("parentreportidname")]
        public string ParentReportIdName { get; set; }

        [JsonProperty("reporttypecodename")]
        public string ReportTypeCodeName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("ispersonalname")]
        public string IsPersonalName { get; set; }

        [JsonProperty("iscustomreportname")]
        public string IsCustomReportName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("reportidunique")]
        public Guid? ReportIdUnique { get; set; }

        [JsonProperty("reportnameonsrs")]
        public string ReportNameOnSRS { get; set; }

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

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("originalbodytext")]
        public string OriginalBodyText { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("createdinmajorversion")]
        public long? CreatedInMajorVersion { get; set; }

        [JsonProperty("rdlhash")]
        public long? RdlHash { get; set; }


    }
}

