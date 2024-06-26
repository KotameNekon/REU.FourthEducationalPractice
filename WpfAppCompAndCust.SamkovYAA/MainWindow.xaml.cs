using LibCompAndCust.SamkovYAA;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private Customer_SamkovYAA CurrentCustomer { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            app = new MainApp_SamkovYAA();

            FillCompaniesCollection();
        }

        private void CompaniesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentCompany = this.CompaniesList.SelectedItem as Company_SamkovYAA;

            if (CurrentCompany != null)
            {
                FillCustomersCollection(CurrentCompany);
            }
        }

        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentCustomer = this.CustomersList.SelectedItem as Customer_SamkovYAA;
        }

        private void FillCompaniesCollection()
        {
            this.CompaniesList.ItemsSource = null;
            this.CompaniesList.Items.Clear();

            this.CompaniesList.ItemsSource = app.Context.Companies;
            this.CompaniesList.SelectedIndex = 0;
        }

        private void FillCustomersCollection(Company_SamkovYAA company)
        {
            this.CustomersList.ItemsSource = null;
            this.CustomersList.Items.Clear();

            this.CustomersList.ItemsSource = company.Customers;
            this.CustomersList.SelectedIndex = 0;
        }

        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void AddCompany_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CommandWindow cmdWindow = new CommandWindow("Новая компания", "Наименование компании: ", "", app, 1);
            cmdWindow.Owner = this;

            if (cmdWindow.ShowDialog() == true)
            {
                FillCompaniesCollection();
            }
        }

        private void EditCompany_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (CurrentCompany != null)
            {
                CommandWindow cmdWindow = new CommandWindow("Изменить компанию", "Наименование компании: ", CurrentCompany.Name, app, 2, CurrentCompany);
                cmdWindow.Owner = this;
                int idx = this.CompaniesList.SelectedIndex;

                if (cmdWindow.ShowDialog() == true)
                {
                    FillCompaniesCollection();
                    this.CompaniesList.SelectedIndex = idx;
                }
            }
        }

        private void RemoveCompany_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (CurrentCompany != null)
            {
                CommandWindow cmdWindow = new CommandWindow("Удалить компанию", "Наименование компании: ", CurrentCompany.Name, app, 3, CurrentCompany);
                cmdWindow.Owner = this;
                cmdWindow.tbName.IsReadOnly = true;

                if (cmdWindow.ShowDialog() == true)
                {
                    FillCompaniesCollection();
                    if (this.CompaniesList.Items.Count == 0)
                    {
                        this.CustomersList.ItemsSource = null;
                    }
                }
            }
        }

        private void AddCustomer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (CurrentCompany != null)
            {
                CommandWindow cmdWindow = new CommandWindow("Новый сотрудник", "Имя сотрудника: ", "", app, 4, CurrentCompany);
                cmdWindow.Owner = this;
                int idx = this.CompaniesList.SelectedIndex;

                if (cmdWindow.ShowDialog() == true)
                {
                    FillCompaniesCollection();
                    this.CompaniesList.SelectedIndex = idx;

                    FillCustomersCollection(CurrentCompany);
                }
            }
        }

        private void EditCustomer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CommandWindow cmdWindow = new CommandWindow("Изменить сотрудника", "Имя сотрудника: ", CurrentCustomer.Name, app, 5, CurrentCompany, CurrentCustomer);
            cmdWindow.Owner = this;
            int idx = this.CompaniesList.SelectedIndex;
            int index = this.CustomersList.SelectedIndex;

            if (cmdWindow.ShowDialog() == true)
            {
                FillCompaniesCollection();
                this.CompaniesList.SelectedIndex = idx;

                FillCustomersCollection(CurrentCompany);
                this.CustomersList.SelectedIndex = index;
            }
        }

        private void RemoveCustomer_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CommandWindow cmdWindow = new CommandWindow("Удалить сотрудника", "Имя сотрудника: ", CurrentCustomer.Name, app, 6, CurrentCompany, CurrentCustomer);
            cmdWindow.Owner = this;
            int idx = this.CompaniesList.SelectedIndex;
            cmdWindow.tbName.IsReadOnly = true;

            if (cmdWindow.ShowDialog() == true)
            {
                FillCompaniesCollection();
                this.CompaniesList.SelectedIndex = idx;
                FillCustomersCollection(CurrentCompany);
            }
        }
    }
}