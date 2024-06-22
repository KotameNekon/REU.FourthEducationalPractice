using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAppCompAndCust.SamkovYAA
{
    internal class WindowCommands_SamkovYAA
    {
        static WindowCommands_SamkovYAA()
        {
            Exit = new RoutedCommand("Exit", typeof(WindowCommands_SamkovYAA));
            AddCompany = new RoutedCommand("AddCompany", typeof(WindowCommands_SamkovYAA));
            EditCompany = new RoutedCommand("EditCompany", typeof(WindowCommands_SamkovYAA));
            RemoveCompany = new RoutedCommand("RemoveCompany", typeof(WindowCommands_SamkovYAA));
            AddCustomer = new RoutedCommand("AddCustomer", typeof(WindowCommands_SamkovYAA));
            EditCustomer = new RoutedCommand("EditCustomer", typeof(WindowCommands_SamkovYAA));
            RemoveCustomer = new RoutedCommand("RemoveCustomer", typeof(WindowCommands_SamkovYAA));
        }
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand AddCompany { get; set; }
        public static RoutedCommand EditCompany { get; set; }
        public static RoutedCommand RemoveCompany { get; set; }
        public static RoutedCommand AddCustomer { get; }
        public static RoutedCommand EditCustomer { get; }
        public static RoutedCommand RemoveCustomer { get; }
    }
}
