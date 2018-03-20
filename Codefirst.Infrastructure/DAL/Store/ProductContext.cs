using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Codefirst.Infrastructure.DAL.Entities;

namespace Codefirst.Infrastructure.DAL.Store
{
   public class ProductContext : DbContext
    {
        public ProductContext() : base("EFCodeFirst.TDD.NUnit")
        { }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<ProductEntity>  Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntity>().ToTable("Category");
            modelBuilder.Entity<ProductEntity>().ToTable("Product");
        }
    }
}
