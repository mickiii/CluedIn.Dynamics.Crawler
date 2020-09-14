using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class EmailHash : DynamicsModel
    {
        [JsonProperty("hashtype")]
        public long? HashType { get; set; }

        [JsonProperty("hash")]
        public long? Hash { get; set; }

        [JsonProperty("owninguser")]
        public Guid? OwningUser { get; set; }

        [JsonProperty("emailhashid")]
        public Guid? EmailHashId { get; set; }

        [JsonProperty("activityid")]
        public string ActivityId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("owningbusinessunit")]
        public Guid? OwningBusinessUnit { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }


    }
}

