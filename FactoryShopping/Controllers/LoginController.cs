﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.UserAccount;
using DataAccessLayer.AccessModel;
using DataAccessLayer.FactoryShoppingModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace FactoryShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository loginService;
        private IConfiguration _config;
        public LoginController(ILoginRepository _loginService, IConfiguration config)
        {
            loginService = _loginService;
            _config = config;
        }

        private string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        // POST: api/Login
        [HttpPost]
        public IActionResult Post([FromBody] Login value)
        {
           if(loginService.checkUser(value) ==1) //admin
            {
                var tokenstring = GenerateJSONWebToken();
                return Ok(new { token= "tokenstring", userCode=1 });
            }

            else if (loginService.checkUser(value) == 2) //user
            {
                var tokenstring = GenerateJSONWebToken();
                return Ok(new { token = "tokenstring", userCode = 2 });
            }
            return Ok(new { userCode = 2 });
        }

    

    }
}
