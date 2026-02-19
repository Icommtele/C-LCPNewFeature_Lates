using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LCPReportingSystem.ViewModel;
using LCPReportingSystem.Model;
using LCPInfrastructure;
using System.IO;
using System.Windows.Controls;
using Microsoft.Reporting.WinForms;
using LiveCharts.Wpf.Charts.Base;
using LCPReportingSystem.RsDialogMessageBox;
using System.Windows.Media;
using System.Diagnostics.Eventing.Reader;
using LCPReportingSystem.UserControls;

namespace LCPReportingSystem.WindowForm
{
    /// <summary>
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        ReportWindowViewModel reportWindowViewModel;
        public ReportWindow(string TagValue,Admin admin = null)
        {
            InitializeComponent();
            try
            {
                todateTimePicker.Value=DateTime.Now;

                if (TagValue == "Fault")
                {
                    SNMPTypePanel.Visibility = Visibility.Collapsed;
                    btnFilter.Margin = new Thickness(0, 0, 0, 0);
                    txtWindowName.Text = "Fault Report";
                    DisplaySubSystemBoarder.Visibility = Visibility.Visible;
                }
                else if(TagValue == "Activity")
                {
                    SNMPTypePanel.Visibility = Visibility.Collapsed;
                    btnFilter.Margin = new Thickness(0, 0, 0, 0);
                    txtWindowName.Text = "Activity Report";
                    DisplaySubSystemBoarder.Visibility = Visibility.Collapsed;

                }
                else
                {
                    SNMPTypePanel.Visibility = Visibility.Visible;
                    btnFilter.Margin = new Thickness(200, 0, 0, 0);
                    txtWindowName.Text = "Tabular Report";
                    DisplaySubSystemBoarder.Visibility = Visibility.Visible;
                }
                ReportWindowUserControl rpu = new ReportWindowUserControl("");
                reportWindowViewModel = new ReportWindowViewModel(TagValue, rpu);
                this.DataContext= reportWindowViewModel;

                if (UsageConstants.exerciseTypes.Count>0)
                {                   
                    cmbExerciseType.ItemsSource = UsageConstants.exerciseTypes;
                    cmbExerciseType.SelectedValue = "None";
                }
                Dg1Checkbox.IsChecked = true;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ReportWindow));
            }
        }

        private void cmbExerciseType_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (cmbExerciseType.SelectedValue.ToString() == "None")
                {
                    fromdateTimePicker.IsEnabled = true;
                    todateTimePicker.IsEnabled = true;
                    reportWindowViewModel.reports.ExerciseType = cmbExerciseType.SelectedValue.ToString();

                }
                else
                {
                    var DateTimeRangeList = reportWindowViewModel.LoadExerciseDateTime_Type(cmbExerciseType.SelectedValue.ToString());
                    reportWindowViewModel.reports.ExerciseType = cmbExerciseType.SelectedValue.ToString();
                    fromdateTimePicker.Value = DateTimeRangeList[0].ExerciseStartTime;
                    todateTimePicker.Value = DateTimeRangeList[0].ExerciseEndTime;
                    reportWindowViewModel.reports.RptSeletedFromDate = (DateTime)fromdateTimePicker.Value;
                    reportWindowViewModel.reports.RptSeletedToDate= (DateTime)todateTimePicker.Value;
                    fromdateTimePicker.IsEnabled = false;
                    todateTimePicker.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(cmbExerciseType_SelectionChanged));
            }
           
        }

        private void RsReportViewer_ReportExport(object sender, Microsoft.Reporting.WinForms.ReportExportEventArgs e)
        {
            try
            {
                //  string exportFormat = e.Extension.Name.ToUpper();
                // e.Cancel = true;
                string exportFormat = e.Extension.Name.ToUpper(); // "PDF", "EXCEL", etc.
                e.Cancel = true; // Cancel the built-in export dialog

                // 🔁 Normalize file extension
                string extension;
                switch (exportFormat)
                {
                    case "PDF":
                        extension = "pdf";
                        break;
                    case "EXCELOPENXML":
                        extension = "xlsx"; // ✅ modern Excel
                        break;
                    case "WORDOPENXML":
                        extension = "docx";
                        break;
                    default:
                        extension = exportFormat.ToLower();
                        break;
                }

                // 🧠 Suggest default file name
                string defaultFileName =$"{SubSystemName}_Report_{DateTime.Now:yyyyMMdd_HHmmss}.{extension}";

                // 📁 Suggest default directory (change if needed)
                string defaultDirectory = Path.Combine(
                    Directory.GetParent(Environment.CurrentDirectory).Parent.FullName,
                    @"Settings\Reports");

                // 📤 Show Save File dialog with default name and path
                var saveFileDialog = new System.Windows.Forms.SaveFileDialog
                {
                    Filter = $"{exportFormat} files|*.{extension}",
                    FileName = defaultFileName,
                    InitialDirectory = defaultDirectory,
                    Title = $"Export as {exportFormat}"
                };

                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ExportReport(exportFormat, saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RsReportViewer_ReportExport));
            }
        }

        private void ExportReport(string format, string outputPath)
        {
            try
            {
                string mimeType, encoding, extension;
                Warning[] warnings;
                string[] streamIds;

                byte[] bytes = RsReportViewer.LocalReport.Render(
                    format, null, out mimeType, out encoding, out extension, out streamIds, out warnings);

                File.WriteAllBytes(outputPath, bytes);

                RsDialogBox.ShowMsg("Report exported SuccessFully", "Reports",MessageBoxButton.OK,MessageBoxImage.Information);
                    
            }
            catch (DllNotFoundException ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RsReportViewer_ReportExport));
                // System.Windows.Forms.MessageBox.Show($"Missing DLL: {dllEx.Message}", "Export Error");
            }
            catch (AccessViolationException ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RsReportViewer_ReportExport));
                // System.Windows.Forms.MessageBox.Show($"Access Violation: {accessEx.Message}", "Export Error");
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RsReportViewer_ReportExport));
                //System.Windows.Forms.MessageBox.Show($"General error: {ex.Message}", "Export Error");
            }
        }
        string SubSystemName=string.Empty;
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MenuItem m = sender as MenuItem;
                SubSystemName = m.Header.ToString();
                if(string.Equals("Diesel Generator", SubSystemName))
                {
                    var dgMenuItem = this.FindName("DgCheckBoxMenuItem") as MenuItem;
                    if (dgMenuItem != null)
                    {
                        if (dgMenuItem.Visibility == Visibility.Visible)
                            dgMenuItem.Visibility = Visibility.Collapsed;
                        else
                            dgMenuItem.Visibility = Visibility.Visible;

                    }
                }
                else if(string.Equals("Router", SubSystemName))
                {
                    var dgMenuItem = this.FindName("RouterCheckBoxMenuItem") as MenuItem;
                    if (dgMenuItem != null)
                    {
                        if (dgMenuItem.Visibility == Visibility.Visible)
                            dgMenuItem.Visibility = Visibility.Collapsed;
                        else
                            dgMenuItem.Visibility = Visibility.Visible;

                    }
                }
                else if(string.Equals("Radio", SubSystemName))
                {
                    var dgMenuItem = this.FindName("RadioCheckBoxMenuItem") as MenuItem;
                    if (dgMenuItem != null)
                    {
                        if (dgMenuItem.Visibility == Visibility.Visible)
                            dgMenuItem.Visibility = Visibility.Collapsed;
                        else
                            dgMenuItem.Visibility = Visibility.Visible;

                    }
                }
                else if(string.Equals("Switch", SubSystemName))
                {
                    var dgMenuItem = this.FindName("SwitchCheckBoxMenuItem") as MenuItem;
                    if (dgMenuItem != null)
                    {
                        if (dgMenuItem.Visibility == Visibility.Visible)
                            dgMenuItem.Visibility = Visibility.Collapsed;
                        else
                            dgMenuItem.Visibility = Visibility.Visible;

                    }
                }
                else if(string.Equals("UPS", SubSystemName))
                {
                    var dgMenuItem = this.FindName("UPSCheckBoxMenuItem") as MenuItem;
                    if (dgMenuItem != null)
                    {
                        if (dgMenuItem.Visibility == Visibility.Visible)
                            dgMenuItem.Visibility = Visibility.Collapsed;
                        else
                            dgMenuItem.Visibility = Visibility.Visible;

                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(MenuItem_Click));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        public void IsOnlyOneCheckboxChecked(string Name)
        {
            try
            {               

                foreach (var checkBox in FindVisualChildren<CheckBox>(SubsystemsMenu))
                {
                    if(Name== checkBox.Name)
                    {
                        checkBox.IsChecked = true;
                    }
                    else
                    {
                        checkBox.IsChecked = false;
                    }                    
                }
               
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IsOnlyOneCheckboxChecked));
            }
           
        }
        
        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child is T t)
                        yield return t;

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                        yield return childOfChild;
                }
            }
        }
        private void Dg1Checkbox_Checked(object sender, RoutedEventArgs e)
        {
                IsOnlyOneCheckboxChecked("Dg1Checkbox");
            
                var viewModel = DataContext as ReportWindowViewModel;
                if (viewModel?.RptDgCommand?.CanExecute("Diesel Generator1") == true)
                {
                    viewModel.RptDgCommand.Execute("Diesel Generator1");
                }
           
        }

        private void Dg2Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            IsOnlyOneCheckboxChecked("Dg2Checkbox");
            
                var viewModel = DataContext as ReportWindowViewModel;
                if (viewModel?.RptDgCommand?.CanExecute("Diesel Generator2") == true)
                {
                    viewModel.RptDgCommand.Execute("Diesel Generator2");
                }
          
        }

        private void Router1Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            IsOnlyOneCheckboxChecked("Router1Checkbox");
            
                var viewModel = DataContext as ReportWindowViewModel;
                if (viewModel?.RptRouterCommand?.CanExecute("Router1") == true)
                {
                    viewModel.RptRouterCommand.Execute("Router1");
                }
            
        }

        private void Router2Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            IsOnlyOneCheckboxChecked("Router2Checkbox");
            
                var viewModel = DataContext as ReportWindowViewModel;
                if (viewModel?.RptRouterCommand?.CanExecute("Router2") == true)
                {
                    viewModel.RptRouterCommand.Execute("Router2");
                }
            
        }

        private void Radio1Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            IsOnlyOneCheckboxChecked("Radio1Checkbox");
            
                var viewModel = DataContext as ReportWindowViewModel;
                if (viewModel?.RptRadioCommand?.CanExecute("Radio1") == true)
                {
                    viewModel.RptRadioCommand.Execute("Radio1");
                }
            
        }

        private void Radio2Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            IsOnlyOneCheckboxChecked("Radio2Checkbox");
            
                var viewModel = DataContext as ReportWindowViewModel;
                if (viewModel?.RptRadioCommand?.CanExecute("Radio2") == true)
                {
                    viewModel.RptRadioCommand.Execute("Radio2");
                }
            
        }

        private void Switch1Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            IsOnlyOneCheckboxChecked("Switch1Checkbox");
            
                var viewModel = DataContext as ReportWindowViewModel;
                if (viewModel?.RptSwitchCommand?.CanExecute("Switch1") == true)
                {
                    viewModel.RptSwitchCommand.Execute("Switch1");
                }
            
        }

        private void Switch2Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            IsOnlyOneCheckboxChecked("Switch2Checkbox");
            
            var viewModel = DataContext as ReportWindowViewModel;
            if (viewModel?.RptSwitchCommand?.CanExecute("Switch2") == true)
            {
                viewModel.RptSwitchCommand.Execute("Switch2");
            }
            
        }

        private void UPS1Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            IsOnlyOneCheckboxChecked("UPS1Checkbox");           
            var viewModel = DataContext as ReportWindowViewModel;
            if (viewModel?.RptUpsCommand?.CanExecute("UPS1") == true)
            {
                viewModel.RptUpsCommand.Execute("UPS1");
            }
           
        }

        private void UPS2Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            IsOnlyOneCheckboxChecked("UPS2Checkbox");            
            var viewModel = DataContext as ReportWindowViewModel;
            if (viewModel?.RptUpsCommand?.CanExecute("UPS2") == true)
            {
                viewModel.RptUpsCommand.Execute("UPS2");
            }
           
        }
    }
}
