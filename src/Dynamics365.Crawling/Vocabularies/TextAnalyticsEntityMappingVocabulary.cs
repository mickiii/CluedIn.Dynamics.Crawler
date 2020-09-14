using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class TextAnalyticsEntityMappingVocabulary : SimpleVocabulary
    {
        public TextAnalyticsEntityMappingVocabulary()
        {
            VocabularyName = "Dynamics365 TextAnalyticsEntityMapping";
            KeyPrefix = "dynamics365.textanalyticsentitymapping";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("TextAnalyticsEntityMapping", group =>
            {
                this.TextAnalyticsEntityMappingId = group.Add(new VocabularyKey("TextAnalyticsEntityMappingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("Text Analytics Entity Mapping")
                    .ModelProperty("textanalyticsentitymappingid", typeof(Guid)));

                this.TopicModelConfigurationId = group.Add(new VocabularyKey("TopicModelConfigurationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"topicmodelconfiguration_textanalyticsentitymapping")
                    .WithDisplayName("Topic Model Configuration Id")
                    .ModelProperty("topicmodelconfigurationid", typeof(string)));

                this.TopicModelConfigurationIdName = group.Add(new VocabularyKey("TopicModelConfigurationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TopicModelConfigurationIdName")
                    .ModelProperty("topicmodelconfigurationidname", typeof(string)));

                this.Entity = group.Add(new VocabularyKey("Entity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Entity")
                    .WithDisplayName("Entity")
                    .ModelProperty("entity", typeof(string)));

                this.Field = group.Add(new VocabularyKey("Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Field")
                    .WithDisplayName("Field")
                    .ModelProperty("field", typeof(string)));

                this.RelationshipName = group.Add(new VocabularyKey("RelationshipName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Relationship Name")
                    .WithDisplayName("Relationship Name")
                    .ModelProperty("relationshipname", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the Text Analytics Entity Mapping.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.KnowledgeSearchModelId = group.Add(new VocabularyKey("KnowledgeSearchModelId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Knowledge Search Model associated with entity mapping.")
                    .WithDisplayName("Knowledge Search Model Id")
                    .ModelProperty("knowledgesearchmodelid", typeof(string)));

                this.KnowledgeSearchModelIdName = group.Add(new VocabularyKey("KnowledgeSearchModelIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("KnowledgeSearchModelIdName")
                    .ModelProperty("knowledgesearchmodelidname", typeof(string)));

                this.ModelType = group.Add(new VocabularyKey("ModelType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Model Type.")
                    .WithDisplayName("Model Type")
                    .ModelProperty("modeltype", typeof(long)));

                this.SimilarityRuleId = group.Add(new VocabularyKey("SimilarityRuleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Similarity Rule associated with entity mapping.")
                    .WithDisplayName("Similarity Rule Id")
                    .ModelProperty("similarityruleid", typeof(string)));

                this.SimilarityRuleIdName = group.Add(new VocabularyKey("SimilarityRuleIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SimilarityRuleIdName")
                    .ModelProperty("similarityruleidname", typeof(string)));

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

                this.TextAnalyticsEntityMappingIdUnique = group.Add(new VocabularyKey("TextAnalyticsEntityMappingIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the Text Analytics Entity Mapping")
                    .WithDisplayName("Text Analytics Entity Mapping Unique Id")
                    .ModelProperty("textanalyticsentitymappingidunique", typeof(Guid)));

                this.EntityPickList = group.Add(new VocabularyKey("EntityPickList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select Entity")
                    .WithDisplayName("Entity")
                    .ModelProperty("entitypicklist", typeof(string)));

                this.EntityPickListName = group.Add(new VocabularyKey("EntityPickListName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityPickListName")
                    .ModelProperty("entitypicklistname", typeof(string)));

                this.FieldPickList = group.Add(new VocabularyKey("FieldPickList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select Field")
                    .WithDisplayName("Field")
                    .ModelProperty("fieldpicklist", typeof(string)));

                this.FieldPickListName = group.Add(new VocabularyKey("FieldPickListName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FieldPickListName")
                    .ModelProperty("fieldpicklistname", typeof(string)));

                this.EntityDisplayName = group.Add(new VocabularyKey("EntityDisplayName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Entity Display Name")
                    .WithDisplayName("Entity Name")
                    .ModelProperty("entitydisplayname", typeof(string)));

                this.FieldDisplayName = group.Add(new VocabularyKey("FieldDisplayName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Field Display Name")
                    .WithDisplayName("Field Name")
                    .ModelProperty("fielddisplayname", typeof(string)));

                this.AdvancedSimilarityRuleId = group.Add(new VocabularyKey("AdvancedSimilarityRuleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Advanced Similarity RuleId associated with entity mapping.")
                    .WithDisplayName("Advanced Similarity RuleId")
                    .ModelProperty("advancedsimilarityruleid", typeof(string)));

                this.AdvancedSimilarityRuleIdName = group.Add(new VocabularyKey("AdvancedSimilarityRuleIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AdvancedSimilarityRuleIdName")
                    .ModelProperty("advancedsimilarityruleidname", typeof(string)));

                this.IsTextMatchMapping = group.Add(new VocabularyKey("IsTextMatchMapping", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Specify if the mapping is for text match or exact match")
                    .WithDisplayName("Criteria")
                    .ModelProperty("istextmatchmapping", typeof(bool)));

                this.IsTextMatchMappingName = group.Add(new VocabularyKey("IsTextMatchMappingName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsTextMatchMappingName")
                    .ModelProperty("istextmatchmappingname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey TextAnalyticsEntityMappingId { get; private set; }

        public VocabularyKey TopicModelConfigurationId { get; private set; }

        public VocabularyKey TopicModelConfigurationIdName { get; private set; }

        public VocabularyKey Entity { get; private set; }

        public VocabularyKey Field { get; private set; }

        public VocabularyKey RelationshipName { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey KnowledgeSearchModelId { get; private set; }

        public VocabularyKey KnowledgeSearchModelIdName { get; private set; }

        public VocabularyKey ModelType { get; private set; }

        public VocabularyKey SimilarityRuleId { get; private set; }

        public VocabularyKey SimilarityRuleIdName { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey TextAnalyticsEntityMappingIdUnique { get; private set; }

        public VocabularyKey EntityPickList { get; private set; }

        public VocabularyKey EntityPickListName { get; private set; }

        public VocabularyKey FieldPickList { get; private set; }

        public VocabularyKey FieldPickListName { get; private set; }

        public VocabularyKey EntityDisplayName { get; private set; }

        public VocabularyKey FieldDisplayName { get; private set; }

        public VocabularyKey AdvancedSimilarityRuleId { get; private set; }

        public VocabularyKey AdvancedSimilarityRuleIdName { get; private set; }

        public VocabularyKey IsTextMatchMapping { get; private set; }

        public VocabularyKey IsTextMatchMappingName { get; private set; }


    }
}

