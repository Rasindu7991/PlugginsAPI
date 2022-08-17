using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PluginAPI.Interface;
using PluginAPI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace PluginAPI.Controllers
{
    [Route("api/ImagePlugin")]
    [ApiController]
    public class ImagePluginController : ControllerBase
    {
        private readonly IImagePlugin _imagePlugin; 

        public ImagePluginController(IImagePlugin imagePluginreepo)
        {
            _imagePlugin = imagePluginreepo;
        }

        [HttpGet]
        [Route("getImages")]
        public IEnumerable<String> GetImages([FromBody] List<string> imageurls)
        {
            //This controller will use to get the user selected images

            List<string> attachedImages = new List<string>();
            try
            {
                foreach (var item in imageurls)
                {
                    attachedImages.Add(item);
                }

            }
            catch (Exception ex)
            {
                return (IEnumerable<string>)BadRequest(ex.Message);
            }
            return _imagePlugin.GetImages(attachedImages);
        }


        [HttpGet]
        [Route("addPlugins")]
        public IEnumerable<String> AddPlugins([FromBody] List<string> plugins)
        {
            //This controller will use to get the user selected plugins

            List<string> addedPlugins = new List<string>();
            try
            {
                foreach (var item in plugins)
                {
                    addedPlugins.Add(item);
                }

            }
            catch (Exception ex)
            {
                return (IEnumerable<string>)BadRequest(ex.Message);
            }
            return _imagePlugin.AddPlugins(addedPlugins);
        }

        [HttpGet]
        [Route("changeSize")]
        public IActionResult ChangeSize([FromBody] Images data)
        {
            try
            {
                //This controller will change the size of the given image and return the updated image
                //return (IActionResult)_imagePlugin.ChangeSize(data.ImageURL, data.SizeValue);
                return Ok($"data = {data.ImageURL}, size = {data.SizeValue}, updatedImage={data.PluginsAddedImageURL}");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("changeRadius")]
        public IActionResult ChangeRadius(Images data)
        {
            try
            {
                //This controller will change the radius of the given image and return the updated image
                //return (IActionResult)_imagePlugin.ChangeRadius(data.ImageURL, data.RadiusValue);
                return Ok($"data = {data.ImageURL}, size = {data.RadiusValue}, updatedImage={data.PluginsAddedImageURL}");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("applyPlugins")]
        public IActionResult ApplyPlugins([FromBody] ImagePlugin data)
        {
            try
            {
                //This method will apply plugins to the given image and return the updated image
                //return (IActionResult)_imagePlugin.ApplyPlugins(data.ImageURLToAddPlugins, data.AddedPlugins);
                return Ok($"data = {data.ImageURLToAddPlugins}, updatedImage={data.PluginsAddedImageURL}");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}