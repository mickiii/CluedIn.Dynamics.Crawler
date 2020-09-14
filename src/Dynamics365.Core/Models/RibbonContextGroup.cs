using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RibbonContextGroup : DynamicsModel
    {
        [JsonProperty("ribboncontextgroupuniqueid")]
        public Guid? RibbonContextGroupUniqueId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("contextgroupxml")]
        public string ContextGroupXml { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("contextgroupid")]
        public string ContextGroupId { get; set; }

        [JsonProperty("ribboncontextgroupid")]
        public Guid? RibbonContextGroupId { get; set; }

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

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }


    }
}

