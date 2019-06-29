using OrdersDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataAccess.Repositories
{
    public class OrderItemRepository
    {
        public List<OrderItem> GetListByOrderId(int orderId)
        {
            using (var db=new SalesDBContext())
            {
                return db.OrderItems.Where(i => i.OrderId == orderId).ToList();
            }
        }

        public OrderItem GetById(int id)
        {
            using (var db = new SalesDBContext())
            {
                return db.OrderItems.FirstOrDefault(i=>i.ID==id);
            }
        }

        public bool Create(OrderItem orderItem)
        {
            using (var db = new SalesDBContext())
            {
                try
                {
                    db.OrderItems.Add(orderItem);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Update(OrderItem orderItem)
        {
            using (var db = new SalesDBContext())
            {
                try
                {
                    var q = db.OrderItems.FirstOrDefault(O => O.ID == orderItem.ID);
                    if (q != null)
                    {
                        q.Amount =orderItem.Amount;
                        q.UnitId = orderItem.UnitId;
                        db.SaveChanges();
                    }
                }
                catch
                {
                    return false;
                }

                return true;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new SalesDBContext())
            {
                try
                {
                    var q = db.OrderItems.FirstOrDefault(x => x.ID == id);
                    if (q != null)
                    {
                        db.OrderItems.Remove(q);
                        db.SaveChanges();
                    }

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }


    }
}
