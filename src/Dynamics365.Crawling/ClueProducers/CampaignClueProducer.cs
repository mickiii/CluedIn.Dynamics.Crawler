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
    public abstract class CampaignClueProducer<T> : DynamicsClueProducer<T> where T : Campaign
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CampaignClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Marketing.Campaign, input.CampaignId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=campaign&id={1}", this._dynamics365CrawlJobData.Api, input.CampaignId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;

            //if (input.PriceListId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.PriceListId);

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Parent, input, input.OwningTeam);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.OwningBusinessUnit != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            if (input.OwningUser != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.OwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            //if (input.EntityImageId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

            data.Properties[Dynamics365Vocabulary.Campaign.TypeCode] = input.TypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ProposedEnd] = input.ProposedEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.BudgetedCost] = input.BudgetedCost.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.PromotionCodeName] = input.PromotionCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.PriceListId] = input.PriceListId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.IsTemplate] = input.IsTemplate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.CampaignId] = input.CampaignId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ActualStart] = input.ActualStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.TotalActualCost] = input.TotalActualCost.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.Message] = input.Message.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ExpectedRevenue] = input.ExpectedRevenue.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.CodeName] = input.CodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ProposedStart] = input.ProposedStart.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.Objective] = input.Objective.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ActualEnd] = input.ActualEnd.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.OtherCost] = input.OtherCost.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.TotalCampaignActivityActualCost] = input.TotalCampaignActivityActualCost.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ExpectedResponse] = input.ExpectedResponse.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.TypeCodeName] = input.TypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.IsTemplateName] = input.IsTemplateName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.PriceListName] = input.PriceListName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.TotalCampaignActivityActualCost_Base] = input.TotalCampaignActivityActualCost_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.BudgetedCost_Base] = input.BudgetedCost_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ExpectedRevenue_Base] = input.ExpectedRevenue_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.OtherCost_Base] = input.OtherCost_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.TotalActualCost_Base] = input.TotalActualCost_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Campaign.TmpRegardingObjectId] = input.TmpRegardingObjectId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

