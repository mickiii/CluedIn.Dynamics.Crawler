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
    public abstract class InternalAddressClueProducer<T> : DynamicsClueProducer<T> where T : InternalAddress
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public InternalAddressClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.InternalAddressId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=internaladdress&id={1}", _dynamics365CrawlJobData.Api, input.InternalAddressId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            //TODO data.Name = input.;
            /*
             if (input.ParentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.businessunit, EntityEdgeType.Parent, input, input.ParentId);

                         if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.ParentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ParentId);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ParentId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.site, EntityEdgeType.Parent, input, input.ParentId);


            */
            data.Properties[Dynamics365Vocabulary.InternalAddress.ParentId] = input.ParentId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.InternalAddressId] = input.InternalAddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.AddressNumber] = input.AddressNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ObjectTypeCode] = input.ObjectTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.AddressTypeCode] = input.AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Line1] = input.Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Line2] = input.Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Line3] = input.Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.City] = input.City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.StateOrProvince] = input.StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.County] = input.County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Country] = input.Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.PostOfficeBox] = input.PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.UTCOffset] = input.UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.UPSZone] = input.UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Latitude] = input.Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Longitude] = input.Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ShippingMethodCode] = input.ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ShippingMethodCodeName] = input.ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.AddressTypeCodeName] = input.AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ObjectTypeCodeName] = input.ObjectTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.Composite] = input.Composite.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.BusinessUnitId] = input.BusinessUnitId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.InternalAddress.OrganizationId] = input.OrganizationId.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

