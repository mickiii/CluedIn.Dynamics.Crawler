using System;
using System.Linq;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public abstract class LeadAddressClueProducer<T> : DynamicsClueProducer<T> where T : LeadAddress
    {
        public LeadAddressClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state) : base(factory, state)
        {
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = this._factory.Create(EntityType.Unknown, input.LeadAddressId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=leadaddress&id={1}", _dynamics365CrawlJobData.Url, input.LeadAddressId.ToString()), UriKind.Absolute, out Uri uri))
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

            var vocab = new LeadAddressVocabulary();

            data.Properties[vocab.ParentId] = input.ParentId.PrintIfAvailable();
            data.Properties[vocab.LeadAddressId] = input.LeadAddressId.PrintIfAvailable();
            data.Properties[vocab.AddressNumber] = input.AddressNumber.PrintIfAvailable();
            data.Properties[vocab.AddressTypeCode] = input.AddressTypeCode.PrintIfAvailable();
            data.Properties[vocab.Name] = input.Name.PrintIfAvailable();
            data.Properties[vocab.Line1] = input.Line1.PrintIfAvailable();
            data.Properties[vocab.Line2] = input.Line2.PrintIfAvailable();
            data.Properties[vocab.Line3] = input.Line3.PrintIfAvailable();
            data.Properties[vocab.City] = input.City.PrintIfAvailable();
            data.Properties[vocab.StateOrProvince] = input.StateOrProvince.PrintIfAvailable();
            data.Properties[vocab.County] = input.County.PrintIfAvailable();
            data.Properties[vocab.Country] = input.Country.PrintIfAvailable();
            data.Properties[vocab.PostOfficeBox] = input.PostOfficeBox.PrintIfAvailable();
            data.Properties[vocab.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[vocab.UTCOffset] = input.UTCOffset.PrintIfAvailable();
            data.Properties[vocab.UPSZone] = input.UPSZone.PrintIfAvailable();
            data.Properties[vocab.Latitude] = input.Latitude.PrintIfAvailable();
            data.Properties[vocab.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[vocab.Longitude] = input.Longitude.PrintIfAvailable();
            data.Properties[vocab.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[vocab.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[vocab.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[vocab.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[vocab.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[vocab.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[vocab.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[vocab.ParentIdName] = input.ParentIdName.PrintIfAvailable();
            data.Properties[vocab.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[vocab.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[vocab.AddressTypeCodeName] = input.AddressTypeCodeName.PrintIfAvailable();
            data.Properties[vocab.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[vocab.ParentIdYomiName] = input.ParentIdYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[vocab.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyId] = input.TransactionCurrencyId.PrintIfAvailable();
            data.Properties[vocab.TransactionCurrencyIdName] = input.TransactionCurrencyIdName.PrintIfAvailable();
            data.Properties[vocab.ExchangeRate] = input.ExchangeRate.PrintIfAvailable();
            data.Properties[vocab.Composite] = input.Composite.PrintIfAvailable();
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.OwnerId] = input.OwnerId.PrintIfAvailable();
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[vocab.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

            // Add custom vocab
            foreach (var key in input.Custom.Keys)
            {
                var vocabName = $"{vocab.KeyPrefix}{vocab.KeySeparator}{key}";
                var vocabKey = new VocabularyKey(vocabName, VocabularyKeyDataType.Json, VocabularyKeyVisibility.Visible);
                data.Properties[vocabKey] = input.Custom[key].ToString().PrintIfAvailable();
            }

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

