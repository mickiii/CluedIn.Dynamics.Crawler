using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class InvalidDependencyVocabulary : SimpleVocabulary
    {
        public InvalidDependencyVocabulary()
        {
            VocabularyName = "Dynamics365 InvalidDependency";
            KeyPrefix = "dynamics365.invaliddependency";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("InvalidDependency", group =>
            {
                this.InvalidDependencyId = group.Add(new VocabularyKey("InvalidDependencyId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the invalid dependency.")
                    .WithDisplayName("Invalid Dependency Identifier")
                    .ModelProperty("invaliddependencyid", typeof(Guid)));

                this.IsExistingNodeRequiredComponent = group.Add(new VocabularyKey("IsExistingNodeRequiredComponent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the existing node is the required component in the dependency")
                    .WithDisplayName("Is this node the required component")
                    .ModelProperty("isexistingnoderequiredcomponent", typeof(bool)));

                this.ExistingDependencyType = group.Add(new VocabularyKey("ExistingDependencyType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The dependency type of the invalid dependency.")
                    .WithDisplayName("Weight")
                    .ModelProperty("existingdependencytype", typeof(string)));

                this.MissingComponentType = group.Add(new VocabularyKey("MissingComponentType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The object type code of the missing component.")
                    .WithDisplayName("Type Code")
                    .ModelProperty("missingcomponenttype", typeof(string)));

                this.MissingComponentId = group.Add(new VocabularyKey("MissingComponentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the missing component.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("missingcomponentid", typeof(Guid)));

                this.MissingComponentInfo = group.Add(new VocabularyKey("MissingComponentInfo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"")
                    .WithDisplayName("MissingComponentInfo")
                    .ModelProperty("missingcomponentinfo", typeof(string)));

                this.MissingComponentLookupType = group.Add(new VocabularyKey("MissingComponentLookupType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The lookup type of the missing component.")
                    .WithDisplayName("Lookup Type")
                    .ModelProperty("missingcomponentlookuptype", typeof(long)));

                this.ExistingComponentId = group.Add(new VocabularyKey("ExistingComponentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the object that has an invalid dependency")
                    .WithDisplayName("Existing Object Id")
                    .ModelProperty("existingcomponentid", typeof(Guid)));

                this.ExistingComponentType = group.Add(new VocabularyKey("ExistingComponentType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Component type of the object that has an invalid dependency")
                    .WithDisplayName("Existing Object's Component Type")
                    .ModelProperty("existingcomponenttype", typeof(string)));

                this.ExistingDependencyTypeName = group.Add(new VocabularyKey("ExistingDependencyTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ExistingDependencyTypeName")
                    .ModelProperty("existingdependencytypename", typeof(string)));

                this.MissingComponentTypeName = group.Add(new VocabularyKey("MissingComponentTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MissingComponentTypeName")
                    .ModelProperty("missingcomponenttypename", typeof(string)));

                this.ExistingComponentTypeName = group.Add(new VocabularyKey("ExistingComponentTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ExistingComponentTypeName")
                    .ModelProperty("existingcomponenttypename", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey InvalidDependencyId { get; private set; }

        public VocabularyKey IsExistingNodeRequiredComponent { get; private set; }

        public VocabularyKey ExistingDependencyType { get; private set; }

        public VocabularyKey MissingComponentType { get; private set; }

        public VocabularyKey MissingComponentId { get; private set; }

        public VocabularyKey MissingComponentInfo { get; private set; }

        public VocabularyKey MissingComponentLookupType { get; private set; }

        public VocabularyKey ExistingComponentId { get; private set; }

        public VocabularyKey ExistingComponentType { get; private set; }

        public VocabularyKey ExistingDependencyTypeName { get; private set; }

        public VocabularyKey MissingComponentTypeName { get; private set; }

        public VocabularyKey ExistingComponentTypeName { get; private set; }


    }
}

