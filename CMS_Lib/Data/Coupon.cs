//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS_Lib.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coupon()
        {
            this.TransactionCoupons = new HashSet<TransactionCoupon>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> CountPerUser { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
        public Nullable<decimal> Value { get; set; }
        public Nullable<double> PercentValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionCoupon> TransactionCoupons { get; set; }
    }
}
