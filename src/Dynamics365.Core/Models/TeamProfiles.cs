using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TeamProfiles : DynamicsModel
    {
        [JsonProperty("teamprofileid")]
        public Guid? TeamProfileId { get; set; }

        [JsonProperty("fieldsecurityprofileid")]
        public Guid? FieldSecurityProfileId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("teamid")]
        public Guid? TeamId { get; set; }


    }
}

