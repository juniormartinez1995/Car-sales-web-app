using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitePI.Models.FipeAPI
{
    public class PrecoCorrente : FipeApi
    {
        public string referencia { get; set; }//
        public string fipe_codigo { get; set; }//
        public string name { get; set; }//
        public string combustivel { get; set; }//
        public string marca { get; set; }//
        public string ano_modelo { get; set; }//
        public string preco { get; set; }//
        public string key { get; set; }//
        public double time { get; set; }
        public string veiculo { get; set; }//
        public string id { get; set; }//
    }
}
