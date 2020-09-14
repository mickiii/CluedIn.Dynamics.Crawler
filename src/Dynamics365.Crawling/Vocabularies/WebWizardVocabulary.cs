using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class WebWizardVocabulary : SimpleVocabulary
        {
            public WebWizardVocabulary()
            {
                VocabularyName = "Dynamics365 WebWizard";
                KeyPrefix = "dynamics365.webwizard";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("WebWizard", group =>
                {
                    this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the wizard definition was created.")
                        .WithDisplayName("Created On")
                        .ModelProperty("createdon", typeof(DateTime)));
                    
                    this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who created the wizard definition.")
                        .WithDisplayName("Created By")
                        .ModelProperty("createdby", typeof(string)));
                    
                    this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("VersionNumber")
                        .ModelProperty("versionnumber", typeof(int)));
                    
                    this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the organization.")
                        .WithDisplayName("Organization")
                        .ModelProperty("organizationid", typeof(string)));
                    
                    this.WebWizardId = group.Add(new VocabularyKey("WebWizardId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the wizard.")
                        .WithDisplayName("Web Wizard")
                        .ModelProperty("webwizardid", typeof(Guid)));
                    
                    this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                        .WithDescription(@"Name of the wizard")
                        .WithDisplayName("Name")
                        .ModelProperty("name", typeof(string)));
                    
                    this.WizardPageHeight = group.Add(new VocabularyKey("WizardPageHeight", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Window height for the wizard.")
                        .WithDisplayName("Page Height")
                        .ModelProperty("wizardpageheight", typeof(long)));
                    
                    this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who last modified the wizard definition.")
                        .WithDisplayName("Modified By")
                        .ModelProperty("modifiedby", typeof(string)));
                    
                    this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the wizard definition was last modified.")
                        .WithDisplayName("Modified On")
                        .ModelProperty("modifiedon", typeof(DateTime)));
                    
                    this.WizardPageWidth = group.Add(new VocabularyKey("WizardPageWidth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Window width for the wizard.")
                        .WithDisplayName("Page Width")
                        .ModelProperty("wizardpagewidth", typeof(long)));
                    
                    this.StartPageSequenceNumber = group.Add(new VocabularyKey("StartPageSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Sequence number of the first page of this wizard.")
                        .WithDisplayName("Start Page Sequence Number")
                        .ModelProperty("startpagesequencenumber", typeof(long)));
                    
                    this.AccessPrivileges = group.Add(new VocabularyKey("AccessPrivileges", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                        .WithDescription(@"Privileges required to use this wizard, separated with commas (,).")
                        .WithDisplayName("Access Privileges")
                        .ModelProperty("accessprivileges", typeof(string)));
                    
                    this.TitleResourceString = group.Add(new VocabularyKey("TitleResourceString", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                        .WithDescription(@"Title of the wizard.")
                        .WithDisplayName("Title")
                        .ModelProperty("titleresourcestring", typeof(string)));
                    
                    this.IsStaticPageSequence = group.Add(new VocabularyKey("IsStaticPageSequence", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information about whether all pages for this wizard are statically defined.")
                        .WithDisplayName("Is Static Page Sequence")
                        .ModelProperty("isstaticpagesequence", typeof(bool)));
                    
                    this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("CreatedByName")
                        .ModelProperty("createdbyname", typeof(string)));
                    
                    this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("OrganizationIdName")
                        .ModelProperty("organizationidname", typeof(string)));
                    
                    this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByName")
                        .ModelProperty("modifiedbyname", typeof(string)));
                    
                    this.IsStaticPageSequenceName = group.Add(new VocabularyKey("IsStaticPageSequenceName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("IsStaticPageSequenceName")
                        .ModelProperty("isstaticpagesequencename", typeof(string)));
                    
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
                    
                    this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the delegate user who created the webwizard.")
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
                        .WithDescription(@"Unique identifier of the delegate user who last modified the webwizard.")
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
                        .WithDescription(@"Information that specifies whether this component is managed.")
                        .WithDisplayName("State")
                        .ModelProperty("ismanaged", typeof(bool)));
                    
                    this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("IsManagedName")
                        .ModelProperty("ismanagedname", typeof(string)));
                    
                    this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                        .WithDescription(@"Version in which the component is introduced.")
                        .WithDisplayName("Introduced Version")
                        .ModelProperty("introducedversion", typeof(string)));
                    
                    this.WebWizardIdUnique = group.Add(new VocabularyKey("WebWizardIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the Web Wizard.")
                        .WithDisplayName("WebWizardIdUnique")
                        .ModelProperty("webwizardidunique", typeof(Guid)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey CreatedOn { get; private set; }
        
        public VocabularyKey CreatedBy { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        public VocabularyKey OrganizationId { get; private set; }
        
        public VocabularyKey WebWizardId { get; private set; }
        
        public VocabularyKey Name { get; private set; }
        
        public VocabularyKey WizardPageHeight { get; private set; }
        
        public VocabularyKey ModifiedBy { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey WizardPageWidth { get; private set; }
        
        public VocabularyKey StartPageSequenceNumber { get; private set; }
        
        public VocabularyKey AccessPrivileges { get; private set; }
        
        public VocabularyKey TitleResourceString { get; private set; }
        
        public VocabularyKey IsStaticPageSequence { get; private set; }
        
        public VocabularyKey CreatedByName { get; private set; }
        
        public VocabularyKey OrganizationIdName { get; private set; }
        
        public VocabularyKey ModifiedByName { get; private set; }
        
        public VocabularyKey IsStaticPageSequenceName { get; private set; }
        
        public VocabularyKey CreatedByYomiName { get; private set; }
        
        public VocabularyKey ModifiedByYomiName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey SolutionId { get; private set; }
        
        public VocabularyKey SupportingSolutionId { get; private set; }
        
        public VocabularyKey ComponentState { get; private set; }
        
        public VocabularyKey OverwriteTime { get; private set; }
        
        public VocabularyKey IsManaged { get; private set; }
        
        public VocabularyKey IsManagedName { get; private set; }
        
        public VocabularyKey IntroducedVersion { get; private set; }
        
        public VocabularyKey WebWizardIdUnique { get; private set; }
        
        
        }
    }
    
