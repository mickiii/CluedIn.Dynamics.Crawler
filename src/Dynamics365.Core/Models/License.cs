using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class License : DynamicsModel
    {
        [JsonProperty("licenseid")]
        public Guid? LicenseId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("licensekey")]
        public string LicenseKey { get; set; }

        [JsonProperty("installedon")]
        public DateTimeOffset? InstalledOn { get; set; }

        [JsonProperty("licensetype")]
        public Guid? LicenseType { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }


    }
}

