using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Queue : DynamicsModel
    {
        [JsonProperty("queueid")]
        public Guid? QueueId { get; set; }

        [JsonProperty("businessunitid")]
        public string BusinessUnitId { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("emailaddress")]
        public string EMailAddress { get; set; }

        [JsonProperty("primaryuserid")]
        public string PrimaryUserId { get; set; }

        [JsonProperty("queuetypecode")]
        public string QueueTypeCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("primaryuseridname")]
        public string PrimaryUserIdName { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("businessunitidname")]
        public string BusinessUnitIdName { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("queuetypecodename")]
        public string QueueTypeCodeName { get; set; }

        [JsonProperty("ignoreunsolicitedemail")]
        public bool? IgnoreUnsolicitedEmail { get; set; }

        [JsonProperty("isfaxqueue")]
        public bool? IsFaxQueue { get; set; }

        [JsonProperty("isfaxqueuename")]
        public string IsFaxQueueName { get; set; }

        [JsonProperty("ignoreunsolicitedemailname")]
        public string IgnoreUnsolicitedEmailName { get; set; }

        [JsonProperty("emailpassword")]
        public string EmailPassword { get; set; }

        [JsonProperty("incomingemaildeliverymethod")]
        public string IncomingEmailDeliveryMethod { get; set; }

        [JsonProperty("emailusername")]
        public string EmailUsername { get; set; }

        [JsonProperty("outgoingemaildeliverymethod")]
        public string OutgoingEmailDeliveryMethod { get; set; }

        [JsonProperty("allowemailcredentials")]
        public bool? AllowEmailCredentials { get; set; }

        [JsonProperty("incomingemailfilteringmethod")]
        public string IncomingEmailFilteringMethod { get; set; }

        [JsonProperty("outgoingemaildeliverymethodname")]
        public string OutgoingEmailDeliveryMethodName { get; set; }

        [JsonProperty("allowemailcredentialsname")]
        public string AllowEmailCredentialsName { get; set; }

        [JsonProperty("incomingemailfilteringmethodname")]
        public string IncomingEmailFilteringMethodName { get; set; }

        [JsonProperty("incomingemaildeliverymethodname")]
        public string IncomingEmailDeliveryMethodName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("primaryuseridyominame")]
        public string PrimaryUserIdYomiName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("numberofitems")]
        public long? NumberOfItems { get; set; }

        [JsonProperty("numberofmembers")]
        public long? NumberOfMembers { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("transactioncurrencyid")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("transactioncurrencyidname")]
        public string TransactionCurrencyIdName { get; set; }

        [JsonProperty("exchangerate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("emailrouteraccessapproval")]
        public string EmailRouterAccessApproval { get; set; }

        [JsonProperty("emailrouteraccessapprovalname")]
        public string EmailRouterAccessApprovalName { get; set; }

        [JsonProperty("defaultmailbox")]
        public string DefaultMailbox { get; set; }

        [JsonProperty("defaultmailboxname")]
        public string DefaultMailboxName { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("isemailaddressapprovedbyo365admin")]
        public bool? IsEmailAddressApprovedByO365Admin { get; set; }

        [JsonProperty("queueviewtype")]
        public string QueueViewType { get; set; }

        [JsonProperty("queueviewtypename")]
        public string QueueViewTypeName { get; set; }


    }
}

