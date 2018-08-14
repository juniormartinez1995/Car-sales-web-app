using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SitePI.Models.FipeAPI
{
    public class Marcas : FipeApi
    {
        public string key { get; set; }
        public string id { get; set; }
        public string fipe_name { get; set; }
        public string name { get; set; }
    }
}
