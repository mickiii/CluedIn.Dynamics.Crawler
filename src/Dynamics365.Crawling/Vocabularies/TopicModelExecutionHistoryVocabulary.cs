using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class TopicModelExecutionHistoryVocabulary : SimpleVocabulary
    {
        public TopicModelExecutionHistoryVocabulary()
        {
            VocabularyName = "Dynamics365 TopicModelExecutionHistory";
            KeyPrefix = "dynamics365.topicmodelexecutionhistory";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("TopicModelExecutionHistory", group =>
            {
                this.TopicModelExecutionHistoryId = group.Add(new VocabularyKey("TopicModelExecutionHistoryId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("TopicModelExecutionHistory")
                    .ModelProperty("topicmodelexecutionhistoryid", typeof(Guid)));

                this.TopicModelId = group.Add(new VocabularyKey("TopicModelId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"topicmodel_topicmodelexecutionhistory")
                    .WithDisplayName("TopicModelId")
                    .ModelProperty("topicmodelid", typeof(string)));

                this.TopicModelIdName = group.Add(new VocabularyKey("TopicModelIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TopicModelIdName")
                    .ModelProperty("topicmodelidname", typeof(string)));

                this.TopicModelConfigurationId = group.Add(new VocabularyKey("TopicModelConfigurationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"topicmodelconfiguration_topicmodelexecutionhistory")
                    .WithDisplayName("Topic Model Configuration")
                    .ModelProperty("topicmodelconfigurationid", typeof(string)));

                this.TopicModelConfigurationIdName = group.Add(new VocabularyKey("TopicModelConfigurationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TopicModelConfigurationIdName")
                    .ModelProperty("topicmodelconfigurationidname", typeof(string)));

                this.RecordsProcessed = group.Add(new VocabularyKey("RecordsProcessed", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of Records Synchronized")
                    .WithDisplayName("Number of Records Synchronized")
                    .ModelProperty("recordsprocessed", typeof(long)));

                this.TotalTime = group.Add(new VocabularyKey("TotalTime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Duration (in mins)")
                    .WithDisplayName("Duration (in mins)")
                    .ModelProperty("totaltime", typeof(long)));

                this.NumberOfTopicsFound = group.Add(new VocabularyKey("NumberOfTopicsFound", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of Topics Identified")
                    .WithDisplayName("Number of Topics Identified")
                    .ModelProperty("numberoftopicsfound", typeof(long)));

                this.StartTime = group.Add(new VocabularyKey("StartTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"StartTime")
                    .WithDisplayName("Start Time")
                    .ModelProperty("starttime", typeof(DateTime)));

                this.IsTestExecution = group.Add(new VocabularyKey("IsTestExecution", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Allow model to check is test executed.")
                    .WithDisplayName("Test Execution")
                    .ModelProperty("istestexecution", typeof(bool)));

                this.IsTestExecutionName = group.Add(new VocabularyKey("IsTestExecutionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsTestExecutionName")
                    .ModelProperty("istestexecutionname", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"organization_topicmodelexecutionhistory")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.Status = group.Add(new VocabularyKey("Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Status")
                    .WithDisplayName("Status")
                    .ModelProperty("status", typeof(string)));

                this.StatusName = group.Add(new VocabularyKey("StatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusName")
                    .ModelProperty("statusname", typeof(string)));

                this.StatusReason = group.Add(new VocabularyKey("StatusReason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"StatusReason")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statusreason", typeof(string)));

                this.StatusReasonName = group.Add(new VocabularyKey("StatusReasonName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusReasonName")
                    .ModelProperty("statusreasonname", typeof(string)));

                this.FetchXmlList = group.Add(new VocabularyKey("FetchXmlList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500000))
                    .WithDescription(@"Fetch Xml")
                    .WithDisplayName("Fetch Xml")
                    .ModelProperty("fetchxmllist", typeof(string)));

                this.MaxTopics = group.Add(new VocabularyKey("MaxTopics", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Maximum number of Topics.")
                    .WithDisplayName("Max Topics")
                    .ModelProperty("maxtopics", typeof(long)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_topicmodelexecutionhistory_createdby")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the topic model execution history was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_topicmodelexecutionhistory_createdonbehalfby")
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

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_topicmodelexecutionhistory_modifiedby")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the topic model execution history was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"lk_topicmodelexecutionhistory_modifiedonbehalfby")
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

                this.ErrorDetails = group.Add(new VocabularyKey("ErrorDetails", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Detailed error message for the Topic Analysis process")
                    .WithDisplayName("Error Details")
                    .ModelProperty("azuresyncerrormessage", typeof(string)));

                this.RecordCorrelationId = group.Add(new VocabularyKey("RecordCorrelationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Record Correlation Id.")
                    .WithDisplayName("Record Correlation Id")
                    .ModelProperty("recordcorrelationid", typeof(string)));

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

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version Number")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Sequence number of the import that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

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

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"name")
                    .WithDisplayName("name")
                    .ModelProperty("name", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey TopicModelExecutionHistoryId { get; private set; }

        public VocabularyKey TopicModelId { get; private set; }

        public VocabularyKey TopicModelIdName { get; private set; }

        public VocabularyKey TopicModelConfigurationId { get; private set; }

        public VocabularyKey TopicModelConfigurationIdName { get; private set; }

        public VocabularyKey RecordsProcessed { get; private set; }

        public VocabularyKey TotalTime { get; private set; }

        public VocabularyKey NumberOfTopicsFound { get; private set; }

        public VocabularyKey StartTime { get; private set; }

        public VocabularyKey IsTestExecution { get; private set; }

        public VocabularyKey IsTestExecutionName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey Status { get; private set; }

        public VocabularyKey StatusName { get; private set; }

        public VocabularyKey StatusReason { get; private set; }

        public VocabularyKey StatusReasonName { get; private set; }

        public VocabularyKey FetchXmlList { get; private set; }

        public VocabularyKey MaxTopics { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ErrorDetails { get; private set; }

        public VocabularyKey RecordCorrelationId { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey Name { get; private set; }


    }
}

