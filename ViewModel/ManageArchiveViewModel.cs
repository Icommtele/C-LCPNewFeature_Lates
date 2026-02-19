using LCPReportingSystem.Command;
using LCPReportingSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LCPReportingSystem.RsDialogMessageBox;
using Microsoft.Reporting.WinForms;
using System.IO;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Xml.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using SnmpSharpNet;
using LCPInfrastructure;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;
using System.IO.Compression;
using CommonLib;
using LCPReportingSystem.DbHelper;

namespace LCPReportingSystem.ViewModel
{
    public class ManageArchiveViewModel
    {
        #region
        private ICommand _idgcommand;
        private ICommand _iroutercommand;
        private ICommand _iradiocommand;
        private ICommand _iswitchcommand;
        private ICommand _iupscommand;
        private ICommand _iarchivehelpcommand;
        private ICommand _iarchivefileexplorercommand;
        private ICommand _filterviewcommand;
        private ICommand _deletecommand;
        private ICommand _archiveclosepopupcommand;
        private ICommand _navnextpagecommand;
        private ICommand _navpreviouspagecommand;
        private ICommand _issavecommand;

        int IsIndexSubsystem =1;
        int? IsIndexArchieveSubsystem = null;
        int? _previousSubsystemIndex = null;
        double CountOfAllpage = 0;
        private const int ItemsPerPage = 25;
        public ManageArchive archive { get; set; }
        private Utility _utility { get; set; }
        public Action<bool> SetHeaderHandler { get; set; }
        public Func<List<ArchiveData>> GetRowIDHandler { get; set; }
        private ArchiveData archiveData { get; set; }
        public Action ArchiveExploreVisibilityHandler;
        public string FromDateLessText = "The From date should be less than or equal to the To date).";
        public string ManageArchiveText = "Archive Management";
        public string SelectSubSystemText = "Please select the subsystem name from the menu.";
        public string RecordsDeletedText = "Data Deleted Successfully.";
        public string ConfirmationMessage = "Are you sure you want to delete the selected records?";
        public string RecordsSelectDeletedText= "Select Data for Delete";
        public string RecordsNotDeletedText = "Failed to Delete The Records";
        public string AreyousureDeletedText = "Are you sure you want to delete this items ?";
        public string NoDataText = "No data available for the selected criteria.";
        public string NoDataFoundText = "No Data Found";
        #endregion
        public ManageArchiveViewModel()
        {
            archive = new ManageArchive();
            _utility = new Utility();
            archiveData = new ArchiveData();        
        }

        public ICommand IDgCommand
        {
            get
            {
                if (_idgcommand == null)
                {
                    _idgcommand = new RelayCommand(param => IDgCommandFunction(param), null);
                }
                return _idgcommand;
            }
        }
        public ICommand IRouterCommand
        {
            get
            {
                if (_iroutercommand == null)
                {
                    _iroutercommand = new RelayCommand(param => IRouterFunction(param), null);
                }
                return _iroutercommand;
            }
        }
        public ICommand IRadioCommand
        {
            get
            {
                if (_iradiocommand == null)
                {
                    _iradiocommand = new RelayCommand(param => IRadioFunction(param), null);
                }
                return _iradiocommand;
            }
        }
        public ICommand ISwitchCommand
        {
            get
            {
                if (_iswitchcommand == null)
                {
                    _iswitchcommand = new RelayCommand(param => ISwitchFunction(param), null);
                }
                return _iswitchcommand;
            }
        }
        public ICommand IUpsCommand
        {
            get
            {
                if (_iupscommand == null)
                {
                    _iupscommand = new RelayCommand(param => IUpsFunction(param), null);
                }
                return _iupscommand;
            }
        }
        public ICommand IArchiveHelpCommand
        {
            get
            {
                if (_iarchivehelpcommand == null)
                {
                    _iarchivehelpcommand = new RelayCommand(param => ArchiveHelpFunation(), null);
                }
                return _iarchivehelpcommand;
            }
        }
        public ICommand IArchiveFileExplorerCommand
        {
            get
            {
                if (_iarchivefileexplorercommand == null)
                {
                    _iarchivefileexplorercommand = new RelayCommand(param => ArchiveFileExplorerFunation(), null);
                }
                return _iarchivefileexplorercommand;
            }
        }
        public ICommand IFilterViewCommand
        {
            get

            {
                if (_filterviewcommand == null)
                {
                    _filterviewcommand = new RelayCommand(param => FilterArchiveData(), null);
                }
                return _filterviewcommand;
            }
        }
        public ICommand IDeleteArchiveCommand
        {
            get
            {
                if (_deletecommand == null)
                {
                    _deletecommand = new RelayCommand(param => DeleteArchive(), null);
                }
                return _deletecommand;
            }
        }
        public ICommand ArchiveClosePopupCommand
        {
            get
            {
                if (_archiveclosepopupcommand == null)
                {
                    _archiveclosepopupcommand = new RelayCommand(param => ArchiveClosePopupAction(), null);
                }
                return _archiveclosepopupcommand;
            }
        }
        public ICommand NavNextPageCommand
        {
            get
            {
                if (_navnextpagecommand == null)
                {
                    _navnextpagecommand = new RelayCommand(param => NavLoadNextPage(param), null);
                }
                return _navnextpagecommand;
            }
        }
        public ICommand NavPreviousPageCommand
        {
            get
            {
                if (_navpreviouspagecommand == null)
                {
                    _navpreviouspagecommand = new RelayCommand(param => NavLoadPreviousPage(), null);
                }
                return _navpreviouspagecommand;
            }
        }
        public ICommand SaveCommand
        {
            get
            {
                if (_issavecommand == null)
                {
                    _issavecommand = new RelayCommand(param => SaveFilterData(), null);
                }
                return _issavecommand;
            }
        }
        
        
        private void IDgCommandFunction(object param)
        {
            try
            {              
                if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
                    IsIndexSubsystem = (int)IsSubSystem.DieselGenerator2;
                else
                    IsIndexSubsystem = (int)IsSubSystem.DieselGenerator;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IDgCommandFunction));
            }
        }
        private void IRouterFunction(object param)
        {            
            archive.CurrentPage = 1;
            if (param.ToString() == "Router2")
                IsIndexSubsystem = (int)IsSubSystem.Router2;
            else
                IsIndexSubsystem = (int)IsSubSystem.Router;                
        }
        private void IRadioFunction(object param)
        {
            try
            {               
                if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
                    IsIndexSubsystem = (int)IsSubSystem.Radio2;
                else
                    IsIndexSubsystem = (int)IsSubSystem.Radio;                
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IRadioFunction));
            }
        }
        private void ISwitchFunction(object param)
        {
            try
            {
                if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))
                    IsIndexSubsystem = (int)IsSubSystem.Switch2;
                else
                    IsIndexSubsystem = (int)IsSubSystem.Switch;        
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ISwitchFunction));
            }
        }
        private void IUpsFunction(object param)
        {
            try
            {              
                if (Common.SubsystemCollection.ContainsKey(param.ToString()) && string.Equals(param.ToString(), Common.SubsystemCollection[param.ToString()]))                
                    IsIndexSubsystem = (int)IsSubSystem.UPS2;                
                else     
                    IsIndexSubsystem = (int)IsSubSystem.UPS;             
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IUpsFunction));
            }
        }
     
        
        //Default Loading Data
        public void ManageArchiveLoadDefault()
        {
            try
            {
                if (archive != null)
                {
                    DateTime fromDate = DateTime.Now.AddMonths(-2);
                    DateTime toDate = DateTime.Now;
                    archive.SeletedFromDate = fromDate;
                    archive.SeletedToDate = toDate;
                    if (IsIndexSubsystem <= 0)
                    {
                        IsIndexSubsystem = 1;
                    }
                    SetHeaderHandler(archive.IsTrap);
                    FilterArchiveData();
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ManageArchiveLoadDefault));
            }
        }
     
        
        //Load Data in Time Period
        private void FilterArchiveData()
        {
            try
            {
                DateTime fromdate = archive.SeletedFromDate;
                DateTime todate = archive.SeletedToDate;
                if (IsIndexSubsystem <= 0)
                {
                    RsDialogBox.ShowMsg(SelectSubSystemText, ManageArchiveText, MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                if (fromdate > todate)
                {
                    RsDialogBox.ShowMsg(FromDateLessText, ManageArchiveText, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (UsageConstants.SubsystemCollectionNumber.ContainsKey((int)IsIndexSubsystem))
                {
                    LoadArchiveFilterData(UsageConstants.SubsystemCollectionNumber[(int)IsIndexSubsystem], fromdate.ToString("yyyy-MM-dd").Trim(), todate.ToString("yyyy-MM-dd").Trim());
                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(FilterArchiveData));
            }
        }
        private void LoadArchiveFilterData(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            try
            {
                if (UsageConstants.SubsystemCollectionNumber.ContainsKey((int)IsIndexSubsystem))
                {
                    bool IsInitialData = true;
                    var filterCollection = _utility.FilterArchiveDataAllInOne(UsageConstants.SubsystemCollectionNumber[(int)IsIndexSubsystem], IsInitialData, FromDate, archive.IsTrap, ToDate,
                                                                           archive.CurrentPage, archive.TotalPage, false, false, false, false);
                    if (filterCollection != null && filterCollection.Any())
                    {
                        var totalValue = _utility._layer.GetArchiveDataTotalCount(FromDate, ToDate, isSubSystem, archive.IsTrap);
                        SetHeaderHandler(archive.IsTrap);
                        archive.ArchiveCollection = filterCollection;

                        if (archive.CurrentPage == 0)
                            archive.CurrentPage = 1;

                        archive.TotalPage = totalValue;
                        string snmpType = archive.IsNonTrap ? "Non Trap" : "Trap";

                        ActivityReportDataInsertModel.SetActivityReport(ManageArchiveText , "Archive Data Generated for : "+UsageConstants.SubsystemCollectionNumber[(int)IsIndexSubsystem].ToString()+" _"+snmpType + " - From : "+FromDate+" To : "+ToDate, string.Empty);

                    }
                    else
                    {
                        archive.ArchiveCollection = new ObservableCollection<ArchiveData>();
                        RsDialogBox.ShowMsg(NoDataFoundText, ManageArchiveText, MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadArchiveFilterData));
            }
        }


        //Next and Previous Buttons
        private void NavLoadNextPage(object param)
        {
            try
            {
                if (archive.CurrentPage >= archive.TotalPage)
                {
                    RsDialogBox.ShowMsg("No Next page", ManageArchiveText, MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                ObservableCollection<ArchiveData> filterCollection = null;
                string fromDate = archive.SeletedFromDate.ToString();
                string toDate = archive.SeletedToDate.ToString();

                if (param?.ToString() == "Go")
                {
                    if (archive.GoToPageNumber <= archive.TotalPage)
                    {
                        UsageConstants.IsGoToPage = true;
                        filterCollection = _utility.FilterArchiveDataAllInOne(UsageConstants.SubsystemCollectionNumber[(int)IsIndexSubsystem], false,
                        fromDate, archive.IsTrap, toDate, archive.GoToPageNumber, archive.TotalPage, false, false, true, false);

                        if (filterCollection?.Any() == true)
                        {
                            archive.CurrentPage = archive.GoToPageNumber;
                        }
                        else
                        {
                            UsageConstants.IsGoToPage = false;
                        }
                    }
                    else
                    {
                        RsDialogBox.ShowMsg("Page Number Exceeded", ManageArchiveText, MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                }
                else
                {
                    UsageConstants.IsGoToPage = false;
                    filterCollection = _utility.FilterArchiveDataAllInOne(
                        UsageConstants.SubsystemCollectionNumber[(int)IsIndexSubsystem], false,
                        fromDate, archive.IsTrap, toDate,
                        archive.CurrentPage, archive.TotalPage,
                        false, false, true, false);

                    if (filterCollection?.Any() == true)
                        archive.CurrentPage++;
                }


                if (filterCollection?.Any() == true)
                {
                    archive.ArchiveCollection = filterCollection;
                }
                else
                {
                    RsDialogBox.ShowMsg(NoDataFoundText, ManageArchiveText, MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(NavLoadNextPage));
            }
        }
        private void NavLoadPreviousPage()
        {
            try
            {
                if (archive.CurrentPage > 1)
                {
                    ObservableCollection<ArchiveData> filterCollection = new ObservableCollection<ArchiveData>();
                    string fromdate = archive.SeletedFromDate.ToString();
                    string Todate = archive.SeletedToDate.ToString();
                    filterCollection = _utility.FilterArchiveDataAllInOne(UsageConstants.SubsystemCollectionNumber[(int)IsIndexSubsystem], false, fromdate, archive.IsTrap, Todate, archive.CurrentPage, archive.TotalPage, false, false, false, true);
                    if (filterCollection != null && filterCollection.Any())
                    {
                        archive.ArchiveCollection = filterCollection;
                        archive.CurrentPage--;
                    }
                    else
                    {
                        archive.ArchiveCollection = new ObservableCollection<ArchiveData>();
                        RsDialogBox.ShowMsg(NoDataFoundText, ManageArchiveText, MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {

                    RsDialogBox.ShowMsg("No Previous page", ManageArchiveText, MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(NavLoadPreviousPage));
            }
        }


        //Save Button
        private void SaveFilterData()
        {
            try
            {
                SaveArchiveSubsystemDataIntoFolder(UsageConstants.SubsystemCollectionNumber[(int)IsIndexSubsystem], archive.IsTrap);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SaveFilterData));
            }
        }
        private void SaveArchiveSubsystemDataIntoFolder(IsSubSystem isSubSystem, bool isTrap)
        {
            try
            {
                string baseFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ManageArchiveText.Replace(" ", ""));
                if (!Directory.Exists(baseFolder))
                {
                    Directory.CreateDirectory(baseFolder);
                }


                string folderName = isTrap ? "TrapData" : "NonTrapData";
                string archiveFolder = Path.Combine(baseFolder, folderName);

                if (!Directory.Exists(archiveFolder))
                {
                    Directory.CreateDirectory(archiveFolder);
                }


                string filePrefix = $"Archive_{_utility.GetSubsystemName(isSubSystem)}_{DateTime.Today:yyyyMMdd}";
                string filePath = Path.Combine(archiveFolder, $"{filePrefix}.txt");

                if (File.Exists(filePath))
                {
                    FileInfo fi = new FileInfo(filePath);
                    long sizeLimit = 2L * 1024 * 1024 * 1024; // 2 GB
                    if (fi.Length >= sizeLimit)
                    {
                        filePath = Path.Combine(
                            archiveFolder,
                            $"{filePrefix}_{DateTime.Now:HHmmss}.txt"
                        );
                    }
                }

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Subsystem Name: {_utility.GetSubsystemName(isSubSystem)}");
                    writer.WriteLine($"Report Date: {DateTime.Today:yyyy-MM-dd}");
                    writer.WriteLine(new string('-', 150));

                    if (isTrap)
                    {
                        var trapCollection = archive.ArchiveCollection;
                        if (trapCollection == null || trapCollection.Count == 0)
                        {
                            RsDialogBox.ShowMsg("Trap data Unable to Save.",
                                "Archive Save Info", MessageBoxButton.OK, MessageBoxImage.Information);
                            return;
                        }

                        writer.WriteLine($"{"RecordId",-12}{"SusbsystemName",-22}{"Trap Name",-25}{"Trap Description",-30}{"Timestamp",-20}{"Recorddate",-20}");
                        writer.WriteLine(new string('-', 150));

                        foreach (var trap in trapCollection)
                        {
                            writer.WriteLine(
                                $"{trap.RecordID,-12}" +
                                $"{trap.SystemName,-22}" +
                                $"{trap.PrameterName,-25}" +
                                $"{trap.PrameterValue,-30}" +
                                $"{trap.DateTimeStamp,-20}" +
                                $"{trap.CurrentDate,-20}");
                        }
                    }
                    else
                    {
                        var parameterCollection = archive.ArchiveCollection;
                        if (parameterCollection == null || parameterCollection.Count == 0)
                        {
                            RsDialogBox.ShowMsg("Trap data Unable to Save.",
                                "Archive Save Info", MessageBoxButton.OK, MessageBoxImage.Information);
                            return;
                        }


                        writer.WriteLine($"{"RecordId",-12}{"SusbsystemName",-22}{"ParameterName",-25}{"ParameterValue",-30}{"Timestamp",-20}{"Recorddate",-20}");
                        writer.WriteLine(new string('-', 150));

                        foreach (var param in parameterCollection)
                        {
                            writer.WriteLine(
                                $"{param.RecordID,-12}" +
                                $"{param.SystemName,-22}" +
                                $"{param.PrameterName,-25}" +
                                $"{param.PrameterValue,-30}" +
                                $"{param.DateTimeStamp,-20}" +
                                $"{param.CurrentDate,-20}");
                        }
                    }

                    writer.WriteLine(new string('-', 150));
                }
                //long Zipvalue = Properties.Settings.Default.ZipFolderSize;
                //// ✅ Check folder size and zip if >= 4GB
                //long folderSize = GetFolderSize(archiveFolder);
                //long sizeLimit = 4L * Zipvalue * Zipvalue * Zipvalue;
                //; // 4 GB

                //if (folderSize >= sizeLimit)
                //{
                //    string zipFilePath = Path.Combine(filePath, $"TrapData_{DateTime.Now:yyyyMMdd_HHmmss}.zip");

                //    if (File.Exists(zipFilePath))
                //        File.Delete(zipFilePath);

                //    ZipFile.CreateFromDirectory(archiveFolder, zipFilePath);

                //    // Delete and recreate the folder for future use
                //    Directory.Delete(archiveFolder, true);
                //    Directory.CreateDirectory(archiveFolder);
                //}
                ArchiveExploreVisibilityHandler();

                RsDialogBox.ShowMsg(
                    $"{(isTrap ? "Trap" : "Non-Trap")} data archived successfully.\n" + archiveFolder,
                    "Archive Save Info", MessageBoxButton.OK, MessageBoxImage.Information
                );
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SaveArchiveSubsystemDataIntoFolder));
            }
        }


        //Delete Button
        private   void DeleteArchive()
        {
            try
            {
                var rowid = GetRowIDHandler();

                    if (rowid.Count > 0)
                    {
                      var result = RsDialogBox.ShowMsg(ConfirmationMessage, ManageArchiveText, MessageBoxButton.YesNo, MessageBoxImage.Information);

                      if (result == MessageBoxResult.No)
                      {
                        return;
                      }
                        var deletedata = _utility._layer.DeleteArchiveData(rowid, archive.IsTrap);
                        archive.GoToPageNumber = archive.CurrentPage;
                        NavLoadNextPage("Go");
                        RsDialogBox.ShowMsg(RecordsDeletedText, ManageArchiveText, MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        RsDialogBox.ShowMsg(RecordsSelectDeletedText, ManageArchiveText, MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(DeleteArchive));
            }
        }


        //Archive explore
        private void ArchiveHelpFunation()
        {
            if (!(bool)archive.IsArchiveHelPopupOpen)
            {
                archive.IsArchiveHelPopupOpen = true;
            }
            else
            {
                archive.IsArchiveHelPopupOpen = false;
            }
        }
        private void ArchiveFileExplorerFunation()
        {
           
            archive.IsArchiveFileExplorerPopupOpen = true;
        }
        private void ArchiveClosePopupAction()
        {
            if ((bool)archive.IsArchiveHelPopupOpen)
            {
                archive.IsArchiveHelPopupOpen = false;
            }
        }

    }
}
       