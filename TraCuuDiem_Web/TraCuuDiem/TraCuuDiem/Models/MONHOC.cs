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
    
    public partial class MONHOC
    {
        public MONHOC()
        {
            this.DIEMs = new HashSet<DIEM>();
        }
    
        public string MAMH { get; set; }
        public string MALOP { get; set; }
        public string TENMH { get; set; }
        public Nullable<int> SOTC { get; set; }
    
        public virtual ICollection<DIEM> DIEMs { get; set; }
        public virtual LOP LOP { get; set; }
    }
}
