using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SolutionVocabulary : SimpleVocabulary
    {
        public SolutionVocabulary()
        {
            VocabularyName = "Dynamics365 Solution";
            KeyPrefix = "dynamics365.solution";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Solution", group =>
            {
                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.SolutionId = group.Add(new VocabularyKey("SolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the solution.")
                    .WithDisplayName("Solution Identifier")
                    .ModelProperty("solutionid", typeof(Guid)));

                this.InstalledOn = group.Add(new VocabularyKey("InstalledOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the solution was installed/upgraded.")
                    .WithDisplayName("Installed On")
                    .ModelProperty("installedon", typeof(DateTime)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the solution was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the solution.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.PublisherId = group.Add(new VocabularyKey("PublisherId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the publisher.")
                    .WithDisplayName("Publisher")
                    .ModelProperty("publisherid", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the solution was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the solution.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.IsVisible = group.Add(new VocabularyKey("IsVisible", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the solution is visible outside of the platform.")
                    .WithDisplayName("Is Visible Outside Platform")
                    .ModelProperty("isvisible", typeof(bool)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Description of the solution.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the solution is managed or unmanaged.")
                    .WithDisplayName("Package Type")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.UniqueName = group.Add(new VocabularyKey("UniqueName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(65))
                    .WithDescription(@"The unique name of this solution")
                    .WithDisplayName("Name")
                    .ModelProperty("uniquename", typeof(string)));

                this.FriendlyName = group.Add(new VocabularyKey("FriendlyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"User display name for the solution.")
                    .WithDisplayName("Display Name")
                    .ModelProperty("friendlyname", typeof(string)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the solution.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.PublisherIdName = group.Add(new VocabularyKey("PublisherIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"name of the publisher.")
                    .WithDisplayName("Publisher")
                    .ModelProperty("publisheridname", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

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

                this.PublisherIdPrefix = group.Add(new VocabularyKey("PublisherIdPrefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("PublisherIdPrefix")
                    .ModelProperty("publisheridprefix", typeof(string)));

                this.Version = group.Add(new VocabularyKey("Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Solution version, used to identify a solution for upgrades and hotfixes.")
                    .WithDisplayName("Version")
                    .ModelProperty("version", typeof(string)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the solution.")
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

                this.CreatedOnBehalfBy = group.Add(new VocabularyKey("CreatedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who created the solution.")
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

                this.PublisherIdOptionValuePrefix = group.Add(new VocabularyKey("PublisherIdOptionValuePrefix", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("PublisherIdOptionValuePrefix")
                    .ModelProperty("publisheridoptionvalueprefix", typeof(long)));

                this.PinpointSolutionId = group.Add(new VocabularyKey("PinpointSolutionId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Identifier of the solution in Microsoft Pinpoint.")
                    .WithDisplayName("PinpointSolutionId")
                    .ModelProperty("pinpointsolutionid", typeof(int)));

                this.PinpointSolutionDefaultLocale = group.Add(new VocabularyKey("PinpointSolutionDefaultLocale", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(16))
                    .WithDescription(@"Default locale of the solution in Microsoft Pinpoint.")
                    .WithDisplayName("PinpointSolutionDefaultLocale")
                    .ModelProperty("pinpointsolutiondefaultlocale", typeof(string)));

                this.PinpointPublisherId = group.Add(new VocabularyKey("PinpointPublisherId", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Identifier of the publisher of this solution in Microsoft Pinpoint.")
                    .WithDisplayName("PinpointPublisherId")
                    .ModelProperty("pinpointpublisherid", typeof(int)));

                this.ConfigurationPageId = group.Add(new VocabularyKey("ConfigurationPageId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"A link to an optional configuration page for this solution.")
                    .WithDisplayName("Configuration Page")
                    .ModelProperty("configurationpageid", typeof(string)));

                this.ConfigurationPageIdName = group.Add(new VocabularyKey("ConfigurationPageIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("ConfigurationPageIdName")
                    .ModelProperty("configurationpageidname", typeof(string)));

                this.PinpointAssetId = group.Add(new VocabularyKey("PinpointAssetId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(255))
                    .WithDescription(@"")
                    .WithDisplayName("PinpointAssetId")
                    .ModelProperty("pinpointassetid", typeof(string)));

                this.SolutionPackageVersion = group.Add(new VocabularyKey("SolutionPackageVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Solution package source organization version")
                    .WithDisplayName("Solution Package Version")
                    .ModelProperty("solutionpackageversion", typeof(string)));

                this.ParentSolutionId = group.Add(new VocabularyKey("ParentSolutionId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the parent solution. Should only be non-null if this solution is a patch.")
                    .WithDisplayName("Parent Solution")
                    .ModelProperty("parentsolutionid", typeof(string)));

                this.ParentSolutionIdName = group.Add(new VocabularyKey("ParentSolutionIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ParentSolutionIdName")
                    .ModelProperty("parentsolutionidname", typeof(string)));

                this.IsInternal = group.Add(new VocabularyKey("IsInternal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the solution is internal or not.")
                    .WithDisplayName("Is internal solution")
                    .ModelProperty("isinternal", typeof(bool)));

                this.SolutionType = group.Add(new VocabularyKey("SolutionType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Solution Type")
                    .WithDisplayName("Solution Type")
                    .ModelProperty("solutiontype", typeof(string)));

                this.UpdatedOn = group.Add(new VocabularyKey("UpdatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the solution was updated.")
                    .WithDisplayName("Updated On")
                    .ModelProperty("updatedon", typeof(DateTime)));

                this.IsApiManaged = group.Add(new VocabularyKey("IsApiManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information about whether the solution is api managed.")
                    .WithDisplayName("Is Api Managed Solution")
                    .ModelProperty("isapimanaged", typeof(bool)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey InstalledOn { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey PublisherId { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey IsVisible { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey UniqueName { get; private set; }

        public VocabularyKey FriendlyName { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey PublisherIdName { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey CreatedByName { get; private set; }

        public VocabularyKey ModifiedByName { get; private set; }

        public VocabularyKey PublisherIdPrefix { get; private set; }

        public VocabularyKey Version { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey PublisherIdOptionValuePrefix { get; private set; }

        public VocabularyKey PinpointSolutionId { get; private set; }

        public VocabularyKey PinpointSolutionDefaultLocale { get; private set; }

        public VocabularyKey PinpointPublisherId { get; private set; }

        public VocabularyKey ConfigurationPageId { get; private set; }

        public VocabularyKey ConfigurationPageIdName { get; private set; }

        public VocabularyKey PinpointAssetId { get; private set; }

        public VocabularyKey SolutionPackageVersion { get; private set; }

        public VocabularyKey ParentSolutionId { get; private set; }

        public VocabularyKey ParentSolutionIdName { get; private set; }

        public VocabularyKey IsInternal { get; private set; }

        public VocabularyKey SolutionType { get; private set; }

        public VocabularyKey UpdatedOn { get; private set; }

        public VocabularyKey IsApiManaged { get; private set; }


    }
}

