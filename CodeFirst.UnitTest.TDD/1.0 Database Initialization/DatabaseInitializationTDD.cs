using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Codefirst.Infrastructure.DAL.Store;
using Codefirst.Infrastructure.DAL.Entities;
using System.Data.Entity;
namespace CodeFirst.UnitTest.TDD._1._0_Database_Initialization
{
    [TestFixture]
    public class DatabaseInitializationTDD
    {
        [SetUp]
        public void TestSetUp()
        {

        }

        [Test]
        public void Initialise_Database_NoConnectionString_WithoutSeed()
        {
            //arrange
            // ************Important :- commented connection string from the app.config file *******/

            //act. Thsi will create database EFCodeFirst.TDD.NUnit in.\sqlexpress  or local db based on the local system.
            DatabaseIntialization.Initialize(DatabaseIntialization.EFInitializerType.DropCreateDatabaseAlways);
            using (ProductContext db = new ProductContext())
            {
                CategoryEntity category = new CategoryEntity
                {
                    ID = 1,
                    Name = "Test",
                    IsActive = true
                };
                db.Categories.Add(category);

                //asert
                db.Categories.Add(category);
                db.SaveChanges();
                //asert
                Assert.IsTrue(db.Database.Connection.Database == "EFCodeFirst.TDD.NUnit");
            }
        }

        [Test]
        public void Initialise_Database_ConnectionString_WithoutSeed()
        {
            //arrange
            
            //act. This will create database EFCodeFirst.TDD.NUnit in.\sqlexpress  or local db based on the local system.
            DatabaseIntialization.Initialize(DatabaseIntialization.EFInitializerType.DropCreateDatabaseAlways);
            using (ProductContext db = new ProductContext())
            {
                CategoryEntity category = new CategoryEntity
                {
                    ID = 1,
                    Name = "Test1",
                    IsActive = true
                };
                db.Categories.Add(category);
                db.SaveChanges();
                //asert
                Assert.IsTrue(db.Database.Connection.Database == "EFCodeFirst");                
            }
        }

        [Test]
        public void Can_Initialise_Database_And_Category_Table()
        {
            //arrange

            //act
            DatabaseIntialization.Initialize(DatabaseIntialization.EFInitializerType.DropCreateDatabaseAlways);
            using (ProductContext db = new ProductContext())
            {
                var categories = db.Categories;
               
                //assert
                Assert.IsTrue(categories.Count() > 0);
            }          
        }

        [Test]
        public void Can_Initialise_Database_And_Product_Table()
        {
            //arrange

            //act
            DatabaseIntialization.Initialize(DatabaseIntialization.EFInitializerType.DropCreateDatabaseAlways);
            using (ProductContext db = new ProductContext())
            {
                var products = db.Products;

                //assert
                Assert.IsTrue(products.Count() > 0);
            }
        }
    }
}
