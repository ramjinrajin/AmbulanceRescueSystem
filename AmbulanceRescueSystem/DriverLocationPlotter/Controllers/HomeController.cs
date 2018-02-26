using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using DriverLocationPlotter.Models;

namespace DriverLocationPlotter.Controllers
{
    public class HomeController : Controller
    {

        [Authorize]
        public ActionResult Index()
        {
            return RedirectToAction("ShowRoute");

        }


        [Authorize]
        public ActionResult ShowRoute()
        {
            GetAccidentLocation objLocation = new GetAccidentLocation();
            string Location = objLocation.Get();
            if (Location=="NIL")
            {
                return View("Index");
            }
            else
            {
                TempData["Location"] = Location;
                return RedirectToAction("Map");
            }
            
        }


        [Authorize]
        public ActionResult Map()
        {


            //GetAccidentLocation objLocation = new GetAccidentLocation();
            //string Location = objLocation.Get();

            if (TempData["Location"] == "NIL")
            {
                return RedirectToAction("ShowRoute");
            }
            else
            {
                try
                {
                    ViewBag.Loc = TempData["Location"].ToString();
                    return View();
                }
                catch
                {
                    return RedirectToAction("ShowRoute");
                }
               
            }
        
          
        }

        [Authorize]
        public string ReportAccident(string AccLoc)
        {

            GetAccidentLocation objLocation = new GetAccidentLocation();
            string Response = objLocation.ReportAccident(AccLoc);
            return Response;
        }
    }
}