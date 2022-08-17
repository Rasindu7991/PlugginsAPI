using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PluginAPI.Models
{
    //Model class for Images
    public class Images
    {
        public int ImageId { get; set; }

        public String ImageURL { get; set; }

        public List<String> AddedImagesURL { get; set; }

        public string  PluginsAddedImageURL { get; set; }

        public int RadiusValue { get; set; }

        public int SizeValue { get; set; }

    }
}