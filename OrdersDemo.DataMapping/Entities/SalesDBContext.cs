using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataMapping.Entities
{
    public class SalesDBContext:DbContext
    {
        public SalesDBContext() : base("SalesDBContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        
    }
}
