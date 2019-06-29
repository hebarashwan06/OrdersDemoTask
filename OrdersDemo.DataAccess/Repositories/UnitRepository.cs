using OrdersDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataAccess.Repositories
{
    public class UnitRepository
    {
        public List<Unit> GetList()
        {
            using (var db = new SalesDBContext())
            {
                return db.Units.ToList();
            }
        }
    }
}
