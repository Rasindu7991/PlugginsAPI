using PluginAPI.Interface;
using PluginAPI.Models;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing.Drawing2D;

namespace PluginAPI.Repositories
{
    //Repository class for Image Plugins

    public class ImagePluginRepo : IImagePlugin
    {
        public IEnumerable<string> GetImages(List<string> imageURLList)
        {
            //This method used to get the user selected images and store in a list
            List<string> imagesList = new List<string>();
            Images images1 = new Images();
            for (int i = 0; i < imageURLList.Count(); i++)
            {
                imagesList.Add(imageURLList[i]);
                images1.AddedImagesURL = imagesList;
            }
            return imagesList;
        }

        public IEnumerable<string> AddPlugins(List<string> plugins)
        {
            //This method used to get the user selected plugins and store in a list
            List<string> PluginsList = new List<string>();
            ImagePlugin imagePlugin = new ImagePlugin();
            for (int i = 0; i < plugins.Count(); i++)
            {
                PluginsList.Add(plugins[i]);
                imagePlugin.AddedPlugins = PluginsList;
            }
            return PluginsList;
        }


        public Image ChangeRadius(string imageURL, int radiusValue)
        {
            //This method used to change the radius of the use selected image with given size and returns the changed image
            var image = new Bitmap(System.Drawing.Image.FromFile(imageURL));
            Bitmap b = new Bitmap(radiusValue, radiusValue);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, radiusValue, radiusValue);
            g.Dispose();

            return (Image)b;
        }

        public Image ChangeSize(string imageURL, int sizeValue)
        {
            //This method used to change the size of the use selected image with given size and returns the changed image
            var image = new Bitmap(System.Drawing.Image.FromFile(imageURL));
            Bitmap b = new Bitmap(sizeValue, sizeValue);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, sizeValue, sizeValue);
            g.Dispose();

            return (Image)b;
        }


        public Image ApplyPlugins(string imageURL, List<string> plugins)
        {
            //This method used to Apply all the user selected plugins and returns the changed image
            Images images1 = new Images();
            Image im = null;
            for (int i = 0; i < plugins.Count(); i++)
            {
                //ApplyPlugins
                var image = new Bitmap(System.Drawing.Image.FromFile(imageURL));
                im = image;
            }
            return im;
        }

    }
}