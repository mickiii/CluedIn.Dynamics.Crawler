using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class MultiSelectAttributeOptionValues : DynamicsModel
    {
        [JsonProperty("objectid")]
        public string ObjectId { get; set; }

        [JsonProperty("objectidtypecode")]
        public long? ObjectIdTypeCode { get; set; }

        [JsonProperty("objectcolumnnumber")]
        public long? ObjectColumnNumber { get; set; }

        [JsonProperty("selectedoptionvalues")]
        public string SelectedOptionValues { get; set; }

        [JsonProperty("multiselectfulltextidkey")]
        public int? MultiSelectFullTextIdKey { get; set; }


    }
}

