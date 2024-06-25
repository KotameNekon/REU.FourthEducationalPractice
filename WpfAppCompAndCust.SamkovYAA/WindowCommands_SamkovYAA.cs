using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            Exit = new RoutedCommand("Exit", typeof(MainWindow));
            AddCompany = new RoutedCommand("AddCompany", typeof(MainWindow));
            EditCompany = new RoutedCommand("EditCompany", typeof(MainWindow));
            RemoveCompany = new RoutedCommand("RemoveCompany", typeof(MainWindow));
            AddCustomer = new RoutedCommand("AddCustomer", typeof(MainWindow));
            EditCustomer = new RoutedCommand("EditCustomer", typeof(MainWindow));
            RemoveCustomer = new RoutedCommand("RemoveCustomer", typeof(MainWindow));
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
