using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class EntityDataProviderVocabulary : SimpleVocabulary
    {
        public EntityDataProviderVocabulary()
        {
            VocabularyName = "Dynamics365 EntityDataProvider";
            KeyPrefix = "dynamics365.entitydataprovider";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("EntityDataProvider", group =>
            {
                this.EntityDataProviderId = group.Add(new VocabularyKey("EntityDataProviderId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data provider.")
                    .WithDisplayName("Data Provider")
                    .ModelProperty("entitydataproviderid", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The name of this Data Provider. This is the name that appears in the dropdown when creating a new entity.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.RetrievePlugin = group.Add(new VocabularyKey("RetrievePlugin", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Retrieve Plugin")
                    .WithDisplayName("Retrieve Plugin")
                    .ModelProperty("retrieveplugin", typeof(Guid)));

                this.RetrieveMultiplePlugin = group.Add(new VocabularyKey("RetrieveMultiplePlugin", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"MultipleRetrieve Plugin")
                    .WithDisplayName("MultipleRetrieve Plugin")
                    .ModelProperty("retrievemultipleplugin", typeof(Guid)));

                this.CreatePlugin = group.Add(new VocabularyKey("CreatePlugin", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Create Plugin")
                    .WithDisplayName("Create Plugin")
                    .ModelProperty("createplugin", typeof(Guid)));

                this.DeletePlugin = group.Add(new VocabularyKey("DeletePlugin", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Delete Plugin")
                    .WithDisplayName("Delete Plugin")
                    .ModelProperty("deleteplugin", typeof(Guid)));

                this.UpdatePlugin = group.Add(new VocabularyKey("UpdatePlugin", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Update Plugin")
                    .WithDisplayName("Update Plugin")
                    .ModelProperty("updateplugin", typeof(Guid)));

                this.DataSourceLogicalName = group.Add(new VocabularyKey("DataSourceLogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"When creating a Data Provider, the end user must select the name of the Data Source entity that will be created for the provider.")
                    .WithDisplayName("Data Source Entity Logical Name")
                    .ModelProperty("datasourcelogicalname", typeof(string)));

                this.EntityDataProviderIdUnique = group.Add(new VocabularyKey("EntityDataProviderIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Unique Id")
                    .ModelProperty("entitydataprovideridunique", typeof(Guid)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated solution.")
                    .WithDisplayName("Solution")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.SupportingSolutionId = group.Add(new VocabularyKey("SupportingSolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Solution")
                    .ModelProperty("supportingsolutionid", typeof(Guid)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

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

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

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

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1000))
                    .WithDescription(@"What is this Data Provider used for and data store technologies does it target?")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.IsCustomizable = group.Add(new VocabularyKey("IsCustomizable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component can be customized.")
                    .WithDisplayName("Customizable")
                    .ModelProperty("iscustomizable", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey EntityDataProviderId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey RetrievePlugin { get; private set; }

        public VocabularyKey RetrieveMultiplePlugin { get; private set; }

        public VocabularyKey CreatePlugin { get; private set; }

        public VocabularyKey DeletePlugin { get; private set; }

        public VocabularyKey UpdatePlugin { get; private set; }

        public VocabularyKey DataSourceLogicalName { get; private set; }

        public VocabularyKey EntityDataProviderIdUnique { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey IsCustomizable { get; private set; }


    }
}

