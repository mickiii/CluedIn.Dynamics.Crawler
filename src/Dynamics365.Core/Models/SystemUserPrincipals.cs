using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SystemUserPrincipals : DynamicsModel
    {
        [JsonProperty("systemuserprincipalid")]
        public Guid? SystemUserPrincipalId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("principalid")]
        public Guid? PrincipalId { get; set; }

        [JsonProperty("systemuserid")]
        public Guid? SystemUserId { get; set; }


    }
}

