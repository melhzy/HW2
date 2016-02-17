using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using DataAccessLayer;
using ModelsLayer;

namespace SmartReporting_HW2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Project description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Company's headquarters.";

            var ReportList = BusinessInformation.GetReportData();

            return View(ReportList);
        }
    }
}