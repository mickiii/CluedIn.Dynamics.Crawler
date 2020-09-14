using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class WorkflowVocabulary : SimpleVocabulary
        {
            public WorkflowVocabulary()
            {
                VocabularyName = "Dynamics365 Workflow";
                KeyPrefix = "dynamics365.workflow";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("Workflow", group =>
                {
                    this.OnDemand = group.Add(new VocabularyKey("OnDemand", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether the process is able to run as an on-demand process.")
                        .WithDisplayName("Run as On Demand")
                        .ModelProperty("ondemand", typeof(bool)));
                    
                    this.PluginTypeId = group.Add(new VocabularyKey("PluginTypeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the plug-in type.")
                        .WithDisplayName("PluginTypeId")
                        .ModelProperty("plugintypeid", typeof(string)));
                    
                    this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the process was created.")
                        .WithDisplayName("Created On")
                        .ModelProperty("createdon", typeof(DateTime)));
                    
                    this.Type = group.Add(new VocabularyKey("Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Type of the process.")
                        .WithDisplayName("Type")
                        .ModelProperty("type", typeof(string)));
                    
                    this.WorkflowId = group.Add(new VocabularyKey("WorkflowId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the process.")
                        .WithDisplayName("Process")
                        .ModelProperty("workflowid", typeof(Guid)));
                    
                    this.ActiveWorkflowId = group.Add(new VocabularyKey("ActiveWorkflowId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the latest activation record for the process.")
                        .WithDisplayName("Active Process ID")
                        .ModelProperty("activeworkflowid", typeof(string)));
                    
                    this.ParentWorkflowId = group.Add(new VocabularyKey("ParentWorkflowId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the definition for process activation.")
                        .WithDisplayName("Parent Process ID")
                        .ModelProperty("parentworkflowid", typeof(string)));
                    
                    this.UIData = group.Add(new VocabularyKey("UIData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("UI Data")
                        .ModelProperty("uidata", typeof(string)));
                    
                    this.PrimaryEntity = group.Add(new VocabularyKey("PrimaryEntity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Primary entity for the process. The process can be associated for one or more SDK operations defined on the primary entity.")
                        .WithDisplayName("Primary Entity")
                        .ModelProperty("primaryentity", typeof(string)));
                    
                    this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the user or team who owns the process.")
                        .WithDisplayName("Owner")
                        .ModelProperty("ownerid", typeof(string)));
                    
                    this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the process was last modified.")
                        .WithDisplayName("Modified On")
                        .ModelProperty("modifiedon", typeof(DateTime)));
                    
                    this.AsyncAutoDelete = group.Add(new VocabularyKey("AsyncAutoDelete", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether the asynchronous system job is automatically deleted on completion.")
                        .WithDisplayName("Delete Job On Completion")
                        .ModelProperty("asyncautodelete", typeof(bool)));
                    
                    this.IsCrmUIWorkflow = group.Add(new VocabularyKey("IsCrmUIWorkflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Indicates whether the process was created using the Microsoft Dynamics CRM Web application.")
                        .WithDisplayName("Is CRM Process")
                        .ModelProperty("iscrmuiworkflow", typeof(bool)));
                    
                    this.Subprocess = group.Add(new VocabularyKey("Subprocess", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether the process can be included in other processes as a child process.")
                        .WithDisplayName("Is Child Process")
                        .ModelProperty("subprocess", typeof(bool)));
                    
                    this.Scope = group.Add(new VocabularyKey("Scope", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Scope of the process.")
                        .WithDisplayName("Scope")
                        .ModelProperty("scope", typeof(string)));
                    
                    this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Additional information about status of the process.")
                        .WithDisplayName("Status Reason")
                        .ModelProperty("statuscode", typeof(string)));
                    
                    this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who last modified the process.")
                        .WithDisplayName("Modified By")
                        .ModelProperty("modifiedby", typeof(string)));
                    
                    this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100000))
                        .WithDescription(@"Description of the process.")
                        .WithDisplayName("Description")
                        .ModelProperty("description", typeof(string)));
                    
                    this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who created the process.")
                        .WithDisplayName("Created By")
                        .ModelProperty("createdby", typeof(string)));
                    
                    this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                        .WithDescription(@"Name of the process.")
                        .WithDisplayName("Process Name")
                        .ModelProperty("name", typeof(string)));
                    
                    this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the business unit that owns the process.")
                        .WithDisplayName("Owning Business Unit")
                        .ModelProperty("owningbusinessunit", typeof(string)));
                    
                    this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Status of the process.")
                        .WithDisplayName("Status")
                        .ModelProperty("statecode", typeof(string)));
                    
                    this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who owns the process.")
                        .WithDisplayName("Owning User")
                        .ModelProperty("owninguser", typeof(string)));
                    
                    this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"")
                        .WithDisplayName("OwnerIdType")
                        .ModelProperty("owneridtype", typeof(string)));
                    
                    this.ScopeName = group.Add(new VocabularyKey("ScopeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("ScopeName")
                        .ModelProperty("scopename", typeof(string)));
                    
                    this.ParentWorkflowIdName = group.Add(new VocabularyKey("ParentWorkflowIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ParentWorkflowIdName")
                        .ModelProperty("parentworkflowidname", typeof(string)));
                    
                    this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("StateCodeName")
                        .ModelProperty("statecodename", typeof(string)));
                    
                    this.TypeName = group.Add(new VocabularyKey("TypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("TypeName")
                        .ModelProperty("typename", typeof(string)));
                    
                    this.ActiveWorkflowIdName = group.Add(new VocabularyKey("ActiveWorkflowIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ActiveWorkflowIdName")
                        .ModelProperty("activeworkflowidname", typeof(string)));
                    
                    this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByName")
                        .ModelProperty("modifiedbyname", typeof(string)));
                    
                    this.OwningBusinessUnitName = group.Add(new VocabularyKey("OwningBusinessUnitName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("OwningBusinessUnitName")
                        .ModelProperty("owningbusinessunitname", typeof(string)));
                    
                    this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("StatusCodeName")
                        .ModelProperty("statuscodename", typeof(string)));
                    
                    this.PrimaryEntityName = group.Add(new VocabularyKey("PrimaryEntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("PrimaryEntityName")
                        .ModelProperty("primaryentityname", typeof(string)));
                    
                    this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("OwnerIdName")
                        .ModelProperty("owneridname", typeof(string)));
                    
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
                    
                    this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByYomiName")
                        .ModelProperty("modifiedbyyominame", typeof(string)));
                    
                    this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("OwnerIdYomiName")
                        .ModelProperty("owneridyominame", typeof(string)));
                    
                    this.WorkflowIdUnique = group.Add(new VocabularyKey("WorkflowIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("WorkflowIdUnique")
                        .ModelProperty("workflowidunique", typeof(Guid)));
                    
                    this.SupportingSolutionId = group.Add(new VocabularyKey("SupportingSolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("Solution")
                        .ModelProperty("supportingsolutionid", typeof(Guid)));
                    
                    this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the associated solution.")
                        .WithDisplayName("Solution")
                        .ModelProperty("solutionid", typeof(Guid)));
                    
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
                    
                    this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the delegate user who created the process.")
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
                        .WithDescription(@"Unique identifier of the delegate user who last modified the process.")
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
                    
                    this.Xaml = group.Add(new VocabularyKey("Xaml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"XAML that defines the process.")
                        .WithDisplayName("Xaml")
                        .ModelProperty("xaml", typeof(string)));
                    
                    this.TriggerOnDelete = group.Add(new VocabularyKey("TriggerOnDelete", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether the process will be triggered on deletion of the primary entity.")
                        .WithDisplayName("Trigger On Delete")
                        .ModelProperty("triggerondelete", typeof(bool)));
                    
                    this.RendererObjectTypeCode = group.Add(new VocabularyKey("RendererObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"The renderer type of Workflow")
                        .WithDisplayName("Renderer Type")
                        .ModelProperty("rendererobjecttypecode", typeof(string)));
                    
                    this.TriggerOnCreate = group.Add(new VocabularyKey("TriggerOnCreate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates whether the process will be triggered when the primary entity is created.")
                        .WithDisplayName("Trigger On Create")
                        .ModelProperty("triggeroncreate", typeof(bool)));
                    
                    this.TriggerOnUpdateAttributeList = group.Add(new VocabularyKey("TriggerOnUpdateAttributeList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Attributes that trigger the process when updated.")
                        .WithDisplayName("Trigger On Update Attribute List")
                        .ModelProperty("triggeronupdateattributelist", typeof(string)));
                    
                    this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the team who owns the process.")
                        .WithDisplayName("Owning Team")
                        .ModelProperty("owningteam", typeof(string)));
                    
                    this.Category = group.Add(new VocabularyKey("Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Category of the process.")
                        .WithDisplayName("Category")
                        .ModelProperty("category", typeof(string)));
                    
                    this.LanguageCode = group.Add(new VocabularyKey("LanguageCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Language of the process.")
                        .WithDisplayName("Language")
                        .ModelProperty("languagecode", typeof(long)));
                    
                    this.CategoryName = group.Add(new VocabularyKey("CategoryName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("CategoryName")
                        .ModelProperty("categoryname", typeof(string)));
                    
                    this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Indicates whether the solution component is part of a managed solution.")
                        .WithDisplayName("Is Managed")
                        .ModelProperty("ismanaged", typeof(bool)));
                    
                    this.IsCustomizable = group.Add(new VocabularyKey("IsCustomizable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Information that specifies whether this component can be customized.")
                        .WithDisplayName("Customizable")
                        .ModelProperty("iscustomizable", typeof(string)));
                    
                    this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("IsManagedName")
                        .ModelProperty("ismanagedname", typeof(string)));
                    
                    this.InputParameters = group.Add(new VocabularyKey("InputParameters", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Input parameters to the process.")
                        .WithDisplayName("Input Parameters")
                        .ModelProperty("inputparameters", typeof(string)));
                    
                    this.AsyncAutoDeleteName = group.Add(new VocabularyKey("AsyncAutoDeleteName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("AsyncAutoDeleteName")
                        .ModelProperty("asyncautodeletename", typeof(string)));
                    
                    this.OnDemandName = group.Add(new VocabularyKey("OnDemandName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("OnDemandName")
                        .ModelProperty("ondemandname", typeof(string)));
                    
                    this.SubprocessName = group.Add(new VocabularyKey("SubprocessName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("SubprocessName")
                        .ModelProperty("subprocessname", typeof(string)));
                    
                    this.TriggerOnCreateName = group.Add(new VocabularyKey("TriggerOnCreateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("TriggerOnCreateName")
                        .ModelProperty("triggeroncreatename", typeof(string)));
                    
                    this.TriggerOnDeleteName = group.Add(new VocabularyKey("TriggerOnDeleteName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("TriggerOnDeleteName")
                        .ModelProperty("triggerondeletename", typeof(string)));
                    
                    this.ClientData = group.Add(new VocabularyKey("ClientData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                        .WithDescription(@"Business logic converted into client data")
                        .WithDisplayName("Client Data")
                        .ModelProperty("clientdata", typeof(string)));
                    
                    this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("VersionNumber")
                        .ModelProperty("versionnumber", typeof(int)));
                    
                    this.CreateStage = group.Add(new VocabularyKey("CreateStage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Stage of the process when triggered on Create.")
                        .WithDisplayName("Create Stage")
                        .ModelProperty("createstage", typeof(string)));
                    
                    this.UpdateStage = group.Add(new VocabularyKey("UpdateStage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Select the stage a process will be triggered on update.")
                        .WithDisplayName("Update Stage")
                        .ModelProperty("updatestage", typeof(string)));
                    
                    this.DeleteStage = group.Add(new VocabularyKey("DeleteStage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Stage of the process when triggered on Delete.")
                        .WithDisplayName("Delete stage")
                        .ModelProperty("deletestage", typeof(string)));
                    
                    this.CreateStageName = group.Add(new VocabularyKey("CreateStageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("CreateStageName")
                        .ModelProperty("createstagename", typeof(string)));
                    
                    this.UpdateStageName = group.Add(new VocabularyKey("UpdateStageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("UpdateStageName")
                        .ModelProperty("updatestagename", typeof(string)));
                    
                    this.DeleteStageName = group.Add(new VocabularyKey("DeleteStageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("DeleteStageName")
                        .ModelProperty("deletestagename", typeof(string)));
                    
                    this.Rank = group.Add(new VocabularyKey("Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Indicates the rank for order of execution for the synchronous workflow.")
                        .WithDisplayName("Rank")
                        .ModelProperty("rank", typeof(long)));
                    
                    this.RunAs = group.Add(new VocabularyKey("RunAs", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Specifies the system user account under which a workflow executes.")
                        .WithDisplayName("Run As User")
                        .ModelProperty("runas", typeof(string)));
                    
                    this.RunAsName = group.Add(new VocabularyKey("RunAsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("RunAsName")
                        .ModelProperty("runasname", typeof(string)));
                    
                    this.SyncWorkflowLogOnFailure = group.Add(new VocabularyKey("SyncWorkflowLogOnFailure", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Select whether synchronous workflow failures will be saved to log files.")
                        .WithDisplayName("Log upon Failure")
                        .ModelProperty("syncworkflowlogonfailure", typeof(bool)));
                    
                    this.SyncWorkflowLogOnFailureName = group.Add(new VocabularyKey("SyncWorkflowLogOnFailureName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("SyncWorkflowLogOnFailureName")
                        .ModelProperty("syncworkflowlogonfailurename", typeof(string)));
                    
                    this.UniqueName = group.Add(new VocabularyKey("UniqueName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                        .WithDescription(@"Unique name of the process")
                        .WithDisplayName("Unique Name")
                        .ModelProperty("uniquename", typeof(string)));
                    
                    this.IsTransacted = group.Add(new VocabularyKey("IsTransacted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Whether or not the steps in the process are executed in a single transaction.")
                        .WithDisplayName("Is Transacted")
                        .ModelProperty("istransacted", typeof(bool)));
                    
                    this.IsTransactedName = group.Add(new VocabularyKey("IsTransactedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("IsTransactedName")
                        .ModelProperty("istransactedname", typeof(string)));
                    
                    this.SdkMessageId = group.Add(new VocabularyKey("SdkMessageId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the SDK Message associated with this workflow.")
                        .WithDisplayName("SDK Message")
                        .ModelProperty("sdkmessageid", typeof(string)));
                    
                    this.ProcessOrder = group.Add(new VocabularyKey("ProcessOrder", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Type the business process flow order.")
                        .WithDisplayName("Process Order")
                        .ModelProperty("processorder", typeof(long)));
                    
                    this.Mode = group.Add(new VocabularyKey("Mode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Shows the mode of the process.")
                        .WithDisplayName("Mode")
                        .ModelProperty("mode", typeof(string)));
                    
                    this.ModeName = group.Add(new VocabularyKey("ModeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("ModeName")
                        .ModelProperty("modename", typeof(string)));
                    
                    this.ProcessRoleAssignment = group.Add(new VocabularyKey("ProcessRoleAssignment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1048576))
                        .WithDescription(@"Contains the role assignment for the process.")
                        .WithDisplayName("Role assignment for Process")
                        .ModelProperty("processroleassignment", typeof(string)));
                    
                    this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                        .WithDescription(@"Version in which the form is introduced.")
                        .WithDisplayName("Introduced Version")
                        .ModelProperty("introducedversion", typeof(string)));
                    
                    this.FormId = group.Add(new VocabularyKey("FormId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the associated form.")
                        .WithDisplayName("Form ID")
                        .ModelProperty("formid", typeof(Guid)));
                    
                    this.EntityImage = group.Add(new VocabularyKey("EntityImage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Shows the default image for the record.")
                        .WithDisplayName("Default Image")
                        .ModelProperty("entityimage", typeof(string)));
                    
                    this.EntityImage_Timestamp = group.Add(new VocabularyKey("EntityImage_Timestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("EntityImage_Timestamp")
                        .ModelProperty("entityimage_timestamp", typeof(int)));
                    
                    this.EntityImage_URL = group.Add(new VocabularyKey("EntityImage_URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                        .WithDescription(@"")
                        .WithDisplayName("EntityImage_URL")
                        .ModelProperty("entityimage_url", typeof(string)));
                    
                    this.EntityImageId = group.Add(new VocabularyKey("EntityImageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"For internal use only.")
                        .WithDisplayName("Entity Image Id")
                        .ModelProperty("entityimageid", typeof(Guid)));
                    
                    this.BusinessProcessType = group.Add(new VocabularyKey("BusinessProcessType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Business Process Type.")
                        .WithDisplayName("Business Process Type")
                        .ModelProperty("businessprocesstype", typeof(string)));
                    
                    this.BusinessProcessTypeName = group.Add(new VocabularyKey("BusinessProcessTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("BusinessProcessTypeName")
                        .ModelProperty("businessprocesstypename", typeof(string)));
                    
                    this.UIFlowType = group.Add(new VocabularyKey("UIFlowType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Type of the UI Flow process.")
                        .WithDisplayName("UI Flow Type")
                        .ModelProperty("uiflowtype", typeof(string)));
                    
                    this.UIFlowTypeName = group.Add(new VocabularyKey("UIFlowTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("UIFlowTypeName")
                        .ModelProperty("uiflowtypename", typeof(string)));
                    
                    this.ProcessTriggerFormId = group.Add(new VocabularyKey("ProcessTriggerFormId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the associated form for process trigger.")
                        .WithDisplayName("ProcessTriggerFormId")
                        .ModelProperty("processtriggerformid", typeof(Guid)));
                    
                    this.ProcessTriggerScope = group.Add(new VocabularyKey("ProcessTriggerScope", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Scope of the process trigger.")
                        .WithDisplayName("ProcessTriggerScope")
                        .ModelProperty("processtriggerscope", typeof(string)));
                    
                    this.ProcessTriggerScopeName = group.Add(new VocabularyKey("ProcessTriggerScopeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"")
                        .WithDisplayName("ProcessTriggerScopeName")
                        .ModelProperty("processtriggerscopename", typeof(string)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey OnDemand { get; private set; }
        
        public VocabularyKey PluginTypeId { get; private set; }
        
        public VocabularyKey CreatedOn { get; private set; }
        
        public VocabularyKey Type { get; private set; }
        
        public VocabularyKey WorkflowId { get; private set; }
        
        public VocabularyKey ActiveWorkflowId { get; private set; }
        
        public VocabularyKey ParentWorkflowId { get; private set; }
        
        public VocabularyKey UIData { get; private set; }
        
        public VocabularyKey PrimaryEntity { get; private set; }
        
        public VocabularyKey OwnerId { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey AsyncAutoDelete { get; private set; }
        
        public VocabularyKey IsCrmUIWorkflow { get; private set; }
        
        public VocabularyKey Subprocess { get; private set; }
        
        public VocabularyKey Scope { get; private set; }
        
        public VocabularyKey StatusCode { get; private set; }
        
        public VocabularyKey ModifiedBy { get; private set; }
        
        public VocabularyKey Description { get; private set; }
        
        public VocabularyKey CreatedBy { get; private set; }
        
        public VocabularyKey Name { get; private set; }
        
        public VocabularyKey OwningBusinessUnit { get; private set; }
        
        public VocabularyKey StateCode { get; private set; }
        
        public VocabularyKey OwningUser { get; private set; }
        
        public VocabularyKey OwnerIdType { get; private set; }
        
        public VocabularyKey ScopeName { get; private set; }
        
        public VocabularyKey ParentWorkflowIdName { get; private set; }
        
        public VocabularyKey StateCodeName { get; private set; }
        
        public VocabularyKey TypeName { get; private set; }
        
        public VocabularyKey ActiveWorkflowIdName { get; private set; }
        
        public VocabularyKey ModifiedByName { get; private set; }
        
        public VocabularyKey OwningBusinessUnitName { get; private set; }
        
        public VocabularyKey StatusCodeName { get; private set; }
        
        public VocabularyKey PrimaryEntityName { get; private set; }
        
        public VocabularyKey OwnerIdName { get; private set; }
        
        public VocabularyKey CreatedByName { get; private set; }
        
        public VocabularyKey CreatedByYomiName { get; private set; }
        
        public VocabularyKey ModifiedByYomiName { get; private set; }
        
        public VocabularyKey OwnerIdYomiName { get; private set; }
        
        public VocabularyKey WorkflowIdUnique { get; private set; }
        
        public VocabularyKey SupportingSolutionId { get; private set; }
        
        public VocabularyKey SolutionId { get; private set; }
        
        public VocabularyKey OverwriteTime { get; private set; }
        
        public VocabularyKey ComponentState { get; private set; }
        
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByName { get; private set; }
        
        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByName { get; private set; }
        
        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }
        
        public VocabularyKey Xaml { get; private set; }
        
        public VocabularyKey TriggerOnDelete { get; private set; }
        
        public VocabularyKey RendererObjectTypeCode { get; private set; }
        
        public VocabularyKey TriggerOnCreate { get; private set; }
        
        public VocabularyKey TriggerOnUpdateAttributeList { get; private set; }
        
        public VocabularyKey OwningTeam { get; private set; }
        
        public VocabularyKey Category { get; private set; }
        
        public VocabularyKey LanguageCode { get; private set; }
        
        public VocabularyKey CategoryName { get; private set; }
        
        public VocabularyKey IsManaged { get; private set; }
        
        public VocabularyKey IsCustomizable { get; private set; }
        
        public VocabularyKey IsManagedName { get; private set; }
        
        public VocabularyKey InputParameters { get; private set; }
        
        public VocabularyKey AsyncAutoDeleteName { get; private set; }
        
        public VocabularyKey OnDemandName { get; private set; }
        
        public VocabularyKey SubprocessName { get; private set; }
        
        public VocabularyKey TriggerOnCreateName { get; private set; }
        
        public VocabularyKey TriggerOnDeleteName { get; private set; }
        
        public VocabularyKey ClientData { get; private set; }
        
        public VocabularyKey VersionNumber { get; private set; }
        
        public VocabularyKey CreateStage { get; private set; }
        
        public VocabularyKey UpdateStage { get; private set; }
        
        public VocabularyKey DeleteStage { get; private set; }
        
        public VocabularyKey CreateStageName { get; private set; }
        
        public VocabularyKey UpdateStageName { get; private set; }
        
        public VocabularyKey DeleteStageName { get; private set; }
        
        public VocabularyKey Rank { get; private set; }
        
        public VocabularyKey RunAs { get; private set; }
        
        public VocabularyKey RunAsName { get; private set; }
        
        public VocabularyKey SyncWorkflowLogOnFailure { get; private set; }
        
        public VocabularyKey SyncWorkflowLogOnFailureName { get; private set; }
        
        public VocabularyKey UniqueName { get; private set; }
        
        public VocabularyKey IsTransacted { get; private set; }
        
        public VocabularyKey IsTransactedName { get; private set; }
        
        public VocabularyKey SdkMessageId { get; private set; }
        
        public VocabularyKey ProcessOrder { get; private set; }
        
        public VocabularyKey Mode { get; private set; }
        
        public VocabularyKey ModeName { get; private set; }
        
        public VocabularyKey ProcessRoleAssignment { get; private set; }
        
        public VocabularyKey IntroducedVersion { get; private set; }
        
        public VocabularyKey FormId { get; private set; }
        
        public VocabularyKey EntityImage { get; private set; }
        
        public VocabularyKey EntityImage_Timestamp { get; private set; }
        
        public VocabularyKey EntityImage_URL { get; private set; }
        
        public VocabularyKey EntityImageId { get; private set; }
        
        public VocabularyKey BusinessProcessType { get; private set; }
        
        public VocabularyKey BusinessProcessTypeName { get; private set; }
        
        public VocabularyKey UIFlowType { get; private set; }
        
        public VocabularyKey UIFlowTypeName { get; private set; }
        
        public VocabularyKey ProcessTriggerFormId { get; private set; }
        
        public VocabularyKey ProcessTriggerScope { get; private set; }
        
        public VocabularyKey ProcessTriggerScopeName { get; private set; }
        
        
        }
    }
    
