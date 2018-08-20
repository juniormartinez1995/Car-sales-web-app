using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SitePI.Models.FipeAPI
{
    public class Veiculos : FipeApi
    {
        [Display(Name = "Marca FIPE")]
        public string fipe_marca { get; set; }

        [Display(Name = "Nome")]
        public string name { get; set; }

        [Display(Name = "Marca")]
        public string marca { get; set; }

        [Display(Name = "Chave")]
        public string key { get; set; }

        [Display(Name = "ID")]
        public string id { get; set; }

        [Display(Name = "Nome FIPE")]
        public string fipe_name { get; set; }
    }
}
