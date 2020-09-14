using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class SolutionComponentDefinition : DynamicsModel
    {
        [JsonProperty("solutioncomponentdefinitionid")]
        public Guid? SolutionComponentDefinitionId { get; set; }

        [JsonProperty("componentxpath")]
        public string ComponentXPath { get; set; }

        [JsonProperty("solutioncomponenttype")]
        public long? SolutionComponentType { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("solutioncomponentdefinitionidunique")]
        public Guid? SolutionComponentDefinitionIdUnique { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objecttypecode")]
        public long? ObjectTypeCode { get; set; }

        [JsonProperty("ismetadata")]
        public bool? IsMetadata { get; set; }

        [JsonProperty("labeltypecode")]
        public long? LabelTypeCode { get; set; }

        [JsonProperty("useforceupdatealways")]
        public bool? UseForceUpdateAlways { get; set; }

        [JsonProperty("useforcedeleteforsolutionupdate")]
        public bool? UseForceDeleteForSolutionUpdate { get; set; }

        [JsonProperty("usesentinelrowinbasesolution")]
        public bool? UseSentinelRowInBaseSolution { get; set; }

        [JsonProperty("allowdeletebasesolutionrowandfakedelete")]
        public bool? AllowDeleteBaseSolutionRowAndFakeDelete { get; set; }

        [JsonProperty("allowrecreateforlogicallydeletedrow")]
        public bool? AllowRecreateForLogicallyDeletedRow { get; set; }

        [JsonProperty("alwaysremoveactivecustomizationsonuninstall")]
        public bool? AlwaysRemoveActiveCustomizationsOnUninstall { get; set; }

        [JsonProperty("groupparentcomponenttype")]
        public long? GroupParentComponentType { get; set; }

        [JsonProperty("groupparentcomponentattributename")]
        public string GroupParentComponentAttributeName { get; set; }

        [JsonProperty("isviewable")]
        public bool? IsViewable { get; set; }

        [JsonProperty("allowoverwritecustomizations")]
        public bool? AllowOverwriteCustomizations { get; set; }

        [JsonProperty("ismergeable")]
        public bool? IsMergeable { get; set; }

        [JsonProperty("canbehidden")]
        public bool? CanBeHidden { get; set; }

        [JsonProperty("descendentisviewablecomponent")]
        public bool? DescendentIsViewableComponent { get; set; }

        [JsonProperty("viewabledescendentcomponenttype")]
        public long? ViewableDescendentComponentType { get; set; }

        [JsonProperty("parentattributename")]
        public string ParentAttributeName { get; set; }

        [JsonProperty("isdependencydisabled")]
        public bool? IsDependencyDisabled { get; set; }

        [JsonProperty("canbeaddedtosolutioncomponents")]
        public bool? CanBeAddedToSolutionComponents { get; set; }

        [JsonProperty("rootcomponent")]
        public long? RootComponent { get; set; }

        [JsonProperty("rootattributename")]
        public string RootAttributeName { get; set; }

        [JsonProperty("introducedversion")]
        public string IntroducedVersion { get; set; }

        [JsonProperty("hasisrenameableattribute")]
        public bool? HasIsRenameableAttribute { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("solutioncomponenttypename")]
        public string SolutionComponentTypeName { get; set; }

        [JsonProperty("importsequencenumber")]
        public long? ImportSequenceNumber { get; set; }

        [JsonProperty("overriddencreatedon")]
        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        [JsonProperty("removeactivecustomizationsbehavior")]
        public string RemoveActiveCustomizationsBehavior { get; set; }

        [JsonProperty("isdisplayable")]
        public bool? IsDisplayable { get; set; }

        [JsonProperty("primaryentityname")]
        public string PrimaryEntityName { get; set; }


    }
}

