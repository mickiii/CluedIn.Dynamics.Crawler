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
    public abstract class PublisherClueProducer<T> : DynamicsClueProducer<T> where T : Publisher
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public PublisherClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.PublisherId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=publisher&id={1}", _dynamics365CrawlJobData.Api, input.PublisherId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.FriendlyName;
            /*
             if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);

                         if (input.EntityImageId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.imagedescriptor, EntityEdgeType.Parent, input, input.EntityImageId);


            */
            data.Properties[Dynamics365Vocabulary.Publisher.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Telephone3] = input.Address1_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Description] = input.Description.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Country] = input.Address2_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Telephone2] = input.Address1_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_AddressTypeCode] = input.Address2_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_AddressTypeCode] = input.Address1_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Line3] = input.Address1_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Name] = input.Address2_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_AddressId] = input.Address1_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_AddressId] = input.Address2_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Latitude] = input.Address1_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_County] = input.Address2_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Country] = input.Address1_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_City] = input.Address2_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.EMailAddress] = input.EMailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_ShippingMethodCode] = input.Address1_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Longitude] = input.Address2_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Line2] = input.Address2_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_UTCOffset] = input.Address1_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_County] = input.Address1_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Fax] = input.Address1_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_UTCOffset] = input.Address2_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Name] = input.Address1_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_UPSZone] = input.Address1_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_PostOfficeBox] = input.Address1_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.CustomizationPrefix] = input.CustomizationPrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_StateOrProvince] = input.Address2_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_ShippingMethodCode] = input.Address2_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Telephone2] = input.Address2_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_UPSZone] = input.Address2_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Telephone1] = input.Address1_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.SupportingWebsiteUrl] = input.SupportingWebsiteUrl.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Longitude] = input.Address1_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_PostOfficeBox] = input.Address2_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Latitude] = input.Address2_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Line3] = input.Address2_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Telephone1] = input.Address2_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.PublisherId] = input.PublisherId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Line1] = input.Address2_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Line2] = input.Address1_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_PostalCode] = input.Address2_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_PostalCode] = input.Address1_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_StateOrProvince] = input.Address1_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_Line1] = input.Address1_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Fax] = input.Address2_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_City] = input.Address1_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_Telephone3] = input.Address2_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_ShippingMethodCodeName] = input.Address1_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_AddressTypeCodeName] = input.Address2_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address2_ShippingMethodCodeName] = input.Address2_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.Address1_AddressTypeCodeName] = input.Address1_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.UniqueName] = input.UniqueName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.FriendlyName] = input.FriendlyName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.CustomizationOptionValuePrefix] = input.CustomizationOptionValuePrefix.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.PinpointPublisherId] = input.PinpointPublisherId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.PinpointPublisherDefaultLocale] = input.PinpointPublisherDefaultLocale.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.IsReadonly] = input.IsReadonly.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.EntityImage] = input.EntityImage.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.EntityImage_URL] = input.EntityImage_URL.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.EntityImageId] = input.EntityImageId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Publisher.EntityImage_Timestamp] = input.EntityImage_Timestamp.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

