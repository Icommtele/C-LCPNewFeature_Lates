using LCPReportingSystem.Model;
using LCPReportingSystem.ViewModel;
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

namespace LCPReportingSystem.View
{
    /// <summary>
    /// Interaction logic for RouterInfoPreview.xaml
    /// </summary>
    public partial class RouterInfoPreview : Window
    {
        public MainViewModel mainViewModel;
        public RouterInfoPreview(Admin admin = null)
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(admin);
        }
    }
}
