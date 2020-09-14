using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class GlobalSearchConfiguration : DynamicsModel
    {
        [JsonProperty("globalsearchconfigurationid")]
        public Guid? GlobalSearchConfigurationId { get; set; }

        [JsonProperty("searchprovidername")]
        public string SearchProviderName { get; set; }

        [JsonProperty("searchproviderresultspage")]
        public string SearchProviderResultsPage { get; set; }

        [JsonProperty("islocalized")]
        public bool? IsLocalized { get; set; }

        [JsonProperty("isenabled")]
        public bool? IsEnabled { get; set; }

        [JsonProperty("issearchboxvisible")]
        public bool? IsSearchBoxVisible { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("globalsearchconfigurationidunique")]
        public Guid? GlobalSearchConfigurationidUnique { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }


    }
}

