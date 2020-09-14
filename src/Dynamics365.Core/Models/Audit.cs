using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Audit : DynamicsModel
    {
        [JsonProperty("attributemask")]
        public string AttributeMask { get; set; }

        [JsonProperty("transactionid")]
        public Guid? TransactionId { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("objectid")]
        public string ObjectId { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("changedata")]
        public string ChangeData { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("operation")]
        public string Operation { get; set; }

        [JsonProperty("auditid")]
        public Guid? AuditId { get; set; }

        [JsonProperty("callinguserid")]
        public string CallingUserId { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("objecttypecodename")]
        public string ObjectTypeCodeName { get; set; }

        [JsonProperty("actionname")]
        public string ActionName { get; set; }

        [JsonProperty("operationname")]
        public string OperationName { get; set; }

        [JsonProperty("useridname")]
        public string UserIdName { get; set; }

        [JsonProperty("objectidname")]
        public string ObjectIdName { get; set; }

        [JsonProperty("callinguseridname")]
        public string CallingUserIdName { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("useradditionalinfo")]
        public string UserAdditionalInfo { get; set; }


    }
}

