//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TraCuuDiem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHOA
    {
        public KHOA()
        {
            this.LOPs = new HashSet<LOP>();
            this.NGANHs = new HashSet<NGANH>();
        }
    
        public string MAKH { get; set; }
        public string TENKH { get; set; }
    
        public virtual ICollection<LOP> LOPs { get; set; }
        public virtual ICollection<NGANH> NGANHs { get; set; }
    }
}
