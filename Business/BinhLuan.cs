//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Business
{
    using System;
    using System.Collections.Generic;
    
    public partial class BinhLuan
    {
        public int MaSo { get; set; }
        public Nullable<int> MS_ThanhVien { get; set; }
        public Nullable<int> MS_BaiNhanXet { get; set; }
        public string NoiDung { get; set; }
        public Nullable<System.DateTime> NgayDang { get; set; }
    
        public virtual BaiNhanXet BaiNhanXet { get; set; }
        public virtual ThanhVien ThanhVien { get; set; }
    }
}
