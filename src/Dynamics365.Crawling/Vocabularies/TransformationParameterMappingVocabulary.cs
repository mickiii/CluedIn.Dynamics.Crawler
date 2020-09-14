using System;
    using CluedIn.Core.Data;
    using CluedIn.Core.Data.Vocabularies;

    namespace CluedIn.Crawling.Dynamics365.Vocabularies
    {
        public class TransformationParameterMappingVocabulary : SimpleVocabulary
        {
            public TransformationParameterMappingVocabulary()
            {
                VocabularyName = "Dynamics365 TransformationParameterMapping";
                KeyPrefix = "dynamics365.transformationparametermapping";
                KeySeparator = ".";
                Grouping = EntityType.Unknown; // TODO: Set value

                this.AddGroup("TransformationParameterMapping", group =>
                {
                    this.ParameterArrayIndex = group.Add(new VocabularyKey("ParameterArrayIndex", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Index of the array if the input parameter is an array.")
                        .WithDisplayName("Parameter Array Index")
                        .ModelProperty("parameterarrayindex", typeof(long)));
                    
                    this.ParameterTypeCode = group.Add(new VocabularyKey("ParameterTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Type of transformation parameter.")
                        .WithDisplayName("Parameter Type")
                        .ModelProperty("parametertypecode", typeof(string)));
                    
                    this.TransformationParameterMappingId = group.Add(new VocabularyKey("TransformationParameterMappingId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the transformation parameter mapping.")
                        .WithDisplayName("TransformationParameterMappingId")
                        .ModelProperty("transformationparametermappingid", typeof(Guid)));
                    
                    this.TransformationMappingId = group.Add(new VocabularyKey("TransformationMappingId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Unique identifier of the transformation with which the parameter is associated.")
                        .WithDisplayName("Transformation Mapping Id")
                        .ModelProperty("transformationmappingid", typeof(string)));
                    
                    this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the transformation parameter mapping was created.")
                        .WithDisplayName("Created On")
                        .ModelProperty("createdon", typeof(DateTime)));
                    
                    this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who created the parameter mapping.")
                        .WithDisplayName("Created By")
                        .ModelProperty("createdby", typeof(string)));
                    
                    this.DataTypeCode = group.Add(new VocabularyKey("DataTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Data type of the transformation parameter.")
                        .WithDisplayName("Parameter Data Type")
                        .ModelProperty("datatypecode", typeof(string)));
                    
                    this.Data = group.Add(new VocabularyKey("Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(500))
                        .WithDescription(@"Transformation data for transformation parameter")
                        .WithDisplayName("Data")
                        .ModelProperty("data", typeof(string)));
                    
                    this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Date and time when the transformation parameter mapping was last modified.")
                        .WithDisplayName("Modified On")
                        .ModelProperty("modifiedon", typeof(DateTime)));
                    
                    this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the user who last modified the transformation parameter mapping.")
                        .WithDisplayName("Modified By")
                        .ModelProperty("modifiedby", typeof(string)));
                    
                    this.ParameterSequence = group.Add(new VocabularyKey("ParameterSequence", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.NotEditable())
                        .WithDescription(@"Parameter sequence number.")
                        .WithDisplayName("Parameter Sequence")
                        .ModelProperty("parametersequence", typeof(long)));
                    
                    this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("ModifiedByName")
                        .ModelProperty("modifiedbyname", typeof(string)));
                    
                    this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"")
                        .WithDisplayName("CreatedByName")
                        .ModelProperty("createdbyname", typeof(string)));
                    
                    this.DataTypeCodeName = group.Add(new VocabularyKey("DataTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Data type name for transformation parameter")
                        .WithDisplayName("DataTypeCodeName")
                        .ModelProperty("datatypecodename", typeof(string)));
                    
                    this.ParameterTypeCodeName = group.Add(new VocabularyKey("ParameterTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Parameter type name for transformation parameter")
                        .WithDisplayName("ParameterTypeCodeName")
                        .ModelProperty("parametertypecodename", typeof(string)));
                    
                    this.TransformationMappingIdName = group.Add(new VocabularyKey("TransformationMappingIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                        .WithDescription(@"Name of the transformation.")
                        .WithDisplayName("TransformationMappingIdName")
                        .ModelProperty("transformationmappingidname", typeof(string)));
                    
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
                        .WithDescription(@"Unique identifier of the delegate user who created the transformationparametermapping.")
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
                        .WithDescription(@"Unique identifier of the delegate user who last modified the transformationparametermapping.")
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
                    
                    this.TransformationParameterMappingIdUnique = group.Add(new VocabularyKey("TransformationParameterMappingIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                        .WithDataAnnotations(k => k.CanEdit())
                        .WithDescription(@"Unique identifier of the Transformation Parameter Mapping.")
                        .WithDisplayName("TransformationParameterMappingIdUnique")
                        .ModelProperty("transformationparametermappingidunique", typeof(Guid)));
                    
                    
                });

                // Mappings
                //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
            }

            public VocabularyKey ParameterArrayIndex { get; private set; }
        
        public VocabularyKey ParameterTypeCode { get; private set; }
        
        public VocabularyKey TransformationParameterMappingId { get; private set; }
        
        public VocabularyKey TransformationMappingId { get; private set; }
        
        public VocabularyKey CreatedOn { get; private set; }
        
        public VocabularyKey CreatedBy { get; private set; }
        
        public VocabularyKey DataTypeCode { get; private set; }
        
        public VocabularyKey Data { get; private set; }
        
        public VocabularyKey ModifiedOn { get; private set; }
        
        public VocabularyKey ModifiedBy { get; private set; }
        
        public VocabularyKey ParameterSequence { get; private set; }
        
        public VocabularyKey ModifiedByName { get; private set; }
        
        public VocabularyKey CreatedByName { get; private set; }
        
        public VocabularyKey DataTypeCodeName { get; private set; }
        
        public VocabularyKey ParameterTypeCodeName { get; private set; }
        
        public VocabularyKey TransformationMappingIdName { get; private set; }
        
        public VocabularyKey CreatedByYomiName { get; private set; }
        
        public VocabularyKey ModifiedByYomiName { get; private set; }
        
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
        
        public VocabularyKey TransformationParameterMappingIdUnique { get; private set; }
        
        
        }
    }
    
