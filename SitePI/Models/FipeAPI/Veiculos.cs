﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitePI.Models.FipeAPI
{
    public class Veiculos : FipeApi
    {
        public string fipe_marca { get; set; }
        public string name { get; set; }
        public string marca { get; set; }
        public string key { get; set; }
        public string id { get; set; }
        public string fipe_name { get; set; }
    }
}
