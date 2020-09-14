using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class BulkOperationLog : DynamicsModel
    {
        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("errornumber")]
        public long? ErrorNumber { get; set; }

        [JsonProperty("createdobjectid")]
        public string CreatedObjectId { get; set; }

        [JsonProperty("bulkoperationlogid")]
        public Guid? BulkOperationLogId { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("bulkoperationid")]
        public string BulkOperationId { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("additionalinfo")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("bulkoperationidname")]
        public string BulkOperationIdName { get; set; }

        [JsonProperty("regardingobjectidtypecode")]
        public string RegardingObjectIdTypeCode { get; set; }

        [JsonProperty("createdobjectidname")]
        public string CreatedObjectIdName { get; set; }

        [JsonProperty("createdobjectidtypecode")]
        public string CreatedObjectIdTypeCode { get; set; }

        [JsonProperty("regardingobjectidyominame")]
        public string RegardingObjectIdYomiName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("errordescriptionformatted")]
        public string ErrorDescriptionFormatted { get; set; }

        [JsonProperty("errornumberformatted")]
        public string ErrorNumberFormatted { get; set; }

        [JsonProperty("campaignactivityid")]
        public string CampaignActivityId { get; set; }

        [JsonProperty("campaignactivityidtype")]
        public string CampaignActivityIdType { get; set; }

        [JsonProperty("campaignactivityidname")]
        public string CampaignActivityIdName { get; set; }

        [JsonProperty("campaignactivityidyominame")]
        public string CampaignActivityIdYomiName { get; set; }


    }
}

