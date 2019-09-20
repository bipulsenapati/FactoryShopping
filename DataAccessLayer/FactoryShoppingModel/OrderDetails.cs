using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.FactoryShoppingModel
{
    public class OrderDetails
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }

        public virtual Cart cart { get; set; }

        public string PaymentMode { get; set; }

        public DateTime orderDate { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public virtual Address address { get; set; }
    }
}
