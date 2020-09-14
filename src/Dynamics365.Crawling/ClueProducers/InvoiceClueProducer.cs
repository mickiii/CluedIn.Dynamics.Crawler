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
    public abstract class InvoiceClueProducer<T> : DynamicsClueProducer<T> where T : Invoice
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public InvoiceClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.InvoiceId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=invoice&id={1}", _dynamics365CrawlJobData.Api, input.InvoiceId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.PriceLevelId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.pricelevel, EntityEdgeType.Parent, input, input.PriceLevelId);

                         if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.SLAInvokedId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAInvokedId);

                         if (input.SLAId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.sla, EntityEdgeType.Parent, input, input.SLAId);

                         if (input.StageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstage, EntityEdgeType.Parent, input, input.StageId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.OpportunityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.OpportunityId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

                         if (input.SalesOrderId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.salesorder, EntityEdgeType.Parent, input, input.SalesOrderId);


            */
            data.Properties[Dynamics365Vocabulary.Invoice.InvoiceId] = input.InvoiceId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OpportunityId] = input.OpportunityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.PriorityCode] = input.PriorityCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.SalesOrderId] = input.SalesOrderId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.LastBackofficeSubmit] = input.LastBackofficeSubmit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.PriceLevelId] = input.PriceLevelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.InvoiceNumber] = input.InvoiceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.DiscountAmount] = input.DiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.FreightAmount] = input.FreightAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalAmount] = input.TotalAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalLineItemAmount] = input.TotalLineItemAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalLineItemDiscountAmount] = input.TotalLineItemDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalAmountLessFreight] = input.TotalAmountLessFreight.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalDiscountAmount] = input.TotalDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalTax] = input.TotalTax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.PaymentTermsCode] = input.PaymentTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_Name] = input.ShipTo_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.PricingErrorCode] = input.PricingErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_Line1] = input.ShipTo_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_Line2] = input.ShipTo_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_Line3] = input.ShipTo_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_City] = input.ShipTo_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_StateOrProvince] = input.ShipTo_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_Country] = input.ShipTo_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_PostalCode] = input.ShipTo_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.WillCall] = input.WillCall.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_Telephone] = input.ShipTo_Telephone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_Name] = input.BillTo_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_FreightTermsCode] = input.ShipTo_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_Fax] = input.ShipTo_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_Line1] = input.BillTo_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_Line2] = input.BillTo_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_Line3] = input.BillTo_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_City] = input.BillTo_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_StateOrProvince] = input.BillTo_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_Country] = input.BillTo_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_PostalCode] = input.BillTo_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_Telephone] = input.BillTo_Telephone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_Fax] = input.BillTo_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.DiscountPercentage] = input.DiscountPercentage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ContactIdName] = input.ContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OpportunityIdName] = input.OpportunityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.SalesOrderIdName] = input.SalesOrderIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.PriceLevelIdName] = input.PriceLevelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.WillCallName] = input.WillCallName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_FreightTermsCodeName] = input.ShipTo_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.PriorityCodeName] = input.PriorityCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.PaymentTermsCodeName] = input.PaymentTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.PricingErrorCodeName] = input.PricingErrorCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.IsPriceLocked] = input.IsPriceLocked.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.DateDelivered] = input.DateDelivered.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.DueDate] = input.DueDate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.IsPriceLockedName] = input.IsPriceLockedName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalLineItemAmount_Base] = input.TotalLineItemAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalLineItemDiscountAmount_Base] = input.TotalLineItemDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalTax_Base] = input.TotalTax_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalAmountLessFreight_Base] = input.TotalAmountLessFreight_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.DiscountAmount_Base] = input.DiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalAmount_Base] = input.TotalAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.FreightAmount_Base] = input.FreightAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TotalDiscountAmount_Base] = input.TotalDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ContactIdYomiName] = input.ContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.BillTo_Composite] = input.BillTo_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ShipTo_Composite] = input.ShipTo_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.SkipPriceCalculation] = input.SkipPriceCalculation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Invoice.skippricecalculationName] = input.skippricecalculationName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

