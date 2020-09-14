using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ServiceAppointmentVocabulary : SimpleVocabulary
    {
        public ServiceAppointmentVocabulary()
        {
            VocabularyName = "Dynamics365 ServiceAppointment";
            KeyPrefix = "dynamics365.serviceappointment";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ServiceAppointment", group =>
            {
                this.IsWorkflowCreated = group.Add(new VocabularyKey("IsWorkflowCreated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information which specifies if the service activity was created from a workflow rule.")
                    .WithDisplayName("Is Workflow Created")
                    .ModelProperty("isworkflowcreated", typeof(bool)));

                this.PriorityCode = group.Add(new VocabularyKey("PriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the priority so that preferred customers or critical issues are handled quickly.")
                    .WithDisplayName("Priority")
                    .ModelProperty("prioritycode", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.ScheduledEnd = group.Add(new VocabularyKey("ScheduledEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the expected due date and time.")
                    .WithDisplayName("Scheduled End")
                    .ModelProperty("scheduledend", typeof(DateTime)));

                this.Category = group.Add(new VocabularyKey("Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type a category to identify the service activity type, such as routine maintenance or service call, to tie the service activity to a business group or function.")
                    .WithDisplayName("Category")
                    .ModelProperty("category", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.SubscriptionId = group.Add(new VocabularyKey("SubscriptionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Subscription")
                    .ModelProperty("subscriptionid", typeof(Guid)));

                this.Customers = group.Add(new VocabularyKey("Customers", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the accounts and contacts for whom the service activity is being performed.")
                    .WithDisplayName("Customers")
                    .ModelProperty("customers", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ServiceId = group.Add(new VocabularyKey("ServiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"service_service_appointments")
                    .WithDisplayName("Service")
                    .ModelProperty("serviceid", typeof(string)));

                this.Location = group.Add(new VocabularyKey("Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Type the location where the service activity will take place, such as a conference room, customer office, or other venue.")
                    .WithDisplayName("Delivery Location")
                    .ModelProperty("location", typeof(string)));

                this.Subcategory = group.Add(new VocabularyKey("Subcategory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type a subcategory to identify the service activity type and relate the activity to a specific product, service region, business group, or other function.")
                    .WithDisplayName("Sub-Category")
                    .ModelProperty("subcategory", typeof(string)));

                this.ActualDurationMinutes = group.Add(new VocabularyKey("ActualDurationMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the value selected in the Duration field on the service activity at the time the service activity is closed as completed. The duration is used to report the time spent on the activity.")
                    .WithDisplayName("Actual Duration")
                    .ModelProperty("actualdurationminutes", typeof(long)));

                this.ScheduledStart = group.Add(new VocabularyKey("ScheduledStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the expected due date and time.")
                    .WithDisplayName("Scheduled Start")
                    .ModelProperty("scheduledstart", typeof(DateTime)));

                this.ActivityId = group.Add(new VocabularyKey("ActivityId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"activity_pointer_service_appointment")
                    .WithDisplayName("Service Activity")
                    .ModelProperty("activityid", typeof(Guid)));

                this.ActualStart = group.Add(new VocabularyKey("ActualStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the actual start date and time for the service activity. By default, it displays when the activity was created.")
                    .WithDisplayName("Actual Start")
                    .ModelProperty("actualstart", typeof(DateTime)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the service activity.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.IsAllDayEvent = group.Add(new VocabularyKey("IsAllDayEvent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the service activity is an all-day event to make sure the required resources are scheduled for the full day.")
                    .WithDisplayName("All Day Event")
                    .ModelProperty("isalldayevent", typeof(bool)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the service activity's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.SiteId = group.Add(new VocabularyKey("SiteId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"site_service_appointments")
                    .WithDisplayName("Site")
                    .ModelProperty("siteid", typeof(string)));

                this.Resources = group.Add(new VocabularyKey("Resources", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user, facility, or equipment required to complete the service activity.")
                    .WithDisplayName("Resources")
                    .ModelProperty("resources", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"business_unit_service_appointments")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the service activity is open, completed, or canceled. Completed and canceled service activities are read-only and can't be edited.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Type additional information to describe the service activity, such as key talking points or objectives.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.ScheduledDurationMinutes = group.Add(new VocabularyKey("ScheduledDurationMinutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the expected duration of the service activity, in minutes.")
                    .WithDisplayName("Scheduled Duration")
                    .ModelProperty("scheduleddurationminutes", typeof(long)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.IsBilled = group.Add(new VocabularyKey("IsBilled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information which specifies whether the service activity was billed as part of resolving a case.")
                    .WithDisplayName("Is Billed")
                    .ModelProperty("isbilled", typeof(bool)));

                this.ActualEnd = group.Add(new VocabularyKey("ActualEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the actual end date and time of the service activity. By default, it displays when the activity was closed or canceled.")
                    .WithDisplayName("Actual End")
                    .ModelProperty("actualend", typeof(DateTime)));

                this.Subject = group.Add(new VocabularyKey("Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type a short description about the objective or primary topic of the service activity.")
                    .WithDisplayName("Subject")
                    .ModelProperty("subject", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the object with which the service activity is associated.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user that owns the service activity.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.PriorityCodeName = group.Add(new VocabularyKey("PriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PriorityCodeName")
                    .ModelProperty("prioritycodename", typeof(string)));

                this.IsWorkflowCreatedName = group.Add(new VocabularyKey("IsWorkflowCreatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsWorkflowCreatedName")
                    .ModelProperty("isworkflowcreatedname", typeof(string)));

                this.IsAllDayEventName = group.Add(new VocabularyKey("IsAllDayEventName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsAllDayEventName")
                    .ModelProperty("isalldayeventname", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.SiteIdName = group.Add(new VocabularyKey("SiteIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SiteIdName")
                    .ModelProperty("siteidname", typeof(string)));

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

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(300))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.IsBilledName = group.Add(new VocabularyKey("IsBilledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsBilledName")
                    .ModelProperty("isbilledname", typeof(string)));

                this.ServiceIdName = group.Add(new VocabularyKey("ServiceIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ServiceIdName")
                    .ModelProperty("serviceidname", typeof(string)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OverriddenCreatedOn")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

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

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(300))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

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
                    .WithDescription(@"Unique identifier of the team that owns the service activity.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"TransactionCurrency_ServiceAppointment")
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

                this.ActivityAdditionalParams = group.Add(new VocabularyKey("ActivityAdditionalParams", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(8192))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Additional Parameters")
                    .ModelProperty("activityadditionalparams", typeof(string)));

                this.SLAName = group.Add(new VocabularyKey("SLAName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAName")
                    .ModelProperty("slaname", typeof(string)));

                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the service level agreement (SLA) that you want to apply to the service appointment record.")
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

                this.SortDate = group.Add(new VocabularyKey("SortDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time by which the activities are sorted.")
                    .WithDisplayName("Sort Date")
                    .ModelProperty("sortdate", typeof(DateTime)));

                this.SLAInvokedIdName = group.Add(new VocabularyKey("SLAInvokedIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SLAInvokedIdName")
                    .ModelProperty("slainvokedidname", typeof(string)));

                this.LeftVoiceMail = group.Add(new VocabularyKey("LeftVoiceMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Left the voice mail")
                    .WithDisplayName("Left Voice Mail")
                    .ModelProperty("leftvoicemail", typeof(bool)));

                this.DeliveryLastAttemptedOn = group.Add(new VocabularyKey("DeliveryLastAttemptedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the delivery of the activity was last attempted.")
                    .WithDisplayName("Date Delivery Last Attempted")
                    .ModelProperty("deliverylastattemptedon", typeof(DateTime)));

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

                this.LeftVoiceMailName = group.Add(new VocabularyKey("LeftVoiceMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LeftVoiceMailName")
                    .ModelProperty("leftvoicemailname", typeof(string)));

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

                this.From = group.Add(new VocabularyKey("From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
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

                this.Partners = group.Add(new VocabularyKey("Partners", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Outsource vendor with which activity is associated.")
                    .WithDisplayName("Outsource Vendors")
                    .ModelProperty("partners", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey IsWorkflowCreated { get; private set; }

        public VocabularyKey PriorityCode { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey ScheduledEnd { get; private set; }

        public VocabularyKey Category { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey SubscriptionId { get; private set; }

        public VocabularyKey Customers { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ServiceId { get; private set; }

        public VocabularyKey Location { get; private set; }

        public VocabularyKey Subcategory { get; private set; }

        public VocabularyKey ActualDurationMinutes { get; private set; }

        public VocabularyKey ScheduledStart { get; private set; }

        public VocabularyKey ActivityId { get; private set; }

        public VocabularyKey ActualStart { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey IsAllDayEvent { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey SiteId { get; private set; }

        public VocabularyKey Resources { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey ScheduledDurationMinutes { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey IsBilled { get; private set; }

        public VocabularyKey ActualEnd { get; private set; }

        public VocabularyKey Subject { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey PriorityCodeName { get; private set; }

        public VocabularyKey IsWorkflowCreatedName { get; private set; }

        public VocabularyKey IsAllDayEventName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey SiteIdName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey IsBilledName { get; private set; }

        public VocabularyKey ServiceIdName { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

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

        public VocabularyKey IsMapiPrivate { get; private set; }

        public VocabularyKey IsMapiPrivateName { get; private set; }

        public VocabularyKey ActivityAdditionalParams { get; private set; }

        public VocabularyKey SLAName { get; private set; }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey SLAInvokedId { get; private set; }

        public VocabularyKey OnHoldTime { get; private set; }

        public VocabularyKey LastOnHoldTime { get; private set; }

        public VocabularyKey SortDate { get; private set; }

        public VocabularyKey SLAInvokedIdName { get; private set; }

        public VocabularyKey LeftVoiceMail { get; private set; }

        public VocabularyKey DeliveryLastAttemptedOn { get; private set; }

        public VocabularyKey PostponeActivityProcessingUntil { get; private set; }

        public VocabularyKey SentOn { get; private set; }

        public VocabularyKey ExchangeWebLink { get; private set; }

        public VocabularyKey ExchangeItemId { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey SeriesId { get; private set; }

        public VocabularyKey DeliveryPriorityCode { get; private set; }

        public VocabularyKey InstanceTypeCode { get; private set; }

        public VocabularyKey Community { get; private set; }

        public VocabularyKey SenderMailboxId { get; private set; }

        public VocabularyKey SenderMailboxIdName { get; private set; }

        public VocabularyKey LeftVoiceMailName { get; private set; }

        public VocabularyKey DeliveryPriorityCodeName { get; private set; }

        public VocabularyKey CommunityName { get; private set; }

        public VocabularyKey InstanceTypeCodeName { get; private set; }

        public VocabularyKey From { get; private set; }

        public VocabularyKey To { get; private set; }

        public VocabularyKey CC { get; private set; }

        public VocabularyKey BCC { get; private set; }

        public VocabularyKey RequiredAttendees { get; private set; }

        public VocabularyKey OptionalAttendees { get; private set; }

        public VocabularyKey Organizer { get; private set; }

        public VocabularyKey Partners { get; private set; }


    }
}

