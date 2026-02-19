using LCPReportingSystem.Model;
using LCPReportingSystem.ViewModel;
using LCPReportingSystem.WindowForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for DieselGenerator.xaml
    /// </summary>
    public partial class DieselGenerator : Window
    {
        public MainViewModel mainViewModel;
        public DieselGenerator(Admin admin = null)
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(admin);
        }

    }
}
