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
    /// Interaction logic for SwitcPreview2.xaml
    /// </summary>
    public partial class SwitcPreview2 : Window
    {
        public MainViewModel MainViewModel;

        public SwitcPreview2(Admin admin = null)
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(admin);

        }
    }
}
