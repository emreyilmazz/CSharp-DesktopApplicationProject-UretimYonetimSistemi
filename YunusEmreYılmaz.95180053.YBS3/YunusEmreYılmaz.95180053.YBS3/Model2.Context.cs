﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YunusEmreYılmaz._95180053.YBS3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UretimYonetimSistemiEntities1 : DbContext
    {
        public UretimYonetimSistemiEntities1()
            : base("name=UretimYonetimSistemiEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Calisan_Tanimi> Calisan_Tanimi { get; set; }
        public virtual DbSet<Is_Istasyon_Tanimi> Is_Istasyon_Tanimi { get; set; }
        public virtual DbSet<Operasyon_Tanimi> Operasyon_Tanimi { get; set; }
        public virtual DbSet<Recete_Tanimi> Recete_Tanimi { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}
