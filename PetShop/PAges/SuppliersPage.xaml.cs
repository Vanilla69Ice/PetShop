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

namespace PetShop.PAges
{
    /// <summary>
    /// Логика взаимодействия для SuppliersPage.xaml
    /// </summary>
    public partial class SuppliersPage : Page
    {
        private static readonly Model.DB _db = new Model.DB();
        public ObservableCollection<Model.Suppliers> Supliers { get; set; } = new ObservableCollection<Model.Suppliers>(_db.Suppliers.ToList());
        public SuppliersPage()
        {
            InitializeComponent();
        }
    }
}
