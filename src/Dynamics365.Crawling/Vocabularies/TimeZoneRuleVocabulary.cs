using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class TimeZoneRuleVocabulary : SimpleVocabulary
    {
        public TimeZoneRuleVocabulary()
        {
            VocabularyName = "Dynamics365 TimeZoneRule";
            KeyPrefix = "dynamics365.timezonerule";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("TimeZoneRule", group =>
            {
                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the time zone rule.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.StandardDay = group.Add(new VocabularyKey("StandardDay", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Day of the month when standard time starts.")
                    .WithDisplayName("Standard Day")
                    .ModelProperty("standardday", typeof(long)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the time zone rule was modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.StandardMinute = group.Add(new VocabularyKey("StandardMinute", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Minute of the hour when standard time starts.")
                    .WithDisplayName("Standard Minute")
                    .ModelProperty("standardminute", typeof(long)));

                this.StandardBias = group.Add(new VocabularyKey("StandardBias", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time bias in addition to the base bias for standard time.")
                    .WithDisplayName("Standard Bias")
                    .ModelProperty("standardbias", typeof(long)));

                this.StandardYear = group.Add(new VocabularyKey("StandardYear", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Year when standard time starts.")
                    .WithDisplayName("Standard Year")
                    .ModelProperty("standardyear", typeof(long)));

                this.DaylightMonth = group.Add(new VocabularyKey("DaylightMonth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Month when daylight savings time starts.")
                    .WithDisplayName("Daylight Month")
                    .ModelProperty("daylightmonth", typeof(long)));

                this.StandardDayOfWeek = group.Add(new VocabularyKey("StandardDayOfWeek", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Day of the week when standard time starts.")
                    .WithDisplayName("Standard Day Of Week")
                    .ModelProperty("standarddayofweek", typeof(long)));

                this.DaylightSecond = group.Add(new VocabularyKey("DaylightSecond", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Second of the minute when daylight savings time starts")
                    .WithDisplayName("Daylight Second")
                    .ModelProperty("daylightsecond", typeof(long)));

                this.Bias = group.Add(new VocabularyKey("Bias", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Base time bias of the time zone rule.")
                    .WithDisplayName("Bias")
                    .ModelProperty("bias", typeof(long)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.DaylightBias = group.Add(new VocabularyKey("DaylightBias", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time bias in addition to the base bias for daylight savings time.")
                    .WithDisplayName("Daylight Bias")
                    .ModelProperty("daylightbias", typeof(long)));

                this.StandardMonth = group.Add(new VocabularyKey("StandardMonth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Month when standard time starts.")
                    .WithDisplayName("Standard Month")
                    .ModelProperty("standardmonth", typeof(long)));

                this.EffectiveDateTime = group.Add(new VocabularyKey("EffectiveDateTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time that this rule takes effect, in local time.")
                    .WithDisplayName("Effective Date Time")
                    .ModelProperty("effectivedatetime", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the time zone rule.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.DaylightHour = group.Add(new VocabularyKey("DaylightHour", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Hour of the day when daylight savings time starts")
                    .WithDisplayName("Daylight Hour")
                    .ModelProperty("daylighthour", typeof(long)));

                this.StandardHour = group.Add(new VocabularyKey("StandardHour", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Hour of the day when standard time starts.")
                    .WithDisplayName("Standard Hour")
                    .ModelProperty("standardhour", typeof(long)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the time zone rule was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.DaylightYear = group.Add(new VocabularyKey("DaylightYear", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Year when daylight savings times starts.")
                    .WithDisplayName("Daylight Year")
                    .ModelProperty("daylightyear", typeof(long)));

                this.StandardSecond = group.Add(new VocabularyKey("StandardSecond", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Second of the Minute when standard time starts.")
                    .WithDisplayName("Standard Second")
                    .ModelProperty("standardsecond", typeof(long)));

                this.DaylightMinute = group.Add(new VocabularyKey("DaylightMinute", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Minute of the hour when daylight savings time starts.")
                    .WithDisplayName("Daylight Minute")
                    .ModelProperty("daylightminute", typeof(long)));

                this.TimeZoneDefinitionId = group.Add(new VocabularyKey("TimeZoneDefinitionId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the time zone definition.")
                    .WithDisplayName("Time Zone Definition")
                    .ModelProperty("timezonedefinitionid", typeof(string)));

                this.DaylightDayOfWeek = group.Add(new VocabularyKey("DaylightDayOfWeek", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Day of the week when daylight savings time starts.")
                    .WithDisplayName("Daylight Day Of Week")
                    .ModelProperty("daylightdayofweek", typeof(long)));

                this.TimeZoneRuleId = group.Add(new VocabularyKey("TimeZoneRuleId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the time zone rule.")
                    .WithDisplayName("Time Zone Rule")
                    .ModelProperty("timezoneruleid", typeof(Guid)));

                this.DaylightDay = group.Add(new VocabularyKey("DaylightDay", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Day of the month when daylight savings time starts.")
                    .WithDisplayName("Daylight Day")
                    .ModelProperty("daylightday", typeof(long)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the time zone rule.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the timezonerule.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who last modified the timezonerule.")
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


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey StandardDay { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey StandardMinute { get; private set; }

        public VocabularyKey StandardBias { get; private set; }

        public VocabularyKey StandardYear { get; private set; }

        public VocabularyKey DaylightMonth { get; private set; }

        public VocabularyKey StandardDayOfWeek { get; private set; }

        public VocabularyKey DaylightSecond { get; private set; }

        public VocabularyKey Bias { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey DaylightBias { get; private set; }

        public VocabularyKey StandardMonth { get; private set; }

        public VocabularyKey EffectiveDateTime { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey DaylightHour { get; private set; }

        public VocabularyKey StandardHour { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey DaylightYear { get; private set; }

        public VocabularyKey StandardSecond { get; private set; }

        public VocabularyKey DaylightMinute { get; private set; }

        public VocabularyKey TimeZoneDefinitionId { get; private set; }

        public VocabularyKey DaylightDayOfWeek { get; private set; }

        public VocabularyKey TimeZoneRuleId { get; private set; }

        public VocabularyKey DaylightDay { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }


    }
}

