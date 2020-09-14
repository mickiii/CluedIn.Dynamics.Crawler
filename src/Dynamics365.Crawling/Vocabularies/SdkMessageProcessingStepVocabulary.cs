using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SdkMessageProcessingStepVocabulary : SimpleVocabulary
    {
        public SdkMessageProcessingStepVocabulary()
        {
            VocabularyName = "Dynamics365 SdkMessageProcessingStep";
            KeyPrefix = "dynamics365.sdkmessageprocessingstep";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SdkMessageProcessingStep", group =>
            {
                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the SDK message processing step was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.Configuration = group.Add(new VocabularyKey("Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Step-specific configuration for the plug-in type. Passed to the plug-in constructor at run time.")
                    .WithDisplayName("Configuration")
                    .ModelProperty("configuration", typeof(string)));

                this.SupportedDeployment = group.Add(new VocabularyKey("SupportedDeployment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Deployment that the SDK message processing step should be executed on; server, client, or both.")
                    .WithDisplayName("Deployment")
                    .ModelProperty("supporteddeployment", typeof(string)));

                this.PluginTypeId = group.Add(new VocabularyKey("PluginTypeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the plug-in type associated with the step.")
                    .WithDisplayName("Plug-In Type")
                    .ModelProperty("plugintypeid", typeof(string)));

                this.Rank = group.Add(new VocabularyKey("Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Processing order within the stage.")
                    .WithDisplayName("Execution Order")
                    .ModelProperty("rank", typeof(long)));

                this.SdkMessageId = group.Add(new VocabularyKey("SdkMessageId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the SDK message.")
                    .WithDisplayName("SDK Message")
                    .ModelProperty("sdkmessageid", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the SDK message processing step was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.SdkMessageProcessingStepId = group.Add(new VocabularyKey("SdkMessageProcessingStepId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the SDK message processing step entity.")
                    .WithDisplayName("SdkMessageProcessingStepId")
                    .ModelProperty("sdkmessageprocessingstepid", typeof(Guid)));

                this.Stage = group.Add(new VocabularyKey("Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Stage in the execution pipeline that the SDK message processing step is in.")
                    .WithDisplayName("Execution Stage")
                    .ModelProperty("stage", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the SDK message processing step.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization with which the SDK message processing step is associated.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.SdkMessageProcessingStepIdUnique = group.Add(new VocabularyKey("SdkMessageProcessingStepIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the SDK message processing step.")
                    .WithDisplayName("SdkMessageProcessingStepIdUnique")
                    .ModelProperty("sdkmessageprocessingstepidunique", typeof(Guid)));

                this.FilteringAttributes = group.Add(new VocabularyKey("FilteringAttributes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100000))
                    .WithDescription(@"Comma-separated list of attributes. If at least one of these attributes is modified, the plug-in should execute.")
                    .WithDisplayName("Filtering Attributes")
                    .ModelProperty("filteringattributes", typeof(string)));

                this.CustomizationLevel = group.Add(new VocabularyKey("CustomizationLevel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Customization level of the SDK message processing step.")
                    .WithDisplayName("CustomizationLevel")
                    .ModelProperty("customizationlevel", typeof(long)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the SDK message processing step.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Status of the SDK message processing step.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.SdkMessageProcessingStepSecureConfigId = group.Add(new VocabularyKey("SdkMessageProcessingStepSecureConfigId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the Sdk message processing step secure configuration.")
                    .WithDisplayName("SDK Message Processing Step Secure Configuration")
                    .ModelProperty("sdkmessageprocessingstepsecureconfigid", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Description of the SDK message processing step.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Number that identifies a specific revision of the SDK message processing step. ")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Mode = group.Add(new VocabularyKey("Mode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Run-time mode of execution, for example, synchronous or asynchronous.")
                    .WithDisplayName("Execution Mode")
                    .ModelProperty("mode", typeof(string)));

                this.SdkMessageFilterId = group.Add(new VocabularyKey("SdkMessageFilterId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the SDK message filter.")
                    .WithDisplayName("SdkMessage Filter")
                    .ModelProperty("sdkmessagefilterid", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Reason for the status of the SDK message processing step.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.ImpersonatingUserId = group.Add(new VocabularyKey("ImpersonatingUserId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the user to impersonate context when step is executed.")
                    .WithDisplayName("Impersonating User")
                    .ModelProperty("impersonatinguserid", typeof(string)));

                this.InvocationSource = group.Add(new VocabularyKey("InvocationSource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Identifies if a plug-in should be executed from a parent pipeline, a child pipeline, or both.")
                    .WithDisplayName("Invocation Source")
                    .ModelProperty("invocationsource", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.StageName = group.Add(new VocabularyKey("StageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StageName")
                    .ModelProperty("stagename", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.SupportedDeploymentName = group.Add(new VocabularyKey("SupportedDeploymentName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SupportedDeploymentName")
                    .ModelProperty("supporteddeploymentname", typeof(string)));

                this.ModeName = group.Add(new VocabularyKey("ModeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ModeName")
                    .ModelProperty("modename", typeof(string)));

                this.InvocationSourceName = group.Add(new VocabularyKey("InvocationSourceName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("InvocationSourceName")
                    .ModelProperty("invocationsourcename", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who last modified the sdkmessageprocessingstep.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the sdkmessageprocessingstep.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.AsyncAutoDelete = group.Add(new VocabularyKey("AsyncAutoDelete", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether the asynchronous system job is automatically deleted on completion.")
                    .WithDisplayName("Asynchronous Automatic Delete")
                    .ModelProperty("asyncautodelete", typeof(bool)));

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

                this.EventHandler = group.Add(new VocabularyKey("EventHandler", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the associated event handler.")
                    .WithDisplayName("Event Handler")
                    .ModelProperty("eventhandler", typeof(string)));

                this.EventHandlerTypeCode = group.Add(new VocabularyKey("EventHandlerTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("EventHandlerTypeCode")
                    .ModelProperty("eventhandlertypecode", typeof(string)));

                this.EventHandlerName = group.Add(new VocabularyKey("EventHandlerName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("EventHandlerName")
                    .ModelProperty("eventhandlername", typeof(string)));

                this.AsyncAutoDeleteName = group.Add(new VocabularyKey("AsyncAutoDeleteName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Async Auto Delete Name")
                    .ModelProperty("asyncautodeletename", typeof(string)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ImpersonatingUserIdName = group.Add(new VocabularyKey("ImpersonatingUserIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ImpersonatingUserIdName")
                    .ModelProperty("impersonatinguseridname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.PluginTypeIdName = group.Add(new VocabularyKey("PluginTypeIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("PluginTypeIdName")
                    .ModelProperty("plugintypeidname", typeof(string)));

                this.SdkMessageIdName = group.Add(new VocabularyKey("SdkMessageIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SdkMessageIdName")
                    .ModelProperty("sdkmessageidname", typeof(string)));

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

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information that specifies whether this component is managed.")
                    .WithDisplayName("State")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Name of SdkMessage processing step.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.IsCustomizable = group.Add(new VocabularyKey("IsCustomizable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component can be customized.")
                    .WithDisplayName("Customizable")
                    .ModelProperty("iscustomizable", typeof(string)));

                this.IsHidden = group.Add(new VocabularyKey("IsHidden", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component should be hidden.")
                    .WithDisplayName("Hidden")
                    .ModelProperty("ishidden", typeof(string)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the form is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.CanUseReadOnlyConnection = group.Add(new VocabularyKey("CanUseReadOnlyConnection", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Identifies whether a SDK Message Processing Step type will be ReadOnly or Read Write. false - ReadWrite, true - ReadOnly ")
                    .WithDisplayName("Intent")
                    .ModelProperty("canusereadonlyconnection", typeof(bool)));

                this.CanUseReadOnlyConnectionName = group.Add(new VocabularyKey("CanUseReadOnlyConnectionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanUseReadOnlyConnectionName")
                    .ModelProperty("canusereadonlyconnectionname", typeof(string)));

                this.EventExpander = group.Add(new VocabularyKey("EventExpander", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Configuration for sending pipeline events to the Event Expander service.")
                    .WithDisplayName("EventExpander")
                    .ModelProperty("eventexpander", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey Configuration { get; private set; }

        public VocabularyKey SupportedDeployment { get; private set; }

        public VocabularyKey PluginTypeId { get; private set; }

        public VocabularyKey Rank { get; private set; }

        public VocabularyKey SdkMessageId { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey SdkMessageProcessingStepId { get; private set; }

        public VocabularyKey Stage { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey SdkMessageProcessingStepIdUnique { get; private set; }

        public VocabularyKey FilteringAttributes { get; private set; }

        public VocabularyKey CustomizationLevel { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey SdkMessageProcessingStepSecureConfigId { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Mode { get; private set; }

        public VocabularyKey SdkMessageFilterId { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey ImpersonatingUserId { get; private set; }

        public VocabularyKey InvocationSource { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey StageName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey SupportedDeploymentName { get; private set; }

        public VocabularyKey ModeName { get; private set; }

        public VocabularyKey InvocationSourceName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey AsyncAutoDelete { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey EventHandler { get; private set; }

        public VocabularyKey EventHandlerTypeCode { get; private set; }

        public VocabularyKey EventHandlerName { get; private set; }

        public VocabularyKey AsyncAutoDeleteName { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ImpersonatingUserIdName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey PluginTypeIdName { get; private set; }

        public VocabularyKey SdkMessageIdName { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey IsCustomizable { get; private set; }

        public VocabularyKey IsHidden { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey CanUseReadOnlyConnection { get; private set; }

        public VocabularyKey CanUseReadOnlyConnectionName { get; private set; }

        public VocabularyKey EventExpander { get; private set; }


    }
}

