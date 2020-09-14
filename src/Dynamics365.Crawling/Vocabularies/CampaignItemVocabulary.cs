using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class CampaignItemVocabulary : SimpleVocabulary
    {
        public CampaignItemVocabulary()
        {
            VocabularyName = "Dynamics365 CampaignItem";
            KeyPrefix = "dynamics365.campaignItem";
            KeySeparator = ".";
            Grouping = "/CampaignItem";

            AddGroup("Campaign", group =>
            {
                CampaignItemId = group.Add(new VocabularyKey("CampaignItemId", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CampaignItemId")
                    .ModelProperty("campaignitemid", typeof(Guid)));

                EntityId = group.Add(new VocabularyKey("EntityId", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityId")
                    .ModelProperty("entityid", typeof(Guid)));

                EntityType = group.Add(new VocabularyKey("EntityType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("EntityType")
                    .ModelProperty("entitytype", typeof(string)));

                ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ImportSequenceNumber")
                    .ModelProperty("importsequencenumber", typeof(int)));

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

                OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwningBusinessUnit")
                    .ModelProperty("owningbusinessunit", typeof(Guid)));

                OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwningUser")
                    .ModelProperty("owninguser", typeof(Guid)));

                TimezoneRuleVersionNumber = group.Add(new VocabularyKey("TimezoneRuleVersionNumber", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("TimezoneRuleVersionNumber")
                    .ModelProperty("timezoneruleversionnumber", typeof(int)));

                UtcConversionTimezoneCode = group.Add(new VocabularyKey("UtcConversionTimezoneCode", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("UtcConversionTimezoneCode")
                    .ModelProperty("utcconversiontimezonecdoe", typeof(int)));

                VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(long)));

            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey CampaignItemId { get; private set; }
        public VocabularyKey EntityId { get; private set; }
        public VocabularyKey EntityType { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey TimezoneRuleVersionNumber { get; private set; }
        public VocabularyKey UtcConversionTimezoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }

    }
}

