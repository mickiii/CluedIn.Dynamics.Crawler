using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SLAVocabulary : SimpleVocabulary
    {
        public SLAVocabulary()
        {
            VocabularyName = "Dynamics365 SLA";
            KeyPrefix = "dynamics365.sla";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SLA", group =>
            {
                this.SLAId = group.Add(new VocabularyKey("SLAId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the SLA.")
                    .WithDisplayName("SLA")
                    .ModelProperty("slaid", typeof(Guid)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type a descriptive name of the service level agreement (SLA).")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.BusinessHoursId = group.Add(new VocabularyKey("BusinessHoursId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Choose the business hours for calculating SLA item timelines.")
                    .WithDisplayName("Business Hours")
                    .ModelProperty("businesshoursid", typeof(string)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Choose the entity type that the SLA is defined.")
                    .WithDisplayName("Object Type Code")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for the business unit that owns the record")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for the user that owns the record.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(string)));

                this.OwningTeam = group.Add(new VocabularyKey("OwningTeam", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier for the team that owns the record.")
                    .WithDisplayName("Owning Team")
                    .ModelProperty("owningteam", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"Type additional information to describe the SLA")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.ChangedAttributeList = group.Add(new VocabularyKey("ChangedAttributeList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1000))
                    .WithDescription(@"Type additional information to describe the SLA")
                    .WithDisplayName("ChangedAttributeList")
                    .ModelProperty("changedattributelist", typeof(string)));

                this.ApplicableFrom = group.Add(new VocabularyKey("ApplicableFrom", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Select the field that specifies the date and time from which the SLA items will be calculated for the case record. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created. ")
                    .WithDisplayName("Applicable From")
                    .ModelProperty("applicablefrom", typeof(string)));

                this.IsDefault = group.Add(new VocabularyKey("IsDefault", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Tells whether this SLA is the default one.")
                    .WithDisplayName("Is Default")
                    .ModelProperty("isdefault", typeof(bool)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who last updated the record.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ExchangeRate = group.Add(new VocabularyKey("ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Exchange rate between the currency associated with the SLA record and the base currency.")
                    .WithDisplayName("Exchange Rate")
                    .ModelProperty("exchangerate", typeof(decimal)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the SLA.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.TransactionCurrencyIdName = group.Add(new VocabularyKey("TransactionCurrencyIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("TransactionCurrencyIdName")
                    .ModelProperty("transactioncurrencyidname", typeof(string)));

                this.TransactionCurrencyId = group.Add(new VocabularyKey("TransactionCurrencyId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the currency associated with the SLA record.")
                    .WithDisplayName("Currency")
                    .ModelProperty("transactioncurrencyid", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Shows whether the Service Level Agreement (SLA) is active or inactive.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the status of the service level agreement (SLA).")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.ApplicableFromName = group.Add(new VocabularyKey("ApplicableFromName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ApplicableFromName")
                    .ModelProperty("applicablefromname", typeof(string)));

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

                this.BusinessHoursIdName = group.Add(new VocabularyKey("BusinessHoursIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("BusinessHoursIdName")
                    .ModelProperty("businesshoursidname", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Is Managed")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.SLAIdUnique = group.Add(new VocabularyKey("SLAIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Unique Id")
                    .ModelProperty("slaidunique", typeof(Guid)));

                this.ObjectTypeCodeName = group.Add(new VocabularyKey("ObjectTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ObjectTypeCodeName")
                    .ModelProperty("objecttypecodename", typeof(string)));

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

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Enter the user or team who owns the SLA. This field is updated every time the item is assigned to a different user.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.IsDefaultName = group.Add(new VocabularyKey("IsDefaultName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsDefaultName")
                    .ModelProperty("isdefaultname", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.ApplicableFromPickList = group.Add(new VocabularyKey("ApplicableFromPickList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Select the field that specifies the date and time from which the SLA items will be calculated. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created.")
                    .WithDisplayName("Applicable From")
                    .ModelProperty("applicablefrompicklist", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.WorkflowId = group.Add(new VocabularyKey("WorkflowId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Workflow associated with the SLA.")
                    .WithDisplayName("Workflow ID")
                    .ModelProperty("workflowid", typeof(string)));

                this.AllowPauseResume = group.Add(new VocabularyKey("AllowPauseResume", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select whether this SLA will allow pausing and resuming during the time calculation.")
                    .WithDisplayName("Allow Pause and Resume")
                    .ModelProperty("allowpauseresume", typeof(bool)));

                this.AllowPauseResumeName = group.Add(new VocabularyKey("AllowPauseResumeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AllowPauseResumeName")
                    .ModelProperty("allowpauseresumename", typeof(string)));

                this.SLAType = group.Add(new VocabularyKey("SLAType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Select the type of service level agreement (SLA).")
                    .WithDisplayName("SLA Type")
                    .ModelProperty("slatype", typeof(string)));

                this.SLATypeName = group.Add(new VocabularyKey("SLATypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SLATypeName")
                    .ModelProperty("slatypename", typeof(string)));

                this.WorkflowIdName = group.Add(new VocabularyKey("WorkflowIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("WorkflowIdName")
                    .ModelProperty("workflowidname", typeof(string)));

                this.OwnerIdYomiName = group.Add(new VocabularyKey("OwnerIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdYomiName")
                    .ModelProperty("owneridyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

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

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows who created the record on behalf of another user.")
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

                this.PrimaryEntityOTC = group.Add(new VocabularyKey("PrimaryEntityOTC", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Shows the primary entity that the SLA has been created for.")
                    .WithDisplayName("Primary Entity")
                    .ModelProperty("primaryentityotc", typeof(long)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey SLAId { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey BusinessHoursId { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey OwningTeam { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey ChangedAttributeList { get; private set; }

        public VocabularyKey ApplicableFrom { get; private set; }

        public VocabularyKey IsDefault { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ExchangeRate { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey TransactionCurrencyIdName { get; private set; }

        public VocabularyKey TransactionCurrencyId { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey ApplicableFromName { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey BusinessHoursIdName { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey SLAIdUnique { get; private set; }

        public VocabularyKey ObjectTypeCodeName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey IsDefaultName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey ApplicableFromPickList { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey WorkflowId { get; private set; }

        public VocabularyKey AllowPauseResume { get; private set; }

        public VocabularyKey AllowPauseResumeName { get; private set; }

        public VocabularyKey SLAType { get; private set; }

        public VocabularyKey SLATypeName { get; private set; }

        public VocabularyKey WorkflowIdName { get; private set; }

        public VocabularyKey OwnerIdYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey PrimaryEntityOTC { get; private set; }


    }
}

