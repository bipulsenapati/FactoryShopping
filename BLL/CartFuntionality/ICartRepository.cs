using DataAccessLayer.FactoryShoppingModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.CartFuntionality
{
    public interface ICartRepository
    {
       bool AddToCart(Cart newCartItem);
    }
}
