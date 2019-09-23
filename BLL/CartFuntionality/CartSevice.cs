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
            var valid = _cartcontext.cart.Where(u => u.PId == newCartItem.PId && u.UserId == newCartItem.UserId).FirstOrDefault();
            
            if (valid == null)
            {
                try
                {
                    _cartcontext.Add(newCartItem);
                    _cartcontext.SaveChanges();
                    var cartitem = _cartcontext.cart.Where(c => c.CartId == newCartItem.CartId).FirstOrDefault();
                    var prod = _cartcontext.Products.Where(u => u.PId == newCartItem.PId).FirstOrDefault();
                    var data = from prod_img in _cartcontext.Products
                               join cart_val in _cartcontext.cart
                               on prod_img.PId equals cart_val.PId
                               where cart_val.UserId == cartitem.UserId
                               select new
                               {
                                   productName=prod_img.Name,
                                   productImage=prod_img.ImagePath
                               };
                    
                    cartitem.Price = prod.Price;
                    cartitem.Amount = cartitem.Price * cartitem.OrderQuantity;                    
                    _cartcontext.SaveChanges();
                }
                catch (NullReferenceException ex)
                {
                    throw ex;
                }
                return true;
            }
            else if(valid != null)
            {
                valid.OrderQuantity += newCartItem.OrderQuantity;
                valid.Amount = valid.Amount + (newCartItem.OrderQuantity * valid.Price);
                _cartcontext.SaveChanges();
                return true;
            }
            else
                return false;
        }
        public bool updateQty(Cart updateCart)
        {
            var valid = _cartcontext.cart.Where(u => u.PId == updateCart.PId && u.UserId == updateCart.UserId).FirstOrDefault();
            if (valid!=null)
            {
                valid.OrderQuantity += updateCart.OrderQuantity;
                valid.Amount = valid.Amount - (updateCart.OrderQuantity * valid.Price);
                _cartcontext.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool deleteCartitem(int uid,int pid)
        {
            if (checkvaliduser(uid))
            {
                try
                {
                    var prod = _cartcontext.Products.Find(pid);
                    _cartcontext.Products.Remove(prod);
                    _cartcontext.SaveChanges();
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
        public bool checkvaliduser(int id)
        {
            var checkid = _cartcontext.Users.Where(i => i.UserId == id).FirstOrDefault();
            if (checkid == null)
                return false;
            else
                return true;
        }

        
    }
}

