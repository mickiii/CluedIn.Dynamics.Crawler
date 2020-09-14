using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class RecurringAppointmentMasterVocabulary : SimpleVocabulary
    {
        public RecurringAppointmentMasterVocabulary()
        {
            VocabularyName = "Dynamics365 RecurringAppointmentMaster";
            KeyPrefix = "dynamics365.recurringappointmentmaster";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("RecurringAppointmentMaster", group =>
            {
                this.IsWeekDayPattern = group.Add(new VocabularyKey("IsWeekDayPattern", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the weekly recurrence pattern is a daily weekday pattern. Valid for weekly recurrence pattern only.")
                    .WithDisplayName("Every Weekday")
                    .ModelProperty("isweekdaypattern", typeof(bool)));

                this.RuleId = group.Add(new VocabularyKey("RuleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the recurrence rule that is associated with the recurring appointment series.")
                    .WithDisplayName("Recurrence Rule")
                    .ModelProperty("ruleid", typeof(string)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.IsNthYearly = group.Add(new VocabularyKey("IsNthYearly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the recurring appointment series should occur after every N years. Valid for yearly recurrence pattern only.")
                    .WithDisplayName("Nth Yearly")
                    .ModelProperty("isnthyearly", typeof(bool)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the recurring appointment is open, scheduled, completed, or canceled. Completed and canceled appointments are read-only and can't be edited.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the recurring appointment series.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.GroupId = group.Add(new VocabularyKey("GroupId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the recurring appointment series for which the recurrence information was updated. ")
                    .WithDisplayName("Group Id")
                    .ModelProperty("groupid", typeof(string)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.OptionalAttendees = group.Add(new VocabularyKey("OptionalAttendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the account, contact, lead, user, or other equipment resources that are not needed at the recurring appointment, but can optionally attend.")
                    .WithDisplayName("Optional Attendees")
                    .ModelProperty("optionalattendees", typeof(string)));

                this.SubscriptionId = group.Add(new VocabularyKey("SubscriptionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("SubscriptionId")
                    .ModelProperty("subscriptionid", typeof(Guid)));

                this.LastExpandedInstanceDate = group.Add(new VocabularyKey("LastExpandedInstanceDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date of last expanded instance of a recurring appointment series.")
                    .WithDisplayName("Last Expanded Instance Date")
                    .ModelProperty("lastexpandedinstancedate", typeof(DateTime)));

                this.EffectiveEndDate = group.Add(new VocabularyKey("EffectiveEndDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Actual end date of the recurring appointment series based on the specified end date and recurrence pattern.")
                    .WithDisplayName("Effective End Date")
                    .ModelProperty("effectiveenddate", typeof(DateTime)));

                this.PatternStartDate = group.Add(new VocabularyKey("PatternStartDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Start date of the recurrence range.")
                    .WithDisplayName("Recurrence Range Start")
                    .ModelProperty("patternstartdate", typeof(DateTime)));

                this.IsWorkflowCreated = group.Add(new VocabularyKey("IsWorkflowCreated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the recurring appointment series was created from a workflow rule.")
                    .WithDisplayName("Is Workflow Created")
                    .ModelProperty("isworkflowcreated", typeof(bool)));

                this.InstanceTypeCode = group.Add(new VocabularyKey("InstanceTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of instance of a recurring appointment series.")
                    .WithDisplayName("Appointment Type")
                    .ModelProperty("instancetypecode", typeof(string)));

                this.IsRegenerate = group.Add(new VocabularyKey("IsRegenerate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Regenerate")
                    .ModelProperty("isregenerate", typeof(bool)));

                this.FirstDayOfWeek = group.Add(new VocabularyKey("FirstDayOfWeek", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"First day of week for the recurrence pattern.")
                    .WithDisplayName("First Day Of Week")
                    .ModelProperty("firstdayofweek", typeof(long)));

                this.Subcategory = group.Add(new VocabularyKey("Subcategory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type a subcategory to identify the recurring appointment type and relate the activity to a specific product, sales region, business group, or other function.")
                    .WithDisplayName("Sub-Category")
                    .ModelProperty("subcategory", typeof(string)));

                this.Category = group.Add(new VocabularyKey("Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"Type a category to identify the recurring appointment type, such as status meeting or service call, to tie the appointment to a business group or function.")
                    .WithDisplayName("Category")
                    .ModelProperty("category", typeof(string)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OutlookOwnerApptId = group.Add(new VocabularyKey("OutlookOwnerApptId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the Microsoft Office Outlook recurring appointment series owner that correlates to the PR_OWNER_APPT_ID MAPI property.")
                    .WithDisplayName("Outlook Recurring Appointment Master Owner")
                    .ModelProperty("outlookownerapptid", typeof(long)));

                this.RecurrencePatternType = group.Add(new VocabularyKey("RecurrencePatternType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the pattern type for the recurring appointment to indicate whether the appointment occurs daily, weekly, monthly, or yearly.")
                    .WithDisplayName("Recurrence Frequency")
                    .ModelProperty("recurrencepatterntype", typeof(string)));

                this.NextExpansionInstanceDate = group.Add(new VocabularyKey("NextExpansionInstanceDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date of the next expanded instance of a recurring appointment series.")
                    .WithDisplayName("Next Expanded Instance Date")
                    .ModelProperty("nextexpansioninstancedate", typeof(DateTime)));

                this.ExpansionStateCode = group.Add(new VocabularyKey("ExpansionStateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"State code to indicate whether the recurring appointment series is expanded fully or partially.")
                    .WithDisplayName("Expansion State Code")
                    .ModelProperty("expansionstatecode", typeof(string)));

                this.PriorityCode = group.Add(new VocabularyKey("PriorityCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the priority so that preferred customers or critical issues are handled quickly.")
                    .WithDisplayName("Priority")
                    .ModelProperty("prioritycode", typeof(string)));

                this.IsBilled = group.Add(new VocabularyKey("IsBilled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the recurring appointment series was billed as part of resolving a case.")
                    .WithDisplayName("Is Billed")
                    .ModelProperty("isbilled", typeof(bool)));

                this.PatternEndDate = group.Add(new VocabularyKey("PatternEndDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"End date of the recurrence range.")
                    .WithDisplayName("Recurrence Range End")
                    .ModelProperty("patternenddate", typeof(DateTime)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("TimeZoneRuleVersionNumber")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.GlobalObjectId = group.Add(new VocabularyKey("GlobalObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(300))
                    .WithDescription(@"Unique Outlook identifier to correlate recurring appointment series across Exchange mailboxes.")
                    .WithDisplayName("Outlook Recurring Appointment Master")
                    .ModelProperty("globalobjectid", typeof(string)));

                this.EffectiveStartDate = group.Add(new VocabularyKey("EffectiveStartDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Actual start date of the recurring appointment series based on the specified start date and recurrence pattern.")
                    .WithDisplayName("Effective Start Date")
                    .ModelProperty("effectivestartdate", typeof(DateTime)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.DayOfMonth = group.Add(new VocabularyKey("DayOfMonth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The day of the month on which the recurring appointment occurs.")
                    .WithDisplayName("Day Of Month")
                    .ModelProperty("dayofmonth", typeof(long)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the recurring appointment's status.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.Organizer = group.Add(new VocabularyKey("Organizer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user who is in charge of coordinating or leading the recurring appointment to make sure the appointment is displayed in the user's My Activities view.")
                    .WithDisplayName("Organizer")
                    .ModelProperty("organizer", typeof(string)));

                this.StartTime = group.Add(new VocabularyKey("StartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Start time of the recurring appointment series.")
                    .WithDisplayName("Pattern Start Time")
                    .ModelProperty("starttime", typeof(DateTime)));

                this.Occurrences = group.Add(new VocabularyKey("Occurrences", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of appointment occurrences in a recurring appointment series.")
                    .WithDisplayName("Occurrences")
                    .ModelProperty("occurrences", typeof(long)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the object with which the recurring appointment series is associated.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.MonthOfYearName = group.Add(new VocabularyKey("MonthOfYearName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MonthOfYearName")
                    .ModelProperty("monthofyearname", typeof(string)));

                this.IsAllDayEvent = group.Add(new VocabularyKey("IsAllDayEvent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select whether the recurring appointment is an all-day event to make sure that the required resources are scheduled for the full day.")
                    .WithDisplayName("All Day Event")
                    .ModelProperty("isalldayevent", typeof(bool)));

                this.SeriesStatus = group.Add(new VocabularyKey("SeriesStatus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the recurring appointment series is active or inactive.")
                    .WithDisplayName("Series Status")
                    .ModelProperty("seriesstatus", typeof(bool)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.IsNthMonthly = group.Add(new VocabularyKey("IsNthMonthly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the recurring appointment series should occur after every N months. Valid for monthly recurrence pattern only.")
                    .WithDisplayName("Nth Monthly")
                    .ModelProperty("isnthmonthly", typeof(bool)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the recurring appointment series.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.EndTime = group.Add(new VocabularyKey("EndTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"End time of the associated activity.")
                    .WithDisplayName("Pattern End Time")
                    .ModelProperty("endtime", typeof(DateTime)));

                this.ServiceId = group.Add(new VocabularyKey("ServiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"service_recurringappointmentmasters")
                    .WithDisplayName("Service")
                    .ModelProperty("serviceid", typeof(string)));

                this.DaysOfWeekMask = group.Add(new VocabularyKey("DaysOfWeekMask", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Bitmask that represents the days of the week on which the recurring appointment occurs.")
                    .WithDisplayName("Days Of Week Mask")
                    .ModelProperty("daysofweekmask", typeof(long)));

                this.Subject = group.Add(new VocabularyKey("Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type a short description about the objective or primary topic of the recurring appointment.")
                    .WithDisplayName("Subject")
                    .ModelProperty("subject", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1048576))
                    .WithDescription(@"Type additional information to describe the recurring appointment, such as key talking points or objectives.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.ActivityId = group.Add(new VocabularyKey("ActivityId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the recurring appointment series.")
                    .WithDisplayName("Recurring Appointment")
                    .ModelProperty("activityid", typeof(Guid)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.RequiredAttendees = group.Add(new VocabularyKey("RequiredAttendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the account, contact, lead, user, or other equipment resources that are required to attend the recurring appointment.")
                    .WithDisplayName("Required Attendees")
                    .ModelProperty("requiredattendees", typeof(string)));

                this.Instance = group.Add(new VocabularyKey("Instance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the recurring appointment series to occur on every Nth day of a month. Valid for monthly and yearly recurrence patterns only.")
                    .WithDisplayName("Instance")
                    .ModelProperty("instance", typeof(string)));

                this.DeletedExceptionsList = group.Add(new VocabularyKey("DeletedExceptionsList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"List of deleted instances of the recurring appointment series.")
                    .WithDisplayName("Deleted Appointments")
                    .ModelProperty("deletedexceptionslist", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Interval = group.Add(new VocabularyKey("Interval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of units of a given recurrence type between occurrences.")
                    .WithDisplayName("Interval")
                    .ModelProperty("interval", typeof(long)));

                this.Duration = group.Add(new VocabularyKey("Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Duration of the recurring appointment series in minutes.")
                    .WithDisplayName("Duration")
                    .ModelProperty("duration", typeof(long)));

                this.MonthOfYear = group.Add(new VocabularyKey("MonthOfYear", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates the month of the year for the recurrence pattern.")
                    .WithDisplayName("Month Of Year")
                    .ModelProperty("monthofyear", typeof(string)));

                this.Location = group.Add(new VocabularyKey("Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Type the location where the recurring appointment will take place, such as a conference room or customer office.")
                    .WithDisplayName("Location")
                    .ModelProperty("location", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.IsWorkflowCreatedName = group.Add(new VocabularyKey("IsWorkflowCreatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsWorkflowCreatedName")
                    .ModelProperty("isworkflowcreatedname", typeof(string)));

                this.InstanceTypeCodeName = group.Add(new VocabularyKey("InstanceTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InstanceTypeCodeName")
                    .ModelProperty("instancetypecodename", typeof(string)));

                this.IsRegenerateName = group.Add(new VocabularyKey("IsRegenerateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsRegenerateName")
                    .ModelProperty("isregeneratename", typeof(string)));

                this.PriorityCodeName = group.Add(new VocabularyKey("PriorityCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PriorityCodeName")
                    .ModelProperty("prioritycodename", typeof(string)));

                this.SeriesStatusName = group.Add(new VocabularyKey("SeriesStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SeriesStatusName")
                    .ModelProperty("seriesstatusname", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.IsWeekDayPatternName = group.Add(new VocabularyKey("IsWeekDayPatternName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsWeekDayPatternName")
                    .ModelProperty("isweekdaypatternname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.PatternEndTypeName = group.Add(new VocabularyKey("PatternEndTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PatternEndTypeName")
                    .ModelProperty("patternendtypename", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.InstanceName = group.Add(new VocabularyKey("InstanceName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InstanceName")
                    .ModelProperty("instancename", typeof(string)));

                this.ExpansionStateCodeName = group.Add(new VocabularyKey("ExpansionStateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ExpansionStateCodeName")
                    .ModelProperty("expansionstatecodename", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.IsAllDayEventName = group.Add(new VocabularyKey("IsAllDayEventName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsAllDayEventName")
                    .ModelProperty("isalldayeventname", typeof(string)));

                this.IsBilledName = group.Add(new VocabularyKey("IsBilledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsBilledName")
                    .ModelProperty("isbilledname", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.IsNthMonthlyName = group.Add(new VocabularyKey("IsNthMonthlyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsNthMonthlyName")
                    .ModelProperty("isnthmonthlyname", typeof(string)));

                this.RecurrencePatternTypeName = group.Add(new VocabularyKey("RecurrencePatternTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RecurrencePatternTypeName")
                    .ModelProperty("recurrencepatterntypename", typeof(string)));

                this.IsNthYearlyName = group.Add(new VocabularyKey("IsNthYearlyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsNthYearlyName")
                    .ModelProperty("isnthyearlyname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

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

                this.ScheduledStart = group.Add(new VocabularyKey("ScheduledStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Scheduled start time of the recurring appointment series.")
                    .WithDisplayName("Start Time")
                    .ModelProperty("scheduledstart", typeof(DateTime)));

                this.ScheduledEnd = group.Add(new VocabularyKey("ScheduledEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Scheduled end time of the recurring appointment series.")
                    .WithDisplayName("End Time")
                    .ModelProperty("scheduledend", typeof(DateTime)));

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
                    .WithDescription(@"Indicates whether the activity is a regular activity type or event type.")
                    .WithDisplayName("Is Regular Activity")
                    .ModelProperty("isregularactivity", typeof(bool)));

                this.IsRegularActivityName = group.Add(new VocabularyKey("IsRegularActivityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsRegularActivityName")
                    .ModelProperty("isregularactivityname", typeof(string)));

                this.PatternEndType = group.Add(new VocabularyKey("PatternEndType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the type of end date for the recurring appointment, such as no end date or the number of occurrences.")
                    .WithDisplayName("Pattern End Type")
                    .ModelProperty("patternendtype", typeof(string)));

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

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the team who owns the recurring appointment series.")
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

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("(Deprecated) Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

                this.SortDate = group.Add(new VocabularyKey("SortDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the date and time by which the activities are sorted.")
                    .WithDisplayName("Sort Date")
                    .ModelProperty("sortdate", typeof(DateTime)));

                this.SafeDescription = group.Add(new VocabularyKey("SafeDescription", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Safe body text of the recurring appointment.")
                    .WithDisplayName("Safe Description")
                    .ModelProperty("safedescription", typeof(string)));

                this.IsUnsafe = group.Add(new VocabularyKey("IsUnsafe", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("IsUnsafe")
                    .ModelProperty("isunsafe", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey IsWeekDayPattern { get; private set; }

        public VocabularyKey RuleId { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey IsNthYearly { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey GroupId { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey OptionalAttendees { get; private set; }

        public VocabularyKey SubscriptionId { get; private set; }

        public VocabularyKey LastExpandedInstanceDate { get; private set; }

        public VocabularyKey EffectiveEndDate { get; private set; }

        public VocabularyKey PatternStartDate { get; private set; }

        public VocabularyKey IsWorkflowCreated { get; private set; }

        public VocabularyKey InstanceTypeCode { get; private set; }

        public VocabularyKey IsRegenerate { get; private set; }

        public VocabularyKey FirstDayOfWeek { get; private set; }

        public VocabularyKey Subcategory { get; private set; }

        public VocabularyKey Category { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OutlookOwnerApptId { get; private set; }

        public VocabularyKey RecurrencePatternType { get; private set; }

        public VocabularyKey NextExpansionInstanceDate { get; private set; }

        public VocabularyKey ExpansionStateCode { get; private set; }

        public VocabularyKey PriorityCode { get; private set; }

        public VocabularyKey IsBilled { get; private set; }

        public VocabularyKey PatternEndDate { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey GlobalObjectId { get; private set; }

        public VocabularyKey EffectiveStartDate { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey DayOfMonth { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey Organizer { get; private set; }

        public VocabularyKey StartTime { get; private set; }

        public VocabularyKey Occurrences { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey MonthOfYearName { get; private set; }

        public VocabularyKey IsAllDayEvent { get; private set; }

        public VocabularyKey SeriesStatus { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey IsNthMonthly { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey EndTime { get; private set; }

        public VocabularyKey ServiceId { get; private set; }

        public VocabularyKey DaysOfWeekMask { get; private set; }

        public VocabularyKey Subject { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey ActivityId { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey RequiredAttendees { get; private set; }

        public VocabularyKey Instance { get; private set; }

        public VocabularyKey DeletedExceptionsList { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Interval { get; private set; }

        public VocabularyKey Duration { get; private set; }

        public VocabularyKey MonthOfYear { get; private set; }

        public VocabularyKey Location { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey IsWorkflowCreatedName { get; private set; }

        public VocabularyKey InstanceTypeCodeName { get; private set; }

        public VocabularyKey IsRegenerateName { get; private set; }

        public VocabularyKey PriorityCodeName { get; private set; }

        public VocabularyKey SeriesStatusName { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey IsWeekDayPatternName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey PatternEndTypeName { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey InstanceName { get; private set; }

        public VocabularyKey ExpansionStateCodeName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey IsAllDayEventName { get; private set; }

        public VocabularyKey IsBilledName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey IsNthMonthlyName { get; private set; }

        public VocabularyKey RecurrencePatternTypeName { get; private set; }

        public VocabularyKey IsNthYearlyName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ScheduledStart { get; private set; }

        public VocabularyKey ScheduledEnd { get; private set; }

        public VocabularyKey ActivityTypeCode { get; private set; }

        public VocabularyKey ActivityTypeCodeName { get; private set; }

        public VocabularyKey IsRegularActivity { get; private set; }

        public VocabularyKey IsRegularActivityName { get; private set; }

        public VocabularyKey PatternEndType { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey IsMapiPrivate { get; private set; }

        public VocabularyKey IsMapiPrivateName { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey SortDate { get; private set; }

        public VocabularyKey SafeDescription { get; private set; }

        public VocabularyKey IsUnsafe { get; private set; }


    }
}

