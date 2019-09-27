using DataAccessLayer.FactoryShoppingModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FactoryShopping.Models.FactoryShoppingModel
{
    public class OrderProductDetails
    {
        [Key]
        public int OrderProductId { get; set; }

        [ForeignKey("OrderDetail")]
        public int OrderId { get; set; }
        //public virtual OrderDetails orderDetail { get; set; }
        [ForeignKey("Product")]
        public int PId { get; set; }

        public virtual Product Products { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal MyProperty { get; set; }

        public int OrderedQuantity { get; set; }


    }
}
