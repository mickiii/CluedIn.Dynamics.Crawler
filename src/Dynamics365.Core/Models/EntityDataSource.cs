using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class EntityDataSource : DynamicsModel
    {
        [JsonProperty("entitydatasourceid")]
        public Guid? EntityDataSourceId { get; set; }

        [JsonProperty("entityname")]
        public string EntityName { get; set; }

        [JsonProperty("connectiondefinition")]
        public string ConnectionDefinition { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }

        [JsonProperty("entitydatasourceidunique")]
        public Guid? EntityDataSourceIdUnique { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("connectiondefinitionsecrets")]
        public string ConnectionDefinitionSecrets { get; set; }

        [JsonProperty("entitydataproviderid")]
        public string EntityDataProviderId { get; set; }

        [JsonProperty("entitydataprovideridname")]
        public string EntityDataProviderIdName { get; set; }

        [JsonProperty("iscustomizable")]
        public string IsCustomizable { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }


    }
}

