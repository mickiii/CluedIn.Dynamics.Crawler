using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class WorkflowWaitSubscription : DynamicsModel
    {
        [JsonProperty("entityid")]
        public Guid? EntityId { get; set; }

        [JsonProperty("workflowwaitsubscriptionid")]
        public Guid? WorkflowWaitSubscriptionId { get; set; }

        [JsonProperty("asyncoperationid")]
        public string AsyncOperationId { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("entityname")]
        public string EntityName { get; set; }

        [JsonProperty("ismodified")]
        public bool? IsModified { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("isdeleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("waitonattributelist")]
        public string WaitOnAttributeList { get; set; }


    }
}

