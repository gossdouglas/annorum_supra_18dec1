//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace annorum_supra_18dec.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_invoice
    {
        public int id { get; set; }
        public string prdct_code { get; set; }
        public string shop_code { get; set; }
        public System.DateTime inv_date { get; set; }
        public int quantity { get; set; }
    
        public virtual tbl_product tbl_product { get; set; }
        public virtual tbl_shop tbl_shop { get; set; }
    }
}
