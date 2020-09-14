using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class RoleTemplateVocabulary : SimpleVocabulary
    {
        public RoleTemplateVocabulary()
        {
            VocabularyName = "Dynamics365 RoleTemplate";
            KeyPrefix = "dynamics365.roletemplate";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("RoleTemplate", group =>
            {
                this.RoleTemplateId = group.Add(new VocabularyKey("RoleTemplateId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the role template.")
                    .WithDisplayName("RoleTemplateId")
                    .ModelProperty("roletemplateid", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the role template.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.Upgrading = group.Add(new VocabularyKey("Upgrading", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Upgrading")
                    .ModelProperty("upgrading", typeof(bool)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey RoleTemplateId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey Upgrading { get; private set; }


    }
}

