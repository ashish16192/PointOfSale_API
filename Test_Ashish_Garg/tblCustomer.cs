//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_Ashish_Garg
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCustomer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public Nullable<int> ServiceTaken { get; set; }
        public string ContactNo { get; set; }
    
        public virtual tblServiceProvider tblServiceProvider { get; set; }
    }
}
