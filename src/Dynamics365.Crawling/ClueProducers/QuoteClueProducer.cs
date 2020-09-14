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
    public abstract class QuoteClueProducer<T> : DynamicsClueProducer<T> where T : Quote
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public QuoteClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.QuoteId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=quote&id={1}", _dynamics365CrawlJobData.Api, input.QuoteId.ToString()), UriKind.Absolute, out Uri uri))
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

                         if (input.CampaignId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.campaign, EntityEdgeType.Parent, input, input.CampaignId);

                         if (input.StageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.processstage, EntityEdgeType.Parent, input, input.StageId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.OwningBusinessUnit != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.OwningBusinessUnit);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.OpportunityId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.opportunity, EntityEdgeType.Parent, input, input.OpportunityId);

                         if (input.OwnerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.owner, EntityEdgeType.Parent, input, input.OwnerId);


            */
            data.Properties[Dynamics365Vocabulary.Quote.QuoteId] = input.QuoteId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.PriceLevelId] = input.PriceLevelId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OpportunityId] = input.OpportunityId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.QuoteNumber] = input.QuoteNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.RevisionNumber] = input.RevisionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.PricingErrorCode] = input.PricingErrorCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.DiscountAmount] = input.DiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.FreightAmount] = input.FreightAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalAmount] = input.TotalAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalLineItemAmount] = input.TotalLineItemAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalLineItemDiscountAmount] = input.TotalLineItemDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalAmountLessFreight] = input.TotalAmountLessFreight.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.EffectiveFrom] = input.EffectiveFrom.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalTax] = input.TotalTax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalDiscountAmount] = input.TotalDiscountAmount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.EffectiveTo] = input.EffectiveTo.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ExpiresOn] = input.ExpiresOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ClosedOn] = input.ClosedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.RequestDeliveryBy] = input.RequestDeliveryBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.PaymentTermsCode] = input.PaymentTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.FreightTermsCode] = input.FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_Name] = input.ShipTo_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_Line1] = input.ShipTo_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_Line2] = input.ShipTo_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_Line3] = input.ShipTo_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_City] = input.ShipTo_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_StateOrProvince] = input.ShipTo_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_Country] = input.ShipTo_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_PostalCode] = input.ShipTo_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.WillCall] = input.WillCall.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_Telephone] = input.ShipTo_Telephone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_Name] = input.BillTo_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_FreightTermsCode] = input.ShipTo_FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_Fax] = input.ShipTo_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_Line1] = input.BillTo_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_Line2] = input.BillTo_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_Line3] = input.BillTo_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_City] = input.BillTo_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_StateOrProvince] = input.BillTo_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_Country] = input.BillTo_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_PostalCode] = input.BillTo_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_Telephone] = input.BillTo_Telephone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_Fax] = input.BillTo_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.DiscountPercentage] = input.DiscountPercentage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ContactIdName] = input.ContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OpportunityIdName] = input.OpportunityIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.PriceLevelIdName] = input.PriceLevelIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.WillCallName] = input.WillCallName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.PricingErrorCodeName] = input.PricingErrorCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.PaymentTermsCodeName] = input.PaymentTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_FreightTermsCodeName] = input.ShipTo_FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.FreightTermsCodeName] = input.FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CampaignId] = input.CampaignId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_AddressId] = input.ShipTo_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_ContactName] = input.ShipTo_ContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_AddressId] = input.BillTo_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_ContactName] = input.BillTo_ContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CampaignIdName] = input.CampaignIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.UniqueDscId] = input.UniqueDscId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalLineItemDiscountAmount_Base] = input.TotalLineItemDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalAmountLessFreight_Base] = input.TotalAmountLessFreight_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.DiscountAmount_Base] = input.DiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.FreightAmount_Base] = input.FreightAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalAmount_Base] = input.TotalAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalDiscountAmount_Base] = input.TotalDiscountAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalTax_Base] = input.TotalTax_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TotalLineItemAmount_Base] = input.TotalLineItemAmount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ContactIdYomiName] = input.ContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.BillTo_Composite] = input.BillTo_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ShipTo_Composite] = input.ShipTo_Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.ProcessId] = input.ProcessId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.StageId] = input.StageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.TraversedPath] = input.TraversedPath.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.OnHoldTime] = input.OnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.LastOnHoldTime] = input.LastOnHoldTime.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.SLAId] = input.SLAId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.SLAName] = input.SLAName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.SLAInvokedId] = input.SLAInvokedId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.SLAInvokedIdName] = input.SLAInvokedIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.SkipPriceCalculation] = input.SkipPriceCalculation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Quote.skippricecalculationName] = input.skippricecalculationName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

