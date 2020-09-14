using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ComplexControl : DynamicsModel
    {
        [JsonProperty("complexcontrolidunique")]
        public Guid? ComplexControlIdUnique { get; set; }

        [JsonProperty("complexcontrolid")]
        public Guid? ComplexControlId { get; set; }

        [JsonProperty("complexcontrolxml")]
        public string ComplexControlXml { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typename")]
        public string TypeName { get; set; }

        [JsonProperty("version")]
        public long? Version { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }


    }
}

