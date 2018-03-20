using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Codefirst.Infrastructure.DAL.Entities;
namespace Codefirst.Infrastructure.DAL.Store
{
    internal class ProductAlwaysDropDatabaseInitializercs : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var categoryList = CategorySeed.GetCategoryForDBIntialization();
            context.Categories.AddRange(categoryList);
            context.SaveChanges();

            var productList = ProductSeed.GetProductsForDBIntialization();
            context.Products.AddRange(productList);
            context.SaveChanges();
        }
    }
}
