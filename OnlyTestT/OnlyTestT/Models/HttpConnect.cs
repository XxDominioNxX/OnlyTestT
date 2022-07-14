using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.IO;

namespace OnlyTestT.Models
{
    class HttpConnect
    {
        private string Url { get; set; }
        

        public string Get(string url_request)
        {
            Url = url_request;
            WebClient webClient = new WebClient();
            string result = webClient.DownloadString(Url);
            return result;
        }

    }
}
