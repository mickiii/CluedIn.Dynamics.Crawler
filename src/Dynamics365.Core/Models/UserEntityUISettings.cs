using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class UserEntityUISettings : DynamicsModel
    {
        [JsonProperty("userentityuisettingsid")]
        public Guid? UserEntityUISettingsId { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("objecttypecode")]
        public long? ObjectTypeCode { get; set; }

        [JsonProperty("taborderxml")]
        public string TabOrderXml { get; set; }

        [JsonProperty("readingpanexml")]
        public string ReadingPaneXml { get; set; }

        [JsonProperty("mruxml")]
        public string MRUXml { get; set; }

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

        [JsonProperty("insertintoemailmruxml")]
        public string InsertIntoEmailMRUXml { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("recentlyviewedxml")]
        public string RecentlyViewedXml { get; set; }

        [JsonProperty("lastviewedformxml")]
        public string LastViewedFormXml { get; set; }

        [JsonProperty("showinaddressbook")]
        public bool? ShowInAddressBook { get; set; }

        [JsonProperty("lookupmruxml")]
        public string LookupMRUXml { get; set; }


    }
}

