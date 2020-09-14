using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class BusinessDataLocalizedLabel : DynamicsModel
    {
        [JsonProperty("businessdatalocalizedlabelid")]
        public Guid? BusinessDataLocalizedLabelId { get; set; }

        [JsonProperty("languageid")]
        public long? LanguageId { get; set; }

        [JsonProperty("objectid")]
        public string ObjectId { get; set; }

        [JsonProperty("objectidtypecode")]
        public long? ObjectIdTypeCode { get; set; }

        [JsonProperty("objectcolumnname")]
        public string ObjectColumnName { get; set; }

        [JsonProperty("objectcolumnnumber")]
        public long? ObjectColumnNumber { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }


    }
}

