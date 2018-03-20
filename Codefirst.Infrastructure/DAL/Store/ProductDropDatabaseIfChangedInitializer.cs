using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Codefirst.Infrastructure.DAL.Entities;

namespace Codefirst.Infrastructure.DAL.Store
{
   internal class ProductDropDatabaseIfChangedInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            List<CategoryEntity> categoryList = new List<CategoryEntity>
            {
                new CategoryEntity{ ID = 1, Name = "Mobile", IsActive=true},
                new CategoryEntity{ ID = 1, Name = "TV", IsActive=true},
                new CategoryEntity{ ID = 1, Name = "Laptop", IsActive=true},
                new CategoryEntity{ ID = 1, Name = "Tablet", IsActive=true}
            };

            context.Categories.AddRange(categoryList);
            context.SaveChanges();
        }
    }
}
