using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Owner : DynamicsModel
    {
        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("ownerid")]
        public Guid? OwnerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("yominame")]
        public string YomiName { get; set; }


    }
}

