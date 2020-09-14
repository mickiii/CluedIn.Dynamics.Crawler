using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ActivityPointerVocabulary : SimpleVocabulary
    {
        public ActivityPointerVocabulary()
        {
            VocabularyName = "Dynamics365 ActivityPointer";
            KeyPrefix = "dynamics365.activitypointer";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ActivityPointer", group =>
            {
                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the activity.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.ActualEnd = group.Add(new VocabularyKey("ActualEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Actual end time of the activity.")
                    .WithDisplayName("Actual End")
                    .ModelProperty("actualend", typeof(DateTime)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the activity.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ActivityId = group.Add(new VocabularyKey("ActivityId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the activity.")
                    .WithDisplayName("Activity")
                    .ModelProperty("activityid", typeof(Guid)));

                this.IsBilled = group.Add(new VocabularyKey("IsBilled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information regarding whether the activity was billed as part of resolving a case.")
                    .WithDisplayName("Is Billed")
                    .ModelProperty("isbilled", typeof(bool)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the activity.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Description of the activity.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when activity was last modified.")
                    .WithDisplayName("Last Updated")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ServiceId = group.Add(new VocabularyKey("ServiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"service_activity_pointers")
                    .WithDisplayName("Service")
                    .ModelProperty("serviceid", typeof(string)));

                this.ActivityTypeCode = group.Add(new VocabularyKey("ActivityTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of activity.")
                    .WithDisplayName("Activity Type")
                    .ModelProperty("activitytypecode", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Status of the activity.")
                    .WithDisplayName("Activity Status")
                    .ModelProperty("statecode", typeof(string)));

                this.ScheduledEnd = group.Add(new VocabularyKey("ScheduledEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Scheduled end time of the activity.")
                    .WithDisplayName("Due Date")
                    .ModelProperty("scheduledend", typeof(DateTime)));

                this.ScheduledDurationMinutes = group.Add(new VocabularyKey("ScheduledDurationMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Scheduled duration of the activity, specified in minutes.")
                    .WithDisplayName("Scheduled Duration")
                    .ModelProperty("scheduleddurationminutes", typeof(long)));

                this.ActualDurationMinutes = group.Add(new VocabularyKey("ActualDurationMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Actual duration of the activity in minutes.")
                    .WithDisplayName("Actual Duration")
                    .ModelProperty("actualdurationminutes", typeof(long)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Reason for the status of the activity.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the activity.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.ActualStart = group.Add(new VocabularyKey("ActualStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Actual start time of the activity.")
                    .WithDisplayName("Actual Start")
                    .ModelProperty("actualstart", typeof(DateTime)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the activity was created.")
                    .WithDisplayName("Date Created")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.PriorityCode = group.Add(new VocabularyKey("PriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Priority of the activity.")
                    .WithDisplayName("Priority")
                    .ModelProperty("prioritycode", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the object with which the activity is associated.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.Subject = group.Add(new VocabularyKey("Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(400))
                    .WithDescription(@"Subject associated with the activity.")
                    .WithDisplayName("Subject")
                    .ModelProperty("subject", typeof(string)));

                this.IsWorkflowCreated = group.Add(new VocabularyKey("IsWorkflowCreated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information regarding whether the activity was created from a workflow rule.")
                    .WithDisplayName("Is Workflow Created")
                    .ModelProperty("isworkflowcreated", typeof(bool)));

                this.ScheduledStart = group.Add(new VocabularyKey("ScheduledStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Scheduled start time of the activity.")
                    .WithDisplayName("Start Date")
                    .ModelProperty("scheduledstart", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of user who last modified the activity.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user that owns the activity.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.IsBilledName = group.Add(new VocabularyKey("IsBilledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsBilledName")
                    .ModelProperty("isbilledname", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

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

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.PriorityCodeName = group.Add(new VocabularyKey("PriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PriorityCodeName")
                    .ModelProperty("prioritycodename", typeof(string)));

                this.ActivityTypeCodeName = group.Add(new VocabularyKey("ActivityTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ActivityTypeCodeName")
                    .ModelProperty("activitytypecodename", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.ServiceIdName = group.Add(new VocabularyKey("ServiceIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ServiceIdName")
                    .ModelProperty("serviceidname", typeof(string)));

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

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.InstanceTypeCode = group.Add(new VocabularyKey("InstanceTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of instance of a recurring series.")
                    .WithDisplayName("Recurring Instance Type")
                    .ModelProperty("instancetypecode", typeof(string)));

                this.SeriesId = group.Add(new VocabularyKey("SeriesId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Uniqueidentifier specifying the id of recurring series of an instance.")
                    .WithDisplayName("Series Id")
                    .ModelProperty("seriesid", typeof(Guid)));

                this.InstanceTypeCodeName = group.Add(new VocabularyKey("InstanceTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InstanceTypeCodeName")
                    .ModelProperty("instancetypecodename", typeof(string)));

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
                    .WithDescription(@"Unique identifier of the delegate user who last modified the activitypointer.")
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

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the activitypointer.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the team that owns the activity.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the currency associated with the activitypointer.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate for the currency associated with the activitypointer with respect to the base currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.allparties = group.Add(new VocabularyKey("allparties", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"All activity parties associated with this activity.")
                    .WithDisplayName("All Activity Parties")
                    .ModelProperty("allparties", typeof(string)));

                this.LeftVoiceMail = group.Add(new VocabularyKey("LeftVoiceMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Left the voice mail")
                    .WithDisplayName("Left Voice Mail")
                    .ModelProperty("leftvoicemail", typeof(bool)));

                this.LeftVoiceMailName = group.Add(new VocabularyKey("LeftVoiceMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LeftVoiceMailName")
                    .ModelProperty("leftvoicemailname", typeof(string)));

                this.Community = group.Add(new VocabularyKey("Community", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.")
                    .WithDisplayName("Social Channel")
                    .ModelProperty("community", typeof(string)));

                this.CommunityName = group.Add(new VocabularyKey("CommunityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CommunityName")
                    .ModelProperty("communityname", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("(Deprecated) Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.IsMapiPrivate = group.Add(new VocabularyKey("IsMapiPrivate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Is Private")
                    .ModelProperty("ismapiprivate", typeof(bool)));

                this.IsMapiPrivateName = group.Add(new VocabularyKey("IsMapiPrivateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsMapiPrivateName")
                    .ModelProperty("ismapiprivatename", typeof(string)));

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

                this.DeliveryPriorityCode = group.Add(new VocabularyKey("DeliveryPriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Priority of delivery of the activity to the email server.")
                    .WithDisplayName("Delivery Priority")
                    .ModelProperty("deliveryprioritycode", typeof(string)));

                this.DeliveryPriorityCodeName = group.Add(new VocabularyKey("DeliveryPriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DeliveryPriorityCodeName")
                    .ModelProperty("deliveryprioritycodename", typeof(string)));

                this.SentOn = group.Add(new VocabularyKey("SentOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the activity was sent.")
                    .WithDisplayName("Date Sent")
                    .ModelProperty("senton", typeof(DateTime)));

                this.DeliveryLastAttemptedOn = group.Add(new VocabularyKey("DeliveryLastAttemptedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the delivery of the activity was last attempted.")
                    .WithDisplayName("Date Delivery Last Attempted")
                    .ModelProperty("deliverylastattemptedon", typeof(DateTime)));

                this.SenderMailboxId = group.Add(new VocabularyKey("SenderMailboxId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the mailbox associated with the sender of the email message.")
                    .WithDisplayName("Sender's Mailbox")
                    .ModelProperty("sendermailboxid", typeof(string)));

                this.SenderMailboxIdName = group.Add(new VocabularyKey("SenderMailboxIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SenderMailboxIdName")
                    .ModelProperty("sendermailboxidname", typeof(string)));

                this.PostponeActivityProcessingUntil = group.Add(new VocabularyKey("PostponeActivityProcessingUntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Delay activity processing until")
                    .ModelProperty("postponeactivityprocessinguntil", typeof(DateTime)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the Process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the Stage.")
                    .WithDisplayName("(Deprecated) Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.ActivityAdditionalParams = group.Add(new VocabularyKey("ActivityAdditionalParams", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8192))
                    .WithDescription(@"Additional information provided by the external application as JSON. For internal use only.")
                    .WithDisplayName("Activity Additional Parameters")
                    .ModelProperty("activityadditionalparams", typeof(string)));

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

                this.SortDate = group.Add(new VocabularyKey("SortDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time by which the activities are sorted.")
                    .WithDisplayName("Sort Date")
                    .ModelProperty("sortdate", typeof(DateTime)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey ActualEnd { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ActivityId { get; private set; }

        public VocabularyKey IsBilled { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ServiceId { get; private set; }

        public VocabularyKey ActivityTypeCode { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey ScheduledEnd { get; private set; }

        public VocabularyKey ScheduledDurationMinutes { get; private set; }

        public VocabularyKey ActualDurationMinutes { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey ActualStart { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey PriorityCode { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey Subject { get; private set; }

        public VocabularyKey IsWorkflowCreated { get; private set; }

        public VocabularyKey ScheduledStart { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey IsBilledName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey IsWorkflowCreatedName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey PriorityCodeName { get; private set; }

        public VocabularyKey ActivityTypeCodeName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey ServiceIdName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey InstanceTypeCode { get; private set; }

        public VocabularyKey SeriesId { get; private set; }

        public VocabularyKey InstanceTypeCodeName { get; private set; }

        public VocabularyKey IsRegularActivity { get; private set; }

        public VocabularyKey IsRegularActivityName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey allparties { get; private set; }

        public VocabularyKey LeftVoiceMail { get; private set; }

        public VocabularyKey LeftVoiceMailName { get; private set; }

        public VocabularyKey Community { get; private set; }

        public VocabularyKey CommunityName { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey IsMapiPrivate { get; private set; }

        public VocabularyKey IsMapiPrivateName { get; private set; }

        public VocabularyKey ExchangeWebLink { get; private set; }

        public VocabularyKey ExchangeItemId { get; private set; }

        public VocabularyKey DeliveryPriorityCode { get; private set; }

        public VocabularyKey DeliveryPriorityCodeName { get; private set; }

        public VocabularyKey SentOn { get; private set; }

        public VocabularyKey DeliveryLastAttemptedOn { get; private set; }

        public VocabularyKey SenderMailboxId { get; private set; }

        public VocabularyKey SenderMailboxIdName { get; private set; }

        public VocabularyKey PostponeActivityProcessingUntil { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey ActivityAdditionalParams { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey SortDate { get; private set; }


    }
}

