using System;
using System.Collections.Generic;
using System.Text;

namespace OnlyTestT.Models
{
    public class Request
    {
        public bool success { get; set; }
        public string Str { get; set; }

        public Request(string str)
        {
            Str = str;
        }

        public Payload payload { get; set; }
    }
}
