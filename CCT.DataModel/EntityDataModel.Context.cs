﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCT.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebApiDbEntities : DbContext
    {
        public WebApiDbEntities()
            : base("name=WebApiDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<DiscountType> DiscountType { get; set; }
        public virtual DbSet<InventoryMaster> InventoryMaster { get; set; }
        public virtual DbSet<InventoryType> InventoryType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductSupply> ProductSupply { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreShop> StoreShop { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Tokens> Tokens { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
