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
    public abstract class DuplicateRuleClueProducer<T> : DynamicsClueProducer<T> where T : DuplicateRule
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public DuplicateRuleClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.DuplicateRuleId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=duplicaterule&id={1}", _dynamics365CrawlJobData.Api, input.DuplicateRuleId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.DuplicateRule.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.IsCaseSensitive] = input.IsCaseSensitive.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.MatchingEntityMatchCodeTable] = input.MatchingEntityMatchCodeTable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.BaseEntityTypeCode] = input.BaseEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.DuplicateRuleId] = input.DuplicateRuleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.MatchingEntityTypeCode] = input.MatchingEntityTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.BaseEntityMatchCodeTable] = input.BaseEntityMatchCodeTable.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.BaseEntityName] = input.BaseEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.MatchingEntityName] = input.MatchingEntityName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.MatchingEntityTypeCodeName] = input.MatchingEntityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.IsCaseSensitiveName] = input.IsCaseSensitiveName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.BaseEntityTypeCodeName] = input.BaseEntityTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.ExcludeInactiveRecords] = input.ExcludeInactiveRecords.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.DuplicateRule.ExcludeInactiveRecordsName] = input.ExcludeInactiveRecordsName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

