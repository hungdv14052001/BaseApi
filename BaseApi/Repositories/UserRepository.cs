using AutoMapper;
using BaseApi.Common;
using BaseApi.Database;
using BaseApi.Models;
using BaseApi.Request;
using BaseApi.Respositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BaseApi.Repositories
{
    public class UserRepository : BaseRespository<User>
    {
        private IMapper _mapper;
        public UserRepository(ApiOption apiConfig, DatabaseContext databaseContext, IMapper mapper) : base(apiConfig, databaseContext)
        {
            this._mapper = mapper;
        }

        /// <summary>
        /// UserLogin function. That return User by user login request
        /// </summary>
        /// <param name="userLoginRequest"></param>
        /// <returns></returns>
        public User UserLogin(UserLoginRequest userLoginRequest)
        {
            try
            {
                var passwordByMD5 = Untill.CreateMD5(userLoginRequest.Password);
                return Model.Where(row => row.Username == userLoginRequest.Username && row.Password == passwordByMD5).FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
