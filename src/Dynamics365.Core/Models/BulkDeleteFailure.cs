using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class BulkDeleteFailure : DynamicsModel
    {
        [JsonProperty("errordescription")]
        public string ErrorDescription { get; set; }

        [JsonProperty("asyncoperationid")]
        public string AsyncOperationId { get; set; }

        [JsonProperty("bulkdeletefailureid")]
        public Guid? BulkDeleteFailureId { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("errornumber")]
        public long? ErrorNumber { get; set; }

        [JsonProperty("orderedqueryindex")]
        public long? OrderedQueryIndex { get; set; }

        [JsonProperty("bulkdeleteoperationid")]
        public string BulkDeleteOperationId { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("regardingobjecttypecode")]
        public string RegardingObjectTypeCode { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }


    }
}

