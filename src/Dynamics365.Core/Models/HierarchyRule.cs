using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class HierarchyRule : DynamicsModel
    {
        [JsonProperty("hierarchyruleid")]
        public Guid? HierarchyRuleID { get; set; }

        [JsonProperty("primaryentityformid")]
        public Guid? PrimaryEntityFormID { get; set; }

        [JsonProperty("relatedentityformid")]
        public Guid? RelatedEntityFormId { get; set; }

        [JsonProperty("primaryentitylogicalname")]
        public string PrimaryEntityLogicalName { get; set; }

        [JsonProperty("relatedentitylogicalname")]
        public string RelatedEntityLogicalName { get; set; }

        [JsonProperty("publishedon")]
        public DateTimeOffset? PublishedOn { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("hierarchyruleidunique")]
        public Guid? HierarchyRuleIDUnique { get; set; }

        [JsonProperty("sortby")]
        public Guid? SortBy { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("showdisabled")]
        public bool? ShowDisabled { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }


    }
}

