using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Privilege : DynamicsModel
    {
        [JsonProperty("privilegeid")]
        public Guid? PrivilegeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("canbelocal")]
        public bool? CanBeLocal { get; set; }

        [JsonProperty("canbedeep")]
        public bool? CanBeDeep { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("canbeglobal")]
        public bool? CanBeGlobal { get; set; }

        [JsonProperty("canbebasic")]
        public bool? CanBeBasic { get; set; }

        [JsonProperty("canbelocalname")]
        public string CanBeLocalName { get; set; }

        [JsonProperty("canbeglobalname")]
        public string CanBeGlobalName { get; set; }

        [JsonProperty("canbebasicname")]
        public string CanBeBasicName { get; set; }

        [JsonProperty("canbedeepname")]
        public string CanBeDeepName { get; set; }

        [JsonProperty("accessright")]
        public long? AccessRight { get; set; }

        [JsonProperty("isdisabledwhenintegrated")]
        public bool? IsDisabledWhenIntegrated { get; set; }

        [JsonProperty("canbeentityreference")]
        public bool? CanBeEntityReference { get; set; }

        [JsonProperty("canbeentityreferencename")]
        public string CanBeEntityReferenceName { get; set; }

        [JsonProperty("canbeparententityreference")]
        public bool? CanBeParentEntityReference { get; set; }

        [JsonProperty("canbeparententityreferencename")]
        public string CanBeParentEntityReferenceName { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("privilegerowid")]
        public Guid? PrivilegeRowId { get; set; }


    }
}

