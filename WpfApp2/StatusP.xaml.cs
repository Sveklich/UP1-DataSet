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
    /// Логика взаимодействия для StatusP.xaml
    /// </summary>
    public partial class StatusP : Page
    {
        PStatusTableAdapter pstatus = new PStatusTableAdapter();
        public StatusP()
        {
            InitializeComponent();
            PStatusDataGrid.ItemsSource = pstatus.GetData();
        }
    }
}
