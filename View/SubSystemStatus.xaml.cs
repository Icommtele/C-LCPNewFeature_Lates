using LCPReportingSystem.Model;
using LCPReportingSystem.ViewModel;
using LCPReportingSystem.WindowForm;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LCPReportingSystem.View
{
    /// <summary>
    /// Interaction logic for SubSystemStatus.xaml
    /// </summary>
    public partial class SubSystemStatus : Window
    {
        public SubSystemStatus(MainViewModel mainViewModel)
        {
            InitializeComponent();           
           
            this.DataContext= mainViewModel; 
        }
       
    }

}
