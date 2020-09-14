using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class TimeStampDateMapping : DynamicsModel
    {
        [JsonProperty("timestampdatemappingid")]
        public Guid? TimeStampDateMappingId { get; set; }

        [JsonProperty("timestamp")]
        public int? TimeStamp { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset? Date { get; set; }


    }
}

