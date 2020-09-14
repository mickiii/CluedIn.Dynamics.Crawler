using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class MailboxTrackingCategory : DynamicsModel
    {
        [JsonProperty("mailboxtrackingcategoryid")]
        public Guid? MailboxTrackingCategoryId { get; set; }

        [JsonProperty("mailboxid")]
        public string MailboxId { get; set; }

        [JsonProperty("exchangecategoryid")]
        public Guid? ExchangeCategoryId { get; set; }

        [JsonProperty("exchangecategoryname")]
        public string ExchangeCategoryName { get; set; }

        [JsonProperty("exchangecategorycolor")]
        public long? ExchangeCategoryColor { get; set; }

        [JsonProperty("categoryonboardingstatus")]
        public long? CategoryOnboardingStatus { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }


    }
}

