using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BLL.UserAccount;
using DataAccessLayer.AccessModel;
using DataAccessLayer.FactoryShoppingModel;
using Microsoft.AspNetCore.Authorization;
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

        private string GenerateJSONWebToken(int role)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
                new Claim(ClaimTypes.Role,role.ToString())
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        // POST: api/Login
        [HttpPost]
        public IActionResult Post([FromBody] Login value)
        {
            var roleId = loginService.checkUser(value);
            var tokenstring = GenerateJSONWebToken(roleId);
            return Ok(new { token = tokenstring, role = roleId});
            //if (roleId == 1) //admin
            //{
            //    var tokenstring = GenerateJSONWebToken(roleId);
            //    return Ok(new { token = tokenstring });
            //}

            //else if (loginService.checkUser(value) == 2) //user
            //{
            //    var tokenstring = GenerateJSONWebToken();
            //    return Ok(new { token = tokenstring});
            //}
            //return Ok(new { userCode = 2 });
        }

        [HttpGet("api/check")]
        [Authorize(Roles ="1")]
        public string CheckAuthorization()
        {
            return "Successfully Authenticated";
        }

    

    }
}
