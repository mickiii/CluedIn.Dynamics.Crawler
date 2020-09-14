using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ActivityPartyVocabulary : SimpleVocabulary
    {
        public ActivityPartyVocabulary()
        {
            VocabularyName = "Dynamics365 ActivityParty";
            KeyPrefix = "dynamics365.activityparty";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ActivityParty", group =>
            {
                this.ActivityId = group.Add(new VocabularyKey("ActivityId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription("Unique identifier of the activity associated with the activity party. (A \"party\" is any person who is associated with an activity.)")
                    .WithDisplayName("Activity")
                    .ModelProperty("activityid", typeof(string)));

                this.ActivityPartyId = group.Add(new VocabularyKey("ActivityPartyId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the activity party.")
                    .WithDisplayName("Activity Party")
                    .ModelProperty("activitypartyid", typeof(Guid)));

                this.PartyId = group.Add(new VocabularyKey("PartyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"salesorder_activity_parties")
                    .WithDisplayName("Party")
                    .ModelProperty("partyid", typeof(string)));

                this.PartyObjectTypeCode = group.Add(new VocabularyKey("PartyObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("PartyObjectTypeCode")
                    .ModelProperty("partyobjecttypecode", typeof(string)));

                this.ParticipationTypeMask = group.Add(new VocabularyKey("ParticipationTypeMask", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.")
                    .WithDisplayName("Participation Type")
                    .ModelProperty("participationtypemask", typeof(string)));

                this.AddressUsed = group.Add(new VocabularyKey("AddressUsed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Email address to which an email is delivered, and which is associated with the target entity.")
                    .WithDisplayName("Address ")
                    .ModelProperty("addressused", typeof(string)));

                this.PartyIdName = group.Add(new VocabularyKey("PartyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("PartyIdName")
                    .ModelProperty("partyidname", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwningBusinessUnit")
                    .ModelProperty("owningbusinessunit", typeof(Guid)));

                this.DoNotFax = group.Add(new VocabularyKey("DoNotFax", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether to allow sending faxes to the activity party.")
                    .WithDisplayName("Do not allow Faxes")
                    .ModelProperty("donotfax", typeof(bool)));

                this.ScheduledStart = group.Add(new VocabularyKey("ScheduledStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Scheduled start time of the activity.")
                    .WithDisplayName("Scheduled Start")
                    .ModelProperty("scheduledstart", typeof(DateTime)));

                this.ScheduledEnd = group.Add(new VocabularyKey("ScheduledEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Scheduled end time of the activity.")
                    .WithDisplayName("Scheduled End")
                    .ModelProperty("scheduledend", typeof(DateTime)));

                this.Effort = group.Add(new VocabularyKey("Effort", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Amount of effort used by the resource in a service appointment activity.")
                    .WithDisplayName("Effort")
                    .ModelProperty("effort", typeof(double)));

                this.DoNotEmail = group.Add(new VocabularyKey("DoNotEmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether to allow sending email to the activity party.")
                    .WithDisplayName("Do not allow Emails")
                    .ModelProperty("donotemail", typeof(bool)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwningUser")
                    .ModelProperty("owninguser", typeof(Guid)));

                this.ExchangeEntryId = group.Add(new VocabularyKey("ExchangeEntryId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Exchange Entry")
                    .ModelProperty("exchangeentryid", typeof(string)));

                this.ResourceSpecId = group.Add(new VocabularyKey("ResourceSpecId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"ActivityPartyResourceSpec")
                    .WithDisplayName("Resource Specification")
                    .ModelProperty("resourcespecid", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ResourceSpecIdName = group.Add(new VocabularyKey("ResourceSpecIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ResourceSpecIdName")
                    .ModelProperty("resourcespecidname", typeof(string)));

                this.DoNotFaxName = group.Add(new VocabularyKey("DoNotFaxName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotFaxName")
                    .ModelProperty("donotfaxname", typeof(string)));

                this.DoNotEmailName = group.Add(new VocabularyKey("DoNotEmailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotEmailName")
                    .ModelProperty("donotemailname", typeof(string)));

                this.ParticipationTypeMaskName = group.Add(new VocabularyKey("ParticipationTypeMaskName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ParticipationTypeMaskName")
                    .ModelProperty("participationtypemaskname", typeof(string)));

                this.DoNotPostalMail = group.Add(new VocabularyKey("DoNotPostalMail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether to allow sending postal mail to the lead.")
                    .WithDisplayName("Do not allow Postal Mails")
                    .ModelProperty("donotpostalmail", typeof(bool)));

                this.DoNotPhone = group.Add(new VocabularyKey("DoNotPhone", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether to allow phone calls to the lead.")
                    .WithDisplayName("Do not allow Phone Calls")
                    .ModelProperty("donotphone", typeof(bool)));

                this.DoNotPhoneName = group.Add(new VocabularyKey("DoNotPhoneName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotPhoneName")
                    .ModelProperty("donotphonename", typeof(string)));

                this.DoNotPostalMailName = group.Add(new VocabularyKey("DoNotPostalMailName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DoNotPostalMailName")
                    .ModelProperty("donotpostalmailname", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the activity_party.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.InstanceTypeCode = group.Add(new VocabularyKey("InstanceTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of instance of a recurring series.")
                    .WithDisplayName("Appointment Type")
                    .ModelProperty("instancetypecode", typeof(string)));

                this.InstanceTypeCodeName = group.Add(new VocabularyKey("InstanceTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InstanceTypeCodeName")
                    .ModelProperty("instancetypecodename", typeof(string)));

                this.IsPartyDeleted = group.Add(new VocabularyKey("IsPartyDeleted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether the underlying entity record is deleted.")
                    .WithDisplayName("Is Party Deleted")
                    .ModelProperty("ispartydeleted", typeof(bool)));

                this.IsPartyDeletedName = group.Add(new VocabularyKey("IsPartyDeletedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPartyDeletedName")
                    .ModelProperty("ispartydeletedname", typeof(string)));

                this.AddressUsedEmailColumnNumber = group.Add(new VocabularyKey("AddressUsedEmailColumnNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Email address column number from associated party.")
                    .WithDisplayName("Email column number of party")
                    .ModelProperty("addressusedemailcolumnnumber", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ActivityId { get; private set; }

        public VocabularyKey ActivityPartyId { get; private set; }

        public VocabularyKey PartyId { get; private set; }

        public VocabularyKey PartyObjectTypeCode { get; private set; }

        public VocabularyKey ParticipationTypeMask { get; private set; }

        public VocabularyKey AddressUsed { get; private set; }

        public VocabularyKey PartyIdName { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey DoNotFax { get; private set; }

        public VocabularyKey ScheduledStart { get; private set; }

        public VocabularyKey ScheduledEnd { get; private set; }

        public VocabularyKey Effort { get; private set; }

        public VocabularyKey DoNotEmail { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey ExchangeEntryId { get; private set; }

        public VocabularyKey ResourceSpecId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ResourceSpecIdName { get; private set; }

        public VocabularyKey DoNotFaxName { get; private set; }

        public VocabularyKey DoNotEmailName { get; private set; }

        public VocabularyKey ParticipationTypeMaskName { get; private set; }

        public VocabularyKey DoNotPostalMail { get; private set; }

        public VocabularyKey DoNotPhone { get; private set; }

        public VocabularyKey DoNotPhoneName { get; private set; }

        public VocabularyKey DoNotPostalMailName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey InstanceTypeCode { get; private set; }

        public VocabularyKey InstanceTypeCodeName { get; private set; }

        public VocabularyKey IsPartyDeleted { get; private set; }

        public VocabularyKey IsPartyDeletedName { get; private set; }

        public VocabularyKey AddressUsedEmailColumnNumber { get; private set; }


    }
}

