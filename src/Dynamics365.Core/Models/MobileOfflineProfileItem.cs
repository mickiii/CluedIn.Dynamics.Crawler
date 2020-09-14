using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class MobileOfflineProfileItem : DynamicsModel
    {
        [JsonProperty("mobileofflineprofileitemid")]
        public Guid? MobileOfflineProfileItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("viewquery")]
        public string ViewQuery { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("canbefollowed")]
        public bool? CanBeFollowed { get; set; }

        [JsonProperty("canbefollowedname")]
        public string CanBeFollowedName { get; set; }

        [JsonProperty("getrelatedentityrecords")]
        public bool? GetRelatedEntityRecords { get; set; }

        [JsonProperty("getrelatedentityrecordsname")]
        public string GetRelatedEntityRecordsName { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("regardingobjectid")]
        public string RegardingObjectId { get; set; }

        [JsonProperty("regardingobjectidname")]
        public string RegardingObjectIdName { get; set; }

        [JsonProperty("processid")]
        public Guid? ProcessId { get; set; }

        [JsonProperty("stageid")]
        public Guid? StageId { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("profileitemrule")]
        public string ProfileItemRule { get; set; }

        [JsonProperty("profileitemrulename")]
        public string ProfileItemRuleName { get; set; }

        [JsonProperty("traversedpath")]
        public string TraversedPath { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("publishedon")]
        public DateTimeOffset? PublishedOn { get; set; }

        [JsonProperty("mobileofflineprofileitemidunique")]
        public Guid? MobileOfflineProfileItemIdUnique { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("selectedentitytypecode")]
        public string SelectedEntityTypeCode { get; set; }

        [JsonProperty("selectedentitytypecodename")]
        public string SelectedEntityTypeCodeName { get; set; }

        [JsonProperty("isvisibleingrid")]
        public bool? IsVisibleInGrid { get; set; }

        [JsonProperty("isvisibleingridname")]
        public string IsVisibleInGridName { get; set; }

        [JsonProperty("recorddistributioncriteria")]
        public string RecordDistributionCriteria { get; set; }

        [JsonProperty("recorddistributioncriterianame")]
        public string RecordDistributionCriteriaName { get; set; }

        [JsonProperty("recordsownedbyme")]
        public bool? RecordsOwnedByMe { get; set; }

        [JsonProperty("recordsownedbymename")]
        public string RecordsOwnedByMeName { get; set; }

        [JsonProperty("recordsownedbymyteam")]
        public bool? RecordsOwnedByMyTeam { get; set; }

        [JsonProperty("recordsownedbymyteamname")]
        public string RecordsOwnedByMyTeamName { get; set; }

        [JsonProperty("recordsownedbymybusinessunit")]
        public bool? RecordsOwnedByMyBusinessUnit { get; set; }

        [JsonProperty("recordsownedbymybusinessunitname")]
        public string RecordsOwnedByMyBusinessUnitName { get; set; }

        [JsonProperty("relationshipdata")]
        public string RelationshipData { get; set; }

        [JsonProperty("isvalidated")]
        public bool? IsValidated { get; set; }

        [JsonProperty("isvalidatedname")]
        public string IsValidatedName { get; set; }

        [JsonProperty("selectedentitymetadata")]
        public string SelectedEntityMetadata { get; set; }

        [JsonProperty("entityobjecttypecode")]
        public long? EntityObjectTypeCode { get; set; }

        [JsonProperty("profileitementityfilter")]
        public string ProfileItemEntityFilter { get; set; }


    }
}

