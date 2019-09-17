using DataAccessLayer.FactoryShoppingModel;
using DataContext;

using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.ProductLayer
{
    public class ProductService : IProductService
    {
        private readonly FactoryShoppingDataContext _pcontext;
        FactoryShoppingDataContext db = new FactoryShoppingDataContext();
        public ProductService(FactoryShoppingDataContext pcontext)
        {
            _pcontext = pcontext;
        }

        public bool deleteProductById(int id)
        {
            if (checkvalid(id))
            {
                try
                {
                    var prod = _pcontext.Products.Find(id);
                    _pcontext.Products.Remove(prod);
                    _pcontext.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Product> getallproduct()
        {
            return _pcontext.Products.ToList();
        }


        public Product getProductById(int id)
        {
            return _pcontext.Products.Find(id);
        }

        public bool saveProduct(Product newproduct)
        {
            try
            {
                db.Products.Add(newproduct);
                db.SaveChanges();
                return true;
            }
            catch (NotImplementedException ex)
            {
                throw ex;
            }
            // return false;
        }

        public bool updateProduct(Product newproduct)
        {
            try
            {
                var updatedprod = db.Products.Where(p => p.PId == newproduct.PId).FirstOrDefault();
                updatedprod.Name = newproduct.Name;
                updatedprod.Price = newproduct.Price;
                updatedprod.Quantity = newproduct.Quantity;
                updatedprod.Description = newproduct.Description;
                updatedprod.Detail_Description = newproduct.Detail_Description;
                updatedprod.CategoryId = newproduct.CategoryId;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool checkvalid(int id)
        {
            var checkid = db.Products.Where(i => i.PId == id).FirstOrDefault();
            if (checkid == null)
                return false;
            else
                return true;
        }
    }
}
