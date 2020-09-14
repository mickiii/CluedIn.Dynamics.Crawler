using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ContactLeadVocabulary : SimpleVocabulary
    {
        public ContactLeadVocabulary()
        {
            VocabularyName = "Dynamics365 ContactLead";
            KeyPrefix = "dynamics365.contactLead";
            KeySeparator = ".";
            Grouping = EntityType.Sales.Lead;

            AddGroup("ContactLead", group =>
            {
                ContactId = group.Add(new VocabularyKey("ContactId", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName(@"ContactId")
                    .ModelProperty("contactid", typeof(Guid)));

                ContactLeadId = group.Add(new VocabularyKey("ContactLeadId", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName(@"ContactLeadId")
                    .ModelProperty("contactleadid", typeof(Guid)));

                ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName(@"ImportSequenceNumber")
                    .ModelProperty("importsequencenumber", typeof(int)));

                LeadId = group.Add(new VocabularyKey("LeadId", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName(@"LeadId")
                    .ModelProperty("leadid", typeof(Guid)));

                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName(@"Name")
                    .ModelProperty("name", typeof(string)));

                OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName(@"OverriddenCreatedOn")
                    .ModelProperty("overriddencreatedon", typeof(DateTimeOffset)));

                TimezoneRuleVersionNumber = group.Add(new VocabularyKey("TimezoneRuleVersionNumber", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName(@"TimezoneRuleVersionNumber")
                    .ModelProperty("timezoneruleversionnumber", typeof(int)));

                UtcConversionTimezoneCode = group.Add(new VocabularyKey("UtcConversionTimezoneCode", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName(@"UtcConversionTimezoneCode")
                    .ModelProperty("utcconversiontimezonecode", typeof(int)));

                VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName(@"VersionNumber")
                    .ModelProperty("versionnumber", typeof(long)));
                });
        }

        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey ContactLeadId { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey LeadId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimezoneRuleVersionNumber { get; private set; }
        public VocabularyKey UtcConversionTimezoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }

    }
}
