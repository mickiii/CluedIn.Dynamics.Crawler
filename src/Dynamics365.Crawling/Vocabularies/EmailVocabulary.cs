using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class EmailVocabulary : SimpleVocabulary
    {
        public EmailVocabulary()
        {
            VocabularyName = "Dynamics365 Email";
            KeyPrefix = "dynamics365.email";
            KeySeparator = ".";
            Grouping = EntityType.Mail;

            this.AddGroup("Email", group =>
            {
                this.ScheduledStart = group.Add(new VocabularyKey("ScheduledStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the expected start date and time for the activity to provide details about the tentative time when the email activity must be initiated.")
                    .WithDisplayName("Start Date")
                    .ModelProperty("scheduledstart", typeof(DateTime)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the email's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.SubmittedBy = group.Add(new VocabularyKey("SubmittedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Shows the Microsoft Office Outlook account for the user who submitted the email to Microsoft Dynamics 365.")
                    .WithDisplayName("Submitted By")
                    .ModelProperty("submittedby", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Type the greeting and message text of the email.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.to = group.Add(new VocabularyKey("to", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the account, contact, lead, queue, or user recipients for the email.")
                    .WithDisplayName("To")
                    .ModelProperty("to", typeof(string)));

                this.IsWorkflowCreated = group.Add(new VocabularyKey("IsWorkflowCreated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indication if the email was created by a workflow rule.")
                    .WithDisplayName("Is Workflow Created")
                    .ModelProperty("isworkflowcreated", typeof(bool)));

                this.ActivityId = group.Add(new VocabularyKey("ActivityId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the email activity.")
                    .WithDisplayName("Email Message")
                    .ModelProperty("activityid", typeof(Guid)));

                this.ScheduledEnd = group.Add(new VocabularyKey("ScheduledEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the expected due date and time for the activity to be completed to provide details about when the email will be sent.")
                    .WithDisplayName("Due Date")
                    .ModelProperty("scheduledend", typeof(DateTime)));

                this.MimeType = group.Add(new VocabularyKey("MimeType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"MIME type of the email message data.")
                    .WithDisplayName("Mime Type")
                    .ModelProperty("mimetype", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the email message.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ReadReceiptRequested = group.Add(new VocabularyKey("ReadReceiptRequested", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates that a read receipt is requested.")
                    .WithDisplayName("Read Receipt Requested")
                    .ModelProperty("readreceiptrequested", typeof(bool)));

                this.Subcategory = group.Add(new VocabularyKey("Subcategory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type a subcategory to identify the email type and relate the activity to a specific product, sales region, business group, or other function.")
                    .WithDisplayName("Sub-Category")
                    .ModelProperty("subcategory", typeof(string)));

                this.IsBilled = group.Add(new VocabularyKey("IsBilled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information regarding whether the email activity was billed as part of resolving a case.")
                    .WithDisplayName("Is Billed")
                    .ModelProperty("isbilled", typeof(bool)));

                this.ActualDurationMinutes = group.Add(new VocabularyKey("ActualDurationMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type the number of minutes spent creating and sending the email. The duration is used in reporting.")
                    .WithDisplayName("Duration")
                    .ModelProperty("actualdurationminutes", typeof(long)));

                this.PriorityCode = group.Add(new VocabularyKey("PriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the priority so that preferred customers or critical issues are handled quickly.")
                    .WithDisplayName("Priority")
                    .ModelProperty("prioritycode", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ActualStart = group.Add(new VocabularyKey("ActualStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the actual start date and time for the email. By default, it displays the date and time when the activity was created, but can be edited to capture the actual time to create and send the email.")
                    .WithDisplayName("Actual Start")
                    .ModelProperty("actualstart", typeof(DateTime)));

                this.from = group.Add(new VocabularyKey("from", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the sender of the email.")
                    .WithDisplayName("From")
                    .ModelProperty("from", typeof(string)));

                this.DirectionCode = group.Add(new VocabularyKey("DirectionCode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the direction of the email as incoming or outbound.")
                    .WithDisplayName("Direction")
                    .ModelProperty("directioncode", typeof(bool)));

                this.ActualEnd = group.Add(new VocabularyKey("ActualEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the actual end date and time of the email. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual time to create and send the email.")
                    .WithDisplayName("Actual End")
                    .ModelProperty("actualend", typeof(DateTime)));

                this.TrackingToken = group.Add(new VocabularyKey("TrackingToken", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Shows the tracking token assigned to the email to make sure responses are automatically tracked in Microsoft Dynamics 365.")
                    .WithDisplayName("Tracking Token")
                    .ModelProperty("trackingtoken", typeof(string)));

                this.ServiceId = group.Add(new VocabularyKey("ServiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"service_emails")
                    .WithDisplayName("Service")
                    .ModelProperty("serviceid", typeof(string)));

                this.ScheduledDurationMinutes = group.Add(new VocabularyKey("ScheduledDurationMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Scheduled duration of the email activity, specified in minutes.")
                    .WithDisplayName("Scheduled Duration")
                    .ModelProperty("scheduleddurationminutes", typeof(long)));

                this.Category = group.Add(new VocabularyKey("Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type a category to identify the email type, such as lead outreach, customer follow-up, or service alert, to tie the email to a business group or function.")
                    .WithDisplayName("Category")
                    .ModelProperty("category", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the email activity.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.bcc = group.Add(new VocabularyKey("bcc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the recipients that are included on the email distribution, but are not displayed to other recipients.")
                    .WithDisplayName("Bcc")
                    .ModelProperty("bcc", typeof(string)));

                this.cc = group.Add(new VocabularyKey("cc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the recipients that should be copied on the email.")
                    .WithDisplayName("Cc")
                    .ModelProperty("cc", typeof(string)));

                this.Sender = group.Add(new VocabularyKey("Sender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Sender of the email.")
                    .WithDisplayName("From")
                    .ModelProperty("sender", typeof(string)));

                this.Subject = group.Add(new VocabularyKey("Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(400))
                    .WithDescription(@"Type a short description about the objective or primary topic of the email.")
                    .WithDisplayName("Subject")
                    .ModelProperty("subject", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ToRecipients = group.Add(new VocabularyKey("ToRecipients", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Shows the email addresses corresponding to the recipients.")
                    .WithDisplayName("To Recipients")
                    .ModelProperty("torecipients", typeof(string)));

                this.DeliveryReceiptRequested = group.Add(new VocabularyKey("DeliveryReceiptRequested", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the sender should receive confirmation that the email was delivered.")
                    .WithDisplayName("Delivery Receipt Requested")
                    .ModelProperty("deliveryreceiptrequested", typeof(bool)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the object with which the e-mail is associated.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the email is open, completed, or canceled. Completed and canceled email is read-only and can't be edited.")
                    .WithDisplayName("Activity Status")
                    .ModelProperty("statecode", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.MessageId = group.Add(new VocabularyKey("MessageId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(320))
                    .WithDescription(@"Unique identifier of the email message. Used only for email that is received.")
                    .WithDisplayName("Message ID")
                    .ModelProperty("messageid", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the email activity.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.DeliveryReceiptRequestedName = group.Add(new VocabularyKey("DeliveryReceiptRequestedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DeliveryReceiptRequestedName")
                    .ModelProperty("deliveryreceiptrequestedname", typeof(string)));

                this.PriorityCodeName = group.Add(new VocabularyKey("PriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PriorityCodeName")
                    .ModelProperty("prioritycodename", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.IsWorkflowCreatedName = group.Add(new VocabularyKey("IsWorkflowCreatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsWorkflowCreatedName")
                    .ModelProperty("isworkflowcreatedname", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ReadReceiptRequestedName = group.Add(new VocabularyKey("ReadReceiptRequestedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ReadReceiptRequestedName")
                    .ModelProperty("readreceiptrequestedname", typeof(string)));

                this.IsBilledName = group.Add(new VocabularyKey("IsBilledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsBilledName")
                    .ModelProperty("isbilledname", typeof(string)));

                this.DirectionCodeName = group.Add(new VocabularyKey("DirectionCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DirectionCodeName")
                    .ModelProperty("directioncodename", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.DeliveryAttempts = group.Add(new VocabularyKey("DeliveryAttempts", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the count of the number of attempts made to send the email. The count is used as an indicator of email routing issues.")
                    .WithDisplayName("No. of Delivery Attempts")
                    .ModelProperty("deliveryattempts", typeof(long)));

                this.MessageIdDupCheck = group.Add(new VocabularyKey("MessageIdDupCheck", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Message ID Dup Check")
                    .ModelProperty("messageiddupcheck", typeof(Guid)));

                this.Compressed = group.Add(new VocabularyKey("Compressed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates if the body is compressed.")
                    .WithDisplayName("Compression")
                    .ModelProperty("compressed", typeof(bool)));

                this.Notifications = group.Add(new VocabularyKey("Notifications", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the notification code to identify issues with the email recipients or attachments, such as blocked attachments.")
                    .WithDisplayName("Notifications")
                    .ModelProperty("notifications", typeof(string)));

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

                this.CompressedName = group.Add(new VocabularyKey("CompressedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CompressedName")
                    .ModelProperty("compressedname", typeof(string)));

                this.NotificationsName = group.Add(new VocabularyKey("NotificationsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("NotificationsName")
                    .ModelProperty("notificationsname", typeof(string)));

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

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

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record on behalf of another user.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

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

                this.ActivityTypeCode = group.Add(new VocabularyKey("ActivityTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the type of activity.")
                    .WithDisplayName("Activity Type")
                    .ModelProperty("activitytypecode", typeof(string)));

                this.ActivityTypeCodeName = group.Add(new VocabularyKey("ActivityTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ActivityTypeCodeName")
                    .ModelProperty("activitytypecodename", typeof(string)));

                this.IsRegularActivity = group.Add(new VocabularyKey("IsRegularActivity", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information regarding whether the activity is a regular activity type or event type.")
                    .WithDisplayName("Is Regular Activity")
                    .ModelProperty("isregularactivity", typeof(bool)));

                this.IsRegularActivityName = group.Add(new VocabularyKey("IsRegularActivityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsRegularActivityName")
                    .ModelProperty("isregularactivityname", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the team who owns the email activity.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the local currency for the record to make sure budgets are reported in the correct currency.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.EmailSender = group.Add(new VocabularyKey("EmailSender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Equipment_Email_EmailSender")
                    .WithDisplayName("Sender")
                    .ModelProperty("emailsender", typeof(string)));

                this.EmailSenderName = group.Add(new VocabularyKey("EmailSenderName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"Shows the name of the sender of the email.")
                    .WithDisplayName("Email Sender Name")
                    .ModelProperty("emailsendername", typeof(string)));

                this.EmailSenderObjectTypeCode = group.Add(new VocabularyKey("EmailSenderObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the object type of sender of the email.")
                    .WithDisplayName("Email Sender Type")
                    .ModelProperty("emailsenderobjecttypecode", typeof(string)));

                this.SendersAccount = group.Add(new VocabularyKey("SendersAccount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the parent account of the sender of the email.")
                    .WithDisplayName("Senders Account")
                    .ModelProperty("sendersaccount", typeof(string)));

                this.SendersAccountObjectTypeCode = group.Add(new VocabularyKey("SendersAccountObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the parent account type code of the sender of the email.")
                    .WithDisplayName(" SendersAccount Type")
                    .ModelProperty("sendersaccountobjecttypecode", typeof(string)));

                this.AttachmentCount = group.Add(new VocabularyKey("AttachmentCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the umber of attachments of the email message.")
                    .WithDisplayName("Attachment Count")
                    .ModelProperty("attachmentcount", typeof(long)));

                this.SenderMailboxId = group.Add(new VocabularyKey("SenderMailboxId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the mailbox associated with the sender of the email message.")
                    .WithDisplayName("Sender's Mailbox")
                    .ModelProperty("sendermailboxid", typeof(string)));

                this.SenderMailboxIdName = group.Add(new VocabularyKey("SenderMailboxIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SenderMailboxIdName")
                    .ModelProperty("sendermailboxidname", typeof(string)));

                this.DeliveryPriorityCode = group.Add(new VocabularyKey("DeliveryPriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the priority of delivery of the email to the email server.")
                    .WithDisplayName("Delivery Priority")
                    .ModelProperty("deliveryprioritycode", typeof(string)));

                this.DeliveryPriorityCodeName = group.Add(new VocabularyKey("DeliveryPriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DeliveryPriorityCodeName")
                    .ModelProperty("deliveryprioritycodename", typeof(string)));

                this.ParentActivityId = group.Add(new VocabularyKey("ParentActivityId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the activity that the email is associated with.")
                    .WithDisplayName("Parent Activity Id")
                    .ModelProperty("parentactivityid", typeof(string)));

                this.ParentActivityIdName = group.Add(new VocabularyKey("ParentActivityIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"Parent Activity Name")
                    .WithDisplayName("Parent Activity Name")
                    .ModelProperty("parentactivityidname", typeof(string)));

                this.InReplyTo = group.Add(new VocabularyKey("InReplyTo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(320))
                    .WithDescription(@"Type the ID of the email message that this email activity is a response to.")
                    .WithDisplayName("In Reply To Message")
                    .ModelProperty("inreplyto", typeof(string)));

                this.BaseConversationIndexHash = group.Add(new VocabularyKey("BaseConversationIndexHash", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Hash of base of conversation index.")
                    .WithDisplayName("Conversation Index (Hash)")
                    .ModelProperty("baseconversationindexhash", typeof(long)));

                this.ConversationIndex = group.Add(new VocabularyKey("ConversationIndex", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2048))
                    .WithDescription(@"Identifier for all the email responses for this conversation.")
                    .WithDisplayName("Conversation Index")
                    .ModelProperty("conversationindex", typeof(string)));

                this.CorrelationMethod = group.Add(new VocabularyKey("CorrelationMethod", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows how an email is matched to an existing email in Microsoft Dynamics 365. For system use only.")
                    .WithDisplayName("Correlation Method")
                    .ModelProperty("correlationmethod", typeof(string)));

                this.SentOn = group.Add(new VocabularyKey("SentOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time that the email was sent.")
                    .WithDisplayName("Date Sent")
                    .ModelProperty("senton", typeof(DateTime)));

                this.PostponeEmailProcessingUntil = group.Add(new VocabularyKey("PostponeEmailProcessingUntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Delay email processing until")
                    .ModelProperty("postponeemailprocessinguntil", typeof(DateTime)));

                this.SafeDescription = group.Add(new VocabularyKey("SafeDescription", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Safe body text of the e-mail.")
                    .WithDisplayName("Safe Description")
                    .ModelProperty("safedescription", typeof(string)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the stage.")
                    .WithDisplayName("(Deprecated) Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.ActivityAdditionalParams = group.Add(new VocabularyKey("ActivityAdditionalParams", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8192))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Additional Parameters")
                    .ModelProperty("activityadditionalparams", typeof(string)));

                this.IsUnsafe = group.Add(new VocabularyKey("IsUnsafe", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("IsUnsafe")
                    .ModelProperty("isunsafe", typeof(long)));

                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the service level agreement (SLA) that you want to apply to the email record.")
                    .WithDisplayName("SLA")
                    .ModelProperty("slaid", typeof(string)));

                this.SLAInvokedId = group.Add(new VocabularyKey("SLAInvokedId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last SLA that was applied to this email. This field is for internal use only.")
                    .WithDisplayName("Last SLA applied")
                    .ModelProperty("slainvokedid", typeof(string)));

                this.OnHoldTime = group.Add(new VocabularyKey("OnHoldTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows how long, in minutes, that the record was on hold.")
                    .WithDisplayName("On Hold Time (Minutes)")
                    .ModelProperty("onholdtime", typeof(long)));

                this.LastOnHoldTime = group.Add(new VocabularyKey("LastOnHoldTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the date and time stamp of the last on hold time.")
                    .WithDisplayName("Last On Hold Time")
                    .ModelProperty("lastonholdtime", typeof(DateTime)));

                this.SendersAccountName = group.Add(new VocabularyKey("SendersAccountName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"Shows the name of the sender account of the email.")
                    .WithDisplayName("Email Sender Account Name")
                    .ModelProperty("sendersaccountname", typeof(string)));

                this.SendersAccountYomiName = group.Add(new VocabularyKey("SendersAccountYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"Shows the name of the sender account yomi name ")
                    .WithDisplayName("Email Sender Account yomi Name")
                    .ModelProperty("sendersaccountyominame", typeof(string)));

                this.EmailSenderYomiName = group.Add(new VocabularyKey("EmailSenderYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"Shows the yomi name of the email sender")
                    .WithDisplayName("Email Sender yomi Name")
                    .ModelProperty("emailsenderyominame", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("(Deprecated) Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.SLAName = group.Add(new VocabularyKey("SLAName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAName")
                    .ModelProperty("slaname", typeof(string)));

                this.SLAInvokedIdName = group.Add(new VocabularyKey("SLAInvokedIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAInvokedIdName")
                    .ModelProperty("slainvokedidname", typeof(string)));

                this.AttachmentOpenCount = group.Add(new VocabularyKey("AttachmentOpenCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the number of times an email attachment has been viewed.")
                    .WithDisplayName("Attachment Open Count")
                    .ModelProperty("attachmentopencount", typeof(long)));

                this.ConversationTrackingId = group.Add(new VocabularyKey("ConversationTrackingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Conversation Tracking Id.")
                    .WithDisplayName("Conversation Tracking Id")
                    .ModelProperty("conversationtrackingid", typeof(Guid)));

                this.DelayedEmailSendTime = group.Add(new VocabularyKey("DelayedEmailSendTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the expected date and time when email will be sent.")
                    .WithDisplayName("Send Later")
                    .ModelProperty("delayedemailsendtime", typeof(DateTime)));

                this.LastOpenedTime = group.Add(new VocabularyKey("LastOpenedTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the latest date and time when email was opened.")
                    .WithDisplayName("Last Opened Time")
                    .ModelProperty("lastopenedtime", typeof(DateTime)));

                this.LinksClickedCount = group.Add(new VocabularyKey("LinksClickedCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the number of times a link in an email has been clicked.")
                    .WithDisplayName("Links Clicked Count")
                    .ModelProperty("linksclickedcount", typeof(long)));

                this.OpenCount = group.Add(new VocabularyKey("OpenCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the number of times an email has been opened.")
                    .WithDisplayName("Open Count")
                    .ModelProperty("opencount", typeof(long)));

                this.ReplyCount = group.Add(new VocabularyKey("ReplyCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the number of replies received for an email.")
                    .WithDisplayName("Reply Count")
                    .ModelProperty("replycount", typeof(long)));

                this.EmailTrackingId = group.Add(new VocabularyKey("EmailTrackingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Email Tracking Id.")
                    .WithDisplayName("Email Tracking Id")
                    .ModelProperty("emailtrackingid", typeof(Guid)));

                this.FollowEmailUserPreference = group.Add(new VocabularyKey("FollowEmailUserPreference", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the email allows following recipient activities sent from Microsoft Dynamics 365.This is user preference state which can be overridden by system evaluated state.")
                    .WithDisplayName("Following")
                    .ModelProperty("followemailuserpreference", typeof(bool)));

                this.FollowEmailUserPreferenceName = group.Add(new VocabularyKey("FollowEmailUserPreferenceName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FollowEmailUserPreferenceName")
                    .ModelProperty("followemailuserpreferencename", typeof(string)));

                this.IsEmailFollowed = group.Add(new VocabularyKey("IsEmailFollowed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only. Shows whether this email is followed. This is evaluated state which overrides user selection of follow email.")
                    .WithDisplayName("Followed")
                    .ModelProperty("isemailfollowed", typeof(bool)));

                this.IsEmailFollowedName = group.Add(new VocabularyKey("IsEmailFollowedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsEmailFollowedName")
                    .ModelProperty("isemailfollowedname", typeof(string)));

                this.EmailReminderExpiryTime = group.Add(new VocabularyKey("EmailReminderExpiryTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time when an email reminder expires.")
                    .WithDisplayName("Email Reminder Expiry Time")
                    .ModelProperty("emailreminderexpirytime", typeof(DateTime)));

                this.EmailReminderType = group.Add(new VocabularyKey("EmailReminderType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the type of the email reminder.")
                    .WithDisplayName("Email Reminder Type")
                    .ModelProperty("emailremindertype", typeof(string)));

                this.EmailReminderTypeName = group.Add(new VocabularyKey("EmailReminderTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EmailReminderTypeName")
                    .ModelProperty("emailremindertypename", typeof(string)));

                this.EmailReminderStatus = group.Add(new VocabularyKey("EmailReminderStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the status of the email reminder.")
                    .WithDisplayName("Email Reminder Status")
                    .ModelProperty("emailreminderstatus", typeof(string)));

                this.EmailReminderStatusName = group.Add(new VocabularyKey("EmailReminderStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EmailReminderStatusName")
                    .ModelProperty("emailreminderstatusname", typeof(string)));

                this.EmailReminderText = group.Add(new VocabularyKey("EmailReminderText", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Email Reminder Text")
                    .ModelProperty("emailremindertext", typeof(string)));

                this.TemplateId = group.Add(new VocabularyKey("TemplateId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only. ID for template used in email.")
                    .WithDisplayName("ID for template used.")
                    .ModelProperty("templateid", typeof(string)));

                this.ReminderActionCardId = group.Add(new VocabularyKey("ReminderActionCardId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Reminder Action Card Id.")
                    .WithDisplayName("Reminder Action Card Id.")
                    .ModelProperty("reminderactioncardid", typeof(Guid)));

                this.TemplateIdName = group.Add(new VocabularyKey("TemplateIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TemplateIdName")
                    .ModelProperty("templateidname", typeof(string)));

                this.SortDate = group.Add(new VocabularyKey("SortDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time by which the activities are sorted.")
                    .WithDisplayName("Sort Date")
                    .ModelProperty("sortdate", typeof(DateTime)));

                this.IsEmailReminderSet = group.Add(new VocabularyKey("IsEmailReminderSet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only. Shows whether this email Reminder is Set.")
                    .WithDisplayName("Reminder Set")
                    .ModelProperty("isemailreminderset", typeof(bool)));

                this.IsEmailReminderSetName = group.Add(new VocabularyKey("IsEmailReminderSetName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsEmailReminderSetName")
                    .ModelProperty("isemailremindersetname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ScheduledStart { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey SubmittedBy { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey to { get; private set; }

        public VocabularyKey IsWorkflowCreated { get; private set; }

        public VocabularyKey ActivityId { get; private set; }

        public VocabularyKey ScheduledEnd { get; private set; }

        public VocabularyKey MimeType { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ReadReceiptRequested { get; private set; }

        public VocabularyKey Subcategory { get; private set; }

        public VocabularyKey IsBilled { get; private set; }

        public VocabularyKey ActualDurationMinutes { get; private set; }

        public VocabularyKey PriorityCode { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ActualStart { get; private set; }

        public VocabularyKey from { get; private set; }

        public VocabularyKey DirectionCode { get; private set; }

        public VocabularyKey ActualEnd { get; private set; }

        public VocabularyKey TrackingToken { get; private set; }

        public VocabularyKey ServiceId { get; private set; }

        public VocabularyKey ScheduledDurationMinutes { get; private set; }

        public VocabularyKey Category { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey bcc { get; private set; }

        public VocabularyKey cc { get; private set; }

        public VocabularyKey Sender { get; private set; }

        public VocabularyKey Subject { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ToRecipients { get; private set; }

        public VocabularyKey DeliveryReceiptRequested { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey MessageId { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey DeliveryReceiptRequestedName { get; private set; }

        public VocabularyKey PriorityCodeName { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey IsWorkflowCreatedName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ReadReceiptRequestedName { get; private set; }

        public VocabularyKey IsBilledName { get; private set; }

        public VocabularyKey DirectionCodeName { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey DeliveryAttempts { get; private set; }

        public VocabularyKey MessageIdDupCheck { get; private set; }

        public VocabularyKey Compressed { get; private set; }

        public VocabularyKey Notifications { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey CompressedName { get; private set; }

        public VocabularyKey NotificationsName { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ActivityTypeCode { get; private set; }

        public VocabularyKey ActivityTypeCodeName { get; private set; }

        public VocabularyKey IsRegularActivity { get; private set; }

        public VocabularyKey IsRegularActivityName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey EmailSender { get; private set; }

        public VocabularyKey EmailSenderName { get; private set; }

        public VocabularyKey EmailSenderObjectTypeCode { get; private set; }

        public VocabularyKey SendersAccount { get; private set; }

        public VocabularyKey SendersAccountObjectTypeCode { get; private set; }

        public VocabularyKey AttachmentCount { get; private set; }

        public VocabularyKey SenderMailboxId { get; private set; }

        public VocabularyKey SenderMailboxIdName { get; private set; }

        public VocabularyKey DeliveryPriorityCode { get; private set; }

        public VocabularyKey DeliveryPriorityCodeName { get; private set; }

        public VocabularyKey ParentActivityId { get; private set; }

        public VocabularyKey ParentActivityIdName { get; private set; }

        public VocabularyKey InReplyTo { get; private set; }

        public VocabularyKey BaseConversationIndexHash { get; private set; }

        public VocabularyKey ConversationIndex { get; private set; }

        public VocabularyKey CorrelationMethod { get; private set; }

        public VocabularyKey SentOn { get; private set; }

        public VocabularyKey PostponeEmailProcessingUntil { get; private set; }

        public VocabularyKey SafeDescription { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey ActivityAdditionalParams { get; private set; }

        public VocabularyKey IsUnsafe { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey SendersAccountName { get; private set; }

        public VocabularyKey SendersAccountYomiName { get; private set; }

        public VocabularyKey EmailSenderYomiName { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey AttachmentOpenCount { get; private set; }

        public VocabularyKey ConversationTrackingId { get; private set; }

        public VocabularyKey DelayedEmailSendTime { get; private set; }

        public VocabularyKey LastOpenedTime { get; private set; }

        public VocabularyKey LinksClickedCount { get; private set; }

        public VocabularyKey OpenCount { get; private set; }

        public VocabularyKey ReplyCount { get; private set; }

        public VocabularyKey EmailTrackingId { get; private set; }

        public VocabularyKey FollowEmailUserPreference { get; private set; }

        public VocabularyKey FollowEmailUserPreferenceName { get; private set; }

        public VocabularyKey IsEmailFollowed { get; private set; }

        public VocabularyKey IsEmailFollowedName { get; private set; }

        public VocabularyKey EmailReminderExpiryTime { get; private set; }

        public VocabularyKey EmailReminderType { get; private set; }

        public VocabularyKey EmailReminderTypeName { get; private set; }

        public VocabularyKey EmailReminderStatus { get; private set; }

        public VocabularyKey EmailReminderStatusName { get; private set; }

        public VocabularyKey EmailReminderText { get; private set; }

        public VocabularyKey TemplateId { get; private set; }

        public VocabularyKey ReminderActionCardId { get; private set; }

        public VocabularyKey TemplateIdName { get; private set; }

        public VocabularyKey SortDate { get; private set; }

        public VocabularyKey IsEmailReminderSet { get; private set; }

        public VocabularyKey IsEmailReminderSetName { get; private set; }


    }
}

