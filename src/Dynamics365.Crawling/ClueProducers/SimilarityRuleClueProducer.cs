using System;
using System.Linq;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public abstract class SimilarityRuleClueProducer<T> : DynamicsClueProducer<T> where T : SimilarityRule
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SimilarityRuleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            this._factory = factory;

            this._dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Unknown, input.SimilarityRuleId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=similarityrule&id={1}", _dynamics365CrawlJobData.Api, input.SimilarityRuleId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.name;
            /*
             if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.SimilarityRule.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.name] = input.name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.SimilarityRuleId] = input.SimilarityRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.MatchingEntityName] = input.MatchingEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.statecode] = input.statecode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.statecodeName] = input.statecodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.statuscode] = input.statuscode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.statuscodeName] = input.statuscodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.SolutionId] = input.SolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.SupportingSolutionId] = input.SupportingSolutionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.ComponentState] = input.ComponentState.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.OverwriteTime] = input.OverwriteTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.IsManaged] = input.IsManaged.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.IntroducedVersion] = input.IntroducedVersion.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.SimilarityRuleIdUnique] = input.SimilarityRuleIdUnique.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.BaseEntityTypeCode] = input.BaseEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.MatchingEntityTypeCode] = input.MatchingEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.ExcludeInactiveRecords] = input.ExcludeInactiveRecords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.BaseEntityTypeCodeName] = input.BaseEntityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.MatchingEntityTypeCodeName] = input.MatchingEntityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.ExcludeInactiveRecordsName] = input.ExcludeInactiveRecordsName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.BaseEntityName] = input.BaseEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.ActiveRuleFetchXML] = input.ActiveRuleFetchXML.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.RuleConditionXml] = input.RuleConditionXml.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.NgramSize] = input.NgramSize.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.MaxKeyWords] = input.MaxKeyWords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SimilarityRule.FetchXmlList] = input.FetchXmlList.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

