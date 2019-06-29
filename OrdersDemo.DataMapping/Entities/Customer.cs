using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrdersDemo.DataMapping.Entities
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
