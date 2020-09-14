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
    public abstract class DuplicateRuleConditionClueProducer<T> : DynamicsClueProducer<T> where T : DuplicateRuleCondition
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DuplicateRuleConditionClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DuplicateRuleConditionId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=duplicaterulecondition&id={1}", _dynamics365CrawlJobData.Api, input.DuplicateRuleConditionId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.RegardingObjectId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.duplicaterule, EntityEdgeType.Parent, input, input.RegardingObjectId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);


            */
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.OperatorParam] = input.OperatorParam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.OperatorCode] = input.OperatorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.BaseAttributeName] = input.BaseAttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.RegardingObjectId] = input.RegardingObjectId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.DuplicateRuleConditionId] = input.DuplicateRuleConditionId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.MatchingAttributeName] = input.MatchingAttributeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.OperatorCodeName] = input.OperatorCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.IgnoreBlankValues] = input.IgnoreBlankValues.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRuleCondition.IgnoreBlankValuesName] = input.IgnoreBlankValuesName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

