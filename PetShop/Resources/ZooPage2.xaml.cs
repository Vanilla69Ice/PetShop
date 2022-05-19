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

namespace PetShop.Resources
{
    /// <summary>
    /// Логика взаимодействия для ZooPage2.xaml
    /// </summary>
    public partial class ZooPage2 : Page
    {
        private static readonly Model.DB _db = new Model.DB();
        public ObservableCollection<Model.Animals> Animals  {get; set; } = new ObservableCollection<Model.Animals>(_db.Animals.ToList());
        public ZooPage2()
        {
            InitializeComponent();
        }
    }
}
