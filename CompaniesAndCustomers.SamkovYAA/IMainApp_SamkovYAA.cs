using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCompAndCust.SamkovYAA
{
    public interface IMainApp_SamkovYAA
    {
        void AddCompany(Company_SamkovYAA company);
        void UpdateCompany(Company_SamkovYAA company);
        void RemoveCompany(Company_SamkovYAA company);
        IEnumerable<Company_SamkovYAA> GetCompanies();

        void AddCustomer(Customer_SamkovYAA customer, Company_SamkovYAA company);
        void UpdateCustomer(Customer_SamkovYAA customer, Company_SamkovYAA company);
        void RemoveCustomer(Customer_SamkovYAA customer, Company_SamkovYAA company);
        IEnumerable<Customer_SamkovYAA> GetCustomers(Company_SamkovYAA company);
    }
}