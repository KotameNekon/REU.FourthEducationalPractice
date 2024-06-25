using LibCompAndCust.SamkovYAA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestsForLibCompAndCust.SamkovYAA
{
    [TestClass()]
    public class MainAppTests_SamkovYAA
    {
        //private MainApp_SamkovYAA _app;

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
            var app = new MainApp_SamkovYAA();
            var company = new Company_SamkovYAA();
            app.AddCompany(company);
            var companies = app.GetCompanies().ToList();
            CollectionAssert.Contains(companies, company);
        }

        [TestMethod()]
        public void UpdateCompanyTest()
        {
            var app = new MainApp_SamkovYAA();
            var company = new Company_SamkovYAA();
            app.AddCompany(company);
            company.Name = "Updated Name";
            app.UpdateCompany(company);
            var updatedCompany = app.GetCompanies().FirstOrDefault(c => c.ID == company.ID);
            Assert.AreEqual("Updated Name", updatedCompany.Name);
        }

        [TestMethod()]
        public void RemoveCompanyTest()
        {
            var app = new MainApp_SamkovYAA();
            var company = new Company_SamkovYAA();
            app.AddCompany(company);
            app.RemoveCompany(company);
            var companies = app.GetCompanies().ToList();
            CollectionAssert.DoesNotContain(companies, company);
        }

        [TestMethod()]
        public void GetCompaniesTest()
        {
            var app = new MainApp_SamkovYAA();
            var company1 = new Company_SamkovYAA { Name = "Company 1" };
            var company2 = new Company_SamkovYAA { Name = "Company 2" };

            app.AddCompany(company1);
            app.AddCompany(company2);

            var companies = app.GetCompanies().ToList();

            Assert.AreEqual(2, companies.Count);
            CollectionAssert.Contains(companies, company1);
            CollectionAssert.Contains(companies, company2);
        }

        [TestMethod()]
        public void AddCustomerTest()
        {
            var app = new MainApp_SamkovYAA();
            var company = new Company_SamkovYAA();
            app.AddCompany(company);
            var customer = new Customer_SamkovYAA();
            app.AddCustomer(customer, company);
            var customers = app.GetCustomers(company).ToList();
            CollectionAssert.Contains(customers, customer);
        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {
            var app = new MainApp_SamkovYAA();
            var company = new Company_SamkovYAA();
            app.AddCompany(company);
            var customer = new Customer_SamkovYAA();
            app.AddCustomer(customer, company);
            customer.Name = "Updated Name";
            app.UpdateCustomer(customer, company);
            var updatedCustomer = app.GetCustomers(company).FirstOrDefault(c => c.ID == customer.ID);
            Assert.AreEqual("Updated Name", updatedCustomer.Name);
        }

        [TestMethod()]
        public void RemoveCustomerTest()
        {
            var app = new MainApp_SamkovYAA();
            var company = new Company_SamkovYAA();
            app.AddCompany(company);
            var customer = new Customer_SamkovYAA();
            app.AddCustomer(customer, company);
            app.RemoveCustomer(customer, company);
            var customers = app.GetCustomers(company).ToList();
            CollectionAssert.DoesNotContain(customers, customer);
        }

        [TestMethod()]
        public void GetCustomersTest()
        {
            var app = new MainApp_SamkovYAA();
            var company = new Company_SamkovYAA { Name = "Company" };
            app.AddCompany(company);

            var customer1 = new Customer_SamkovYAA { Name = "Customer 1" };
            var customer2 = new Customer_SamkovYAA { Name = "Customer 2" };

            app.AddCustomer(customer1, company);
            app.AddCustomer(customer2, company);

            var customers = app.GetCustomers(company).ToList();

            Assert.AreEqual(2, customers.Count);
            CollectionAssert.Contains(customers, customer1);
            CollectionAssert.Contains(customers, customer2);
        }
    }
}