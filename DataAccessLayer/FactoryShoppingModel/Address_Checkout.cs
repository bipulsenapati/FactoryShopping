using DataAccessLayer.FactoryShoppingModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FactoryShopping.Models.FactoryShoppingModel
{
    public class Address_Checkout
    {
        [Key]
        public int AddressId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public string AdName { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public int State { get; set; }
        public int AdMobile { get; set; }
        
        [ForeignKey("AddressType")]
        public string AddressTypeID { get; set; } //Address type
        public virtual AddressType addressType { get; set; }
    }
}
