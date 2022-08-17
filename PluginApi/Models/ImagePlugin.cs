using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PluginAPI.Models
{
    //Model class for Plugins

    public class ImagePlugin
    {
        public int PluginId { get; set; }
        public string PluginName { get; set; }
        public List<string> AddedPlugins { get; set; }
        public String ImageURLToAddPlugins { get; set; }
        public String PluginsAddedImageURL { get; set; }


    }
}