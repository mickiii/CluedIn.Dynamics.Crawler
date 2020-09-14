using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SavedQuery : DynamicsModel
    {
        [JsonProperty("savedqueryid")]
        public Guid? SavedQueryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("querytype")]
        public long? QueryType { get; set; }

        [JsonProperty("isdefault")]
        public bool? IsDefault { get; set; }

        [JsonProperty("returnedtypecode")]
        public string ReturnedTypeCode { get; set; }

        [JsonProperty("queryappusage")]
        public long? QueryAppUsage { get; set; }

        [JsonProperty("isuserdefined")]
        public bool? IsUserDefined { get; set; }

        [JsonProperty("fetchxml")]
        public string FetchXml { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }

        [JsonProperty("isquickfindquery")]
        public bool? IsQuickFindQuery { get; set; }

        [JsonProperty("columnsetxml")]
        public string ColumnSetXml { get; set; }

        [JsonProperty("layoutxml")]
        public string LayoutXml { get; set; }

        [JsonProperty("queryapi")]
        public string QueryAPI { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("isquickfindqueryname")]
        public string IsQuickFindQueryName { get; set; }

        [JsonProperty("isdefaultname")]
        public string IsDefaultName { get; set; }

        [JsonProperty("isuserdefinedname")]
        public string IsUserDefinedName { get; set; }

        [JsonProperty("iscustomizablename")]
        public string IsCustomizableName { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("offlinesqlquery")]
        public string OfflineSqlQuery { get; set; }

        [JsonProperty("isprivate")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("savedqueryidunique")]
        public Guid? SavedQueryIdUnique { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

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

        [JsonProperty("advancedgroupby")]
        public string AdvancedGroupBy { get; set; }

        [JsonProperty("conditionalformatting")]
        public string ConditionalFormatting { get; set; }

        [JsonProperty("organizationtaborder")]
        public long? OrganizationTabOrder { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("canbedeleted")]
        public string CanBeDeleted { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("iscustom")]
        public bool? IsCustom { get; set; }

        [JsonProperty("layoutjson")]
        public string LayoutJson { get; set; }


    }
}

