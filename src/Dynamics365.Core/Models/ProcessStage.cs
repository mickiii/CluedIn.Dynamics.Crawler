using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ProcessStage : DynamicsModel
    {
        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("primaryentitytypecode")]
        public string PrimaryEntityTypeCode { get; set; }

        [JsonProperty("primaryentitytypecodename")]
        public string PrimaryEntityTypeCodeName { get; set; }

        [JsonProperty("processid")]
        public string ProcessId { get; set; }

        [JsonProperty("processidname")]
        public string ProcessIdName { get; set; }

        [JsonProperty("processstageid")]
        public Guid? ProcessStageId { get; set; }

        [JsonProperty("stagecategory")]
        public string StageCategory { get; set; }

        [JsonProperty("stagecategoryname")]
        public string StageCategoryName { get; set; }

        [JsonProperty("stagename")]
        public string StageName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("clientdata")]
        public string ClientData { get; set; }


    }
}

