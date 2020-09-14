using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class HierarchySecurityConfigurationVocabulary : SimpleVocabulary
    {
        public HierarchySecurityConfigurationVocabulary()
        {
            VocabularyName = "Dynamics365 HierarchySecurityConfiguration";
            KeyPrefix = "dynamics365.hierarchysecurityconfiguration";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("HierarchySecurityConfiguration", group =>
            {
                this.HierarchySecurityModelingSettingId = group.Add(new VocabularyKey("HierarchySecurityModelingSettingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the entity used for the Hierarchy Security Modeling Configuration.")
                    .WithDisplayName("HierarchySecurityModelingSettingId")
                    .ModelProperty("hierarchysecuritymodelingsettingid", typeof(Guid)));

                this.EntityName = group.Add(new VocabularyKey("EntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(64))
                    .WithDescription(@"Logical entity name of the entity that is configured for hierarchy security.")
                    .WithDisplayName("Entity Name")
                    .ModelProperty("entityname", typeof(string)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("ObjectTypeCode")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey HierarchySecurityModelingSettingId { get; private set; }

        public VocabularyKey EntityName { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }


    }
}

