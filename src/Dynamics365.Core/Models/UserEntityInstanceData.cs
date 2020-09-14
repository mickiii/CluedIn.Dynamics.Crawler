using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class UserEntityInstanceData : DynamicsModel
    {
        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("userentityinstancedataid")]
        public Guid? UserEntityInstanceDataId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("objecttypecode")]
        public long? ObjectTypeCode { get; set; }

        [JsonProperty("remindertime")]
        public DateTimeOffset? ReminderTime { get; set; }

        [JsonProperty("starttime")]
        public DateTimeOffset? StartTime { get; set; }

        [JsonProperty("duedate")]
        public DateTimeOffset? DueDate { get; set; }

        [JsonProperty("flagdueby")]
        public DateTimeOffset? FlagDueBy { get; set; }

        [JsonProperty("commonstart")]
        public DateTimeOffset? CommonStart { get; set; }

        [JsonProperty("commonend")]
        public DateTimeOffset? CommonEnd { get; set; }

        [JsonProperty("todoordinaldate")]
        public DateTimeOffset? ToDoOrdinalDate { get; set; }

        [JsonProperty("reminderset")]
        public bool? ReminderSet { get; set; }

        [JsonProperty("flagrequest")]
        public string FlagRequest { get; set; }

        [JsonProperty("todosubordinal")]
        public string ToDoSubOrdinal { get; set; }

        [JsonProperty("todotitle")]
        public string ToDoTitle { get; set; }

        [JsonProperty("personalcategories")]
        public string PersonalCategories { get; set; }

        [JsonProperty("objectid")]
        public string ObjectId { get; set; }

        [JsonProperty("flagstatus")]
        public long? FlagStatus { get; set; }

        [JsonProperty("todoitemflags")]
        public long? ToDoItemFlags { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }


    }
}

