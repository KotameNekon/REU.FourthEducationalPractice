using LibCompAndCust.SamkovYAA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestsForLibCompAndCust.SamkovYAA
{
    [TestClass()]
    public class MainAppTests_SamkovYAA
    {
        private MainApp_SamkovYAA _app;

        [TestMethod()]
        public void MainAppTest()
        {
            /*MainApp_SamkovYAA ma = new MainApp_SamkovYAA();
            Assert.IsInstanceOfType(ma, typeof(MainApp_SamkovYAA));
            Assert.IsNotNull(ma);*/

            var app = new MainApp_SamkovYAA();
            Assert.IsNotNull(app.Context);
            Assert.IsNotNull(app.Context.Companies);
            Assert.IsTrue(app.Context.Companies.Count == 0);
        }

        [TestMethod()]
        public void AddCompanyTest()
        {
            var company = new Company_SamkovYAA();
            _app.AddCompany(company);
            var companies = _app.GetCompanies();
            Assert.IsTrue(companies.Contains(company));
        }

        [TestMethod()]
        public void UpdateCompanyTest()
        {
            var company = new Company_SamkovYAA();
            _app.AddCompany(company);
            company.Name = "Updated Name";
            _app.UpdateCompany(company);
            var updatedCompany = _app.GetCompanies().FirstOrDefault(c => c.ID == company.ID);
            Assert.AreEqual("Updated Name", updatedCompany.Name);
        }

        [TestMethod()]
        public void RemoveCompanyTest()
        {
            var company = new Company_SamkovYAA();
            _app.AddCompany(company);
            _app.RemoveCompany(company);
            var companies = _app.GetCompanies();
            Assert.IsFalse(companies.Contains(company));
        }

        [TestMethod()]
        public void GetCompaniesTest()
        {
            var company1 = new Company_SamkovYAA { Name = "Company 1" };
            var company2 = new Company_SamkovYAA { Name = "Company 2" };

            _app.AddCompany(company1);
            _app.AddCompany(company2);

            var companies = _app.GetCompanies().ToList();

            Assert.AreEqual(2, companies.Count);
            CollectionAssert.Contains(companies, company1);
            CollectionAssert.Contains(companies, company2);
        }

        [TestMethod()]
        public void AddCustomerTest()
        {
            var company = new Company_SamkovYAA();
            _app.AddCompany(company);
            var customer = new Customer_SamkovYAA();
            _app.AddCustomer(customer, company);
            var customers = _app.GetCustomers(company);
            Assert.IsTrue(customers.Contains(customer));
        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {
            var company = new Company_SamkovYAA();
            _app.AddCompany(company);
            var customer = new Customer_SamkovYAA();
            _app.AddCustomer(customer, company);
            customer.Name = "Updated Name";
            _app.UpdateCustomer(customer, company);
            var updatedCustomer = _app.GetCustomers(company).FirstOrDefault(c => c.ID == customer.ID);
            Assert.AreEqual("Updated Name", updatedCustomer.Name);
        }

        [TestMethod()]
        public void RemoveCustomerTest()
        {
            var company = new Company_SamkovYAA();
            _app.AddCompany(company);
            var customer = new Customer_SamkovYAA();
            _app.AddCustomer(customer, company);
            _app.RemoveCustomer(customer, company);
            var customers = _app.GetCustomers(company);
            Assert.IsFalse(customers.Contains(customer));
        }

        [TestMethod()]
        public void GetCustomersTest()
        {
            var company = new Company_SamkovYAA { Name = "Company" };
            _app.AddCompany(company);

            var customer1 = new Customer_SamkovYAA { Name = "Customer 1" };
            var customer2 = new Customer_SamkovYAA { Name = "Customer 2" };

            _app.AddCustomer(customer1, company);
            _app.AddCustomer(customer2, company);

            var customers = _app.GetCustomers(company).ToList();

            Assert.AreEqual(2, customers.Count);
            CollectionAssert.Contains(customers, customer1);
            CollectionAssert.Contains(customers, customer2);
        }
    }
}