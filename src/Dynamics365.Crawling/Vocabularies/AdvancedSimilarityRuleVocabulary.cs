using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AdvancedSimilarityRuleVocabulary : SimpleVocabulary
    {
        public AdvancedSimilarityRuleVocabulary()
        {
            VocabularyName = "Dynamics365 AdvancedSimilarityRule";
            KeyPrefix = "dynamics365.advancedsimilarityrule";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("AdvancedSimilarityRule", group =>
            {
                this.AdvancedSimilarityRuleId = group.Add(new VocabularyKey("AdvancedSimilarityRuleId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("Advanced Similarity Rule")
                    .ModelProperty("advancedsimilarityruleid", typeof(Guid)));

                this.name = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a logical name for the similarity configuration")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Enter a description for the Advanced Similarity Rule")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.SourceEntity = group.Add(new VocabularyKey("SourceEntity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Enter an entity that similar records will be suggested for")
                    .WithDisplayName("Source Entity")
                    .ModelProperty("sourceentity", typeof(string)));

                this.SourceEntityName = group.Add(new VocabularyKey("SourceEntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SourceEntityName")
                    .ModelProperty("sourceentityname", typeof(string)));

                this.NgramSize = group.Add(new VocabularyKey("NgramSize", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the maximum number of words in a key phrase to use with text analytics.")
                    .WithDisplayName("Maximum Key Phrase Words")
                    .ModelProperty("ngramsize", typeof(long)));

                this.MaxNumberKeyphrases = group.Add(new VocabularyKey("MaxNumberKeyphrases", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the maximum number of keywords and key phrases to use with text analytics.")
                    .WithDisplayName("Maximum Number of Key Phrases")
                    .ModelProperty("maxnumberkeyphrases", typeof(long)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the advanced similarity rules")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Reason for the status of the advanced similarity rules")
                    .WithDisplayName("Status")
                    .ModelProperty("statuscode", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Status of the advanced similarity rules")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.AzureServiceConnectionId = group.Add(new VocabularyKey("AzureServiceConnectionId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for AzureServiceConnection associated with AdvancedSimilarityRule.")
                    .WithDisplayName("Connection")
                    .ModelProperty("azureserviceconnectionid", typeof(string)));

                this.AzureServiceConnectionIdName = group.Add(new VocabularyKey("AzureServiceConnectionIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("AzureServiceConnectionIdName")
                    .ModelProperty("azureserviceconnectionidname", typeof(string)));

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

                this.AdvancedSimilarityRuleIdUnique = group.Add(new VocabularyKey("AdvancedSimilarityRuleIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the Advanced Similarity Rule used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook")
                    .WithDisplayName("Advanced Similarity Rule Unique Id")
                    .ModelProperty("advancedsimilarityruleidunique", typeof(Guid)));

                this.Entity = group.Add(new VocabularyKey("Entity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"entity")
                    .WithDisplayName("Target Entity")
                    .ModelProperty("entity", typeof(string)));

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

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the Advanced Similarity Rules.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who modified the Advanced Similarity Rules.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who last modified the advanced similarity rules.")
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

                this.FetchXmlList = group.Add(new VocabularyKey("FetchXmlList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500000))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("For internal use only.")
                    .ModelProperty("fetchxmllist", typeof(string)));

                this.ExactMatchList = group.Add(new VocabularyKey("ExactMatchList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500000))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("For internal use only.")
                    .ModelProperty("exactmatchlist", typeof(string)));

                this.IsAzureMLRequired = group.Add(new VocabularyKey("IsAzureMLRequired", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Use Text Analytics for Target Match")
                    .WithDisplayName("Use Text Analytics for Target Match")
                    .ModelProperty("isazuremlrequired", typeof(bool)));

                this.FilterResultByStatus = group.Add(new VocabularyKey("FilterResultByStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Filter Result By Status")
                    .WithDisplayName("Filter Result By Status")
                    .ModelProperty("filterresultbystatus", typeof(string)));

                this.FilterResultByStatusName = group.Add(new VocabularyKey("FilterResultByStatusName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FilterResultByStatusName")
                    .ModelProperty("filterresultbystatusname", typeof(string)));

                this.FilterResultByStatusDisplayName = group.Add(new VocabularyKey("FilterResultByStatusDisplayName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Filter Result By Status")
                    .WithDisplayName("Filter Result By Status")
                    .ModelProperty("filterresultbystatusdisplayname", typeof(string)));

                this.NoiseKeyphraseslist = group.Add(new VocabularyKey("NoiseKeyphraseslist", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Provide noise key phrases by a semicolon ( ; ). These phrases will be filtered while searching for similar cases")
                    .WithDisplayName("Noise Key Phrases")
                    .ModelProperty("noisekeyphraseslist", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey AdvancedSimilarityRuleId { get; private set; }

        public VocabularyKey name { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey SourceEntity { get; private set; }

        public VocabularyKey SourceEntityName { get; private set; }

        public VocabularyKey NgramSize { get; private set; }

        public VocabularyKey MaxNumberKeyphrases { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey AzureServiceConnectionId { get; private set; }

        public VocabularyKey AzureServiceConnectionIdName { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey AdvancedSimilarityRuleIdUnique { get; private set; }

        public VocabularyKey Entity { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey FetchXmlList { get; private set; }

        public VocabularyKey ExactMatchList { get; private set; }

        public VocabularyKey IsAzureMLRequired { get; private set; }

        public VocabularyKey FilterResultByStatus { get; private set; }

        public VocabularyKey FilterResultByStatusName { get; private set; }

        public VocabularyKey FilterResultByStatusDisplayName { get; private set; }

        public VocabularyKey NoiseKeyphraseslist { get; private set; }


    }
}

