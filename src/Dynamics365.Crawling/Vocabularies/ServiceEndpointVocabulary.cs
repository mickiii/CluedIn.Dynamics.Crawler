using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ServiceEndpointVocabulary : SimpleVocabulary
    {
        public ServiceEndpointVocabulary()
        {
            VocabularyName = "Dynamics365 ServiceEndpoint";
            KeyPrefix = "dynamics365.serviceendpoint";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ServiceEndpoint", group =>
            {
                this.ServiceEndpointId = group.Add(new VocabularyKey("ServiceEndpointId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the service endpoint.")
                    .WithDisplayName("ServiceEndpointId")
                    .ModelProperty("serviceendpointid", typeof(Guid)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization with which the service endpoint is associated.")
                    .WithDisplayName("OrganizationId")
                    .ModelProperty("organizationid", typeof(string)));

                this.SolutionNamespace = group.Add(new VocabularyKey("SolutionNamespace", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Namespace of the App Fabric solution.")
                    .WithDisplayName("Service Namespace")
                    .ModelProperty("solutionnamespace", typeof(string)));

                this.Path = group.Add(new VocabularyKey("Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(160))
                    .WithDescription(@"Path to the service endpoint.")
                    .WithDisplayName("Path")
                    .ModelProperty("path", typeof(string)));

                this.Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Description of the service endpoint.")
                    .WithDisplayName("Description")
                    .ModelProperty("description", typeof(string)));

                this.Contract = group.Add(new VocabularyKey("Contract", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of the endpoint contract.")
                    .WithDisplayName("Contract")
                    .ModelProperty("contract", typeof(string)));

                this.ContractName = group.Add(new VocabularyKey("ContractName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ContractName")
                    .ModelProperty("contractname", typeof(string)));

                this.ConnectionMode = group.Add(new VocabularyKey("ConnectionMode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Connection mode to contact the service endpoint.")
                    .WithDisplayName("Connection Mode")
                    .ModelProperty("connectionmode", typeof(string)));

                this.ConnectionModeName = group.Add(new VocabularyKey("ConnectionModeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ConnectionModeName")
                    .ModelProperty("connectionmodename", typeof(string)));

                this.UserClaim = group.Add(new VocabularyKey("UserClaim", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Additional user claim value type.")
                    .WithDisplayName("User Claim")
                    .ModelProperty("userclaim", typeof(string)));

                this.UserClaimName = group.Add(new VocabularyKey("UserClaimName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("UserClaimName")
                    .ModelProperty("userclaimname", typeof(string)));

                this.CreatedBy = group.Add(new VocabularyKey("CreatedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who created the service endpoint.")
                    .WithDisplayName("Created By")
                    .ModelProperty("createdby", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the service endpoint was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ModifiedBy = group.Add(new VocabularyKey("ModifiedBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who last modified the service endpoint.")
                    .WithDisplayName("Modified By")
                    .ModelProperty("modifiedby", typeof(string)));

                this.ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the service endpoint was last modified.")
                    .WithDisplayName("Modified On")
                    .ModelProperty("modifiedon", typeof(DateTime)));

                this.ModifiedOnBehalfBy = group.Add(new VocabularyKey("ModifiedOnBehalfBy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the delegate user who modified the service endpoint.")
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
                    .WithDescription(@"Unique identifier of the delegate user who created the service endpoint.")
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

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

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

                this.OverwriteTime = group.Add(new VocabularyKey("OverwriteTime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Record Overwrite Time")
                    .ModelProperty("overwritetime", typeof(DateTime)));

                this.ServiceEndpointIdUnique = group.Add(new VocabularyKey("ServiceEndpointIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the service endpoint.")
                    .WithDisplayName("ServiceEndpointIdUnique")
                    .ModelProperty("serviceendpointidunique", typeof(Guid)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Information that specifies whether this component is managed.")
                    .WithDisplayName("State")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Name of Service end point.")
                    .WithDisplayName("Name")
                    .ModelProperty("name", typeof(string)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.IsCustomizable = group.Add(new VocabularyKey("IsCustomizable", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Information that specifies whether this component can be customized.")
                    .WithDisplayName("Customizable")
                    .ModelProperty("iscustomizable", typeof(string)));

                this.IntroducedVersion = group.Add(new VocabularyKey("IntroducedVersion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(48))
                    .WithDescription(@"Version in which the form is introduced.")
                    .WithDisplayName("Introduced Version")
                    .ModelProperty("introducedversion", typeof(string)));

                this.AuthType = group.Add(new VocabularyKey("AuthType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Specifies mode of authentication with SB")
                    .WithDisplayName("Specifies mode of authentication with SB")
                    .ModelProperty("authtype", typeof(string)));

                this.AuthTypeName = group.Add(new VocabularyKey("AuthTypeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AuthTypeName")
                    .ModelProperty("authtypename", typeof(string)));

                this.MessageFormat = group.Add(new VocabularyKey("MessageFormat", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Content type of the message")
                    .WithDisplayName("Content type of the message")
                    .ModelProperty("messageformat", typeof(string)));

                this.SASKey = group.Add(new VocabularyKey("SASKey", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Shared Access Key")
                    .WithDisplayName("Shared Access Key")
                    .ModelProperty("saskey", typeof(string)));

                this.SASKeyName = group.Add(new VocabularyKey("SASKeyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Shared Access Key Name")
                    .WithDisplayName("Shared Access Key Name")
                    .ModelProperty("saskeyname", typeof(string)));

                this.MessageFormatName = group.Add(new VocabularyKey("MessageFormatName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("MessageFormatName")
                    .ModelProperty("messageformatname", typeof(string)));

                this.SASToken = group.Add(new VocabularyKey("SASToken", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"Shared Access Token")
                    .WithDisplayName("Shared Access Token")
                    .ModelProperty("sastoken", typeof(string)));

                this.NamespaceFormat = group.Add(new VocabularyKey("NamespaceFormat", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Format of Service Bus Namespace")
                    .WithDisplayName("Format of Service Bus Namespace")
                    .ModelProperty("namespaceformat", typeof(string)));

                this.NamespaceFormatName = group.Add(new VocabularyKey("NamespaceFormatName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("NamespaceFormatName")
                    .ModelProperty("namespaceformatname", typeof(string)));

                this.NamespaceAddress = group.Add(new VocabularyKey("NamespaceAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                    .WithDescription(@"Full service endpoint address.")
                    .WithDisplayName("Namespace Address")
                    .ModelProperty("namespaceaddress", typeof(string)));

                this.IsSASTokenSet = group.Add(new VocabularyKey("IsSASTokenSet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsSASTokenSet")
                    .ModelProperty("issastokenset", typeof(bool)));

                this.IsSASKeySet = group.Add(new VocabularyKey("IsSASKeySet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsSASKeySet")
                    .ModelProperty("issaskeyset", typeof(bool)));

                this.AuthValue = group.Add(new VocabularyKey("AuthValue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2048))
                    .WithDescription(@"Authentication Value")
                    .WithDisplayName("Authentication Value")
                    .ModelProperty("authvalue", typeof(string)));

                this.Url = group.Add(new VocabularyKey("Url", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Full service endpoint Url.")
                    .WithDisplayName("Url Address")
                    .ModelProperty("url", typeof(string)));

                this.IsAuthValueSet = group.Add(new VocabularyKey("IsAuthValueSet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsAuthValueSet")
                    .ModelProperty("isauthvalueset", typeof(bool)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ServiceEndpointId { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey SolutionNamespace { get; private set; }

        public VocabularyKey Path { get; private set; }

        public VocabularyKey Description { get; private set; }

        public VocabularyKey Contract { get; private set; }

        public VocabularyKey ContractName { get; private set; }

        public VocabularyKey ConnectionMode { get; private set; }

        public VocabularyKey ConnectionModeName { get; private set; }

        public VocabularyKey UserClaim { get; private set; }

        public VocabularyKey UserClaimName { get; private set; }

        public VocabularyKey CreatedBy { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ModifiedBy { get; private set; }

        public VocabularyKey ModifiedOn { get; private set; }

        public VocabularyKey ModifiedOnBehalfBy { get; private set; }

        public VocabularyKey ModifiedOnBehalfByName { get; private set; }

        public VocabularyKey ModifiedOnBehalfByYomiName { get; private set; }

        public VocabularyKey CreatedOnBehalfBy { get; private set; }

        public VocabularyKey CreatedOnBehalfByName { get; private set; }

        public VocabularyKey CreatedOnBehalfByYomiName { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey ServiceEndpointIdUnique { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey Name { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey IsCustomizable { get; private set; }

        public VocabularyKey IntroducedVersion { get; private set; }

        public VocabularyKey AuthType { get; private set; }

        public VocabularyKey AuthTypeName { get; private set; }

        public VocabularyKey MessageFormat { get; private set; }

        public VocabularyKey SASKey { get; private set; }

        public VocabularyKey SASKeyName { get; private set; }

        public VocabularyKey MessageFormatName { get; private set; }

        public VocabularyKey SASToken { get; private set; }

        public VocabularyKey NamespaceFormat { get; private set; }

        public VocabularyKey NamespaceFormatName { get; private set; }

        public VocabularyKey NamespaceAddress { get; private set; }

        public VocabularyKey IsSASTokenSet { get; private set; }

        public VocabularyKey IsSASKeySet { get; private set; }

        public VocabularyKey AuthValue { get; private set; }

        public VocabularyKey Url { get; private set; }

        public VocabularyKey IsAuthValueSet { get; private set; }


    }
}

