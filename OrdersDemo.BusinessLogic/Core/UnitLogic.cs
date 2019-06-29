using OrdersDemo.DataAccess.Repositories;
using OrdersDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.BusinessLogic.Core
{
    public class UnitLogic
    {
        public List<Unit> GetList()
        {
            return new UnitRepository().GetList();
        }

    }
}
