using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class OrgInsightsNotificationVocabulary : SimpleVocabulary
    {
        public OrgInsightsNotificationVocabulary()
        {
            VocabularyName = "Dynamics365 OrgInsightsNotification";
            KeyPrefix = "dynamics365.orginsightsnotification";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("OrgInsightsNotification", group =>
            {
                this.OrgInsightsNotificationId = group.Add(new VocabularyKey("OrgInsightsNotificationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OrgInsightsNotificationId")
                    .ModelProperty("orginsightsnotificationid", typeof(Guid)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the record")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the organization insights notification was created")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.InternalName = group.Add(new VocabularyKey("InternalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the notification which is used for retrieving the data")
                    .WithDisplayName("Name of the notification that is used for retrieving the data")
                    .ModelProperty("internalname", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Legend Name used while displaying the notification")
                    .WithDisplayName("Legend Name used wile displaying the notification")
                    .ModelProperty("name", typeof(string)));

                this.JsonData = group.Add(new VocabularyKey("JsonData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Notification Data in Json format")
                    .WithDisplayName("Notification Data in Json format")
                    .ModelProperty("jsondata", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey OrgInsightsNotificationId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey InternalName { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey JsonData { get; private set; }


    }
}

