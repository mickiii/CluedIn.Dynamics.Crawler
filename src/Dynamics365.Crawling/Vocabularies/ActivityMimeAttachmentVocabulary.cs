using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ActivityMimeAttachmentVocabulary : SimpleVocabulary
    {
        public ActivityMimeAttachmentVocabulary()
        {
            VocabularyName = "Dynamics365 ActivityMimeAttachment";
            KeyPrefix = "dynamics365.activitymimeattachment";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ActivityMimeAttachment", group =>
            {
                this.AttachmentNumber = group.Add(new VocabularyKey("AttachmentNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Number of the attachment.")
                    .WithDisplayName("Attachment Number")
                    .ModelProperty("attachmentnumber", typeof(long)));

                this.ActivityMimeAttachmentId = group.Add(new VocabularyKey("ActivityMimeAttachmentId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the attachment.")
                    .WithDisplayName("Activity Mime Attachment")
                    .ModelProperty("activitymimeattachmentid", typeof(Guid)));

                this.ActivityId = group.Add(new VocabularyKey("ActivityId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the activity with which the attachment is associated.")
                    .WithDisplayName("Regarding")
                    .ModelProperty("activityid", typeof(string)));

                this.Body = group.Add(new VocabularyKey("Body", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(1073741823))
                    .WithDescription(@"Contents of the attachment.")
                    .WithDisplayName("Body")
                    .ModelProperty("body", typeof(string)));

                this.Subject = group.Add(new VocabularyKey("Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(2000))
                    .WithDescription(@"Descriptive subject for the attachment.")
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
                    .WithDisplayName("Mime Type")
                    .ModelProperty("mimetype", typeof(string)));

                this.FileName = group.Add(new VocabularyKey("FileName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(255))
                    .WithDescription(@"File name of the attachment.")
                    .WithDisplayName("File Name")
                    .ModelProperty("filename", typeof(string)));

                this.OwningUser = group.Add(new VocabularyKey("OwningUser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user who owns the activity mime attachment.")
                    .WithDisplayName("Owner")
                    .ModelProperty("owninguser", typeof(string)));

                this.VersionNumber = group.Add(new VocabularyKey("VersionNumber", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Version number of the activity mime attachment.")
                    .WithDisplayName("Version Number")
                    .ModelProperty("versionnumber", typeof(int)));

                this.OwningBusinessUnit = group.Add(new VocabularyKey("OwningBusinessUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the business unit that owns the activity mime attachment.")
                    .WithDisplayName("Owning Business Unit")
                    .ModelProperty("owningbusinessunit", typeof(string)));

                this.OwnerIdType = group.Add(new VocabularyKey("OwnerIdType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdType")
                    .ModelProperty("owneridtype", typeof(string)));

                this.OwnerId = group.Add(new VocabularyKey("OwnerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Unique identifier of the user or team who owns the activity_mime_attachment.")
                    .WithDisplayName("Owner")
                    .ModelProperty("ownerid", typeof(string)));

                this.AttachmentId = group.Add(new VocabularyKey("AttachmentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the attachment with which this activitymimeattachment is associated.")
                    .WithDisplayName("Attachment")
                    .ModelProperty("attachmentid", typeof(string)));

                this.ObjectId = group.Add(new VocabularyKey("ObjectId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Unique identifier of the record with which the attachment is associated")
                    .WithDisplayName("Item")
                    .ModelProperty("objectid", typeof(string)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"Object Type Code of the entity that is associated with the attachment.")
                    .WithDisplayName("Entity")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.ComponentState = group.Add(new VocabularyKey("ComponentState", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Component State")
                    .ModelProperty("componentstate", typeof(string)));

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

                this.SupportingSolutionId = group.Add(new VocabularyKey("SupportingSolutionId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("Solution")
                    .ModelProperty("supportingsolutionid", typeof(Guid)));

                this.ActivityMimeAttachmentIdUnique = group.Add(new VocabularyKey("ActivityMimeAttachmentIdUnique", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"For internal use only.")
                    .WithDisplayName("ActivityMimeAttachmentIdUnique")
                    .ModelProperty("activitymimeattachmentidunique", typeof(Guid)));

                this.IsManaged = group.Add(new VocabularyKey("IsManaged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates whether the solution component is part of a managed solution.")
                    .WithDisplayName("Is Managed")
                    .ModelProperty("ismanaged", typeof(bool)));

                this.IsManagedName = group.Add(new VocabularyKey("IsManagedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsManagedName")
                    .ModelProperty("ismanagedname", typeof(string)));

                this.AttachmentContentId = group.Add(new VocabularyKey("AttachmentContentId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(250))
                    .WithDescription(@"For internal use only")
                    .WithDisplayName("Content Id")
                    .ModelProperty("attachmentcontentid", typeof(string)));

                this.IsFollowed = group.Add(new VocabularyKey("IsFollowed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"Indicates if this attachment is followed.")
                    .WithDisplayName("Followed")
                    .ModelProperty("isfollowed", typeof(bool)));

                this.IsFollowedName = group.Add(new VocabularyKey("IsFollowedName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("IsFollowedName")
                    .ModelProperty("isfollowedname", typeof(string)));

                this.AnonymousLink = group.Add(new VocabularyKey("AnonymousLink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"anonymous link")
                    .WithDisplayName("For internal use only.")
                    .ModelProperty("anonymouslink", typeof(string)));

                this.ActivitySubject = group.Add(new VocabularyKey("ActivitySubject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(2000))
                    .WithDescription(@"Descriptive subject for the activity.")
                    .WithDisplayName("ActivitySubject")
                    .ModelProperty("activitysubject", typeof(string)));

                this.OwnerIdName = group.Add(new VocabularyKey("OwnerIdName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(100))
                    .WithDescription(@"")
                    .WithDisplayName("OwnerIdName")
                    .ModelProperty("owneridname", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey AttachmentNumber { get; private set; }

        public VocabularyKey ActivityMimeAttachmentId { get; private set; }

        public VocabularyKey ActivityId { get; private set; }

        public VocabularyKey Body { get; private set; }

        public VocabularyKey Subject { get; private set; }

        public VocabularyKey FileSize { get; private set; }

        public VocabularyKey MimeType { get; private set; }

        public VocabularyKey FileName { get; private set; }

        public VocabularyKey OwningUser { get; private set; }

        public VocabularyKey VersionNumber { get; private set; }

        public VocabularyKey OwningBusinessUnit { get; private set; }

        public VocabularyKey OwnerIdType { get; private set; }

        public VocabularyKey OwnerId { get; private set; }

        public VocabularyKey AttachmentId { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey ComponentState { get; private set; }

        public VocabularyKey OverwriteTime { get; private set; }

        public VocabularyKey SolutionId { get; private set; }

        public VocabularyKey SupportingSolutionId { get; private set; }

        public VocabularyKey ActivityMimeAttachmentIdUnique { get; private set; }

        public VocabularyKey IsManaged { get; private set; }

        public VocabularyKey IsManagedName { get; private set; }

        public VocabularyKey AttachmentContentId { get; private set; }

        public VocabularyKey IsFollowed { get; private set; }

        public VocabularyKey IsFollowedName { get; private set; }

        public VocabularyKey AnonymousLink { get; private set; }

        public VocabularyKey ActivitySubject { get; private set; }

        public VocabularyKey OwnerIdName { get; private set; }


    }
}

