using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.Repositories;
using Oceantecsa.Shared.DTOs;
using System.Threading.Tasks;
using Oceantecsa.Shared.Uniteofwork;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.IdentityServices
{
    public class AuthService : IAuthService
    {

        private readonly IConfiguration _configuration;
        private readonly IUsersService _usersService;
        private readonly IMapper _mapper;


        private readonly IUsersRepository _usersRepository;

        public AuthService(IConfiguration configuration, IUsersService usersService, IUsersRepository usersRepository, IMapper mapper)
        {
            _configuration = configuration;
            _usersService = usersService;
            _usersRepository = usersRepository;
            _mapper = mapper;

        }
        private async Task<TokenResponseDTO> GenerateToken(UserInfoDTO user)
        {



            var claims = new[]
            {
                new Claim("preferred_username", user.Username),
                new Claim("password", string.Empty),
                new Claim("userid", user.Userid.ToString()),
                new Claim("UserInfo", JsonConvert.SerializeObject(user)),
            };
            SymmetricSecurityKey signatureKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWTSettings:JwtSecretKey"]));
            SigningCredentials credentials = new SigningCredentials(signatureKey, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor accessTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = credentials,
                Expires = DateTime.Now.AddHours(int.Parse(_configuration["JWTSettings:Expires"]))

            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken accessToken = tokenHandler.CreateToken(accessTokenDescriptor);

            var encodedAccessToken = "Bearer " + tokenHandler.WriteToken(accessToken);

            return new TokenResponseDTO
            {
                AccessToken = encodedAccessToken,
            };
        }

        public async Task<(bool, string)> Login(LoginDto loginDto)
        {
            string EncryptPassword = _usersService.EncryptPassword(loginDto.UserName, loginDto.Password);
            var user = _usersRepository.Get(a => a.Username.ToLower() == loginDto.UserName.TrimEnd().ToLower() && a.Password == EncryptPassword);
            if (user == null)
                return (false, "");
            var Token = await GenerateToken(_mapper.Map<UserInfoDTO>(user));
            return (true, Token.AccessToken);
        }
    }
}
