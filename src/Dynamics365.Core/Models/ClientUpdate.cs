using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ClientUpdate : DynamicsModel
    {
        [JsonProperty("clientupdateid")]
        public Guid? ClientUpdateId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("sqlscript")]
        public string SqlScript { get; set; }

        [JsonProperty("whenexecute")]
        public string WhenExecute { get; set; }

        [JsonProperty("wasexecuted")]
        public bool? WasExecuted { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }


    }
}

