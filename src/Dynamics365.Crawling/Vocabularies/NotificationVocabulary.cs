using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class NotificationVocabulary : SimpleVocabulary
    {
        public NotificationVocabulary()
        {
            VocabularyName = "Dynamics365 Notification";
            KeyPrefix = "dynamics365.notification";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Notification", group =>
            {
                this.NotificationNumber = group.Add(new VocabularyKey("NotificationNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("NotificationNumber")
                    .ModelProperty("notificationnumber", typeof(long)));

                this.EventData = group.Add(new VocabularyKey("EventData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("EventData")
                    .ModelProperty("eventdata", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("CreatedOn")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.EventId = group.Add(new VocabularyKey("EventId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("EventId")
                    .ModelProperty("eventid", typeof(long)));

                this.NotificationId = group.Add(new VocabularyKey("NotificationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("NotificationId")
                    .ModelProperty("notificationid", typeof(Guid)));

                this.CreatedOnString = group.Add(new VocabularyKey("CreatedOnString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(40))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("CreatedOnString")
                    .ModelProperty("createdonstring", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey NotificationNumber { get; private set; }

        public VocabularyKey EventData { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey EventId { get; private set; }

        public VocabularyKey NotificationId { get; private set; }

        public VocabularyKey CreatedOnString { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }


    }
}

