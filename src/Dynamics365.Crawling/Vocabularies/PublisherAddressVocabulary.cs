using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class PublisherAddressVocabulary : SimpleVocabulary
    {
        public PublisherAddressVocabulary()
        {
            VocabularyName = "Dynamics365 PublisherAddress";
            KeyPrefix = "dynamics365.publisheraddress";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("PublisherAddress", group =>
            {
                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the publisher address.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.Telephone3 = group.Add(new VocabularyKey("Telephone3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third telephone number for the publisher address.")
                    .WithDisplayName("Telephone 3")
                    .ModelProperty("telephone3", typeof(string)));

                this.Fax = group.Add(new VocabularyKey("Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Fax number for the publisher address.")
                    .WithDisplayName("Fax")
                    .ModelProperty("fax", typeof(string)));

                this.Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"Country/region name in the publisher address.")
                    .WithDisplayName("Country")
                    .ModelProperty("country", typeof(string)));

                this.Telephone1 = group.Add(new VocabularyKey("Telephone1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"First telephone number for the publisher address.")
                    .WithDisplayName("Main Phone")
                    .ModelProperty("telephone1", typeof(string)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTC Conversion Time Zone Code")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.Longitude = group.Add(new VocabularyKey("Longitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Longitude for the publisher address.")
                    .WithDisplayName("Longitude")
                    .ModelProperty("longitude", typeof(double)));

                this.County = group.Add(new VocabularyKey("County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"County name in the publisher address.")
                    .WithDisplayName("County")
                    .ModelProperty("county", typeof(string)));

                this.Line2 = group.Add(new VocabularyKey("Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Second line for entering address information.")
                    .WithDisplayName("Street 2")
                    .ModelProperty("line2", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"Name used to identify the publisher address.")
                    .WithDisplayName("Address Name")
                    .ModelProperty("name", typeof(string)));

                this.ShippingMethodCode = group.Add(new VocabularyKey("ShippingMethodCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Method of shipment for the publisher address.")
                    .WithDisplayName("Shipping Method")
                    .ModelProperty("shippingmethodcode", typeof(string)));

                this.PublisherAddressId = group.Add(new VocabularyKey("PublisherAddressId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the publisher address.")
                    .WithDisplayName("Address")
                    .ModelProperty("publisheraddressid", typeof(Guid)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the publisher address was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.PrimaryContactName = group.Add(new VocabularyKey("PrimaryContactName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(150))
                    .WithDescription(@"Name of the primary contact at the publisher address.")
                    .WithDisplayName("Address Contact")
                    .ModelProperty("primarycontactname", typeof(string)));

                this.Latitude = group.Add(new VocabularyKey("Latitude", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Latitude for the publisher address.")
                    .WithDisplayName("Latitude")
                    .ModelProperty("latitude", typeof(double)));

                this.UTCOffset = group.Add(new VocabularyKey("UTCOffset", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"UTC offset for the address. This is the difference between local time and standard Coordinated Universal Time.")
                    .WithDisplayName("UTC Offset")
                    .ModelProperty("utcoffset", typeof(long)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.Line3 = group.Add(new VocabularyKey("Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Third line for entering address information.")
                    .WithDisplayName("Street 3")
                    .ModelProperty("line3", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the publisher address was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Time Zone Rule Version Number")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));

                this.PostOfficeBox = group.Add(new VocabularyKey("PostOfficeBox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"Post office box number in the publisher address.")
                    .WithDisplayName("Post Office Box")
                    .ModelProperty("postofficebox", typeof(string)));

                this.UPSZone = group.Add(new VocabularyKey("UPSZone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(4))
                    .WithDescription(@"United Parcel Service (UPS) zone for the address of the publisher.")
                    .WithDisplayName("UPS Zone")
                    .ModelProperty("upszone", typeof(string)));

                this.Telephone2 = group.Add(new VocabularyKey("Telephone2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"Second telephone number for the publisher address.")
                    .WithDisplayName("Phone 2")
                    .ModelProperty("telephone2", typeof(string)));

                this.FreightTermsCode = group.Add(new VocabularyKey("FreightTermsCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Freight terms for the publisher address.")
                    .WithDisplayName("Freight Terms")
                    .ModelProperty("freighttermscode", typeof(string)));

                this.ParentId = group.Add(new VocabularyKey("ParentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the parent object with which the publisher address is associated.")
                    .WithDisplayName("Parent")
                    .ModelProperty("parentid", typeof(string)));

                this.PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(20))
                    .WithDescription(@"ZIP Code or postal code in the publisher address.")
                    .WithDisplayName("ZIP/Postal Code")
                    .ModelProperty("postalcode", typeof(string)));

                this.AddressNumber = group.Add(new VocabularyKey("AddressNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies which publisher address is applicable.")
                    .WithDisplayName("Address Number")
                    .ModelProperty("addressnumber", typeof(long)));

                this.City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(80))
                    .WithDescription(@"City name in the publisher address.")
                    .WithDisplayName("City")
                    .ModelProperty("city", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the publisher address.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.StateOrProvince = group.Add(new VocabularyKey("StateOrProvince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"State or province in the publisher address.")
                    .WithDisplayName("State/Province")
                    .ModelProperty("stateorprovince", typeof(string)));

                this.AddressTypeCode = group.Add(new VocabularyKey("AddressTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of address for the publisher, such as billing, shipping, or primary address.")
                    .WithDisplayName("Address Type")
                    .ModelProperty("addresstypecode", typeof(string)));

                this.Line1 = group.Add(new VocabularyKey("Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(50))
                    .WithDescription(@"First line for entering address information.")
                    .WithDisplayName("Street 1")
                    .ModelProperty("line1", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ShippingMethodCodeName = group.Add(new VocabularyKey("ShippingMethodCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ShippingMethodCodeName")
                    .ModelProperty("shippingmethodcodename", typeof(string)));

                this.FreightTermsCodeName = group.Add(new VocabularyKey("FreightTermsCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("FreightTermsCodeName")
                    .ModelProperty("freighttermscodename", typeof(string)));

                this.AddressTypeCodeName = group.Add(new VocabularyKey("AddressTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AddressTypeCodeName")
                    .ModelProperty("addresstypecodename", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.ParentIdTypeCode = group.Add(new VocabularyKey("ParentIdTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("Parent Object Type")
                    .ModelProperty("parentidtypecode", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the publisher address.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the publisher address.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey Telephone3 { get; private set; }

        public VocabularyKey Fax { get; private set; }

        public VocabularyKey Country { get; private set; }

        public VocabularyKey Telephone1 { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey Longitude { get; private set; }

        public VocabularyKey County { get; private set; }

        public VocabularyKey Line2 { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey ShippingMethodCode { get; private set; }

        public VocabularyKey PublisherAddressId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey PrimaryContactName { get; private set; }

        public VocabularyKey Latitude { get; private set; }

        public VocabularyKey UTCOffset { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey Line3 { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }

        public VocabularyKey PostOfficeBox { get; private set; }

        public VocabularyKey UPSZone { get; private set; }

        public VocabularyKey Telephone2 { get; private set; }

        public VocabularyKey FreightTermsCode { get; private set; }

        public VocabularyKey ParentId { get; private set; }

        public VocabularyKey PostalCode { get; private set; }

        public VocabularyKey AddressNumber { get; private set; }

        public VocabularyKey City { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey StateOrProvince { get; private set; }

        public VocabularyKey AddressTypeCode { get; private set; }

        public VocabularyKey Line1 { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ShippingMethodCodeName { get; private set; }

        public VocabularyKey FreightTermsCodeName { get; private set; }

        public VocabularyKey AddressTypeCodeName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ParentIdTypeCode { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }


    }
}

