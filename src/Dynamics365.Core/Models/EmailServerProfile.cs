using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class EmailServerProfile : DynamicsModel
    {
        [JsonProperty("emailserverprofileid")]
        public Guid? EmailServerProfileId { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedon")]
        public DateTimeOffset? ModifiedOn { get; set; }

        [JsonProperty("modifiedby")]
        public string ModifiedBy { get; set; }

        [JsonProperty("createdonbehalfby")]
        public string CreatedOnBehalfBy { get; set; }

        [JsonProperty("modifiedonbehalfby")]
        public string ModifiedOnBehalfBy { get; set; }

        [JsonProperty("createdbyname")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdbyyominame")]
        public string CreatedByYomiName { get; set; }

        [JsonProperty("createdonbehalfbyname")]
        public string CreatedOnBehalfByName { get; set; }

        [JsonProperty("createdonbehalfbyyominame")]
        public string CreatedOnBehalfByYomiName { get; set; }

        [JsonProperty("modifiedbyname")]
        public string ModifiedByName { get; set; }

        [JsonProperty("modifiedbyyominame")]
        public string ModifiedByYomiName { get; set; }

        [JsonProperty("modifiedonbehalfbyname")]
        public string ModifiedOnBehalfByName { get; set; }

        [JsonProperty("modifiedonbehalfbyyominame")]
        public string ModifiedOnBehalfByYomiName { get; set; }

        [JsonProperty("organizationid")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationidname")]
        public string OrganizationIdName { get; set; }

        [JsonProperty("statecode")]
        public string StateCode { get; set; }

        [JsonProperty("statecodename")]
        public string StateCodeName { get; set; }

        [JsonProperty("statuscode")]
        public string StatusCode { get; set; }

        [JsonProperty("statuscodename")]
        public string StatusCodeName { get; set; }

        [JsonProperty("timezoneruleversionnumber")]
        public long? TimeZoneRuleVersionNumber { get; set; }

        [JsonProperty("utcconversiontimezonecode")]
        public long? UTCConversionTimeZoneCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("servertype")]
        public string ServerType { get; set; }

        [JsonProperty("servertypename")]
        public string ServerTypeName { get; set; }

        [JsonProperty("outgoingserverlocation")]
        public string OutgoingServerLocation { get; set; }

        [JsonProperty("incomingserverlocation")]
        public string IncomingServerLocation { get; set; }

        [JsonProperty("incomingusername")]
        public string IncomingUserName { get; set; }

        [JsonProperty("incomingpassword")]
        public string IncomingPassword { get; set; }

        [JsonProperty("outgoingusername")]
        public string OutgoingUsername { get; set; }

        [JsonProperty("outgoingpassword")]
        public string OutgoingPassword { get; set; }

        [JsonProperty("incomingportnumber")]
        public long? IncomingPortNumber { get; set; }

        [JsonProperty("outgoingportnumber")]
        public long? OutgoingPortNumber { get; set; }

        [JsonProperty("incomingusessl")]
        public bool? IncomingUseSSL { get; set; }

        [JsonProperty("incomingusesslname")]
        public string IncomingUseSslName { get; set; }

        [JsonProperty("outgoingusessl")]
        public bool? OutgoingUseSSL { get; set; }

        [JsonProperty("outgoingusesslname")]
        public string OutgoingUseSslName { get; set; }

        [JsonProperty("useautodiscover")]
        public bool? UseAutoDiscover { get; set; }

        [JsonProperty("useautodiscovername")]
        public string UseAutoDiscoverName { get; set; }

        [JsonProperty("incomingauthenticationprotocol")]
        public string IncomingAuthenticationProtocol { get; set; }

        [JsonProperty("incomingauthenticationprotocolname")]
        public string IncomingAuthenticationProtocolName { get; set; }

        [JsonProperty("outgoingcredentialretrieval")]
        public string OutgoingCredentialRetrieval { get; set; }

        [JsonProperty("incomingcredentialretrieval")]
        public string IncomingCredentialRetrieval { get; set; }

        [JsonProperty("incomingcredentialretrievalname")]
        public string IncomingCredentialRetrievalName { get; set; }

        [JsonProperty("outgoingcredentialretrievalname")]
        public string OutgoingCredentialRetrievalName { get; set; }

        [JsonProperty("encodingcodepage")]
        public string EncodingCodePage { get; set; }

        [JsonProperty("processemailsreceivedafter")]
        public DateTimeOffset? ProcessEmailsReceivedAfter { get; set; }

        [JsonProperty("maxconcurrentconnections")]
        public long? MaxConcurrentConnections { get; set; }

        [JsonProperty("outgoingautograntdelegateaccess")]
        public bool? OutgoingAutoGrantDelegateAccess { get; set; }

        [JsonProperty("outgoingautograntdelegateaccessname")]
        public string OutgoingAutoGrantDelegateAccessName { get; set; }

        [JsonProperty("outgoinguseimpersonation")]
        public bool? OutgoingUseImpersonation { get; set; }

        [JsonProperty("outgoinguseimpersonationname")]
        public string OutgoingUseImpersonationName { get; set; }

        [JsonProperty("incominguseimpersonation")]
        public bool? IncomingUseImpersonation { get; set; }

        [JsonProperty("incominguseimpersonationname")]
        public string IncomingUseImpersonationName { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("owneridyominame")]
        public string OwnerIdYomiName { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owningbusinessunitname")]
        public string OwningBusinessUnitName { get; set; }

        [JsonProperty("owningteam")]
        public string OwningTeam { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("incomingpartnerapplication")]
        public string IncomingPartnerApplication { get; set; }

        [JsonProperty("incomingpartnerapplicationname")]
        public string IncomingPartnerApplicationName { get; set; }

        [JsonProperty("outgoingpartnerapplication")]
        public string OutgoingPartnerApplication { get; set; }

        [JsonProperty("outgoingpartnerapplicationname")]
        public string OutgoingPartnerApplicationName { get; set; }

        [JsonProperty("moveundeliveredemails")]
        public bool? MoveUndeliveredEmails { get; set; }

        [JsonProperty("moveundeliveredemailsname")]
        public string MoveUndeliveredEmailsName { get; set; }

        [JsonProperty("minpollingintervalinminutes")]
        public long? MinPollingIntervalInMinutes { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("usesamesettingsforoutgoingconnections")]
        public bool? UseSameSettingsForOutgoingConnections { get; set; }

        [JsonProperty("usesamesettingsforoutgoingconnectionsname")]
        public string UseSameSettingsForOutgoingConnectionsName { get; set; }

        [JsonProperty("isincomingpasswordset")]
        public bool? IsIncomingPasswordSet { get; set; }

        [JsonProperty("isoutgoingpasswordset")]
        public bool? IsOutgoingPasswordSet { get; set; }

        [JsonProperty("outgoingauthenticationprotocol")]
        public string OutgoingAuthenticationProtocol { get; set; }

        [JsonProperty("outgoingauthenticationprotocolname")]
        public string OutgoingAuthenticationProtocolName { get; set; }

        [JsonProperty("exchangeversion")]
        public string ExchangeVersion { get; set; }

        [JsonProperty("exchangeversionname")]
        public string ExchangeVersionName { get; set; }

        [JsonProperty("entityimageid")]
        public Guid? EntityImageId { get; set; }

        [JsonProperty("entityimage")]
        public string EntityImage { get; set; }

        [JsonProperty("entityimage_timestamp")]
        public int? EntityImage_Timestamp { get; set; }

        [JsonProperty("entityimage_url")]
        public string EntityImage_URL { get; set; }

        [JsonProperty("timeoutmailboxconnection")]
        public bool? TimeoutMailboxConnection { get; set; }

        [JsonProperty("timeoutmailboxconnectionname")]
        public string TimeoutMailboxConnectionName { get; set; }

        [JsonProperty("sendemailalert")]
        public bool? SendEmailAlert { get; set; }

        [JsonProperty("sendemailalertname")]
        public string SendEmailAlertName { get; set; }

        [JsonProperty("timeoutmailboxconnectionafteramount")]
        public long? TimeoutMailboxConnectionAfterAmount { get; set; }

        [JsonProperty("emailservertypename")]
        public string EmailServerTypeName { get; set; }

        [JsonProperty("exchangeonlinetenantid")]
        public string ExchangeOnlineTenantId { get; set; }

        [JsonProperty("lasttestexecutionstatus")]
        public string LastTestExecutionStatus { get; set; }

        [JsonProperty("lasttestvalidationstatus")]
        public string LastTestValidationStatus { get; set; }

        [JsonProperty("lasttestrequest")]
        public string LastTestRequest { get; set; }

        [JsonProperty("lasttestresponse")]
        public string LastTestResponse { get; set; }

        [JsonProperty("lastteststarttime")]
        public DateTimeOffset? LastTestStartTime { get; set; }

        [JsonProperty("lasttesttotalexecutiontime")]
        public int? LastTestTotalExecutionTime { get; set; }

        [JsonProperty("owneremailaddress")]
        public string OwnerEmailAddress { get; set; }

        [JsonProperty("usedefaulttenantid")]
        public bool? UseDefaultTenantId { get; set; }

        [JsonProperty("usedefaulttenantidname")]
        public string UseDefaultTenantIdName { get; set; }

        [JsonProperty("lastauthorizationstatus")]
        public string LastAuthorizationStatus { get; set; }

        [JsonProperty("lastcrmmessage")]
        public string LastCrmMessage { get; set; }

        [JsonProperty("defaultserverlocation")]
        public string DefaultServerLocation { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }


    }
}

