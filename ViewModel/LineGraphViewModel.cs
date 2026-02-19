using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using LCPReportingSystem.Command;
using LCPReportingSystem.Model;
using LCPReportingSystem.RsDialogMessageBox;
using System.Diagnostics;
using System.IO;
using LCPReportingSystem.View;
using LCPInfrastructure;
using LiveCharts.Wpf;
using LiveCharts;
using CommonLib;

namespace LCPReportingSystem.ViewModel
{
    public class LineGraphViewModel: ViewModelBase
    {

        private ICommand _lngdgcommand;
        private ICommand _lngroutercommand;
        private ICommand _lngradiocommand;
        private ICommand _lngswitchcommand;
        private ICommand _lngupscommand;
        private ICommand _lngfiltercommand;
        private ICommand _linegraphhelpcommand;
        private ICommand _cancelpopupcommand;
        private ICommand _Settingcommand;
       
        string LineGraphText = "Line Graph";

      public  int lngSubSystemIndex = 0;
        public LineGraph LineGraph { get; set; }

        private Utility _utility { get; set; }
        public LineGraphViewModel()
        {
            LineGraph = new LineGraph();
            _utility = new Utility();         
        }
        /// <summary>
        /// 
        /// </summary>
        public ICommand LngDgCommand
        {
            get
            {
                if (_lngdgcommand == null)
                {
                    _lngdgcommand = new RelayCommand(param => LoadLngDgFunction(param), null);
                }
                return _lngdgcommand;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public ICommand LngRouterCommand
        {
            get
            {
                if (_lngroutercommand == null)
                {
                    _lngroutercommand = new RelayCommand(param => LoadLngRouterFunction(param), null);
                }
                return _lngroutercommand;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public ICommand LngRadioCommand
        {
            get
            {
                if (_lngradiocommand == null)
                {
                    _lngradiocommand = new RelayCommand(param => LoadLngRadioFunction(param), null);
                }
                return _lngradiocommand;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public ICommand LngSwitchCommand
        {
            get
            {
                if (_lngswitchcommand == null)
                {
                    _lngswitchcommand = new RelayCommand(param => LoadLngSwitchFunction(param), null);
                }
                return _lngswitchcommand;
            }
        }
        public ICommand LngUpsCommand
        {
            get
            {
                if (_lngupscommand == null)
                {
                    _lngupscommand = new RelayCommand(param => LoadLngUpsFunction(param), null);
                }
                return _lngupscommand;
            }
        }
        public ICommand LngFilterCommand
        {
            get
            {
                if (_lngfiltercommand == null)
                {
                    _lngfiltercommand = new RelayCommand(param => GetLngFilterFunction(), null);
                }
                return _lngfiltercommand;
            }
        }
        public ICommand LinegraphHelpCommand
        {
            get
            {
                if (_linegraphhelpcommand == null)
                {
                    _linegraphhelpcommand = new RelayCommand(param => LinegraphHelpFunction(), null);
                }
                return _linegraphhelpcommand;
            }
        }
        public ICommand SettingCommand
        {
            get
            {
                if (_Settingcommand == null)
                {
                    _Settingcommand = new RelayCommand(param => LinegrapsettingFunction(), null);
                }
                return _Settingcommand;
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



        public void SetDeafaultGraphicalReport()
        {
            try
            {
                LoadLineGraphDefault();
                LoadExerciseTypeData();
                LoadParmsCombo(IsSubSystem.DieselGenerator, 1);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SetDeafaultGraphicalReport));
            }
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
        private void LoadLngDgFunction(object param)
        { 
            if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
            {
                lngSubSystemIndex = (int)IsSubSystem.DieselGenerator2;
            }
            else
            {
                lngSubSystemIndex = (int)IsSubSystem.DieselGenerator;
            }
            LoadParmsCombo(IsSubSystem.DieselGenerator,1);
        }
        private void LoadLngRouterFunction(object param)
        {    

            if (param.ToString() == "Router2")
            {
                lngSubSystemIndex = (int)IsSubSystem.Router2;
            }
            else
            {
                lngSubSystemIndex = (int)IsSubSystem.Router;
            }
            LoadParmsCombo(IsSubSystem.Router, 5 );
        }
        private void LoadLngRadioFunction(object param)
        {
            if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
            {
                lngSubSystemIndex = (int)IsSubSystem.Radio2;
            }
            else
            {
                lngSubSystemIndex = (int)IsSubSystem.Radio;
            }
            LoadParmsCombo(IsSubSystem.Radio, 3);
        }
        private void LoadLngSwitchFunction(object param)
        {           
            if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
            {
                lngSubSystemIndex = (int)IsSubSystem.Switch2;
            }
            else
            {
                lngSubSystemIndex = (int)IsSubSystem.Switch;
            }
            LoadParmsCombo(IsSubSystem.Switch, 4);
        }
        private void LoadLngUpsFunction(object param)
        {

            if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
            {
                lngSubSystemIndex = (int)IsSubSystem.UPS2;
            }
            else
            {
                lngSubSystemIndex = (int)IsSubSystem.UPS;
            }
            LoadParmsCombo(IsSubSystem.UPS, 2);
        }

       
        /// <summary>
        /// 
        /// </summary>
        public Func<List<string>> DataHandler { get; set; }
        public List<string> DataList = new List<string>();
        private void GetLngFilterFunction()
           {
            try
            {
                DataList = DataHandler();
                if(DataList.Count > 0)
                {
                    if (DataList.Count > 3)
                    {
                        RsDialogBox.ShowMsg("Please select only Three Values in Select Parameter Combobox", LineGraphText, MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        if (lngSubSystemIndex != null)
                        {
                            LoadLineGraph(UsageConstants.SubsystemCollectionNumber[(int)lngSubSystemIndex]);                            
                        }
                        else
                        {
                            RsDialogBox.ShowMsg("Please select the subsystem name from the menu.", LineGraphText, MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    RsDialogBox.ShowMsg("Please Select Parameter in Combobox", LineGraphText, MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetLngFilterFunction));
            }
           
        }
        private void LinegraphHelpFunction()
        {
            if (!(bool)LineGraph.IsLineGraphPopupOpen)
            {
                LineGraph.IsLineGraphPopupOpen = true;
            }
        }
        private void LinegrapsettingFunction()
        {
            Setting Linegrapsetting = new Setting();
            Linegrapsetting.ShowDialog();
        }
        private void CancelPopupFunction()
        {
            if ((bool)LineGraph.IsLineGraphPopupOpen)
            {
                LineGraph.IsLineGraphPopupOpen = false;
            }
        }

        private Dictionary<string, object> _items;
        private Dictionary<string, object> _selectedItems;


        public Dictionary<string, object> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        public Dictionary<string, object> SelectedItems
        {
            get
            {
                return _selectedItems;
            }
            set
            {
                _selectedItems = value;
                OnPropertyChanged("SelectedItems");
            }
        }
        public Action<Dictionary<string, object>> setItemSourceHandler { get; set; }
        private void LoadParmsCombo(IsSubSystem isSubSystem, int SubsystemId)
        {
            try
            {
                ObservableCollection<ArchiveEntity> ParamCollection = null;
                if (ParamCollection == null)
                {
                    ParamCollection = _utility.getArchiveCollection(isSubSystem, IsSqlFlag.GetParameters, IsRequestType.BindByCombo, SubsystemId);

                    if (ParamCollection != null)
                    {
                        LineGraph.PrameterCollection = ParamCollection;

                        Items = new Dictionary<string, object>();
                        SelectedItems = new Dictionary<string, object>();
                        int increment = 0;
                        foreach (var item in ParamCollection)
                        {
                            Items.Add(item.ParameterName, increment);
                            increment++;
                            if (SelectedItems.Count == 0)
                                SelectedItems.Add(item.ParameterName, increment);
                        }
                        SelectedItems.Clear();
                        if (setItemSourceHandler!=null && Items.Count>0)
                        setItemSourceHandler(Items);
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadParmsCombo));
            }

        }
       
       public Action<Dictionary<string, object>> setValuesHandler { get; set; }
        private void LoadLineGraph(IsSubSystem isSubSystem)
        {
            Dictionary<string, object> data_list = new Dictionary<string, object>();
            List<string> invalidStrings = new List<string>();
            ObservableCollection<ArchiveData> LineGraphCollection = null;
            string lngFromdate = string.Empty;
            string lngTodate = string.Empty;
            string ParamsName = string.Empty;
            LineGraph.LngXaxis.Clear();
            LineGraph.LngYaxis.Clear();
            try
            {
                if (LineGraphCollection == null)
                {
                    DateTime fromdate = LineGraph.LngFromDate;
                    DateTime todate = LineGraph.LngToDate;
                    lngFromdate = LineGraph.LngFromDate.ToString("yyyy-MM-dd").Trim();
                    lngTodate = LineGraph.LngToDate.ToString("yyyy-MM-dd").Trim();
                    ParamsName = LineGraph.SelectedPrameter.ParameterName;
                    LineGraph.ParameterName = LineGraph.SelectedPrameter.ParameterName;
                    foreach (var item in DataList)
                    {
                        LineGraphCollection = new ObservableCollection<ArchiveData>();
                        LineGraphCollection = _utility.ArchiveFilterCollection(isSubSystem, lngFromdate, lngTodate, IsSqlFlag.GetLineGraphData, item);
                        if (!(fromdate > todate))
                        {
                            if (LineGraphCollection.Count > 0)
                            {
                                //foreach (ArchiveData Line in LineGraphCollection)
                                //{
                                //    LineGraph.LngXaxis.Add($"{Line.DateTimeStamp}");
                                //    LineGraph.LngYaxis.Add(decimal.Parse(Line.PrameterValue));

                                //}
                                List<DateTime> timeStamps = new List<DateTime>();
                                List<double> values = new List<double>();

                                foreach (ArchiveData line in LineGraphCollection)
                                {
                                    timeStamps.Add(DateTime.Parse(line.DateTimeStamp));
                                    if (double.TryParse(line.PrameterValue, out double parsedValue))
                                    {
                                        values.Add(parsedValue);
                                    }
                                    else
                                    {
                                        // Track non-numeric unique strings
                                        if (!string.IsNullOrWhiteSpace(line.PrameterValue))
                                        {
                                            if(!invalidStrings.Contains(line.PrameterName))
                                            {
                                                invalidStrings.Add(line.PrameterName);
                                            }
                                        }
                                    }

                                    // values.Add(double.Parse(line.PrameterValue));
                                }
                                data_list[item] = values;
                                if(!data_list.Keys.Contains("Dates"))
                                {
                                    data_list[ParamsName + "Dates"] = timeStamps;
                                }
                            }
                            else
                            {
                                RsDialogBox.ShowMsg(UsageConstants.NodataDatesText, LineGraphText, MessageBoxButton.OK, MessageBoxImage.Warning);
                                break;
                            }
                        }
                        else
                        {
                            RsDialogBox.ShowMsg("The (from date) should be less than or equal to the (to date).", LineGraphText, MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }

                    if(data_list.Count > 0)
                    {
                        setValuesHandler(data_list);
                    }

                    if (invalidStrings.Count > 0)
                    {
                        string message = "The following non-numeric values were skipped to display in Graph:\n" + string.Join(", ", invalidStrings);
                        RsDialogBox.ShowMsg(message, "Invalid Parameter Values", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadLineGraph));
            }
        }

        #region LoadLineGraphDefault()
        private void LoadLineGraphDefault()
        {
            try
            {
                LineGraph.IsLngDgActive = _utility.IsMenuActiveStatus(IsMenuActiveStatus.Inactive);
                LineGraph.IsLngRouterActive = _utility.IsMenuActiveStatus(IsMenuActiveStatus.Inactive);
                LineGraph.IsLngRadioActive = _utility.IsMenuActiveStatus(IsMenuActiveStatus.Inactive);
                LineGraph.IslngSwitchActive = _utility.IsMenuActiveStatus(IsMenuActiveStatus.Inactive);
                LineGraph.IsLngUpsActive = _utility.IsMenuActiveStatus(IsMenuActiveStatus.Inactive);

                LineGraph.IsLineGraphPopupOpen = false;

                LineGraph.LngFromDate = DateTime.Today;
                LineGraph.LngToDate = DateTime.Today;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadLineGraphDefault));
            }
        }
        #endregion
    }
}
