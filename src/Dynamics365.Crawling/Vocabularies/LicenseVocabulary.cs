using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class LicenseVocabulary : SimpleVocabulary
    {
        public LicenseVocabulary()
        {
            VocabularyName = "Dynamics365 License";
            KeyPrefix = "dynamics365.license";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("License", group =>
            {
                this.LicenseId = group.Add(new VocabularyKey("LicenseId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the license.")
                    .WithDisplayName("LicenseId")
                    .ModelProperty("licenseid", typeof(Guid)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the license.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.LicenseKey = group.Add(new VocabularyKey("LicenseKey", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Key for the license.")
                    .WithDisplayName("LicenseKey")
                    .ModelProperty("licensekey", typeof(string)));

                this.InstalledOn = group.Add(new VocabularyKey("InstalledOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Date and time when the license was installed.")
                    .WithDisplayName("InstalledOn")
                    .ModelProperty("installedon", typeof(DateTime)));

                this.LicenseType = group.Add(new VocabularyKey("LicenseType", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of license, such as Professional, Standard, or Suite.")
                    .WithDisplayName("LicenseType")
                    .ModelProperty("licensetype", typeof(Guid)));

                this.UTCConversionTimeZoneCode = group.Add(new VocabularyKey("UTCConversionTimeZoneCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Time zone code that was in use when the record was created.")
                    .WithDisplayName("UTCConversionTimeZoneCode")
                    .ModelProperty("utcconversiontimezonecode", typeof(long)));

                this.TimeZoneRuleVersionNumber = group.Add(new VocabularyKey("TimeZoneRuleVersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("TimeZoneRuleVersionNumber")
                    .ModelProperty("timezoneruleversionnumber", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey LicenseId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey LicenseKey { get; private set; }

        public VocabularyKey InstalledOn { get; private set; }

        public VocabularyKey LicenseType { get; private set; }

        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }

        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }


    }
}

