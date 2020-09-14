using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class BulkOperationVocabulary : SimpleVocabulary
    {
        public BulkOperationVocabulary()
        {
            VocabularyName = "Dynamics365 BulkOperation";
            KeyPrefix = "dynamics365.bulkoperation";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("BulkOperation", group =>
            {
                this.ScheduledDurationMinutes = group.Add(new VocabularyKey("ScheduledDurationMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Scheduled duration of the bulk operation, specified in minutes.")
                    .WithDisplayName("Scheduled Duration")
                    .ModelProperty("scheduleddurationminutes", typeof(long)));

                this.ServiceId = group.Add(new VocabularyKey("ServiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for an associated service.")
                    .WithDisplayName("Service")
                    .ModelProperty("serviceid", typeof(string)));

                this.TargetedRecordTypeCode = group.Add(new VocabularyKey("TargetedRecordTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the type of records targeted in the quick campaign to identify the target audience.")
                    .WithDisplayName("Members Type")
                    .ModelProperty("targetedrecordtypecode", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"business_unit_BulkOperation_activities")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.CreatedRecordTypeCode = group.Add(new VocabularyKey("CreatedRecordTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Choose the activity to create that determines how target prospects or customers in this quick campaign are contacted.")
                    .WithDisplayName("Activity Type")
                    .ModelProperty("createdrecordtypecode", typeof(string)));

                this.ScheduledEnd = group.Add(new VocabularyKey("ScheduledEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Scheduled end date and time of the bulk operation.")
                    .WithDisplayName("Due Date")
                    .ModelProperty("scheduledend", typeof(DateTime)));

                this.ActualDurationMinutes = group.Add(new VocabularyKey("ActualDurationMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Actual duration of the bulk operation in minutes.")
                    .WithDisplayName("Actual Duration")
                    .ModelProperty("actualdurationminutes", typeof(long)));

                this.IsWorkflowCreated = group.Add(new VocabularyKey("IsWorkflowCreated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Specifies if the bulk operation was created from a workflow rule.")
                    .WithDisplayName("Is Workflow Created")
                    .ModelProperty("isworkflowcreated", typeof(bool)));

                this.Parameters = group.Add(new VocabularyKey("Parameters", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100000))
                    .WithDescription(@"XML string that contains the parameters to the bulk operation.")
                    .WithDisplayName("Parameters")
                    .ModelProperty("parameters", typeof(string)));

                this.ErrorNumber = group.Add(new VocabularyKey("ErrorNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the error code that is used to troubleshoot issues in the quick campaign.")
                    .WithDisplayName("Error Number")
                    .ModelProperty("errornumber", typeof(long)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the quick campaign's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.Subject = group.Add(new VocabularyKey("Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"Type a short description about the objective or primary topic of the quick campaign.")
                    .WithDisplayName("Subject")
                    .ModelProperty("subject", typeof(string)));

                this.BulkOperationNumber = group.Add(new VocabularyKey("BulkOperationNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(32))
                    .WithDescription(@"Shows the number for the quick campaign record, used to identify the quick campaign.")
                    .WithDisplayName("Bulk Operation Number")
                    .ModelProperty("bulkoperationnumber", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the bulk operation.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information to describe the quick campaign, such as the products or services offered.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.OperationTypeCode = group.Add(new VocabularyKey("OperationTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the type of bulk operation process, such as quick campaign or campaign activity distribution.")
                    .WithDisplayName("Operation")
                    .ModelProperty("operationtypecode", typeof(string)));

                this.ScheduledStart = group.Add(new VocabularyKey("ScheduledStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Scheduled start date and time of the bulk operation.")
                    .WithDisplayName("Start Date")
                    .ModelProperty("scheduledstart", typeof(DateTime)));

                this.TargetMembersCount = group.Add(new VocabularyKey("TargetMembersCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of members to target.")
                    .WithDisplayName("Total Members")
                    .ModelProperty("targetmemberscount", typeof(long)));

                this.ActivityId = group.Add(new VocabularyKey("ActivityId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"activity_pointer_BulkOperation")
                    .WithDisplayName("Activity")
                    .ModelProperty("activityid", typeof(Guid)));

                this.SuccessCount = group.Add(new VocabularyKey("SuccessCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of records which succeeded in the bulk operation.")
                    .WithDisplayName("No. of Successes")
                    .ModelProperty("successcount", typeof(long)));

                this.FailureCount = group.Add(new VocabularyKey("FailureCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of records which failed in the bulk operation.")
                    .WithDisplayName("No. of Failures")
                    .ModelProperty("failurecount", typeof(long)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_BulkOperation_createdby")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ActualStart = group.Add(new VocabularyKey("ActualStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the activity was started or created.")
                    .WithDisplayName("Actual Start")
                    .ModelProperty("actualstart", typeof(DateTime)));

                this.IsBilled = group.Add(new VocabularyKey("IsBilled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Is Billed")
                    .ModelProperty("isbilled", typeof(bool)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.ActualEnd = group.Add(new VocabularyKey("ActualEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time when the quick campaign was completed or canceled.")
                    .WithDisplayName("Actual End")
                    .ModelProperty("actualend", typeof(DateTime)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"List_BulkOperations")
                    .WithDisplayName("Import File Name")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows whether the quick campaign is open, closed, or canceled.  Closed or canceled quick campaigns are read-only and can't be edited.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_BulkOperation_modifiedby")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the bulk operation was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"user_BulkOperation")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.IsWorkflowCreatedName = group.Add(new VocabularyKey("IsWorkflowCreatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsWorkflowCreatedName")
                    .ModelProperty("isworkflowcreatedname", typeof(string)));

                this.IsBilledName = group.Add(new VocabularyKey("IsBilledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsBilledName")
                    .ModelProperty("isbilledname", typeof(string)));

                this.OperationTypeCodeName = group.Add(new VocabularyKey("OperationTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Name of the operation to be performed.")
                    .WithDisplayName("OperationTypeCodeName")
                    .ModelProperty("operationtypecodename", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the user who created the bulk operation.")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the user who modified the bulk operation.")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.CreatedRecordTypeCodeName = group.Add(new VocabularyKey("CreatedRecordTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type name of the objects created in the bulk operation.")
                    .WithDisplayName("CreatedRecordTypeCodeName")
                    .ModelProperty("createdrecordtypecodename", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.TargetedRecordTypeCodeName = group.Add(new VocabularyKey("TargetedRecordTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type name of the objects targeted in the bulk operation.")
                    .WithDisplayName("TargetedRecordTypeCodeName")
                    .ModelProperty("targetedrecordtypecodename", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of user who owns the bulk operation.")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Name for the status reason of the bulk operation.")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status name of the bulk operation.")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_BulkOperation_createdonbehalfby")
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
                    .WithDescription(@"lk_BulkOperation_modifiedonbehalfby")
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
                    .WithDescription(@"Type of activity.")
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
                    .WithDescription(@"team_BulkOperation")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.LeftVoiceMail = group.Add(new VocabularyKey("LeftVoiceMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Left the voice mail")
                    .WithDisplayName("Left Voice Mail")
                    .ModelProperty("leftvoicemail", typeof(bool)));

                this.IsMapiPrivate = group.Add(new VocabularyKey("IsMapiPrivate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Is Private")
                    .ModelProperty("ismapiprivate", typeof(bool)));

                this.DeliveryLastAttemptedOn = group.Add(new VocabularyKey("DeliveryLastAttemptedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the delivery of the activity was last attempted.")
                    .WithDisplayName("Date Delivery Last Attempted")
                    .ModelProperty("deliverylastattemptedon", typeof(DateTime)));

                this.LastOnHoldTime = group.Add(new VocabularyKey("LastOnHoldTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Contains the date and time stamp of the last on hold time.")
                    .WithDisplayName("Last On Hold Time")
                    .ModelProperty("lastonholdtime", typeof(DateTime)));

                this.PostponeActivityProcessingUntil = group.Add(new VocabularyKey("PostponeActivityProcessingUntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Delay activity processing until")
                    .ModelProperty("postponeactivityprocessinguntil", typeof(DateTime)));

                this.SentOn = group.Add(new VocabularyKey("SentOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the activity was sent.")
                    .WithDisplayName("Date Sent")
                    .ModelProperty("senton", typeof(DateTime)));

                this.SortDate = group.Add(new VocabularyKey("SortDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time by which the activities are sorted.")
                    .WithDisplayName("Sort Date")
                    .ModelProperty("sortdate", typeof(DateTime)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the activitypointer with respect to the base currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.OnHoldTime = group.Add(new VocabularyKey("OnHoldTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows how long, in minutes, that the record was on hold.")
                    .WithDisplayName("On Hold Time (Minutes)")
                    .ModelProperty("onholdtime", typeof(long)));

                this.ActivityAdditionalParams = group.Add(new VocabularyKey("ActivityAdditionalParams", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8192))
                    .WithDescription(@"Additional information provided by the external application as JSON. For internal use only.")
                    .WithDisplayName("Activity Additional Parameters")
                    .ModelProperty("activityadditionalparams", typeof(string)));

                this.ExchangeWebLink = group.Add(new VocabularyKey("ExchangeWebLink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"Shows the web link of Activity of type email.")
                    .WithDisplayName("Exchange WebLink")
                    .ModelProperty("exchangeweblink", typeof(string)));

                this.ExchangeItemId = group.Add(new VocabularyKey("ExchangeItemId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"The message id of activity which is returned from Exchange Server.")
                    .WithDisplayName("Exchange Item ID")
                    .ModelProperty("exchangeitemid", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("(Deprecated) Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the Stage.")
                    .WithDisplayName("(Deprecated) Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the Process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.SeriesId = group.Add(new VocabularyKey("SeriesId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Uniqueidentifier specifying the id of recurring series of an instance.")
                    .WithDisplayName("Series Id")
                    .ModelProperty("seriesid", typeof(Guid)));

                this.DeliveryPriorityCode = group.Add(new VocabularyKey("DeliveryPriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Priority of delivery of the activity to the email server.")
                    .WithDisplayName("Delivery Priority")
                    .ModelProperty("deliveryprioritycode", typeof(string)));

                this.PriorityCode = group.Add(new VocabularyKey("PriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Priority of the activity.")
                    .WithDisplayName("Priority")
                    .ModelProperty("prioritycode", typeof(string)));

                this.InstanceTypeCode = group.Add(new VocabularyKey("InstanceTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of instance of a recurring series.")
                    .WithDisplayName("Recurring Instance Type")
                    .ModelProperty("instancetypecode", typeof(string)));

                this.Community = group.Add(new VocabularyKey("Community", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.")
                    .WithDisplayName("Social Channel")
                    .ModelProperty("community", typeof(string)));

                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the service level agreement (SLA) that you want to apply to the case record.")
                    .WithDisplayName("SLA")
                    .ModelProperty("slaid", typeof(string)));

                this.SLAInvokedId = group.Add(new VocabularyKey("SLAInvokedId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last SLA that was applied to this case. This field is for internal use only.")
                    .WithDisplayName("Last SLA applied")
                    .ModelProperty("slainvokedid", typeof(string)));

                this.SenderMailboxId = group.Add(new VocabularyKey("SenderMailboxId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the mailbox associated with the sender of the email message.")
                    .WithDisplayName("Sender's Mailbox")
                    .ModelProperty("sendermailboxid", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the currency associated with the activitypointer.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.SLAName = group.Add(new VocabularyKey("SLAName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAName")
                    .ModelProperty("slaname", typeof(string)));

                this.SenderMailboxIdName = group.Add(new VocabularyKey("SenderMailboxIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SenderMailboxIdName")
                    .ModelProperty("sendermailboxidname", typeof(string)));

                this.SLAInvokedIdName = group.Add(new VocabularyKey("SLAInvokedIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAInvokedIdName")
                    .ModelProperty("slainvokedidname", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.LeftVoiceMailName = group.Add(new VocabularyKey("LeftVoiceMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LeftVoiceMailName")
                    .ModelProperty("leftvoicemailname", typeof(string)));

                this.IsMapiPrivateName = group.Add(new VocabularyKey("IsMapiPrivateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsMapiPrivateName")
                    .ModelProperty("ismapiprivatename", typeof(string)));

                this.DeliveryPriorityCodeName = group.Add(new VocabularyKey("DeliveryPriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DeliveryPriorityCodeName")
                    .ModelProperty("deliveryprioritycodename", typeof(string)));

                this.CommunityName = group.Add(new VocabularyKey("CommunityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CommunityName")
                    .ModelProperty("communityname", typeof(string)));

                this.InstanceTypeCodeName = group.Add(new VocabularyKey("InstanceTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InstanceTypeCodeName")
                    .ModelProperty("instancetypecodename", typeof(string)));

                this.PriorityCodeName = group.Add(new VocabularyKey("PriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PriorityCodeName")
                    .ModelProperty("prioritycodename", typeof(string)));

                this.from = group.Add(new VocabularyKey("from", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Person who the activity is from.")
                    .WithDisplayName("From")
                    .ModelProperty("from", typeof(string)));

                this.To = group.Add(new VocabularyKey("To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Person who is the receiver of the activity.")
                    .WithDisplayName("To")
                    .ModelProperty("to", typeof(string)));

                this.CC = group.Add(new VocabularyKey("CC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Carbon-copy (cc) recipients of the activity.")
                    .WithDisplayName("CC")
                    .ModelProperty("cc", typeof(string)));

                this.BCC = group.Add(new VocabularyKey("BCC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Blind Carbon-copy (bcc) recipients of the activity.")
                    .WithDisplayName("BCC")
                    .ModelProperty("bcc", typeof(string)));

                this.RequiredAttendees = group.Add(new VocabularyKey("RequiredAttendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"List of required attendees for the activity.")
                    .WithDisplayName("Required Attendees")
                    .ModelProperty("requiredattendees", typeof(string)));

                this.OptionalAttendees = group.Add(new VocabularyKey("OptionalAttendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"List of optional attendees for the activity.")
                    .WithDisplayName("Optional Attendees")
                    .ModelProperty("optionalattendees", typeof(string)));

                this.Organizer = group.Add(new VocabularyKey("Organizer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Person who organized the activity.")
                    .WithDisplayName("Organizer")
                    .ModelProperty("organizer", typeof(string)));

                this.Resources = group.Add(new VocabularyKey("Resources", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Users or facility/equipment that are required for the activity.")
                    .WithDisplayName("Resources")
                    .ModelProperty("resources", typeof(string)));

                this.Customers = group.Add(new VocabularyKey("Customers", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Customer with which the activity is associated.")
                    .WithDisplayName("Customers")
                    .ModelProperty("customers", typeof(string)));

                this.Partners = group.Add(new VocabularyKey("Partners", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Outsource vendor with which activity is associated.")
                    .WithDisplayName("Outsource Vendors")
                    .ModelProperty("partners", typeof(string)));

                this.WorkflowInfo = group.Add(new VocabularyKey("WorkflowInfo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100000))
                    .WithDescription(@"Information for bulk operation workflow.")
                    .WithDisplayName("Workflow information")
                    .ModelProperty("workflowinfo", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ScheduledDurationMinutes { get; private set; }

        public VocabularyKey ServiceId { get; private set; }

        public VocabularyKey TargetedRecordTypeCode { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey CreatedRecordTypeCode { get; private set; }

        public VocabularyKey ScheduledEnd { get; private set; }

        public VocabularyKey ActualDurationMinutes { get; private set; }

        public VocabularyKey IsWorkflowCreated { get; private set; }

        public VocabularyKey Parameters { get; private set; }

        public VocabularyKey ErrorNumber { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey Subject { get; private set; }

        public VocabularyKey BulkOperationNumber { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey OperationTypeCode { get; private set; }

        public VocabularyKey ScheduledStart { get; private set; }

        public VocabularyKey TargetMembersCount { get; private set; }

        public VocabularyKey ActivityId { get; private set; }

        public VocabularyKey SuccessCount { get; private set; }

        public VocabularyKey FailureCount { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ActualStart { get; private set; }

        public VocabularyKey IsBilled { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey ActualEnd { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey IsWorkflowCreatedName { get; private set; }

        public VocabularyKey IsBilledName { get; private set; }

        public VocabularyKey OperationTypeCodeName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey CreatedRecordTypeCodeName { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey TargetedRecordTypeCodeName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

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

        public VocabularyKey LeftVoiceMail { get; private set; }

        public VocabularyKey IsMapiPrivate { get; private set; }

        public VocabularyKey DeliveryLastAttemptedOn { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey PostponeActivityProcessingUntil { get; private set; }

        public VocabularyKey SentOn { get; private set; }

        public VocabularyKey SortDate { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey ActivityAdditionalParams { get; private set; }

        public VocabularyKey ExchangeWebLink { get; private set; }

        public VocabularyKey ExchangeItemId { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey SeriesId { get; private set; }

        public VocabularyKey DeliveryPriorityCode { get; private set; }

        public VocabularyKey PriorityCode { get; private set; }

        public VocabularyKey InstanceTypeCode { get; private set; }

        public VocabularyKey Community { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey SenderMailboxId { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey SenderMailboxIdName { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey LeftVoiceMailName { get; private set; }

        public VocabularyKey IsMapiPrivateName { get; private set; }

        public VocabularyKey DeliveryPriorityCodeName { get; private set; }

        public VocabularyKey CommunityName { get; private set; }

        public VocabularyKey InstanceTypeCodeName { get; private set; }

        public VocabularyKey PriorityCodeName { get; private set; }

        public VocabularyKey from { get; private set; }

        public VocabularyKey To { get; private set; }

        public VocabularyKey CC { get; private set; }

        public VocabularyKey BCC { get; private set; }

        public VocabularyKey RequiredAttendees { get; private set; }

        public VocabularyKey OptionalAttendees { get; private set; }

        public VocabularyKey Organizer { get; private set; }

        public VocabularyKey Resources { get; private set; }

        public VocabularyKey Customers { get; private set; }

        public VocabularyKey Partners { get; private set; }

        public VocabularyKey WorkflowInfo { get; private set; }


    }
}

