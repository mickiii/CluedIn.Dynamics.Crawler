using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class TopicModelConfigurationVocabulary : SimpleVocabulary
    {
        public TopicModelConfigurationVocabulary()
        {
            VocabularyName = "Dynamics365 TopicModelConfiguration";
            KeyPrefix = "dynamics365.topicmodelconfiguration";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("TopicModelConfiguration", group =>
            {
                this.TopicModelConfigurationId = group.Add(new VocabularyKey("TopicModelConfigurationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("TopicModelConfiguration")
                    .ModelProperty("topicmodelconfigurationid", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a logical name for the model.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Enter a description for the model")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.NgramSize = group.Add(new VocabularyKey("NgramSize", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the maximum number of key phrase words to use in a topic.")
                    .WithDisplayName("Maximum Key Phrase Words")
                    .ModelProperty("ngramsize", typeof(long)));

                this.MinRelevanceScore = group.Add(new VocabularyKey("MinRelevanceScore", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the minimum relevance score of a topic.")
                    .WithDisplayName("Minimum Relevance Score")
                    .ModelProperty("minrelevancescore", typeof(decimal)));

                this.StopWords = group.Add(new VocabularyKey("StopWords", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                    .WithDescription(@"Stop words.")
                    .WithDisplayName("Stop Words")
                    .ModelProperty("stopwords", typeof(string)));

                this.TopicModelId = group.Add(new VocabularyKey("TopicModelId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"topicmodel_topicmodelconfiguration")
                    .WithDisplayName("TopicModelId")
                    .ModelProperty("topicmodelid", typeof(string)));

                this.TopicModelIdName = group.Add(new VocabularyKey("TopicModelIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TopicModelIdName")
                    .ModelProperty("topicmodelidname", typeof(string)));

                this.TimeFilter = group.Add(new VocabularyKey("TimeFilter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the time window to filter on for the last number of days or weeks.")
                    .WithDisplayName("Time Window Filter")
                    .ModelProperty("timefilter", typeof(string)));

                this.DataFilter = group.Add(new VocabularyKey("DataFilter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Specify the data filter configured to filter records.")
                    .WithDisplayName("Data Filter")
                    .ModelProperty("datafilter", typeof(string)));

                this.SourceEntity = group.Add(new VocabularyKey("SourceEntity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of entity with which the topic model configuration is associated.")
                    .WithDisplayName("Source Entity")
                    .ModelProperty("sourceentity", typeof(string)));

                this.SourceEntityName = group.Add(new VocabularyKey("SourceEntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SourceEntityName")
                    .ModelProperty("sourceentityname", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"organization_topicmodelconfiguration")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.FetchXmlList = group.Add(new VocabularyKey("FetchXmlList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500000))
                    .WithDescription(@"Fetch Xml")
                    .WithDisplayName("Fetch Xml")
                    .ModelProperty("fetchxmllist", typeof(string)));

                this.TimeFilterName = group.Add(new VocabularyKey("TimeFilterName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TimeFilterName")
                    .ModelProperty("timefiltername", typeof(string)));

                this.TimeFilterDuration = group.Add(new VocabularyKey("TimeFilterDuration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time Filter Duration")
                    .WithDisplayName("Time Filter Duration")
                    .ModelProperty("timefilterduration", typeof(long)));

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

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Is Manageed")
                    .WithDisplayName("State")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.TopicModelConfigurationIdUnique = group.Add(new VocabularyKey("TopicModelConfigurationIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the Topic Model Configuration used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook")
                    .WithDisplayName("Topic Model Configuration Unique Id")
                    .ModelProperty("topicmodelconfigurationidunique", typeof(Guid)));

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

                this.componentstateName = group.Add(new VocabularyKey("componentstateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("componentstateName")
                    .ModelProperty("componentstatename", typeof(string)));

                this.ismanagedName = group.Add(new VocabularyKey("ismanagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ismanagedName")
                    .ModelProperty("ismanagedname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey TopicModelConfigurationId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey NgramSize { get; private set; }

        public VocabularyKey MinRelevanceScore { get; private set; }

        public VocabularyKey StopWords { get; private set; }

        public VocabularyKey TopicModelId { get; private set; }

        public VocabularyKey TopicModelIdName { get; private set; }

        public VocabularyKey TimeFilter { get; private set; }

        public VocabularyKey DataFilter { get; private set; }

        public VocabularyKey SourceEntity { get; private set; }

        public VocabularyKey SourceEntityName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey FetchXmlList { get; private set; }

        public VocabularyKey TimeFilterName { get; private set; }

        public VocabularyKey TimeFilterDuration { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey TopicModelConfigurationIdUnique { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey componentstateName { get; private set; }

        public VocabularyKey ismanagedName { get; private set; }


    }
}

