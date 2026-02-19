using LCPInfrastructure;
using LCPReportingSystem.Command;
using LCPReportingSystem.DbHelper;
using LCPReportingSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Linq;

namespace LCPReportingSystem.ViewModel
{
    public class SubSystemConfigViewModel
    {
        private ICommand _dgconfigcommand;
        private ICommand _routerconfigcommand;
        private ICommand _radioconfigcommand;
        private ICommand _switchconfigcommand;
        private ICommand _upsconfigcommand;
        private ICommand _confighelpcommand;
        private ICommand _subsysconfigeditcommand;
        private ICommand _refreshcommand;
        private ICommand _cancelpopupcommand;
        private ICommand _editsubsystemcommand;
        int IsSunSysIndex = 0;
        string SystemCOnfig = "SubSystem Configuration";
        string DgConfig = "Diesel Generator Configuration opened from SubSystem Configuration";
        string UpsConfig = "UPS Configuration opened from SubSystem Configuration";
        string RadioConfig = "Radio Configuration opened from SubSystem Configuration";
        string SwitchConfig = "Switch Configuration opened from SubSystem Configuration";
        public SubSystemConfig subSystemConfig { get; set; }
        private Utility _utility { get; set; }



        public Func<Admin> GetSubSystemConfigViewHandler { get; set; }

        public SubSystemConfigViewModel()
        {
            subSystemConfig = new SubSystemConfig();
            _utility = new Utility();
        }



        public ICommand DgConfigCommand
        {
            get
            {
                if (_dgconfigcommand == null)
                {
                    _dgconfigcommand = new RelayCommand(param => dgConfigFunction(), null);
                }
                return _dgconfigcommand;
            }
        }
        public ICommand RouterConfigCommand
        {
            get
            {
                if (_routerconfigcommand == null)
                {
                    _routerconfigcommand = new RelayCommand(Param => RouterConfigFunction(), null);
                }
                return _routerconfigcommand;
            }
        }
        public ICommand RadioConfigCommand
        {
            get
            {
                if (_radioconfigcommand == null)
                {
                    _radioconfigcommand = new RelayCommand(Param => RadioConfigFunction(), null);
                }
                return _radioconfigcommand;
            }
        }
        public ICommand SwitchConfigCommand
        {
            get
            {
                if (_switchconfigcommand == null)
                {
                    _switchconfigcommand = new RelayCommand(Param => SwitchConfigFunction(), null);
                }
                return _switchconfigcommand;
            }
        }
        public ICommand UPSConfigCommand
        {
            get
            {
                if (_upsconfigcommand == null)
                {
                    _upsconfigcommand = new RelayCommand(Param => UPSConfigFunction(), null);
                }
                return _upsconfigcommand;
            }
        }
        public ICommand ConfigHelpCommand
        {
            get
            {
                if (_confighelpcommand == null)
                {
                    _confighelpcommand = new RelayCommand(Param => ConfigHelpFunction(), null);
                }
                return _confighelpcommand;
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
        public ICommand SubSysConfigEditCommand
        {
            get
            {
                if (_subsysconfigeditcommand == null)
                {
                    _subsysconfigeditcommand = new RelayCommand(Param => SubSysConfigEditFunction(), null);
                }
                return _subsysconfigeditcommand;
            }
        }
        public ICommand RefreshCommand
        {
            get
            {
                if (_refreshcommand == null)
                {
                    _refreshcommand = new RelayCommand(Param => RefreshFunction(), null);
                }
                return _refreshcommand;
            }
        }
        public ICommand EditSubSystemCommand
        {
            get
            {
                if (_editsubsystemcommand == null)
                {
                    _editsubsystemcommand = new RelayCommand(Param => EditSubSystemConfig(), null);
                }
                return _editsubsystemcommand;
            }
        }




        public void LoadDefaultConfig()
        {
            try
            {
                dgConfigFunction();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadDefaultConfig));
            }
        }
        private void dgConfigFunction()
        {
            try
            {
                subSystemConfig.IsConfigPopupOpen = false;
                subSystemConfig.IsSubsystemDetails = false;
                subSystemConfig.SystemParamsDetails = true;
                subSystemConfig.SubSystemName = _utility.GetSubsystemName(IsSubSystem.DieselGenerator);
                IsSunSysIndex = (int)IsSubSystem.DieselGenerator;
                loadSubsystemConfiguration(IsSubSystem.DieselGenerator);
                ActivityReportDataInsertModel.SetActivityReport(SystemCOnfig, DgConfig, string.Empty);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(dgConfigFunction));
            }
        }
        private void RouterConfigFunction()
        {
            ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> Router", string.Empty);
            subSystemConfig.IsDgActive = _utility.IsMenuActiveStatus(IsMenuActiveStatus.Inactive);
            subSystemConfig.IsRouterActive = _utility.IsMenuActiveStatus(IsMenuActiveStatus.Active);
            subSystemConfig.IsRadioActive = _utility.IsMenuActiveStatus(IsMenuActiveStatus.Inactive);
            subSystemConfig.IsSwitchActive = _utility.IsMenuActiveStatus(IsMenuActiveStatus.Inactive);
            subSystemConfig.IsUpsActive = _utility.IsMenuActiveStatus(IsMenuActiveStatus.Inactive);
            subSystemConfig.IsSubsystemDetails = false;
            subSystemConfig.SystemParamsDetails = true;

            subSystemConfig.SubSystemName = _utility.GetSubsystemName(IsSubSystem.Router);
            IsSunSysIndex = (int)IsSubSystem.Router;
            loadSubsystemConfiguration(IsSubSystem.Router);


        }
        private void RadioConfigFunction()
        {
            try
            {
                subSystemConfig.IsConfigPopupOpen = false;
                subSystemConfig.IsSubsystemDetails = false;
                subSystemConfig.SystemParamsDetails = true;
                subSystemConfig.SubSystemName = _utility.GetSubsystemName(IsSubSystem.Radio);
                IsSunSysIndex = (int)IsSubSystem.Radio;
                loadSubsystemConfiguration(IsSubSystem.Radio);
                ActivityReportDataInsertModel.SetActivityReport(SystemCOnfig, RadioConfig, string.Empty);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(dgConfigFunction));
            }
        }
        private void SwitchConfigFunction()
        {
            try
            {
                subSystemConfig.IsConfigPopupOpen = false;
                subSystemConfig.IsSubsystemDetails = false;
                subSystemConfig.SystemParamsDetails = true;
                subSystemConfig.SubSystemName = _utility.GetSubsystemName(IsSubSystem.Switch);
                IsSunSysIndex = (int)IsSubSystem.Switch;
                loadSubsystemConfiguration(IsSubSystem.Switch);
                ActivityReportDataInsertModel.SetActivityReport(SystemCOnfig, SwitchConfig, string.Empty);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(dgConfigFunction));
            }
        }
        private void UPSConfigFunction()
        {
            try
            {
                subSystemConfig.IsConfigPopupOpen = false;
                subSystemConfig.IsSubsystemDetails = false;
                subSystemConfig.SystemParamsDetails = true;
                subSystemConfig.SubSystemName = _utility.GetSubsystemName(IsSubSystem.UPS);
                IsSunSysIndex = (int)IsSubSystem.UPS;
                loadSubsystemConfiguration(IsSubSystem.UPS);
                ActivityReportDataInsertModel.SetActivityReport(SystemCOnfig, UpsConfig, string.Empty);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(dgConfigFunction));
            }
        }
        private void loadSubsystemConfiguration(IsSubSystem isSubSystem)
        {
            try
            {
                var subSysConfigs = _utility.getSubSystemConfig(isSubSystem);
                if (subSysConfigs != null && subSysConfigs.Count>0)
                {
                    subSystemConfig.ConfigCollection = subSysConfigs;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(EditSubSystemConfig));
            }
        }
       
        
        
        
        
        private void ConfigHelpFunction()
        {
            ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> Help", string.Empty);
            if (!(bool)subSystemConfig.IsConfigPopupOpen)
            {
                subSystemConfig.IsConfigPopupOpen = true;
            }
        }
        private void CancelPopupFunction()
        {
            ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> Cancel", string.Empty);

            if ((bool)subSystemConfig.IsConfigPopupOpen)
            {
                subSystemConfig.IsConfigPopupOpen = false;
            }
        }
        private void SubSysConfigEditFunction()
        { 
            
            if (IsSunSysIndex == 1)
            {
                ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> EdIT(DieselGenerator)", string.Empty);

                OpenSubSystenmConfigFile(IsSubSystem.DieselGenerator);
            }
            else if (IsSunSysIndex == 2)
            {
                ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> EdIT(Router)", string.Empty);
                OpenSubSystenmConfigFile(IsSubSystem.UPS);
            }
            else if (IsSunSysIndex == 3)
            {
                ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> EdIT(Radio)", string.Empty);
                OpenSubSystenmConfigFile(IsSubSystem.Radio);
            }
            else if (IsSunSysIndex == 4)
            {
                ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> EdIT(Switch)", string.Empty);
                OpenSubSystenmConfigFile(IsSubSystem.Switch);
            }
            else if (IsSunSysIndex == 5)
            {
                ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> EdIT(UPS)", string.Empty);
                OpenSubSystenmConfigFile(IsSubSystem.Router);
            }
        }
        private void RefreshFunction()
        {
            if (IsSunSysIndex == 1)
            {
                ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> Refresh(DieselGenerator)", string.Empty);
                loadSubsystemConfiguration(IsSubSystem.DieselGenerator);
            }
            if (IsSunSysIndex == 2)
            {
                ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> Refresh(Router)", string.Empty);
                loadSubsystemConfiguration(IsSubSystem.UPS);
            }
            else if (IsSunSysIndex == 3)
            {
                ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> Refresh(Radio)", string.Empty);
                loadSubsystemConfiguration(IsSubSystem.Radio);
            }
            else if (IsSunSysIndex == 4)
            {
                ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> Refresh(Switch)", string.Empty);
                loadSubsystemConfiguration(IsSubSystem.Switch);
            }
            else if (IsSunSysIndex == 5)
            {
                ActivityReportDataInsertModel.SetActivityReport("Configuration", "Clicked on Configuration -> Refresh(UPS)", string.Empty);
                loadSubsystemConfiguration(IsSubSystem.Router);
            }
        }
        public void EditSubSystemConfig()
        {
            try
            {

                if (subSystemConfig.SubsystemNavText.Equals("Subsystem Details"))
                {
                    subSystemConfig.SubsystemNavText = "Edit Subsystems";
                    subSystemConfig.SystemParamsDetails = false;
                    subSystemConfig.IsSubsystemDetails = true;
                    subSystemConfig.SubsystemConfigCollection = LoadSubsystemDetails();
                    return;
                }
                if (subSystemConfig.SubsystemNavText.Equals("Edit Subsystems"))
                {
                    subSystemConfig.SystemParamsDetails = false;
                    subSystemConfig.IsSubsystemDetails = true;
                    string fileName = _utility.getSubSystemDirectory(IsAppService.Maintenance);
                    ProcessStartInfo processInfor = new ProcessStartInfo(fileName);
                    processInfor.Arguments = Path.GetFileName(fileName);
                    processInfor.UseShellExecute = true;
                    processInfor.WorkingDirectory = Path.GetDirectoryName(fileName);
                    processInfor.FileName = fileName;
                    processInfor.Verb = "OPEN";
                    Process.Start(processInfor);
                    subSystemConfig.SubsystemNavText = "Update Subsystems";
                    return;
                }
                if (subSystemConfig.SubsystemNavText.Equals("Update Subsystems"))
                {
                    subSystemConfig.SystemParamsDetails = false;
                    subSystemConfig.IsSubsystemDetails = true;
                    subSystemConfig.SubsystemConfigCollection = LoadSubsystemDetails();
                    subSystemConfig.SubsystemNavText = "Subsystem Details";
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(EditSubSystemConfig));
            }
        }
        public ObservableCollection<SubSystem> LoadSubsystemDetails()
        {
            ObservableCollection<SubSystem> _subsystemCollection = new ObservableCollection<SubSystem>();
            try
            {
                string[] SubSysDetails = File.ReadAllLines(_utility.getSubSystemDirectory(IsAppService.Maintenance));

                if (SubSysDetails.Length > 0)
                {
                    foreach (string subSysItem in SubSysDetails)
                    {
                        string[] LineItem = subSysItem.Split(',');
                        if (LineItem.Length > 0)
                        {
                            string source = LineItem[0].Trim();
                            string dest = LineItem[1].Trim();
                            Int32 port = Convert.ToInt32(LineItem[2].Trim());
                            Int32 trap = Convert.ToInt32(LineItem[3].Trim());
                            string filename = LineItem[4].Trim();
                            Int32 version = Convert.ToInt32(LineItem[5].Trim());
                            _subsystemCollection.Add(new SubSystem(source, dest, port, trap, filename, version));
                        }
                    }
                }
                return _subsystemCollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadSubsystemDetails));
                return null;
            }
        }
        private void OpenSubSystenmConfigFile(IsSubSystem isSubSystem)
        {
            try
            {
                string fileName = _utility.loadSubsystemConfigPath(isSubSystem);
                ProcessStartInfo processInfor = new ProcessStartInfo(fileName);
                processInfor.Arguments = Path.GetFileName(fileName);
                processInfor.UseShellExecute = true;
                processInfor.WorkingDirectory = Path.GetDirectoryName(fileName);
                processInfor.FileName = fileName;
                processInfor.Verb = "OPEN";
                Process.Start(processInfor);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(OpenSubSystenmConfigFile));
            }
        }
        
       
    }
}
