using System;
using System.Collections.Generic;
using System.IO;
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
using LCPInfrastructure;
using Microsoft.Reporting.WinForms;
using LCPReportingSystem.Model;
using LCPReportingSystem.RsDialogMessageBox;
using LCPReportingSystem.ViewModel;
using CommonLib;
using Microsoft.ReportingServices.Interfaces;
using LCPReportingSystem.DbHelper;

namespace LCPReportingSystem.UserControls
{
    /// <summary>
    /// Interaction logic for ReportWindowUserControl.xaml
    /// </summary>
    public partial class ReportWindowUserControl : UserControl
    {
       
        #region 
        public string FaultReport = "Fault";
        public string FaultReportText = "FAULT REPORT";
        public string ActivityReport = "Activity";
        public string ActivityReportText = "ACTIVITY REPORT";
        public string TabularReportText = "SUBSYSTEM REPORT";
       

        public const string PDFText = "PDF";
        public const string ExcelOpenText = "EXCELOPENXML";
        public const string WordOpenText = "WORDOPENXML";

        public string pdfExtensionText = "pdf";
        public string ExcelExtensionText = "xlsx";
        public string WordExtensionText = "docx";
        string ReportType=string.Empty;
        string SubSystemName = string.Empty;
       public  ReportWindowViewModel reportWindowViewModel;
        #endregion   
       
        
        public ReportWindowUserControl(string TagValue)
        {
            InitializeComponent();

            try
            {
                ReportType = TagValue;
                //Set Title
                todateTimePicker.Value = DateTime.Now;
                //DisplaySubSystemBoarder.Visibility = Visibility.Visible;
                SubsystemPanel.Visibility = Visibility.Collapsed;
                SNMPTypePanel.Visibility = Visibility.Collapsed;
                if (TagValue == FaultReport)
                {
                    txtWindowName.Text = FaultReportText;
                    SubsystemPanel.Visibility = Visibility.Visible;
                }
                else if (TagValue == ActivityReport)
                {

                    txtWindowName.Text = ActivityReportText;
                    //DisplaySubSystemBoarder.Visibility = Visibility.Collapsed;         
                }
                else
                {
                    txtWindowName.Text = TabularReportText;
                    SNMPTypePanel.Visibility = Visibility.Visible;
                    SubsystemPanel.Visibility = Visibility.Visible; ;
                }



                //Set DataContext
                reportWindowViewModel = new ReportWindowViewModel(TagValue, this);
                this.DataContext = reportWindowViewModel;



                //Set Exercise Types
                if (UsageConstants.exerciseTypes.Count > 0)
                {
                    cmbExerciseType.ItemsSource = UsageConstants.exerciseTypes;
                    cmbExerciseType.SelectedValue = UsageConstants.DefaultExerciseItem;
                }
                cmbSubsystem.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ReportWindowUserControl));
            }
          
        
        }
        private void cmbExerciseType_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (cmbExerciseType.SelectedValue.ToString() == UsageConstants.DefaultExerciseItem)
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
                    reportWindowViewModel.reports.RptSeletedToDate = (DateTime)todateTimePicker.Value;
                    fromdateTimePicker.IsEnabled = false;
                    todateTimePicker.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(cmbExerciseType_SelectionChanged));
            }

        }
        private void cmbSubsystem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbSubsystem.SelectedItem != null)
            {
                var selectedItem = cmbSubsystem.SelectedItem as ComboBoxItem;
                var viewModel = DataContext as ReportWindowViewModel;
                if (string.Equals(selectedItem.Content.ToString(), UsageConstants.DieselGenerator1Text))
                {
                    if (viewModel?.RptDgCommand?.CanExecute(UsageConstants.DieselGenerator1Text) == true)
                    {
                        viewModel.RptDgCommand.Execute(UsageConstants.DieselGenerator1Text);
                    }
                }
                else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.DieselGenerator2Text))
                {
                    if (viewModel?.RptDgCommand?.CanExecute(UsageConstants.DieselGenerator2Text) == true)
                    {
                        viewModel.RptDgCommand.Execute(UsageConstants.DieselGenerator2Text);
                    }
                }
                else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Radio1Text))
                {
                    if (viewModel?.RptRadioCommand?.CanExecute(UsageConstants.Radio1Text) == true)
                    {
                        viewModel.RptRadioCommand.Execute(UsageConstants.Radio1Text);
                    }
                }
                else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Radio2Text))
                {
                    if (viewModel?.RptRadioCommand?.CanExecute(UsageConstants.Radio2Text) == true)
                    {
                        viewModel.RptRadioCommand.Execute(UsageConstants.Radio2Text);
                    }
                }
                else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Switch1Text))
                {
                    if (viewModel?.RptSwitchCommand?.CanExecute(UsageConstants.Switch1Text) == true)
                    {
                        viewModel.RptSwitchCommand.Execute(UsageConstants.Switch1Text);
                    }
                }
                else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Switch2Text))
                {
                    if (viewModel?.RptSwitchCommand?.CanExecute(UsageConstants.Switch2Text) == true)
                    {
                        viewModel.RptSwitchCommand.Execute( UsageConstants.Switch2Text);
                    }
                }
                else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.UPS1Text))
                {
                    if (viewModel?.RptUpsCommand?.CanExecute(UsageConstants.UPS1Text) == true)
                    {
                        viewModel.RptUpsCommand.Execute(UsageConstants.UPS1Text);
                       
                    }
                    
                }
                else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.UPS2Text))
                {
                    if (viewModel?.RptUpsCommand?.CanExecute(UsageConstants.UPS2Text) == true)
                    {
                        viewModel.RptUpsCommand.Execute(UsageConstants.UPS2Text);
                       
                    }
                }
            }
        }
        private void RsReportViewer_ReportExport(object sender, Microsoft.Reporting.WinForms.ReportExportEventArgs e)
        {
            try
            {                
                string exportFormat = e.Extension.Name.ToUpper(); 
                e.Cancel = true; 
                string extension;
                switch (exportFormat)
                {
                    case PDFText:
                        extension = pdfExtensionText;
                        break;
                    case ExcelOpenText:
                        extension = ExcelExtensionText;
                        break;
                    case WordOpenText:
                        extension = WordExtensionText;
                        break;
                    default:
                        extension = exportFormat.ToLower();
                        break;
                }

                var selectedItem = cmbSubsystem.SelectedItem as ComboBoxItem;
                string defaultFileName=string.Empty;
                if (ReportType==ActivityReport)
                {
                     defaultFileName = $"{ActivityReport}_{DateTime.Now:yyyyMMdd_HHmmss}.{extension}";
                }
                else if(ReportType == FaultReport)
                {
                    defaultFileName = $"{selectedItem.Content.ToString()}_FaultReport_{DateTime.Now:yyyyMMdd_HHmmss}.{extension}";
                }
                else
                {
                    string snmpType = reportWindowViewModel.reports.IsNonTrap ? reportWindowViewModel.reports.SnmpNonTrapName : reportWindowViewModel.reports.SnmpTrapName;
                    defaultFileName = $"{selectedItem.Content.ToString()}_{snmpType}_Report_{DateTime.Now:yyyyMMdd_HHmmss}.{extension}";
                }
                 
                string defaultDirectory = System.IO.Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName,@"Settings\Reports");

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

                ActivityReportDataInsertModel.SetActivityReport(ReportType +" Report", "Report Exported as : "+ defaultFileName, string.Empty);
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

                RsDialogBox.ShowMsg("Report exported SuccessFully", "Reports", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (DllNotFoundException ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RsReportViewer_ReportExport));
            }
            catch (AccessViolationException ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RsReportViewer_ReportExport));
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RsReportViewer_ReportExport));
            }
        }         
        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FiltersBorder.Visibility == Visibility.Visible)
                { FiltersBorder.Visibility = Visibility.Collapsed; return; }

                if (FiltersBorder.Visibility == Visibility.Collapsed)
                { FiltersBorder.Visibility = Visibility.Visible; return; }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(FilterButton_Click));
            }
        }
        
    }
}
