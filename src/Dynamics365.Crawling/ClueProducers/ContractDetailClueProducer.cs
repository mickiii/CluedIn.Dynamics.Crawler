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
    public abstract class ContractDetailClueProducer<T> : DynamicsClueProducer<T> where T : ContractDetail
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ContractDetailClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.ContractDetailId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=contractdetail&id={1}", _dynamics365CrawlJobData.Api, input.ContractDetailId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;
            /*
             if (input.OwningTeam != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.team, EntityEdgeType.Parent, input, input.OwningTeam);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CustomerId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.CustomerId);

                         if (input.OwningUser != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.OwningUser);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ServiceAddress != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.customeraddress, EntityEdgeType.Parent, input, input.ServiceAddress);

                         if (input.UoMId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uom, EntityEdgeType.Parent, input, input.UoMId);

                         if (input.ProductId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.product, EntityEdgeType.Parent, input, input.ProductId);

                         if (input.ContractId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contract, EntityEdgeType.Parent, input, input.ContractId);

                         if (input.UoMScheduleId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.uomschedule, EntityEdgeType.Parent, input, input.UoMScheduleId);


            */
            data.Properties[Dynamics365Vocabulary.ContractDetail.ContractDetailId] = input.ContractDetailId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ServiceAddress] = input.ServiceAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.UoMId] = input.UoMId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ProductSerialNumber] = input.ProductSerialNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ContractId] = input.ContractId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.LineItemOrder] = input.LineItemOrder.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ServiceContractUnitsCode] = input.ServiceContractUnitsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.InitialQuantity] = input.InitialQuantity.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.EffectivityCalendar] = input.EffectivityCalendar.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ActiveOn] = input.ActiveOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ExpiresOn] = input.ExpiresOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.TotalAllotments] = input.TotalAllotments.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.Rate] = input.Rate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.Price] = input.Price.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.Discount] = input.Discount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.Net] = input.Net.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.AllotmentsRemaining] = input.AllotmentsRemaining.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.AllotmentsUsed] = input.AllotmentsUsed.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.UoMScheduleId] = input.UoMScheduleId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ContractIdName] = input.ContractIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ServiceAddressName] = input.ServiceAddressName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ProductIdName] = input.ProductIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.UoMIdName] = input.UoMIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.UoMScheduleIdName] = input.UoMScheduleIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ContractStateCode] = input.ContractStateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ContractStateCodeName] = input.ContractStateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ServiceContractUnitsCodeName] = input.ServiceContractUnitsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.DiscountPercentage] = input.DiscountPercentage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.Discount_Base] = input.Discount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.Rate_Base] = input.Rate_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.Price_Base] = input.Price_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.Net_Base] = input.Net_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.AllotmentsOverage] = input.AllotmentsOverage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.ContractDetail.OwningTeam] = input.OwningTeam.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

