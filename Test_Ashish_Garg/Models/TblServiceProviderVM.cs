using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Ashish_Garg.Models
{
    public class TblServiceProviderVM
    {
        public int Id { get; set; }
        public string ProviderName { get; set; }
        public string ServiceName { get; set; }
        public Nullable<int> ServiceProviderId { get; set; }
        public string City { get; set; }
    }
}