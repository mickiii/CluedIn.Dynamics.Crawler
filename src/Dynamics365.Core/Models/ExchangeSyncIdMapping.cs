using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ExchangeSyncIdMapping : DynamicsModel
    {
        [JsonProperty("exchangesyncidmappingid")]
        public Guid? ExchangeSyncIdmappingId { get; set; }

        [JsonProperty("exchangeentryid")]
        public string ExchangeEntryId { get; set; }

        [JsonProperty("isdeletedinexchange")]
        public bool? IsDeletedInExchange { get; set; }

        [JsonProperty("objectid")]
        public Guid? ObjectId { get; set; }

        [JsonProperty("objecttypecode")]
        public long? ObjectTypeCode { get; set; }

        [JsonProperty("isunlinkedincrm")]
        public bool? IsUnlinkedInCRM { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("fromcrmchangetype")]
        public long? FromCrmChangeType { get; set; }

        [JsonProperty("tocrmchangetype")]
        public long? ToCrmChangeType { get; set; }

        [JsonProperty("retries")]
        public long? Retries { get; set; }

        [JsonProperty("lastsyncerror")]
        public string LastSyncError { get; set; }

        [JsonProperty("userdecision")]
        public long? UserDecision { get; set; }

        [JsonProperty("lastsyncerrorcode")]
        public long? LastSyncErrorCode { get; set; }

        [JsonProperty("lastsyncerroroccurredon")]
        public DateTimeOffset? LastSyncErrorOccurredOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("itemsubject")]
        public string ItemSubject { get; set; }


    }
}

