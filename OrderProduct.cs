using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_ecommerce_db
{
    [Table("order_product")]
    internal class OrderProduct
    {
        [Key]
        [Column("order_product_id")]
        public int OrderProductQuantityId { get; set; }

        public int Quantity { get; set; }

        //relazione con Order
        [Column("order_id")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        //relazione con Product
        [Column("product_id")]
        public int ProductId { get; set; }
        public Product Product { get; set; }


        public OrderProduct(int orderId, int productId, int quantity)
        {
            Quantity = quantity;
        }
    }
}
