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
    
    public partial class tblServiceProvider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblServiceProvider()
        {
            this.tblCustomers = new HashSet<tblCustomer>();
            this.tblServiceProviderCities = new HashSet<tblServiceProviderCity>();
        }
    
        public int Id { get; set; }
        public string ProviderName { get; set; }
        public string ServiceName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomer> tblCustomers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblServiceProviderCity> tblServiceProviderCities { get; set; }
    }
}
