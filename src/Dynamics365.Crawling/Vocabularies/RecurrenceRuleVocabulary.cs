using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class RecurrenceRuleVocabulary : SimpleVocabulary
    {
        public RecurrenceRuleVocabulary()
        {
            VocabularyName = "Dynamics365 RecurrenceRule";
            KeyPrefix = "dynamics365.recurrencerule";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("RecurrenceRule", group =>
            {
                this.DayOfMonth = group.Add(new VocabularyKey("DayOfMonth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The day of the month on which the recurring appointment or task occurs.")
                    .WithDisplayName("Day Of Month")
                    .ModelProperty("dayofmonth", typeof(long)));

                this.Duration = group.Add(new VocabularyKey("Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Duration of the recurrence pattern in minutes.")
                    .WithDisplayName("Duration")
                    .ModelProperty("duration", typeof(long)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the recurrence rule.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Object Type ")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the recurrence rule was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the recurrence rule was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.RuleId = group.Add(new VocabularyKey("RuleId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the entity associated with recurrence rule.")
                    .WithDisplayName("Recurrence Rule")
                    .ModelProperty("ruleid", typeof(Guid)));

                this.IsNthMonthly = group.Add(new VocabularyKey("IsNthMonthly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies whether the monthly recurrence pattern is Nth monthly, valid only for monthly recurrence.")
                    .WithDisplayName("Nth Monthly")
                    .ModelProperty("isnthmonthly", typeof(bool)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.MonthOfYearName = group.Add(new VocabularyKey("MonthOfYearName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MonthOfYearName")
                    .ModelProperty("monthofyearname", typeof(string)));

                this.EffectiveStartDate = group.Add(new VocabularyKey("EffectiveStartDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The actual start date for expansion of the recurrence pattern.")
                    .WithDisplayName("Effective Start Date")
                    .ModelProperty("effectivestartdate", typeof(DateTime)));

                this.RecurrencePatternType = group.Add(new VocabularyKey("RecurrencePatternType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of Recurrence.")
                    .WithDisplayName("Recurrence Pattern")
                    .ModelProperty("recurrencepatterntype", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the recurrence rule.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.MonthOfYear = group.Add(new VocabularyKey("MonthOfYear", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the month of the year valid for the recurrence pattern.")
                    .WithDisplayName("Month Of Year")
                    .ModelProperty("monthofyear", typeof(string)));

                this.EffectiveEndDate = group.Add(new VocabularyKey("EffectiveEndDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The actual end date for expansion of the recurrence pattern.")
                    .WithDisplayName("Effective End Date")
                    .ModelProperty("effectiveenddate", typeof(DateTime)));

                this.StartTime = group.Add(new VocabularyKey("StartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Start time of the recurring activity.")
                    .WithDisplayName("Start Time")
                    .ModelProperty("starttime", typeof(DateTime)));

                this.Interval = group.Add(new VocabularyKey("Interval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of units of a given recurrence type between occurrences.")
                    .WithDisplayName("Interval")
                    .ModelProperty("interval", typeof(long)));

                this.EndTime = group.Add(new VocabularyKey("EndTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"End time of the associated activity.")
                    .WithDisplayName("End Time")
                    .ModelProperty("endtime", typeof(DateTime)));

                this.PatternEndType = group.Add(new VocabularyKey("PatternEndType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Pattern End Type of a recurring series.")
                    .WithDisplayName("Pattern End Type")
                    .ModelProperty("patternendtype", typeof(string)));

                this.IsNthYearly = group.Add(new VocabularyKey("IsNthYearly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies whether the yearly recurrence pattern is Nth yearly, valid only for yearly recurrence.")
                    .WithDisplayName("Nth Yearly")
                    .ModelProperty("isnthyearly", typeof(bool)));

                this.PatternStartDate = group.Add(new VocabularyKey("PatternStartDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Start date of the Recurrence Range.")
                    .WithDisplayName("Recurrence Range Start")
                    .ModelProperty("patternstartdate", typeof(DateTime)));

                this.Instance = group.Add(new VocabularyKey("Instance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies the count for which the recurrence pattern is valid for a given interval.")
                    .WithDisplayName("Instance")
                    .ModelProperty("instance", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the recurrence rule.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.IsWeekDayPattern = group.Add(new VocabularyKey("IsWeekDayPattern", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies whether the weekly recurrence pattern is actually a daily every weekday pattern, valid only for weekly recurrence.")
                    .WithDisplayName("Every Weekday")
                    .ModelProperty("isweekdaypattern", typeof(bool)));

                this.PatternEndDate = group.Add(new VocabularyKey("PatternEndDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"End date of the Recurrence Range.")
                    .WithDisplayName("Recurrence Range End")
                    .ModelProperty("patternenddate", typeof(DateTime)));

                this.FirstDayOfWeek = group.Add(new VocabularyKey("FirstDayOfWeek", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"First day Of week for the recurrence pattern.")
                    .WithDisplayName("First Day Of Week")
                    .ModelProperty("firstdayofweek", typeof(long)));

                this.IsRegenerate = group.Add(new VocabularyKey("IsRegenerate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Valid only for task type recurrence,indicates whether task should be regenerated.")
                    .WithDisplayName("Regenerate")
                    .ModelProperty("isregenerate", typeof(bool)));

                this.ObjectId = group.Add(new VocabularyKey("ObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the object with which the recurrence rule is associated.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("objectid", typeof(string)));

                this.DaysOfWeekMask = group.Add(new VocabularyKey("DaysOfWeekMask", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Bitmask representing the days of the week on which the recurring appointment or task occurs.")
                    .WithDisplayName("Days Of Week Mask")
                    .ModelProperty("daysofweekmask", typeof(long)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the recurrence rule.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.Occurrences = group.Add(new VocabularyKey("Occurrences", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of occurrences of the recurrence pattern.")
                    .WithDisplayName("Occurrences")
                    .ModelProperty("occurrences", typeof(long)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.InstanceName = group.Add(new VocabularyKey("InstanceName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InstanceName")
                    .ModelProperty("instancename", typeof(string)));

                this.IsWeekDayPatternName = group.Add(new VocabularyKey("IsWeekDayPatternName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsWeekDayPatternName")
                    .ModelProperty("isweekdaypatternname", typeof(string)));

                this.RecurrencePatternTypeName = group.Add(new VocabularyKey("RecurrencePatternTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RecurrencePatternTypeName")
                    .ModelProperty("recurrencepatterntypename", typeof(string)));

                this.PatternEndTypeName = group.Add(new VocabularyKey("PatternEndTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PatternEndTypeName")
                    .ModelProperty("patternendtypename", typeof(string)));

                this.IsNthMonthlyName = group.Add(new VocabularyKey("IsNthMonthlyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsNthMonthlyName")
                    .ModelProperty("isnthmonthlyname", typeof(string)));

                this.IsNthYearlyName = group.Add(new VocabularyKey("IsNthYearlyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsNthYearlyName")
                    .ModelProperty("isnthyearlyname", typeof(string)));

                this.IsRegenerateName = group.Add(new VocabularyKey("IsRegenerateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsRegenerateName")
                    .ModelProperty("isregeneratename", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

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

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the recurrence rule.")
                    .WithDisplayName("Created By (Delegate)")
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
                    .WithDescription(@"Unique identifier of the delegate user who created the recurrence rule.")
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
                    .WithDescription(@"")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey DayOfMonth { get; private set; }

        public VocabularyKey Duration { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey RuleId { get; private set; }

        public VocabularyKey IsNthMonthly { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey MonthOfYearName { get; private set; }

        public VocabularyKey EffectiveStartDate { get; private set; }

        public VocabularyKey RecurrencePatternType { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey MonthOfYear { get; private set; }

        public VocabularyKey EffectiveEndDate { get; private set; }

        public VocabularyKey StartTime { get; private set; }

        public VocabularyKey Interval { get; private set; }

        public VocabularyKey EndTime { get; private set; }

        public VocabularyKey PatternEndType { get; private set; }

        public VocabularyKey IsNthYearly { get; private set; }

        public VocabularyKey PatternStartDate { get; private set; }

        public VocabularyKey Instance { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey IsWeekDayPattern { get; private set; }

        public VocabularyKey PatternEndDate { get; private set; }

        public VocabularyKey FirstDayOfWeek { get; private set; }

        public VocabularyKey IsRegenerate { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey DaysOfWeekMask { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey Occurrences { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey InstanceName { get; private set; }

        public VocabularyKey IsWeekDayPatternName { get; private set; }

        public VocabularyKey RecurrencePatternTypeName { get; private set; }

        public VocabularyKey PatternEndTypeName { get; private set; }

        public VocabularyKey IsNthMonthlyName { get; private set; }

        public VocabularyKey IsNthYearlyName { get; private set; }

        public VocabularyKey IsRegenerateName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }


    }
}

