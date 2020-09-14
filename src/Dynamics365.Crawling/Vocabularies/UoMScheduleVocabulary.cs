using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class UoMScheduleVocabulary : SimpleVocabulary
        {
            public UoMScheduleVocabulary()
            {
                VocabularyName = "Dynamics365 UoMSchedule";
                KeyPrefix = "dynamics365.uomschedule";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("UoMSchedule", group =>
                {
                    this.UoMScheduleId = group.Add(new VocabularyKey("UoMScheduleId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier for the unit group.")
                        .WithDisplayName("Unit Group")
                        .ModelProperty("uomscheduleid", typeof(Guid)));
                    
                    this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"organization_uof_schedules")
                        .WithDisplayName("Organization")
                        .ModelProperty("organizationid", typeof(string)));
                    
                    this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                        .WithDescription(@"Name of the unit group.")
                        .WithDisplayName("Name")
                        .ModelProperty("name", typeof(string)));
                    
                    this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                        .WithDescription(@"Description of the unit group.")
                        .WithDisplayName("Description")
                        .ModelProperty("description", typeof(string)));
                    
                    this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the unit group was created.")
                        .WithDisplayName("Created On")
                        .ModelProperty("createdon", typeof(DateTime)));
                    
                    this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"lk_uomschedulebase_createdby")
                        .WithDisplayName("Created By")
                        .ModelProperty("createdby", typeof(string)));
                    
                    this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the unit group was last modified.")
                        .WithDisplayName("Modified On")
                        .ModelProperty("modifiedon", typeof(DateTime)));
                    
                    this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"lk_uomschedulebase_modifiedby")
                        .WithDisplayName("Modified By")
                        .ModelProperty("modifiedby", typeof(string)));
                    
                    this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Version number of the unit group.")
                        .WithDisplayName("Version Number")
                        .ModelProperty("versionnumber", typeof(int)));
                    
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
                    
                    this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("OrganizationIdName")
                        .ModelProperty("organizationidname", typeof(string)));
                    
                    this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                        .WithDisplayName("Import Sequence Number")
                        .ModelProperty("importsequencenumber", typeof(long)));
                    
                    this.BaseUoMName = group.Add(new VocabularyKey("BaseUoMName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"Name of the base unit.")
                        .WithDisplayName("Base Unit name")
                        .ModelProperty("baseuomname", typeof(string)));
                    
                    this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time that the record was migrated.")
                        .WithDisplayName("Record Created On")
                        .ModelProperty("overriddencreatedon", typeof(DateTime)));
                    
                    this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByYomiName")
                        .ModelProperty("modifiedbyyominame", typeof(string)));
                    
                    this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("CreatedByYomiName")
                        .ModelProperty("createdbyyominame", typeof(string)));
                    
                    this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"lk_uomschedulebase_createdonbehalfby")
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
                        .WithDescription(@"lk_uomschedulebase_modifiedonbehalfby")
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
                    
                    this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Status of the Unit Group.")
                        .WithDisplayName("Status")
                        .ModelProperty("statecode", typeof(string)));
                    
                    this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("StateCodeName")
                        .ModelProperty("statecodename", typeof(string)));
                    
                    this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Reason for the status of the Unit Group.")
                        .WithDisplayName("Status Reason")
                        .ModelProperty("statuscode", typeof(string)));
                    
                    this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("StatusCodeName")
                        .ModelProperty("statuscodename", typeof(string)));
                    
                    this.CreatedByExternalParty = group.Add(new VocabularyKey("CreatedByExternalParty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Shows the external party who created the record.")
                        .WithDisplayName("Created By (External Party)")
                        .ModelProperty("createdbyexternalparty", typeof(string)));
                    
                    this.CreatedByExternalPartyName = group.Add(new VocabularyKey("CreatedByExternalPartyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("CreatedByExternalPartyName")
                        .ModelProperty("createdbyexternalpartyname", typeof(string)));
                    
                    this.CreatedByExternalPartyYomiName = group.Add(new VocabularyKey("CreatedByExternalPartyYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("CreatedByExternalPartyYomiName")
                        .ModelProperty("createdbyexternalpartyyominame", typeof(string)));
                    
                    this.ModifiedByExternalParty = group.Add(new VocabularyKey("ModifiedByExternalParty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Shows the external party who modified the record.")
                        .WithDisplayName("Modified By (External Party)")
                        .ModelProperty("modifiedbyexternalparty", typeof(string)));
                    
                    this.ModifiedByExternalPartyName = group.Add(new VocabularyKey("ModifiedByExternalPartyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByExternalPartyName")
                        .ModelProperty("modifiedbyexternalpartyname", typeof(string)));
                    
                    this.ModifiedByExternalPartyYomiName = group.Add(new VocabularyKey("ModifiedByExternalPartyYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByExternalPartyYomiName")
                        .ModelProperty("modifiedbyexternalpartyyominame", typeof(string)));
                    
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

            public VocabularyKey UoMScheduleId { get; private set; }
        
        public VocabularyKey OrganizationId { get; private set; }
        
        public VocabularyKey Name { get; private set; }
        
        public VocabularyKey Description { get; private set; }
        
        public VocabularyKey CreatedOn { get; private set; }
        
        public VocabularyKey CreatedBy { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey ModifiedBy { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        public VocabularyKey CreatedByName { get; private set; }
        
        public VocabularyKey ModifiedByName { get; private set; }
        
        public VocabularyKey OrganizationIdName { get; private set; }
        
        public VocabularyKey ImportSequenceNumber { get; private set; }
        
        public VocabularyKey BaseUoMName { get; private set; }
        
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        
        public VocabularyKey ModifiedByYomiName { get; private set; }
        
        public VocabularyKey CreatedByYomiName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey StateCode { get; private set; }
        
        public VocabularyKey StateCodeName { get; private set; }
        
        public VocabularyKey StatusCode { get; private set; }
        
        public VocabularyKey StatusCodeName { get; private set; }
        
        public VocabularyKey CreatedByExternalParty { get; private set; }
        
        public VocabularyKey CreatedByExternalPartyName { get; private set; }
        
        public VocabularyKey CreatedByExternalPartyYomiName { get; private set; }
        
        public VocabularyKey ModifiedByExternalParty { get; private set; }
        
        public VocabularyKey ModifiedByExternalPartyName { get; private set; }
        
        public VocabularyKey ModifiedByExternalPartyYomiName { get; private set; }
        
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        
        
        }
    }
    
