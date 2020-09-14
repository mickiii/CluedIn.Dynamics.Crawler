using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class UserEntityUISettingsVocabulary : SimpleVocabulary
        {
            public UserEntityUISettingsVocabulary()
            {
                VocabularyName = "Dynamics365 UserEntityUISettings";
                KeyPrefix = "dynamics365.userentityuisettings";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("UserEntityUISettings", group =>
                {
                    this.UserEntityUISettingsId = group.Add(new VocabularyKey("UserEntityUISettingsId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier user entity")
                        .WithDisplayName("UserEntityUISettingsId")
                        .ModelProperty("userentityuisettingsid", typeof(Guid)));
                    
                    this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user or team who owns the settings.")
                        .WithDisplayName("Owner")
                        .ModelProperty("ownerid", typeof(string)));
                    
                    this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who owns this saved view.")
                        .WithDisplayName("Owning User")
                        .ModelProperty("owninguser", typeof(string)));
                    
                    this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Object Type Code")
                        .WithDisplayName("ObjectTypeCode")
                        .ModelProperty("objecttypecode", typeof(long)));
                    
                    this.TabOrderXml = group.Add(new VocabularyKey("TabOrderXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Describes the tab ordering for this entity")
                        .WithDisplayName("Tab Order Xml")
                        .ModelProperty("taborderxml", typeof(string)));
                    
                    this.ReadingPaneXml = group.Add(new VocabularyKey("ReadingPaneXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Describes the reading pane formatting of this entity")
                        .WithDisplayName("Conditional formatting")
                        .ModelProperty("readingpanexml", typeof(string)));
                    
                    this.MRUXml = group.Add(new VocabularyKey("MRUXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Describes which tabs are most recently used for this entity")
                        .WithDisplayName("Most Recently Used Xml")
                        .ModelProperty("mruxml", typeof(string)));
                    
                    this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"Name of the owner of the saved view.")
                        .WithDisplayName("OwnerIdName")
                        .ModelProperty("owneridname", typeof(string)));
                    
                    this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Type of the owner of the saved view, such as user, team, or business unit.")
                        .WithDisplayName("OwnerIdType")
                        .ModelProperty("owneridtype", typeof(string)));
                    
                    this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("OwnerIdYomiName")
                        .ModelProperty("owneridyominame", typeof(string)));
                    
                    this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("VersionNumber")
                        .ModelProperty("versionnumber", typeof(int)));
                    
                    this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the business unit that owns this.")
                        .WithDisplayName("Owning Business Unit")
                        .ModelProperty("owningbusinessunit", typeof(string)));
                    
                    this.InsertIntoEmailMRUXml = group.Add(new VocabularyKey("InsertIntoEmailMRUXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Describes which entities are most recently inserted into email for this entity")
                        .WithDisplayName("Most Recently Inserted Into Email Xml")
                        .ModelProperty("insertintoemailmruxml", typeof(string)));
                    
                    this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the team who owns this saved view.")
                        .WithDisplayName("Owning Team")
                        .ModelProperty("owningteam", typeof(string)));
                    
                    this.RecentlyViewedXml = group.Add(new VocabularyKey("RecentlyViewedXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Describes which objects are most recently viewed for this entity")
                        .WithDisplayName("Most Recently Viewed Objects")
                        .ModelProperty("recentlyviewedxml", typeof(string)));
                    
                    this.LastViewedFormXml = group.Add(new VocabularyKey("LastViewedFormXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Describes which forms are most recently viewed for this entity.")
                        .WithDisplayName("Last Viewed Form Xml")
                        .ModelProperty("lastviewedformxml", typeof(string)));
                    
                    this.ShowInAddressBook = group.Add(new VocabularyKey("ShowInAddressBook", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Determines whether a record type is exposed in the Outlook Address Book")
                        .WithDisplayName("Show In Address Book")
                        .ModelProperty("showinaddressbook", typeof(bool)));
                    
                    this.LookupMRUXml = group.Add(new VocabularyKey("LookupMRUXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"List of most recently used lookup references for this entity")
                        .WithDisplayName("Most Recently Used Xml")
                        .ModelProperty("lookupmruxml", typeof(string)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey UserEntityUISettingsId { get; private set; }
        
        public VocabularyKey OwnerId { get; private set; }
        
        public VocabularyKey OwningUser { get; private set; }
        
        public VocabularyKey ObjectTypeCode { get; private set; }
        
        public VocabularyKey TabOrderXml { get; private set; }
        
        public VocabularyKey ReadingPaneXml { get; private set; }
        
        public VocabularyKey MRUXml { get; private set; }
        
        public VocabularyKey OwnerIdName { get; private set; }
        
        public VocabularyKey OwnerIdType { get; private set; }
        
        public VocabularyKey OwnerIdYomiName { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        public VocabularyKey OwningBusinessUnit { get; private set; }
        
        public VocabularyKey InsertIntoEmailMRUXml { get; private set; }
        
        public VocabularyKey OwningTeam { get; private set; }
        
        public VocabularyKey RecentlyViewedXml { get; private set; }
        
        public VocabularyKey LastViewedFormXml { get; private set; }
        
        public VocabularyKey ShowInAddressBook { get; private set; }
        
        public VocabularyKey LookupMRUXml { get; private set; }
        
        
        }
    }
    
