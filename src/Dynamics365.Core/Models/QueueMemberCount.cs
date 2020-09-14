using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class QueueMemberCount : DynamicsModel
    {
        [JsonProperty("queuemembercount")]
        public string QueueMemberCount1 { get; set; }

        [JsonProperty("queuemembercountid")]
        public Guid? QueueMemberCountId { get; set; }

        [JsonProperty("queueid")]
        public Guid? QueueId { get; set; }


    }
}

