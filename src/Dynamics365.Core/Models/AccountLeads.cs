using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class AccountClass : DynamicsModel
    {
        [JsonProperty("accountid")]
        public Guid? AccountId { get; set; }

        [JsonProperty("accountleadid")]
        public Guid? AccountLeadId { get; set; }

        [JsonProperty("importsequencenumber")]
        public int ImportSequenceNumber { get; set; }

        [JsonProperty("leadid")]
        public Guid? LeadId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public int TimezoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public int UtcConversionTimezoneCode{ get; set; }

        [JsonProperty("versionnumber")]
        public long VersionNumber { get; set; }
    }
}
