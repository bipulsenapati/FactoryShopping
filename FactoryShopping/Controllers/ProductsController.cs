using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.FactoryShoppingModel;
using BLL.ProductLayer;

namespace FactoryShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService ProductService;

        public ProductsController(IProductService _ProductService)
        {
            ProductService = _ProductService;
        }

        // GET: api/Products
        [HttpGet]
        public IList<Product> Getproduct()
        {
            return  ProductService.getallproduct();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
           return ProductService.getProductById(id);
            
        }

        // PUT: api/Products/5
        [HttpPut]
        public bool PutProduct(Product product)
        {
            return ProductService.updateProduct(product);
        }

      

        // POST: api/Products
        [HttpPost]
        public bool PostProduct(Product product)
        {
             return ProductService.saveProduct(product);
            //return CreatedAtAction("GetProduct", new { id = product.PId }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public bool DeleteProduct(int id)
        {
            return ProductService.deleteProductById(id);
        }

    }
}
