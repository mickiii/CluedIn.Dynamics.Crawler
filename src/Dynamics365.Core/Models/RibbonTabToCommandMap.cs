using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RibbonTabToCommandMap : DynamicsModel
    {
        [JsonProperty("tabid")]
        public string TabId { get; set; }

        [JsonProperty("ribbontabtocommandmapuniqueid")]
        public Guid? RibbonTabToCommandMapUniqueId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("controlid")]
        public string ControlId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("ribbontabtocommandmapid")]
        public Guid? RibbonTabToCommandMapId { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("ribbondiffid")]
        public string RibbonDiffId { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }


    }
}

