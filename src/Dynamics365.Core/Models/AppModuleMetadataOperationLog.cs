using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class AppModuleMetadataOperationLog : DynamicsModel
    {
        [JsonProperty("appmodulemetadataoperationlogid")]
        public Guid? AppModuleMetadataOperationLogId { get; set; }

        [JsonProperty("appmoduleid")]
        public Guid? AppModuleId { get; set; }

        [JsonProperty("state")]
        public long? State { get; set; }

        [JsonProperty("retrycount")]
        public long? RetryCount { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("startedon")]
        public DateTimeOffset? StartedOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }


    }
}

