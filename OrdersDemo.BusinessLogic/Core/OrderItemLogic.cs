using OrdersDemo.DataAccess.Repositories;
using OrdersDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.BusinessLogic.Core
{
    public class OrderItemLogic
    {
        public List<OrderItem> GetListByOrderId(int orderId)
        {
            return new OrderItemRepository().GetListByOrderId(orderId);
        }

        public OrderItem GetById(int id)
        {
            return new OrderItemRepository().GetById(id);
        }

        public bool Create(OrderItem orderItem)
        {
            return new OrderItemRepository().Create(orderItem);
        }

        public bool Update(OrderItem orderItem)
        {
            return new OrderItemRepository().Update(orderItem);
        }

        public bool Delete(int id)
        {
            return new OrderItemRepository().Delete(id);
        }

    }
}
