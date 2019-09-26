using DataAccessLayer.FactoryShoppingModel;
using DataContext;
using System;

namespace FactoryShopping.Domain.Order
{
    public class AddressService : IAddressRepository
    {
        private readonly FactoryShoppingDataContext _acontext;

        public AddressService(FactoryShoppingDataContext acontext)
        {
            _acontext = acontext;
        }
        public bool saveAddress(Address newAddress)
        {
            try
            {
                _acontext.address.Add(newAddress);
                _acontext.SaveChanges();
                return true;
            }
            catch (NotImplementedException ex)
            {
                throw ex;
            }
            // return false;
        }
    }
}
