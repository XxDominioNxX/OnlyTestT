using System;
using System.Collections.Generic;
using System.Text;

namespace OnlyTestT.Models
{
    public class Payload
    {
        public int total { get; set; }

        public List<Survey> surveys { get; set; }
    }
}
