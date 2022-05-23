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

namespace PetShop.Models.Таблицы
{
    /// <summary>
    /// Логика взаимодействия для кнопки.xaml
    /// </summary>
    public partial class кнопки : Page
    {
        public кнопки()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PAges.ZooPage());
        }

        private void Staff_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PAges.StaffPage());
        }

        private void RegularCustomers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PAges.RegularCustomersPage());
        }

        private void Supplies_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PAges.SupliesPage());
        }

        private void Suppliers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PAges.SuppliersPage());
        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PAges.SalesPage());
        }
    }
}
