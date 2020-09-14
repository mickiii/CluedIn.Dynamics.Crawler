using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class BulkDeleteFailureVocabulary : SimpleVocabulary
    {
        public BulkDeleteFailureVocabulary()
        {
            VocabularyName = "Dynamics365 BulkDeleteFailure";
            KeyPrefix = "dynamics365.bulkdeletefailure";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("BulkDeleteFailure", group =>
            {
                this.ErrorDescription = group.Add(new VocabularyKey("ErrorDescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(512))
                    .WithDescription(@"Description of the error.")
                    .WithDisplayName("Error Description")
                    .ModelProperty("errordescription", typeof(string)));

                this.AsyncOperationId = group.Add(new VocabularyKey("AsyncOperationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the system job that created this record.")
                    .WithDisplayName("System Job")
                    .ModelProperty("asyncoperationid", typeof(string)));

                this.BulkDeleteFailureId = group.Add(new VocabularyKey("BulkDeleteFailureId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the bulk deletion failure record.")
                    .WithDisplayName("Bulk Deletion Failure")
                    .ModelProperty("bulkdeletefailureid", typeof(Guid)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the bulk deletion failure.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(Guid)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the record that can not be deleted.")
                    .WithDisplayName("Name")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.ErrorNumber = group.Add(new VocabularyKey("ErrorNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Error code for the failed bulk deletion.")
                    .WithDisplayName("Error Code")
                    .ModelProperty("errornumber", typeof(long)));

                this.OrderedQueryIndex = group.Add(new VocabularyKey("OrderedQueryIndex", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Index of the ordered query expression that retrieved this record.")
                    .WithDisplayName("Index")
                    .ModelProperty("orderedqueryindex", typeof(long)));

                this.BulkDeleteOperationId = group.Add(new VocabularyKey("BulkDeleteOperationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the bulk operation job which created this record")
                    .WithDisplayName("BulkDeleteOperationId")
                    .ModelProperty("bulkdeleteoperationid", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the bulk deletion failure record.
")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(Guid)));

                this.RegardingObjectIdYomiName = group.Add(new VocabularyKey("RegardingObjectIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdYomiName")
                    .ModelProperty("regardingobjectidyominame", typeof(string)));

                this.RegardingObjectTypeCode = group.Add(new VocabularyKey("RegardingObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectTypeCode")
                    .ModelProperty("regardingobjecttypecode", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the bulk operation log.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ErrorDescription { get; private set; }

        public VocabularyKey AsyncOperationId { get; private set; }

        public VocabularyKey BulkDeleteFailureId { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey ErrorNumber { get; private set; }

        public VocabularyKey OrderedQueryIndex { get; private set; }

        public VocabularyKey BulkDeleteOperationId { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey RegardingObjectIdYomiName { get; private set; }

        public VocabularyKey RegardingObjectTypeCode { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }


    }
}

