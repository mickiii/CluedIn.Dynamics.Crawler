using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ActionCardUserSettings : DynamicsModel
    {
        [JsonProperty("actioncardusersettingsid")]
        public Guid? ActionCardUserSettingsId { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("cardtypeid")]
        public string CardTypeId { get; set; }

        [JsonProperty("isenabled")]
        public bool? IsEnabled { get; set; }

        [JsonProperty("isenabledname")]
        public string IsEnabledName { get; set; }

        [JsonProperty("intcardoption")]
        public long? IntCardOption { get; set; }

        [JsonProperty("stringcardoption")]
        public string StringCardOption { get; set; }

        [JsonProperty("boolcardoption")]
        public bool? BoolCardOption { get; set; }

        [JsonProperty("boolcardoptionname")]
        public string BoolCardOptionName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("cardtypeidname")]
        public string CardTypeIdName { get; set; }

        [JsonProperty("cardtype")]
        public long? CardType { get; set; }


    }
}

