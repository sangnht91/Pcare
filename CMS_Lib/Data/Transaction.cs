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
    
    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            this.TransactionCoupons = new HashSet<TransactionCoupon>();
            this.TransactionDetails = new HashSet<TransactionDetail>();
            this.TransactionTransactionStatus = new HashSet<TransactionTransactionStatu>();
        }
    
        public int ID { get; set; }
        public string TransactionCode { get; set; }
        public Nullable<int> TransactionTypeID { get; set; }
        public Nullable<int> SenderID { get; set; }
        public string EndingBalanceSender { get; set; }
        public Nullable<int> ReceiverID { get; set; }
        public string EndingBalanceReceiver { get; set; }
        public string TotalAmount { get; set; }
        public string TotalDiscount { get; set; }
        public string TotalPaid { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionCoupon> TransactionCoupons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionTransactionStatu> TransactionTransactionStatus { get; set; }
    }
}
