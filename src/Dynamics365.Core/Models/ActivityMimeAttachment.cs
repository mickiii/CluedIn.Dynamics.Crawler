using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ActivityMimeAttachment : DynamicsModel
    {
        [JsonProperty("attachmentnumber")]
        public long? AttachmentNumber { get; set; }

        [JsonProperty("activitymimeattachmentid")]
        public Guid? ActivityMimeAttachmentId { get; set; }

        [JsonProperty("activityid")]
        public string ActivityId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("filesize")]
        public long? FileSize { get; set; }

        [JsonProperty("mimetype")]
        public string MimeType { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("owninguser")]
        public string OwningUser { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("owningbusinessunit")]
        public string OwningBusinessUnit { get; set; }

        [JsonProperty("owneridtype")]
        public string OwnerIdType { get; set; }

        [JsonProperty("ownerid")]
        public string OwnerId { get; set; }

        [JsonProperty("attachmentid")]
        public string AttachmentId { get; set; }

        [JsonProperty("objectid")]
        public string ObjectId { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("supportingsolutionid")]
        public Guid? SupportingSolutionId { get; set; }

        [JsonProperty("activitymimeattachmentidunique")]
        public Guid? ActivityMimeAttachmentIdUnique { get; set; }

        [JsonProperty("ismanaged")]
        public bool? IsManaged { get; set; }

        [JsonProperty("ismanagedname")]
        public string IsManagedName { get; set; }

        [JsonProperty("attachmentcontentid")]
        public string AttachmentContentId { get; set; }

        [JsonProperty("isfollowed")]
        public bool? IsFollowed { get; set; }

        [JsonProperty("isfollowedname")]
        public string IsFollowedName { get; set; }

        [JsonProperty("anonymouslink")]
        public string AnonymousLink { get; set; }

        [JsonProperty("activitysubject")]
        public string ActivitySubject { get; set; }

        [JsonProperty("owneridname")]
        public string OwnerIdName { get; set; }


    }
}

