using Codefirst.Infrastructure.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst.Infrastructure.DAL.Store
{
    public static class ProductSeed
    {
        public static List<ProductEntity> GetProductsForDBIntialization()
        {
            List<ProductEntity> productList = new List<ProductEntity>
            {
                new ProductEntity{Title = "Iphone 7", CategoryID =1, Description="", Price = 899, IsPublished = true},
                new ProductEntity{Title = "Galaxy S9", CategoryID =1, Description="", Price = 577, IsPublished = true},
                new ProductEntity{Title = "Pixel 2", CategoryID =1, Description="", Price = 899, IsPublished = true},
                new ProductEntity{Title = "Nokia 6", CategoryID =1, Description="", Price = 899, IsPublished = true},
                new ProductEntity{Title = " 49\" LG" , CategoryID = 2, Description="", Price = 899, IsPublished = true},
                new ProductEntity{Title = " Sony Bravia" , CategoryID = 2, Description="", Price = 899, IsPublished = true},
                new ProductEntity{Title = " Toshiba Ulta HD" , CategoryID = 2, Description="", Price = 899, IsPublished = true},
                new ProductEntity{Title = " Samsung Smart" , CategoryID = 2, Description="", Price = 899, IsPublished = true},
                new ProductEntity{Title = " Andriod Curve" , CategoryID = 2, Description="", Price = 899, IsPublished = true},
            };
            return productList;
        }
    }
}
