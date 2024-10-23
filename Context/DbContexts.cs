using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using OsokinUP.Models;

namespace OsokinUP.Context
{
    public class DbContexts : DbContext
    {
        public DbSet<Materials> materials { get; set; }
        public DbSet<Partner_type> partner_type { get; set; }
        public DbSet<Partners> partners { get; set; }
        public DbSet<Partners_products> partners_products { get; set; }
        public DbSet<Product_type> product_type { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Required_material> required_material { get; set; }
        public DbSet<Suppliers> suppliers { get; set; }
        public DbContexts()
        {
            Database.EnsureCreated();
            this.materials.Load();
            this.partner_type.Load();
            this.partners.Load();
            this.partners_products.Load();
            this.product_type.Load();
            this.products.Load();
            this.required_material.Load();
            this.suppliers.Load();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection.config);
        }
    }
}
