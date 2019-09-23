using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.CartFuntionality;
using DataAccessLayer.FactoryShoppingModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository cartService;

        public CartController(ICartRepository _cartService)
        {
            cartService = _cartService;
        }
        // GET: api/Cart
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Cart/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Cart
        [HttpPost]
        public bool Post([FromBody] Cart value)
        {
            return cartService.AddToCart(value);
        }

        // PUT: api/Cart/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return cartService.deleteCartitem(id);
        }
    }
}
