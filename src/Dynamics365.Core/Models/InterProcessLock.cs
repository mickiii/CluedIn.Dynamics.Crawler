using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class InterProcessLock : DynamicsModel
    {
        [JsonProperty("interprocesslockid")]
        public Guid? InterProcessLockId { get; set; }

        [JsonProperty("token")]
        public Guid? Token { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }


    }
}

