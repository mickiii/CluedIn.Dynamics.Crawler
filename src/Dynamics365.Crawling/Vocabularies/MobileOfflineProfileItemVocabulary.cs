using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class MobileOfflineProfileItemVocabulary : SimpleVocabulary
    {
        public MobileOfflineProfileItemVocabulary()
        {
            VocabularyName = "Dynamics365 MobileOfflineProfileItem";
            KeyPrefix = "dynamics365.mobileofflineprofileitem";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("MobileOfflineProfileItem", group =>
            {
                this.MobileOfflineProfileItemId = group.Add(new VocabularyKey("MobileOfflineProfileItemId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the mobile offline profile item.")
                    .WithDisplayName("Mobile Offline Profile Item")
                    .ModelProperty("mobileofflineprofileitemid", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(255))
                    .WithDescription(@"Enter the name of the mobile offline profile item.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.ViewQuery = group.Add(new VocabularyKey("ViewQuery", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Contains converted sql of the referenced view.")
                    .WithDisplayName("View Query")
                    .ModelProperty("viewquery", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the Mobile Offline Profile Item.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated solution.")
                    .WithDisplayName("Solution")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.CanBeFollowed = group.Add(new VocabularyKey("CanBeFollowed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies whether records of this entity can be followed.")
                    .WithDisplayName("Allow Entity to Follow Relationship")
                    .ModelProperty("canbefollowed", typeof(bool)));

                this.CanBeFollowedName = group.Add(new VocabularyKey("CanBeFollowedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("CanBeFollowedName")
                    .ModelProperty("canbefollowedname", typeof(string)));

                this.GetRelatedEntityRecords = group.Add(new VocabularyKey("GetRelatedEntityRecords", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specify whether records related to this entity will be made available for offline access.")
                    .WithDisplayName("Get Related Entities")
                    .ModelProperty("getrelatedentityrecords", typeof(bool)));

                this.GetRelatedEntityRecordsName = group.Add(new VocabularyKey("GetRelatedEntityRecordsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("GetRelatedEntityRecordsName")
                    .ModelProperty("getrelatedentityrecordsname", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

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

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who updated the record on behalf of another user.")
                    .WithDisplayName("Modified By (Delegate)")
                    .ModelProperty("modifiedonbehalfby", typeof(string)));

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

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Items contained with a particular Profile.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.ProcessId = group.Add(new VocabularyKey("ProcessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the process.")
                    .WithDisplayName("Process")
                    .ModelProperty("processid", typeof(Guid)));

                this.StageId = group.Add(new VocabularyKey("StageId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows the ID of the stage.")
                    .WithDisplayName("(Deprecated) Process Stage")
                    .ModelProperty("stageid", typeof(Guid)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Is Managed")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the Mobile Offline Profile Item.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.ProfileItemRule = group.Add(new VocabularyKey("ProfileItemRule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Saved Query associated with the Mobile offline profile item rule.")
                    .WithDisplayName("View to sync data to device")
                    .ModelProperty("profileitemrule", typeof(string)));

                this.ProfileItemRuleName = group.Add(new VocabularyKey("ProfileItemRuleName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ProfileItemRuleName")
                    .ModelProperty("profileitemrulename", typeof(string)));

                this.TraversedPath = group.Add(new VocabularyKey("TraversedPath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1250))
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("(Deprecated) Traversed Path")
                    .ModelProperty("traversedpath", typeof(string)));

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

                this.PublishedOn = group.Add(new VocabularyKey("PublishedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Displays the last published date time.")
                    .WithDisplayName("Published On")
                    .ModelProperty("publishedon", typeof(DateTime)));

                this.MobileOfflineProfileItemIdUnique = group.Add(new VocabularyKey("MobileOfflineProfileItemIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For Internal Use Only")
                    .WithDisplayName("Unique Id")
                    .ModelProperty("mobileofflineprofileitemidunique", typeof(Guid)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the Mobile offline Profile Item is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.SelectedEntityTypeCode = group.Add(new VocabularyKey("SelectedEntityTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Mobile offline enabled entity")
                    .WithDisplayName("Entity")
                    .ModelProperty("selectedentitytypecode", typeof(string)));

                this.SelectedEntityTypeCodeName = group.Add(new VocabularyKey("SelectedEntityTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SelectedEntityTypeCodeName")
                    .ModelProperty("selectedentitytypecodename", typeof(string)));

                this.IsVisibleInGrid = group.Add(new VocabularyKey("IsVisibleInGrid", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether the mobile offline profile item is visible in the Profile Item subgrid.")
                    .WithDisplayName("Is Visible In Grid")
                    .ModelProperty("isvisibleingrid", typeof(bool)));

                this.IsVisibleInGridName = group.Add(new VocabularyKey("IsVisibleInGridName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsVisibleInGridName")
                    .ModelProperty("isvisibleingridname", typeof(string)));

                this.RecordDistributionCriteria = group.Add(new VocabularyKey("RecordDistributionCriteria", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specify data download filter for selected entity")
                    .WithDisplayName("Data Download Filter")
                    .ModelProperty("recorddistributioncriteria", typeof(string)));

                this.RecordDistributionCriteriaName = group.Add(new VocabularyKey("RecordDistributionCriteriaName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RecordDistributionCriteriaName")
                    .ModelProperty("recorddistributioncriterianame", typeof(string)));

                this.RecordsOwnedByMe = group.Add(new VocabularyKey("RecordsOwnedByMe", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Download my records")
                    .WithDisplayName("Download my records")
                    .ModelProperty("recordsownedbyme", typeof(bool)));

                this.RecordsOwnedByMeName = group.Add(new VocabularyKey("RecordsOwnedByMeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RecordsOwnedByMeName")
                    .ModelProperty("recordsownedbymename", typeof(string)));

                this.RecordsOwnedByMyTeam = group.Add(new VocabularyKey("RecordsOwnedByMyTeam", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Download my team's records")
                    .WithDisplayName("Download my team's records")
                    .ModelProperty("recordsownedbymyteam", typeof(bool)));

                this.RecordsOwnedByMyTeamName = group.Add(new VocabularyKey("RecordsOwnedByMyTeamName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RecordsOwnedByMyTeamName")
                    .ModelProperty("recordsownedbymyteamname", typeof(string)));

                this.RecordsOwnedByMyBusinessUnit = group.Add(new VocabularyKey("RecordsOwnedByMyBusinessUnit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Download my business unit's records")
                    .WithDisplayName("Download my business unit's records")
                    .ModelProperty("recordsownedbymybusinessunit", typeof(bool)));

                this.RecordsOwnedByMyBusinessUnitName = group.Add(new VocabularyKey("RecordsOwnedByMyBusinessUnitName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RecordsOwnedByMyBusinessUnitName")
                    .ModelProperty("recordsownedbymybusinessunitname", typeof(string)));

                this.RelationshipData = group.Add(new VocabularyKey("RelationshipData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Internal Use Only")
                    .WithDisplayName("Internal Use Only")
                    .ModelProperty("relationshipdata", typeof(string)));

                this.IsValidated = group.Add(new VocabularyKey("IsValidated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether profile item is validated or not")
                    .WithDisplayName("Is Valid For Mobile Offline")
                    .ModelProperty("isvalidated", typeof(bool)));

                this.IsValidatedName = group.Add(new VocabularyKey("IsValidatedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Is Validated Name.")
                    .WithDisplayName("IsValidatedName")
                    .ModelProperty("isvalidatedname", typeof(string)));

                this.SelectedEntityMetadata = group.Add(new VocabularyKey("SelectedEntityMetadata", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Internal Use Only")
                    .WithDisplayName("Internal Use Only")
                    .ModelProperty("selectedentitymetadata", typeof(string)));

                this.EntityObjectTypeCode = group.Add(new VocabularyKey("EntityObjectTypeCode", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Internal Use Only")
                    .WithDisplayName("Internal Use Only")
                    .ModelProperty("entityobjecttypecode", typeof(long)));

                this.ProfileItemEntityFilter = group.Add(new VocabularyKey("ProfileItemEntityFilter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Profile item entity filter criteria")
                    .WithDisplayName("Profile item entity filter")
                    .ModelProperty("profileitementityfilter", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey MobileOfflineProfileItemId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey ViewQuery { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey CanBeFollowed { get; private set; }

        public VocabularyKey CanBeFollowedName { get; private set; }

        public VocabularyKey GetRelatedEntityRecords { get; private set; }

        public VocabularyKey GetRelatedEntityRecordsName { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey ProcessId { get; private set; }

        public VocabularyKey StageId { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey ProfileItemRule { get; private set; }

        public VocabularyKey ProfileItemRuleName { get; private set; }

        public VocabularyKey TraversedPath { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey PublishedOn { get; private set; }

        public VocabularyKey MobileOfflineProfileItemIdUnique { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey SelectedEntityTypeCode { get; private set; }

        public VocabularyKey SelectedEntityTypeCodeName { get; private set; }

        public VocabularyKey IsVisibleInGrid { get; private set; }

        public VocabularyKey IsVisibleInGridName { get; private set; }

        public VocabularyKey RecordDistributionCriteria { get; private set; }

        public VocabularyKey RecordDistributionCriteriaName { get; private set; }

        public VocabularyKey RecordsOwnedByMe { get; private set; }

        public VocabularyKey RecordsOwnedByMeName { get; private set; }

        public VocabularyKey RecordsOwnedByMyTeam { get; private set; }

        public VocabularyKey RecordsOwnedByMyTeamName { get; private set; }

        public VocabularyKey RecordsOwnedByMyBusinessUnit { get; private set; }

        public VocabularyKey RecordsOwnedByMyBusinessUnitName { get; private set; }

        public VocabularyKey RelationshipData { get; private set; }

        public VocabularyKey IsValidated { get; private set; }

        public VocabularyKey IsValidatedName { get; private set; }

        public VocabularyKey SelectedEntityMetadata { get; private set; }

        public VocabularyKey EntityObjectTypeCode { get; private set; }

        public VocabularyKey ProfileItemEntityFilter { get; private set; }


    }
}

