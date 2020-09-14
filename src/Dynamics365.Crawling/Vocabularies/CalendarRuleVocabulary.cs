using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class CalendarRuleVocabulary : SimpleVocabulary
    {
        public CalendarRuleVocabulary()
        {
            VocabularyName = "Dynamics365 CalendarRule";
            KeyPrefix = "dynamics365.calendarrule";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("CalendarRule", group =>
            {
                this.IsVaried = group.Add(new VocabularyKey("IsVaried", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag used in leaf nonrecurring rules.")
                    .WithDisplayName("Is Varied")
                    .ModelProperty("isvaried", typeof(bool)));

                this.Rank = group.Add(new VocabularyKey("Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Rank of the calendar rule.")
                    .WithDisplayName("Rank")
                    .ModelProperty("rank", typeof(long)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the calendar rule was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the calendar rule.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation, and blocked.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.CalendarRuleId = group.Add(new VocabularyKey("CalendarRuleId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the calendar rule.")
                    .WithDisplayName("Calendar Rule")
                    .ModelProperty("calendarruleid", typeof(Guid)));

                this.Effort = group.Add(new VocabularyKey("Effort", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Effort available for a resource during the time described by the calendar rule.")
                    .WithDisplayName("Effort")
                    .ModelProperty("effort", typeof(double)));

                this.EndTime = group.Add(new VocabularyKey("EndTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("End")
                    .ModelProperty("endtime", typeof(DateTime)));

                this.TimeCode = group.Add(new VocabularyKey("TimeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of calendar rule such as working hours, break, holiday, or time off.")
                    .WithDisplayName("Type")
                    .ModelProperty("timecode", typeof(long)));

                this.StartTime = group.Add(new VocabularyKey("StartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Start time for the rule.")
                    .WithDisplayName("Start")
                    .ModelProperty("starttime", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the calendar rule.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.BusinessUnitId = group.Add(new VocabularyKey("BusinessUnitId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit with which the calendar rule is associated.")
                    .WithDisplayName("Business Unit")
                    .ModelProperty("businessunitid", typeof(Guid)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Offset = group.Add(new VocabularyKey("Offset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Start offset for leaf nonrecurring rules.")
                    .WithDisplayName("Offset")
                    .ModelProperty("offset", typeof(long)));

                this.IsSimple = group.Add(new VocabularyKey("IsSimple", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag used in vary-by-day calendar rules.")
                    .WithDisplayName("Is Simple")
                    .ModelProperty("issimple", typeof(bool)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the calendar rule.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.TimeZoneCode = group.Add(new VocabularyKey("TimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Local time zone for the calendar rule.")
                    .WithDisplayName("Time Zone")
                    .ModelProperty("timezonecode", typeof(long)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization with which the calendar rule is associated.")
                    .WithDisplayName("Organization ")
                    .ModelProperty("organizationid", typeof(Guid)));

                this.IsSelected = group.Add(new VocabularyKey("IsSelected", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag used in vary-by-day calendar rules.")
                    .WithDisplayName("Is Selected")
                    .ModelProperty("isselected", typeof(bool)));

                this.ExtentCode = group.Add(new VocabularyKey("ExtentCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Extent of the calendar rule.")
                    .WithDisplayName("Extent Code")
                    .ModelProperty("extentcode", typeof(long)));

                this.EffectiveIntervalEnd = group.Add(new VocabularyKey("EffectiveIntervalEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Effective interval end of the calendar rule.")
                    .WithDisplayName("Effective Interval End")
                    .ModelProperty("effectiveintervalend", typeof(DateTime)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the calendar rule was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.CalendarId = group.Add(new VocabularyKey("CalendarId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the calendar with which the calendar rule is associated.")
                    .WithDisplayName("Calendar")
                    .ModelProperty("calendarid", typeof(string)));

                this.InnerCalendarId = group.Add(new VocabularyKey("InnerCalendarId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the inner calendar for non-leaf calendar rules.")
                    .WithDisplayName("Inner Calendar")
                    .ModelProperty("innercalendarid", typeof(string)));

                this.Pattern = group.Add(new VocabularyKey("Pattern", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Pattern of the rule recurrence.")
                    .WithDisplayName("Recurrence Pattern")
                    .ModelProperty("pattern", typeof(string)));

                this.GroupDesignator = group.Add(new VocabularyKey("GroupDesignator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(36))
                    .WithDescription(@"Unique identifier of the group.")
                    .WithDisplayName("Group Designator")
                    .ModelProperty("groupdesignator", typeof(string)));

                this.IsModified = group.Add(new VocabularyKey("IsModified", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Is Modified")
                    .ModelProperty("ismodified", typeof(bool)));

                this.SubCode = group.Add(new VocabularyKey("SubCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Sub-type of calendar rule.")
                    .WithDisplayName("Sub Code")
                    .ModelProperty("subcode", typeof(long)));

                this.Duration = group.Add(new VocabularyKey("Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Duration of the calendar rule in minutes.")
                    .WithDisplayName("Duration")
                    .ModelProperty("duration", typeof(long)));

                this.EffectiveIntervalStart = group.Add(new VocabularyKey("EffectiveIntervalStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Effective interval start of the calendar rule.")
                    .WithDisplayName("Effective Interval Start")
                    .ModelProperty("effectiveintervalstart", typeof(DateTime)));

                this.ServiceId = group.Add(new VocabularyKey("ServiceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"service_calendar_rules")
                    .WithDisplayName("Service")
                    .ModelProperty("serviceid", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.IsSimpleName = group.Add(new VocabularyKey("IsSimpleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsSimpleName")
                    .ModelProperty("issimplename", typeof(string)));

                this.IsSelectedName = group.Add(new VocabularyKey("IsSelectedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsSelectedName")
                    .ModelProperty("isselectedname", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.IsModifiedName = group.Add(new VocabularyKey("IsModifiedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsModifiedName")
                    .ModelProperty("ismodifiedname", typeof(string)));

                this.IsVariedName = group.Add(new VocabularyKey("IsVariedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsVariedName")
                    .ModelProperty("isvariedname", typeof(string)));

                this.ServiceIdName = group.Add(new VocabularyKey("ServiceIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ServiceIdName")
                    .ModelProperty("serviceidname", typeof(string)));

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

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the calendarrule.")
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
                    .WithDescription(@"Unique identifier of the delegate user who last modified the calendarrule.")
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


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey IsVaried { get; private set; }

        public VocabularyKey Rank { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey CalendarRuleId { get; private set; }

        public VocabularyKey Effort { get; private set; }

        public VocabularyKey EndTime { get; private set; }

        public VocabularyKey TimeCode { get; private set; }

        public VocabularyKey StartTime { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey BusinessUnitId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Offset { get; private set; }

        public VocabularyKey IsSimple { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey TimeZoneCode { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey IsSelected { get; private set; }

        public VocabularyKey ExtentCode { get; private set; }

        public VocabularyKey EffectiveIntervalEnd { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey CalendarId { get; private set; }

        public VocabularyKey InnerCalendarId { get; private set; }

        public VocabularyKey Pattern { get; private set; }

        public VocabularyKey GroupDesignator { get; private set; }

        public VocabularyKey IsModified { get; private set; }

        public VocabularyKey SubCode { get; private set; }

        public VocabularyKey Duration { get; private set; }

        public VocabularyKey EffectiveIntervalStart { get; private set; }

        public VocabularyKey ServiceId { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey IsSimpleName { get; private set; }

        public VocabularyKey IsSelectedName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey IsModifiedName { get; private set; }

        public VocabularyKey IsVariedName { get; private set; }

        public VocabularyKey ServiceIdName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }


    }
}

