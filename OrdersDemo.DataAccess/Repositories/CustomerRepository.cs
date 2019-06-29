using OrdersDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataAccess.Repositories
{
    public class CustomerRepository
    {
        public List<Customer> GetList()
        {
            using (var db = new SalesDBContext())
            {
                return db.Customers.ToList();
            }
        }
    }
}
