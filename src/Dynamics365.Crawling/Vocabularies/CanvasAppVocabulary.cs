using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class CanvasAppVocabulary : SimpleVocabulary
    {
        public CanvasAppVocabulary()
        {
            VocabularyName = "Dynamics365 CanvasApp";
            KeyPrefix = "dynamics365.canvasapp";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("CanvasApp", group =>
            {
                this.CanvasAppRowId = group.Add(new VocabularyKey("CanvasAppRowId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("CanvasAppRowId")
                    .ModelProperty("canvasapprowid", typeof(Guid)));

                this.AppVersion = group.Add(new VocabularyKey("AppVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The application version.")
                    .WithDisplayName("AppVersion")
                    .ModelProperty("appversion", typeof(string)));

                this.Status = group.Add(new VocabularyKey("Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"A value indicating whether the application is ready for consumption.")
                    .WithDisplayName("Status")
                    .ModelProperty("status", typeof(string)));

                this.CreatedByClientVersion = group.Add(new VocabularyKey("CreatedByClientVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The version of the client that was used to author the application.")
                    .WithDisplayName("CreatedByClientVersion")
                    .ModelProperty("createdbyclientversion", typeof(string)));

                this.MinClientVersion = group.Add(new VocabularyKey("MinClientVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The version of the client that was used to author the application.")
                    .WithDisplayName("MinClientVersion")
                    .ModelProperty("minclientversion", typeof(string)));

                this.Tags = group.Add(new VocabularyKey("Tags", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The metadata tags of the application.")
                    .WithDisplayName("Tags")
                    .ModelProperty("tags", typeof(string)));

                this.CreatedTime = group.Add(new VocabularyKey("CreatedTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Date and time when the application was created.")
                    .WithDisplayName("Created Time")
                    .ModelProperty("createdtime", typeof(DateTime)));

                this.AppOpenUri = group.Add(new VocabularyKey("AppOpenUri", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The app open URI.")
                    .WithDisplayName("AppOpenUri")
                    .ModelProperty("appopenuri", typeof(string)));

                this.IsCdsUpgraded = group.Add(new VocabularyKey("IsCdsUpgraded", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the canvas app contains CDS 1.0 references.")
                    .WithDisplayName("Is CDS Upgraded")
                    .ModelProperty("iscdsupgraded", typeof(bool)));

                this.GalleryItemId = group.Add(new VocabularyKey("GalleryItemId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The gallery item identifier.")
                    .WithDisplayName("The gallery item identifier")
                    .ModelProperty("galleryitemid", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the CanvasApp")
                    .WithDisplayName("CanvasApp Name")
                    .ModelProperty("name", typeof(string)));

                this.AADLastModifiedById = group.Add(new VocabularyKey("AADLastModifiedById", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Unique identifier of the user who last modified the application.")
                    .WithDisplayName("Last Modified By")
                    .ModelProperty("aadlastmodifiedbyid", typeof(string)));

                this.AADLastPublishedById = group.Add(new VocabularyKey("AADLastPublishedById", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Unique identifier of the user who last published the application.")
                    .WithDisplayName("Last Published By")
                    .ModelProperty("aadlastpublishedbyid", typeof(string)));

                this.DisplayName = group.Add(new VocabularyKey("DisplayName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The display name of the app.")
                    .WithDisplayName("DisplayName")
                    .ModelProperty("displayname", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The description of the app.")
                    .WithDisplayName("The description.")
                    .ModelProperty("description", typeof(string)));

                this.CommitMessage = group.Add(new VocabularyKey("CommitMessage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The commit message of the app.")
                    .WithDisplayName("The commit message.")
                    .ModelProperty("commitmessage", typeof(string)));

                this.Publisher = group.Add(new VocabularyKey("Publisher", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The publisher of the app.")
                    .WithDisplayName("Publisher")
                    .ModelProperty("publisher", typeof(string)));

                this.LastModifiedTime = group.Add(new VocabularyKey("LastModifiedTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Date and time when the application was last modified.")
                    .WithDisplayName("Last Modified Time")
                    .ModelProperty("lastmodifiedtime", typeof(DateTime)));

                this.LastPublishTime = group.Add(new VocabularyKey("LastPublishTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Date and time when the application was last published.")
                    .WithDisplayName("Last Publish Time")
                    .ModelProperty("lastpublishtime", typeof(DateTime)));

                this.ConnectionReferences = group.Add(new VocabularyKey("ConnectionReferences", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(768000))
                    .WithDescription(@"The connection references of the application.")
                    .WithDisplayName("ConnectionReferences")
                    .ModelProperty("connectionreferences", typeof(string)));

                this.IsFeaturedApp = group.Add(new VocabularyKey("IsFeaturedApp", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the canvas app is a featured app.")
                    .WithDisplayName("Is Featured App")
                    .ModelProperty("isfeaturedapp", typeof(bool)));

                this.BypassConsent = group.Add(new VocabularyKey("BypassConsent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the canvas app should bypass consent from consumers.")
                    .WithDisplayName("Bypass Consent")
                    .ModelProperty("bypassconsent", typeof(bool)));

                this.AdminControlBypassConsent = group.Add(new VocabularyKey("AdminControlBypassConsent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the canvas app was marked for bypass consent by an admin.")
                    .WithDisplayName("Admin Control Bypass Consent")
                    .ModelProperty("admincontrolbypassconsent", typeof(bool)));

                this.IsHeroApp = group.Add(new VocabularyKey("IsHeroApp", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the canvas app is a hero app.")
                    .WithDisplayName("Is Hero App")
                    .ModelProperty("isheroapp", typeof(bool)));

                this.IsHidden = group.Add(new VocabularyKey("IsHidden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the canvas app is hidden from a user's list.")
                    .WithDisplayName("Is Hidden")
                    .ModelProperty("ishidden", typeof(bool)));

                this.CanvasAppId = group.Add(new VocabularyKey("CanvasAppId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("CanvasAppId")
                    .ModelProperty("canvasappid", typeof(Guid)));

                this.BackgroundColor = group.Add(new VocabularyKey("BackgroundColor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The background image color.")
                    .WithDisplayName("BackgroundColor")
                    .ModelProperty("backgroundcolor", typeof(string)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated solution.")
                    .WithDisplayName("Solution")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.SupportingSolutionId = group.Add(new VocabularyKey("SupportingSolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Solution")
                    .ModelProperty("supportingsolutionid", typeof(Guid)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the solution component is part of a managed solution.")
                    .WithDisplayName("Is Managed")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the canvas app is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the user or team who owns the canvas app.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the process.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the team who owns the process.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the process.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.IsCdsUpgradedName = group.Add(new VocabularyKey("IsCdsUpgradedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsCdsUpgradedName")
                    .ModelProperty("iscdsupgradedname", typeof(string)));

                this.IsFeaturedAppName = group.Add(new VocabularyKey("IsFeaturedAppName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsFeaturedAppName")
                    .ModelProperty("isfeaturedappname", typeof(string)));

                this.BypassConsentName = group.Add(new VocabularyKey("BypassConsentName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("BypassConsentName")
                    .ModelProperty("bypassconsentname", typeof(string)));

                this.AdminControlBypassConsentName = group.Add(new VocabularyKey("AdminControlBypassConsentName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AdminControlBypassConsentName")
                    .ModelProperty("admincontrolbypassconsentname", typeof(string)));

                this.IsHeroAppName = group.Add(new VocabularyKey("IsHeroAppName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsHeroAppName")
                    .ModelProperty("isheroappname", typeof(string)));

                this.IsHiddenName = group.Add(new VocabularyKey("IsHiddenName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsHiddenName")
                    .ModelProperty("ishiddenname", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwningBusinessUnitName = group.Add(new VocabularyKey("OwningBusinessUnitName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwningBusinessUnitName")
                    .ModelProperty("owningbusinessunitname", typeof(string)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.AADCreatedById = group.Add(new VocabularyKey("AADCreatedById", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Unique identifier of the user who created the canvas app.")
                    .WithDisplayName("Created By")
                    .ModelProperty("aadcreatedbyid", typeof(string)));

                this.AuthorizationReferences = group.Add(new VocabularyKey("AuthorizationReferences", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"The authorization references of the application.")
                    .WithDisplayName("AuthorizationReferences")
                    .ModelProperty("authorizationreferences", typeof(string)));

                this.EmbeddedApp = group.Add(new VocabularyKey("EmbeddedApp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Internal use. The embedded app information.")
                    .WithDisplayName("EmbeddedApp")
                    .ModelProperty("embeddedapp", typeof(string)));

                this.CdsDependencies = group.Add(new VocabularyKey("CdsDependencies", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(768000))
                    .WithDescription(@"Internal use. The app dependency details.")
                    .WithDisplayName("CdsDependencies")
                    .ModelProperty("cdsdependencies", typeof(string)));

                this.DatabaseReferences = group.Add(new VocabularyKey("DatabaseReferences", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(768000))
                    .WithDescription(@"The database references of the application.")
                    .WithDisplayName("DatabaseReferences")
                    .ModelProperty("databasereferences", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey CanvasAppRowId { get; private set; }

        public VocabularyKey AppVersion { get; private set; }

        public VocabularyKey Status { get; private set; }

        public VocabularyKey CreatedByClientVersion { get; private set; }

        public VocabularyKey MinClientVersion { get; private set; }

        public VocabularyKey Tags { get; private set; }

        public VocabularyKey CreatedTime { get; private set; }

        public VocabularyKey AppOpenUri { get; private set; }

        public VocabularyKey IsCdsUpgraded { get; private set; }

        public VocabularyKey GalleryItemId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey AADLastModifiedById { get; private set; }

        public VocabularyKey AADLastPublishedById { get; private set; }

        public VocabularyKey DisplayName { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey CommitMessage { get; private set; }

        public VocabularyKey Publisher { get; private set; }

        public VocabularyKey LastModifiedTime { get; private set; }

        public VocabularyKey LastPublishTime { get; private set; }

        public VocabularyKey ConnectionReferences { get; private set; }

        public VocabularyKey IsFeaturedApp { get; private set; }

        public VocabularyKey BypassConsent { get; private set; }

        public VocabularyKey AdminControlBypassConsent { get; private set; }

        public VocabularyKey IsHeroApp { get; private set; }

        public VocabularyKey IsHidden { get; private set; }

        public VocabularyKey CanvasAppId { get; private set; }

        public VocabularyKey BackgroundColor { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey IsCdsUpgradedName { get; private set; }

        public VocabularyKey IsFeaturedAppName { get; private set; }

        public VocabularyKey BypassConsentName { get; private set; }

        public VocabularyKey AdminControlBypassConsentName { get; private set; }

        public VocabularyKey IsHeroAppName { get; private set; }

        public VocabularyKey IsHiddenName { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwningBusinessUnitName { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey AADCreatedById { get; private set; }

        public VocabularyKey AuthorizationReferences { get; private set; }

        public VocabularyKey EmbeddedApp { get; private set; }

        public VocabularyKey CdsDependencies { get; private set; }

        public VocabularyKey DatabaseReferences { get; private set; }


    }
}

