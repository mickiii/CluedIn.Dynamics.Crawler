using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class WebResourceVocabulary : SimpleVocabulary
        {
            public WebResourceVocabulary()
            {
                VocabularyName = "Dynamics365 WebResource";
                KeyPrefix = "dynamics365.webresource";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("WebResource", group =>
                {
                    this.WebResourceId = group.Add(new VocabularyKey("WebResourceId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the web resource.")
                        .WithDisplayName("Web Resource Identifier")
                        .ModelProperty("webresourceid", typeof(Guid)));
                    
                    this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                        .WithDescription(@"Name of the web resource.")
                        .WithDisplayName("Name")
                        .ModelProperty("name", typeof(string)));
                    
                    this.DisplayName = group.Add(new VocabularyKey("DisplayName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                        .WithDescription(@"Display name of the web resource.")
                        .WithDisplayName("Display Name")
                        .ModelProperty("displayname", typeof(string)));
                    
                    this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                        .WithDescription(@"Description of the web resource.")
                        .WithDisplayName("Description")
                        .ModelProperty("description", typeof(string)));
                    
                    this.Content = group.Add(new VocabularyKey("Content", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Bytes of the web resource, in Base64 format.")
                        .WithDisplayName("Content")
                        .ModelProperty("content", typeof(string)));
                    
                    this.SilverlightVersion = group.Add(new VocabularyKey("SilverlightVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                        .WithDescription(@"Silverlight runtime version number required by a silverlight web resource.")
                        .WithDisplayName("Silverlight Version")
                        .ModelProperty("silverlightversion", typeof(string)));
                    
                    this.WebResourceType = group.Add(new VocabularyKey("WebResourceType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Drop-down list for selecting the type of the web resource.")
                        .WithDisplayName("Type")
                        .ModelProperty("webresourcetype", typeof(string)));
                    
                    this.WebResourceTypeName = group.Add(new VocabularyKey("WebResourceTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("WebResourceTypeName")
                        .ModelProperty("webresourcetypename", typeof(string)));
                    
                    this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the organization associated with the web resource.")
                        .WithDisplayName("Organization")
                        .ModelProperty("organizationid", typeof(string)));
                    
                    this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("OrganizationIdName")
                        .ModelProperty("organizationidname", typeof(string)));
                    
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
                    
                    this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("Record Overwrite Time")
                        .ModelProperty("overwritetime", typeof(DateTime)));
                    
                    this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("Component State")
                        .ModelProperty("componentstate", typeof(string)));
                    
                    this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("VersionNumber")
                        .ModelProperty("versionnumber", typeof(int)));
                    
                    this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the web resource was last modified.")
                        .WithDisplayName("Modified On")
                        .ModelProperty("modifiedon", typeof(DateTime)));
                    
                    this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who last modified the web resource.")
                        .WithDisplayName("Modified By")
                        .ModelProperty("modifiedby", typeof(string)));
                    
                    this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the web resource was created.")
                        .WithDisplayName("Created On")
                        .ModelProperty("createdon", typeof(DateTime)));
                    
                    this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who created the web resource.")
                        .WithDisplayName("Created By")
                        .ModelProperty("createdby", typeof(string)));
                    
                    this.WebResourceIdUnique = group.Add(new VocabularyKey("WebResourceIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("WebResourceIdUnique")
                        .ModelProperty("webresourceidunique", typeof(Guid)));
                    
                    this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the delegate user who modified the web resource.")
                        .WithDisplayName("Created By (Delegate)")
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
                    
                    this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the delegate user who created the web resource.")
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
                    
                    this.LanguageCode = group.Add(new VocabularyKey("LanguageCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Language of the web resource.")
                        .WithDisplayName("Language")
                        .ModelProperty("languagecode", typeof(long)));
                    
                    this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("IsManaged")
                        .ModelProperty("ismanaged", typeof(bool)));
                    
                    this.IsCustomizable = group.Add(new VocabularyKey("IsCustomizable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies whether this component can be customized.")
                        .WithDisplayName("Customizable")
                        .ModelProperty("iscustomizable", typeof(string)));
                    
                    this.CanBeDeleted = group.Add(new VocabularyKey("CanBeDeleted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies whether this component can be deleted.")
                        .WithDisplayName("Can Be Deleted")
                        .ModelProperty("canbedeleted", typeof(string)));
                    
                    this.IsHidden = group.Add(new VocabularyKey("IsHidden", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies whether this component should be hidden.")
                        .WithDisplayName("Hidden")
                        .ModelProperty("ishidden", typeof(string)));
                    
                    this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("IsManagedName")
                        .ModelProperty("ismanagedname", typeof(string)));
                    
                    this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                        .WithDescription(@"Version in which the form is introduced.")
                        .WithDisplayName("Introduced Version")
                        .ModelProperty("introducedversion", typeof(string)));
                    
                    this.IsEnabledForMobileClient = group.Add(new VocabularyKey("IsEnabledForMobileClient", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies whether this web resource is enabled for mobile client.")
                        .WithDisplayName("Is Enabled For Mobile Client")
                        .ModelProperty("isenabledformobileclient", typeof(bool)));
                    
                    this.DependencyXml = group.Add(new VocabularyKey("DependencyXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(5000))
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("DependencyXML")
                        .ModelProperty("dependencyxml", typeof(string)));
                    
                    this.IsAvailableForMobileOffline = group.Add(new VocabularyKey("IsAvailableForMobileOffline", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies whether this web resource is available for mobile client in offline mode.")
                        .WithDisplayName("Is Available For Mobile Offline")
                        .ModelProperty("isavailableformobileoffline", typeof(bool)));
                    
                    this.ContentJson = group.Add(new VocabularyKey("ContentJson", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Json representation of the content of the resource.")
                        .WithDisplayName("ContentJson")
                        .ModelProperty("contentjson", typeof(string)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey WebResourceId { get; private set; }
        
        public VocabularyKey Name { get; private set; }
        
        public VocabularyKey DisplayName { get; private set; }
        
        public VocabularyKey Description { get; private set; }
        
        public VocabularyKey Content { get; private set; }
        
        public VocabularyKey SilverlightVersion { get; private set; }
        
        public VocabularyKey WebResourceType { get; private set; }
        
        public VocabularyKey WebResourceTypeName { get; private set; }
        
        public VocabularyKey OrganizationId { get; private set; }
        
        public VocabularyKey OrganizationIdName { get; private set; }
        
        public VocabularyKey SolutionId { get; private set; }
        
        public VocabularyKey SupportingSolutionId { get; private set; }
        
        public VocabularyKey OverwriteTime { get; private set; }
        
        public VocabularyKey ComponentState { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey ModifiedBy { get; private set; }
        
        public VocabularyKey CreatedOn { get; private set; }
        
        public VocabularyKey CreatedBy { get; private set; }
        
        public VocabularyKey WebResourceIdUnique { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey LanguageCode { get; private set; }
        
        public VocabularyKey IsManaged { get; private set; }
        
        public VocabularyKey IsCustomizable { get; private set; }
        
        public VocabularyKey CanBeDeleted { get; private set; }
        
        public VocabularyKey IsHidden { get; private set; }
        
        public VocabularyKey IsManagedName { get; private set; }
        
        public VocabularyKey IntroducedVersion { get; private set; }
        
        public VocabularyKey IsEnabledForMobileClient { get; private set; }
        
        public VocabularyKey DependencyXml { get; private set; }
        
        public VocabularyKey IsAvailableForMobileOffline { get; private set; }
        
        public VocabularyKey ContentJson { get; private set; }
        
        
        }
    }
    
