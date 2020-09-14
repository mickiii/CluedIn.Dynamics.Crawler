using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SolutionHistoryData : DynamicsModel
    {
        [JsonProperty("solutionhistorydataid")]
        public Guid? SolutionHistoryDataId { get; set; }

        [JsonProperty("starttime")]
        public DateTimeOffset? StartTime { get; set; }

        [JsonProperty("endtime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("operation")]
        public string Operation { get; set; }

        [JsonProperty("suboperation")]
        public string SubOperation { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("solutionname")]
        public string SolutionName { get; set; }

        [JsonProperty("solutionversion")]
        public string SolutionVersion { get; set; }

        [JsonProperty("result")]
        public long? Result { get; set; }

        [JsonProperty("errorcode")]
        public long? ErrorCode { get; set; }

        [JsonProperty("exceptionmessage")]
        public string ExceptionMessage { get; set; }

        [JsonProperty("exceptionstack")]
        public string ExceptionStack { get; set; }

        [JsonProperty("activityid")]
        public Guid? ActivityId { get; set; }

        [JsonProperty("correlationid")]
        public Guid? CorrelationId { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ispatch")]
        public bool? IsPatch { get; set; }

        [JsonProperty("isoverwritecustomizations")]
        public bool? IsOverwriteCustomizations { get; set; }

        [JsonProperty("ismicrosoftpublisher")]
        public bool? IsMicrosoftPublisher { get; set; }

        [JsonProperty("publishername")]
        public string PublisherName { get; set; }

        [JsonProperty("packagename")]
        public string PackageName { get; set; }

        [JsonProperty("packageversion")]
        public string PackageVersion { get; set; }


    }
}

