using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataMapping.Entities
{
    public class OrderItem
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Please Enter OrderItem Amount")]
        public double Amount { get; set; }

        public virtual int? OrderId { get; set; }
        public virtual Order Order { get; set; }

        public virtual int? UnitId { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
