using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class UserEntityInstanceDataVocabulary : SimpleVocabulary
        {
            public UserEntityInstanceDataVocabulary()
            {
                VocabularyName = "Dynamics365 UserEntityInstanceData";
                KeyPrefix = "dynamics365.userentityinstancedata";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("UserEntityInstanceData", group =>
                {
                    this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who owns this object.")
                        .WithDisplayName("Owning User")
                        .ModelProperty("owninguser", typeof(string)));
                    
                    this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user or team who owns the user entity instance data.")
                        .WithDisplayName("Owner")
                        .ModelProperty("ownerid", typeof(string)));
                    
                    this.UserEntityInstanceDataId = group.Add(new VocabularyKey("UserEntityInstanceDataId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier user entity")
                        .WithDisplayName("UserEntityInstanceDataId")
                        .ModelProperty("userentityinstancedataid", typeof(Guid)));
                    
                    this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"Name of the owner of the object.")
                        .WithDisplayName("OwnerIdName")
                        .ModelProperty("owneridname", typeof(string)));
                    
                    this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Type of the owner of the object.")
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
                    
                    this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Object Type Code")
                        .WithDisplayName("ObjectTypeCode")
                        .ModelProperty("objecttypecode", typeof(long)));
                    
                    this.ReminderTime = group.Add(new VocabularyKey("ReminderTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Reminder time")
                        .WithDisplayName("Reminder time")
                        .ModelProperty("remindertime", typeof(DateTime)));
                    
                    this.StartTime = group.Add(new VocabularyKey("StartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Start Time")
                        .WithDisplayName("Start Time")
                        .ModelProperty("starttime", typeof(DateTime)));
                    
                    this.DueDate = group.Add(new VocabularyKey("DueDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Due Date")
                        .WithDisplayName("Due Date")
                        .ModelProperty("duedate", typeof(DateTime)));
                    
                    this.FlagDueBy = group.Add(new VocabularyKey("FlagDueBy", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Flag due by")
                        .WithDisplayName("Flag due by")
                        .ModelProperty("flagdueby", typeof(DateTime)));
                    
                    this.CommonStart = group.Add(new VocabularyKey("CommonStart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Common start date")
                        .WithDisplayName("Common start date")
                        .ModelProperty("commonstart", typeof(DateTime)));
                    
                    this.CommonEnd = group.Add(new VocabularyKey("CommonEnd", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Common end date")
                        .WithDisplayName("Common end date")
                        .ModelProperty("commonend", typeof(DateTime)));
                    
                    this.ToDoOrdinalDate = group.Add(new VocabularyKey("ToDoOrdinalDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("To Do Primary Sort Date")
                        .ModelProperty("todoordinaldate", typeof(DateTime)));
                    
                    this.ReminderSet = group.Add(new VocabularyKey("ReminderSet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether a reminder is set on this object.")
                        .WithDisplayName("Is Reminder set")
                        .ModelProperty("reminderset", typeof(bool)));
                    
                    this.FlagRequest = group.Add(new VocabularyKey("FlagRequest", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                        .WithDescription(@"Flag request")
                        .WithDisplayName("Flag Request")
                        .ModelProperty("flagrequest", typeof(string)));
                    
                    this.ToDoSubOrdinal = group.Add(new VocabularyKey("ToDoSubOrdinal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("To Do Sort Tie Breaker")
                        .ModelProperty("todosubordinal", typeof(string)));
                    
                    this.ToDoTitle = group.Add(new VocabularyKey("ToDoTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4000))
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("To Do Title")
                        .ModelProperty("todotitle", typeof(string)));
                    
                    this.PersonalCategories = group.Add(new VocabularyKey("PersonalCategories", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                        .WithDescription(@"Personal categories")
                        .WithDisplayName("personal categories")
                        .ModelProperty("personalcategories", typeof(string)));
                    
                    this.ObjectId = group.Add(new VocabularyKey("ObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the source record.")
                        .WithDisplayName("Object Id")
                        .ModelProperty("objectid", typeof(string)));
                    
                    this.FlagStatus = group.Add(new VocabularyKey("FlagStatus", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Flag status.")
                        .WithDisplayName("FlagStatus")
                        .ModelProperty("flagstatus", typeof(long)));
                    
                    this.ToDoItemFlags = group.Add(new VocabularyKey("ToDoItemFlags", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"To Do item flags.")
                        .WithDisplayName("ToDoItemFlags")
                        .ModelProperty("todoitemflags", typeof(long)));
                    
                    this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the team who owns this object.")
                        .WithDisplayName("Owning Team")
                        .ModelProperty("owningteam", typeof(string)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey OwningUser { get; private set; }
        
        public VocabularyKey OwnerId { get; private set; }
        
        public VocabularyKey UserEntityInstanceDataId { get; private set; }
        
        public VocabularyKey OwnerIdName { get; private set; }
        
        public VocabularyKey OwnerIdType { get; private set; }
        
        public VocabularyKey OwnerIdYomiName { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        public VocabularyKey OwningBusinessUnit { get; private set; }
        
        public VocabularyKey ObjectTypeCode { get; private set; }
        
        public VocabularyKey ReminderTime { get; private set; }
        
        public VocabularyKey StartTime { get; private set; }
        
        public VocabularyKey DueDate { get; private set; }
        
        public VocabularyKey FlagDueBy { get; private set; }
        
        public VocabularyKey CommonStart { get; private set; }
        
        public VocabularyKey CommonEnd { get; private set; }
        
        public VocabularyKey ToDoOrdinalDate { get; private set; }
        
        public VocabularyKey ReminderSet { get; private set; }
        
        public VocabularyKey FlagRequest { get; private set; }
        
        public VocabularyKey ToDoSubOrdinal { get; private set; }
        
        public VocabularyKey ToDoTitle { get; private set; }
        
        public VocabularyKey PersonalCategories { get; private set; }
        
        public VocabularyKey ObjectId { get; private set; }
        
        public VocabularyKey FlagStatus { get; private set; }
        
        public VocabularyKey ToDoItemFlags { get; private set; }
        
        public VocabularyKey OwningTeam { get; private set; }
        
        
        }
    }
    
