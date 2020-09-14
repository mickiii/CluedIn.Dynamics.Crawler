using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class PluginTraceLogVocabulary : SimpleVocabulary
    {
        public PluginTraceLogVocabulary()
        {
            VocabularyName = "Dynamics365 PluginTraceLog";
            KeyPrefix = "dynamics365.plugintracelog";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("PluginTraceLog", group =>
            {
                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the record.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdby", typeof(string)));

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

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the record.")
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

                this.PluginTraceLogId = group.Add(new VocabularyKey("PluginTraceLogId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for an entity instance.")
                    .WithDisplayName("Plug-in Trace Log")
                    .ModelProperty("plugintracelogid", typeof(Guid)));

                this.Configuration = group.Add(new VocabularyKey("Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Unsecured configuration for the plug-in trace log.")
                    .WithDisplayName("Configuration")
                    .ModelProperty("configuration", typeof(string)));

                this.MessageName = group.Add(new VocabularyKey("MessageName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1024))
                    .WithDescription(@"Name of the message that triggered this plug-in.")
                    .WithDisplayName("Message Name")
                    .ModelProperty("messagename", typeof(string)));

                this.Depth = group.Add(new VocabularyKey("Depth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Depth of execution of the plug-in or custom workflow activity.")
                    .WithDisplayName("Depth")
                    .ModelProperty("depth", typeof(long)));

                this.Mode = group.Add(new VocabularyKey("Mode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of execution.")
                    .WithDisplayName("Mode")
                    .ModelProperty("mode", typeof(string)));

                this.ModeName = group.Add(new VocabularyKey("ModeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ModeName")
                    .ModelProperty("modename", typeof(string)));

                this.OperationType = group.Add(new VocabularyKey("OperationType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of custom code.")
                    .WithDisplayName("Operation Type")
                    .ModelProperty("operationtype", typeof(string)));

                this.OperationTypeName = group.Add(new VocabularyKey("OperationTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OperationTypeName")
                    .ModelProperty("operationtypename", typeof(string)));

                this.PerformanceConstructorDuration = group.Add(new VocabularyKey("PerformanceConstructorDuration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Time, in milliseconds, to construct.")
                    .WithDisplayName("Constructor Duration")
                    .ModelProperty("performanceconstructorduration", typeof(long)));

                this.PerformanceConstructorStartTime = group.Add(new VocabularyKey("PerformanceConstructorStartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when constructed.")
                    .WithDisplayName("Constructor Start Time")
                    .ModelProperty("performanceconstructorstarttime", typeof(DateTime)));

                this.PerformanceExecutionDuration = group.Add(new VocabularyKey("PerformanceExecutionDuration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Time, in milliseconds, to execute the request.")
                    .WithDisplayName("Execution Duration")
                    .ModelProperty("performanceexecutionduration", typeof(long)));

                this.PerformanceExecutionStartTime = group.Add(new VocabularyKey("PerformanceExecutionStartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Time, in milliseconds, to execute the request.")
                    .WithDisplayName("Execution Start Time")
                    .ModelProperty("performanceexecutionstarttime", typeof(DateTime)));

                this.PersistenceKey = group.Add(new VocabularyKey("PersistenceKey", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Asynchronous workflow persistence key.")
                    .WithDisplayName("Persistence Key")
                    .ModelProperty("persistencekey", typeof(Guid)));

                this.PrimaryEntity = group.Add(new VocabularyKey("PrimaryEntity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1000))
                    .WithDescription(@"Entity, if any, that the plug-in is executed against.")
                    .WithDisplayName("Primary Entity")
                    .ModelProperty("primaryentity", typeof(string)));

                this.Profile = group.Add(new VocabularyKey("Profile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Plug-in profile formatted as serialized text.")
                    .WithDisplayName("Profile")
                    .ModelProperty("profile", typeof(string)));

                this.RequestId = group.Add(new VocabularyKey("RequestId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the message request.")
                    .WithDisplayName("Request ID")
                    .ModelProperty("requestid", typeof(Guid)));

                this.SecureConfiguration = group.Add(new VocabularyKey("SecureConfiguration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Secured configuration for the plug-in trace log.")
                    .WithDisplayName("Secure Configuration")
                    .ModelProperty("secureconfiguration", typeof(string)));

                this.TypeName = group.Add(new VocabularyKey("TypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1024))
                    .WithDescription(@"Class name of the plug-in.")
                    .WithDisplayName("Type Name")
                    .ModelProperty("typename", typeof(string)));

                this.PluginStepId = group.Add(new VocabularyKey("PluginStepId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"ID of the plug-in registration step.")
                    .WithDisplayName("Plugin Step ID")
                    .ModelProperty("pluginstepid", typeof(Guid)));

                this.MessageBlock = group.Add(new VocabularyKey("MessageBlock", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Trace text from the plug-in.")
                    .WithDisplayName("Message Block")
                    .ModelProperty("messageblock", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the organization.")
                    .WithDisplayName("Organization Id")
                    .ModelProperty("organizationid", typeof(Guid)));

                this.ExceptionDetails = group.Add(new VocabularyKey("ExceptionDetails", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Details of the exception.")
                    .WithDisplayName("Exception Details")
                    .ModelProperty("exceptiondetails", typeof(string)));

                this.CorrelationId = group.Add(new VocabularyKey("CorrelationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for tracking plug-in or custom workflow activity execution.")
                    .WithDisplayName("Correlation Id")
                    .ModelProperty("correlationid", typeof(Guid)));

                this.IsSystemCreated = group.Add(new VocabularyKey("IsSystemCreated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Where the event originated. Set to true if it's a system trace; otherwise, false.")
                    .WithDisplayName("System Created")
                    .ModelProperty("issystemcreated", typeof(bool)));

                this.IsSystemCreatedName = group.Add(new VocabularyKey("IsSystemCreatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsSystemCreatedName")
                    .ModelProperty("issystemcreatedname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey PluginTraceLogId { get; private set; }

        public VocabularyKey Configuration { get; private set; }

        public VocabularyKey MessageName { get; private set; }

        public VocabularyKey Depth { get; private set; }

        public VocabularyKey Mode { get; private set; }

        public VocabularyKey ModeName { get; private set; }

        public VocabularyKey OperationType { get; private set; }

        public VocabularyKey OperationTypeName { get; private set; }

        public VocabularyKey PerformanceConstructorDuration { get; private set; }

        public VocabularyKey PerformanceConstructorStartTime { get; private set; }

        public VocabularyKey PerformanceExecutionDuration { get; private set; }

        public VocabularyKey PerformanceExecutionStartTime { get; private set; }

        public VocabularyKey PersistenceKey { get; private set; }

        public VocabularyKey PrimaryEntity { get; private set; }

        public VocabularyKey Profile { get; private set; }

        public VocabularyKey RequestId { get; private set; }

        public VocabularyKey SecureConfiguration { get; private set; }

        public VocabularyKey TypeName { get; private set; }

        public VocabularyKey PluginStepId { get; private set; }

        public VocabularyKey MessageBlock { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey ExceptionDetails { get; private set; }

        public VocabularyKey CorrelationId { get; private set; }

        public VocabularyKey IsSystemCreated { get; private set; }

        public VocabularyKey IsSystemCreatedName { get; private set; }


    }
}

