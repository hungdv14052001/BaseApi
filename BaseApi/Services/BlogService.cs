using AutoMapper;
using BaseApi.Common;
using BaseApi.Database;
using BaseApi.Models;
using BaseApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseApi.Services
{
    public class BlogService
    {
        private readonly BlogRepository _blogRepository;
        public BlogService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _blogRepository = new BlogRepository(apiOption, databaseContext, mapper);
        }

        /// <summary>
        /// Get blogs
        /// </summary>
        /// <returns></returns>
        public List<Blog> GetBlogs()
        {
            try
            {
                return _blogRepository.FindAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
