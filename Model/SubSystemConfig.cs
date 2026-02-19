using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCPReportingSystem.ViewModel;
using System.Collections.ObjectModel;

namespace LCPReportingSystem.Model
{
    public class SubSystemConfig : ViewModelBase
    {
        private string _isdgactive = string.Empty;
        private string _isrouteractive = string.Empty;
        private string _isradioactive = string.Empty;
        private string _isswitchactive = string.Empty;
        private string _isupsactive = string.Empty;
        private string _subystemname = string.Empty;
        private string _subsystemnavtext = string.Empty;

        private bool? _isconfigpopupopen;
        private bool? _issubsystemdetails;
        private bool? _systemparamsdetails;

        private ObservableCollection<SubSysParameterConfig> _configcollection = new ObservableCollection<SubSysParameterConfig>();
        private ObservableCollection<SubSystem> _subsystemconfigcollection = new ObservableCollection<SubSystem>();
        public ObservableCollection<SubSysParameterConfig> ConfigCollection
        {
            get { return _configcollection; }
            set
            {
                _configcollection = value;
                OnPropertyChanged(nameof(ConfigCollection));
            }
        }
        public ObservableCollection<SubSystem> SubsystemConfigCollection
        {
            get { return _subsystemconfigcollection; }
            set
            {
                _subsystemconfigcollection = value;
                OnPropertyChanged(nameof(SubsystemConfigCollection));
            }
        }
        public string IsDgActive
        {
            get { return _isdgactive; }
            set
            {
                _isdgactive = value;
                OnPropertyChanged(nameof(IsDgActive));
            }
        }
        public string IsRouterActive
        {
            get { return _isrouteractive; }
            set
            {
                _isrouteractive = value;
                OnPropertyChanged(nameof(IsRouterActive));
            }
        }
        public string IsRadioActive
        {
            get { return _isradioactive; }
            set
            {
                _isradioactive = value;
                OnPropertyChanged(nameof(IsRadioActive));
            }
        }
        public string IsSwitchActive
        {
            get { return _isswitchactive; }
            set
            {
                _isswitchactive = value;
                OnPropertyChanged(nameof(IsSwitchActive));
            }
        }
        public string IsUpsActive
        {
            get { return _isupsactive; }
            set
            {
                _isupsactive = value;
                OnPropertyChanged(nameof(IsUpsActive));
            }
        }
        public string SubSystemName
        {
            get { return _subystemname; }
            set
            {
                _subystemname = value;
                OnPropertyChanged(nameof(SubSystemName));
            }
        }
        public string SubsystemNavText
        {
            get { return _subsystemnavtext; }
            set
            {
                _subsystemnavtext = value;
                OnPropertyChanged(nameof(SubsystemNavText));
            }
        }
        public bool? IsConfigPopupOpen
        {
            get { return _isconfigpopupopen; }
            set
            {
                _isconfigpopupopen = value;
                OnPropertyChanged(nameof(IsConfigPopupOpen));
            }
        }
        public bool? SystemParamsDetails
        {
            get { return _systemparamsdetails; }
            set
            {
                _systemparamsdetails = value;
                OnPropertyChanged(nameof(SystemParamsDetails));
            }
        }
        public bool? IsSubsystemDetails
        {
            get { return _issubsystemdetails; }
            set
            {
                _issubsystemdetails = value;
                OnPropertyChanged(nameof(IsSubsystemDetails));
            }
        }
    }
}
