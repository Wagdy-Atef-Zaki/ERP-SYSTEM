//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITI_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payback_Order_Retern_Table
    {
        public int Payback_Order_Retern_ID { get; set; }
        public int Order_Retern_ID { get; set; }
        public decimal Payback_Order_Retern_Value { get; set; }
        public System.DateTime Payback_Order_Retern_Date { get; set; }
        public decimal Last_Order_Retern_Reming { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> Deleted { get; set; }
    
        public virtual Order_Retern_Table Order_Retern_Table { get; set; }
    }
}