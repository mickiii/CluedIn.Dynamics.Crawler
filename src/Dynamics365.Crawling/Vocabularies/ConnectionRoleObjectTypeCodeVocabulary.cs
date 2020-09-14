using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ConnectionRoleObjectTypeCodeVocabulary : SimpleVocabulary
    {
        public ConnectionRoleObjectTypeCodeVocabulary()
        {
            VocabularyName = "Dynamics365 ConnectionRoleObjectTypeCode";
            KeyPrefix = "dynamics365.connectionroleobjecttypecode";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ConnectionRoleObjectTypeCode", group =>
            {
                this.ConnectionRoleId = group.Add(new VocabularyKey("ConnectionRoleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the connection role associated with the Connection Role Object Type Code.")
                    .WithDisplayName("Connection Role")
                    .ModelProperty("connectionroleid", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("VersionNumber")
                    .ModelProperty("versionnumber", typeof(int)));

                this.ConnectionRoleObjectTypeCodeId = group.Add(new VocabularyKey("ConnectionRoleObjectTypeCodeId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the connection role object type association.")
                    .WithDisplayName("ConnectionRoleObjectTypeCodeId")
                    .ModelProperty("connectionroleobjecttypecodeid", typeof(Guid)));

                this.AssociatedObjectTypeCode = group.Add(new VocabularyKey("AssociatedObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("AssociatedObjectTypeCode")
                    .ModelProperty("associatedobjecttypecode", typeof(string)));

                this.OrganizationId = group.Add(new VocabularyKey("OrganizationId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the organization associated with the connectionroleobjecttypecode.")
                    .WithDisplayName("Organization ")
                    .ModelProperty("organizationid", typeof(Guid)));

                this.ConnectionRoleIdName = group.Add(new VocabularyKey("ConnectionRoleIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("ConnectionRoleIdName")
                    .ModelProperty("connectionroleidname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ConnectionRoleId { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey ConnectionRoleObjectTypeCodeId { get; private set; }

        public VocabularyKey AssociatedObjectTypeCode { get; private set; }

        public VocabularyKey OrganizationId { get; private set; }

        public VocabularyKey ConnectionRoleIdName { get; private set; }


    }
}

