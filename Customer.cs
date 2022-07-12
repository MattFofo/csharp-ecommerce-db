using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_ecommerce_db
{
    [Table("customers")]
    internal class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        //relazione con orders
        public List<Order> Orders { get; set; }
    }
}
