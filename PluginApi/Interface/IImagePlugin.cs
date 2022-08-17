using PluginAPI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginAPI.Interface
{
    //Interface of Image Plugins API Operartions

    public interface IImagePlugin
    {
        IEnumerable<string> GetImages(List<string> images);

        IEnumerable<string> AddPlugins(List<string> plugins);

        Image ChangeRadius(string imageURL, int radiusValue);

        Image ChangeSize(string imageURL, int sizeValue);

        Image ApplyPlugins(string imageURL, List<string> plugins);

    }
}
