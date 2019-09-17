using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using DataAccessLayer.AccessModel;
using DataAccessLayer.FactoryShoppingModel;
using DataContext;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BLL.UserAccount
{
    public class LoginService : ILoginRepository
    {
        FactoryShoppingDataContext db = new FactoryShoppingDataContext();
        private IConfiguration _config;
        public LoginService(IConfiguration config)
        {
            _config = config;
        }

        public int checkUser(Login chkuser)
        {
                                          
            var valid = db.Users.Where(x => x.Email == chkuser.Email).FirstOrDefault();
            if (valid != null)
            {
                try
                {
                    if (valid.RoleId == 2)//user
                    {
                        if (chkuser.Password != valid.Password)
                            return 0; //invalid password
                        else
                            return 2; //user
                    }
                    else
                    {
                        if (chkuser.Password != valid.Password)
                            return 0; //invalid password
                        else
                            return 1;//admin
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
             
            }
            else
                return 0;
        }



        private string GenerateJSONWebToken(User userInfo)
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

    }
}
