using System;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ImageDescriptorVocabulary : SimpleVocabulary
    {
        public ImageDescriptorVocabulary()
        {
            VocabularyName = "Dynamics365 ImageDescriptor";
            KeyPrefix = "dynamics365.imagedescriptor";
            KeySeparator = ".";
            Grouping = EntityType.Unknown; // TODO: Set value

            this.AddGroup("ImageDescriptor", group =>
            {
                this.ImageDescriptorId = group.Add(new VocabularyKey("ImageDescriptorId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ImageDescriptorId")
                    .ModelProperty("imagedescriptorid", typeof(Guid)));

                this.ImageData = group.Add(new VocabularyKey("ImageData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("ImageData")
                    .ModelProperty("imagedata", typeof(string)));

                this.ImageURL = group.Add(new VocabularyKey("ImageURL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("ImageURL")
                    .ModelProperty("imageurl", typeof(string)));

                this.ImageTimestamp = group.Add(new VocabularyKey("ImageTimestamp", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ImageTimestamp")
                    .ModelProperty("imagetimestamp", typeof(int)));

                this.Size = group.Add(new VocabularyKey("Size", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("Size")
                    .ModelProperty("size", typeof(long)));

                this.FileType = group.Add(new VocabularyKey("FileType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("FileType")
                    .ModelProperty("filetype", typeof(string)));

                this.Title = group.Add(new VocabularyKey("Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(200))
                    .WithDescription(@"")
                    .WithDisplayName("Title")
                    .ModelProperty("title", typeof(string)));

                this.ObjectId = group.Add(new VocabularyKey("ObjectId", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ObjectId")
                    .ModelProperty("objectid", typeof(Guid)));

                this.ObjectTypeCode = group.Add(new VocabularyKey("ObjectTypeCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.CanEdit())
                    .WithDescription(@"")
                    .WithDisplayName("ObjectTypeCode")
                    .ModelProperty("objecttypecode", typeof(string)));

                this.FullImageData = group.Add(new VocabularyKey("FullImageData", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("FullImageData")
                    .ModelProperty("fullimagedata", typeof(string)));

                this.FullImageURL = group.Add(new VocabularyKey("FullImageURL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("FullImageURL")
                    .ModelProperty("fullimageurl", typeof(string)));

                this.ImagePixelWidth = group.Add(new VocabularyKey("ImagePixelWidth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("ImagePixelWidth")
                    .ModelProperty("imagepixelwidth", typeof(long)));

                this.ImagePixelHeight = group.Add(new VocabularyKey("ImagePixelHeight", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("ImagePixelHeight")
                    .ModelProperty("imagepixelheight", typeof(long)));

                this.ColorDepthBits = group.Add(new VocabularyKey("ColorDepthBits", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("ColorDepthBits")
                    .ModelProperty("colordepthbits", typeof(long)));

                this.ImageDescription = group.Add(new VocabularyKey("ImageDescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(512))
                    .WithDescription(@"")
                    .WithDisplayName("ImageDescription")
                    .ModelProperty("imagedescription", typeof(string)));

                this.ImageTags = group.Add(new VocabularyKey("ImageTags", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(512))
                    .WithDescription(@"")
                    .WithDisplayName("ImageTags")
                    .ModelProperty("imagetags", typeof(string)));

                this.FileSizeBytes = group.Add(new VocabularyKey("FileSizeBytes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable())
                    .WithDescription(@"")
                    .WithDisplayName("FileSizeBytes")
                    .ModelProperty("filesizebytes", typeof(long)));

                this.MimeType = group.Add(new VocabularyKey("MimeType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("MimeType")
                    .ModelProperty("mimetype", typeof(string)));

                this.FileName = group.Add(new VocabularyKey("FileName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("FileName")
                    .ModelProperty("filename", typeof(string)));

                this.FileLocation = group.Add(new VocabularyKey("FileLocation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)
                    .WithDataAnnotations(k => k.NotEditable(), k => k.MaxLength(256))
                    .WithDescription(@"")
                    .WithDisplayName("FileLocation")
                    .ModelProperty("filelocation", typeof(string)));


            });

            // Mappings
            //AddMapping(this.City,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AddressCity);
        }

        public VocabularyKey ImageDescriptorId { get; private set; }

        public VocabularyKey ImageData { get; private set; }

        public VocabularyKey ImageURL { get; private set; }

        public VocabularyKey ImageTimestamp { get; private set; }

        public VocabularyKey Size { get; private set; }

        public VocabularyKey FileType { get; private set; }

        public VocabularyKey Title { get; private set; }

        public VocabularyKey ObjectId { get; private set; }

        public VocabularyKey ObjectTypeCode { get; private set; }

        public VocabularyKey FullImageData { get; private set; }

        public VocabularyKey FullImageURL { get; private set; }

        public VocabularyKey ImagePixelWidth { get; private set; }

        public VocabularyKey ImagePixelHeight { get; private set; }

        public VocabularyKey ColorDepthBits { get; private set; }

        public VocabularyKey ImageDescription { get; private set; }

        public VocabularyKey ImageTags { get; private set; }

        public VocabularyKey FileSizeBytes { get; private set; }

        public VocabularyKey MimeType { get; private set; }

        public VocabularyKey FileName { get; private set; }

        public VocabularyKey FileLocation { get; private set; }


    }
}

