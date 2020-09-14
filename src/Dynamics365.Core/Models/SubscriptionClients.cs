using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SubscriptionClients : DynamicsModel
    {
        [JsonProperty("clientid")]
        public Guid? ClientId { get; set; }

        [JsonProperty("machinename")]
        public string MachineName { get; set; }

        [JsonProperty("subscriptionid")]
        public Guid? SubscriptionId { get; set; }

        [JsonProperty("isprimaryclient")]
        public bool? IsPrimaryClient { get; set; }

        [JsonProperty("subscriptionclientid")]
        public Guid? SubscriptionClientId { get; set; }


    }
}

