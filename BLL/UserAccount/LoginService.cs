using DataAccessLayer.AccessModel;
using DataAccessLayer.FactoryShoppingModel;
using DataContext;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

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
                    if (chkuser.Password != valid.Password)
                        return 0; //invalid password
                    else
                        return valid.RoleId; //user
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
                return 0;
        }

        public int getUserId(Login val)
        {
            var udata = (from user in db.Users
                         where user.Email == val.Email
                         select user.UserId).FirstOrDefault();
            return udata;
        }

    }
}
