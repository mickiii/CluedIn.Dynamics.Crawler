using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AttachmentVocabulary : SimpleVocabulary
    {
        public AttachmentVocabulary()
        {
            VocabularyName = "Dynamics365 Attachment";
            KeyPrefix = "dynamics365.attachment";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("Attachment", group =>
            {
                this.AttachmentId = group.Add(new VocabularyKey("AttachmentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the attachment.")
                    .WithDisplayName("Attachment")
                    .ModelProperty("attachmentid", typeof(Guid)));

                this.StoragePointer = group.Add(new VocabularyKey("StoragePointer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(10))
                    .WithDescription(@"Storage pointer.")
                    .WithDisplayName("Storage Pointer")
                    .ModelProperty("storagepointer", typeof(string)));

                this.Body = group.Add(new VocabularyKey("Body", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Contents of the attachment.")
                    .WithDisplayName("Body")
                    .ModelProperty("body", typeof(string)));

                this.Subject = group.Add(new VocabularyKey("Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Subject associated with the attachment.")
                    .WithDisplayName("Subject")
                    .ModelProperty("subject", typeof(string)));

                this.FileSize = group.Add(new VocabularyKey("FileSize", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"File size of the attachment.")
                    .WithDisplayName("File Size (Bytes)")
                    .ModelProperty("filesize", typeof(long)));

                this.MimeType = group.Add(new VocabularyKey("MimeType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"MIME type of the attachment.")
                    .WithDisplayName("MIME Type")
                    .ModelProperty("mimetype", typeof(string)));

                this.FileName = group.Add(new VocabularyKey("FileName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                    .WithDescription(@"File name of the attachment.")
                    .WithDisplayName("File Name")
                    .ModelProperty("filename", typeof(string)));

                this.Prefix = group.Add(new VocabularyKey("Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(10))
                    .WithDescription(@"Prefix of the file pointer in blob storage.")
                    .WithDisplayName("Prefix")
                    .ModelProperty("prefix", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the attachment.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.FilePointer = group.Add(new VocabularyKey("FilePointer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(255))
                    .WithDescription(@"File pointer of the attachment.")
                    .WithDisplayName("File Pointer")
                    .ModelProperty("filepointer", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey AttachmentId { get; private set; }

        public VocabularyKey StoragePointer { get; private set; }

        public VocabularyKey Body { get; private set; }

        public VocabularyKey Subject { get; private set; }

        public VocabularyKey FileSize { get; private set; }

        public VocabularyKey MimeType { get; private set; }

        public VocabularyKey FileName { get; private set; }

        public VocabularyKey Prefix { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey FilePointer { get; private set; }


    }
}

