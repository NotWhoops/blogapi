using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogapijlmv2.Models;
using blogapijlmv2.Properties.Services;
using Microsoft.AspNetCore.Mvc;

namespace blogapijlmv2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly BlogItemService _data;

        public BlogController(BlogItemService dataFromService)
        {
            _data = dataFromService;
        }

        //AddBlogItems
        [HttpPost("AddBlogItems")]

        public bool AddBlogItems(BlogItemModel newBlogItem)
        {
            return _data.AddBlogItems(newBlogItem);
        }

        //GetBlogItems
        [HttpGet("GetBlogItemz")]

        public IEnumerable<BlogItemModel> GetAllBlogItems()
        {
            return _data.GetAllBlogItems();
        }

        //GetBlogItemsByCategory
        [HttpGet("GetBlogItemsByCategory{category}")]

        public IEnumerable<BlogItemModel> GetItemsByCategory(string category)
        {
            return _data.GetBlogItemsByCategory(category);
        }

        //GetItemsByTag
        [HttpGet("GetItemsByTag{tag}")]

        public List<BlogItemModel> GetItemsByTag(string tag)
        {
            return _data.GetItemsByTag(tag);
        }

        //GetItemsByDate
        [HttpGet("GetItemsByDate/{date}")]

        public IEnumerable<BlogItemModel> GetItemsByDate(string date)
        {
            return _data.GetItemsByDate(date);
        }

        //UpdateBlogItems
        [HttpPut("blogUpdate")]

        public bool UpdateBlogItems(BlogItemModel blogUpdate)
        {
            return _data.UpdateBlogItems(blogUpdate);
        }

        //DeleteBlogItems
        [HttpPut("DeleteBlogItem/{BlogItemToDelete}")]

        public bool DeleteBlogitems(BlogItemModel BlogItemToDelete)
        {
            return _data.DeleteBlogItem(BlogItemToDelete);
        }

        //GetPublishedBlogItems
        [HttpGet("GetPublishedItems")]

        public IEnumerable<BlogItemModel> GetPublishedItems()
        {
            return _data.GetPublishedItems();
        }

    }
}