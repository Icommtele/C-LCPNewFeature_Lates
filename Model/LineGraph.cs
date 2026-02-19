using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCPReportingSystem.ViewModel;
using LiveCharts;

namespace LCPReportingSystem.Model
{
    public class LineGraph : ViewModelBase
    {
        string _subsystemname = string.Empty;
        string _islngdgactive = string.Empty;
        string _islngrouteractive = string.Empty;
        string _islngradioactive = string.Empty;
        string _islngswitchactive = string.Empty;
        string _islngupsactive = string.Empty;
        string _parametername = string.Empty;

        private bool? _islinegraphpopupopen;

        private ArchiveEntity _archiveentity = new ArchiveEntity();
        private ChartValues<string> _lngxaxis = new ChartValues<string>();
        private ChartValues<decimal> _lngyaxis = new ChartValues<decimal>();

        private DateTime _lngfromdate;
        private DateTime _lngtodate;

        ObservableCollection<ArchiveEntity> _paramcollection = new ObservableCollection<ArchiveEntity>();

        public string SubSystemName
        {
            get { return _subsystemname; }
            set
            {
                _subsystemname = value;
                OnPropertyChanged(nameof(SubSystemName));
            }
        }
        public string IsLngDgActive
        {
            get { return _islngdgactive; }
            set
            {
                _islngdgactive = value;
                OnPropertyChanged(nameof(IsLngDgActive));
            }
        }
        public string IsLngRouterActive
        {
            get { return _islngrouteractive; }
            set
            {
                _islngrouteractive = value;
                OnPropertyChanged(nameof(IsLngRouterActive));
            }
        }
        public string IsLngRadioActive
        {
            get { return _islngradioactive; }
            set
            {
                _islngradioactive = value;
                OnPropertyChanged(nameof(IsLngRadioActive));
            }
        }
        public string IslngSwitchActive
        {
            get { return _islngswitchactive; }
            set
            {
                _islngswitchactive = value;
                OnPropertyChanged(nameof(IslngSwitchActive));
            }
        }
        public string IsLngUpsActive
        {
            get { return _islngupsactive; }
            set
            {
                _islngupsactive = value;
                OnPropertyChanged(nameof(IsLngUpsActive));
            }
        }
        public string ParameterName
        {
            get { return _parametername; }
            set 
            {
                _parametername = value;
                OnPropertyChanged(nameof(ParameterName));
            }
        }
        public ObservableCollection<ArchiveEntity> PrameterCollection
        {
            get { return _paramcollection; }
            set
            {
                _paramcollection = value;
                OnPropertyChanged(nameof(PrameterCollection));
            }
        }
        public ArchiveEntity SelectedPrameter
        {
            get 
            {
                if (_archiveentity == null)
                {
                    _archiveentity = new ArchiveEntity();
                }
                return _archiveentity;
            }
            set
            {
                _archiveentity = value;
                OnPropertyChanged(nameof(SelectedPrameter));
            }
        }
        public ChartValues<string> LngXaxis
        {
            get { return _lngxaxis; }
            set
            {
                _lngxaxis = value;
                OnPropertyChanged(nameof(LngXaxis));
            }
        }
        public ChartValues<decimal> LngYaxis
        {
            get { return _lngyaxis; }
            set
            {
                _lngyaxis = value;
                OnPropertyChanged(nameof(LngYaxis));
            }
        }
        public DateTime LngFromDate
        {
            get { return _lngfromdate; }
            set
            {
                _lngfromdate = value;
                OnPropertyChanged(nameof(LngFromDate));
            }
        }
        public DateTime LngToDate
        {
            get { return _lngtodate; }
            set
            {
                _lngtodate = value;
                OnPropertyChanged(nameof(LngToDate));
            }
        }
        public bool? IsLineGraphPopupOpen
        {
            get { return _islinegraphpopupopen; }
            set
            {
                _islinegraphpopupopen = value;
                OnPropertyChanged(nameof(IsLineGraphPopupOpen));
            }
        }
    }
}
