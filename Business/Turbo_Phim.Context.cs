﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TURBO_PHIMEntities : DbContext
    {
        public TURBO_PHIMEntities()
            : base("name=TURBO_PHIMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BaiNhanXet> BaiNhanXet { get; set; }
        public virtual DbSet<BangThamSo> BangThamSo { get; set; }
        public virtual DbSet<BinhChon> BinhChon { get; set; }
        public virtual DbSet<BinhLuan> BinhLuan { get; set; }
        public virtual DbSet<DanhGia> DanhGia { get; set; }
        public virtual DbSet<DanhMucNuocSanXuat> DanhMucNuocSanXuat { get; set; }
        public virtual DbSet<DanhMucTheLoai> DanhMucTheLoai { get; set; }
        public virtual DbSet<DanhSachPhimYeuThich> DanhSachPhimYeuThich { get; set; }
        public virtual DbSet<Phim> Phim { get; set; }
        public virtual DbSet<ThanhVien> ThanhVien { get; set; }
    }
}
