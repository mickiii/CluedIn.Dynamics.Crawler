using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class RuntimeDependencyVocabulary : SimpleVocabulary
    {
        public RuntimeDependencyVocabulary()
        {
            VocabularyName = "Dynamics365 RuntimeDependency";
            KeyPrefix = "dynamics365.runtimedependency";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("RuntimeDependency", group =>
            {
                this.DependencyId = group.Add(new VocabularyKey("DependencyId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of a dependency.")
                    .WithDisplayName("Dependency Identifier")
                    .ModelProperty("dependencyid", typeof(Guid)));

                this.DependentComponentNodeId = group.Add(new VocabularyKey("DependentComponentNodeId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the dependent component's node.")
                    .WithDisplayName("Dependent Component")
                    .ModelProperty("dependentcomponentnodeid", typeof(Guid)));

                this.RequiredComponentNodeId = group.Add(new VocabularyKey("RequiredComponentNodeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(300))
                    .WithDescription(@"Unique identifier of the required component's node")
                    .WithDisplayName("Required Component")
                    .ModelProperty("requiredcomponentnodeid", typeof(string)));

                this.DependentComponentType = group.Add(new VocabularyKey("DependentComponentType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Dependent Component Node Type")
                    .WithDisplayName("Dependent Component Node Type")
                    .ModelProperty("dependentcomponenttype", typeof(long)));

                this.RequiredComponentType = group.Add(new VocabularyKey("RequiredComponentType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Required Component Node Type")
                    .WithDisplayName("Required Component Node Type")
                    .ModelProperty("requiredcomponenttype", typeof(long)));

                this.CreatedTime = group.Add(new VocabularyKey("CreatedTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the record was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdtime", typeof(DateTime)));

                this.RequiredComponentModifiedTime = group.Add(new VocabularyKey("RequiredComponentModifiedTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the required component was modified.")
                    .WithDisplayName("Created On")
                    .ModelProperty("requiredcomponentmodifiedtime", typeof(DateTime)));

                this.IsPublished = group.Add(new VocabularyKey("IsPublished", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Determines whether required component is published")
                    .WithDisplayName("IsPublished")
                    .ModelProperty("ispublished", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey DependencyId { get; private set; }

        public VocabularyKey DependentComponentNodeId { get; private set; }

        public VocabularyKey RequiredComponentNodeId { get; private set; }

        public VocabularyKey DependentComponentType { get; private set; }

        public VocabularyKey RequiredComponentType { get; private set; }

        public VocabularyKey CreatedTime { get; private set; }

        public VocabularyKey RequiredComponentModifiedTime { get; private set; }

        public VocabularyKey IsPublished { get; private set; }


    }
}

