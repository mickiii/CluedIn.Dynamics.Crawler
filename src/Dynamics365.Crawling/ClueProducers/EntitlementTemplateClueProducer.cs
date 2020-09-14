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
    public abstract class EntitlementTemplateClueProducer<T> : DynamicsClueProducer<T> where T : EntitlementTemplate
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public EntitlementTemplateClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.EntitlementTemplateId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=entitlementtemplate&id={1}", _dynamics365CrawlJobData.Api, input.EntitlementTemplateId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.SLAId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.EntitlementTemplateId] = input.EntitlementTemplateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.AllocationTypeCode] = input.AllocationTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.AllocationTypeCodeName] = input.AllocationTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.RestrictCaseCreation] = input.RestrictCaseCreation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.RestrictCaseCreationName] = input.RestrictCaseCreationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.TotalTerms] = input.TotalTerms.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.EndDate] = input.EndDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.SLAIdName] = input.SLAIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.KbAccessLevel] = input.KbAccessLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.KbAccessLevelName] = input.KbAccessLevelName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.DecreaseRemainingOn] = input.DecreaseRemainingOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.DecreaseRemainingOnName] = input.DecreaseRemainingOnName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.entitytype] = input.entitytype.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.EntitlementTemplate.entitytypeName] = input.entitytypeName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

