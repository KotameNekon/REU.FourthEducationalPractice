using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCompAndCust.SamkovYAA
{
    public class ApplicationContext_SamkovYAA
    {
        public ObservableCollection<Company_SamkovYAA> Companies { get; set; } = new ObservableCollection<Company_SamkovYAA>();

        public static int companyID { get; set; } = 0;
        public static int customerID { get; set; } = 0;

        public ApplicationContext_SamkovYAA()
        {

        }

        public void Dispose()
        {

        }
    }
}
