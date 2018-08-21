using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SitePI.Data;
using SitePI.Models;
using SitePI.Models.CarServicesViewModels;

namespace SitePI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TestDB()
        {
            List<DbModel> ListCar = new List<DbModel>();
            ListCar = DbManager.ReadItem(DbManager.GetConn());
            return View(ListCar);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Services()
        {
            ViewData["Message"] = "Your services page.";

            return View();

        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
