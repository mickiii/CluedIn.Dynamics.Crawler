using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class BookableResourceBookingExchangeSyncIdMapping : DynamicsModel
    {
        [JsonProperty("exchangeentryid")]
        public string ExchangeEntryId { get; set; }

        [JsonProperty("bookableresourcebookingexchangesyncidmappingid")]
        public Guid? BookableResourceBookingExchangeSyncIdMappingId { get; set; }

        [JsonProperty("isdeletedinexchange")]
        public bool? IsDeletedInExchange { get; set; }

        [JsonProperty("bookableresourcebookingid")]
        public Guid? BookableResourceBookingId { get; set; }

        [JsonProperty("lastsyncerroroccurredon")]
        public DateTimeOffset? LastSyncErrorOccurredOn { get; set; }

        [JsonProperty("retries")]
        public long? Retries { get; set; }

        [JsonProperty("lastsyncerrorcode")]
        public long? LastSyncErrorCode { get; set; }

        [JsonProperty("lastsyncerror")]
        public string LastSyncError { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

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

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("syncstatus")]
        public string SyncStatus { get; set; }

        [JsonProperty("syncversionnumber")]
        public int? SyncVersionNumber { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("isdeletedinexchangename")]
        public string isdeletedinexchangeName { get; set; }

        [JsonProperty("syncstatusname")]
        public string syncstatusName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }


    }
}

