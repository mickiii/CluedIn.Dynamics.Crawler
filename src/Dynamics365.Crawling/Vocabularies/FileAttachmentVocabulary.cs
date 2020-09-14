using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class FileAttachmentVocabulary : SimpleVocabulary
    {
        public FileAttachmentVocabulary()
        {
            VocabularyName = "Dynamics365 FileAttachment";
            KeyPrefix = "dynamics365.fileattachment";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("FileAttachment", group =>
            {
                this.FileAttachmentId = group.Add(new VocabularyKey("FileAttachmentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the file attachment.")
                    .WithDisplayName("FileAttachmentId")
                    .ModelProperty("fileattachmentid", typeof(Guid)));

                this.FilePointer = group.Add(new VocabularyKey("FilePointer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(255))
                    .WithDescription(@"File pointer of the attachment.")
                    .WithDisplayName("File Pointer")
                    .ModelProperty("filepointer", typeof(string)));

                this.FileName = group.Add(new VocabularyKey("FileName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                    .WithDescription(@"File name of the attachment.")
                    .WithDisplayName("File Name")
                    .ModelProperty("filename", typeof(string)));

                this.FileSize = group.Add(new VocabularyKey("FileSize", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("FileSize")
                    .ModelProperty("filesize", typeof(long)));

                this.MimeType = group.Add(new VocabularyKey("MimeType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"MIME type of the attachment.")
                    .WithDisplayName("MIME Type")
                    .ModelProperty("mimetype", typeof(string)));

                this.Prefix = group.Add(new VocabularyKey("Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(10))
                    .WithDescription(@"Prefix of the file pointer in blob storage.")
                    .WithDisplayName("Prefix")
                    .ModelProperty("prefix", typeof(string)));

                this.StoragePointer = group.Add(new VocabularyKey("StoragePointer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(10))
                    .WithDescription(@"Storage pointer.")
                    .WithDisplayName("Storage Pointer")
                    .ModelProperty("storagepointer", typeof(string)));

                this.ObjectId = group.Add(new VocabularyKey("ObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the object with which the attachment is associated.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("objectid", typeof(string)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of entity with which the file attachment is associated.")
                    .WithDisplayName("Object Type ")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.ObjectTypeCodeName = group.Add(new VocabularyKey("ObjectTypeCodeName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ObjectTypeCodeName")
                    .ModelProperty("objecttypecodename", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the file attachment.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.CreatedOn = group.Add(new VocabularyKey("CreatedOn", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Date and time when the attachment was created.")
                    .WithDisplayName("Created On")
                    .ModelProperty("createdon", typeof(DateTime)));

                this.ObjectIdTypeCode = group.Add(new VocabularyKey("ObjectIdTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Type of entity with which the file attachment is associated.")
                    .WithDisplayName("Object Id Type Code")
                    .ModelProperty("objectidtypecode", typeof(string)));

                this.RegardingFieldName = group.Add(new VocabularyKey("RegardingFieldName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                    .WithDescription(@"Regarding attribute schema name of the attachment.")
                    .WithDisplayName("Regarding Attribute Schema Name")
                    .ModelProperty("regardingfieldname", typeof(string)));

                this.FileSizeInBytes = group.Add(new VocabularyKey("FileSizeInBytes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"File size of the attachment in bytes.")
                    .WithDisplayName("File Size (Bytes)")
                    .ModelProperty("filesizeinbytes", typeof(int)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey FileAttachmentId { get; private set; }

        public VocabularyKey FilePointer { get; private set; }

        public VocabularyKey FileName { get; private set; }

        public VocabularyKey FileSize { get; private set; }

        public VocabularyKey MimeType { get; private set; }

        public VocabularyKey Prefix { get; private set; }

        public VocabularyKey StoragePointer { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey ObjectTypeCodeName { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey CreatedOn { get; private set; }

        public VocabularyKey ObjectIdTypeCode { get; private set; }

        public VocabularyKey RegardingFieldName { get; private set; }

        public VocabularyKey FileSizeInBytes { get; private set; }


    }
}

