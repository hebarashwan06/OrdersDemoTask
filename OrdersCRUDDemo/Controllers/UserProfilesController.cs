using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OrdersDemo.BusinessLogic.Core;
using OrdersDemo.DataMapping.Entities;
using OrdersDemo.DataMapping.Services;

namespace OrdersCRUDDemo.Controllers
{
    [Authorize(Roles = "Admin")]

    public class UserProfilesController : Controller
    {

        public ActionResult Index()
        {
            var model = new UserProfileLogic().GetList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                Membership.CreateUser(userProfile.UserName,userProfile.Password,userProfile.Email);
                Roles.AddUserToRole(userProfile.UserName, "Admin");
                new UserProfileLogic().Create(userProfile);
                return RedirectToAction("Index");
            }

            return View(userProfile);
        }

        public ActionResult Edit(int id)
        {
            EditUserProfile editUserProfile = new UserProfileLogic().GetEditUserProfileById(id);
            if (editUserProfile != null)
            {
                return View(editUserProfile);
            }
            return View();
        }

        
        [HttpPost]
        public ActionResult Edit(EditUserProfile editUserProfile)
        {
            if (ModelState.IsValid)
            {
                MembershipUser membershipUser = Membership.GetUser(editUserProfile.UserName);
                membershipUser.Email = editUserProfile.Email;
                Membership.UpdateUser(membershipUser);
                new UserProfileLogic().Update(editUserProfile);
                return RedirectToAction("Index");
            }
            return View(editUserProfile);
        }

        public ActionResult Delete(int id)
        {
            UserProfile userProfile = new UserProfileLogic().GetById(id);
            if (userProfile != null)
            {
                Membership.DeleteUser(userProfile.UserName);
                new UserProfileLogic().Delete(id);
                return RedirectToAction("Index");
            }
            return View(userProfile);
        }

        
    }
}
