using AutoMapper;
using BaseApi.Common;
using BaseApi.Database;
using BaseApi.Models;
using BaseApi.Respositories;

namespace BaseApi.Repositories
{
    public class BlogRepository : BaseRespository<Blog>
    {
        private IMapper _mapper;
        public BlogRepository(ApiOption apiConfig, DatabaseContext databaseContext, IMapper mapper) : base(apiConfig, databaseContext)
        {
            this._mapper = mapper;
        }
    }
}
