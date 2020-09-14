using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DuplicateRecordVocabulary : SimpleVocabulary
    {
        public DuplicateRecordVocabulary()
        {
            VocabularyName = "Dynamics365 DuplicateRecord";
            KeyPrefix = "dynamics365.duplicaterecord";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("DuplicateRecord", group =>
            {
                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the duplicate record.")
                    .WithDisplayName("Owning User")
                    .ModelProperty("owninguser", typeof(Guid)));

                this.DuplicateRuleId = group.Add(new VocabularyKey("DuplicateRuleId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the duplicate rule against which this duplicate was found.")
                    .WithDisplayName("DuplicateRuleId")
                    .ModelProperty("duplicateruleid", typeof(string)));

                this.BaseRecordId = group.Add(new VocabularyKey("BaseRecordId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the base record.")
                    .WithDisplayName("Base Record ID")
                    .ModelProperty("baserecordid", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the duplicate record was created.")
                    .WithDisplayName("CreatedOn")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.DuplicateId = group.Add(new VocabularyKey("DuplicateId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the duplicate record.")
                    .WithDisplayName("DuplicateId")
                    .ModelProperty("duplicateid", typeof(Guid)));

                this.AsyncOperationId = group.Add(new VocabularyKey("AsyncOperationId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the system job that created this record.")
                    .WithDisplayName("System Job")
                    .ModelProperty("asyncoperationid", typeof(string)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the duplicate record.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(Guid)));

                this.DuplicateRecordId = group.Add(new VocabularyKey("DuplicateRecordId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the potential duplicate record.")
                    .WithDisplayName("Duplicate Record ID")
                    .ModelProperty("duplicaterecordid", typeof(string)));

                this.BaseRecordIdTypeCode = group.Add(new VocabularyKey("BaseRecordIdTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("BaseRecordIdTypeCode")
                    .ModelProperty("baserecordidtypecode", typeof(string)));

                this.BaseRecordIdName = group.Add(new VocabularyKey("BaseRecordIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("BaseRecordIdName")
                    .ModelProperty("baserecordidname", typeof(string)));

                this.DuplicateRecordIdName = group.Add(new VocabularyKey("DuplicateRecordIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("DuplicateRecordIdName")
                    .ModelProperty("duplicaterecordidname", typeof(string)));

                this.DuplicateRecordIdYomiName = group.Add(new VocabularyKey("DuplicateRecordIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("DuplicateRecordIdYomiName")
                    .ModelProperty("duplicaterecordidyominame", typeof(string)));

                this.BaseRecordIdYomiName = group.Add(new VocabularyKey("BaseRecordIdYomiName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("BaseRecordIdYomiName")
                    .ModelProperty("baserecordidyominame", typeof(string)));

                this.DuplicateRecordIdTypeCode = group.Add(new VocabularyKey("DuplicateRecordIdTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("DuplicateRecordIdTypeCode")
                    .ModelProperty("duplicaterecordidtypecode", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the duplicate record.")
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

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey DuplicateRuleId { get; private set; }

        public VocabularyKey BaseRecordId { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey DuplicateId { get; private set; }

        public VocabularyKey AsyncOperationId { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey DuplicateRecordId { get; private set; }

        public VocabularyKey BaseRecordIdTypeCode { get; private set; }

        public VocabularyKey BaseRecordIdName { get; private set; }

        public VocabularyKey DuplicateRecordIdName { get; private set; }

        public VocabularyKey DuplicateRecordIdYomiName { get; private set; }

        public VocabularyKey BaseRecordIdYomiName { get; private set; }

        public VocabularyKey DuplicateRecordIdTypeCode { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }


    }
}

