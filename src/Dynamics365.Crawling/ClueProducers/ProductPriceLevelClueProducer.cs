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
    public abstract class ProductPriceLevelClueProducer<T> : DynamicsClueProducer<T> where T : ProductPriceLevel
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ProductPriceLevelClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ProductPriceLevelId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=productpricelevel&id={1}", _dynamics365CrawlJobData.Api, input.ProductPriceLevelId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.ProductIdName;
            /*
             if (input.PriceLevelId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.PriceLevelId);

                         if (input.DiscountTypeId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.discounttype, EntityEdgeType.Parent, input, input.DiscountTypeId);

                         if (input.StageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstage, EntityEdgeType.Parent, input, input.StageId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.UoMId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uom, EntityEdgeType.Parent, input, input.UoMId);

                         if (input.ProductId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ProductId);

                         if (input.UoMScheduleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uomschedule, EntityEdgeType.Parent, input, input.UoMScheduleId);


            */
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.PriceLevelId] = input.PriceLevelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ProductPriceLevelId] = input.ProductPriceLevelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.UoMId] = input.UoMId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.UoMScheduleId] = input.UoMScheduleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.DiscountTypeId] = input.DiscountTypeId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.Percentage] = input.Percentage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.Amount] = input.Amount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.QuantitySellingCode] = input.QuantitySellingCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.RoundingPolicyCode] = input.RoundingPolicyCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.PricingMethodCode] = input.PricingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.RoundingOptionCode] = input.RoundingOptionCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.RoundingOptionAmount] = input.RoundingOptionAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.DiscountTypeIdName] = input.DiscountTypeIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ProductIdName] = input.ProductIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.PriceLevelIdName] = input.PriceLevelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.UoMIdName] = input.UoMIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.UoMScheduleIdName] = input.UoMScheduleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.RoundingPolicyCodeName] = input.RoundingPolicyCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.QuantitySellingCodeName] = input.QuantitySellingCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.PricingMethodCodeName] = input.PricingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.RoundingOptionCodeName] = input.RoundingOptionCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.Amount_Base] = input.Amount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.RoundingOptionAmount_Base] = input.RoundingOptionAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.ProductNumber] = input.ProductNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ProductPriceLevel.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

