using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.FactoryShoppingModel
{
    public class Product
    {
        [Key]
        public int PId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public string Detail_Description { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Categories { get; set; }
    }
}
