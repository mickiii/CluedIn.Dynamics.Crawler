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
    public abstract class SiteClueProducer<T> : DynamicsClueProducer<T> where T : Site
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public SiteClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
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

            var clue = this._factory.Create(EntityType.Unknown, input.SiteId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=site&id={1}", _dynamics365CrawlJobData.Api, input.SiteId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;
            /*
             if (input.CreatedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedBy);

                         if (input.CreatedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.CreatedOnBehalfBy);

                         if (input.ModifiedBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedBy);

                         if (input.ModifiedOnBehalfBy != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.systemuser, EntityEdgeType.Parent, input, input.ModifiedOnBehalfBy);

                         if (input.OrganizationId != null)
                            _factory.CreateOutgoingEntityReference(clue, EntityType.organization, EntityEdgeType.Parent, input, input.OrganizationId);


            */
            data.Properties[Dynamics365Vocabulary.Site.Address2_Latitude] = input.Address2_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_County] = input.Address1_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_UPSZone] = input.Address2_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_ShippingMethodCode] = input.Address1_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_AddressId] = input.Address1_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_StateOrProvince] = input.Address2_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.VersionNumber] = input.VersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Latitude] = input.Address1_Latitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_PostOfficeBox] = input.Address1_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Longitude] = input.Address1_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Telephone2] = input.Address1_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.OrganizationId] = input.OrganizationId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.EMailAddress] = input.EMailAddress.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_ShippingMethodCode] = input.Address2_ShippingMethodCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Country] = input.Address1_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Name] = input.Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_AddressId] = input.Address2_AddressId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_City] = input.Address1_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_Line3] = input.Address2_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.SiteId] = input.SiteId.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Line3] = input.Address1_Line3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_AddressTypeCode] = input.Address1_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_Fax] = input.Address2_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_UTCOffset] = input.Address1_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_City] = input.Address2_City.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.ModifiedBy] = input.ModifiedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_Telephone3] = input.Address2_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_Line1] = input.Address2_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_Longitude] = input.Address2_Longitude.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_UTCOffset] = input.Address2_UTCOffset.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_UPSZone] = input.Address1_UPSZone.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_Country] = input.Address2_Country.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_PostOfficeBox] = input.Address2_PostOfficeBox.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_Telephone2] = input.Address2_Telephone2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_County] = input.Address2_County.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_PostalCode] = input.Address1_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_Telephone1] = input.Address2_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Fax] = input.Address1_Fax.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_AddressTypeCode] = input.Address2_AddressTypeCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Telephone1] = input.Address1_Telephone1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.TimeZoneCode] = input.TimeZoneCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Name] = input.Address1_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Telephone3] = input.Address1_Telephone3.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_PostalCode] = input.Address2_PostalCode.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_Name] = input.Address2_Name.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.CreatedBy] = input.CreatedBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Line1] = input.Address1_Line1.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_Line2] = input.Address2_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_Line2] = input.Address1_Line2.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_StateOrProvince] = input.Address1_StateOrProvince.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_AddressTypeCodeName] = input.Address1_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_AddressTypeCodeName] = input.Address2_AddressTypeCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.CreatedByName] = input.CreatedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address2_ShippingMethodCodeName] = input.Address2_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.ModifiedByName] = input.ModifiedByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.Address1_ShippingMethodCodeName] = input.Address1_ShippingMethodCodeName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.ModifiedByYomiName] = input.ModifiedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.CreatedByYomiName] = input.CreatedByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.CreatedOnBehalfBy] = input.CreatedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.CreatedOnBehalfByName] = input.CreatedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.CreatedOnBehalfByYomiName] = input.CreatedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.ModifiedOnBehalfBy] = input.ModifiedOnBehalfBy.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.ModifiedOnBehalfByName] = input.ModifiedOnBehalfByName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.ModifiedOnBehalfByYomiName] = input.ModifiedOnBehalfByYomiName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.OrganizationIdName] = input.OrganizationIdName.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.TimeZoneRuleVersionNumber] = input.TimeZoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[Dynamics365Vocabulary.Site.UTCConversionTimeZoneCode] = input.UTCConversionTimeZoneCode.PrintIfAvailable();

            this.Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                this._factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

