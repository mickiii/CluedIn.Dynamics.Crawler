using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class UntrackedEmailVocabulary : SimpleVocabulary
        {
            public UntrackedEmailVocabulary()
            {
                VocabularyName = "Dynamics365 UntrackedEmail";
                KeyPrefix = "dynamics365.untrackedemail";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("UntrackedEmail", group =>
                {
                    this.ActivityId = group.Add(new VocabularyKey("ActivityId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of untracked the email activity.")
                        .WithDisplayName("Untracked Email Message")
                        .ModelProperty("activityid", typeof(Guid)));
                    
                    this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the activity was created.")
                        .WithDisplayName("Created Date")
                        .ModelProperty("createdon", typeof(DateTime)));
                    
                    this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the delegate user who created the activitypointer.")
                        .WithDisplayName("Created By (Delegate)")
                        .ModelProperty("createdonbehalfby", typeof(string)));
                    
                    this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Version number of the untracked email message.")
                        .WithDisplayName("Version Number")
                        .ModelProperty("versionnumber", typeof(int)));
                    
                    this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                        .WithDescription(@"Shows information about the untracked email. This field is read-only.")
                        .WithDisplayName("Post Description")
                        .ModelProperty("description", typeof(string)));
                    
                    this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Shows who last updated the record.")
                        .WithDisplayName("Modified By")
                        .ModelProperty("modifiedby", typeof(string)));
                    
                    this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the business unit that owns the untracked email activity.")
                        .WithDisplayName("Owning Business Unit")
                        .ModelProperty("owningbusinessunit", typeof(string)));
                    
                    this.Subject = group.Add(new VocabularyKey("Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                        .WithDescription(@"Type a short description about the objective or primary topic of the UntrackedEmail.")
                        .WithDisplayName("Subject")
                        .ModelProperty("subject", typeof(string)));
                    
                    this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Dynamics 365 options.")
                        .WithDisplayName("Modified On")
                        .ModelProperty("modifiedon", typeof(DateTime)));
                    
                    this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.")
                        .WithDisplayName("Owner")
                        .ModelProperty("ownerid", typeof(string)));
                    
                    this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who owns the untracked email activity.")
                        .WithDisplayName("Owning User")
                        .ModelProperty("owninguser", typeof(string)));
                    
                    this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("CreatedByName")
                        .ModelProperty("createdbyname", typeof(string)));
                    
                    this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"")
                        .WithDisplayName("OwnerIdType")
                        .ModelProperty("owneridtype", typeof(string)));
                    
                    this.ModifiedByDsc = group.Add(new VocabularyKey("ModifiedByDsc", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByDsc")
                        .ModelProperty("modifiedbydsc", typeof(long)));
                    
                    this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("OwnerIdName")
                        .ModelProperty("owneridname", typeof(string)));
                    
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
                    
                    this.ExchangeWebLink = group.Add(new VocabularyKey("ExchangeWebLink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                        .WithDescription(@"Shows the web link of untracked email.")
                        .WithDisplayName("Exchange WebLink")
                        .ModelProperty("exchangeweblink", typeof(string)));
                    
                    this.ExchangeItemId = group.Add(new VocabularyKey("ExchangeItemId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                        .WithDescription(@"The message id of untracked email which is returned from Exchange Server.")
                        .WithDisplayName("Exchange Item ID")
                        .ModelProperty("exchangeitemid", typeof(string)));
                    
                    this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("CreatedOnBehalfByYomiName")
                        .ModelProperty("createdonbehalfbyyominame", typeof(string)));
                    
                    this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByYomiName")
                        .ModelProperty("modifiedbyyominame", typeof(string)));
                    
                    this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Choose the record that the untracked email relates to.")
                        .WithDisplayName("Regarding")
                        .ModelProperty("regardingobjectid", typeof(string)));
                    
                    this.RegardingObjectIdDsc = group.Add(new VocabularyKey("RegardingObjectIdDsc", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("RegardingObjectIdDsc")
                        .ModelProperty("regardingobjectiddsc", typeof(long)));
                    
                    this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                        .WithDescription(@"")
                        .WithDisplayName("RegardingObjectIdName")
                        .ModelProperty("regardingobjectidname", typeof(string)));
                    
                    this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"")
                        .WithDisplayName("RegardingObjectTypeCode")
                        .ModelProperty("regardingobjecttypecode", typeof(string)));
                    
                    this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Shows who last updated the record on behalf of another user.")
                        .WithDisplayName("Modified By (Delegate)")
                        .ModelProperty("modifiedonbehalfby", typeof(string)));
                    
                    this.ModifiedOnBehalfByDsc = group.Add(new VocabularyKey("ModifiedOnBehalfByDsc", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedOnBehalfByDsc")
                        .ModelProperty("modifiedonbehalfbydsc", typeof(long)));
                    
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
                    
                    this.ActivityTypeCode = group.Add(new VocabularyKey("ActivityTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Shows the type of activity.")
                        .WithDisplayName("Activity Type")
                        .ModelProperty("activitytypecode", typeof(string)));
                    
                    this.ActivityTypeCodeName = group.Add(new VocabularyKey("ActivityTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("ActivityTypeCodeName")
                        .ModelProperty("activitytypecodename", typeof(string)));
                    
                    this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who created the activity.")
                        .WithDisplayName("Created By")
                        .ModelProperty("createdby", typeof(string)));
                    
                    this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the team who owns the untracked email activity.")
                        .WithDisplayName("Owning Team")
                        .ModelProperty("owningteam", typeof(string)));
                    
                    this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Choose the local currency for the record to make sure budgets are reported in the correct currency.")
                        .WithDisplayName("Currency")
                        .ModelProperty("transactioncurrencyid", typeof(string)));
                    
                    this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("TransactionCurrencyIdName")
                        .ModelProperty("transactioncurrencyidname", typeof(string)));
                    
                    this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.")
                        .WithDisplayName("Exchange Rate")
                        .ModelProperty("exchangerate", typeof(decimal)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey ActivityId { get; private set; }
        
        public VocabularyKey CreatedOn { get; private set; }
        
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        public VocabularyKey Description { get; private set; }
        
        public VocabularyKey ModifiedBy { get; private set; }
        
        public VocabularyKey OwningBusinessUnit { get; private set; }
        
        public VocabularyKey Subject { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey OwnerId { get; private set; }
        
        public VocabularyKey OwningUser { get; private set; }
        
        public VocabularyKey CreatedByName { get; private set; }
        
        public VocabularyKey OwnerIdType { get; private set; }
        
        public VocabularyKey ModifiedByDsc { get; private set; }
        
        public VocabularyKey OwnerIdName { get; private set; }
        
        public VocabularyKey ModifiedByName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByName { get; private set; }
        
        public VocabularyKey ExchangeWebLink { get; private set; }
        
        public VocabularyKey ExchangeItemId { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey ModifiedByYomiName { get; private set; }
        
        public VocabularyKey RegardingObjectId { get; private set; }
        
        public VocabularyKey RegardingObjectIdDsc { get; private set; }
        
        public VocabularyKey RegardingObjectIdName { get; private set; }
        
        public VocabularyKey RegardingObjectTypeCode { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByDsc { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey ActivityTypeCode { get; private set; }
        
        public VocabularyKey ActivityTypeCodeName { get; private set; }
        
        public VocabularyKey CreatedBy { get; private set; }
        
        public VocabularyKey OwningTeam { get; private set; }
        
        public VocabularyKey TransactionCurrencyId { get; private set; }
        
        public VocabularyKey TransactionCurrencyIdName { get; private set; }
        
        public VocabularyKey ExchangeRate { get; private set; }
        
        
        }
    }
    
