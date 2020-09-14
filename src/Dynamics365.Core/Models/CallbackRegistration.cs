using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class CallbackRegistration : DynamicsModel
    {
        [JsonProperty("callbackregistrationid")]
        public Guid? CallbackRegistrationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entityname")]
        public string EntityName { get; set; }

        [JsonProperty("filteringattributes")]
        public string FilteringAttributes { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messagename")]
        public string MessageName { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("scopename")]
        public string ScopeName { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("versionname")]
        public string VersionName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owningbusinessunitname")]
        public string OwningBusinessUnitName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("filterexpression")]
        public string FilterExpression { get; set; }

        [JsonProperty("postponeuntil")]
        public string PostponeUntil { get; set; }

        [JsonProperty("runas")]
        public string RunAs { get; set; }

        [JsonProperty("runasname")]
        public string RunAsName { get; set; }


    }
}

