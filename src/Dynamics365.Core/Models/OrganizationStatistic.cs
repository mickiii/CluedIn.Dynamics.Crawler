using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class OrganizationStatistic : DynamicsModel
    {
        [JsonProperty("hour")]
        public long? Hour { get; set; }

        [JsonProperty("statistictype")]
        public long? StatisticType { get; set; }

        [JsonProperty("organizationstatisticid")]
        public Guid? OrganizationStatisticId { get; set; }

        [JsonProperty("servername")]
        public string ServerName { get; set; }

        [JsonProperty("statisticvalue")]
        public long? StatisticValue { get; set; }


    }
}

