﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DetectFace
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class quanlydiemEntities : DbContext
    {
        public quanlydiemEntities()
            : base("name=quanlydiemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BACDAOTAO> BACDAOTAOs { get; set; }
        public DbSet<DIEM> DIEMs { get; set; }
        public DbSet<HOCKY> HOCKies { get; set; }
        public DbSet<KHOA> KHOAs { get; set; }
        public DbSet<LOAIHINHDAOTAO> LOAIHINHDAOTAOs { get; set; }
        public DbSet<LOP> LOPs { get; set; }
        public DbSet<MONHOC> MONHOCs { get; set; }
        public DbSet<NGANH> NGANHs { get; set; }
        public DbSet<NIENKHOA> NIENKHOAs { get; set; }
        public DbSet<SINHVIEN> SINHVIENs { get; set; }
    }
}
