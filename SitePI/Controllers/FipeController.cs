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

        public IActionResult Veiculos(String id)
        {
            var v = new Veiculos();
            String url = "http://fipeapi.appspot.com/api/1/carros/veiculos/" + id + ".json";

            var ListaVeic = v.GetJsonData<Veiculos>(url);
            ViewData["IdMarca"] = id;

            return View(ListaVeic);
        }

        public IActionResult AnoModelo(String IdMarca, String id)
        {
            var a = new AnoModelo();
            String url = "http://fipeapi.appspot.com/api/1/carros/veiculo/" + IdMarca + "/" + id + ".json";
            var ListaAnoM = a.GetJsonData<AnoModelo>(url);

            ViewData["IdMarca"] = IdMarca;
            ViewData["IdAno"] = id;

            return View(ListaAnoM);
        }

        public IActionResult PrecoCorrente(String IdMarca, String IdAno, String id)
        {
            var p = new PrecoCorrente();
            String url = "http://fipeapi.appspot.com/api/1/carros/veiculo/" + IdMarca + "/" + IdAno + "/" + id + ".json";
            var ListaPrec = new List<PrecoCorrente>();
            ListaPrec.Add(p.GetCarPrice<PrecoCorrente>(url));

            return View(ListaPrec);
        }
    }
}