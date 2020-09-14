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
    public abstract class CustomerAddressClueProducer<T> : DynamicsClueProducer<T> where T : CustomerAddress
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CustomerAddressClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.CustomerAddressId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=customeraddress&id={1}", _dynamics365CrawlJobData.Api, input.CustomerAddressId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ParentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.contact, EntityEdgeType.Parent, input, input.ParentId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.ParentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.account, EntityEdgeType.Parent, input, input.ParentId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ParentId] = input.ParentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.CustomerAddressId] = input.CustomerAddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.AddressNumber] = input.AddressNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.AddressTypeCode] = input.AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.PrimaryContactName] = input.PrimaryContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Line1] = input.Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Line2] = input.Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Line3] = input.Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.City] = input.City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.StateOrProvince] = input.StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.County] = input.County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Country] = input.Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.PostOfficeBox] = input.PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.UTCOffset] = input.UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.FreightTermsCode] = input.FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.UPSZone] = input.UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Latitude] = input.Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Longitude] = input.Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.FreightTermsCodeName] = input.FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.AddressTypeCodeName] = input.AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ObjectTypeCodeName] = input.ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.OwnerIdType] = input.OwnerIdType.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ParentIdTypeCode] = input.ParentIdTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CustomerAddress.Composite] = input.Composite.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

