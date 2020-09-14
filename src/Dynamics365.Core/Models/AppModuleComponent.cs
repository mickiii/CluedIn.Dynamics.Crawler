using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class AppModuleComponent : DynamicsModel
    {
        [JsonProperty("appmodulecomponentid")]
        public Guid? AppModuleComponentId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("appmoduleidunique")]
        public string AppModuleIdUnique { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

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

        [JsonProperty("appmoduleidname")]
        public string AppModuleIdName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("isdefault")]
        public bool? IsDefault { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("componenttype")]
        public string ComponentType { get; set; }

        [JsonProperty("componenttypename")]
        public string ComponentTypeName { get; set; }

        [JsonProperty("rootappmodulecomponentid")]
        public Guid? RootAppModuleComponentId { get; set; }

        [JsonProperty("objectid")]
        public Guid? ObjectId { get; set; }

        [JsonProperty("rootcomponentbehavior")]
        public string RootComponentBehavior { get; set; }

        [JsonProperty("ismetadata")]
        public bool? IsMetadata { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("appmodulecomponentidunique")]
        public Guid? AppModuleComponentIdUnique { get; set; }


    }
}

