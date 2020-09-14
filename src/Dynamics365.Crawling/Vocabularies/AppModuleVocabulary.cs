using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AppModuleVocabulary : SimpleVocabulary
    {
        public AppModuleVocabulary()
        {
            VocabularyName = "Dynamics365 AppModule";
            KeyPrefix = "dynamics365.appmodule";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("AppModule", group =>
            {
                this.AppModuleId = group.Add(new VocabularyKey("AppModuleId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("AppModuleId")
                    .ModelProperty("appmoduleid", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of App Module")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Description for entity")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.FormFactor = group.Add(new VocabularyKey("FormFactor", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Form Factor")
                    .WithDisplayName("Form Factor")
                    .ModelProperty("formfactor", typeof(long)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Version in which the similarity rule is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

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

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the record.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who modified the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the record.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Internal use only")
                    .WithDisplayName("Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Is Managed")
                    .WithDisplayName("IsManaged")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.AppModuleVersion = group.Add(new VocabularyKey("AppModuleVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(48))
                    .WithDescription(@"App Module Version")
                    .WithDisplayName("App Module Version")
                    .ModelProperty("appmoduleversion", typeof(string)));

                this.IsFeatured = group.Add(new VocabularyKey("IsFeatured", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Is Featured")
                    .WithDisplayName("IsFeatured")
                    .ModelProperty("isfeatured", typeof(bool)));

                this.PublisherId = group.Add(new VocabularyKey("PublisherId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the publisher.")
                    .WithDisplayName("Publisher")
                    .ModelProperty("publisherid", typeof(string)));

                this.PublisherIdName = group.Add(new VocabularyKey("PublisherIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"name of the publisher.")
                    .WithDisplayName("Publisher")
                    .ModelProperty("publisheridname", typeof(string)));

                this.IsDefault = group.Add(new VocabularyKey("IsDefault", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Is Default")
                    .WithDisplayName("Is Default")
                    .ModelProperty("isdefault", typeof(bool)));

                this.AppModuleXmlManaged = group.Add(new VocabularyKey("AppModuleXmlManaged", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"App Module Xml Managed")
                    .WithDisplayName("AppModuleXmlManaged")
                    .ModelProperty("appmodulexmlmanaged", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the app.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.PublishedOn = group.Add(new VocabularyKey("PublishedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Date and time when the record was published.")
                    .WithDisplayName("Published On")
                    .ModelProperty("publishedon", typeof(DateTime)));

                this.URL = group.Add(new VocabularyKey("URL", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Contains URL")
                    .WithDisplayName("URL")
                    .ModelProperty("url", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.AppModuleIdUnique = group.Add(new VocabularyKey("AppModuleIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the App Module used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook")
                    .WithDisplayName("App Module Unique Id")
                    .ModelProperty("appmoduleidunique", typeof(Guid)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.WebResourceId = group.Add(new VocabularyKey("WebResourceId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the Web Resource")
                    .WithDisplayName("Web Resource Id")
                    .ModelProperty("webresourceid", typeof(Guid)));

                this.ConfigXML = group.Add(new VocabularyKey("ConfigXML", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Contains configuration XML")
                    .WithDisplayName("ConfigXML")
                    .ModelProperty("configxml", typeof(string)));

                this.ClientType = group.Add(new VocabularyKey("ClientType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Client Type such as Web or UCI")
                    .WithDisplayName("Client Type")
                    .ModelProperty("clienttype", typeof(long)));

                this.UniqueName = group.Add(new VocabularyKey("UniqueName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Unique Name of App Module")
                    .WithDisplayName("Unique Name")
                    .ModelProperty("uniquename", typeof(string)));

                this.WelcomePageId = group.Add(new VocabularyKey("WelcomePageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the Web Resource as Welcome Page Id")
                    .WithDisplayName("Welcome Page Id")
                    .ModelProperty("welcomepageid", typeof(Guid)));

                this.Descriptor = group.Add(new VocabularyKey("Descriptor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"App Module Descriptor")
                    .WithDisplayName("Descriptor")
                    .ModelProperty("descriptor", typeof(string)));

                this.EventHandlers = group.Add(new VocabularyKey("EventHandlers", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"App Module Event Handlers")
                    .WithDisplayName("Event Handlers")
                    .ModelProperty("eventhandlers", typeof(string)));

                this.NavigationType = group.Add(new VocabularyKey("NavigationType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"App navigation type")
                    .WithDisplayName("Navigation type")
                    .ModelProperty("navigationtype", typeof(string)));

                this.OptimizedFor = group.Add(new VocabularyKey("OptimizedFor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"The client that this app is optimized for")
                    .WithDisplayName("Optimized Client")
                    .ModelProperty("optimizedfor", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey AppModuleId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey FormFactor { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey AppModuleVersion { get; private set; }

        public VocabularyKey IsFeatured { get; private set; }

        public VocabularyKey PublisherId { get; private set; }

        public VocabularyKey PublisherIdName { get; private set; }

        public VocabularyKey IsDefault { get; private set; }

        public VocabularyKey AppModuleXmlManaged { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey PublishedOn { get; private set; }

        public VocabularyKey URL { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey AppModuleIdUnique { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey WebResourceId { get; private set; }

        public VocabularyKey ConfigXML { get; private set; }

        public VocabularyKey ClientType { get; private set; }

        public VocabularyKey UniqueName { get; private set; }

        public VocabularyKey WelcomePageId { get; private set; }

        public VocabularyKey Descriptor { get; private set; }

        public VocabularyKey EventHandlers { get; private set; }

        public VocabularyKey NavigationType { get; private set; }

        public VocabularyKey OptimizedFor { get; private set; }


    }
}

