using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibCompAndCust.SamkovYAA
{
    public class Customer_SamkovYAA
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public int CompanyID{ get; set; }

        public Company_SamkovYAA Company { get; set; }

        public Customer_SamkovYAA() { }

        public Customer_SamkovYAA(string name, int companyID)
        {
            this.Name = name;
            this.CompanyID = companyID;
        }

        public Customer_SamkovYAA(string name, Company_SamkovYAA company)
        {
            this.Name = name;
            this.Company = company;
            this.CompanyID = company.ID;
        }
    }
}