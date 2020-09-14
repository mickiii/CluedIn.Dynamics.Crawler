using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class NavigationSetting : DynamicsModel
    {
        [JsonProperty("navigationsettingid")]
        public Guid? NavigationSettingId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("resourceid")]
        public Guid? ResourceId { get; set; }

        [JsonProperty("pageurl")]
        public string PageUrl { get; set; }

        [JsonProperty("quicksettingorder")]
        public long? QuickSettingOrder { get; set; }

        [JsonProperty("settingtype")]
        public string SettingType { get; set; }

        [JsonProperty("groupname")]
        public string GroupName { get; set; }

        [JsonProperty("parentnavigationsettingid")]
        public Guid? ParentNavigationSettingId { get; set; }

        [JsonProperty("appconfigid")]
        public string AppConfigId { get; set; }

        [JsonProperty("progressstate")]
        public bool? ProgressState { get; set; }

        [JsonProperty("progressstatename")]
        public string ProgressStateName { get; set; }

        [JsonProperty("privileges")]
        public long? Privileges { get; set; }

        [JsonProperty("objecttypecode")]
        public long? ObjectTypeCode { get; set; }

        [JsonProperty("appconfigidunique")]
        public Guid? AppConfigIdUnique { get; set; }

        [JsonProperty("grouptypename")]
        public string GroupTypeName { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("navigationsettingidunique")]
        public Guid? NavigationSettingIdUnique { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("iconresourceid")]
        public Guid? IconResourceId { get; set; }

        [JsonProperty("advancedsettingorder")]
        public long? AdvancedSettingOrder { get; set; }


    }
}

