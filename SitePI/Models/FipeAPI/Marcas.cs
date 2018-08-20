using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SitePI.Models.FipeAPI
{
    public class Marcas : FipeApi
    {
        [Display(Name = "Chave")]
        public string key { get; set; }

        [Display(Name = "ID")]
        public string id { get; set; }

        [Display(Name = "Nome FIPE")]
        public string fipe_name { get; set; }

        [Display(Name = "Nome")]
        public string name { get; set; }
    }
}
