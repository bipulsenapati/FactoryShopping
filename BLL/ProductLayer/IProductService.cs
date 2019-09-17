using DataAccessLayer.FactoryShoppingModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ProductLayer
{
   public interface IProductService
    {
        List<Product> getallproduct();
        Product getProductById(int id); // get by id

        bool saveProduct(Product newproduct); //post  

        bool deleteProductById(int id); //Delete user by id 

        bool updateProduct(Product newproduct); //put
    }
}
