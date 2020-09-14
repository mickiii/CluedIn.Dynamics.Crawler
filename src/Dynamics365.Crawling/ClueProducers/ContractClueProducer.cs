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
    public abstract class ContractClueProducer<T> : DynamicsClueProducer<T> where T : Contract
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public ContractClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Sales.Contract, input.ContractId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=contract&id={1}", this._dynamics365CrawlJobData.Api, input.ContractId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Title;

            if (input.OwningTeam != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.Group, EntityEdgeType.Parent, input, input.OwningTeam);

            if (input.CustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.CustomerId);

            if (input.BillingCustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.Parent, input, input.BillingCustomerId);

            //if (input.ContractTemplateId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.contracttemplate, EntityEdgeType.Parent, input, input.ContractTemplateId);

            //if (input.TransactionCurrencyId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

            if (input.BillingCustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.BillingCustomerId);

            if (input.CustomerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, input, input.CustomerId);

            if (input.OwningBusinessUnit != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Organization.Unit, EntityEdgeType.OwnedBy, input, input.OwningBusinessUnit);

            if (input.CreatedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedBy);

            if (input.OwningUser != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwningUser);

            if (input.ModifiedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedOnBehalfBy);

            if (input.ModifiedBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.ModifiedBy);

            if (input.CreatedOnBehalfBy != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.CreatedOnBehalfBy);

            //if (input.ServiceAddress != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.customeraddress, EntityEdgeType.Parent, input, input.ServiceAddress);

            //if (input.BillToAddress != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.customeraddress, EntityEdgeType.Parent, input, input.BillToAddress);

            if (input.OriginatingContract != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Contract, EntityEdgeType.Parent, input, input.OriginatingContract);

            if (input.OwnerId != null)
                this._factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.OwnedBy, input, input.OwnerId);

            //if (input.EntityImageId != null)
            //    this._factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);

            data.Properties[Dynamics365Vocabulary.Contract.ContractId] = input.ContractId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ContractTemplateId] = input.ContractTemplateId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ContractServiceLevelCode] = input.ContractServiceLevelCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ServiceAddress] = input.ServiceAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillToAddress] = input.BillToAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ContactId] = input.ContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.AccountId] = input.AccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingAccountId] = input.BillingAccountId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ContractNumber] = input.ContractNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingContactId] = input.BillingContactId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ActiveOn] = input.ActiveOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ExpiresOn] = input.ExpiresOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CancelOn] = input.CancelOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.Title] = input.Title.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ContractLanguage] = input.ContractLanguage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingStartOn] = input.BillingStartOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.EffectivityCalendar] = input.EffectivityCalendar.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingEndOn] = input.BillingEndOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingFrequencyCode] = input.BillingFrequencyCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.AllotmentTypeCode] = input.AllotmentTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.UseDiscountAsPercentage] = input.UseDiscountAsPercentage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.TotalPrice] = input.TotalPrice.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.TotalDiscount] = input.TotalDiscount.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.StateCode] = input.StateCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.NetPrice] = input.NetPrice.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.StatusCode] = input.StatusCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.OriginatingContract] = input.OriginatingContract.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.Duration] = input.Duration.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ContactIdName] = input.ContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.AccountIdName] = input.AccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingContactIdName] = input.BillingContactIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingAccountIdName] = input.BillingAccountIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ContractTemplateIdName] = input.ContractTemplateIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.OriginatingContractName] = input.OriginatingContractName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillToAddressName] = input.BillToAddressName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ServiceAddressName] = input.ServiceAddressName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ContractTemplateAbbreviation] = input.ContractTemplateAbbreviation.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CustomerIdName] = input.CustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CustomerIdType] = input.CustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingCustomerId] = input.BillingCustomerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingCustomerIdName] = input.BillingCustomerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingCustomerIdType] = input.BillingCustomerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.OwnerIdName] = input.OwnerIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.UseDiscountAsPercentageName] = input.UseDiscountAsPercentageName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingFrequencyCodeName] = input.BillingFrequencyCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ContractServiceLevelCodeName] = input.ContractServiceLevelCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.StatusCodeName] = input.StatusCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.StateCodeName] = input.StateCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.AllotmentTypeCodeName] = input.AllotmentTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.TotalDiscount_Base] = input.TotalDiscount_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.NetPrice_Base] = input.NetPrice_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.TotalPrice_Base] = input.TotalPrice_Base.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingContactIdYomiName] = input.BillingContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingAccountIdYomiName] = input.BillingAccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.OwnerIdYomiName] = input.OwnerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.BillingCustomerIdYomiName] = input.BillingCustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ContactIdYomiName] = input.ContactIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.AccountIdYomiName] = input.AccountIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CustomerIdYomiName] = input.CustomerIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.OwningTeam] = input.OwningTeam.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Contract.EmailAddress] = input.EmailAddress.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

