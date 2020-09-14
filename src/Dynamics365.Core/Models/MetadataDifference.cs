using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class MetadataDifference : DynamicsModel
    {
        [JsonProperty("metadatadifferenceid")]
        public Guid? MetadataDifferenceId { get; set; }

        [JsonProperty("introducedversion")]
        public double? IntroducedVersion { get; set; }

        [JsonProperty("introducedversionstring")]
        public string IntroducedVersionString { get; set; }

        [JsonProperty("differencexml")]
        public string DifferenceXml { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }


    }
}

