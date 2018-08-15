using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SitePI.Models.FipeAPI;

namespace SitePI.Controllers
{
    public class FipeController : Controller
    {
        public IActionResult Marcas()
        {

            var m = new Marcas();
            var ListaMrc = m.GetJsonData<Marcas>("http://fipeapi.appspot.com/api/1/carros/marcas.json");
            return View(ListaMrc);
        }
    }
}