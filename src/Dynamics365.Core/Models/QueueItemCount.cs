using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class QueueItemCount : DynamicsModel
    {
        [JsonProperty("queueitemcount")]
        public string QueueItemCount1 { get; set; }

        [JsonProperty("queueitemcountid")]
        public Guid? QueueItemCountId { get; set; }

        [JsonProperty("queueid")]
        public Guid? QueueId { get; set; }


    }
}

