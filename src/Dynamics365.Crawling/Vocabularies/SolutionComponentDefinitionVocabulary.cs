using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SolutionComponentDefinitionVocabulary : SimpleVocabulary
    {
        public SolutionComponentDefinitionVocabulary()
        {
            VocabularyName = "Dynamics365 SolutionComponentDefinition";
            KeyPrefix = "dynamics365.solutioncomponentdefinition";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SolutionComponentDefinition", group =>
            {
                this.SolutionComponentDefinitionId = group.Add(new VocabularyKey("SolutionComponentDefinitionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the solution component definition")
                    .WithDisplayName("Solution Component Definition")
                    .ModelProperty("solutioncomponentdefinitionid", typeof(Guid)));

                this.ComponentXPath = group.Add(new VocabularyKey("ComponentXPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Path to component's XML node")
                    .WithDisplayName("Component XPath")
                    .ModelProperty("componentxpath", typeof(string)));

                this.SolutionComponentType = group.Add(new VocabularyKey("SolutionComponentType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Solution Component Type")
                    .WithDisplayName("Solution Component Type")
                    .ModelProperty("solutioncomponenttype", typeof(long)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated solution.")
                    .WithDisplayName("Solution")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.SupportingSolutionId = group.Add(new VocabularyKey("SupportingSolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Supporting Solution")
                    .ModelProperty("supportingsolutionid", typeof(Guid)));

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

                this.SolutionComponentDefinitionIdUnique = group.Add(new VocabularyKey("SolutionComponentDefinitionIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Unique Id")
                    .ModelProperty("solutioncomponentdefinitionidunique", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Name")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Object Type Code")
                    .WithDisplayName("Object Type Code")
                    .ModelProperty("objecttypecode", typeof(long)));

                this.IsMetadata = group.Add(new VocabularyKey("IsMetadata", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Boolean identifier for metadata components")
                    .WithDisplayName("Metadata")
                    .ModelProperty("ismetadata", typeof(bool)));

                this.LabelTypeCode = group.Add(new VocabularyKey("LabelTypeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Label Type Code")
                    .WithDisplayName("Label Type Code")
                    .ModelProperty("labeltypecode", typeof(long)));

                this.UseForceUpdateAlways = group.Add(new VocabularyKey("UseForceUpdateAlways", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Boolean identifier for always forcing update.")
                    .WithDisplayName("UseForceUpdateAlways")
                    .ModelProperty("useforceupdatealways", typeof(bool)));

                this.UseForceDeleteForSolutionUpdate = group.Add(new VocabularyKey("UseForceDeleteForSolutionUpdate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Boolean identifier for forcing delete for solution update.")
                    .WithDisplayName("UseForceDeleteForSolutionUpdate")
                    .ModelProperty("useforcedeleteforsolutionupdate", typeof(bool)));

                this.UseSentinelRowInBaseSolution = group.Add(new VocabularyKey("UseSentinelRowInBaseSolution", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Boolean identifier for using sentine rows.")
                    .WithDisplayName("UseSentinelRowInBaseSolution")
                    .ModelProperty("usesentinelrowinbasesolution", typeof(bool)));

                this.AllowDeleteBaseSolutionRowAndFakeDelete = group.Add(new VocabularyKey("AllowDeleteBaseSolutionRowAndFakeDelete", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Boolean identifier for using deleting base layers.")
                    .WithDisplayName("AllowDeleteBaseSolutionRowAndFakeDeleteInSolutionUpgrade")
                    .ModelProperty("allowdeletebasesolutionrowandfakedelete", typeof(bool)));

                this.AllowRecreateForLogicallyDeletedRow = group.Add(new VocabularyKey("AllowRecreateForLogicallyDeletedRow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Boolean identifier for a row that is marked as logically deleted in the Active solution and should be re-created back")
                    .WithDisplayName("AllowRecreateForLogicallyDeletedRowInActiveSolution")
                    .ModelProperty("allowrecreateforlogicallydeletedrow", typeof(bool)));

                this.AlwaysRemoveActiveCustomizationsOnUninstall = group.Add(new VocabularyKey("AlwaysRemoveActiveCustomizationsOnUninstall", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag used to indicate whether this component always removes active customizations on uninstall")
                    .WithDisplayName("AlwaysRemoveActiveCustomizationsOnUninstall")
                    .ModelProperty("alwaysremoveactivecustomizationsonuninstall", typeof(bool)));

                this.GroupParentComponentType = group.Add(new VocabularyKey("GroupParentComponentType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Group Parent Component Type")
                    .WithDisplayName("Group Parent Component Type")
                    .ModelProperty("groupparentcomponenttype", typeof(long)));

                this.GroupParentComponentAttributeName = group.Add(new VocabularyKey("GroupParentComponentAttributeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Group Parent Component Attribute Name")
                    .WithDisplayName("Group Parent Component Attribute Name")
                    .ModelProperty("groupparentcomponentattributename", typeof(string)));

                this.IsViewable = group.Add(new VocabularyKey("IsViewable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Whether this component is viewable in the SDK and UI")
                    .WithDisplayName("Viewable")
                    .ModelProperty("isviewable", typeof(bool)));

                this.AllowOverwriteCustomizations = group.Add(new VocabularyKey("AllowOverwriteCustomizations", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Whether this component allows Overwrite Customizations when update managed solution")
                    .WithDisplayName("AllowOverwriteCustomizations")
                    .ModelProperty("allowoverwritecustomizations", typeof(bool)));

                this.IsMergeable = group.Add(new VocabularyKey("IsMergeable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Whether this component is either a mergeable component, or part of a mergeable component")
                    .WithDisplayName("Mergeable")
                    .ModelProperty("ismergeable", typeof(bool)));

                this.CanBeHidden = group.Add(new VocabularyKey("CanBeHidden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Whether this component is hidden using an IsHidden managed property")
                    .WithDisplayName("CanBeHidden")
                    .ModelProperty("canbehidden", typeof(bool)));

                this.DescendentIsViewableComponent = group.Add(new VocabularyKey("DescendentIsViewableComponent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag that indicates whether this component uses its descendent as its viewable component")
                    .WithDisplayName("Descendent Is Viewable Component")
                    .ModelProperty("descendentisviewablecomponent", typeof(bool)));

                this.ViewableDescendentComponentType = group.Add(new VocabularyKey("ViewableDescendentComponentType", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"The component type of the viewable descendent")
                    .WithDisplayName("Viewable Descendent ComponentType")
                    .ModelProperty("viewabledescendentcomponenttype", typeof(long)));

                this.ParentAttributeName = group.Add(new VocabularyKey("ParentAttributeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"The attribute name of the parent attribute")
                    .WithDisplayName("Parent Attribute Name")
                    .ModelProperty("parentattributename", typeof(string)));

                this.IsDependencyDisabled = group.Add(new VocabularyKey("IsDependencyDisabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Is dependency disabled for the component")
                    .WithDisplayName("Is Dependency Disabled")
                    .ModelProperty("isdependencydisabled", typeof(bool)));

                this.CanBeAddedToSolutionComponents = group.Add(new VocabularyKey("CanBeAddedToSolutionComponents", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Flag indicating whether the subcomponent can be added directly to the SolutionComponents table")
                    .WithDisplayName("Can Be Added To SolutionComponents")
                    .ModelProperty("canbeaddedtosolutioncomponents", typeof(bool)));

                this.RootComponent = group.Add(new VocabularyKey("RootComponent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Root Solution Component Type")
                    .WithDisplayName("Root Solution Component Type")
                    .ModelProperty("rootcomponent", typeof(long)));

                this.RootAttributeName = group.Add(new VocabularyKey("RootAttributeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Root Solution Component Type Name")
                    .WithDisplayName("Root Solution Component Type Name")
                    .ModelProperty("rootattributename", typeof(string)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the component is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.HasIsRenameableAttribute = group.Add(new VocabularyKey("HasIsRenameableAttribute", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Boolean that indicates if the component has a renamable attribute")
                    .WithDisplayName("HasIsRenameableAttribute")
                    .ModelProperty("hasisrenameableattribute", typeof(bool)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Boolean that indicates if the component is managed")
                    .WithDisplayName("Managed")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.SolutionComponentTypeName = group.Add(new VocabularyKey("SolutionComponentTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SolutionComponentTypeName")
                    .ModelProperty("solutioncomponenttypename", typeof(string)));

                this.ImportSequenceNumber = group.Add(new VocabularyKey("ImportSequenceNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the data import or data migration that created this record.")
                    .WithDisplayName("Import Sequence Number")
                    .ModelProperty("importsequencenumber", typeof(long)));

                this.OverriddenCreatedOn = group.Add(new VocabularyKey("OverriddenCreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time that the record was migrated.")
                    .WithDisplayName("Record Created On")
                    .ModelProperty("overriddencreatedon", typeof(DateTime)));

                this.RemoveActiveCustomizationsBehavior = group.Add(new VocabularyKey("RemoveActiveCustomizationsBehavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Remove Active Customizations Behavior.")
                    .WithDisplayName("Remove Active Customizations Behavior")
                    .ModelProperty("removeactivecustomizationsbehavior", typeof(string)));

                this.IsDisplayable = group.Add(new VocabularyKey("IsDisplayable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Boolean that indicates if the component has user interface enabled")
                    .WithDisplayName("Displayable")
                    .ModelProperty("isdisplayable", typeof(bool)));

                this.PrimaryEntityName = group.Add(new VocabularyKey("PrimaryEntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Component Entity Logical Name")
                    .WithDisplayName("Entity Logical Name")
                    .ModelProperty("primaryentityname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey SolutionComponentDefinitionId { get; private set; }

        public VocabularyKey ComponentXPath { get; private set; }

        public VocabularyKey SolutionComponentType { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey SolutionComponentDefinitionIdUnique { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey IsMetadata { get; private set; }

        public VocabularyKey LabelTypeCode { get; private set; }

        public VocabularyKey UseForceUpdateAlways { get; private set; }

        public VocabularyKey UseForceDeleteForSolutionUpdate { get; private set; }

        public VocabularyKey UseSentinelRowInBaseSolution { get; private set; }

        public VocabularyKey AllowDeleteBaseSolutionRowAndFakeDelete { get; private set; }

        public VocabularyKey AllowRecreateForLogicallyDeletedRow { get; private set; }

        public VocabularyKey AlwaysRemoveActiveCustomizationsOnUninstall { get; private set; }

        public VocabularyKey GroupParentComponentType { get; private set; }

        public VocabularyKey GroupParentComponentAttributeName { get; private set; }

        public VocabularyKey IsViewable { get; private set; }

        public VocabularyKey AllowOverwriteCustomizations { get; private set; }

        public VocabularyKey IsMergeable { get; private set; }

        public VocabularyKey CanBeHidden { get; private set; }

        public VocabularyKey DescendentIsViewableComponent { get; private set; }

        public VocabularyKey ViewableDescendentComponentType { get; private set; }

        public VocabularyKey ParentAttributeName { get; private set; }

        public VocabularyKey IsDependencyDisabled { get; private set; }

        public VocabularyKey CanBeAddedToSolutionComponents { get; private set; }

        public VocabularyKey RootComponent { get; private set; }

        public VocabularyKey RootAttributeName { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey HasIsRenameableAttribute { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey SolutionComponentTypeName { get; private set; }

        public VocabularyKey ImportSequenceNumber { get; private set; }

        public VocabularyKey OverriddenCreatedOn { get; private set; }

        public VocabularyKey RemoveActiveCustomizationsBehavior { get; private set; }

        public VocabularyKey IsDisplayable { get; private set; }

        public VocabularyKey PrimaryEntityName { get; private set; }


    }
}

