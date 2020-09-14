using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class UserMappingVocabulary : SimpleVocabulary
        {
            public UserMappingVocabulary()
            {
                VocabularyName = "Dynamics365 UserMapping";
                KeyPrefix = "dynamics365.usermapping";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("UserMapping", group =>
                {
                    this.UserMappingId = group.Add(new VocabularyKey("UserMappingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier for entity instances")
                        .WithDisplayName("UserMapping")
                        .ModelProperty("usermappingid", typeof(Guid)));
                    
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
                    
                    this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the delegate user who created the record.")
                        .WithDisplayName("Created By (Delegate)")
                        .ModelProperty("createdonbehalfby", typeof(string)));
                    
                    this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the delegate user who modified the record.")
                        .WithDisplayName("Modified By (Delegate)")
                        .ModelProperty("modifiedonbehalfby", typeof(string)));
                    
                    this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("CreatedByName")
                        .ModelProperty("createdbyname", typeof(string)));
                    
                    this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("CreatedByYomiName")
                        .ModelProperty("createdbyyominame", typeof(string)));
                    
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
                    
                    this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByName")
                        .ModelProperty("modifiedbyname", typeof(string)));
                    
                    this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByYomiName")
                        .ModelProperty("modifiedbyyominame", typeof(string)));
                    
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
                    
                    this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier for the organization")
                        .WithDisplayName("Organization Id")
                        .ModelProperty("organizationid", typeof(string)));
                    
                    this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("OrganizationIdName")
                        .ModelProperty("organizationidname", typeof(string)));
                    
                    this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("VersionNumber")
                        .ModelProperty("versionnumber", typeof(int)));
                    
                    this.ClaimType = group.Add(new VocabularyKey("ClaimType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                        .WithDescription(@"The Claim Type")
                        .WithDisplayName("Claim Type")
                        .ModelProperty("claimtype", typeof(string)));
                    
                    this.SystemUserAttributeName = group.Add(new VocabularyKey("SystemUserAttributeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                        .WithDescription(@"The user attribute.")
                        .WithDisplayName("The System User Attribute")
                        .ModelProperty("systemuserattributename", typeof(string)));
                    
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
                    
                    this.PartnerApplicationType = group.Add(new VocabularyKey("PartnerApplicationType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"The partner application for which this claim mapping is to be used. (exchange or sharepoint)")
                        .WithDisplayName("Choose the Partner Application Type")
                        .ModelProperty("partnerapplicationtype", typeof(string)));
                    
                    this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Exchange rate for the currency associated with the UserMapping with respect to the base currency.")
                        .WithDisplayName("ExchangeRate")
                        .ModelProperty("exchangerate", typeof(decimal)));
                    
                    this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Exchange rate for the currency associated with the UserMapping with respect to the base currency.")
                        .WithDisplayName("Currency")
                        .ModelProperty("transactioncurrencyid", typeof(string)));
                    
                    this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("TransactionCurrencyIdName")
                        .ModelProperty("transactioncurrencyidname", typeof(string)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey UserMappingId { get; private set; }
        
        public VocabularyKey CreatedOn { get; private set; }
        
        public VocabularyKey CreatedBy { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey ModifiedBy { get; private set; }
        
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        
        public VocabularyKey CreatedByName { get; private set; }
        
        public VocabularyKey CreatedByYomiName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey ModifiedByName { get; private set; }
        
        public VocabularyKey ModifiedByYomiName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey OrganizationId { get; private set; }
        
        public VocabularyKey OrganizationIdName { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        public VocabularyKey ClaimType { get; private set; }
        
        public VocabularyKey SystemUserAttributeName { get; private set; }
        
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        
        public VocabularyKey PartnerApplicationType { get; private set; }
        
        public VocabularyKey ExchangeRate { get; private set; }
        
        public VocabularyKey TransactionCurrencyId { get; private set; }
        
        public VocabularyKey TransactionCurrencyIdName { get; private set; }
        
        
        }
    }
    
