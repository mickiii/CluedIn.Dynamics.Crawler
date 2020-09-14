using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class FilterTemplate : DynamicsModel
    {
        [JsonProperty("fetchxml")]
        public string FetchXml { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("querytype")]
        public long? QueryType { get; set; }

        [JsonProperty("filtertemplateid")]
        public Guid? FilterTemplateId { get; set; }

        [JsonProperty("returnedtypecode")]
        public string ReturnedTypeCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }


    }
}

