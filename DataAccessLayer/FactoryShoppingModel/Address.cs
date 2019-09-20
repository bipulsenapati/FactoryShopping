using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.FactoryShoppingModel
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string AdName { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string AdMobile { get; set; }
        public string AlternetAdMobile { get; set; }
        [ForeignKey("AddressType")]
        public string AddressTypeID { get; set; } //Address type
        public virtual AddressType addressType { get; set; }
    }
}
