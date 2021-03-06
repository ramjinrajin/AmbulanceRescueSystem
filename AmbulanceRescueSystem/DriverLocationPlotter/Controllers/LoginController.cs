﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DriverLocationPlotter.Controllers
{
    public class LoginController : Controller
    {
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

       [HttpPost]
       public ActionResult Index(FormCollection frmCollection)
       {
           if (FormsAuthentication.Authenticate(frmCollection["UserName"].ToString(),frmCollection["Password"].ToString()))
           {
               FormsAuthentication.RedirectFromLoginPage(frmCollection["UserName"].ToString(), false);
               string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
               return RedirectToAction("ShowRoute", "Home");
           }
           return View();
       }

       [Authorize]
       public ActionResult logout()
       {
           Session.Clear();
           FormsAuthentication.SignOut();
           return RedirectToAction("Index", "Login");


       }
    }
}