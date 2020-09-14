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
    public abstract class PublisherAddressClueProducer<T> : DynamicsClueProducer<T> where T : PublisherAddress
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PublisherAddressClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PublisherAddressId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=publisheraddress&id={1}", _dynamics365CrawlJobData.Api, input.PublisherAddressId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ParentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.publisher, EntityEdgeType.Parent, input, input.ParentId);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);


            */
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Country] = input.Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Longitude] = input.Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.County] = input.County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Line2] = input.Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.PublisherAddressId] = input.PublisherAddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.PrimaryContactName] = input.PrimaryContactName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Latitude] = input.Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.UTCOffset] = input.UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Line3] = input.Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.PostOfficeBox] = input.PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.UPSZone] = input.UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.FreightTermsCode] = input.FreightTermsCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ParentId] = input.ParentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.AddressNumber] = input.AddressNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.City] = input.City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.StateOrProvince] = input.StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.AddressTypeCode] = input.AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.Line1] = input.Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.FreightTermsCodeName] = input.FreightTermsCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.AddressTypeCodeName] = input.AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ParentIdTypeCode] = input.ParentIdTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.PublisherAddress.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

