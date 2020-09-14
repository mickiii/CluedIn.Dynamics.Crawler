using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ResourceVocabulary : SimpleVocabulary
    {
        public ResourceVocabulary()
        {
            VocabularyName = "Dynamics365 Resource";
            KeyPrefix = "dynamics365.resource";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Resource", group =>
            {
                this.DisplayInServiceViews = group.Add(new VocabularyKey("DisplayInServiceViews", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Display in Service Views")
                    .ModelProperty("displayinserviceviews", typeof(bool)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of entity with which the resource is associated.")
                    .WithDisplayName("Object Type ")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.BusinessUnitId = group.Add(new VocabularyKey("BusinessUnitId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"business_unit_resources")
                    .WithDisplayName("Business Unit")
                    .ModelProperty("businessunitid", typeof(string)));

                this.CalendarId = group.Add(new VocabularyKey("CalendarId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the calendar for the resource.")
                    .WithDisplayName("Calendar")
                    .ModelProperty("calendarid", typeof(Guid)));

                this.IsDisabled = group.Add(new VocabularyKey("IsDisabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about whether the resource is enabled.")
                    .WithDisplayName("Is Disabled")
                    .ModelProperty("isdisabled", typeof(bool)));

                this.ResourceId = group.Add(new VocabularyKey("ResourceId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"systemuser_resources")
                    .WithDisplayName("Resource")
                    .ModelProperty("resourceid", typeof(Guid)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the resource.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"organization_resources")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the resource.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.SiteId = group.Add(new VocabularyKey("SiteId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"site_resources")
                    .WithDisplayName("Site")
                    .ModelProperty("siteid", typeof(string)));

                this.DisplayInServiceViewsName = group.Add(new VocabularyKey("DisplayInServiceViewsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DisplayInServiceViewsName")
                    .ModelProperty("displayinserviceviewsname", typeof(string)));

                this.SiteIdName = group.Add(new VocabularyKey("SiteIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SiteIdName")
                    .ModelProperty("siteidname", typeof(string)));

                this.IsDisabledName = group.Add(new VocabularyKey("IsDisabledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsDisabledName")
                    .ModelProperty("isdisabledname", typeof(string)));

                this.ObjectTypeCodeName = group.Add(new VocabularyKey("ObjectTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ObjectTypeCodeName")
                    .ModelProperty("objecttypecodename", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.BusinessUnitIdName = group.Add(new VocabularyKey("BusinessUnitIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("BusinessUnitIdName")
                    .ModelProperty("businessunitidname", typeof(string)));

                this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the default image for the record.")
                    .WithDisplayName("Entity Image")
                    .ModelProperty("entityimage", typeof(string)));

                this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_URL")
                    .ModelProperty("entityimage_url", typeof(string)));

                this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Entity Image Id")
                    .ModelProperty("entityimageid", typeof(Guid)));

                this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityImage_Timestamp")
                    .ModelProperty("entityimage_timestamp", typeof(int)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Sequence number of the import that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

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


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey DisplayInServiceViews { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey BusinessUnitId { get; private set; }

        public VocabularyKey CalendarId { get; private set; }

        public VocabularyKey IsDisabled { get; private set; }

        public VocabularyKey ResourceId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey SiteId { get; private set; }

        public VocabularyKey DisplayInServiceViewsName { get; private set; }

        public VocabularyKey SiteIdName { get; private set; }

        public VocabularyKey IsDisabledName { get; private set; }

        public VocabularyKey ObjectTypeCodeName { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey BusinessUnitIdName { get; private set; }

        public VocabularyKey EntityImage { get; private set; }

        public VocabularyKey EntityImage_URL { get; private set; }

        public VocabularyKey EntityImageId { get; private set; }

        public VocabularyKey EntityImage_Timestamp { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}

