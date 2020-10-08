using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Restaurant.unittest
{
    [TestClass]
    public class Menstest
    {
        Mens manager;

        [TestInitialize]
        public void Setup()
        {
            manager = new Mens();
        }

        [TestMethod]
        public void GetIsManager_IsManager_ReturnsTrue()
        {
            //Mens manager = new Mens();

            manager.SetIsManager(true);

            var result = manager.GetIsManager();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetIsManager_IsNotManager_ReturnsFalse()
        {
           // Mens manager = new Mens();

            manager.SetIsManager(false);

            var result = manager.GetIsManager();

            Assert.IsFalse(result);
        }
    }
}
