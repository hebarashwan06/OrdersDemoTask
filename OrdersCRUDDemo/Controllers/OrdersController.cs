using System.Web.Mvc;
using OrdersDemo.BusinessLogic.Core;
using OrdersDemo.DataMapping.Entities;

namespace OrdersCRUDDemo.Controllers
{
    public class OrdersController : Controller
    {
        [Authorize(Roles ="Admin")]
        public ActionResult Index()
        {
            var model = new OrderLogic().GetList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(new CustomerLogic().GetList(), "ID", "Name");
            return View();
        }


        [HttpPost]
        public ActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                new OrderLogic().Create(order);
                return RedirectToAction("Index");
            }
            ViewBag.CustomerId = new SelectList(new CustomerLogic().GetList(), "ID", "Name");
            return View(order);
        }

        public ActionResult Edit(int id)
        {
            Order order = new OrderLogic().GetByID(id);
            ViewBag.CustomerId = new SelectList(new CustomerLogic().GetList(), "ID", "Name",order.CustomerId);

            if (order != null)
            {
                return View(order);
            }
            return View();
        }


        [HttpPost]
        public ActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                new OrderLogic().Update(order);
                return RedirectToAction("Index");
            }
            return View(order);
        }

        public ActionResult Delete(int id)
        {
            new OrderLogic().Delete(id);
            return RedirectToAction("Index");
        }
    }
}
