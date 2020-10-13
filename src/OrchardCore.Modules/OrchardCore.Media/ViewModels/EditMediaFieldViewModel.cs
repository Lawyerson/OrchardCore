using System;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.Media.Fields;
using SixLabors.ImageSharp;

namespace OrchardCore.Media.ViewModels
{
    public class EditMediaFieldViewModel
    {
        // A Json serialized array of media paths
        public string Paths { get; set; }

        public MediaField Field { get; set; }
        public ContentPart Part { get; set; }
        public ContentPartFieldDefinition PartFieldDefinition { get; set; }

        // This will be used by the uploader of an attached media field
        public string TempUploadFolder { get; set; }

        // Media Text is an option that maybe applied to a media field through settings.
        public bool AllowMediaText { get; set; }
        public string MediaTexts { get; set; }

        // Center cropping dimensions are an option that maybe applied to a media field through settings.
        public bool AllowCenterCropping { get; set; }
        public float[][] Centers { get; set; }
    }

    public class EditMediaFieldItemInfo
    {
        public string Path { get; set; }

        // It will be true if the media item is a new upload from a attached media field.
        public bool IsNew { get; set; }

        // It will be true if the media item has been marked for deletion using a attached media field.
        public bool IsRemoved { get; set; }

        // Alt text is an option that maybe applied to a media field through settings.
        public string MediaText { get; set; } = String.Empty;
        public float?[] Center { get; set; } = Array.Empty<float?>();
    }
}
