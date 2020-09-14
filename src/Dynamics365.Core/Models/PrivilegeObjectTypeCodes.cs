using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class PrivilegeObjectTypeCodes : DynamicsModel
    {
        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("privilegeid")]
        public string PrivilegeId { get; set; }

        [JsonProperty("privilegeobjecttypecodeid")]
        public Guid? PrivilegeObjectTypeCodeId { get; set; }

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

        [JsonProperty("privilegeobjecttypecoderowid")]
        public Guid? PrivilegeObjectTypeCodeRowId { get; set; }


    }
}

