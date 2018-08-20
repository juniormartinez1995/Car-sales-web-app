using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SitePI.Models.FipeAPI
{
    public class PrecoCorrente : FipeApi
    {
        [Display(Name = "Referencia")]
        public string referencia { get; set; }//

        [Display(Name = "Codigo FIPE")]
        public string fipe_codigo { get; set; }//

        [Display(Name = "Nome")]
        public string name { get; set; }//

        [Display(Name = "Combustivel")]
        public string combustivel { get; set; }//

        [Display(Name = "Marca")]
        public string marca { get; set; }//

        [Display(Name = "Ano-Modelo")]
        public string ano_modelo { get; set; }//

        [Display(Name = "Preço")]
        public string preco { get; set; }//

        [Display(Name = "Chave")]
        public string key { get; set; }//

        [Display(Name = "Time")]
        public double time { get; set; }

        [Display(Name = "Veículo")]
        public string veiculo { get; set; }//

        [Display(Name = "ID")]
        public string id { get; set; }//
    }
}
