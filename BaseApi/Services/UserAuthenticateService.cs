using AutoMapper;
using AutoMapper.Configuration;
using BaseApi.Common;
using BaseApi.Database;
using BaseApi.Models;
using BaseApi.Repositories;
using BaseApi.Request;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace BaseApi.Services
{
    public class UserAuthenticateService
    {
        private readonly UserRepository _userRepository;
        private readonly ApiOption _apiOption;
        public UserAuthenticateService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _userRepository = new UserRepository(apiOption, databaseContext, mapper);
            _apiOption = apiOption;
        }

        /// <summary>
        /// User login
        /// </summary>
        /// <param name="userLoginRequest"></param>
        /// <returns></returns>
        public object UserLogin(UserLoginRequest userLoginRequest)
        {
            try
            {
                var user = _userRepository.UserLogin(userLoginRequest);
                if(user == null)
                {
                    throw new Exception("Username or Password incorrect");
                }
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_apiOption.Secret));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
                var claimList = new[]
                {
                new Claim(ClaimTypes.Role, user.Role),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.UserData, user.Username),
                new Claim(ClaimTypes.Sid, user.Id.ToString()),
            };
                var token = new JwtSecurityToken(
                    issuer: _apiOption.ValidIssuer,
                    audience: _apiOption.ValidAudience,
                    expires: DateTime.Now.AddDays(1),
                    claims: claimList,
                    signingCredentials: credentials
                    );
                var tokenByString = new JwtSecurityTokenHandler().WriteToken(token);
                return new  { 
                    token = tokenByString,
                    role = user.Role,
                    user = user,
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
