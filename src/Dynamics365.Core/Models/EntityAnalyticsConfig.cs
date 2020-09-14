using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class EntityAnalyticsConfig : DynamicsModel
    {
        [JsonProperty("entityanalyticsconfigid")]
        public Guid? EntityAnalyticsConfigId { get; set; }

        [JsonProperty("componentidunique")]
        public Guid? ComponentIdUnique { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("componentstatename")]
        public string componentstateName { get; set; }

        [JsonProperty("parententitylogicalname")]
        public string ParentEntityLogicalName { get; set; }

        [JsonProperty("parententityid")]
        public string ParentEntityId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("isenabledforadls")]
        public bool? IsEnabledForADLS { get; set; }

        [JsonProperty("isenabledforadlsname")]
        public string isenabledforadlsName { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string ismanagedName { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("parententityidname")]
        public string ParentEntityIdName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }


    }
}

