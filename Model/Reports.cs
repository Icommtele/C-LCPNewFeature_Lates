using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCPReportingSystem.ViewModel;

namespace LCPReportingSystem.Model
{
    public class Reports : ViewModelBase
    {
        string _rptusername = string.Empty;
        string _strdatetime = string.Empty;
        string _isrptdgactive = string.Empty;
        string _isrptrouteractive = string.Empty;
        string _isrptradioactive = string.Empty;
        string _isrptswitchactive = string.Empty;
        string _isrptupsactive = string.Empty;
        string _snmpNonTrapName = "Non Trap";
        string _snmpTrapName = "Trap";
        string _exerciseType = string.Empty;

        bool _isreportviewenable;
        bool _isnontrap;
        bool _istrap;
        private bool? _isreportpopupopen;
        DateTime _rptseletedfromdate;
        DateTime _rptseletedtodate;

        public string SnmpNonTrapName
        {
            get => _snmpNonTrapName;
            set
            {
                _snmpNonTrapName = value;
                OnPropertyChanged(nameof(SnmpNonTrapName));
            }
        }
        public string ExerciseType
        {
            get => _exerciseType;
            set
            {
                _exerciseType = value;
                OnPropertyChanged(nameof(ExerciseType));
            }
        }

        public string SnmpTrapName
        {
            get => _snmpTrapName;
            set
            {
                _snmpTrapName = value;
                OnPropertyChanged(nameof(SnmpTrapName));
            }
        }
        public string RptUserName
        {
            get { return _rptusername; }
            set
            {
                _rptusername = value;
                OnPropertyChanged(nameof(RptUserName));
            }
        }
        public string RptDateTime
        {
            get { return _strdatetime; }
            set
            {
                _strdatetime = value;
                OnPropertyChanged(nameof(RptDateTime));
            }
        }
        public string IsRptDgActive
        {
            get { return _isrptdgactive; }
            set
            {
                _isrptdgactive = value;
                OnPropertyChanged(nameof(IsRptDgActive));
            }
        }
        public string IsRptRouterActive
        {
            get { return _isrptrouteractive; }
            set
            {
                _isrptrouteractive = value;
                OnPropertyChanged(nameof(IsRptRouterActive));
            }
        }
        public string IsRptRadioActive
        {
            get { return _isrptradioactive; }
            set
            {
                _isrptradioactive = value;
                OnPropertyChanged(nameof(IsRptRadioActive));
            }
        }
        public string IsRptSwitchActive
        {
            get { return _isrptswitchactive; }
            set
            {
                _isrptswitchactive = value;
                OnPropertyChanged(nameof(IsRptSwitchActive));
            }
        }
        public string IsRptUpsActive
        {
            get { return _isrptupsactive; }
            set
            {
                _isrptupsactive = value;
                OnPropertyChanged(nameof(IsRptUpsActive));
            }
        }

        public bool IsReportViewEnable
        {
            get { return _isreportviewenable; }
            set 
            {
                _isreportviewenable = value;
                OnPropertyChanged(nameof(IsReportViewEnable));
            }
        }
        public bool IsNonTrap
        {
            get { return _isnontrap; }
            set 
            {
                _isnontrap = value;
                OnPropertyChanged(nameof(IsNonTrap));
            }
        }
        public bool IsTrap
        {
            get { return _istrap; }
            set 
            {
                _istrap = value;
                OnPropertyChanged(nameof(IsTrap));
            }
        }
        public bool? IsReportPopupOpen
        {
            get { return _isreportpopupopen; }
            set
            {
                _isreportpopupopen = value;
                OnPropertyChanged(nameof(IsReportPopupOpen));
            }
        }
        public DateTime RptSeletedFromDate
        {
            get { return _rptseletedfromdate; }
            set
            {
                _rptseletedfromdate = value;
                OnPropertyChanged(nameof(RptSeletedFromDate));
            }
        }
        public DateTime RptSeletedToDate
        {
            get { return _rptseletedtodate; }
            set
            {
                _rptseletedtodate = value;
                OnPropertyChanged(nameof(RptSeletedToDate));
            }
        }
    }
}
