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
    public abstract class CompetitorAddressClueProducer<T> : DynamicsClueProducer<T> where T : CompetitorAddress
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CompetitorAddressClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.CompetitorAddressId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=competitoraddress&id={1}", _dynamics365CrawlJobData.Api, input.CompetitorAddressId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.ParentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.competitor, EntityEdgeType.Parent, input, input.ParentId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);


            */
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ParentId] = input.ParentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.CompetitorAddressId] = input.CompetitorAddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.AddressNumber] = input.AddressNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.AddressTypeCode] = input.AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Line1] = input.Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Line2] = input.Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Line3] = input.Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.City] = input.City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.StateOrProvince] = input.StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.County] = input.County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Country] = input.Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.PostOfficeBox] = input.PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.UTCOffset] = input.UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.UPSZone] = input.UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Latitude] = input.Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Longitude] = input.Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ParentIdName] = input.ParentIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.AddressTypeCodeName] = input.AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ParentIdYomiName] = input.ParentIdYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.Composite] = input.Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.CompetitorAddress.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

