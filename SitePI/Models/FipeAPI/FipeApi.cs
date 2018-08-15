using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SitePI.Models.FipeAPI
{
    public abstract class FipeApi
    {
        public  List<FipeApi> GetJsonData<FipeApi>(string url)
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return JsonConvert.DeserializeObject<List<FipeApi>>(json_data);
            }
        }

        public PrecoCorrente GetCarPrice<PrecoCorrente>(string url)
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return JsonConvert.DeserializeObject<PrecoCorrente>(json_data);
            }
        }
    }
}
