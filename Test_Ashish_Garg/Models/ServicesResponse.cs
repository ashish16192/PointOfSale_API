using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Ashish_Garg.Models
{
    public class ServicesResponse
    {
        public int statusCode { get; set; }
        public string message { get; set; }
        public string version { get; set; }
        public object data { get; set; }
    }
}