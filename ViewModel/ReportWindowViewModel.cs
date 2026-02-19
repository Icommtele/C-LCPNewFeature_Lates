using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using CommonLib;
using LCPInfrastructure;
using LCPReportingSystem.Command;
using LCPReportingSystem.DbHelper;
using LCPReportingSystem.Model;
using LCPReportingSystem.RsDialogMessageBox;
using LCPReportingSystem.UserControls;
using LCPReportingSystem.WindowForm;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using Xceed.Wpf.Toolkit;

namespace LCPReportingSystem.ViewModel
{
    public class ReportWindowViewModel
    {
        #region
        private ICommand _rptclosecommand;
        private ICommand _rptdgcommand;
        private ICommand _rptroutercommand;
        private ICommand _rptradiocommand;
        private ICommand _rptswitchcommand;
        private ICommand _rptupscommand;
        private ICommand _rptfilterreportcommand;
        private ICommand _rpthelpcommand;
        private ICommand _cancelpopupcommand;

        int? IsSubSysIndex = null;
        string reportsMode = string.Empty;
        public Reports reports { get; set; }
        private Admin _admin { get; set; }
        private Utility _utility { get; set; }
        private ReportWindowUserControl _window { get; set; }
        private LocalReport _Report { get; set; }
        private ReportViewer _reportviewer { get; set; }



        public string reportsText = "Reports";

        public string Text = "No data found";

        public string DsActivity = "DSActivityCollection";
        public string DsActivityPath = "LCPReportingSystem.RdlcReports.ActiveRsRptSubSystem.rdlc";


        public string DsArchive = "DsArchiveCollection";
        public string DsArchivePath = "LCPReportingSystem.RdlcReports.RsRptSubSystem.rdlc";



        public string DsTrap = "DsTrapCollection";
        public string DsTrapPath = "LCPReportingSystem.RdlcReports.RsRptSubsystemTrap.rdlc";



        public string DsFault = "DsFaultCollection";
        public string DsFaultPath = "LCPReportingSystem.RdlcReports.RsRptSubSystemFaultData.rdlc";

        string DateFormat = "yyyy-MM-dd";
        string DateTimeFormat = "dd-MM-yyyy HH:mm:ss";
        public string FromDateLessText = "The From date should be less than or equal to the To date).";
        public string SelectSubSystemText = "Please select the subsystem name from the menu.";

        #endregion

        public ReportWindowViewModel(string ReportMode, ReportWindowUserControl reportwindow = null)
        {
            reports = new Reports();
            _utility = new Utility();
            this.reportsMode= ReportMode;
            _window = reportwindow;
            this._reportviewer = reportwindow.RsReportViewer;
           
        }
       




        public ICommand RptCloseCommand
        {
            get
            {
                if (_rptclosecommand == null)
                {
                    _rptclosecommand = new RelayCommand(param => RptLoadColseFunction(), null);
                }
                return _rptclosecommand;
            }
        }
        public ICommand RptDgCommand
        {
            get
            {
                if (_rptdgcommand == null)
                {
                    _rptdgcommand = new RelayCommand(param => RptLoadDgFunation(param), null);
                }
                return _rptdgcommand;
            }
        }
        public ICommand RptRouterCommand
        {
            get
            {
                if (_rptroutercommand == null)
                {
                    _rptroutercommand = new RelayCommand(param => RptLoadRouterFunation(param), null);
                }
                return _rptroutercommand;
            }
        }
        public ICommand RptRadioCommand
        {
            get
            {
                if (_rptradiocommand == null)
                {
                    _rptradiocommand = new RelayCommand(param => RptLoadRadioFunation(param), null);
                }
                return _rptradiocommand;
            }
        }
        public ICommand RptSwitchCommand
        {
            get
            {
                if (_rptswitchcommand == null)
                {
                    _rptswitchcommand = new RelayCommand(param => RptLoadSwitchFunation(param), null);
                }
                return _rptswitchcommand;
            }
        }
        public ICommand RptUpsCommand
        {
            get
            {
                if (_rptupscommand == null)
                {
                    _rptupscommand = new RelayCommand(param => RptLoadUpsFunation(param), null);
                }
                return _rptupscommand;
            }
        }
        public ICommand RptFilterReportCommand
        {
            get
            {
                if (_rptfilterreportcommand == null)
                {
                    _rptfilterreportcommand = new RelayCommand(param => GenerateReports(), null);
                }
                return _rptfilterreportcommand;
            }
        }
        public ICommand RptHelpCommand
        {
            get
            {
                if (_rpthelpcommand == null)
                {
                    _rpthelpcommand = new RelayCommand(param => RptHelpFunction(), null);
                }
                return _rpthelpcommand;
            }
        }
        public ICommand CancelPopupCommand
        {
            get
            {
                if (_cancelpopupcommand == null)
                {
                    _cancelpopupcommand = new RelayCommand(Param => CancelPopupFunction(), null);
                }
                return _cancelpopupcommand;
            }
        }

        public void SetDeFaultReport()
        {
            try
            {
                LoadReportsDefault();
                LoadExerciseTypeData();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SetDeFaultReport));
            }
        }

        private void RptLoadDgFunation(object param)
        {
            try
            {
                if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
                    IsSubSysIndex = (int)IsSubSystem.DieselGenerator2;
                else
                    IsSubSysIndex = (int)IsSubSystem.DieselGenerator;

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RptLoadDgFunation));
            }
        }
        private void RptLoadRouterFunation(object param)
        {

            if (param.ToString() == "Router2")
            {
                IsSubSysIndex = (int)IsSubSystem.Router2;
            }
            else
            {
                IsSubSysIndex = (int)IsSubSystem.Router;
            }
        }
        private void RptLoadRadioFunation(object param)
        {
            try
            {
                if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
                    IsSubSysIndex = (int)IsSubSystem.Radio2;
                else
                    IsSubSysIndex = (int)IsSubSystem.Radio;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RptLoadRadioFunation));
            }
        }
        private void RptLoadSwitchFunation(object param)
        {
            try
            {
                if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
                    IsSubSysIndex = (int)IsSubSystem.Switch2;
                else
                    IsSubSysIndex = (int)IsSubSystem.Switch;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RptLoadSwitchFunation));
            }
        }
        private void RptLoadUpsFunation(object param)
        {
            try
            {
                if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
                    IsSubSysIndex = (int)IsSubSystem.UPS2;
                else
                    IsSubSysIndex = (int)IsSubSystem.UPS;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RptLoadUpsFunation));
            }

        }
        private void RptHelpFunction()
        {
            if (!(bool)reports.IsReportPopupOpen)
            {
                reports.IsReportPopupOpen = true;
            }
        }
        private void CancelPopupFunction()
        {
            if ((bool)reports.IsReportPopupOpen)
            {
                reports.IsReportPopupOpen = false;
            }
        }
        private void RptLoadColseFunction()
        {
            ReportWindow _reportwindow = Application.Current.Windows.OfType<ReportWindow>().SingleOrDefault(window => window.IsActive);
            _reportwindow.Close();
        }




        private void LoadExerciseTypeData()
        {
            try
            {
                if (UsageConstants.exerciseTypes.Count == 0)
                {
                    var list = _utility.Getexercisetypes();

                    UsageConstants.exerciseTypes = list;
                    UsageConstants.exerciseTypes.Add(UsageConstants.DefaultExerciseItem);
                    _window.cmbExerciseType.ItemsSource = UsageConstants.exerciseTypes;
                    _window.cmbExerciseType.SelectedValue = UsageConstants.DefaultExerciseItem;
                }
               
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadExerciseTypeData));
            }

        }
        public List<ExerciseTimeRange> LoadExerciseDateTime_Type(string exrType)
        {
            try
            {
                var list = _utility.GetexercisetypeTimeRange(exrType);

                return list;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadExerciseDateTime_Type));
            }
            return null;
        }
        private void LoadReportsDefault()
        {
            try
            {
                reports.RptSeletedFromDate = DateTime.Now.AddHours(-23).AddMinutes(59);
                reports.RptSeletedToDate = DateTime.Now;
                reports.IsReportViewEnable = false;
                reports.IsReportPopupOpen = false;
                reports.IsNonTrap = true;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadReportsDefault));
            }
        }
        private void GenerateReports()
        {
            try
            {
                if (IsSubSysIndex <= 0)
                {
                    RsDialogBox.ShowMsg(SelectSubSystemText, reportsText, MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }


                if ((reports.RptSeletedFromDate > reports.RptSeletedToDate))
                {
                    RsDialogBox.ShowMsg(FromDateLessText, reportsText, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }


                if (!UsageConstants.SubsystemCollectionNumber.TryGetValue((int)IsSubSysIndex, out var subsystem))
                    return;
                
                string fromDate = reports.RptSeletedFromDate.ToString(DateTimeFormat).Trim();
                string toDate = reports.RptSeletedToDate.ToString(DateTimeFormat).Trim();
               
                if (string.Equals(reportsMode, _window.ActivityReport))
                {
                    Generate_ActivityReports(fromDate, toDate);
                    return;
                }

                if (string.Equals(this.reportsMode, _window.FaultReport))
                {
                    Generate_FaultReports(subsystem, fromDate, toDate);
                    return;
                }

                if (reports.IsNonTrap)
                {
                    Generate_NonTrapReports(subsystem, fromDate, toDate);
                    return;
                }

                if (reports.IsTrap)
                {
                    Generate_TrapReports(subsystem, fromDate, toDate);
                    return;
                }
                string snmpType = reports.IsNonTrap ? reports.SnmpNonTrapName : reports.SnmpTrapName;

                ActivityReportDataInsertModel.SetActivityReport(this.reportsMode + " Report", subsystem.ToString() + "_" + snmpType + " Report Generated.", string.Empty);

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GenerateReports));
            }
        }
        public void Generate_ActivityReports(string fromDate, string toDate)
        {
            try
            {
                if (!string.Equals(reportsMode, _window.ActivityReport))
                    return;

                 string ExerciseType=string.Empty;
                //DateTime fromDateTime = DateTime.Parse(fromDate);
                //DateTime toDateTime = DateTime.Parse(toDate);

                //string fromdate = fromDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                //string todate = toDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                ExerciseType=reports.ExerciseType;
                var activityReportCollection = _utility.GetActivityData_Collection(fromDate, toDate);

                if (activityReportCollection == null || activityReportCollection.Count == 0)
                {
                    reports.IsReportViewEnable = false;
                    RsDialogBox.ShowMsg(UsageConstants.NodataDatesText, reportsText, MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                // Configure report viewer
                _reportviewer.Reset();
                reports.IsReportViewEnable = true;

                var reportDataSource = new ReportDataSource(DsActivity, activityReportCollection);
                _reportviewer.LocalReport.DataSources.Add(reportDataSource);
                _reportviewer.LocalReport.ReportEmbeddedResource = DsActivityPath;

                // Example parameters (replace with actual dynamic values if needed)
                ReportParameter[] reportParameters =
                {
                    new ReportParameter("Activity_Id", "1"),
                    new ReportParameter("Activity_Type", "abc"),
                    new ReportParameter("Activity_Datetime", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")),
                    new ReportParameter("Activity_Info", "abc"),
                    new ReportParameter("Username", "abc"),
                    new ReportParameter("FromDate", reports.RptSeletedFromDate.ToString("dd-MM-yyyy HH:mm:ss")),
                    new ReportParameter("ToDate", reports.RptSeletedToDate.ToString("dd-MM-yyyy HH:mm:ss")),
                    new ReportParameter("ExerciseType",_window.cmbExerciseType.Text)
                };

                _reportviewer.LocalReport.SetParameters(reportParameters);
                _reportviewer.RefreshReport();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(Generate_ActivityReports));
            }
        }
        public void Generate_FaultReports(IsSubSystem isSubSystem, string fromDate, string toDate)
        {
            try
            {
                if (!string.Equals(reportsMode, _window.FaultReport))
                    return;
                string ExerciseType = string.Empty;
                //DateTime fromDateTime = DateTime.Parse(fromDate);
                //DateTime toDateTime = DateTime.Parse(toDate);

                //string fromdate = fromDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                //string todate = toDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                ExerciseType = reports.ExerciseType;
                var faultfilterCollection = _utility.GetFaultData_Collection(isSubSystem, fromDate, toDate);

                if (faultfilterCollection == null || faultfilterCollection.Count == 0)
                {
                    reports.IsReportViewEnable = false;
                    RsDialogBox.ShowMsg(UsageConstants.NodataDatesText, reportsText, MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                // Configure report viewer
                _reportviewer.Reset();
                reports.IsReportViewEnable = true;

                ReportDataSource reportDataSource = new ReportDataSource(DsFault, faultfilterCollection);
                _reportviewer.LocalReport.DataSources.Add(reportDataSource);
                _reportviewer.LocalReport.ReportEmbeddedResource = DsFaultPath;

                // Example values for parameters (replace if dynamic later)
                string subsystemIp = "192.168.10.137";
                int faultId = 123;

                ReportParameter[] reportParameters =
                {
                    new ReportParameter("Id", faultId.ToString()),
                    new ReportParameter("SubSystem", _utility.GetSubsystemName(isSubSystem)),
                    new ReportParameter("SubsystemIp", subsystemIp),
                    new ReportParameter("FromDate", reports.RptSeletedFromDate.ToString("yyyy-MM-dd HH:mm:ss")),
                    new ReportParameter("ToDate", reports.RptSeletedToDate.ToString("yyyy-MM-dd HH:mm:ss")),
                    new ReportParameter("Status", "All"),
                    new ReportParameter("DurationInMinutes", "60"),
                    new ReportParameter("ExerciseType", _window.cmbExerciseType.Text)
                };

                _reportviewer.LocalReport.SetParameters(reportParameters);
                _reportviewer.RefreshReport();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(Generate_FaultReports));
            }
        }
        private void Generate_NonTrapReports(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            try
            {
                ObservableCollection<ArchiveEntity> filterCollection = _utility.GetNonTrapReportData_Collection(isSubSystem, FromDate, ToDate);

                if (filterCollection == null || filterCollection.Count == 0)
                {
                    reports.IsReportViewEnable = false;
                    RsDialogBox.ShowMsg(UsageConstants.NodataDatesText, reportsText, MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                _reportviewer.Reset();
                reports.IsReportViewEnable = true;
                ReportDataSource reportDataSource = new ReportDataSource(DsArchive, filterCollection);
                _reportviewer.LocalReport.DataSources.Add(reportDataSource);
                _reportviewer.LocalReport.ReportEmbeddedResource = DsArchivePath;

                string snmpType = reports.IsNonTrap ? reports.SnmpNonTrapName : reports.SnmpTrapName;
                ReportParameter[] reportParameters = new ReportParameter[]
                {
                    new ReportParameter("SubSystemName", _utility.GetSubsystemName(isSubSystem).ToUpper()),
                    new ReportParameter("ReportDate", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")),
                    new ReportParameter("Fromdate", reports.RptSeletedFromDate.ToString("dd-MM-yyyy HH:mm:ss")),
                    new ReportParameter("Todate", reports.RptSeletedToDate.ToString("dd-MM-yyyy HH:mm:ss")),
                    new ReportParameter("SnmpType", snmpType),
                    new ReportParameter("ExerciseType", reports.ExerciseType)
                };

                _reportviewer.LocalReport.SetParameters(reportParameters);
                _reportviewer.RefreshReport();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(Generate_NonTrapReports));
            }
        }
        private void Generate_TrapReports(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            try
            {
                ObservableCollection<TrapEntity> filterTrapCollection = _utility.GetTrapReportData_Collection(isSubSystem, FromDate, ToDate);
                ObservableCollection<TrapTypeSummary> trapTypeCountCollection = _utility.TrapTypeSummaryCollection(isSubSystem, FromDate, ToDate);
                var footerSummaryList = GetFooterSummary(trapTypeCountCollection);

                if (filterTrapCollection == null || filterTrapCollection.Count == 0)
                {
                    reports.IsReportViewEnable = false;
                    RsDialogBox.ShowMsg(UsageConstants.NodataText, reportsText, MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                // Reset and configure report viewer
                _reportviewer.Reset();
                reports.IsReportViewEnable = true;

                ReportDataSource reportDataSource = new ReportDataSource(DsTrap, filterTrapCollection);
                _reportviewer.LocalReport.DataSources.Add(reportDataSource);
                // _reportviewer.LocalReport.DataSources.Add(new ReportDataSource("DsTrapCountSummary", footerSummaryList));
                _reportviewer.LocalReport.ReportEmbeddedResource = DsTrapPath;

                string snmpType = reports.IsNonTrap ? reports.SnmpNonTrapName : reports.SnmpTrapName;

                ReportParameter[] reportParameters = new ReportParameter[]
                {
                    new ReportParameter("SubsystemName", _utility.GetSubsystemName(isSubSystem)),
                    new ReportParameter("ReportDate", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")),
                    new ReportParameter("Fromdate", reports.RptSeletedFromDate.ToString("dd-MM-yyyy HH:mm:ss")),
                    new ReportParameter("Todate", reports.RptSeletedToDate.ToString("dd-MM-yyyy HH:mm:ss")),
                    new ReportParameter("SnmpType", snmpType),
                    new ReportParameter("ExerciseType", reports.ExerciseType),
                    new ReportParameter("TrapSummary", footerSummaryList)
                };

                _reportviewer.LocalReport.SetParameters(reportParameters);
                _reportviewer.RefreshReport();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(Generate_TrapReports));
            }
        }
        public string GetFooterSummary(ObservableCollection<TrapTypeSummary> trapSummaryList)
        {
            if (trapSummaryList.Any())
            {
                return string.Join("\r\n", trapSummaryList.Select(t => $"{t.TrapType}: {t.Count}"));
            }
            return string.Empty;
        }


    }
}
