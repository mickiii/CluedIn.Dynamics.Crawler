using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SdkMessageProcessingStepSecureConfigVocabulary : SimpleVocabulary
    {
        public SdkMessageProcessingStepSecureConfigVocabulary()
        {
            VocabularyName = "Dynamics365 SdkMessageProcessingStepSecureConfig";
            KeyPrefix = "dynamics365.sdkmessageprocessingstepsecureconfig";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("SdkMessageProcessingStepSecureConfig", group =>
            {
                this.CustomizationLevel = group.Add(new VocabularyKey("CustomizationLevel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Customization level of the SDK message processing step secure configuration.")
                    .WithDisplayName("CustomizationLevel")
                    .ModelProperty("customizationlevel", typeof(long)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the SDK message processing step was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.SecureConfig = group.Add(new VocabularyKey("SecureConfig", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Secure step-specific configuration for the plug-in type that is passed to the plug-in's constructor at run time.")
                    .WithDisplayName("Secure Configuration")
                    .ModelProperty("secureconfig", typeof(string)));

                this.SdkMessageProcessingStepSecureConfigId = group.Add(new VocabularyKey("SdkMessageProcessingStepSecureConfigId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the SDK message processing step secure configuration.")
                    .WithDisplayName("SdkMessageProcessingStepSecureConfigId")
                    .ModelProperty("sdkmessageprocessingstepsecureconfigid", typeof(Guid)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the SDK message processing step.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.SdkMessageProcessingStepSecureConfigIdUnique = group.Add(new VocabularyKey("SdkMessageProcessingStepSecureConfigIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the SDK message processing step.")
                    .WithDisplayName("SdkMessageProcessingStepSecureConfigIdUnique")
                    .ModelProperty("sdkmessageprocessingstepsecureconfigidunique", typeof(Guid)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the SDK message processing step was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization with which the SDK message processing step is associated.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the SDK message processing step.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the sdkmessageprocessingstepsecureconfig.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who last modified the sdkmessageprocessingstepsecureconfig.")
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


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey CustomizationLevel { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey SecureConfig { get; private set; }

        public VocabularyKey SdkMessageProcessingStepSecureConfigId { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey SdkMessageProcessingStepSecureConfigIdUnique { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }


    }
}

