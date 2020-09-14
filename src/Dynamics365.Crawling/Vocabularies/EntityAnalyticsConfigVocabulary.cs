using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class EntityAnalyticsConfigVocabulary : SimpleVocabulary
    {
        public EntityAnalyticsConfigVocabulary()
        {
            VocabularyName = "Dynamics365 EntityAnalyticsConfig";
            KeyPrefix = "dynamics365.entityanalyticsconfig";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("EntityAnalyticsConfig", group =>
            {
                this.EntityAnalyticsConfigId = group.Add(new VocabularyKey("EntityAnalyticsConfigId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for entity instances")
                    .WithDisplayName("Entity Analytics Config")
                    .ModelProperty("entityanalyticsconfigid", typeof(Guid)));

                this.ComponentIdUnique = group.Add(new VocabularyKey("ComponentIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Row id unique")
                    .ModelProperty("componentidunique", typeof(Guid)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.componentstateName = group.Add(new VocabularyKey("componentstateName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("componentstateName")
                    .ModelProperty("componentstatename", typeof(string)));

                this.ParentEntityLogicalName = group.Add(new VocabularyKey("ParentEntityLogicalName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"Entity Logical Name For Analytics")
                    .WithDisplayName("Entity Logical Name For Analytics")
                    .ModelProperty("parententitylogicalname", typeof(string)));

                this.ParentEntityId = group.Add(new VocabularyKey("ParentEntityId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for Entity associated with Entity Analytics Config.")
                    .WithDisplayName("Parent Entity Id")
                    .ModelProperty("parententityid", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of Entity Analytics Config.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.IsEnabledForADLS = group.Add(new VocabularyKey("IsEnabledForADLS", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Azure Data Lake Storage is enabled for the selected entity")
                    .WithDisplayName("Is Enabled For ADLS")
                    .ModelProperty("isenabledforadls", typeof(bool)));

                this.isenabledforadlsName = group.Add(new VocabularyKey("isenabledforadlsName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("isenabledforadlsName")
                    .ModelProperty("isenabledforadlsname", typeof(string)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the solution component is part of a managed solution.")
                    .WithDisplayName("Is Managed")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.ismanagedName = group.Add(new VocabularyKey("ismanagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ismanagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

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

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for the organization")
                    .WithDisplayName("Organization Id")
                    .ModelProperty("organizationid", typeof(string)));

                this.ParentEntityIdName = group.Add(new VocabularyKey("ParentEntityIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentEntityIdName")
                    .ModelProperty("parententityidname", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey EntityAnalyticsConfigId { get; private set; }

        public VocabularyKey ComponentIdUnique { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey componentstateName { get; private set; }

        public VocabularyKey ParentEntityLogicalName { get; private set; }

        public VocabularyKey ParentEntityId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey IsEnabledForADLS { get; private set; }

        public VocabularyKey isenabledforadlsName { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey ismanagedName { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey ParentEntityIdName { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }


    }
}

