using DataAccessLayer.FactoryShoppingModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryShopping.Domain.Order
{
    public interface IAddressRepository
    {
        bool saveAddress(Address newAddress); //post  
    }
}
