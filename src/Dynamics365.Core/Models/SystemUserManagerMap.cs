using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SystemUserManagerMap : DynamicsModel
    {
        [JsonProperty("systemusermanagermapid")]
        public Guid? SystemUserManagerMapId { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("parentsystemuserid")]
        public Guid? ParentSystemUserId { get; set; }

        [JsonProperty("systemuserid")]
        public Guid? SystemUserId { get; set; }

        [JsonProperty("hierarchylevel")]
        public long? HierarchyLevel { get; set; }


    }
}

