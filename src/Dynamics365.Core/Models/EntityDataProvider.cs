using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class EntityDataProvider : DynamicsModel
    {
        [JsonProperty("entitydataproviderid")]
        public Guid? EntityDataProviderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("retrieveplugin")]
        public Guid? RetrievePlugin { get; set; }

        [JsonProperty("retrievemultipleplugin")]
        public Guid? RetrieveMultiplePlugin { get; set; }

        [JsonProperty("createplugin")]
        public Guid? CreatePlugin { get; set; }

        [JsonProperty("deleteplugin")]
        public Guid? DeletePlugin { get; set; }

        [JsonProperty("updateplugin")]
        public Guid? UpdatePlugin { get; set; }

        [JsonProperty("datasourcelogicalname")]
        public string DataSourceLogicalName { get; set; }

        [JsonProperty("entitydataprovideridunique")]
        public Guid? EntityDataProviderIdUnique { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }


    }
}

