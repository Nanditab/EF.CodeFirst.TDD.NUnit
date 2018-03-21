using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Codefirst.Infrastructure.DAL.Entities;

namespace Codefirst.Infrastructure.DAL.Store
{
   public class CodefirstContext : DbContext
    {
        public CodefirstContext() : base("EFCodeFirst.TDD.NUnit")
        { }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<ProductEntity>  Products { get; set; }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntity>().ToTable("Category");
            modelBuilder.Entity<ProductEntity>().ToTable("Product");
            modelBuilder.Entity<UserEntity>().ToTable("User");
        }
    }
}
