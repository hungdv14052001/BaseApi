using AutoMapper;
using BaseApi.Common;
using BaseApi.Controllers;
using BaseApi.Database;
using BaseApi.Dto;
using BaseApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace BaseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _blogService;
        public BlogController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _blogService = new BlogService(apiConfig, databaseContext, mapper);
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetBlogs")]
        public MessageData GetBlogs()
        {
            try
            {
                var res = _blogService.GetBlogs();
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
