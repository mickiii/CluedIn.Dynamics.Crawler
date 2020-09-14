using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ActivityParty : DynamicsModel
    {
        [JsonProperty("activityid")]
        public string ActivityId { get; set; }

        [JsonProperty("activitypartyid")]
        public Guid? ActivityPartyId { get; set; }

        [JsonProperty("partyid")]
        public string PartyId { get; set; }

        [JsonProperty("partyobjecttypecode")]
        public string PartyObjectTypeCode { get; set; }

        [JsonProperty("participationtypemask")]
        public string ParticipationTypeMask { get; set; }

        [JsonProperty("addressused")]
        public string AddressUsed { get; set; }

        [JsonProperty("partyidname")]
        public string PartyIdName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("donotfax")]
        public bool? DoNotFax { get; set; }

        [JsonProperty("scheduledstart")]
        public DateTimeOffset? ScheduledStart { get; set; }

        [JsonProperty("scheduledend")]
        public DateTimeOffset? ScheduledEnd { get; set; }

        [JsonProperty("effort")]
        public double? Effort { get; set; }

        [JsonProperty("donotemail")]
        public bool? DoNotEmail { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("exchangeentryid")]
        public string ExchangeEntryId { get; set; }

        [JsonProperty("resourcespecid")]
        public string ResourceSpecId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("resourcespecidname")]
        public string ResourceSpecIdName { get; set; }

        [JsonProperty("donotfaxname")]
        public string DoNotFaxName { get; set; }

        [JsonProperty("donotemailname")]
        public string DoNotEmailName { get; set; }

        [JsonProperty("participationtypemaskname")]
        public string ParticipationTypeMaskName { get; set; }

        [JsonProperty("donotpostalmail")]
        public bool? DoNotPostalMail { get; set; }

        [JsonProperty("donotphone")]
        public bool? DoNotPhone { get; set; }

        [JsonProperty("donotphonename")]
        public string DoNotPhoneName { get; set; }

        [JsonProperty("donotpostalmailname")]
        public string DoNotPostalMailName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("instancetypecode")]
        public string InstanceTypeCode { get; set; }

        [JsonProperty("instancetypecodename")]
        public string InstanceTypeCodeName { get; set; }

        [JsonProperty("ispartydeleted")]
        public bool? IsPartyDeleted { get; set; }

        [JsonProperty("ispartydeletedname")]
        public string IsPartyDeletedName { get; set; }

        [JsonProperty("addressusedemailcolumnnumber")]
        public long? AddressUsedEmailColumnNumber { get; set; }


    }
}

