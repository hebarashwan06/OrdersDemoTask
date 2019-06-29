using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataMapping.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage ="Please Enter Order Total Amount")]
        public double TotalAmount { get; set; }

        public virtual int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
