using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SdkMessageFilterVocabulary : SimpleVocabulary
    {
        public SdkMessageFilterVocabulary()
        {
            VocabularyName = "Dynamics365 SdkMessageFilter";
            KeyPrefix = "dynamics365.sdkmessagefilter";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SdkMessageFilter", group =>
            {
                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the SDK message filter.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.SdkMessageFilterId = group.Add(new VocabularyKey("SdkMessageFilterId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the SDK message filter entity.")
                    .WithDisplayName("SdkMessageFilterId")
                    .ModelProperty("sdkmessagefilterid", typeof(Guid)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization with which the SDK message filter is associated.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.PrimaryObjectTypeCode = group.Add(new VocabularyKey("PrimaryObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of entity with which the SDK message filter is primarily associated.")
                    .WithDisplayName("Primary Object Type Code")
                    .ModelProperty("primaryobjecttypecode", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the SDK message filter.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.CustomizationLevel = group.Add(new VocabularyKey("CustomizationLevel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Customization level of the SDK message filter.")
                    .WithDisplayName("CustomizationLevel")
                    .ModelProperty("customizationlevel", typeof(long)));

                this.SecondaryObjectTypeCode = group.Add(new VocabularyKey("SecondaryObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of entity with which the SDK message filter is secondarily associated.")
                    .WithDisplayName("Secondary Object Type Code")
                    .ModelProperty("secondaryobjecttypecode", typeof(string)));

                this.SdkMessageFilterIdUnique = group.Add(new VocabularyKey("SdkMessageFilterIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the SDK message filter.")
                    .WithDisplayName("SdkMessageFilterIdUnique")
                    .ModelProperty("sdkmessagefilteridunique", typeof(Guid)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the SDK message filter was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.IsCustomProcessingStepAllowed = group.Add(new VocabularyKey("IsCustomProcessingStepAllowed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Indicates whether a custom SDK message processing step is allowed.")
                    .WithDisplayName("Custom Processing Step Allowed")
                    .ModelProperty("iscustomprocessingstepallowed", typeof(bool)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the SDK message filter was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.Availability = group.Add(new VocabularyKey("Availability", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.")
                    .WithDisplayName("Availability")
                    .ModelProperty("availability", typeof(long)));

                this.SdkMessageId = group.Add(new VocabularyKey("SdkMessageId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the related SDK message.")
                    .WithDisplayName("SDK Message ID")
                    .ModelProperty("sdkmessageid", typeof(string)));

                this.SecondaryObjectTypeCodeName = group.Add(new VocabularyKey("SecondaryObjectTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SecondaryObjectTypeCodeName")
                    .ModelProperty("secondaryobjecttypecodename", typeof(string)));

                this.PrimaryObjectTypeCodeName = group.Add(new VocabularyKey("PrimaryObjectTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PrimaryObjectTypeCodeName")
                    .ModelProperty("primaryobjecttypecodename", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the sdkmessagefilter.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who last modified the sdkmessagefilter.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

                this.IsVisible = group.Add(new VocabularyKey("IsVisible", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the filter should be visible.")
                    .WithDisplayName("IsVisible")
                    .ModelProperty("isvisible", typeof(bool)));

                this.ModifiedOnBehalfByName = group.Add(new VocabularyKey("ModifiedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByName")
                    .ModelProperty("modifiedonbehalfbyname", typeof(string)));

                this.ModifiedOnBehalfByYomiName = group.Add(new VocabularyKey("ModifiedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedOnBehalfByYomiName")
                    .ModelProperty("modifiedonbehalfbyyominame", typeof(string)));

                this.CreatedOnBehalfByName = group.Add(new VocabularyKey("CreatedOnBehalfByName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByName")
                    .ModelProperty("createdonbehalfbyname", typeof(string)));

                this.CreatedOnBehalfByYomiName = group.Add(new VocabularyKey("CreatedOnBehalfByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedOnBehalfByYomiName")
                    .ModelProperty("createdonbehalfbyyominame", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.SdkMessageIdName = group.Add(new VocabularyKey("SdkMessageIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("SdkMessageIdName")
                    .ModelProperty("sdkmessageidname", typeof(string)));

                this.IsCustomProcessingStepAllowedName = group.Add(new VocabularyKey("IsCustomProcessingStepAllowedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsCustomProcessingStepAllowedName")
                    .ModelProperty("iscustomprocessingstepallowedname", typeof(string)));

                this.WorkflowSdkStepEnabled = group.Add(new VocabularyKey("WorkflowSdkStepEnabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Whether or not the SDK message can be called from a workflow.")
                    .WithDisplayName("WorkflowSdkStepEnabled")
                    .ModelProperty("workflowsdkstepenabled", typeof(bool)));

                this.WorkflowSdkStepEnabledName = group.Add(new VocabularyKey("WorkflowSdkStepEnabledName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("WorkflowSdkStepEnabledName")
                    .ModelProperty("workflowsdkstepenabledname", typeof(string)));

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

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information that specifies whether this component is managed.")
                    .WithDisplayName("State")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the component is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.RestrictionLevel = group.Add(new VocabularyKey("RestrictionLevel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("RestrictionLevel")
                    .ModelProperty("restrictionlevel", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey SdkMessageFilterId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey PrimaryObjectTypeCode { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey CustomizationLevel { get; private set; }

        public VocabularyKey SecondaryObjectTypeCode { get; private set; }

        public VocabularyKey SdkMessageFilterIdUnique { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey IsCustomProcessingStepAllowed { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey Availability { get; private set; }

        public VocabularyKey SdkMessageId { get; private set; }

        public VocabularyKey SecondaryObjectTypeCodeName { get; private set; }

        public VocabularyKey PrimaryObjectTypeCodeName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey IsVisible { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey SdkMessageIdName { get; private set; }

        public VocabularyKey IsCustomProcessingStepAllowedName { get; private set; }

        public VocabularyKey WorkflowSdkStepEnabled { get; private set; }

        public VocabularyKey WorkflowSdkStepEnabledName { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey RestrictionLevel { get; private set; }


    }
}

