using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class WorkflowLogVocabulary : SimpleVocabulary
        {
            public WorkflowLogVocabulary()
            {
                VocabularyName = "Dynamics365 WorkflowLog";
                KeyPrefix = "dynamics365.workflowlog";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("WorkflowLog", group =>
                {
                    this.AsyncOperationId = group.Add(new VocabularyKey("AsyncOperationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"lk_opportunitysalesprocess_workflowlogs")
                        .WithDisplayName("Parent record")
                        .ModelProperty("asyncoperationid", typeof(string)));
                    
                    this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who last modified the process log entry.")
                        .WithDisplayName("Modified By")
                        .ModelProperty("modifiedby", typeof(string)));
                    
                    this.CompletedOn = group.Add(new VocabularyKey("CompletedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Date and time when the operation was completed.")
                        .WithDisplayName("Completed On")
                        .ModelProperty("completedon", typeof(DateTime)));
                    
                    this.WorkflowLogId = group.Add(new VocabularyKey("WorkflowLogId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the process log entry.")
                        .WithDisplayName("Process Log")
                        .ModelProperty("workflowlogid", typeof(Guid)));
                    
                    this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the business unit that owns the process.")
                        .WithDisplayName("Owning Business Unit")
                        .ModelProperty("owningbusinessunit", typeof(string)));
                    
                    this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100000))
                        .WithDescription(@"Description of the process step.")
                        .WithDisplayName("Step Description")
                        .ModelProperty("description", typeof(string)));
                    
                    this.Message = group.Add(new VocabularyKey("Message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100000))
                        .WithDescription(@"Message related to process.")
                        .WithDisplayName("Message")
                        .ModelProperty("message", typeof(string)));
                    
                    this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who created the process log entry.")
                        .WithDisplayName("Created By")
                        .ModelProperty("createdby", typeof(string)));
                    
                    this.StageName = group.Add(new VocabularyKey("StageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                        .WithDescription(@"Name of the process stage.")
                        .WithDisplayName("Process Stage")
                        .ModelProperty("stagename", typeof(string)));
                    
                    this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the process log entry was created.")
                        .WithDisplayName("Started On")
                        .ModelProperty("createdon", typeof(DateTime)));
                    
                    this.StepName = group.Add(new VocabularyKey("StepName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                        .WithDescription(@"Name of the process step.")
                        .WithDisplayName("Step Name")
                        .ModelProperty("stepname", typeof(string)));
                    
                    this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who owns the process.")
                        .WithDisplayName("Owning User")
                        .ModelProperty("owninguser", typeof(string)));
                    
                    this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the process log entry was last modified.")
                        .WithDisplayName("Modified On")
                        .ModelProperty("modifiedon", typeof(DateTime)));
                    
                    this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the associated record.")
                        .WithDisplayName("Regarding")
                        .ModelProperty("regardingobjectid", typeof(string)));
                    
                    this.Status = group.Add(new VocabularyKey("Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Status of the process step for which process log record has been created: In Progress, Successfully Completed, or Failed.")
                        .WithDisplayName("Status")
                        .ModelProperty("status", typeof(string)));
                    
                    this.ErrorCode = group.Add(new VocabularyKey("ErrorCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Error code related to process.")
                        .WithDisplayName("Error Message")
                        .ModelProperty("errorcode", typeof(long)));
                    
                    this.ActivityName = group.Add(new VocabularyKey("ActivityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                        .WithDescription(@"Name of the activity which the process step is currently processing.")
                        .WithDisplayName("Activity Name")
                        .ModelProperty("activityname", typeof(string)));
                    
                    this.AsyncOperationIdName = group.Add(new VocabularyKey("AsyncOperationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                        .WithDescription(@"Name of the parent record.")
                        .WithDisplayName("Parent record")
                        .ModelProperty("asyncoperationidname", typeof(string)));
                    
                    this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                        .WithDescription(@"")
                        .WithDisplayName("Regarding Object Id Name")
                        .ModelProperty("regardingobjectidname", typeof(string)));
                    
                    this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("Created By Name")
                        .ModelProperty("createdbyname", typeof(string)));
                    
                    this.StatusName = group.Add(new VocabularyKey("StatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("Status Name")
                        .ModelProperty("statusname", typeof(string)));
                    
                    this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"")
                        .WithDisplayName("Regarding Object Type Code")
                        .ModelProperty("regardingobjecttypecode", typeof(string)));
                    
                    this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"Name of the user who last modified the operation.")
                        .WithDisplayName("Modified By Name")
                        .ModelProperty("modifiedbyname", typeof(string)));
                    
                    this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                        .WithDescription(@"")
                        .WithDisplayName("Regarding Object Id Yomi Name")
                        .ModelProperty("regardingobjectidyominame", typeof(string)));
                    
                    this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"YomiName of the user who last modified the operation.")
                        .WithDisplayName("Modified By Yomi Name")
                        .ModelProperty("modifiedbyyominame", typeof(string)));
                    
                    this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("Created By Yomi Name")
                        .ModelProperty("createdbyyominame", typeof(string)));
                    
                    this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user or team who owns the process log.")
                        .WithDisplayName("Owner")
                        .ModelProperty("ownerid", typeof(string)));
                    
                    this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("Owner Id Type")
                        .ModelProperty("owneridtype", typeof(string)));
                    
                    this.ChildWorkflowInstanceId = group.Add(new VocabularyKey("ChildWorkflowInstanceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the system job.")
                        .WithDisplayName("Child Workflow System Job")
                        .ModelProperty("childworkflowinstanceid", typeof(string)));
                    
                    this.ChildWorkflowInstanceIdName = group.Add(new VocabularyKey("ChildWorkflowInstanceIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"Name of the async operation.")
                        .WithDisplayName("Child Async Operation Name")
                        .ModelProperty("childworkflowinstanceidname", typeof(string)));
                    
                    this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the delegate user who created the process log.")
                        .WithDisplayName("Created By (Delegate)")
                        .ModelProperty("createdonbehalfby", typeof(string)));
                    
                    this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("Created By(Delegate) Name")
                        .ModelProperty("createdonbehalfbyname", typeof(string)));
                    
                    this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("Created By(Delegate) Yomi Name")
                        .ModelProperty("createdonbehalfbyyominame", typeof(string)));
                    
                    this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the delegate user who last modified the process log.")
                        .WithDisplayName("Modified By (Delegate)")
                        .ModelProperty("modifiedonbehalfby", typeof(string)));
                    
                    this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("Modified On Behalf By Name")
                        .ModelProperty("modifiedonbehalfbyname", typeof(string)));
                    
                    this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("Modified On Behalf By Yomi Name")
                        .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));
                    
                    this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Type of entity with which the process is associated.")
                        .WithDisplayName("Entity")
                        .ModelProperty("objecttypecode", typeof(string)));
                    
                    this.ChildWorkflowInstanceObjectTypeCode = group.Add(new VocabularyKey("ChildWorkflowInstanceObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Object Type Code of the entity that is associated with the child workflow.")
                        .WithDisplayName("Entity")
                        .ModelProperty("childworkflowinstanceobjecttypecode", typeof(string)));
                    
                    this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the team who owns the process log.")
                        .WithDisplayName("Owning Team")
                        .ModelProperty("owningteam", typeof(string)));
                    
                    this.InteractionActivityResult = group.Add(new VocabularyKey("InteractionActivityResult", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100000))
                        .WithDescription(@"String specifying the result of an interaction activity.")
                        .WithDisplayName("Interaction Activity Result")
                        .ModelProperty("interactionactivityresult", typeof(string)));
                    
                    this.StartedOn = group.Add(new VocabularyKey("StartedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Date and time when the operation was started.")
                        .WithDisplayName("Started On")
                        .ModelProperty("startedon", typeof(DateTime)));
                    
                    this.Duration = group.Add(new VocabularyKey("Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Duration between completed on and started on, used by business process flow.")
                        .WithDisplayName("Duration")
                        .ModelProperty("duration", typeof(long)));
                    
                    this.ErrorText = group.Add(new VocabularyKey("ErrorText", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1000))
                        .WithDescription(@"The string representation of the error.")
                        .WithDisplayName("ErrorText")
                        .ModelProperty("errortext", typeof(string)));
                    
                    this.Inputs_Name = group.Add(new VocabularyKey("Inputs_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                        .WithDescription(@"")
                        .WithDisplayName("Inputs_Name")
                        .ModelProperty("inputs_name", typeof(string)));
                    
                    this.Outputs_Name = group.Add(new VocabularyKey("Outputs_Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                        .WithDescription(@"")
                        .WithDisplayName("Outputs_Name")
                        .ModelProperty("outputs_name", typeof(string)));
                    
                    this.IterationCount = group.Add(new VocabularyKey("IterationCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"The iteration count for the action when in a do until loop.")
                        .WithDisplayName("IterationCount")
                        .ModelProperty("iterationcount", typeof(long)));
                    
                    this.RepetitionCount = group.Add(new VocabularyKey("RepetitionCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"The count of repetitions of the action when in a loop.")
                        .WithDisplayName("RepetitionCount")
                        .ModelProperty("repetitioncount", typeof(long)));
                    
                    this.RepetitionId = group.Add(new VocabularyKey("RepetitionId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1000))
                        .WithDescription(@"The string representation of the repetition and iteration / level of the action.")
                        .WithDisplayName("RepetitionId")
                        .ModelProperty("repetitionid", typeof(string)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey AsyncOperationId { get; private set; }
        
        public VocabularyKey ModifiedBy { get; private set; }
        
        public VocabularyKey CompletedOn { get; private set; }
        
        public VocabularyKey WorkflowLogId { get; private set; }
        
        public VocabularyKey OwningBusinessUnit { get; private set; }
        
        public VocabularyKey Description { get; private set; }
        
        public VocabularyKey Message { get; private set; }
        
        public VocabularyKey CreatedBy { get; private set; }
        
        public VocabularyKey StageName { get; private set; }
        
        public VocabularyKey CreatedOn { get; private set; }
        
        public VocabularyKey StepName { get; private set; }
        
        public VocabularyKey OwningUser { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey RegardingObjectId { get; private set; }
        
        public VocabularyKey Status { get; private set; }
        
        public VocabularyKey ErrorCode { get; private set; }
        
        public VocabularyKey ActivityName { get; private set; }
        
        public VocabularyKey AsyncOperationIdName { get; private set; }
        
        public VocabularyKey RegardingObjectIdName { get; private set; }
        
        public VocabularyKey CreatedByName { get; private set; }
        
        public VocabularyKey StatusName { get; private set; }
        
        public VocabularyKey RegardingObjectTypeCode { get; private set; }
        
        public VocabularyKey ModifiedByName { get; private set; }
        
        public VocabularyKey RegardingObjectIdYomiName { get; private set; }
        
        public VocabularyKey ModifiedByYomiName { get; private set; }
        
        public VocabularyKey CreatedByYomiName { get; private set; }
        
        public VocabularyKey OwnerId { get; private set; }
        
        public VocabularyKey OwnerIdType { get; private set; }
        
        public VocabularyKey ChildWorkflowInstanceId { get; private set; }
        
        public VocabularyKey ChildWorkflowInstanceIdName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey ObjectTypeCode { get; private set; }
        
        public VocabularyKey ChildWorkflowInstanceObjectTypeCode { get; private set; }
        
        public VocabularyKey OwningTeam { get; private set; }
        
        public VocabularyKey InteractionActivityResult { get; private set; }
        
        public VocabularyKey StartedOn { get; private set; }
        
        public VocabularyKey Duration { get; private set; }
        
        public VocabularyKey ErrorText { get; private set; }
        
        public VocabularyKey Inputs_Name { get; private set; }
        
        public VocabularyKey Outputs_Name { get; private set; }
        
        public VocabularyKey IterationCount { get; private set; }
        
        public VocabularyKey RepetitionCount { get; private set; }
        
        public VocabularyKey RepetitionId { get; private set; }
        
        
        }
    }
    
