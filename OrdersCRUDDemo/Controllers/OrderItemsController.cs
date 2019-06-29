using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OrdersDemo.BusinessLogic.Core;
using OrdersDemo.DataMapping.Entities;

namespace OrdersCRUDDemo.Controllers
{
    public class OrderItemsController : Controller
    {

        public ActionResult Index(int orderId)
        {
            var orderItems = new OrderItemLogic().GetListByOrderId(orderId);
            ViewBag.OrderId = orderId;
            return View(orderItems);
        }

        

        public ActionResult Create(int orderId)
        {
            ViewBag.UnitId = new SelectList(new UnitLogic().GetList(), "ID", "Name","--Select Unit--");
            return View(new OrderItem {OrderId=orderId});
        }

        
        [HttpPost]
        public ActionResult Create(OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                new OrderItemLogic().Create(orderItem);
                return RedirectToAction("Index", new { orderId = orderItem.OrderId });
            }

            ViewBag.UnitId = new SelectList(new UnitLogic().GetList(), "ID", "Name", orderItem.UnitId);
            return View(orderItem);
        }

        public ActionResult Edit(int id,int orderId)
        {
            OrderItem orderItem = new OrderItemLogic().GetById(id);
            orderItem.OrderId = orderId;
            if (orderItem == null)
            {
                return View();
            }
            ViewBag.UnitId = new SelectList(new UnitLogic().GetList(), "ID", "Name", orderItem.UnitId);
            return View(orderItem);
        }

        
        [HttpPost]
        public ActionResult Edit(OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                new OrderItemLogic().Update(orderItem);
                return RedirectToAction("Index",new { orderId= orderItem.OrderId});
            }
            ViewBag.UnitId = new SelectList(new UnitLogic().GetList(), "ID", "Name", orderItem.UnitId);
            return View(orderItem);
        }

        public ActionResult Delete(int id,int orderID)
        {
            new OrderItemLogic().Delete(id);
            return RedirectToAction("Index", new { orderId = orderID });

        }



    }
}
