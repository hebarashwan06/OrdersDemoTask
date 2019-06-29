using OrdersDemo.DataAccess.Repositories;
using OrdersDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;


namespace OrdersDemo.BusinessLogic.Core
{
    public class OrderLogic
    {
        public List<Order> GetList()
        {
            return new OrderRepository().GetList();
        }

        public Order GetByID(int id)
        {
            return new OrderRepository().GetByID(id);
        }

        public bool Create(Order order)
        {
            return new OrderRepository().Create(order);
        }

        public bool Update(Order order)
        {
            return new OrderRepository().Update(order);
        }

        public bool Delete(int id)
        {
            return new OrderRepository().Delete(id);
        }
        
    }
}
