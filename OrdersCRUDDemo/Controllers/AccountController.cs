using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security;
using System.Web.Security;
using OrdersDemo.BusinessLogic.ViewModels;

namespace OrdersCRUDDemo.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(loginModel.UserName, loginModel.Password))
                {
                    FormsAuthentication.SetAuthCookie(loginModel.UserName, false);
                    if (Roles.IsUserInRole(loginModel.UserName, "Admin"))
                    {
                        return RedirectToAction("Index", "Orders");
                    }
                }
            }
            return View();
            
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                Membership.CreateUser(registerModel.UserName, registerModel.Password);
                Roles.AddUserToRole(registerModel.UserName, "Admin");
                return RedirectToAction("Login");
            }
            return View();
        }
    }
}