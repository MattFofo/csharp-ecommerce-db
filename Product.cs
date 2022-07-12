using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace csharp_ecommerce_db
{
    [Table("products")]
    internal class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        ////relazione con Order
        //public List<Order> Orders { get; set; }

        //relazione con OrderProductQuantities
        public List<OrderProductQuantity> OrderProductQuantities { get; set; }
    }
}
