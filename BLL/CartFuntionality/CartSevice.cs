using DataAccessLayer.FactoryShoppingModel;
using DataContext;
using System;
using System.Linq;

namespace BLL.CartFuntionality
{
    public class CartSevice : ICartRepository
    {
        private readonly FactoryShoppingDataContext _cartcontext;
        public CartSevice(FactoryShoppingDataContext cartcontext)
        {
            _cartcontext = cartcontext;
        }
        public bool AddToCart(Cart newCartItem)
        {
            var cartItem = _cartcontext.cart.Where(x => x.PId == newCartItem.PId).FirstOrDefault();
            if (cartItem == null)
            {
                try
                {
                    _cartcontext.Add(newCartItem);
                    _cartcontext.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return true;
            }
            else
                return false;
        }

        //public bool deleteCartitem(int id)
        //{
          
        //}

        //public bool UpdateCart(Cart updateCart)
        //{
        //    try
        //    {
        //        var updatedcart = _cartcontext.Products.Where(p => p.PId == updateCart.PId).FirstOrDefault();
        //        updateCart.OrderQuantity = updateCart.OrderQuantity
        //        _cartcontext.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
         
        //}
    }
}

