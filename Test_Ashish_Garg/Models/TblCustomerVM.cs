using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Ashish_Garg.Models
{
    public class TblCustomerVM
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public Nullable<int> ServiceTaken { get; set; }
        public string ContactNo { get; set; }
        public string ServiceName { get; set; }
    }
}