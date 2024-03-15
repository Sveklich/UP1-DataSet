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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            ComboPage.SelectedIndex = 0;
            
        }
        private void Page_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboPage.SelectedIndex == 0)
            {
                Page2Frame.Content = new LegionsP();
            }
            if (ComboPage.SelectedIndex == 1)
            {
                Page2Frame.Content = new Homeworld();
            }
            if (ComboPage.SelectedIndex == 2)
            {
                Page2Frame.Content = new Loyalty();
            }
            if (ComboPage.SelectedIndex == 3)
            {
                Page2Frame.Content = new StatusP();
            }

        }
    }
}
