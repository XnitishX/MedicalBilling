//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalBilling
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceItem
    {
        public int id { get; set; }
        public Nullable<int> invoiceId { get; set; }
        public Nullable<int> pid { get; set; }
        public Nullable<int> iid { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> free { get; set; }
    
        public virtual Inventory Inventory { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
