using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class EmailServerProfileVocabulary : SimpleVocabulary
    {
        public EmailServerProfileVocabulary()
        {
            VocabularyName = "Dynamics365 EmailServerProfile";
            KeyPrefix = "dynamics365.emailserverprofile";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("EmailServerProfile", group =>
            {
                this.EmailServerProfileId = group.Add(new VocabularyKey("EmailServerProfileId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the email server profile.")
                    .WithDisplayName("EmailServerProfile")
                    .ModelProperty("emailserverprofileid", typeof(Guid)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record on behalf of another user.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the record.")
                    .WithDisplayName("Organization Id")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the email server profile is active or inactive.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the email server profile's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a meaningful name for the email server profile. This name is displayed when you need to select an email server profile.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.ServerType = group.Add(new VocabularyKey("ServerType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the profile's email server type.")
                    .WithDisplayName("Email Server Type")
                    .ModelProperty("servertype", typeof(string)));

                this.ServerTypeName = group.Add(new VocabularyKey("ServerTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ServerTypeName")
                    .ModelProperty("servertypename", typeof(string)));

                this.OutgoingServerLocation = group.Add(new VocabularyKey("OutgoingServerLocation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2084))
                    .WithDescription(@"Type the location of the server for outgoing email.")
                    .WithDisplayName("Outgoing Email Server Location")
                    .ModelProperty("outgoingserverlocation", typeof(string)));

                this.IncomingServerLocation = group.Add(new VocabularyKey("IncomingServerLocation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2084))
                    .WithDescription(@"Type the location of the server for incoming email.")
                    .WithDisplayName("Incoming Email Server Location")
                    .ModelProperty("incomingserverlocation", typeof(string)));

                this.IncomingUserName = group.Add(new VocabularyKey("IncomingUserName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the user name for incoming email.")
                    .WithDisplayName("Incoming Email User Name")
                    .ModelProperty("incomingusername", typeof(string)));

                this.IncomingPassword = group.Add(new VocabularyKey("IncomingPassword", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the password for incoming email.")
                    .WithDisplayName("Incoming Email Password")
                    .ModelProperty("incomingpassword", typeof(string)));

                this.OutgoingUsername = group.Add(new VocabularyKey("OutgoingUsername", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the user name for outgoing email.")
                    .WithDisplayName("Outgoing Email User Name")
                    .ModelProperty("outgoingusername", typeof(string)));

                this.OutgoingPassword = group.Add(new VocabularyKey("OutgoingPassword", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type the password for outgoing email.")
                    .WithDisplayName("Outgoing Email Password")
                    .ModelProperty("outgoingpassword", typeof(string)));

                this.IncomingPortNumber = group.Add(new VocabularyKey("IncomingPortNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the Exchange port number for incoming mail.")
                    .WithDisplayName("Incoming Email Port")
                    .ModelProperty("incomingportnumber", typeof(long)));

                this.OutgoingPortNumber = group.Add(new VocabularyKey("OutgoingPortNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the Exchange port number for outgoing mail.")
                    .WithDisplayName("Outgoing Email Port")
                    .ModelProperty("outgoingportnumber", typeof(long)));

                this.IncomingUseSSL = group.Add(new VocabularyKey("IncomingUseSSL", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to use the Secure Sockets Layer (SSL) protocol for incoming email.")
                    .WithDisplayName("Use SSL for Incoming Email")
                    .ModelProperty("incomingusessl", typeof(bool)));

                this.IncomingUseSslName = group.Add(new VocabularyKey("IncomingUseSslName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IncomingUseSslName")
                    .ModelProperty("incomingusesslname", typeof(string)));

                this.OutgoingUseSSL = group.Add(new VocabularyKey("OutgoingUseSSL", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to use the Secure Sockets Layer (SSL) protocol for outgoing email.")
                    .WithDisplayName("Use SSL for Outgoing Email")
                    .ModelProperty("outgoingusessl", typeof(bool)));

                this.OutgoingUseSslName = group.Add(new VocabularyKey("OutgoingUseSslName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OutgoingUseSslName")
                    .ModelProperty("outgoingusesslname", typeof(string)));

                this.UseAutoDiscover = group.Add(new VocabularyKey("UseAutoDiscover", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to automatically discover the server location")
                    .WithDisplayName("Auto Discover Server Location")
                    .ModelProperty("useautodiscover", typeof(bool)));

                this.UseAutoDiscoverName = group.Add(new VocabularyKey("UseAutoDiscoverName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("UseAutoDiscoverName")
                    .ModelProperty("useautodiscovername", typeof(string)));

                this.IncomingAuthenticationProtocol = group.Add(new VocabularyKey("IncomingAuthenticationProtocol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the incoming email authentication protocol that is used for connecting to the email server.")
                    .WithDisplayName("Incoming Authentication Protocol")
                    .ModelProperty("incomingauthenticationprotocol", typeof(string)));

                this.IncomingAuthenticationProtocolName = group.Add(new VocabularyKey("IncomingAuthenticationProtocolName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IncomingAuthenticationProtocolName")
                    .ModelProperty("incomingauthenticationprotocolname", typeof(string)));

                this.OutgoingCredentialRetrieval = group.Add(new VocabularyKey("OutgoingCredentialRetrieval", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select how credentials will be retrieved for outgoing email.")
                    .WithDisplayName("Outgoing Email Credential Retrieval")
                    .ModelProperty("outgoingcredentialretrieval", typeof(string)));

                this.IncomingCredentialRetrieval = group.Add(new VocabularyKey("IncomingCredentialRetrieval", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select how credentials will be retrieved for incoming email.")
                    .WithDisplayName("Incoming Email Credential Retrieval")
                    .ModelProperty("incomingcredentialretrieval", typeof(string)));

                this.IncomingCredentialRetrievalName = group.Add(new VocabularyKey("IncomingCredentialRetrievalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IncomingCredentialRetrievalName")
                    .ModelProperty("incomingcredentialretrievalname", typeof(string)));

                this.OutgoingCredentialRetrievalName = group.Add(new VocabularyKey("OutgoingCredentialRetrievalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OutgoingCredentialRetrievalName")
                    .ModelProperty("outgoingcredentialretrievalname", typeof(string)));

                this.EncodingCodePage = group.Add(new VocabularyKey("EncodingCodePage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Indicates the code page to use when encoding email content.")
                    .WithDisplayName("Encoding Code Page")
                    .ModelProperty("encodingcodepage", typeof(string)));

                this.ProcessEmailsReceivedAfter = group.Add(new VocabularyKey("ProcessEmailsReceivedAfter", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time after which email messages that are received will be processed for mailboxes associated with the email server profile.")
                    .WithDisplayName("Process Emails Received After")
                    .ModelProperty("processemailsreceivedafter", typeof(DateTime)));

                this.MaxConcurrentConnections = group.Add(new VocabularyKey("MaxConcurrentConnections", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of concurrent connections allowed to the email server per authenticated user.")
                    .WithDisplayName("Maximum Concurrent Connections")
                    .ModelProperty("maxconcurrentconnections", typeof(long)));

                this.OutgoingAutoGrantDelegateAccess = group.Add(new VocabularyKey("OutgoingAutoGrantDelegateAccess", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the email connector will grant delegate access permissions to the accessing user when required while processing outgoing emails.")
                    .WithDisplayName("Auto Grant Delegate Access for Outgoing Email.")
                    .ModelProperty("outgoingautograntdelegateaccess", typeof(bool)));

                this.OutgoingAutoGrantDelegateAccessName = group.Add(new VocabularyKey("OutgoingAutoGrantDelegateAccessName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OutgoingAutoGrantDelegateAccessName")
                    .ModelProperty("outgoingautograntdelegateaccessname", typeof(string)));

                this.OutgoingUseImpersonation = group.Add(new VocabularyKey("OutgoingUseImpersonation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to use impersonation for accessing the mailbox to process outgoing emails.")
                    .WithDisplayName("Use Impersonation for Outgoing Email")
                    .ModelProperty("outgoinguseimpersonation", typeof(bool)));

                this.OutgoingUseImpersonationName = group.Add(new VocabularyKey("OutgoingUseImpersonationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OutgoingUseImpersonationName")
                    .ModelProperty("outgoinguseimpersonationname", typeof(string)));

                this.IncomingUseImpersonation = group.Add(new VocabularyKey("IncomingUseImpersonation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to use impersonation to access the mailbox to process incoming emails.")
                    .WithDisplayName("Use Impersonation for Incoming Email")
                    .ModelProperty("incominguseimpersonation", typeof(bool)));

                this.IncomingUseImpersonationName = group.Add(new VocabularyKey("IncomingUseImpersonationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IncomingUseImpersonationName")
                    .ModelProperty("incominguseimpersonationname", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the owner")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Owner Id Type")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Yomi name of the owner")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the business unit that owns the record.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwningBusinessUnitName = group.Add(new VocabularyKey("OwningBusinessUnitName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwningBusinessUnitName")
                    .ModelProperty("owningbusinessunitname", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the team that owns the record.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the user that owns the record.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.IncomingPartnerApplication = group.Add(new VocabularyKey("IncomingPartnerApplication", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates the incoming partner application.")
                    .WithDisplayName("Incoming Partner Application")
                    .ModelProperty("incomingpartnerapplication", typeof(string)));

                this.IncomingPartnerApplicationName = group.Add(new VocabularyKey("IncomingPartnerApplicationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("IncomingPartnerApplicationName")
                    .ModelProperty("incomingpartnerapplicationname", typeof(string)));

                this.OutgoingPartnerApplication = group.Add(new VocabularyKey("OutgoingPartnerApplication", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates the outgoing partner application.")
                    .WithDisplayName("Outgoing Partner Application")
                    .ModelProperty("outgoingpartnerapplication", typeof(string)));

                this.OutgoingPartnerApplicationName = group.Add(new VocabularyKey("OutgoingPartnerApplicationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OutgoingPartnerApplicationName")
                    .ModelProperty("outgoingpartnerapplicationname", typeof(string)));

                this.MoveUndeliveredEmails = group.Add(new VocabularyKey("MoveUndeliveredEmails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether to move undelivered incoming emails to the Undeliverable folder in Microsoft Exchange.")
                    .WithDisplayName("Move Undelivered Emails to the Undeliverable Folder")
                    .ModelProperty("moveundeliveredemails", typeof(bool)));

                this.MoveUndeliveredEmailsName = group.Add(new VocabularyKey("MoveUndeliveredEmailsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MoveUndeliveredEmailsName")
                    .ModelProperty("moveundeliveredemailsname", typeof(string)));

                this.MinPollingIntervalInMinutes = group.Add(new VocabularyKey("MinPollingIntervalInMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Minimum polling interval, in minutes, for mailboxes that are associated with this email server profile.")
                    .WithDisplayName("Minimum Polling Interval In Minutes")
                    .ModelProperty("minpollingintervalinminutes", typeof(long)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information that describes the email server profile.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.UseSameSettingsForOutgoingConnections = group.Add(new VocabularyKey("UseSameSettingsForOutgoingConnections", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to use the same settings for incoming and outgoing connections.")
                    .WithDisplayName("Use Same Settings for Outgoing Connection")
                    .ModelProperty("usesamesettingsforoutgoingconnections", typeof(bool)));

                this.UseSameSettingsForOutgoingConnectionsName = group.Add(new VocabularyKey("UseSameSettingsForOutgoingConnectionsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("UseSameSettingsForOutgoingConnectionsName")
                    .ModelProperty("usesamesettingsforoutgoingconnectionsname", typeof(string)));

                this.IsIncomingPasswordSet = group.Add(new VocabularyKey("IsIncomingPasswordSet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsIncomingPasswordSet")
                    .ModelProperty("isincomingpasswordset", typeof(bool)));

                this.IsOutgoingPasswordSet = group.Add(new VocabularyKey("IsOutgoingPasswordSet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsOutgoingPasswordSet")
                    .ModelProperty("isoutgoingpasswordset", typeof(bool)));

                this.OutgoingAuthenticationProtocol = group.Add(new VocabularyKey("OutgoingAuthenticationProtocol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the outgoing email authentication protocol that is used for connecting to the email server.")
                    .WithDisplayName("Outgoing Authentication Protocol")
                    .ModelProperty("outgoingauthenticationprotocol", typeof(string)));

                this.OutgoingAuthenticationProtocolName = group.Add(new VocabularyKey("OutgoingAuthenticationProtocolName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OutgoingAuthenticationProtocolName")
                    .ModelProperty("outgoingauthenticationprotocolname", typeof(string)));

                this.ExchangeVersion = group.Add(new VocabularyKey("ExchangeVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the version of Exchange that is on the email server.")
                    .WithDisplayName("Exchange Version")
                    .ModelProperty("exchangeversion", typeof(string)));

                this.ExchangeVersionName = group.Add(new VocabularyKey("ExchangeVersionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ExchangeVersionName")
                    .ModelProperty("exchangeversionname", typeof(string)));

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The default image for the entity.")
                    .WithDisplayName("Entity Image")
                    .ModelProperty("entityimage", typeof(string)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));

                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_URL")
                    .ModelProperty("entityimage_url", typeof(string)));

                this.TimeoutMailboxConnection = group.Add(new VocabularyKey("TimeoutMailboxConnection", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to timeout a single mailbox.")
                    .WithDisplayName("Timeout Mailbox Connection to Exchange")
                    .ModelProperty("timeoutmailboxconnection", typeof(bool)));

                this.TimeoutMailboxConnectionName = group.Add(new VocabularyKey("TimeoutMailboxConnectionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TimeoutMailboxConnectionName")
                    .ModelProperty("timeoutmailboxconnectionname", typeof(string)));

                this.SendEmailAlert = group.Add(new VocabularyKey("SendEmailAlert", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to send an email alert if more than 50% of the mailboxes in this email server profile failed to synchronize in an hour period.")
                    .WithDisplayName("Send an alert email to the owner of the email server profile reporting on major events")
                    .ModelProperty("sendemailalert", typeof(bool)));

                this.SendEmailAlertName = group.Add(new VocabularyKey("SendEmailAlertName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SendEmailAlertName")
                    .ModelProperty("sendemailalertname", typeof(string)));

                this.TimeoutMailboxConnectionAfterAmount = group.Add(new VocabularyKey("TimeoutMailboxConnectionAfterAmount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the number of milliseconds to timeout a single mailbox. The upper limit is 100 seconds.")
                    .WithDisplayName("Timeout a Single Mailbox Connection After this Amount of Milliseconds")
                    .ModelProperty("timeoutmailboxconnectionafteramount", typeof(long)));

                this.EmailServerTypeName = group.Add(new VocabularyKey("EmailServerTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(250))
                    .WithDescription(@"Email Server Type Name")
                    .WithDisplayName("Email Server Type Name")
                    .ModelProperty("emailservertypename", typeof(string)));

                this.ExchangeOnlineTenantId = group.Add(new VocabularyKey("ExchangeOnlineTenantId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(36))
                    .WithDescription(@"Type the tenant ID of Exchange Online.")
                    .WithDisplayName("Exchange Online Tenant Id")
                    .ModelProperty("exchangeonlinetenantid", typeof(string)));

                this.LastTestExecutionStatus = group.Add(new VocabularyKey("LastTestExecutionStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the last test Execution status of email server profile")
                    .WithDisplayName("Last Test Execution Status")
                    .ModelProperty("lasttestexecutionstatus", typeof(string)));

                this.LastTestValidationStatus = group.Add(new VocabularyKey("LastTestValidationStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the last test Validation status of email server profile")
                    .WithDisplayName("Last Test Validation Status")
                    .ModelProperty("lasttestvalidationstatus", typeof(string)));

                this.LastTestRequest = group.Add(new VocabularyKey("LastTestRequest", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2084))
                    .WithDescription(@"Shows the EWS Request created during the Last Test")
                    .WithDisplayName("Last Test Request")
                    .ModelProperty("lasttestrequest", typeof(string)));

                this.LastTestResponse = group.Add(new VocabularyKey("LastTestResponse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2084))
                    .WithDescription(@"Shows the EWS Response obtained during the Last Test")
                    .WithDisplayName("Last Test Response")
                    .ModelProperty("lasttestresponse", typeof(string)));

                this.LastTestStartTime = group.Add(new VocabularyKey("LastTestStartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the Last Test Start date and time")
                    .WithDisplayName("Last Test Time")
                    .ModelProperty("lastteststarttime", typeof(DateTime)));

                this.LastTestTotalExecutionTime = group.Add(new VocabularyKey("LastTestTotalExecutionTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the Time taken while running the last test")
                    .WithDisplayName("Last Test Time Taken")
                    .ModelProperty("lasttesttotalexecutiontime", typeof(int)));

                this.OwnerEmailAddress = group.Add(new VocabularyKey("OwnerEmailAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Email Server Profile Owner's email address")
                    .WithDisplayName("Email Server Profile Owner's email address")
                    .ModelProperty("owneremailaddress", typeof(string)));

                this.UseDefaultTenantId = group.Add(new VocabularyKey("UseDefaultTenantId", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to use the Exchange Online Tenant ID obtained from running Microsoft Azure PowerShell cmdlets (highly recommended). If you select No, you can edit this field manually")
                    .WithDisplayName("Use Default Tenant Id")
                    .ModelProperty("usedefaulttenantid", typeof(bool)));

                this.UseDefaultTenantIdName = group.Add(new VocabularyKey("UseDefaultTenantIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("UseDefaultTenantIdName")
                    .ModelProperty("usedefaulttenantidname", typeof(string)));

                this.LastAuthorizationStatus = group.Add(new VocabularyKey("LastAuthorizationStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the last test authorization status of email server profile")
                    .WithDisplayName("Last Test Authorization Status")
                    .ModelProperty("lastauthorizationstatus", typeof(string)));

                this.LastCrmMessage = group.Add(new VocabularyKey("LastCrmMessage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2084))
                    .WithDescription(@"Shows the Dynamics 365 message obtained during the Last Test")
                    .WithDisplayName("Last Dynamics 365 Message")
                    .ModelProperty("lastcrmmessage", typeof(string)));

                this.DefaultServerLocation = group.Add(new VocabularyKey("DefaultServerLocation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2084))
                    .WithDescription(@"Type the default location of the server.")
                    .WithDisplayName("Default Email Server Location")
                    .ModelProperty("defaultserverlocation", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the email server profile.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey EmailServerProfileId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey ServerType { get; private set; }

        public VocabularyKey ServerTypeName { get; private set; }

        public VocabularyKey OutgoingServerLocation { get; private set; }

        public VocabularyKey IncomingServerLocation { get; private set; }

        public VocabularyKey IncomingUserName { get; private set; }

        public VocabularyKey IncomingPassword { get; private set; }

        public VocabularyKey OutgoingUsername { get; private set; }

        public VocabularyKey OutgoingPassword { get; private set; }

        public VocabularyKey IncomingPortNumber { get; private set; }

        public VocabularyKey OutgoingPortNumber { get; private set; }

        public VocabularyKey IncomingUseSSL { get; private set; }

        public VocabularyKey IncomingUseSslName { get; private set; }

        public VocabularyKey OutgoingUseSSL { get; private set; }

        public VocabularyKey OutgoingUseSslName { get; private set; }

        public VocabularyKey UseAutoDiscover { get; private set; }

        public VocabularyKey UseAutoDiscoverName { get; private set; }

        public VocabularyKey IncomingAuthenticationProtocol { get; private set; }

        public VocabularyKey IncomingAuthenticationProtocolName { get; private set; }

        public VocabularyKey OutgoingCredentialRetrieval { get; private set; }

        public VocabularyKey IncomingCredentialRetrieval { get; private set; }

        public VocabularyKey IncomingCredentialRetrievalName { get; private set; }

        public VocabularyKey OutgoingCredentialRetrievalName { get; private set; }

        public VocabularyKey EncodingCodePage { get; private set; }

        public VocabularyKey ProcessEmailsReceivedAfter { get; private set; }

        public VocabularyKey MaxConcurrentConnections { get; private set; }

        public VocabularyKey OutgoingAutoGrantDelegateAccess { get; private set; }

        public VocabularyKey OutgoingAutoGrantDelegateAccessName { get; private set; }

        public VocabularyKey OutgoingUseImpersonation { get; private set; }

        public VocabularyKey OutgoingUseImpersonationName { get; private set; }

        public VocabularyKey IncomingUseImpersonation { get; private set; }

        public VocabularyKey IncomingUseImpersonationName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningBusinessUnitName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey IncomingPartnerApplication { get; private set; }

        public VocabularyKey IncomingPartnerApplicationName { get; private set; }

        public VocabularyKey OutgoingPartnerApplication { get; private set; }

        public VocabularyKey OutgoingPartnerApplicationName { get; private set; }

        public VocabularyKey MoveUndeliveredEmails { get; private set; }

        public VocabularyKey MoveUndeliveredEmailsName { get; private set; }

        public VocabularyKey MinPollingIntervalInMinutes { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey UseSameSettingsForOutgoingConnections { get; private set; }

        public VocabularyKey UseSameSettingsForOutgoingConnectionsName { get; private set; }

        public VocabularyKey IsIncomingPasswordSet { get; private set; }

        public VocabularyKey IsOutgoingPasswordSet { get; private set; }

        public VocabularyKey OutgoingAuthenticationProtocol { get; private set; }

        public VocabularyKey OutgoingAuthenticationProtocolName { get; private set; }

        public VocabularyKey ExchangeVersion { get; private set; }

        public VocabularyKey ExchangeVersionName { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey TimeoutMailboxConnection { get; private set; }

        public VocabularyKey TimeoutMailboxConnectionName { get; private set; }

        public VocabularyKey SendEmailAlert { get; private set; }

        public VocabularyKey SendEmailAlertName { get; private set; }

        public VocabularyKey TimeoutMailboxConnectionAfterAmount { get; private set; }

        public VocabularyKey EmailServerTypeName { get; private set; }

        public VocabularyKey ExchangeOnlineTenantId { get; private set; }

        public VocabularyKey LastTestExecutionStatus { get; private set; }

        public VocabularyKey LastTestValidationStatus { get; private set; }

        public VocabularyKey LastTestRequest { get; private set; }

        public VocabularyKey LastTestResponse { get; private set; }

        public VocabularyKey LastTestStartTime { get; private set; }

        public VocabularyKey LastTestTotalExecutionTime { get; private set; }

        public VocabularyKey OwnerEmailAddress { get; private set; }

        public VocabularyKey UseDefaultTenantId { get; private set; }

        public VocabularyKey UseDefaultTenantIdName { get; private set; }

        public VocabularyKey LastAuthorizationStatus { get; private set; }

        public VocabularyKey LastCrmMessage { get; private set; }

        public VocabularyKey DefaultServerLocation { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }


    }
}

