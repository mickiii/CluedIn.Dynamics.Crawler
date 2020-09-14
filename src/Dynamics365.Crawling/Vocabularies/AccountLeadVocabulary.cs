using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AccountLeadVocabulary : SimpleVocabulary
    {
        public AccountLeadVocabulary()
        {
            VocabularyName = "Dynamics365 AccountLead";
            KeyPrefix = "dynamics365.accountLead";
            KeySeparator = ".";
            Grouping = EntityType.Organization;

            AddGroup("AccountLead", group =>
            {

                AccountId = group.Add(new VocabularyKey("AccountId", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AccountId")
                    .ModelProperty("accountid", typeof(Guid)));

                AccountLeadId = group.Add(new VocabularyKey("AccountLeadId", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AccountLeadId")
                    .ModelProperty("accountleadid", typeof(Guid)));

                ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ImportSequenceNumber")
                    .ModelProperty("importsequencenumber", typeof(int)));

                LeadId = group.Add(new VocabularyKey("LeadId", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("LeadId")
                    .ModelProperty("leadid", typeof(Guid)));

                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OverriddenCreatedOn")
                    .ModelProperty("overriddencreatedon", typeof(DateTimeOffset)));

                TimezoneRuleVersionNumber = group.Add(new VocabularyKey("TimezoneRuleVersionNumber", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TimezoneRuleVersionNumber")
                    .ModelProperty("timezoneruleversionnumber", typeof(int)));

                UtcConversionTimezoneCode = group.Add(new VocabularyKey("UtcConversionTimezoneCode", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("UtcConversionTimezoneCode")
                    .ModelProperty("utcconversiontimezonecode", typeof(int)));

                VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(long)));

            });

            // Mappings
            //AddMapping(City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }
        
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey AccountLeadId { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey LeadId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimezoneRuleVersionNumber { get; private set; }
        public VocabularyKey UtcConversionTimezoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }

    }
}

