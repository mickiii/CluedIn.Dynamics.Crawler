using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class PrincipalObjectAttributeAccessVocabulary : SimpleVocabulary
    {
        public PrincipalObjectAttributeAccessVocabulary()
        {
            VocabularyName = "Dynamics365 PrincipalObjectAttributeAccess";
            KeyPrefix = "dynamics365.principalobjectattributeaccess";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("PrincipalObjectAttributeAccess", group =>
            {
                this.PrincipalObjectAttributeAccessId = group.Add(new VocabularyKey("PrincipalObjectAttributeAccessId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the shared secured field instance")
                    .WithDisplayName("Shared secured field")
                    .ModelProperty("principalobjectattributeaccessid", typeof(Guid)));

                this.PrincipalId = group.Add(new VocabularyKey("PrincipalId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the principal to which secured field is shared")
                    .WithDisplayName("Principal")
                    .ModelProperty("principalid", typeof(string)));

                this.AttributeId = group.Add(new VocabularyKey("AttributeId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the shared secured field")
                    .WithDisplayName("Secured field")
                    .ModelProperty("attributeid", typeof(Guid)));

                this.ObjectId = group.Add(new VocabularyKey("ObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the entity instance with shared secured field")
                    .WithDisplayName("Entity instance")
                    .ModelProperty("objectid", typeof(string)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of the record with shared secured field")
                    .WithDisplayName("Entity object type")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.ReadAccess = group.Add(new VocabularyKey("ReadAccess", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Read permission for secured field instance")
                    .WithDisplayName("Read permission")
                    .ModelProperty("readaccess", typeof(bool)));

                this.UpdateAccess = group.Add(new VocabularyKey("UpdateAccess", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Update permission for secured field instance")
                    .WithDisplayName("Update permission")
                    .ModelProperty("updateaccess", typeof(bool)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the associated organization.")
                    .WithDisplayName("Organization")
                    .ModelProperty("organizationid", typeof(string)));

                this.OrganizationIdName = group.Add(new VocabularyKey("OrganizationIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("OrganizationIdName")
                    .ModelProperty("organizationidname", typeof(string)));

                this.PrincipalIdType = group.Add(new VocabularyKey("PrincipalIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Type of the principal to which secured field is shared")
                    .WithDisplayName("Principal type")
                    .ModelProperty("principalidtype", typeof(string)));

                this.PrincipalIdName = group.Add(new VocabularyKey("PrincipalIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("PrincipalIdName")
                    .ModelProperty("principalidname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey PrincipalObjectAttributeAccessId { get; private set; }

        public VocabularyKey PrincipalId { get; private set; }

        public VocabularyKey AttributeId { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey ReadAccess { get; private set; }

        public VocabularyKey UpdateAccess { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey OrganizationIdName { get; private set; }

        public VocabularyKey PrincipalIdType { get; private set; }

        public VocabularyKey PrincipalIdName { get; private set; }


    }
}

