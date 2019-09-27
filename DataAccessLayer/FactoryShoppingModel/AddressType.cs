using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.FactoryShoppingModel
{
    public class AddressType
    {
        [Key]
        public string AddressTypeID { get; set; }
        public string Type { get; set; }
    }
}
