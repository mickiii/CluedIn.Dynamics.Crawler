using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Notification : DynamicsModel
    {
        [JsonProperty("notificationnumber")]
        public long? NotificationNumber { get; set; }

        [JsonProperty("eventdata")]
        public string EventData { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("eventid")]
        public long? EventId { get; set; }

        [JsonProperty("notificationid")]
        public Guid? NotificationId { get; set; }

        [JsonProperty("createdonstring")]
        public string CreatedOnString { get; set; }

        [JsonProperty("organizationid")]
        public Guid? OrganizationId { get; set; }


    }
}

