using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RibbonDiff : DynamicsModel
    {
        [JsonProperty("tabid")]
        public string TabId { get; set; }

        [JsonProperty("rdx")]
        public string RDX { get; set; }

        [JsonProperty("contextgroupid")]
        public Guid? ContextGroupId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("ribbondiffuniqueid")]
        public Guid? RibbonDiffUniqueId { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("sequence")]
        public long? Sequence { get; set; }

        [JsonProperty("ribbondiffid")]
        public Guid? RibbonDiffId { get; set; }

        [JsonProperty("difftype")]
        public string DiffType { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("ribboncustomizationid")]
        public string RibbonCustomizationId { get; set; }

        [JsonProperty("diffid")]
        public string DiffId { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("isappaware")]
        public bool? IsAppAware { get; set; }

        [JsonProperty("isappawarename")]
        public string IsAppAwareName { get; set; }


    }
}

