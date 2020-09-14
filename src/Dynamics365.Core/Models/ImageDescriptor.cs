using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ImageDescriptor : DynamicsModel
    {
        [JsonProperty("imagedescriptorid")]
        public Guid? ImageDescriptorId { get; set; }

        [JsonProperty("imagedata")]
        public string ImageData { get; set; }

        [JsonProperty("imageurl")]
        public string ImageURL { get; set; }

        [JsonProperty("imagetimestamp")]
        public int? ImageTimestamp { get; set; }

        [JsonProperty("size")]
        public long? Size { get; set; }

        [JsonProperty("filetype")]
        public string FileType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("objectid")]
        public Guid? ObjectId { get; set; }

        [JsonProperty("objecttypecode")]
        public string ObjectTypeCode { get; set; }

        [JsonProperty("fullimagedata")]
        public string FullImageData { get; set; }

        [JsonProperty("fullimageurl")]
        public string FullImageURL { get; set; }

        [JsonProperty("imagepixelwidth")]
        public long? ImagePixelWidth { get; set; }

        [JsonProperty("imagepixelheight")]
        public long? ImagePixelHeight { get; set; }

        [JsonProperty("colordepthbits")]
        public long? ColorDepthBits { get; set; }

        [JsonProperty("imagedescription")]
        public string ImageDescription { get; set; }

        [JsonProperty("imagetags")]
        public string ImageTags { get; set; }

        [JsonProperty("filesizebytes")]
        public long? FileSizeBytes { get; set; }

        [JsonProperty("mimetype")]
        public string MimeType { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("filelocation")]
        public string FileLocation { get; set; }


    }
}

