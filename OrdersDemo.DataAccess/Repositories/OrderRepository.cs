using OrdersDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataAccess.Repositories
{
    public class OrderRepository
    {
        public List<Order> GetList()
        {
            using (var db=new SalesDBContext())
            {
                return db.Orders.ToList();
            }
        }

        public Order GetByID(int id)
        {
            using (var db=new SalesDBContext())
            {
                return db.Orders.FirstOrDefault(o => o.ID == id);
            }
        }

        public bool Create(Order order)
        {
            using (var db =new SalesDBContext())
            {
                try
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Update(Order order)
        {
            using (var db = new SalesDBContext())
            {
                try
                {
                    var q = db.Orders.FirstOrDefault(O=>O.ID==order.ID);
                    if (q != null)
                    {
                        q.OrderDate = order.OrderDate;
                        q.TotalAmount = order.TotalAmount;
                        q.CustomerId = order.CustomerId;
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
                    var q = db.Orders.FirstOrDefault(x => x.ID == id);
                    if (q != null)
                    {
                        db.Orders.Remove(q);
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
