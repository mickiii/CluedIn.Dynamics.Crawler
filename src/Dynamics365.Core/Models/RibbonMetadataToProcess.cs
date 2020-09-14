using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class RibbonMetadataToProcess : DynamicsModel
    {
        [JsonProperty("ribbonmetadatarowid")]
        public Guid? RibbonMetadataRowId { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("entityname")]
        public string EntityName { get; set; }

        [JsonProperty("status")]
        public long? Status { get; set; }

        [JsonProperty("retrycount")]
        public long? RetryCount { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("processedon")]
        public DateTimeOffset? ProcessedOn { get; set; }

        [JsonProperty("completedon")]
        public DateTimeOffset? CompletedOn { get; set; }

        [JsonProperty("exceptionmessage")]
        public string ExceptionMessage { get; set; }

        [JsonProperty("isdbupdate")]
        public long? IsDbUpdate { get; set; }


    }
}

