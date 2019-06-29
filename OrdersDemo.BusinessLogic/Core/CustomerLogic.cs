using OrdersDemo.DataAccess.Repositories;
using OrdersDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.BusinessLogic.Core
{
    public class CustomerLogic
    {
        public List<Customer> GetList()
        {
            return new CustomerRepository().GetList();
        }
    }
}
