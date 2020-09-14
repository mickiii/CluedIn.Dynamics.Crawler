using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class LanguageProvisioningState : DynamicsModel
    {
        [JsonProperty("languageprovisioningstateid")]
        public Guid? LanguageProvisioningStateId { get; set; }

        [JsonProperty("applicationversion")]
        public string ApplicationVersion { get; set; }

        [JsonProperty("languageid")]
        public long? LanguageId { get; set; }

        [JsonProperty("solutionuniquename")]
        public string SolutionUniqueName { get; set; }

        [JsonProperty("solutionfileversion")]
        public string SolutionFileVersion { get; set; }

        [JsonProperty("provisioningstage")]
        public string ProvisioningStage { get; set; }


    }
}

