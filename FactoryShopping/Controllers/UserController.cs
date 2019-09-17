using BLL.UserAccount;
using DataAccessLayer.FactoryShoppingModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FactoryShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository userService;
        public UserController(IUserRepository _userService)
        {
            userService = _userService;
        }
        // Post: /api/User/saveUser
        [HttpPost("saveUser")]
        public bool saveUser(User user)
        {
            return userService.saveUser(user);
        }


        // GET: api/User
        [HttpGet]
        public List<User> GetUsers()
        {
            return userService.getAllUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<User> Get(int id)
        {
            return userService.getUserById(id);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public bool Put(int id, User value)
        {
            return userService.updateUser(id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return userService.deleteuserbyId(id);
        }
    }
}
