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
    public abstract class SalesOrderClueProducer<T> : DynamicsClueProducer<T> where T : SalesOrder
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SalesOrderClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Sales.Order, input.SalesOrderId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=salesorder&id={1}", this._dynamics365CrawlJobData.Api, input.SalesOrderId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;

            //if (input.PriceLevelId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.PriceLevelId);

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Parent, input, input.OwningTeam);

            if (input.CustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.CustomerId);

            //if (input.SLAInvokedId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

            //if (input.SLAId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

            if (input.CampaignId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Marketing.Campaign, EntityEdgeType.Parent, input, input.CampaignId);

            if (input.StageId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.Parent, input, input.StageId.ToString());

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.CustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.CustomerId);

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

            //if (input.QuoteId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.quote, EntityEdgeType.Parent, input, input.QuoteId);

            if (input.OpportunityId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Opportunity, EntityEdgeType.Parent, input, input.OpportunityId);

            if (input.OwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            //if (input.EntityImageId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

            data.Properties[Dynamics365Vocabulary.SalesOrder.SalesOrderId] = input.SalesOrderId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OpportunityId] = input.OpportunityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.QuoteId] = input.QuoteId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.SubmitStatus] = input.SubmitStatus.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.SubmitDate] = input.SubmitDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.SubmitStatusDescription] = input.SubmitStatusDescription.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.PriceLevelId] = input.PriceLevelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.LastBackofficeSubmit] = input.LastBackofficeSubmit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OrderNumber] = input.OrderNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.PricingErrorCode] = input.PricingErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.DiscountAmount] = input.DiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.FreightAmount] = input.FreightAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalAmount] = input.TotalAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalLineItemAmount] = input.TotalLineItemAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalLineItemDiscountAmount] = input.TotalLineItemDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalAmountLessFreight] = input.TotalAmountLessFreight.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalDiscountAmount] = input.TotalDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.RequestDeliveryBy] = input.RequestDeliveryBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalTax] = input.TotalTax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.PaymentTermsCode] = input.PaymentTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.FreightTermsCode] = input.FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_Name] = input.ShipTo_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_Line1] = input.ShipTo_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_Line2] = input.ShipTo_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_Line3] = input.ShipTo_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_City] = input.ShipTo_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_StateOrProvince] = input.ShipTo_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_Country] = input.ShipTo_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_PostalCode] = input.ShipTo_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.WillCall] = input.WillCall.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_Telephone] = input.ShipTo_Telephone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_Name] = input.BillTo_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_FreightTermsCode] = input.ShipTo_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_Fax] = input.ShipTo_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_Line1] = input.BillTo_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_Line2] = input.BillTo_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_Line3] = input.BillTo_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_City] = input.BillTo_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_StateOrProvince] = input.BillTo_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_Country] = input.BillTo_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_PostalCode] = input.BillTo_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_Telephone] = input.BillTo_Telephone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_Fax] = input.BillTo_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.DiscountPercentage] = input.DiscountPercentage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ContactIdName] = input.ContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OpportunityIdName] = input.OpportunityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.QuoteIdName] = input.QuoteIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.PriceLevelIdName] = input.PriceLevelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.WillCallName] = input.WillCallName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_FreightTermsCodeName] = input.ShipTo_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.PaymentTermsCodeName] = input.PaymentTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.PricingErrorCodeName] = input.PricingErrorCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.FreightTermsCodeName] = input.FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_ContactName] = input.BillTo_ContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CampaignId] = input.CampaignId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_AddressId] = input.BillTo_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_AddressId] = input.ShipTo_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.IsPriceLocked] = input.IsPriceLocked.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.DateFulfilled] = input.DateFulfilled.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_ContactName] = input.ShipTo_ContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CampaignIdName] = input.CampaignIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.IsPriceLockedName] = input.IsPriceLockedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalLineItemAmount_Base] = input.TotalLineItemAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalDiscountAmount_Base] = input.TotalDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalAmountLessFreight_Base] = input.TotalAmountLessFreight_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalAmount_Base] = input.TotalAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.DiscountAmount_Base] = input.DiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.FreightAmount_Base] = input.FreightAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalLineItemDiscountAmount_Base] = input.TotalLineItemDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TotalTax_Base] = input.TotalTax_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ContactIdYomiName] = input.ContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.BillTo_Composite] = input.BillTo_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ShipTo_Composite] = input.ShipTo_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.SkipPriceCalculation] = input.SkipPriceCalculation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.SalesOrder.skippricecalculationName] = input.skippricecalculationName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

