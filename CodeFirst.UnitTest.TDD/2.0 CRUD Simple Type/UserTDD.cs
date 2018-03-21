using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codefirst.Domain.DomainModel;
using Codefirst.Infrastructure.DAL.Entities;
using Codefirst.Infrastructure.DAL.Store;
using Codefirst.Infrastructure.Repository;
using NUnit.Framework;
namespace CodeFirst.UnitTest.TDD._2._0_CRUD_Simple_Type
{
    [TestFixture]
    public class UserTDD
    {
        [SetUp]
        public void TestSetUp()
        {
            DatabaseIntialization.Initialize(DatabaseIntialization.EFInitializerType.DropCreateDatabaseAlways);
        }

        [Test]
        public void AddUser()
        {
            //arrange
            User user = new User
            {
                FirstName = "Adam",
                LastName = "Freeman",
                Email = "adam.freeman@gmail.com",
                IsActive = true
            };
            EFRepository repository = new EFRepository();
            //act
            user = repository.AddUser(user);
            //asert
            Assert.IsNotNull(user);

        }
        [Test]
        public void GetUsers()
        {
            //arrange
            EFRepository repository = new EFRepository();
            //act
            var users = repository.GetUsers();
            //assert
            Assert.IsTrue(users.Count() > 0);
        }
    }
}
