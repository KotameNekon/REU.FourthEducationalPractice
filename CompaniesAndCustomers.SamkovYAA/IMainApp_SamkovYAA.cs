using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCompAndCust.SamkovYAA
{
    public interface IMainApp_SamkovYAA
    {
        //void SaveChanges();

        void AddCompany(Company_SamkovYAA company);
        void UpdateCompany(Company_SamkovYAA company);
        void RemoveCompany(Company_SamkovYAA company);
        IEnumerable<Company_SamkovYAA> GetCompanies();

        void AddCustomer(Customer_SamkovYAA customer, Company_SamkovYAA company);
        //void AddCustomers(List<Customer_SamkovYAA> custlist, Company_SamkovYAA company);
        void UpdateCustomer(Customer_SamkovYAA customer, Company_SamkovYAA company);
        void RemoveCustomer(Customer_SamkovYAA customer, Company_SamkovYAA company);
        IEnumerable<Customer_SamkovYAA> GetCustomers(Company_SamkovYAA company);
    }
}
