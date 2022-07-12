using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_ecommerce_db
{
    [Table("orders")]
    internal class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Amount { get; set; }
        public string Status { get; set; }

        //relazione con Customer
        [Column("customer_id")]
        public int CustomerId { get; set; }
        Customer Customer { get; set; }

        //relazione con Product
        public List<Product> Products { get; set; }

        //relazione con OrderProductQuantities
        public List<OrderProductQuantity> OrderProductQuantities { get; set; }
    }
}
