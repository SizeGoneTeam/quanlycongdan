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
    
    public partial class TamTruTamVang
    {
        public int ID_TamTru { get; set; }
        public Nullable<int> ID_CongDan { get; set; }
        public Nullable<System.DateTime> NgayDen { get; set; }
        public Nullable<System.DateTime> NgayDi { get; set; }
        public string DiaChi { get; set; }
        public string LiDo { get; set; }
    
        public virtual CongDan CongDan { get; set; }
        public TamTruTamVang() { }
        public TamTruTamVang(int iD_TamTru, int? iD_CongDan, DateTime? ngayDen, DateTime? ngayDi, string diaChi, string liDo)
        {
            ID_TamTru = iD_TamTru;
            ID_CongDan = iD_CongDan;
            NgayDen = ngayDen;
            NgayDi = ngayDi;
            DiaChi = diaChi;
            LiDo = liDo;
        }
        public TamTruTamVang(int? iD_CongDan, DateTime? ngayDen, DateTime? ngayDi, string diaChi, string liDo)
        {
            ID_CongDan = iD_CongDan;
            NgayDen = ngayDen;
            NgayDi = ngayDi;
            DiaChi = diaChi;
            LiDo = liDo;
        }
    }
}