using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Attachment : DynamicsModel
    {
        [JsonProperty("attachmentid")]
        public Guid? AttachmentId { get; set; }

        [JsonProperty("storagepointer")]
        public string StoragePointer { get; set; }

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

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("versionnumber")]
        public int? VersionNumber { get; set; }

        [JsonProperty("filepointer")]
        public string FilePointer { get; set; }


    }
}

