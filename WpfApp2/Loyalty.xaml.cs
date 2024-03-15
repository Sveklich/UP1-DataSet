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

using WpfApp2.UP1DataSetTableAdapters;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Loyalty.xaml
    /// </summary>
    public partial class Loyalty : Page
    {
        LoyaltyTableAdapter loyalty = new LoyaltyTableAdapter();
        public Loyalty()
        {
            InitializeComponent();
            LoyaltyDataGrid.ItemsSource = loyalty.GetData();
        }
    }
}
