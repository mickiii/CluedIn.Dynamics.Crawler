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
    public abstract class InvoiceDetailClueProducer<T> : DynamicsClueProducer<T> where T : InvoiceDetail
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public InvoiceDetailClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.InvoiceDetailId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=invoicedetail&id={1}", _dynamics365CrawlJobData.Api, input.InvoiceDetailId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.InvoiceDetailName;
            /*
             if (input.InvoiceId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoice, EntityEdgeType.Parent, input, input.InvoiceId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.SalesOrderDetailId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorderdetail, EntityEdgeType.Parent, input, input.SalesOrderDetailId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.SalesRepId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.SalesRepId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ProductAssociationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.productassociation, EntityEdgeType.Parent, input, input.ProductAssociationId);

                         if (input.UoMId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uom, EntityEdgeType.Parent, input, input.UoMId);

                         if (input.ProductId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ProductId);

                         if (input.ParentBundleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoicedetail, EntityEdgeType.Parent, input, input.ParentBundleId);

                         if (input.ParentBundleIdRef != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.invoicedetail, EntityEdgeType.Parent, input, input.ParentBundleIdRef);


            */
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.InvoiceDetailId] = input.InvoiceDetailId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.SalesRepId] = input.SalesRepId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.IsProductOverridden] = input.IsProductOverridden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.LineItemNumber] = input.LineItemNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.IsCopied] = input.IsCopied.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.InvoiceId] = input.InvoiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.QuantityBackordered] = input.QuantityBackordered.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.UoMId] = input.UoMId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ActualDeliveryOn] = input.ActualDeliveryOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.Quantity] = input.Quantity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ManualDiscountAmount] = input.ManualDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ProductDescription] = input.ProductDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.VolumeDiscountAmount] = input.VolumeDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.PricePerUnit] = input.PricePerUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.BaseAmount] = input.BaseAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.QuantityCancelled] = input.QuantityCancelled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShippingTrackingNumber] = input.ShippingTrackingNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ExtendedAmount] = input.ExtendedAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.IsPriceOverridden] = input.IsPriceOverridden.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_Name] = input.ShipTo_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.PricingErrorCode] = input.PricingErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.Tax] = input.Tax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_Line1] = input.ShipTo_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_Line2] = input.ShipTo_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_Line3] = input.ShipTo_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_City] = input.ShipTo_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_StateOrProvince] = input.ShipTo_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_Country] = input.ShipTo_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_PostalCode] = input.ShipTo_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.WillCall] = input.WillCall.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_Telephone] = input.ShipTo_Telephone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_Fax] = input.ShipTo_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_FreightTermsCode] = input.ShipTo_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.QuantityShipped] = input.QuantityShipped.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ProductIdName] = input.ProductIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.UoMIdName] = input.UoMIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.SalesRepIdName] = input.SalesRepIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.InvoiceStateCode] = input.InvoiceStateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.IsPriceOverriddenName] = input.IsPriceOverriddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.IsProductOverriddenName] = input.IsProductOverriddenName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.WillCallName] = input.WillCallName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.IsCopiedName] = input.IsCopiedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ShipTo_FreightTermsCodeName] = input.ShipTo_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.InvoiceStateCodeName] = input.InvoiceStateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.PricingErrorCodeName] = input.PricingErrorCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.InvoiceIsPriceLocked] = input.InvoiceIsPriceLocked.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.InvoiceIsPriceLockedName] = input.InvoiceIsPriceLockedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.VolumeDiscountAmount_Base] = input.VolumeDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.BaseAmount_Base] = input.BaseAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.PricePerUnit_Base] = input.PricePerUnit_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.Tax_Base] = input.Tax_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ExtendedAmount_Base] = input.ExtendedAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ManualDiscountAmount_Base] = input.ManualDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.SalesRepIdYomiName] = input.SalesRepIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.SequenceNumber] = input.SequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ParentBundleId] = input.ParentBundleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ProductTypeCode] = input.ProductTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ProductTypeCodeName] = input.ProductTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.PropertyConfigurationStatus] = input.PropertyConfigurationStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.PropertyConfigurationStatusName] = input.PropertyConfigurationStatusName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ProductAssociationId] = input.ProductAssociationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.InvoiceIdName] = input.InvoiceIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ProductName] = input.ProductName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.InvoiceDetailName] = input.InvoiceDetailName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.SalesOrderDetailId] = input.SalesOrderDetailId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.ParentBundleIdRef] = input.ParentBundleIdRef.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.SalesOrderDetailIdName] = input.SalesOrderDetailIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.SkipPriceCalculation] = input.SkipPriceCalculation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InvoiceDetail.skippricecalculationName] = input.skippricecalculationName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

