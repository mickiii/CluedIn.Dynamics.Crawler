using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class WorkflowWaitSubscriptionVocabulary : SimpleVocabulary
        {
            public WorkflowWaitSubscriptionVocabulary()
            {
                VocabularyName = "Dynamics365 WorkflowWaitSubscription";
                KeyPrefix = "dynamics365.workflowwaitsubscription";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("WorkflowWaitSubscription", group =>
                {
                    this.EntityId = group.Add(new VocabularyKey("EntityId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Id of entity to which workflow instance subscribes.")
                        .WithDisplayName("EntityId")
                        .ModelProperty("entityid", typeof(Guid)));
                    
                    this.WorkflowWaitSubscriptionId = group.Add(new VocabularyKey("WorkflowWaitSubscriptionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the subscription.")
                        .WithDisplayName("WorkflowWaitSubscriptionId")
                        .ModelProperty("workflowwaitsubscriptionid", typeof(Guid)));
                    
                    this.AsyncOperationId = group.Add(new VocabularyKey("AsyncOperationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the asynchronous operation with which the subscription is associated.")
                        .WithDisplayName("AsyncOperationId")
                        .ModelProperty("asyncoperationid", typeof(string)));
                    
                    this.Data = group.Add(new VocabularyKey("Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Unstructured data associated with the subscription.")
                        .WithDisplayName("Data")
                        .ModelProperty("data", typeof(string)));
                    
                    this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the business unit that owns the parent workflow instance.")
                        .WithDisplayName("OwningBusinessUnit")
                        .ModelProperty("owningbusinessunit", typeof(Guid)));
                    
                    this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the entity was modified.")
                        .WithDisplayName("ModifiedOn")
                        .ModelProperty("modifiedon", typeof(DateTime)));
                    
                    this.EntityName = group.Add(new VocabularyKey("EntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                        .WithDescription(@"Name of entity to which workflow instance subscribes.")
                        .WithDisplayName("EntityName")
                        .ModelProperty("entityname", typeof(string)));
                    
                    this.IsModified = group.Add(new VocabularyKey("IsModified", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Indicates whether the entity to which workflow instance subscribes is modified after the subscription is created.")
                        .WithDisplayName("IsModified")
                        .ModelProperty("ismodified", typeof(bool)));
                    
                    this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who owns the parent workflow instance.")
                        .WithDisplayName("OwningUser")
                        .ModelProperty("owninguser", typeof(Guid)));
                    
                    this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("OwnerIdType")
                        .ModelProperty("owneridtype", typeof(string)));
                    
                    this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user or team who owns the parent workflow instance.")
                        .WithDisplayName("Owner")
                        .ModelProperty("ownerid", typeof(string)));
                    
                    this.IsDeleted = group.Add(new VocabularyKey("IsDeleted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Indicates whether the entity to which workflow instance subscribes is deleted after the subscription is created.")
                        .WithDisplayName("IsDeleted")
                        .ModelProperty("isdeleted", typeof(bool)));
                    
                    this.WaitOnAttributeList = group.Add(new VocabularyKey("WaitOnAttributeList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100000))
                        .WithDescription(@"Attributes on which the subscription is waiting to change.")
                        .WithDisplayName("Wait On Attribute List")
                        .ModelProperty("waitonattributelist", typeof(string)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey EntityId { get; private set; }
        
        public VocabularyKey WorkflowWaitSubscriptionId { get; private set; }
        
        public VocabularyKey AsyncOperationId { get; private set; }
        
        public VocabularyKey Data { get; private set; }
        
        public VocabularyKey OwningBusinessUnit { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey EntityName { get; private set; }
        
        public VocabularyKey IsModified { get; private set; }
        
        public VocabularyKey OwningUser { get; private set; }
        
        public VocabularyKey OwnerIdType { get; private set; }
        
        public VocabularyKey OwnerId { get; private set; }
        
        public VocabularyKey IsDeleted { get; private set; }
        
        public VocabularyKey WaitOnAttributeList { get; private set; }
        
        
        }
    }
    
