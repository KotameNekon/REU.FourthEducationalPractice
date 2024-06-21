using LibCompAndCust.SamkovYAA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppCompAndCust.SamkovYAA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainApp_SamkovYAA app;
        private Company_SamkovYAA CurrentCompany { get; set; }
        private Customer_SamkovYAA CurrenyCustomer { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            app = new MainApp_SamkovYAA();

            this.DataContext = app.Context;

            FillCompaniesCollection();
        }


    }
}
