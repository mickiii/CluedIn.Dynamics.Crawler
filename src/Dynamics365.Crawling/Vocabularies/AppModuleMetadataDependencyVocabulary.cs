using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AppModuleMetadataDependencyVocabulary : SimpleVocabulary
    {
        public AppModuleMetadataDependencyVocabulary()
        {
            VocabularyName = "Dynamics365 AppModuleMetadataDependency";
            KeyPrefix = "dynamics365.appmodulemetadatadependency";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("AppModuleMetadataDependency", group =>
            {
                this.AppModuleMetadataDependencyId = group.Add(new VocabularyKey("AppModuleMetadataDependencyId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("AppModule Metadata Dependency Id")
                    .ModelProperty("appmodulemetadatadependencyid", typeof(Guid)));

                this.DependentComponentId = group.Add(new VocabularyKey("DependentComponentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Dependent Component Id")
                    .ModelProperty("dependentcomponentid", typeof(Guid)));

                this.RequiredComponentType = group.Add(new VocabularyKey("RequiredComponentType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Required Component Type")
                    .ModelProperty("requiredcomponenttype", typeof(long)));

                this.RequiredComponentId = group.Add(new VocabularyKey("RequiredComponentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Required Component Id")
                    .ModelProperty("requiredcomponentid", typeof(Guid)));

                this.RequiredComponentVersion = group.Add(new VocabularyKey("RequiredComponentVersion", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Required Component Version")
                    .ModelProperty("requiredcomponentversion", typeof(int)));

                this.State = group.Add(new VocabularyKey("State", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("State of the record")
                    .ModelProperty("state", typeof(long)));

                this.RequiredComponentSubType = group.Add(new VocabularyKey("RequiredComponentSubType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Required Component Sub-Type")
                    .ModelProperty("requiredcomponentsubtype", typeof(long)));

                this.RequiredComponentInternalId = group.Add(new VocabularyKey("RequiredComponentInternalId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(300))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Required Component Internal Id")
                    .ModelProperty("requiredcomponentinternalid", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey AppModuleMetadataDependencyId { get; private set; }

        public VocabularyKey DependentComponentId { get; private set; }

        public VocabularyKey RequiredComponentType { get; private set; }

        public VocabularyKey RequiredComponentId { get; private set; }

        public VocabularyKey RequiredComponentVersion { get; private set; }

        public VocabularyKey State { get; private set; }

        public VocabularyKey RequiredComponentSubType { get; private set; }

        public VocabularyKey RequiredComponentInternalId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }


    }
}

