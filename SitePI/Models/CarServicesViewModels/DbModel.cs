using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitePI.Models.CarServicesViewModels
{
    public class DbModel
    {
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String Local { get; set; }
        public DateTime HorarioCadastro { get; set; }
        public int id { get; set; }
    }
}
