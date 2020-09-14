using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class PluginAssemblyVocabulary : SimpleVocabulary
    {
        public PluginAssemblyVocabulary()
        {
            VocabularyName = "Dynamics365 PluginAssembly";
            KeyPrefix = "dynamics365.pluginassembly";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("PluginAssembly", group =>
            {
                this.SourceHash = group.Add(new VocabularyKey("SourceHash", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Hash of the source of the assembly.")
                    .WithDisplayName("SourceHash")
                    .ModelProperty("sourcehash", typeof(string)));

                this.CustomizationLevel = group.Add(new VocabularyKey("CustomizationLevel", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Customization Level.")
                    .WithDisplayName("CustomizationLevel")
                    .ModelProperty("customizationlevel", typeof(long)));

                this.Content = group.Add(new VocabularyKey("Content", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Bytes of the assembly, in Base64 format.")
                    .WithDisplayName("Content")
                    .ModelProperty("content", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization with which the plug-in assembly is associated.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the plug-in assembly was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.Path = group.Add(new VocabularyKey("Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"File name of the plug-in assembly. Used when the source type is set to 1.")
                    .WithDisplayName("Path")
                    .ModelProperty("path", typeof(string)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Name of the plug-in assembly.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the plug-in assembly.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.Version = group.Add(new VocabularyKey("Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(48))
                    .WithDescription(@"Version number of the assembly. The value can be obtained from the assembly through reflection.")
                    .WithDisplayName("Version")
                    .ModelProperty("version", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the plug-in assembly.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the plug-in assembly was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.PluginAssemblyId = group.Add(new VocabularyKey("PluginAssemblyId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the plug-in assembly.")
                    .WithDisplayName("PluginAssemblyId")
                    .ModelProperty("pluginassemblyid", typeof(Guid)));

                this.Culture = group.Add(new VocabularyKey("Culture", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(32))
                    .WithDescription(@"Culture code for the plug-in assembly.")
                    .WithDisplayName("Culture")
                    .ModelProperty("culture", typeof(string)));

                this.SourceType = group.Add(new VocabularyKey("SourceType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Location of the assembly, for example 0=database, 1=on-disk.")
                    .WithDisplayName("Source Type")
                    .ModelProperty("sourcetype", typeof(string)));

                this.PluginAssemblyIdUnique = group.Add(new VocabularyKey("PluginAssemblyIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the plug-in assembly.")
                    .WithDisplayName("PluginAssemblyIdUnique")
                    .ModelProperty("pluginassemblyidunique", typeof(Guid)));

                this.PublicKeyToken = group.Add(new VocabularyKey("PublicKeyToken", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(32))
                    .WithDescription(@"Public key token of the assembly. This value can be obtained from the assembly by using reflection.")
                    .WithDisplayName("Public Key Token")
                    .ModelProperty("publickeytoken", typeof(string)));

                this.IsolationMode = group.Add(new VocabularyKey("IsolationMode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information about how the plugin assembly is to be isolated at execution time; None / Sandboxed.")
                    .WithDisplayName("Isolation Mode")
                    .ModelProperty("isolationmode", typeof(string)));

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the pluginassembly.")
                    .WithDisplayName("Created By (Delegate)")
                    .ModelProperty("createdonbehalfby", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who last modified the pluginassembly.")
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

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

                this.CreatedByName = group.Add(new VocabularyKey("CreatedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CreatedByName")
                    .ModelProperty("createdbyname", typeof(string)));

                this.IsolationModeName = group.Add(new VocabularyKey("IsolationModeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsolationModeName")
                    .ModelProperty("isolationmodename", typeof(string)));

                this.ModifiedByName = group.Add(new VocabularyKey("ModifiedByName", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ModifiedByName")
                    .ModelProperty("modifiedbyname", typeof(string)));

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

                this.SourceTypeName = group.Add(new VocabularyKey("SourceTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("SourceTypeName")
                    .ModelProperty("sourcetypename", typeof(string)));

                this.SupportingSolutionId = group.Add(new VocabularyKey("SupportingSolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Solution")
                    .ModelProperty("supportingsolutionid", typeof(Guid)));

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

                this.Major = group.Add(new VocabularyKey("Major", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Major of the assembly version.")
                    .WithDisplayName("Major")
                    .ModelProperty("major", typeof(long)));

                this.Minor = group.Add(new VocabularyKey("Minor", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Minor of the assembly version.")
                    .WithDisplayName("Minor")
                    .ModelProperty("minor", typeof(long)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Description of the plug-in assembly.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.IsHidden = group.Add(new VocabularyKey("IsHidden", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component should be hidden.")
                    .WithDisplayName("Hidden")
                    .ModelProperty("ishidden", typeof(string)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the form is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.IsCustomizable = group.Add(new VocabularyKey("IsCustomizable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component can be customized.")
                    .WithDisplayName("Customizable")
                    .ModelProperty("iscustomizable", typeof(string)));

                this.AuthType = group.Add(new VocabularyKey("AuthType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies mode of authentication with web sources like WebApp")
                    .WithDisplayName("Specifies mode of authentication with web sources")
                    .ModelProperty("authtype", typeof(string)));

                this.AuthTypeName = group.Add(new VocabularyKey("AuthTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AuthTypeName")
                    .ModelProperty("authtypename", typeof(string)));

                this.UserName = group.Add(new VocabularyKey("UserName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"User Name")
                    .WithDisplayName("User Name")
                    .ModelProperty("username", typeof(string)));

                this.Password = group.Add(new VocabularyKey("Password", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"User Password")
                    .WithDisplayName("User Password")
                    .ModelProperty("password", typeof(string)));

                this.IsPasswordSet = group.Add(new VocabularyKey("IsPasswordSet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsPasswordSet")
                    .ModelProperty("ispasswordset", typeof(bool)));

                this.Url = group.Add(new VocabularyKey("Url", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Web Url")
                    .WithDisplayName("Web Url")
                    .ModelProperty("url", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey SourceHash { get; private set; }

        public VocabularyKey CustomizationLevel { get; private set; }

        public VocabularyKey Content { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey Path { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey Version { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey PluginAssemblyId { get; private set; }

        public VocabularyKey Culture { get; private set; }

        public VocabularyKey SourceType { get; private set; }

        public VocabularyKey PluginAssemblyIdUnique { get; private set; }

        public VocabularyKey PublicKeyToken { get; private set; }

        public VocabularyKey IsolationMode { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey IsolationModeName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SourceTypeName { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey Major { get; private set; }

        public VocabularyKey Minor { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey IsHidden { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey IsCustomizable { get; private set; }

        public VocabularyKey AuthType { get; private set; }

        public VocabularyKey AuthTypeName { get; private set; }

        public VocabularyKey UserName { get; private set; }

        public VocabularyKey Password { get; private set; }

        public VocabularyKey IsPasswordSet { get; private set; }

        public VocabularyKey Url { get; private set; }


    }
}

