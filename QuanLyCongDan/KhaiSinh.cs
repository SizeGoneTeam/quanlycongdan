//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCongDan
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhaiSinh
    {
        public int ID_KhaiSinh { get; set; }
        public Nullable<int> ID_CongDan { get; set; }
        public Nullable<int> ID_NguoiYeuCau { get; set; }
        public Nullable<int> ID_Cha { get; set; }
        public Nullable<int> ID_Me { get; set; }
        public string NoiDangKy { get; set; }
        public Nullable<System.DateTime> NgayThucHien { get; set; }
    
        public virtual CongDan CongDan { get; set; }
        public virtual CongDan CongDan1 { get; set; }
        public virtual CongDan CongDan2 { get; set; }
        public virtual CongDan CongDan3 { get; set; }
    }
}
