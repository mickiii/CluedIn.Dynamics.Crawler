using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class HierarchySecurityConfiguration : DynamicsModel
    {
        [JsonProperty("hierarchysecuritymodelingsettingid")]
        public Guid? HierarchySecurityModelingSettingId { get; set; }

        [JsonProperty("entityname")]
        public string EntityName { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }


    }
}

