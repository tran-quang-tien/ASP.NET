﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TqtSinhvien.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TqtQuanlysvEntities : DbContext
    {
        public TqtQuanlysvEntities()
            : base("name=TqtQuanlysvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TqtKhoa> TqtKhoas { get; set; }
        public virtual DbSet<TqtSinhvien> TqtSinhviens { get; set; }
        public virtual DbSet<Ketqua> Ketquas { get; set; }
        public virtual DbSet<Monho> Monhoes { get; set; }
    }
}
