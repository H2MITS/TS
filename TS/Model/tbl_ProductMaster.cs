//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ProductMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ProductMaster()
        {
            this.tbl_SheetDetails = new HashSet<tbl_SheetDetails>();
        }
    
        public long id { get; set; }
        public string p_Name { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<System.DateTime> cDate { get; set; }
        public Nullable<System.DateTime> uDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SheetDetails> tbl_SheetDetails { get; set; }
    }
}
