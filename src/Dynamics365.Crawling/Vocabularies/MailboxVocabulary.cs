using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class MailboxVocabulary : SimpleVocabulary
    {
        public MailboxVocabulary()
        {
            VocabularyName = "Dynamics365 Mailbox";
            KeyPrefix = "dynamics365.mailbox";
            KeySeparator = ".";
            Grouping = EntityType.Mail.Folder;

            this.AddGroup("Mailbox", group =>
            {
                this.MailboxId = group.Add(new VocabularyKey("MailboxId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the mailbox.")
                    .WithDisplayName("Mailbox")
                    .ModelProperty("mailboxid", typeof(Guid)));

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
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Owner Id Type")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the owner")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Yomi name of the owner")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the business unit that owns the record.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the user that owns the record.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the team that owns the record.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the mailbox is active or inactive.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the mailbox's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.ExchangeSyncStateXml = group.Add(new VocabularyKey("ExchangeSyncStateXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Contains the exchange synchronization state in XML format.")
                    .WithDisplayName("Exchange Sync State")
                    .ModelProperty("exchangesyncstatexml", typeof(string)));

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
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type the name of the mailbox.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.EmailAddress = group.Add(new VocabularyKey("EmailAddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type the email address of the mailbox.")
                    .WithDisplayName("Email Address")
                    .ModelProperty("emailaddress", typeof(string)));

                this.IncomingEmailDeliveryMethod = group.Add(new VocabularyKey("IncomingEmailDeliveryMethod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select how incoming email will be delivered to the mailbox.")
                    .WithDisplayName("Incoming Email")
                    .ModelProperty("incomingemaildeliverymethod", typeof(string)));

                this.IncomingEmailDeliveryMethodName = group.Add(new VocabularyKey("IncomingEmailDeliveryMethodName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IncomingEmailDeliveryMethodName")
                    .ModelProperty("incomingemaildeliverymethodname", typeof(string)));

                this.OutgoingEmailDeliveryMethod = group.Add(new VocabularyKey("OutgoingEmailDeliveryMethod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select how outgoing email will be sent from the mailbox.")
                    .WithDisplayName("Outgoing Email")
                    .ModelProperty("outgoingemaildeliverymethod", typeof(string)));

                this.OutgoingEmailDeliveryMethodName = group.Add(new VocabularyKey("OutgoingEmailDeliveryMethodName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OutgoingEmailDeliveryMethodName")
                    .ModelProperty("outgoingemaildeliverymethodname", typeof(string)));

                this.ProcessAndDeleteEmails = group.Add(new VocabularyKey("ProcessAndDeleteEmails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether to delete emails from the mailbox after processing.")
                    .WithDisplayName("Delete Emails after Processing")
                    .ModelProperty("processanddeleteemails", typeof(bool)));

                this.ProcessAndDeleteEmailsName = group.Add(new VocabularyKey("ProcessAndDeleteEmailsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ProcessAndDeleteEmailsName")
                    .ModelProperty("processanddeleteemailsname", typeof(string)));

                this.AllowEmailConnectorToUseCredentials = group.Add(new VocabularyKey("AllowEmailConnectorToUseCredentials", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether to allow the email connector to use credentials.")
                    .WithDisplayName("Allow to Use Credentials for Email Processing")
                    .ModelProperty("allowemailconnectortousecredentials", typeof(bool)));

                this.AllowEmailConnectorToUseCredentialsName = group.Add(new VocabularyKey("AllowEmailConnectorToUseCredentialsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AllowEmailConnectorToUseCredentialsName")
                    .ModelProperty("allowemailconnectortousecredentialsname", typeof(string)));

                this.Username = group.Add(new VocabularyKey("Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type a user name used for mailbox authentication.")
                    .WithDisplayName("User Name")
                    .ModelProperty("username", typeof(string)));

                this.Password = group.Add(new VocabularyKey("Password", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type the password for the mailbox.")
                    .WithDisplayName("Password")
                    .ModelProperty("password", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Choose the user associated to the mailbox.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"Name for User associated with Mailbox.")
                    .WithDisplayName("Regarding Name")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.EmailServerProfile = group.Add(new VocabularyKey("EmailServerProfile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the email server profile of the mailbox.")
                    .WithDisplayName("Server Profile")
                    .ModelProperty("emailserverprofile", typeof(string)));

                this.EmailServerProfileName = group.Add(new VocabularyKey("EmailServerProfileName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("EmailServerProfileName")
                    .ModelProperty("emailserverprofilename", typeof(string)));

                this.IsForwardMailbox = group.Add(new VocabularyKey("IsForwardMailbox", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select whether the mailbox is a forward mailbox.")
                    .WithDisplayName("Is Forward Mailbox")
                    .ModelProperty("isforwardmailbox", typeof(bool)));

                this.IsForwardMailboxName = group.Add(new VocabularyKey("IsForwardMailboxName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsForwardMailboxName")
                    .ModelProperty("isforwardmailboxname", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Object Type of the entity associated with the mailbox.")
                    .WithDisplayName("Regarding Object Type Code")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the record.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.OwningBusinessUnitName = group.Add(new VocabularyKey("OwningBusinessUnitName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("OwningBusinessUnitName")
                    .ModelProperty("owningbusinessunitname", typeof(string)));

                this.EmailRouterAccessApproval = group.Add(new VocabularyKey("EmailRouterAccessApproval", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the status of the email address.")
                    .WithDisplayName("Email Address Status")
                    .ModelProperty("emailrouteraccessapproval", typeof(string)));

                this.EmailRouterAccessApprovalName = group.Add(new VocabularyKey("EmailRouterAccessApprovalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EmailRouterAccessApprovalName")
                    .ModelProperty("emailrouteraccessapprovalname", typeof(string)));

                this.HostId = group.Add(new VocabularyKey("HostId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Unique identifier of the async host that is processing this mailbox.")
                    .WithDisplayName("Host")
                    .ModelProperty("hostid", typeof(string)));

                this.NoEmailCount = group.Add(new VocabularyKey("NoEmailCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Zero email count for mailbox")
                    .ModelProperty("noemailcount", typeof(long)));

                this.ProcessEmailReceivedAfter = group.Add(new VocabularyKey("ProcessEmailReceivedAfter", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time to start processing email received by the mailbox.")
                    .WithDisplayName("Process Email Received After")
                    .ModelProperty("processemailreceivedafter", typeof(DateTime)));

                this.ReceivingPostponedUntil = group.Add(new VocabularyKey("ReceivingPostponedUntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Postpone receiving emails for the mailbox until the specified data and time.")
                    .ModelProperty("receivingpostponeduntil", typeof(DateTime)));

                this.LastMessageId = group.Add(new VocabularyKey("LastMessageId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(320))
                    .WithDescription(@"Unique identifier of the last message.")
                    .WithDisplayName("Last Message ID")
                    .ModelProperty("lastmessageid", typeof(string)));

                this.OutgoingEmailStatus = group.Add(new VocabularyKey("OutgoingEmailStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the status of outgoing email messages.")
                    .WithDisplayName("Outgoing Email Status")
                    .ModelProperty("outgoingemailstatus", typeof(string)));

                this.OutgoingEmailStatusName = group.Add(new VocabularyKey("OutgoingEmailStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OutgoingEmailStatusName")
                    .ModelProperty("outgoingemailstatusname", typeof(string)));

                this.IncomingEmailStatus = group.Add(new VocabularyKey("IncomingEmailStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the status that will be assigned to incoming email messages.")
                    .WithDisplayName("Incoming Email Status")
                    .ModelProperty("incomingemailstatus", typeof(string)));

                this.IncomingEmailStatusName = group.Add(new VocabularyKey("IncomingEmailStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IncomingEmailStatusName")
                    .ModelProperty("incomingemailstatusname", typeof(string)));

                this.TestMailboxAccessCompletedOn = group.Add(new VocabularyKey("TestMailboxAccessCompletedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Date and time when the last email configuration test was completed for a mailbox record.")
                    .WithDisplayName("Mailbox Test Completed On")
                    .ModelProperty("testmailboxaccesscompletedon", typeof(DateTime)));

                this.TestEmailConfigurationScheduled = group.Add(new VocabularyKey("TestEmailConfigurationScheduled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates if the email configuration test has been scheduled for a mailbox record.")
                    .WithDisplayName("Test Email Configuration Scheduled")
                    .ModelProperty("testemailconfigurationscheduled", typeof(bool)));

                this.EnabledForIncomingEmail = group.Add(new VocabularyKey("EnabledForIncomingEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether the mailbox is enabled for receiving email.")
                    .WithDisplayName("Enabled For Incoming Email")
                    .ModelProperty("enabledforincomingemail", typeof(bool)));

                this.TransientFailureCount = group.Add(new VocabularyKey("TransientFailureCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Concatenation of transient failure counts of all mailbox operations.")
                    .WithDisplayName("Transient Failure Count")
                    .ModelProperty("transientfailurecount", typeof(long)));

                this.ACTDeliveryMethod = group.Add(new VocabularyKey("ACTDeliveryMethod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the delivery method for the mailbox for appointments, contacts, and tasks.")
                    .WithDisplayName("Appointments, Contacts, and Tasks")
                    .ModelProperty("actdeliverymethod", typeof(string)));

                this.ACTDeliveryMethodName = group.Add(new VocabularyKey("ACTDeliveryMethodName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ACTDeliveryMethodName")
                    .ModelProperty("actdeliverymethodname", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the mailbox.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.TestEmailConfigurationScheduledName = group.Add(new VocabularyKey("TestEmailConfigurationScheduledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TestEmailConfigurationScheduledName")
                    .ModelProperty("testemailconfigurationscheduledname", typeof(string)));

                this.PostponeTestEmailConfigurationUntil = group.Add(new VocabularyKey("PostponeTestEmailConfigurationUntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time when the next email configuration test will be run for a mailbox record.")
                    .WithDisplayName("Postpone Test Email Configuration Until")
                    .ModelProperty("postponetestemailconfigurationuntil", typeof(DateTime)));

                this.TestEmailConfigurationRetryCount = group.Add(new VocabularyKey("TestEmailConfigurationRetryCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the number of times an email configuration test has been performed.")
                    .WithDisplayName("Test Email Configuration Retry Count")
                    .ModelProperty("testemailconfigurationretrycount", typeof(long)));

                this.PostponeSendingUntil = group.Add(new VocabularyKey("PostponeSendingUntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time when the mailbox can start sending emails.")
                    .WithDisplayName("Postpone Sending Until")
                    .ModelProperty("postponesendinguntil", typeof(DateTime)));

                this.LastActiveOn = group.Add(new VocabularyKey("LastActiveOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Last Active On")
                    .ModelProperty("lastactiveon", typeof(DateTime)));

                this.UndeliverableFolder = group.Add(new VocabularyKey("UndeliverableFolder", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Shows the ID of the Undeliverable folder in the mailbox managed by Microsoft Exchange.")
                    .WithDisplayName("Undeliverable Folder")
                    .ModelProperty("undeliverablefolder", typeof(string)));

                this.IsPasswordSet = group.Add(new VocabularyKey("IsPasswordSet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPasswordSet")
                    .ModelProperty("ispasswordset", typeof(bool)));

                this.EnabledForIncomingEmailName = group.Add(new VocabularyKey("EnabledForIncomingEmailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EnabledForIncomingEmailName")
                    .ModelProperty("enabledforincomingemailname", typeof(string)));

                this.EnabledForOutgoingEmail = group.Add(new VocabularyKey("EnabledForOutgoingEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose whether the mailbox is enabled for sending email.")
                    .WithDisplayName("Enabled For Outgoing Email")
                    .ModelProperty("enabledforoutgoingemail", typeof(bool)));

                this.EnabledForOutgoingEmailName = group.Add(new VocabularyKey("EnabledForOutgoingEmailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EnabledForOutgoingEmailName")
                    .ModelProperty("enabledforoutgoingemailname", typeof(string)));

                this.ProcessingStateCode = group.Add(new VocabularyKey("ProcessingStateCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information that indicates whether email will be processed for this mailbox")
                    .WithDisplayName("Mailbox Processing State")
                    .ModelProperty("processingstatecode", typeof(long)));

                this.LastAutoDiscoveredOn = group.Add(new VocabularyKey("LastAutoDiscoveredOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time when the Exchange web services URL was last discovered using the AutoDiscover service.")
                    .WithDisplayName("Last Auto Discovered On")
                    .ModelProperty("lastautodiscoveredon", typeof(DateTime)));

                this.PostponeMailboxProcessingUntil = group.Add(new VocabularyKey("PostponeMailboxProcessingUntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time when processing will begin on this mailbox.")
                    .WithDisplayName("Postpone Mailbox Processing Until")
                    .ModelProperty("postponemailboxprocessinguntil", typeof(DateTime)));

                this.EWSURL = group.Add(new VocabularyKey("EWSURL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2084))
                    .WithDescription(@"Exchange web services endpoint URL for the mailbox.")
                    .WithDisplayName("Exchange Web Services URL")
                    .ModelProperty("ewsurl", typeof(string)));

                this.MailboxProcessingContext = group.Add(new VocabularyKey("MailboxProcessingContext", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Processing Context of the Mailbox")
                    .ModelProperty("mailboxprocessingcontext", typeof(long)));

                this.EnabledForACT = group.Add(new VocabularyKey("EnabledForACT", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the mailbox is enabled for Appointments, Contacts, and Tasks.")
                    .WithDisplayName("Enabled For Appointments, Contacts, And Tasks")
                    .ModelProperty("enabledforact", typeof(bool)));

                this.EnabledForACTName = group.Add(new VocabularyKey("EnabledForACTName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EnabledForACTName")
                    .ModelProperty("enabledforactname", typeof(string)));

                this.ReceivingPostponedUntilForACT = group.Add(new VocabularyKey("ReceivingPostponedUntilForACT", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Postpone processing Appointments, Contacts, and Tasks for the mailbox until the specified data and time.")
                    .ModelProperty("receivingpostponeduntilforact", typeof(DateTime)));

                this.NoACTCount = group.Add(new VocabularyKey("NoACTCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Zero appointment, contact, task count for mailbox")
                    .ModelProperty("noactcount", typeof(long)));

                this.ACTStatus = group.Add(new VocabularyKey("ACTStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Status of the Appointments, Contacts, and Tasks.")
                    .WithDisplayName("Appointments, Contacts, and Tasks Status")
                    .ModelProperty("actstatus", typeof(string)));

                this.ACTStatusName = group.Add(new VocabularyKey("ACTStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ACTStatusName")
                    .ModelProperty("actstatusname", typeof(string)));

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

                this.IsEmailAddressApprovedByO365Admin = group.Add(new VocabularyKey("IsEmailAddressApprovedByO365Admin", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the status of approval of the email address by O365 Admin.")
                    .WithDisplayName("Email Address O365 Admin Approval Status")
                    .ModelProperty("isemailaddressapprovedbyo365admin", typeof(bool)));

                this.IsACTSyncOrgFlagSet = group.Add(new VocabularyKey("IsACTSyncOrgFlagSet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Set the current organization as the synchronization organization.")
                    .WithDisplayName("Set Current Organization as Synchronization Organization")
                    .ModelProperty("isactsyncorgflagset", typeof(bool)));

                this.ProcessedTimes = group.Add(new VocabularyKey("ProcessedTimes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The number of times mailbox has processed")
                    .WithDisplayName("Monitor Performance")
                    .ModelProperty("processedtimes", typeof(long)));

                this.LastDuration = group.Add(new VocabularyKey("LastDuration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last Duration for the mailbox")
                    .WithDisplayName("Monitor last duration Performance")
                    .ModelProperty("lastduration", typeof(long)));

                this.OrgMarkedAsPrimaryForExchangeSync = group.Add(new VocabularyKey("OrgMarkedAsPrimaryForExchangeSync", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates if the crm org is to be marked as primary syncing org for the mailbox record.")
                    .WithDisplayName("Crm Org Marked as Primary Org for Exchange Mailbox")
                    .ModelProperty("orgmarkedasprimaryforexchangesync", typeof(bool)));

                this.AverageTotalDuration = group.Add(new VocabularyKey("AverageTotalDuration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Mailbox Total Duration in Average")
                    .WithDisplayName("Monitor Total Performance")
                    .ModelProperty("averagetotalduration", typeof(long)));

                this.LastSyncErrorCode = group.Add(new VocabularyKey("LastSyncErrorCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Last Sync Error Code")
                    .ModelProperty("lastsyncerrorcode", typeof(long)));

                this.LastSyncError = group.Add(new VocabularyKey("LastSyncError", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2048))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Last Sync Error Stack")
                    .ModelProperty("lastsyncerror", typeof(string)));

                this.LastSyncErrorCount = group.Add(new VocabularyKey("LastSyncErrorCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only")
                    .WithDisplayName("Last Sync Error Continuous Count")
                    .ModelProperty("lastsyncerrorcount", typeof(long)));

                this.LastSyncErrorOccurredOn = group.Add(new VocabularyKey("LastSyncErrorOccurredOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Last Sync Error Time")
                    .ModelProperty("lastsyncerroroccurredon", typeof(DateTime)));

                this.LastSyncErrorMachineName = group.Add(new VocabularyKey("LastSyncErrorMachineName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(320))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Last Sync Error Machine Name")
                    .ModelProperty("lastsyncerrormachinename", typeof(string)));

                this.ItemsProcessedForLastSync = group.Add(new VocabularyKey("ItemsProcessedForLastSync", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Items Processed For Last Sync")
                    .ModelProperty("itemsprocessedforlastsync", typeof(long)));

                this.ItemsFailedForLastSync = group.Add(new VocabularyKey("ItemsFailedForLastSync", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Items Failed For Last Sync")
                    .ModelProperty("itemsfailedforlastsync", typeof(long)));

                this.LastSyncStartedOn = group.Add(new VocabularyKey("LastSyncStartedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last Sync Start Time")
                    .WithDisplayName("Last Sync Start Time")
                    .ModelProperty("lastsyncstartedon", typeof(DateTime)));

                this.LastSuccessfulSyncCompletedOn = group.Add(new VocabularyKey("LastSuccessfulSyncCompletedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Last Successful Sync Time")
                    .WithDisplayName("Last Successful Sync Time")
                    .ModelProperty("lastsuccessfulsynccompletedon", typeof(DateTime)));

                this.FolderHierarchy = group.Add(new VocabularyKey("FolderHierarchy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1048576))
                    .WithDescription(@"Holds the hierarchy of folders under inbox in XML format.")
                    .WithDisplayName("Folder Hierarchy")
                    .ModelProperty("folderhierarchy", typeof(string)));

                this.ProcessingLastAttemptedOn = group.Add(new VocabularyKey("ProcessingLastAttemptedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the processing of the mailbox was last attempted.")
                    .WithDisplayName("Date Processing Last Attempted")
                    .ModelProperty("processinglastattemptedon", typeof(DateTime)));

                this.ForcedUnlockCount = group.Add(new VocabularyKey("ForcedUnlockCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only")
                    .WithDisplayName("Count of the number of times a mailbox gets forced unlocked")
                    .ModelProperty("forcedunlockcount", typeof(long)));

                this.LastMailboxForcedUnlockOccurredOn = group.Add(new VocabularyKey("LastMailboxForcedUnlockOccurredOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Last Date Time when a mailbox got forced unlocked")
                    .ModelProperty("lastmailboxforcedunlockoccurredon", typeof(DateTime)));

                this.IsServiceAccount = group.Add(new VocabularyKey("IsServiceAccount", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select whether the mailbox corresponds to one for the service account.")
                    .WithDisplayName("Is Service Account")
                    .ModelProperty("isserviceaccount", typeof(bool)));

                this.VerboseLoggingEnabled = group.Add(new VocabularyKey("VerboseLoggingEnabled", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates if verbose tracing needs to be enabled for this mailbox.")
                    .WithDisplayName("Verbose Logging")
                    .ModelProperty("verboseloggingenabled", typeof(long)));

                this.OfficeAppsDeploymentScheduled = group.Add(new VocabularyKey("OfficeAppsDeploymentScheduled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates if the office apps deployment has been scheduled for a mailbox record.")
                    .WithDisplayName("Office Apps Deployment Scheduled")
                    .ModelProperty("officeappsdeploymentscheduled", typeof(bool)));

                this.OfficeAppsDeploymentScheduledName = group.Add(new VocabularyKey("OfficeAppsDeploymentScheduledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OfficeAppsDeploymentScheduledName")
                    .ModelProperty("officeappsdeploymentscheduledname", typeof(string)));

                this.OfficeAppsDeploymentStatus = group.Add(new VocabularyKey("OfficeAppsDeploymentStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates the office apps deployment type for a mailbox record.")
                    .WithDisplayName("Office Apps Deployment Type")
                    .ModelProperty("officeappsdeploymentstatus", typeof(string)));

                this.OfficeAppsDeploymentStatusName = group.Add(new VocabularyKey("OfficeAppsDeploymentStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OfficeAppsDeploymentStatusName")
                    .ModelProperty("officeappsdeploymentstatusname", typeof(string)));

                this.OfficeAppsDeploymentCompleteOn = group.Add(new VocabularyKey("OfficeAppsDeploymentCompleteOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the last office apps deployment was completed for a mailbox record.")
                    .WithDisplayName("Office Apps Deployment Completed On")
                    .ModelProperty("officeappsdeploymentcompleteon", typeof(DateTime)));

                this.OfficeAppsDeploymentError = group.Add(new VocabularyKey("OfficeAppsDeploymentError", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2048))
                    .WithDescription(@"The Office Apps deployment error.")
                    .WithDisplayName("Office Apps Deployment Error")
                    .ModelProperty("officeappsdeploymenterror", typeof(string)));

                this.PostponeOfficeAppsDeploymentUntil = group.Add(new VocabularyKey("PostponeOfficeAppsDeploymentUntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time when the next outlook mail app install will be run for a mailbox record.")
                    .WithDisplayName("Postpone Outlook Mail App Install Until")
                    .ModelProperty("postponeofficeappsdeploymentuntil", typeof(DateTime)));

                this.MailboxStatus = group.Add(new VocabularyKey("MailboxStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last Sync Status for Outgoing, Incoming and ACT as a whole.")
                    .WithDisplayName("Mailbox Status")
                    .ModelProperty("mailboxstatus", typeof(string)));

                this.MailboxStatusName = group.Add(new VocabularyKey("MailboxStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MailboxStatusName")
                    .ModelProperty("mailboxstatusname", typeof(string)));

                this.IsExchangeContactsImportScheduled = group.Add(new VocabularyKey("IsExchangeContactsImportScheduled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Is Exchange Contacts Import Scheduled.")
                    .WithDisplayName("Is Exchange Contacts Import Scheduled.")
                    .ModelProperty("isexchangecontactsimportscheduled", typeof(bool)));

                this.ExchangeContactsImportStatus = group.Add(new VocabularyKey("ExchangeContactsImportStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates the exchange contacts import status for a mailbox record.")
                    .WithDisplayName("Exchange Contacts Import Status")
                    .ModelProperty("exchangecontactsimportstatus", typeof(string)));

                this.ExchangeContactsImportCompletedOn = group.Add(new VocabularyKey("ExchangeContactsImportCompletedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the exchange contacts import was last completed for a mailbox record.")
                    .WithDisplayName("Exchange Contacts Import Completed On")
                    .ModelProperty("exchangecontactsimportcompletedon", typeof(DateTime)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey MailboxId { get; private set; }

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

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey ExchangeSyncStateXml { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey EmailAddress { get; private set; }

        public VocabularyKey IncomingEmailDeliveryMethod { get; private set; }

        public VocabularyKey IncomingEmailDeliveryMethodName { get; private set; }

        public VocabularyKey OutgoingEmailDeliveryMethod { get; private set; }

        public VocabularyKey OutgoingEmailDeliveryMethodName { get; private set; }

        public VocabularyKey ProcessAndDeleteEmails { get; private set; }

        public VocabularyKey ProcessAndDeleteEmailsName { get; private set; }

        public VocabularyKey AllowEmailConnectorToUseCredentials { get; private set; }

        public VocabularyKey AllowEmailConnectorToUseCredentialsName { get; private set; }

        public VocabularyKey Username { get; private set; }

        public VocabularyKey Password { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey EmailServerProfile { get; private set; }

        public VocabularyKey EmailServerProfileName { get; private set; }

        public VocabularyKey IsForwardMailbox { get; private set; }

        public VocabularyKey IsForwardMailboxName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey OwningBusinessUnitName { get; private set; }

        public VocabularyKey EmailRouterAccessApproval { get; private set; }

        public VocabularyKey EmailRouterAccessApprovalName { get; private set; }

        public VocabularyKey HostId { get; private set; }

        public VocabularyKey NoEmailCount { get; private set; }

        public VocabularyKey ProcessEmailReceivedAfter { get; private set; }

        public VocabularyKey ReceivingPostponedUntil { get; private set; }

        public VocabularyKey LastMessageId { get; private set; }

        public VocabularyKey OutgoingEmailStatus { get; private set; }

        public VocabularyKey OutgoingEmailStatusName { get; private set; }

        public VocabularyKey IncomingEmailStatus { get; private set; }

        public VocabularyKey IncomingEmailStatusName { get; private set; }

        public VocabularyKey TestMailboxAccessCompletedOn { get; private set; }

        public VocabularyKey TestEmailConfigurationScheduled { get; private set; }

        public VocabularyKey EnabledForIncomingEmail { get; private set; }

        public VocabularyKey TransientFailureCount { get; private set; }

        public VocabularyKey ACTDeliveryMethod { get; private set; }

        public VocabularyKey ACTDeliveryMethodName { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey TestEmailConfigurationScheduledName { get; private set; }

        public VocabularyKey PostponeTestEmailConfigurationUntil { get; private set; }

        public VocabularyKey TestEmailConfigurationRetryCount { get; private set; }

        public VocabularyKey PostponeSendingUntil { get; private set; }

        public VocabularyKey LastActiveOn { get; private set; }

        public VocabularyKey UndeliverableFolder { get; private set; }

        public VocabularyKey IsPasswordSet { get; private set; }

        public VocabularyKey EnabledForIncomingEmailName { get; private set; }

        public VocabularyKey EnabledForOutgoingEmail { get; private set; }

        public VocabularyKey EnabledForOutgoingEmailName { get; private set; }

        public VocabularyKey ProcessingStateCode { get; private set; }

        public VocabularyKey LastAutoDiscoveredOn { get; private set; }

        public VocabularyKey PostponeMailboxProcessingUntil { get; private set; }

        public VocabularyKey EWSURL { get; private set; }

        public VocabularyKey MailboxProcessingContext { get; private set; }

        public VocabularyKey EnabledForACT { get; private set; }

        public VocabularyKey EnabledForACTName { get; private set; }

        public VocabularyKey ReceivingPostponedUntilForACT { get; private set; }

        public VocabularyKey NoACTCount { get; private set; }

        public VocabularyKey ACTStatus { get; private set; }

        public VocabularyKey ACTStatusName { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey IsEmailAddressApprovedByO365Admin { get; private set; }

        public VocabularyKey IsACTSyncOrgFlagSet { get; private set; }

        public VocabularyKey ProcessedTimes { get; private set; }

        public VocabularyKey LastDuration { get; private set; }

        public VocabularyKey OrgMarkedAsPrimaryForExchangeSync { get; private set; }

        public VocabularyKey AverageTotalDuration { get; private set; }

        public VocabularyKey LastSyncErrorCode { get; private set; }

        public VocabularyKey LastSyncError { get; private set; }

        public VocabularyKey LastSyncErrorCount { get; private set; }

        public VocabularyKey LastSyncErrorOccurredOn { get; private set; }

        public VocabularyKey LastSyncErrorMachineName { get; private set; }

        public VocabularyKey ItemsProcessedForLastSync { get; private set; }

        public VocabularyKey ItemsFailedForLastSync { get; private set; }

        public VocabularyKey LastSyncStartedOn { get; private set; }

        public VocabularyKey LastSuccessfulSyncCompletedOn { get; private set; }

        public VocabularyKey FolderHierarchy { get; private set; }

        public VocabularyKey ProcessingLastAttemptedOn { get; private set; }

        public VocabularyKey ForcedUnlockCount { get; private set; }

        public VocabularyKey LastMailboxForcedUnlockOccurredOn { get; private set; }

        public VocabularyKey IsServiceAccount { get; private set; }

        public VocabularyKey VerboseLoggingEnabled { get; private set; }

        public VocabularyKey OfficeAppsDeploymentScheduled { get; private set; }

        public VocabularyKey OfficeAppsDeploymentScheduledName { get; private set; }

        public VocabularyKey OfficeAppsDeploymentStatus { get; private set; }

        public VocabularyKey OfficeAppsDeploymentStatusName { get; private set; }

        public VocabularyKey OfficeAppsDeploymentCompleteOn { get; private set; }

        public VocabularyKey OfficeAppsDeploymentError { get; private set; }

        public VocabularyKey PostponeOfficeAppsDeploymentUntil { get; private set; }

        public VocabularyKey MailboxStatus { get; private set; }

        public VocabularyKey MailboxStatusName { get; private set; }

        public VocabularyKey IsExchangeContactsImportScheduled { get; private set; }

        public VocabularyKey ExchangeContactsImportStatus { get; private set; }

        public VocabularyKey ExchangeContactsImportCompletedOn { get; private set; }


    }
}

