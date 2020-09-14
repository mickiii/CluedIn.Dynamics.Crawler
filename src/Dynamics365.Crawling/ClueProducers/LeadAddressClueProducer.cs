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
    public abstract class LeadAddressClueProducer<T> : DynamicsClueProducer<T> where T : LeadAddress
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public LeadAddressClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.LeadAddressId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=leadaddress&id={1}", _dynamics365CrawlJobData.Api, input.LeadAddressId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ParentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.lead, EntityEdgeType.Parent, input, input.ParentId);

                         if (input.TransactionCurrencyId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.transactioncurrency, EntityEdgeType.Parent, input, input.TransactionCurrencyId);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.LeadAddress.ParentId] = input.ParentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.LeadAddressId] = input.LeadAddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.AddressNumber] = input.AddressNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.AddressTypeCode] = input.AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Line1] = input.Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Line2] = input.Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Line3] = input.Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.City] = input.City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.StateOrProvince] = input.StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.County] = input.County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Country] = input.Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.PostOfficeBox] = input.PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.UTCOffset] = input.UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.UPSZone] = input.UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Latitude] = input.Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Longitude] = input.Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ParentIdName] = input.ParentIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.AddressTypeCodeName] = input.AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ParentIdYomiName] = input.ParentIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.Composite] = input.Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.LeadAddress.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

