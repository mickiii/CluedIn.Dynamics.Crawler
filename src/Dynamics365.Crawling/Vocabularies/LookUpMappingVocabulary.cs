using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class LookUpMappingVocabulary : SimpleVocabulary
    {
        public LookUpMappingVocabulary()
        {
            VocabularyName = "Dynamics365 LookUpMapping";
            KeyPrefix = "dynamics365.lookupmapping";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("LookUpMapping", group =>
            {
                this.LookUpEntityName = group.Add(new VocabularyKey("LookUpEntityName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the entity with which the lookup is associated.")
                    .WithDisplayName("Lookup Entity Name")
                    .ModelProperty("lookupentityname", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the lookup mapping.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.LookUpSourceCode = group.Add(new VocabularyKey("LookUpSourceCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Lookup source code for lookup mapping.")
                    .WithDisplayName("Lookup Source")
                    .ModelProperty("lookupsourcecode", typeof(string)));

                this.ColumnMappingId = group.Add(new VocabularyKey("ColumnMappingId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the column mapping with which this lookup mapping is associated.")
                    .WithDisplayName("Column Mapping Id")
                    .ModelProperty("columnmappingid", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the lookup mapping was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.LookUpMappingId = group.Add(new VocabularyKey("LookUpMappingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the lookup mapping.")
                    .WithDisplayName("LookUpMappingId")
                    .ModelProperty("lookupmappingid", typeof(Guid)));

                this.TransformationParameterMappingId = group.Add(new VocabularyKey("TransformationParameterMappingId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the transformation parameter mapping with which this lookup mapping is associated.")
                    .WithDisplayName("Transformation Parameter Mapping Id")
                    .ModelProperty("transformationparametermappingid", typeof(string)));

                this.ProcessCode = group.Add(new VocabularyKey("ProcessCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about whether the lookup mapping has to be processed.")
                    .WithDisplayName("Process Code")
                    .ModelProperty("processcode", typeof(string)));

                this.StatusCode = group.Add(new VocabularyKey("StatusCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Reason for the status of the lookup mapping.")
                    .WithDisplayName("Status Reason")
                    .ModelProperty("statuscode", typeof(string)));

                this.StateCode = group.Add(new VocabularyKey("StateCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status of the lookup mapping.")
                    .WithDisplayName("Status")
                    .ModelProperty("statecode", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the lookup mapping was created.")
                    .WithDisplayName("CreatedOn")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.LookUpAttributeName = group.Add(new VocabularyKey("LookUpAttributeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Name of the field with which the lookup is associated.")
                    .WithDisplayName("Lookup Field Name")
                    .ModelProperty("lookupattributename", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the lookup mapping.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ProcessCodeName = group.Add(new VocabularyKey("ProcessCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Process code name for ProcessCode")
                    .WithDisplayName("ProcessCodeName")
                    .ModelProperty("processcodename", typeof(string)));

                this.StatusCodeName = group.Add(new VocabularyKey("StatusCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Name of the status reason of the lookup mapping.")
                    .WithDisplayName("StatusCodeName")
                    .ModelProperty("statuscodename", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

                this.StateCodeName = group.Add(new VocabularyKey("StateCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Status name of the lookup mapping.")
                    .WithDisplayName("StateCodeName")
                    .ModelProperty("statecodename", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.ColumnMappingIdName = group.Add(new VocabularyKey("ColumnMappingIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Name of the column mapping.")
                    .WithDisplayName("ColumnMappingIdName")
                    .ModelProperty("columnmappingidname", typeof(string)));

                this.LookUpSourceCodeName = group.Add(new VocabularyKey("LookUpSourceCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Lookup source code name for lookup mapping")
                    .WithDisplayName("LookUpSourceCodeName")
                    .ModelProperty("lookupsourcecodename", typeof(string)));

                this.ModifiedByYomiName = group.Add(new VocabularyKey("ModifiedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByYomiName")
                    .ModelProperty("modifiedbyyominame", typeof(string)));

                this.CreatedByYomiName = group.Add(new VocabularyKey("CreatedByYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByYomiName")
                    .ModelProperty("createdbyyominame", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the lookupmapping.")
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
                    .WithDescription(@"Unique identifier of the delegate user who last modified the lookupmapping.")
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

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the component is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.LookUpMappingIdUnique = group.Add(new VocabularyKey("LookUpMappingIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the LookUp Mapping.")
                    .WithDisplayName("LookUpMappingIdUnique")
                    .ModelProperty("lookupmappingidunique", typeof(Guid)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey LookUpEntityName { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey LookUpSourceCode { get; private set; }

        public VocabularyKey ColumnMappingId { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey LookUpMappingId { get; private set; }

        public VocabularyKey TransformationParameterMappingId { get; private set; }

        public VocabularyKey ProcessCode { get; private set; }

        public VocabularyKey StatusCode { get; private set; }

        public VocabularyKey StateCode { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey LookUpAttributeName { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ProcessCodeName { get; private set; }

        public VocabularyKey StatusCodeName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey StateCodeName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ColumnMappingIdName { get; private set; }

        public VocabularyKey LookUpSourceCodeName { get; private set; }

        public VocabularyKey ModifiedByYomiName { get; private set; }

        public VocabularyKey CreatedByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey LookUpMappingIdUnique { get; private set; }


    }
}

