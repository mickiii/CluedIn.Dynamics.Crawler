using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AuditVocabulary : SimpleVocabulary
    {
        public AuditVocabulary()
        {
            VocabularyName = "Dynamics365 Audit";
            KeyPrefix = "dynamics365.audit";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Audit", group =>
            {
                this.AttributeMask = group.Add(new VocabularyKey("AttributeMask", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Contains a CSV of the ColumnNumber metadata property of attributes")
                    .WithDisplayName("Changed Field")
                    .ModelProperty("attributemask", typeof(string)));

                this.TransactionId = group.Add(new VocabularyKey("TransactionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier for multiple changes that are part of a single operation; this field contains the same GUID for all the audit rows generated in a single transaction")
                    .WithDisplayName("Transaction Id")
                    .ModelProperty("transactionid", typeof(Guid)));

                this.Action = group.Add(new VocabularyKey("Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Actions the user can perform that cause a change")
                    .WithDisplayName("Event")
                    .ModelProperty("action", typeof(string)));

                this.ObjectId = group.Add(new VocabularyKey("ObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the record that is being audited")
                    .WithDisplayName("Record")
                    .ModelProperty("objectid", typeof(string)));

                this.UserId = group.Add(new VocabularyKey("UserId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who caused a change")
                    .WithDisplayName("Changed By")
                    .ModelProperty("userid", typeof(string)));

                this.ChangeData = group.Add(new VocabularyKey("ChangeData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Contains a CSV of old values of all the attributes whose IsAuditEnabled property is True and are being changed")
                    .WithDisplayName("Change Data")
                    .ModelProperty("changedata", typeof(string)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the audit record was created.")
                    .WithDisplayName("Changed Date")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.Operation = group.Add(new VocabularyKey("Operation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"The action that causes the audit--it will be create, delete, or update")
                    .WithDisplayName("Operation")
                    .ModelProperty("operation", typeof(string)));

                this.AuditId = group.Add(new VocabularyKey("AuditId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the auditing instance")
                    .WithDisplayName("Record Id")
                    .ModelProperty("auditid", typeof(Guid)));

                this.CallingUserId = group.Add(new VocabularyKey("CallingUserId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the calling user in case of an impersonated call")
                    .WithDisplayName("Calling User")
                    .ModelProperty("callinguserid", typeof(string)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the entity that is being audited")
                    .WithDisplayName("Entity")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.ObjectTypeCodeName = group.Add(new VocabularyKey("ObjectTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ObjectTypeCodeName")
                    .ModelProperty("objecttypecodename", typeof(string)));

                this.ActionName = group.Add(new VocabularyKey("ActionName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ActionName")
                    .ModelProperty("actionname", typeof(string)));

                this.OperationName = group.Add(new VocabularyKey("OperationName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OperationName")
                    .ModelProperty("operationname", typeof(string)));

                this.UserIdName = group.Add(new VocabularyKey("UserIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("UserIdName")
                    .ModelProperty("useridname", typeof(string)));

                this.ObjectIdName = group.Add(new VocabularyKey("ObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(160))
                    .WithDescription(@"")
                    .WithDisplayName("ObjectIdName")
                    .ModelProperty("objectidname", typeof(string)));

                this.CallingUserIdName = group.Add(new VocabularyKey("CallingUserIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("CallingUserIdName")
                    .ModelProperty("callinguseridname", typeof(string)));

                this.RegardingObjectId = group.Add(new VocabularyKey("RegardingObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the object with which the record is associated.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("regardingobjectid", typeof(string)));

                this.RegardingObjectIdName = group.Add(new VocabularyKey("RegardingObjectIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(400))
                    .WithDescription(@"")
                    .WithDisplayName("RegardingObjectIdName")
                    .ModelProperty("regardingobjectidname", typeof(string)));

                this.UserAdditionalInfo = group.Add(new VocabularyKey("UserAdditionalInfo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(350))
                    .WithDescription(@"Additional information associated to the user who caused the change.")
                    .WithDisplayName("User Info")
                    .ModelProperty("useradditionalinfo", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey AttributeMask { get; private set; }

        public VocabularyKey TransactionId { get; private set; }

        public VocabularyKey Action { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey UserId { get; private set; }

        public VocabularyKey ChangeData { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey Operation { get; private set; }

        public VocabularyKey AuditId { get; private set; }

        public VocabularyKey CallingUserId { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey ObjectTypeCodeName { get; private set; }

        public VocabularyKey ActionName { get; private set; }

        public VocabularyKey OperationName { get; private set; }

        public VocabularyKey UserIdName { get; private set; }

        public VocabularyKey ObjectIdName { get; private set; }

        public VocabularyKey CallingUserIdName { get; private set; }

        public VocabularyKey RegardingObjectId { get; private set; }

        public VocabularyKey RegardingObjectIdName { get; private set; }

        public VocabularyKey UserAdditionalInfo { get; private set; }


    }
}

