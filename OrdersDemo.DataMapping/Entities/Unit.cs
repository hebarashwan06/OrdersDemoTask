using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataMapping.Entities
{
    public class Unit
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
