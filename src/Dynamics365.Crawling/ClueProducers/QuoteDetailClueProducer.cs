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
    public abstract class QuoteDetailClueProducer<T> : DynamicsClueProducer<T> where T : QuoteDetail
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public QuoteDetailClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.QuoteDetailId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=quotedetail&id={1}", _dynamics365CrawlJobData.Api, input.QuoteDetailId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.QuoteDetailName;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.ParentBundleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quotedetail, EntityEdgeType.Parent, input, input.ParentBundleId);

                         if (input.ParentBundleIdRef != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quotedetail, EntityEdgeType.Parent, input, input.ParentBundleIdRef);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.SalesRepId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.SalesRepId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ProductAssociationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.productassociation, EntityEdgeType.Parent, input, input.ProductAssociationId);

                         if (input.UoMId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uom, EntityEdgeType.Parent, input, input.UoMId);

                         if (input.QuoteId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.QuoteId);

                         if (input.ProductId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ProductId);


            */
            data.Properties[Dynamics365Vocabulary.QuoteDetail.QuoteDetailId] = input.QuoteDetailId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.QuoteId] = input.QuoteId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.SalesRepId] = input.SalesRepId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.LineItemNumber] = input.LineItemNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.UoMId] = input.UoMId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.RequestDeliveryBy] = input.RequestDeliveryBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.Quantity] = input.Quantity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.PricingErrorCode] = input.PricingErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ManualDiscountAmount] = input.ManualDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ProductDescription] = input.ProductDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.VolumeDiscountAmount] = input.VolumeDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.PricePerUnit] = input.PricePerUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.BaseAmount] = input.BaseAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ExtendedAmount] = input.ExtendedAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_Name] = input.ShipTo_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.IsPriceOverridden] = input.IsPriceOverridden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.Tax] = input.Tax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_Line1] = input.ShipTo_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_Line2] = input.ShipTo_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_Line3] = input.ShipTo_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_City] = input.ShipTo_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_StateOrProvince] = input.ShipTo_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_Country] = input.ShipTo_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_PostalCode] = input.ShipTo_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.WillCall] = input.WillCall.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.IsProductOverridden] = input.IsProductOverridden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_Telephone] = input.ShipTo_Telephone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_Fax] = input.ShipTo_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_FreightTermsCode] = input.ShipTo_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ProductIdName] = input.ProductIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.UoMIdName] = input.UoMIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.SalesRepIdName] = input.SalesRepIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.QuoteStateCode] = input.QuoteStateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.IsProductOverriddenName] = input.IsProductOverriddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.WillCallName] = input.WillCallName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.IsPriceOverriddenName] = input.IsPriceOverriddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_FreightTermsCodeName] = input.ShipTo_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.QuoteStateCodeName] = input.QuoteStateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.PricingErrorCodeName] = input.PricingErrorCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_AddressId] = input.ShipTo_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ShipTo_ContactName] = input.ShipTo_ContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.Tax_Base] = input.Tax_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ExtendedAmount_Base] = input.ExtendedAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.PricePerUnit_Base] = input.PricePerUnit_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.BaseAmount_Base] = input.BaseAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ManualDiscountAmount_Base] = input.ManualDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.VolumeDiscountAmount_Base] = input.VolumeDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.SalesRepIdYomiName] = input.SalesRepIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.SequenceNumber] = input.SequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.PropertyConfigurationStatus] = input.PropertyConfigurationStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.PropertyConfigurationStatusName] = input.PropertyConfigurationStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ProductAssociationId] = input.ProductAssociationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ParentBundleId] = input.ParentBundleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ProductTypeCode] = input.ProductTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ProductTypeCodeName] = input.ProductTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.QuoteIdName] = input.QuoteIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ProductName] = input.ProductName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.QuoteDetailName] = input.QuoteDetailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.ParentBundleIdRef] = input.ParentBundleIdRef.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.SkipPriceCalculation] = input.SkipPriceCalculation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.QuoteDetail.skippricecalculationName] = input.skippricecalculationName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

