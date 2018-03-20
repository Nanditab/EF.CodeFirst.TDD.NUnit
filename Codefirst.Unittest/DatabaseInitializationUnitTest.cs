using System;
using Codefirst.Infrastructure.DAL.Store;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codefirst.Unittest
{
    [TestClass]
    public class DatabaseInitializationUnitTest
    {
        [TestInitialize]
        public void TestInitialise()
        {

        }

        [TestMethod]
        public void CanDatabaseInitialiseNoConnectionString()
        {
            //arrange

            //act
            DatabaseIntialization.Initialize();
            //assert

        }
    }
}
