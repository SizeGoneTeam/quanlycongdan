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
    
    public partial class CongTy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongTy()
        {
            this.CongTy_NhanVien = new HashSet<CongTy_NhanVien>();
        }

        public CongTy(string text)
        {
            TenCongTy = text;
            NgayTao = DateTime.Now;
        }

        public CongTy(int iD_CongTy, string tenCongTy, DateTime? ngayTao)
        {
            ID_CongTy = iD_CongTy;
            TenCongTy = tenCongTy;
            NgayTao = ngayTao;
        }

        public int ID_CongTy { get; set; }
        public string TenCongTy { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongTy_NhanVien> CongTy_NhanVien { get; set; }
    }
}