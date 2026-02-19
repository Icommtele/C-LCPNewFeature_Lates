using LCPReportingSystem.Command;
using LCPReportingSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LCPReportingSystem.DAL;
using LCPReportingSystem.Model;
using LCPReportingSystem.DbHelper;
using System.IO;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Diagnostics;
using System.Reflection.Emit;
using LCPInfrastructure;
using CommonLib;

namespace LCPReportingSystem.ViewModel
{
    public class SettingViewModel : Window
    {
        public bool IsOptiondgSelected { get; set; }
        public bool IsOptionupsSelected { get; set; }

        private ICommand _cancelpopupcommand;
        private ICommand _Syncinfocommand;
        private ICommand _Radiocommand;
        private ICommand _DiGencommand;
        public string DataSyncText = " Data is sync successfully !!!";

        private Setting setting;
        private DataAccessLayer _layer;
        private DbContext _dbContext;
        string radioContent;

        public SettingViewModel(Setting setting)
        {
            this.setting = setting;
        }

        //public event EventHandler RequestClose;
        public ICommand LinegraphCancelCommand
        {
            get
            {
                if (_cancelpopupcommand == null)
                {
                    _cancelpopupcommand = new RelayCommand(param => ClosePopUp(), null);
                }
                return _cancelpopupcommand;
            }
        }
        public ICommand LinegraphSyncInfoCommand
        {
            get
            {
                if (_Syncinfocommand == null)
                {
                    _Syncinfocommand = new RelayCommand(param => SyncInfoCommand(), null);
                }
                return _Syncinfocommand;
            }
        }
        public ICommand RadioInfoCommand
        {
            get
            {
                if (_Radiocommand == null)
                {
                    _Radiocommand = new RelayCommand(param => Radio_Checked(param), null);

                    _Radiocommand = new RelayCommand(param =>
                    {
                        radioContent = Radio_Checked(param);
                    }, null);
                }
                return _Radiocommand;
            }
        }

        public ICommand DgInfoCommand
        {
            get
            {
                if (_DiGencommand == null)
                {
                    _DiGencommand = new RelayCommand(param => Radio_Checked(param), null);

                    _DiGencommand = new RelayCommand(param =>
                    {
                        radioContent = Radio_Checked(param);
                    }, null);
                }
                return _DiGencommand;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        private string Radio_Checked(object sender)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.IsChecked.HasValue && radioButton.IsChecked.Value)
            {
                return radioButton.Content.ToString();
            }
            else
            {
                radioButton.IsChecked = false;
                return radioButton.Content.ToString();
            }
        }
        private void ClosePopUp()
        {
            try
            {
                Setting IsactiveMainWin = Application.Current.Windows.OfType<Setting>().SingleOrDefault(window => window.IsActive);
                IsactiveMainWin.Close();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ClosePopUp));
            }
        }
        private void SyncInfoCommand()
        {
            if (radioContent == Convert.ToString(UsageConstants.DieselGeneratorText))
            {
                ReadSubSystemFile(IsSubSystem.DieselGenerator);
                MessageBox.Show(radioContent + DataSyncText,"SubSystem",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else if (radioContent == Convert.ToString(IsSubSystem.UPS))
            {
                ReadSubSystemFile(IsSubSystem.UPS);
                MessageBox.Show(radioContent + DataSyncText, "SubSystem", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (radioContent == Convert.ToString(IsSubSystem.Router))
            {
                ReadSubSystemFile(IsSubSystem.Router);
                MessageBox.Show(radioContent + DataSyncText, "SubSystem", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (radioContent == Convert.ToString(IsSubSystem.Switch))
            {
                ReadSubSystemFile(IsSubSystem.Switch);
                MessageBox.Show(radioContent + DataSyncText, "SubSystem", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (radioContent == Convert.ToString(IsSubSystem.Radio))
            {
                ReadSubSystemFile(IsSubSystem.Radio);
                MessageBox.Show(radioContent + DataSyncText, "SubSystem", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private string ReadSubSystemFile(IsSubSystem isSubSystem)
        {
            string getFilePath = string.Empty;
            _layer = new DataAccessLayer();
            _dbContext = new DbContext();
            try
            {

                if (string.IsNullOrEmpty(getFilePath))
                {
                    getFilePath = _layer.getSubSystemConfigPath(isSubSystem);
                    string[] SubSysConfigCollection = File.ReadAllLines(getFilePath)
                                               .Select(line => line.Trim())
                                               .ToArray();

                    string SubsystemInfo = _layer.getSubSystemName(isSubSystem);
                    string[] SubSystem = SubsystemInfo.Split(',');

                    foreach (var item in SubSysConfigCollection)
                    {
                        string[] SubSystemInfo = item.Split(',');

                        _layer.SetSubsystemParmsDetailsInfo(SubSystem[0], SubSystem[1], SubSystemInfo);
                    }


                }
                return getFilePath;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ReadSubSystemFile));
                return null;
            }
        }



    }
}
