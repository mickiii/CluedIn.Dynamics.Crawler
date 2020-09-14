using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class StringMap : DynamicsModel
    {
        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("attributename")]
        public string AttributeName { get; set; }

        [JsonProperty("attributevalue")]
        public long? AttributeValue { get; set; }

        [JsonProperty("langid")]
        public long? LangId { get; set; }

        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayorder")]
        public long? DisplayOrder { get; set; }

        [JsonProperty("objecttypecodename")]
        public string ObjectTypeCodeName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("stringmapid")]
        public Guid? StringMapId { get; set; }


    }
}

