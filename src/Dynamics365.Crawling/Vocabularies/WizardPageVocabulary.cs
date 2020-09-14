using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class WizardPageVocabulary : SimpleVocabulary
        {
            public WizardPageVocabulary()
            {
                VocabularyName = "Dynamics365 WizardPage";
                KeyPrefix = "dynamics365.wizardpage";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("WizardPage", group =>
                {
                    this.PageSequenceNumber = group.Add(new VocabularyKey("PageSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Sequence number of the wizard page.")
                        .WithDisplayName("Page Sequence Number")
                        .ModelProperty("pagesequencenumber", typeof(long)));
                    
                    this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who last modified the wizard page.")
                        .WithDisplayName("Modified By")
                        .ModelProperty("modifiedby", typeof(string)));
                    
                    this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the wizard page was last modified.")
                        .WithDisplayName("Modified On")
                        .ModelProperty("modifiedon", typeof(DateTime)));
                    
                    this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("VersionNumber")
                        .ModelProperty("versionnumber", typeof(int)));
                    
                    this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who created the wizard page.")
                        .WithDisplayName("Created By")
                        .ModelProperty("createdby", typeof(string)));
                    
                    this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the organization.")
                        .WithDisplayName("Organization")
                        .ModelProperty("organizationid", typeof(string)));
                    
                    this.PageUrl = group.Add(new VocabularyKey("PageUrl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(512))
                        .WithDescription(@"URL for the wizard page.")
                        .WithDisplayName("Page URL")
                        .ModelProperty("pageurl", typeof(string)));
                    
                    this.WebWizardId = group.Add(new VocabularyKey("WebWizardId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the wizard associated with this wizard page.")
                        .WithDisplayName("Wizard ID")
                        .ModelProperty("webwizardid", typeof(string)));
                    
                    this.WizardPageId = group.Add(new VocabularyKey("WizardPageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the wizard page.")
                        .WithDisplayName("Wizard Page")
                        .ModelProperty("wizardpageid", typeof(Guid)));
                    
                    this.PageDataToPost = group.Add(new VocabularyKey("PageDataToPost", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1024))
                        .WithDescription(@"Data to post to the wizard page when requesting the page.")
                        .WithDisplayName("Data To Post")
                        .ModelProperty("pagedatatopost", typeof(string)));
                    
                    this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the wizard page was created.")
                        .WithDisplayName("Created On")
                        .ModelProperty("createdon", typeof(DateTime)));
                    
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
                        .WithDescription(@"Unique identifier of the delegate user who created the wizardpage.")
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
                        .WithDescription(@"Unique identifier of the delegate user who last modified the wizardpage.")
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

            public VocabularyKey PageSequenceNumber { get; private set; }
        
        public VocabularyKey ModifiedBy { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        public VocabularyKey CreatedBy { get; private set; }
        
        public VocabularyKey OrganizationId { get; private set; }
        
        public VocabularyKey PageUrl { get; private set; }
        
        public VocabularyKey WebWizardId { get; private set; }
        
        public VocabularyKey WizardPageId { get; private set; }
        
        public VocabularyKey PageDataToPost { get; private set; }
        
        public VocabularyKey CreatedOn { get; private set; }
        
        public VocabularyKey CreatedByName { get; private set; }
        
        public VocabularyKey OrganizationIdName { get; private set; }
        
        public VocabularyKey ModifiedByName { get; private set; }
        
        public VocabularyKey CreatedByYomiName { get; private set; }
        
        public VocabularyKey ModifiedByYomiName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }
        
        
        }
    }
    
