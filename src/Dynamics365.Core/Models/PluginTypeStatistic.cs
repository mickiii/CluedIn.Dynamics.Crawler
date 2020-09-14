using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class PluginTypeStatistic : DynamicsModel
    {
        [JsonProperty("plugintypestatisticid")]
        public Guid? PluginTypeStatisticId { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("plugintypeid")]
        public string PluginTypeId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("executecount")]
        public long? ExecuteCount { get; set; }

        [JsonProperty("failurecount")]
        public long? FailureCount { get; set; }

        [JsonProperty("crashcount")]
        public long? CrashCount { get; set; }

        [JsonProperty("failurepercent")]
        public long? FailurePercent { get; set; }

        [JsonProperty("crashpercent")]
        public long? CrashPercent { get; set; }

        [JsonProperty("crashcontributionpercent")]
        public long? CrashContributionPercent { get; set; }

        [JsonProperty("terminatecpucontributionpercent")]
        public long? TerminateCpuContributionPercent { get; set; }

        [JsonProperty("terminatememorycontributionpercent")]
        public long? TerminateMemoryContributionPercent { get; set; }

        [JsonProperty("terminatehandlescontributionpercent")]
        public long? TerminateHandlesContributionPercent { get; set; }

        [JsonProperty("terminateothercontributionpercent")]
        public long? TerminateOtherContributionPercent { get; set; }

        [JsonProperty("averageexecutetimeinmilliseconds")]
        public long? AverageExecuteTimeInMilliseconds { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("plugintypeidname")]
        public string PluginTypeIdName { get; set; }


    }
}

