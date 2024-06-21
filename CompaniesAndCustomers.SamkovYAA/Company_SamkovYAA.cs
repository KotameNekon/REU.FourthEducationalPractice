using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibCompAndCust.SamkovYAA
{
    public class Company_SamkovYAA
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<Customer_SamkovYAA> Customers { get; set; } = new List<Customer_SamkovYAA>();

        public Company_SamkovYAA() { }

        public Company_SamkovYAA(string name)
        {
            this.Name = name;
        }
    }
}
