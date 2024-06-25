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
using System.Windows.Shapes;
using LibCompAndCust.SamkovYAA;

namespace WpfAppCompAndCust.SamkovYAA
{
    /// <summary>
    /// Логика взаимодействия для CommandWindow.xaml
    /// </summary>
    public partial class CommandWindow : Window
    {
        private MainApp_SamkovYAA app;
        private int flag;

        public Company_SamkovYAA CurrentCompany { get; set; }
        public Customer_SamkovYAA CurrentCustomer { get; set; }

        public CommandWindow()
        {
            InitializeComponent();
        }

        public CommandWindow(string Title, string labelName, string strData, MainApp_SamkovYAA App, int Flag)
        {
            InitializeComponent();

            this.flag = Flag;

            this.Title = Title;
            this.lblName.Content = labelName;

            if (String.IsNullOrEmpty(strData))
            {
                this.tbName.Clear();
            }
            else
            {
                tbName.Text = strData.ToString();
            }

            this.app = App;
        }

        public CommandWindow(string Title, string labelName, string strData, MainApp_SamkovYAA App, int Flag, Company_SamkovYAA currentCompany)
        {
            InitializeComponent();

            this.flag = Flag;

            this.Title = Title;
            this.lblName.Content = labelName;

            if (String.IsNullOrEmpty(strData))
            {
                this.tbName.Clear();
            }
            else
            {
                tbName.Text = strData.ToString();
            }

            //this.app = App;

            if (currentCompany != null)
            {
                this.CurrentCompany= currentCompany;
            }

            this.app = App;
        }

        public CommandWindow(string Title, string labelName, string strData, MainApp_SamkovYAA App, int Flag, Company_SamkovYAA currentCompany, Customer_SamkovYAA currentCustomer)
        {
            InitializeComponent();

            this.flag = Flag;

            this.Title = Title;
            this.lblName.Content = labelName;

            if (String.IsNullOrEmpty(strData))
            {
                this.tbName.Clear();
            }
            else
            {
                tbName.Text = strData.ToString();
            }

            //this.app = App;

            if (currentCompany != null)
            {
                this.CurrentCompany = currentCompany;
            }
            if (currentCustomer != null)
            {
                this.CurrentCustomer = currentCustomer;
            }

            this.app = App;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (app != null)
            {
                if (!String.IsNullOrEmpty(tbName.Text))
                {
                    switch (this.flag)
                    {
                        case 1:
                            {
                                CurrentCompany = new Company_SamkovYAA(tbName.Text.ToString());
                                app.AddCompany(CurrentCompany);

                                break;
                            }
                        case 2:
                            {
                                if (CurrentCompany != null)
                                {
                                    CurrentCompany.Name = tbName.Text.ToString();
                                }
                                app.UpdateCompany(CurrentCompany);

                                break;
                            }
                        case 3:
                            {
                                if (CurrentCompany != null)
                                {
                                    app.RemoveCompany(CurrentCompany);
                                }

                                break;
                            }
                        case 4:
                            {
                                if (CurrentCompany != null)
                                {
                                    Customer_SamkovYAA customer = new Customer_SamkovYAA(tbName.Text.ToString(), CurrentCompany.ID);
                                    app.AddCustomer(customer, CurrentCompany);
                                }

                                break;
                            }
                        case 5:
                            {
                                if ((CurrentCompany != null) & (CurrentCompany != null))
                                {
                                    if (CurrentCompany.Customers.Contains(CurrentCustomer))
                                    {
                                        CurrentCustomer.Name = tbName.Text.ToString();
                                        app.UpdateCustomer(CurrentCustomer, CurrentCompany);
                                    }
                                }

                                break;
                            }
                        case 6:
                            {
                                if ((CurrentCompany != null) & (CurrentCompany != null))
                                {
                                    if (CurrentCompany.Customers.Contains(CurrentCustomer))
                                    {
                                        app.RemoveCustomer(CurrentCustomer, CurrentCompany);
                                    }
                                }

                                break;
                            }
                        default: break;
                    }
                }
            }
            this.DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
