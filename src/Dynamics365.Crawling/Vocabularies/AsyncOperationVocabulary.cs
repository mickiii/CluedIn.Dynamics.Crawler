using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AsyncOperationVocabulary : SimpleVocabulary
    {
        public AsyncOperationVocabulary()
        {
            VocabularyName = "Dynamics365 AsyncOperation";
            KeyPrefix = "dynamics365.asyncoperation";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("AsyncOperation", group =>
            {
                this.MessageName = group.Add(new VocabularyKey("MessageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the message that started this system job.")
                    .WithDisplayName("Message Name")
                    .ModelProperty("messagename", typeof(string)));

                this.Depth = group.Add(new VocabularyKey("Depth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number of SDK calls made since the first call.")
                    .WithDisplayName("Depth")
                    .ModelProperty("depth", typeof(long)));

                this.PrimaryEntityType = group.Add(new VocabularyKey("PrimaryEntityType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of entity with which the system job is primarily associated.")
                    .WithDisplayName("Primary Entity Type")
                    .ModelProperty("primaryentitytype", typeof(string)));

                this.Data = group.Add(new VocabularyKey("Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Unstructured data associated with the system job.")
                    .WithDisplayName("Data")
                    .ModelProperty("data", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the object with which the system job is associated.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.WorkflowStageName = group.Add(new VocabularyKey("WorkflowStageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Name of a workflow stage.")
                    .WithDisplayName("Workflow Stage")
                    .ModelProperty("workflowstagename", typeof(string)));

                this.OperationType = group.Add(new VocabularyKey("OperationType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of the system job.")
                    .WithDisplayName("System Job Type")
                    .ModelProperty("operationtype", typeof(string)));

                this.DependencyToken = group.Add(new VocabularyKey("DependencyToken", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Execution of all operations with the same dependency token is serialized.")
                    .WithDisplayName("Dependency Token")
                    .ModelProperty("dependencytoken", typeof(string)));

                this.RecurrencePattern = group.Add(new VocabularyKey("RecurrencePattern", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Pattern of the system job's recurrence.")
                    .WithDisplayName("Recurrence Pattern")
                    .ModelProperty("recurrencepattern", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Name of the system job.")
                    .WithDisplayName("System Job Name")
                    .ModelProperty("name", typeof(string)));

                this.PostponeUntil = group.Add(new VocabularyKey("PostponeUntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the system job should run only after the specified date and time.")
                    .WithDisplayName("Postpone Until")
                    .ModelProperty("postponeuntil", typeof(DateTime)));

                this.WorkflowState = group.Add(new VocabularyKey("WorkflowState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"State of the workflow job.")
                    .WithDisplayName("Workflow State")
                    .ModelProperty("workflowstate", typeof(string)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("TimeZoneRuleVersionNumber")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the system job.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.IsWaitingForEvent = group.Add(new VocabularyKey("IsWaitingForEvent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates that the system job is waiting for an event.")
                    .WithDisplayName("Waiting for Event")
                    .ModelProperty("iswaitingforevent", typeof(bool)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the system job.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ErrorCode = group.Add(new VocabularyKey("ErrorCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Error code returned from a canceled system job.")
                    .WithDisplayName("Error Code")
                    .ModelProperty("errorcode", typeof(long)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the system job.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.CorrelationId = group.Add(new VocabularyKey("CorrelationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier used to correlate between multiple SDK requests and system jobs.")
                    .WithDisplayName("Correlation Id")
                    .ModelProperty("correlationid", typeof(Guid)));

                this.RecurrenceStartTime = group.Add(new VocabularyKey("RecurrenceStartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Starting time in UTC for the recurrence pattern.")
                    .WithDisplayName("Recurrence Start")
                    .ModelProperty("recurrencestarttime", typeof(DateTime)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Reason for the status of the system job.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.AsyncOperationId = group.Add(new VocabularyKey("AsyncOperationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the system job.")
                    .WithDisplayName("System Job")
                    .ModelProperty("asyncoperationid", typeof(Guid)));

                this.Sequence = group.Add(new VocabularyKey("Sequence", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Order in which operations were submitted.")
                    .WithDisplayName("Sequence")
                    .ModelProperty("sequence", typeof(int)));

                this.RequestId = group.Add(new VocabularyKey("RequestId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the request that generated the system job.")
                    .WithDisplayName("Request")
                    .ModelProperty("requestid", typeof(Guid)));

                this.WorkflowIsBlocked = group.Add(new VocabularyKey("WorkflowIsBlocked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the workflow instance was blocked when it was persisted.")
                    .WithDisplayName("Workflow Is Blocked")
                    .ModelProperty("workflowisblocked", typeof(bool)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the system job was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.Message = group.Add(new VocabularyKey("Message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100000))
                    .WithDescription(@"Message related to the system job.")
                    .WithDisplayName("Message")
                    .ModelProperty("message", typeof(string)));

                this.StartedOn = group.Add(new VocabularyKey("StartedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the system job was started.")
                    .WithDisplayName("Started On")
                    .ModelProperty("startedon", typeof(DateTime)));

                this.HostId = group.Add(new VocabularyKey("HostId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"Unique identifier of the host that owns this system job.")
                    .WithDisplayName("Host")
                    .ModelProperty("hostid", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Status of the system job.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.WorkflowActivationId = group.Add(new VocabularyKey("WorkflowActivationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the workflow activation related to the system job.")
                    .WithDisplayName("Workflow Activation Id")
                    .ModelProperty("workflowactivationid", typeof(string)));

                this.CompletedOn = group.Add(new VocabularyKey("CompletedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the system job was completed.")
                    .WithDisplayName("Completed On")
                    .ModelProperty("completedon", typeof(DateTime)));

                this.CorrelationUpdatedTime = group.Add(new VocabularyKey("CorrelationUpdatedTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Last time the correlation depth was updated.")
                    .WithDisplayName("Correlation Updated Time")
                    .ModelProperty("correlationupdatedtime", typeof(DateTime)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTCConversionTimeZoneCode")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the system job.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.RetryCount = group.Add(new VocabularyKey("RetryCount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number of times to retry the system job.")
                    .WithDisplayName("Retry Count")
                    .ModelProperty("retrycount", typeof(long)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the system job was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the record.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.PrimaryEntityTypeName = group.Add(new VocabularyKey("PrimaryEntityTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PrimaryEntityTypeName")
                    .ModelProperty("primaryentitytypename", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the user who last modified the record.")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.WorkflowActivationIdName = group.Add(new VocabularyKey("WorkflowActivationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("WorkflowActivationIdName")
                    .ModelProperty("workflowactivationidname", typeof(string)));

                this.OperationTypeName = group.Add(new VocabularyKey("OperationTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Describes the record type.")
                    .WithDisplayName("OperationTypeName")
                    .ModelProperty("operationtypename", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"State name of the async operation.")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"YomiName of the user who last modified the record.")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.FriendlyMessage = group.Add(new VocabularyKey("FriendlyMessage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100000))
                    .WithDescription(@"Message provided by the system job.")
                    .WithDisplayName("Friendly message")
                    .ModelProperty("friendlymessage", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the asyncoperation.")
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
                    .WithDescription(@"Unique identifier of the delegate user who last modified the asyncoperation.")
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

                this.OwningExtensionId = group.Add(new VocabularyKey("OwningExtensionId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the owning extension with which the system job is associated.")
                    .WithDisplayName("Owning Extension")
                    .ModelProperty("owningextensionid", typeof(string)));

                this.OwningExtensionIdName = group.Add(new VocabularyKey("OwningExtensionIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("OwningExtensionIdName")
                    .ModelProperty("owningextensionidname", typeof(string)));

                this.OwningExtensionTypeCode = group.Add(new VocabularyKey("OwningExtensionTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwningExtensionTypeCode")
                    .ModelProperty("owningextensiontypecode", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the team who owns the record.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.ExecutionTimeSpan = group.Add(new VocabularyKey("ExecutionTimeSpan", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Time that the system job has taken to execute.")
                    .WithDisplayName("ExecutionTimeSpan")
                    .ModelProperty("executiontimespan", typeof(double)));

                this.Subtype = group.Add(new VocabularyKey("Subtype", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The Subtype of the Async Job")
                    .WithDisplayName("Subtype")
                    .ModelProperty("subtype", typeof(long)));

                this.ParentPluginExecutionId = group.Add(new VocabularyKey("ParentPluginExecutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ParentPluginExecutionId")
                    .ModelProperty("parentpluginexecutionid", typeof(Guid)));

                this.RootExecutionContext = group.Add(new VocabularyKey("RootExecutionContext", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Root execution context of the job that trigerred async job.")
                    .WithDisplayName("RootExecutionContext")
                    .ModelProperty("rootexecutioncontext", typeof(string)));

                this.Workload = group.Add(new VocabularyKey("Workload", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"The workload name.")
                    .WithDisplayName("Workload")
                    .ModelProperty("workload", typeof(string)));

                this.ExpanderStartTime = group.Add(new VocabularyKey("ExpanderStartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The datetime when the Expander pipeline started.")
                    .WithDisplayName("Expander Start Time")
                    .ModelProperty("expanderstarttime", typeof(DateTime)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey MessageName { get; private set; }

        public VocabularyKey Depth { get; private set; }

        public VocabularyKey PrimaryEntityType { get; private set; }

        public VocabularyKey Data { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey WorkflowStageName { get; private set; }

        public VocabularyKey OperationType { get; private set; }

        public VocabularyKey DependencyToken { get; private set; }

        public VocabularyKey RecurrencePattern { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey PostponeUntil { get; private set; }

        public VocabularyKey WorkflowState { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey IsWaitingForEvent { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ErrorCode { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey CorrelationId { get; private set; }

        public VocabularyKey RecurrenceStartTime { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey AsyncOperationId { get; private set; }

        public VocabularyKey Sequence { get; private set; }

        public VocabularyKey RequestId { get; private set; }

        public VocabularyKey WorkflowIsBlocked { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey Message { get; private set; }

        public VocabularyKey StartedOn { get; private set; }

        public VocabularyKey HostId { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey WorkflowActivationId { get; private set; }

        public VocabularyKey CompletedOn { get; private set; }

        public VocabularyKey CorrelationUpdatedTime { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey RetryCount { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey PrimaryEntityTypeName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey WorkflowActivationIdName { get; private set; }

        public VocabularyKey OperationTypeName { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey FriendlyMessage { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey OwningExtensionId { get; private set; }

        public VocabularyKey OwningExtensionIdName { get; private set; }

        public VocabularyKey OwningExtensionTypeCode { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey ExecutionTimeSpan { get; private set; }

        public VocabularyKey Subtype { get; private set; }

        public VocabularyKey ParentPluginExecutionId { get; private set; }

        public VocabularyKey RootExecutionContext { get; private set; }

        public VocabularyKey Workload { get; private set; }

        public VocabularyKey ExpanderStartTime { get; private set; }


    }
}

