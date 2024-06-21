using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LibCompAndCust.SamkovYAA
{
    public class MainApp_SamkovYAA : IDisposable, IMainApp_SamkovYAA
    {
        public ApplicationContext_SamkovYAA Context { get; private set; } = new ApplicationContext_SamkovYAA();

        private bool disposedValue;

        public void Dispose()
        {

        }

        protected virtual void Dispose(bool disposing)
        {

        }

        ~MainApp_SamkovYAA()
        {

        }

        public MainApp_SamkovYAA()
        {

        }

        public void AddCompany(Company_SamkovYAA company)
        {
            if (!this.Context.Companies.Contains(company))
            {
                company.ID = ++ApplicationContext_SamkovYAA.companyID;
                this.Context.Companies.Add(company);
            }
        }

        public void UpdateCompany(Company_SamkovYAA company)
        {
            if (!this.Context.Companies.Contains(company))
            {
                Company_SamkovYAA target = this.Context.Companies.FirstOrDefault(x => x.ID == company.ID);
                int id = this.Context.Companies.IndexOf(target);
                this.Context.Companies[id] = company;
            }
        }

        public void RemoveCompany(Company_SamkovYAA company)
        {
            if (this.Context.Companies.Contains(company))
            {
                this.Context.Companies.Remove(company);
            }
        }

        public IEnumerable<Company_SamkovYAA> GetCompanies()
        {
            return this.Context.Companies;
        }

        public void AddCustomer(Customer_SamkovYAA customer, Company_SamkovYAA company)
        {
            if (!company.Customers.Contains(customer))
            {
                customer.ID = ++ApplicationContext_SamkovYAA.customerID;
                customer.Company = company;
                customer.CompanyID = company.ID;
                company.Customers.Add(customer);
            }
        }

        public void AddCustomers(List<Customer_SamkovYAA> custlist, Company_SamkovYAA company)
        {
            foreach(Customer_SamkovYAA customer in custlist)
            {
                this.AddCustomer(customer, company);
            }
        }

        public void UpdateCustomer(Customer_SamkovYAA customer, Company_SamkovYAA company)
        {
            if (!company.Customers.Contains(customer))
            {
                Customer_SamkovYAA target = company.Customers.FirstOrDefault<Customer_SamkovYAA>(c => c.ID == customer.ID);
                if (target != null)
                {
                    int id = company.Customers.IndexOf(target);
                    company.Customers[id] = target;
                }
            }
        }

        public void RemoveCustomer(Customer_SamkovYAA customer, Company_SamkovYAA company)
        {
            if (this.Context.Companies.Contains(company))
            {
                if (company.Customers.Contains((Customer_SamkovYAA)customer))
                {
                    company.Customers.Remove(customer);
                }
            }
        }

        public IEnumerable<Customer_SamkovYAA> GetCustomers(Company_SamkovYAA company)
        {
            return company.Customers.Where(c => c.CompanyID == company.ID);
        }

        private void Serialize(string path, Customer_SamkovYAA obj)
        {

        }

        private Customer_SamkovYAA Deserialize(string path)
        {

        }

        public void SaveChanges()
        {

        }
    }
}
