﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLCongDanEntities : DbContext
    {
        public QLCongDanEntities()
            : base("name=QLCongDanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CCCD> CCCDs { get; set; }
        public virtual DbSet<CongDan> CongDans { get; set; }
        public virtual DbSet<CongDan_SoHoKhau> CongDan_SoHoKhau { get; set; }
        public virtual DbSet<CongTy> CongTies { get; set; }
        public virtual DbSet<CongTy_NhanVien> CongTy_NhanVien { get; set; }
        public virtual DbSet<HonNhan> HonNhans { get; set; }
        public virtual DbSet<KhaiSinh> KhaiSinhs { get; set; }
        public virtual DbSet<KhaiTu> KhaiTus { get; set; }
        public virtual DbSet<LichSuThue> LichSuThues { get; set; }
        public virtual DbSet<SoHoKhau> SoHoKhaus { get; set; }
        public virtual DbSet<TamTruTamVang> TamTruTamVangs { get; set; }
    }
}
