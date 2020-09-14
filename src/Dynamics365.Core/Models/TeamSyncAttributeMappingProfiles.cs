using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TeamSyncAttributeMappingProfiles : DynamicsModel
    {
        [JsonProperty("teamsyncattributemappingprofileid")]
        public Guid? TeamSyncAttributeMappingProfileId { get; set; }

        [JsonProperty("syncattributemappingprofileid")]
        public Guid? SyncAttributeMappingProfileId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("teamid")]
        public Guid? TeamId { get; set; }


    }
}

