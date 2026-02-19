using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using LCPInfrastructure;
using LCPReportingSystem.ViewModel;

namespace LCPReportingSystem.UserControls
{
    /// <summary>
    /// Interaction logic for SubSysConfigUserControl.xaml
    /// </summary>
    public partial class SubSysConfigUserControl : UserControl
    {
       public  SubSystemConfigViewModel scvm;
        public SubSysConfigUserControl()
        {
            InitializeComponent();
            scvm = new SubSystemConfigViewModel();
            this.DataContext = scvm;
            
        }
        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child is T t)
                    {
                        yield return t;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var clickedMenuItem = sender as MenuItem;
                string clickedHeader = clickedMenuItem?.Header?.ToString();

                var activeColor = Brushes.YellowGreen;
                var inactiveColor = (Brush)new BrushConverter().ConvertFromString("#0064C1");

                foreach (var menuItem in FindVisualChildren<MenuItem>(SubSystemMenu))
                {
                    string currentHeader = menuItem.Header?.ToString();

                    if (!string.IsNullOrWhiteSpace(currentHeader))
                    {
                        menuItem.Background = currentHeader == clickedHeader ? activeColor : inactiveColor;
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(MenuItem_Click));
            }
        }
    }
}
