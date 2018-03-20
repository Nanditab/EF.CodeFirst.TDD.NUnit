using Codefirst.Infrastructure.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst.Infrastructure.DAL.Store
{
    public static class CategorySeed
    {
        public static List<CategoryEntity> GetCategoryForDBIntialization()
        {

            List<CategoryEntity> categoryList = new List<CategoryEntity>
            {
                new CategoryEntity{ Name = "Mobile", IsActive=true},
                new CategoryEntity{ Name = "TV", IsActive=true},
                new CategoryEntity{ Name = "Laptop", IsActive=true},
                new CategoryEntity{ Name = "Tablet", IsActive=true}
            };

            return categoryList;
        }
    }
}
