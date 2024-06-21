using LibCompAndCust.SamkovYAA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsForLibCompAndCust.SamkovYAA
{
    [TestClass()]
    public class MainAppTests_SamkovYAA
    {
        [TestMethod()]
        public void MainAppTest()
        {
            MainApp_SamkovYAA ma = new MainApp_SamkovYAA();
            Assert.IsInstanceOfType(ma, typeof(MainApp_SamkovYAA));
            Assert.IsNotNull(ma);
        }

        [TestMethod()]
        public void AddCompanyTest()
        {

        }

        [TestMethod()]
        public void UpdateCompanyTest()
        {

        }

        [TestMethod()]
        public void RemoveCompanyTest()
        {

        }

        [TestMethod()]
        public void GetCompaniesTest()
        {

        }

        [TestMethod()]
        public void AddCustomerTest()
        {

        }

        [TestMethod()]
        public void AddCustomersTest()
        {

        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {

        }

        [TestMethod()]
        public void RemoveCustomerTest()
        {

        }

        [TestMethod()]
        public void GetCustomersTest()
        {

        }

        [TestMethod()]
        public void SaveChangesTest()
        {

        }
    }
}
