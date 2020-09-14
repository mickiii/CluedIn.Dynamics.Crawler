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
    public abstract class EntitlementClueProducer<T> : DynamicsClueProducer<T> where T : Entitlement
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public EntitlementClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.EntitlementId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=entitlement&id={1}", _dynamics365CrawlJobData.Api, input.EntitlementId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.ContactId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.ContactId);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.SLAId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.AccountId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.AccountId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.EntitlementTemplateId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.entitlementtemplate, EntityEdgeType.Parent, input, input.EntitlementTemplateId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.Entitlement.EntitlementId] = input.EntitlementId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.AllocationTypeCode] = input.AllocationTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.AllocationTypeCodeName] = input.AllocationTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.RemainingTerms] = input.RemainingTerms.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.RestrictCaseCreation] = input.RestrictCaseCreation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.RestrictCaseCreationName] = input.RestrictCaseCreationName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.TotalTerms] = input.TotalTerms.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.EndDate] = input.EndDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.SLAIdName] = input.SLAIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.KbAccessLevel] = input.KbAccessLevel.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.KbAccessLevelName] = input.KbAccessLevelName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.EntitlementTemplateId] = input.EntitlementTemplateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.EntitlementTemplateIdName] = input.EntitlementTemplateIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.DecreaseRemainingOn] = input.DecreaseRemainingOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.DecreaseRemainingOnName] = input.DecreaseRemainingOnName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.IsDefaultName] = input.IsDefaultName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ContactIdName] = input.ContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ContactIdYomiName] = input.ContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.entitytype] = input.entitytype.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Entitlement.entitytypeName] = input.entitytypeName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

