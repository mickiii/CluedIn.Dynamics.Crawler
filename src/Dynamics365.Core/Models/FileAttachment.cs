using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class FileAttachment : DynamicsModel
    {
        [JsonProperty("fileattachmentid")]
        public Guid? FileAttachmentId { get; set; }

        [JsonProperty("filepointer")]
        public string FilePointer { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("filesize")]
        public long? FileSize { get; set; }

        [JsonProperty("mimetype")]
        public string MimeType { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("storagepointer")]
        public string StoragePointer { get; set; }

        [JsonProperty("objectid")]
        public string ObjectId { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("objecttypecodename")]
        public string ObjectTypeCodeName { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("createdon")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("objectidtypecode")]
        public string ObjectIdTypeCode { get; set; }

        [JsonProperty("regardingfieldname")]
        public string RegardingFieldName { get; set; }

        [JsonProperty("filesizeinbytes")]
        public int? FileSizeInBytes { get; set; }


    }
}

