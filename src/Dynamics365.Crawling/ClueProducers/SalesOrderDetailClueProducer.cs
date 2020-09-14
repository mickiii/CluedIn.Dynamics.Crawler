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
    public abstract class SalesOrderDetailClueProducer<T> : DynamicsClueProducer<T> where T : SalesOrderDetail
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SalesOrderDetailClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SalesOrderDetailId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=salesorderdetail&id={1}", _dynamics365CrawlJobData.Api, input.SalesOrderDetailId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.SalesOrderDetailName;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.ParentBundleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorderdetail, EntityEdgeType.Parent, input, input.ParentBundleId);

                         if (input.ParentBundleIdRef != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorderdetail, EntityEdgeType.Parent, input, input.ParentBundleIdRef);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.QuoteDetailId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.quotedetail, EntityEdgeType.Parent, input, input.QuoteDetailId);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.SalesRepId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.SalesRepId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ProductAssociationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.productassociation, EntityEdgeType.Parent, input, input.ProductAssociationId);

                         if (input.UoMId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uom, EntityEdgeType.Parent, input, input.UoMId);

                         if (input.ProductId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ProductId);

                         if (input.SalesOrderId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.SalesOrderId);


            */
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesOrderDetailId] = input.SalesOrderDetailId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesOrderId] = input.SalesOrderId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesRepId] = input.SalesRepId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.IsProductOverridden] = input.IsProductOverridden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.IsCopied] = input.IsCopied.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.QuantityShipped] = input.QuantityShipped.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.LineItemNumber] = input.LineItemNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.QuantityBackordered] = input.QuantityBackordered.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.UoMId] = input.UoMId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.QuantityCancelled] = input.QuantityCancelled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.RequestDeliveryBy] = input.RequestDeliveryBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.Quantity] = input.Quantity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.PricingErrorCode] = input.PricingErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ManualDiscountAmount] = input.ManualDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ProductDescription] = input.ProductDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.VolumeDiscountAmount] = input.VolumeDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.PricePerUnit] = input.PricePerUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.BaseAmount] = input.BaseAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ExtendedAmount] = input.ExtendedAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.IsPriceOverridden] = input.IsPriceOverridden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_Name] = input.ShipTo_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.Tax] = input.Tax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_Line1] = input.ShipTo_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_Line2] = input.ShipTo_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_Line3] = input.ShipTo_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_City] = input.ShipTo_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_StateOrProvince] = input.ShipTo_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_Country] = input.ShipTo_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_PostalCode] = input.ShipTo_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.WillCall] = input.WillCall.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_Telephone] = input.ShipTo_Telephone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_Fax] = input.ShipTo_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_FreightTermsCode] = input.ShipTo_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ProductIdName] = input.ProductIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.UoMIdName] = input.UoMIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesRepIdName] = input.SalesRepIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesOrderStateCode] = input.SalesOrderStateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.IsCopiedName] = input.IsCopiedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.IsPriceOverriddenName] = input.IsPriceOverriddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.WillCallName] = input.WillCallName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.IsProductOverriddenName] = input.IsProductOverriddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesOrderStateCodeName] = input.SalesOrderStateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_FreightTermsCodeName] = input.ShipTo_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.PricingErrorCodeName] = input.PricingErrorCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_ContactName] = input.ShipTo_ContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesOrderIsPriceLocked] = input.SalesOrderIsPriceLocked.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ShipTo_AddressId] = input.ShipTo_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesOrderIsPriceLockedName] = input.SalesOrderIsPriceLockedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.BaseAmount_Base] = input.BaseAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.PricePerUnit_Base] = input.PricePerUnit_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.VolumeDiscountAmount_Base] = input.VolumeDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ExtendedAmount_Base] = input.ExtendedAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.Tax_Base] = input.Tax_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ManualDiscountAmount_Base] = input.ManualDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesRepIdYomiName] = input.SalesRepIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SequenceNumber] = input.SequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ParentBundleId] = input.ParentBundleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ProductTypeCode] = input.ProductTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ProductTypeCodeName] = input.ProductTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.PropertyConfigurationStatusName] = input.PropertyConfigurationStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.PropertyConfigurationStatus] = input.PropertyConfigurationStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ProductAssociationId] = input.ProductAssociationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesOrderIdName] = input.SalesOrderIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ProductName] = input.ProductName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.QuoteDetailId] = input.QuoteDetailId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SalesOrderDetailName] = input.SalesOrderDetailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.ParentBundleIdRef] = input.ParentBundleIdRef.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.QuoteDetailIdName] = input.QuoteDetailIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.SkipPriceCalculation] = input.SkipPriceCalculation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrderDetail.skippricecalculationName] = input.skippricecalculationName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

