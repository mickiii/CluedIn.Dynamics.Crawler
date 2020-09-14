using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class DuplicateRecord : DynamicsModel
    {
        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("duplicateruleid")]
        public string DuplicateRuleId { get; set; }

        [JsonProperty("baserecordid")]
        public string BaseRecordId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("duplicateid")]
        public Guid? DuplicateId { get; set; }

        [JsonProperty("asyncoperationid")]
        public string AsyncOperationId { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("duplicaterecordid")]
        public string DuplicateRecordId { get; set; }

        [JsonProperty("baserecordidtypecode")]
        public string BaseRecordIdTypeCode { get; set; }

        [JsonProperty("baserecordidname")]
        public string BaseRecordIdName { get; set; }

        [JsonProperty("duplicaterecordidname")]
        public string DuplicateRecordIdName { get; set; }

        [JsonProperty("duplicaterecordidyominame")]
        public string DuplicateRecordIdYomiName { get; set; }

        [JsonProperty("baserecordidyominame")]
        public string BaseRecordIdYomiName { get; set; }

        [JsonProperty("duplicaterecordidtypecode")]
        public string DuplicateRecordIdTypeCode { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }


    }
}

