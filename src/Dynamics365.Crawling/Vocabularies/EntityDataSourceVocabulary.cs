using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class EntityDataSourceVocabulary : SimpleVocabulary
    {
        public EntityDataSourceVocabulary()
        {
            VocabularyName = "Dynamics365 EntityDataSource";
            KeyPrefix = "dynamics365.entitydatasource";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("EntityDataSource", group =>
            {
                this.EntityDataSourceId = group.Add(new VocabularyKey("EntityDataSourceId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the Data Source Id")
                    .WithDisplayName("Data Source Id")
                    .ModelProperty("entitydatasourceid", typeof(Guid)));

                this.EntityName = group.Add(new VocabularyKey("EntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Entity Logical Name")
                    .WithDisplayName("Entity Logical Name")
                    .ModelProperty("entityname", typeof(string)));

                this.ConnectionDefinition = group.Add(new VocabularyKey("ConnectionDefinition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"JSON data representing values from a data source entity as individual fields.")
                    .WithDisplayName("Data Source Values")
                    .ModelProperty("connectiondefinition", typeof(string)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated solution.")
                    .WithDisplayName("Solution")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the solution component is part of a managed solution.")
                    .WithDisplayName("State")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.SupportingSolutionId = group.Add(new VocabularyKey("SupportingSolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Solution")
                    .ModelProperty("supportingsolutionid", typeof(Guid)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the form is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the organization.")
                    .WithDisplayName("Organization Id")
                    .ModelProperty("organizationid", typeof(Guid)));

                this.EntityDataSourceIdUnique = group.Add(new VocabularyKey("EntityDataSourceIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Unique Id")
                    .ModelProperty("entitydatasourceidunique", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Name of this data source. This name appears in the data source drop-down when creating a new entity.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.ConnectionDefinitionSecrets = group.Add(new VocabularyKey("ConnectionDefinitionSecrets", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"JSON data representing secrets in a data source entity as individual fields.")
                    .WithDisplayName("Data Source Secrets")
                    .ModelProperty("connectiondefinitionsecrets", typeof(string)));

                this.EntityDataProviderId = group.Add(new VocabularyKey("EntityDataProviderId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the entity dataprovider for the entity datasource.")
                    .WithDisplayName("Entity Provider")
                    .ModelProperty("entitydataproviderid", typeof(string)));

                this.EntityDataProviderIdName = group.Add(new VocabularyKey("EntityDataProviderIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("Entity Provider Name")
                    .ModelProperty("entitydataprovideridname", typeof(string)));

                this.IsCustomizable = group.Add(new VocabularyKey("IsCustomizable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component can be customized.")
                    .WithDisplayName("Customizable")
                    .ModelProperty("iscustomizable", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1000))
                    .WithDescription(@"Enter additional information to describe the environment this data source targets and the purpose of this system.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey EntityDataSourceId { get; private set; }

        public VocabularyKey EntityName { get; private set; }

        public VocabularyKey ConnectionDefinition { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey EntityDataSourceIdUnique { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey ConnectionDefinitionSecrets { get; private set; }

        public VocabularyKey EntityDataProviderId { get; private set; }

        public VocabularyKey EntityDataProviderIdName { get; private set; }

        public VocabularyKey IsCustomizable { get; private set; }

        public VocabularyKey Description { get; private set; }


    }
}

