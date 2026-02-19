using LCPReportingSystem.ViewModel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.Model
{
    public partial class DashBoard : ViewModelBase
    {
        //Radio1
        string _terminalmodebase = string.Empty;
        string _terminalmoderemote = string.Empty;
        string _terminalmoderepeater = string.Empty;

        string _terminalmodetimestamp = string.Empty;

        string _managerip = string.Empty;
        string _managernetmaskip = string.Empty;

        string _manageriptimestamp = string.Empty;
        string _managernetmasktimestamp = string.Empty;

        string _slotactivate1 = string.Empty;
        string _slotactivate2 = string.Empty;
        string _slotactivate3 = string.Empty;
        string _slotactivate4 = string.Empty;
        string _slotactivate5 = string.Empty;
        string _slotactivate6 = string.Empty;

        string _slotactivate1indicator = string.Empty;
        string _slotactivate2indicator = string.Empty;
        string _slotactivate3indicator = string.Empty;
        string _slotactivate4indicator = string.Empty;
        string _slotactivate5indicator = string.Empty;
        string _slotactivate6indicator = string.Empty;

        string _slotactivate1timestamp = string.Empty;
        string _slotactivate2timestamp = string.Empty;
        string _slotactivate3timestamp = string.Empty;
        string _slotactivate4timestamp = string.Empty;
        string _slotactivate5timestamp = string.Empty;
        string _slotactivate6timestamp = string.Empty;

        string _fec1 = string.Empty;
        string _fec2 = string.Empty;
        string _fec3 = string.Empty;
        string _fec4 = string.Empty;
        string _fec5 = string.Empty;
        string _fec6 = string.Empty;

        string _fec1indicator = string.Empty;
        string _fec2indicator = string.Empty;
        string _fec3indicator = string.Empty;
        string _fec4indicator = string.Empty;
        string _fec5indicator = string.Empty;
        string _fec6indicator = string.Empty;

        string _fec1timestamp = string.Empty;
        string _fec2timestamp = string.Empty;
        string _fec3timestamp = string.Empty;
        string _fec4timestamp = string.Empty;
        string _fec5timestamp = string.Empty;
        string _fec6timestamp = string.Empty;


        string _txpwr1 = string.Empty;
        string _txpwr2 = string.Empty;
        string _txpwr3 = string.Empty;
        string _txpwr4 = string.Empty;
        string _txpwr5 = string.Empty;
        string _txpwr6 = string.Empty;

        string _txpwrslot1 = string.Empty;
        string _txpwrslot2 = string.Empty;
        string _txpwrslot3 = string.Empty;
        string _txpwrslot4 = string.Empty;
        string _txpwrslot5 = string.Empty;
        string _txpwrslot6 = string.Empty;

        string _remoteid1 = string.Empty;
        string _remoteid2 = string.Empty;
        string _remoteid3 = string.Empty;
        string _remoteid4 = string.Empty;
        string _remoteid5 = string.Empty;
        string _remoteid6 = string.Empty;

        string _link1 = string.Empty;
        string _link2 = string.Empty;
        string _link3 = string.Empty;
        string _link4 = string.Empty;
        string _link5 = string.Empty;
        string _link6 = string.Empty;

        string _link1indicator = string.Empty;
        string _link2indicator = string.Empty;
        string _link3indicator = string.Empty;
        string _link4indicator = string.Empty;
        string _link5indicator = string.Empty;
        string _link6indicator = string.Empty;

        string _channelno1 = string.Empty;
        string _channelno2 = string.Empty;
        string _channelno3 = string.Empty;
        string _channelno4 = string.Empty;
        string _channelno5 = string.Empty;
        string _channelno6 = string.Empty;


        string _txpwr1timestamp = string.Empty;
        string _txpwr2timestamp = string.Empty;
        string _txpwr3timestamp = string.Empty;
        string _txpwr4timestamp = string.Empty;
        string _txpwr5timestamp = string.Empty;
        string _txpwr6timestamp = string.Empty;

        string _rssislot1 = string.Empty;
        string _rssislot2 = string.Empty;
        string _rssislot3 = string.Empty;
        string _rssislot4 = string.Empty;
        string _rssislot5 = string.Empty;
        string _rssislot6 = string.Empty;

        string _rssislot1timestamp = string.Empty;
        string _rssislot2timestamp = string.Empty;
        string _rssislot3timestamp = string.Empty;
        string _rssislot4timestamp = string.Empty;
        string _rssislot5timestamp = string.Empty;
        string _rssislot6timestamp = string.Empty;

        string _syncLoss1 = string.Empty;
        string _syncLoss2 = string.Empty;
        string _syncLoss3 = string.Empty;
        string _syncLoss4 = string.Empty;
        string _syncLoss5 = string.Empty;
        string _syncLoss6 = string.Empty;

        string _syncLoss1indicator = string.Empty;
        string _syncLoss2indicator = string.Empty;
        string _syncLoss3indicator = string.Empty;
        string _syncLoss4indicator = string.Empty;
        string _syncLoss5indicator = string.Empty;
        string _syncLoss6indicator = string.Empty;

        string _syncLoss1timestamp = string.Empty;
        string _syncLoss2timestamp = string.Empty;
        string _syncLoss3timestamp = string.Empty;
        string _syncLoss4timestamp = string.Empty;
        string _syncLoss5timestamp = string.Empty;
        string _syncLoss6timestamp = string.Empty;

        string _snr1 = string.Empty;
        string _snr2 = string.Empty;
        string _snr3 = string.Empty;
        string _snr4 = string.Empty;
        string _snr5 = string.Empty;
        string _snr6 = string.Empty;

        string _snr1timestamp = string.Empty;
        string _snr2timestamp = string.Empty;
        string _snr3timestamp = string.Empty;
        string _snr4timestamp = string.Empty;
        string _snr5timestamp = string.Empty;
        string _snr6timestamp = string.Empty;

        string _voltage5VA = string.Empty;
        string _voltage12v = string.Empty;
        string _voltageneg5v = string.Empty;
        string _voltage49v = string.Empty;

        string _voltage5VAtimestamp = string.Empty;
        string _voltage12vtimestamp = string.Empty;
        string _voltageneg5vtimestamp = string.Empty;
        string _voltage49vtimestamp = string.Empty;

        string _indexhealth = string.Empty;
        string _indexhealthtimestamp = string.Empty;


        public string TerminalModeBase
        {
            get { return _terminalmodebase; }
            set
            {
                _terminalmodebase = value;
                OnPropertyChanged(nameof(TerminalModeBase));
            }
        }
        public string TerminalModeRemote
        {
            get { return _terminalmoderemote; }
            set
            {
                _terminalmoderemote = value;
                OnPropertyChanged(nameof(TerminalModeRemote));
            }
        }
        public string TerminalModeRepeater
        {
            get { return _terminalmoderepeater; }
            set
            {
                _terminalmoderepeater = value;
                OnPropertyChanged(nameof(TerminalModeRepeater));
            }
        }
        public string TerminalmodeTimestamp
        {
            get { return _terminalmodetimestamp; }
            set
            {
                _terminalmodetimestamp = value;
                OnPropertyChanged(nameof(TerminalmodeTimestamp));
            }
        }
        public string ManagerIp
        {
            get { return _managerip; }
            set
            {
                _managerip = value;
                OnPropertyChanged(nameof(ManagerIp));
            }
        }
        public string ManageripTimestamp 
        {
            get { return _manageriptimestamp; }
            set
            {
                _manageriptimestamp = value;
                OnPropertyChanged(nameof(ManageripTimestamp));
            }
        }
        public string ManagerNetMaskIp
        {
            get { return _managernetmaskip; }
            set
            {
                _managernetmaskip = value;
                OnPropertyChanged(nameof(ManagerNetMaskIp));
            }
        }
        public string ManagerNetMaskTimestamp
        {
            get { return _managernetmasktimestamp; }
            set
            {
                _managernetmasktimestamp = value;
                OnPropertyChanged(nameof(ManagerNetMaskTimestamp));
            }
        }
        public string SlotActivate1
        {
            get { return _slotactivate1; }
            set
            {
                _slotactivate1 = value;
                OnPropertyChanged(nameof(SlotActivate1));
            }
        }
        public string SlotActivate2
        {
            get { return _slotactivate2; }
            set
            {
                _slotactivate2 = value;
                OnPropertyChanged(nameof(SlotActivate2));
            }
        }
        public string SlotActivate3
        {
            get { return _slotactivate3; }
            set
            {
                _slotactivate3 = value;
                OnPropertyChanged(nameof(SlotActivate3));
            }
        }
        public string SlotActivate4
        {
            get { return _slotactivate4; }
            set
            {
                _slotactivate4 = value;
                OnPropertyChanged(nameof(SlotActivate4));
            }
        }
        public string SlotActivate5
        {
            get { return _slotactivate5; }
            set
            {
                _slotactivate5 = value;
                OnPropertyChanged(nameof(SlotActivate5));
            }
        }
        public string SlotActivate6
        {
            get { return _slotactivate6; }
            set
            {
                _slotactivate6 = value;
                OnPropertyChanged(nameof(SlotActivate6));
            }
        }
        public string SlotActivate1Indicator
        {
            get { return _slotactivate1indicator; }
            set
            {
                _slotactivate1indicator = value;
                OnPropertyChanged(nameof(SlotActivate1Indicator));
            }
        }
        public string SlotActivate2Indicator
        {
            get { return _slotactivate2indicator; }
            set
            {
                _slotactivate2indicator = value;
                OnPropertyChanged(nameof(SlotActivate2Indicator));
            }
        }
        public string SlotActivate3Indicator
        {
            get { return _slotactivate3indicator; }
            set
            {
                _slotactivate3indicator = value;
                OnPropertyChanged(nameof(SlotActivate3Indicator));
            }
        }
        public string SlotActivate4Indicator
        {
            get { return _slotactivate4indicator; }
            set
            {
                _slotactivate4indicator = value;
                OnPropertyChanged(nameof(SlotActivate4Indicator));
            }
        }
        public string SlotActivate5Indicator
        {
            get { return _slotactivate5indicator; }
            set
            {
                _slotactivate5indicator = value;
                OnPropertyChanged(nameof(SlotActivate5Indicator));
            }
        }
        public string SlotActivate6Indicator
        {
            get { return _slotactivate5indicator; }
            set
            {
                _slotactivate5indicator = value;
                OnPropertyChanged(nameof(SlotActivate6Indicator));
            }
        }
        public string SlotActivate1Timestamp
        {
            get { return _slotactivate1timestamp; }
            set
            {
                _slotactivate1timestamp = value;
                OnPropertyChanged(nameof(SlotActivate1Timestamp));
            }
        }
        public string SlotActivate2Timestamp
        {
            get { return _slotactivate2timestamp; }
            set
            {
                _slotactivate2timestamp = value;
                OnPropertyChanged(nameof(SlotActivate2Timestamp));
            }
        }
        public string SlotActivate3Timestamp
        {
            get { return _slotactivate3timestamp; }
            set
            {
                _slotactivate3timestamp = value;
                OnPropertyChanged(nameof(SlotActivate3Timestamp));
            }
        }
        public string SlotActivate4Timestamp
        {
            get { return _slotactivate4timestamp; }
            set
            {
                _slotactivate4timestamp = value;
                OnPropertyChanged(nameof(SlotActivate4Timestamp));
            }
        }
        public string SlotActivate5Timestamp
        {
            get { return _slotactivate5timestamp; }
            set
            {
                _slotactivate5timestamp = value;
                OnPropertyChanged(nameof(SlotActivate5Timestamp));
            }
        }
        public string SlotActivate6Timestamp
        {
            get { return _slotactivate6timestamp; }
            set
            {
                _slotactivate6timestamp = value;
                OnPropertyChanged(nameof(SlotActivate6Timestamp));
            }
        }
        public string Fec1
        {
            get { return _fec1; }
            set
            {
                _fec1 = value;
                OnPropertyChanged(nameof(Fec1));
            }
        }
        public string Fec2
        {
            get { return _fec2; }
            set
            {
                _fec2 = value;
                OnPropertyChanged(nameof(Fec2));
            }
        }
        public string Fec3
        {
            get { return _fec3; }
            set
            {
                _fec3 = value;
                OnPropertyChanged(nameof(Fec3));
            }
        }
        public string Fec4
        {
            get { return _fec4; }
            set
            {
                _fec4 = value;
                OnPropertyChanged(nameof(Fec4));
            }
        }
        public string Fec5
        {
            get { return _fec5; }
            set
            {
                _fec5 = value;
                OnPropertyChanged(nameof(Fec5));
            }
        }
        public string Fec6
        {
            get { return _fec6; }
            set
            {
                _fec6 = value;
                OnPropertyChanged(nameof(Fec6));
            }
        }
        public string Fec1Indicator
        {
            get { return _fec1indicator; }
            set
            {
                _fec1indicator = value;
                OnPropertyChanged(nameof(Fec1Indicator));
            }
        }
        public string Fec2Indicator
        {
            get { return _fec2indicator; }
            set
            {
                _fec2indicator = value;
                OnPropertyChanged(nameof(Fec2Indicator));
            }
        }
        public string Fec3Indicator
        {
            get { return _fec3indicator; }
            set
            {
                _fec3indicator = value;
                OnPropertyChanged(nameof(Fec3Indicator));
            }
        }
        public string Fec4Indicator
        {
            get { return _fec4indicator; }
            set
            {
                _fec4indicator = value;
                OnPropertyChanged(nameof(Fec4Indicator));
            }
        }
        public string Fec5Indicator
        {
            get { return _fec5indicator; }
            set
            {
                _fec5indicator = value;
                OnPropertyChanged(nameof(Fec5Indicator));
            }
        }
        public string Fec6Indicator
        {
            get { return _fec6indicator; }
            set
            {
                _fec6indicator = value;
                OnPropertyChanged(nameof(Fec6Indicator));
            }
        }
        public string Fec1Timestamp
        {
            get { return _fec1timestamp; }
            set
            {
                _fec1timestamp = value;
                OnPropertyChanged(nameof(Fec1Timestamp));
            }
        }
        public string Fec2Timestamp
        {
            get { return _fec2timestamp; }
            set
            {
                _fec2timestamp = value;
                OnPropertyChanged(nameof(Fec2Timestamp));
            }
        }
        public string Fec3Timestamp
        {
            get { return _fec3timestamp; }
            set
            {
                _fec3timestamp = value;
                OnPropertyChanged(nameof(Fec3Timestamp));
            }
        }
        public string Fec4Timestamp
        {
            get { return _fec4timestamp; }
            set
            {
                _fec4timestamp = value;
                OnPropertyChanged(nameof(Fec4Timestamp));
            }
        }
        public string Fec5timestamp
        {
            get { return _fec5timestamp; }
            set
            {
                _fec5timestamp = value;
                OnPropertyChanged(nameof(Fec5timestamp));
            }
        }
        public string Fec6Timestamp
        {
            get { return _fec6timestamp; }
            set
            {
                _fec6timestamp = value;
                OnPropertyChanged(nameof(Fec6Timestamp));
            }
        }
        public string Txpwr1
        {
            get { return _txpwr1; }
            set
            {
                _txpwr1 = value;
                OnPropertyChanged(nameof(Txpwr1));
            }
        }
        public string Txpwr2
        {
            get { return _txpwr2; }
            set
            {
                _txpwr2 = value;
                OnPropertyChanged(nameof(Txpwr2));
            }
        }
        public string Txpwr3
        {
            get { return _txpwr3; }
            set
            {
                _txpwr3 = value;
                OnPropertyChanged(nameof(Txpwr3));
            }
        }
        public string Txpwr4
        {
            get { return _txpwr4; }
            set
            {
                _txpwr4 = value;
                OnPropertyChanged(nameof(Txpwr4));
            }
        }
        public string Txpwr5
        {
            get { return _txpwr5; }
            set
            {
                _txpwr5 = value;
                OnPropertyChanged(nameof(Txpwr5));
            }
        }
        public string Txpwr6
        {
            get { return _txpwr6; }
            set
            {
                _txpwr6 = value;
                OnPropertyChanged(nameof(Txpwr6));
            }
        } 
        public string RemoteId1
        {
            get { return _remoteid1; }
            set
            {
                _remoteid1 = value;
                OnPropertyChanged(nameof(RemoteId1));
            }
        } 
        public string RemoteId2
        {
            get { return _remoteid2; }
            set
            {
                _remoteid2 = value;
                OnPropertyChanged(nameof(RemoteId2));
            }
        }
        public string RemoteId3
        {
            get { return _remoteid3; }
            set
            {
                _remoteid3 = value;
                OnPropertyChanged(nameof(RemoteId3));
            }
        }
        public string RemoteId4
        {
            get { return _remoteid4; }
            set
            {
                _remoteid4 = value;
                OnPropertyChanged(nameof(RemoteId4));
            }
        }
        public string RemoteId5
        {
            get { return _remoteid5; }
            set
            {
                _remoteid5 = value;
                OnPropertyChanged(nameof(RemoteId5));
            }
        }
        public string RemoteId6
        {
            get { return _remoteid6; }
            set
            {
                _remoteid6 = value;
                OnPropertyChanged(nameof(RemoteId6));
            }
        }
        public string Link1
        {
            get { return _link1; }
            set
            {
                _link1 = value;
                OnPropertyChanged(nameof(Link1));
            }
        }
        public string Link2
        {
            get { return _link2; }
            set
            {
                _link2 = value;
                OnPropertyChanged(nameof(Link2));
            }
        }
        public string Link3
        {
            get { return _link3; }
            set
            {
                _link3 = value;
                OnPropertyChanged(nameof(Link3));
            }
        }
        public string Link4
        {
            get { return _link4; }
            set
            {
                _link4 = value;
                OnPropertyChanged(nameof(Link4));
            }
        }
        public string Link5
        {
            get { return _link5; }
            set
            {
                _link5 = value;
                OnPropertyChanged(nameof(Link5));
            }
        }
        public string Link6
        {
            get { return _link6; }
            set
            {
                _link6 = value;
                OnPropertyChanged(nameof(Link6));
            }
        }
        public string Channelno1
        {
            get { return _channelno1; }
            set
            {
                _channelno1 = value;
                OnPropertyChanged(nameof(Channelno1));
            }
        }
        public string Channelno2
        {
            get { return _channelno2; }
            set
            {
                _channelno2 = value;
                OnPropertyChanged(nameof(Channelno2));
            }

        }
        public string Channelno3
        {
            get { return _channelno3; }
            set
            {
                _channelno3 = value;
                OnPropertyChanged(nameof(Channelno3));
            }
        }
        public string Channelno4
        {
            get { return _channelno4; }
            set
            {
                _channelno4 = value;
                OnPropertyChanged(nameof(Channelno4));
            }
        }
        public string Channelno5
        {
            get { return _channelno5; }
            set
            {
                _channelno5 = value;
                OnPropertyChanged(nameof(Channelno5));
            }
        }
        public string Channelno6
        {
            get { return _channelno6; }
            set
            {
                _channelno6 = value;
                OnPropertyChanged(nameof(Channelno6));
            }
        }
        public string Link1Indicator
        {
            get { return _link1indicator; }
            set
            {
                _link1indicator = value;
                OnPropertyChanged(nameof(Link1Indicator));
            }
        } public string Link2Indicator
        {
            get { return _link2indicator; }
            set
            {
                _link2indicator = value;
                OnPropertyChanged(nameof(Link2Indicator));
            }
        } public string Link3Indicator
        {
            get { return _link3indicator; }
            set
            {
                _link3indicator = value;
                OnPropertyChanged(nameof(Link3Indicator));
            }
        } public string Link4Indicator
        {
            get { return _link4indicator; }
            set
            {
                _link4indicator = value;
                OnPropertyChanged(nameof(Link4Indicator));
            }
        } public string Link5Indicator
        {
            get { return _link5indicator; }
            set
            {
                _link5indicator = value;
                OnPropertyChanged(nameof(Link5Indicator));
            }
        } public string Link6Indicator
        {
            get { return _link6indicator; }
            set
            {
                _link6indicator = value;
                OnPropertyChanged(nameof(Link6Indicator));
            }
        }
        public string Txpwr1Timestamp
        {
            get { return _txpwr1timestamp; }
            set
            {
                _txpwr1timestamp = value;
                OnPropertyChanged(nameof(Txpwr1Timestamp));
            }
        }
        public string Txpwr2Timestamp
        {
            get { return _txpwr2timestamp; }
            set
            {
                _txpwr2timestamp = value;
                OnPropertyChanged(nameof(Txpwr2Timestamp));
            }
        }
        public string Txpwr3Timestamp
        {
            get { return _txpwr3timestamp; }
            set
            {
                _txpwr3timestamp = value;
                OnPropertyChanged(nameof(Txpwr3Timestamp));
            }
        }
        public string Txpwr4Timestamp
        {
            get { return _txpwr4timestamp; }
            set
            {
                _txpwr4timestamp = value;
                OnPropertyChanged(nameof(Txpwr4Timestamp));
            }
        }
        public string Txpwr5Timestamp
        {
            get { return _txpwr5timestamp; }
            set
            {
                _txpwr5timestamp = value;
                OnPropertyChanged(nameof(Txpwr5Timestamp));
            }
        }
        public string Txpwr6Timestamp
        {
            get { return _txpwr6timestamp; }
            set
            {
                _txpwr6timestamp = value;
                OnPropertyChanged(nameof(Txpwr6Timestamp));
            }
        }
        public string Txpwrslot1
        {
            get { return _txpwrslot1; }
            set
            {
                _txpwrslot1 = value;
                OnPropertyChanged(nameof(Txpwrslot1));
            }
        }
        public string Txpwrslot2
        {
            get { return _txpwrslot2; }
            set
            {
                _txpwrslot2 = value;
                OnPropertyChanged(nameof(Txpwrslot2));
            }
        }
        public string Txpwrslot3
        {
            get { return _txpwrslot3; }
            set
            {
                _txpwrslot3 = value;
                OnPropertyChanged(nameof(Txpwrslot3));
            }
        }
        public string Txpwrslot4
        {
            get { return _txpwrslot4; }
            set
            {
                _txpwrslot4 = value;
                OnPropertyChanged(nameof(Txpwrslot4));
            }
        }
        public string Txpwrslot5
        {
            get { return _txpwrslot5; }
            set
            {
                _txpwrslot5 = value;
                OnPropertyChanged(nameof(Txpwrslot5));
            }
        }
        public string Txpwrslot6
        {
            get { return _txpwrslot6; }
            set
            {
                _txpwrslot6 = value;
                OnPropertyChanged(nameof(Txpwrslot6));
            }
        }
        public string RssiSlot1
        {
            get { return _rssislot1; }
            set
            {
                _rssislot1 = value;
                OnPropertyChanged(nameof(RssiSlot1));
            }
        }
        public string RssiSlot2
        {
            get { return _rssislot2; }
            set
            {
                _rssislot2 = value;
                OnPropertyChanged(nameof(RssiSlot2));
            }
        }
        public string RssiSlot3
        {
            get { return _rssislot3; }
            set
            {
                _rssislot3 = value;
                OnPropertyChanged(nameof(RssiSlot3));
            }
        }
        public string RssiSlot4
        {
            get { return _rssislot4; }
            set
            {
                _rssislot4 = value;
                OnPropertyChanged(nameof(RssiSlot4));
            }
        }
        public string RssiSlot5
        {
            get { return _rssislot5; }
            set
            {
                _rssislot5 = value;
                OnPropertyChanged(nameof(RssiSlot5));
            }
        }
        public string RssiSlot6
        {
            get { return _rssislot6; }
            set
            {
                _rssislot6 = value;
                OnPropertyChanged(nameof(RssiSlot6));
            }
        }
        public string RssiSlot1Timestamp
        {
            get { return _rssislot1timestamp; }
            set
            {
                _rssislot1timestamp = value;
                OnPropertyChanged(nameof(RssiSlot1Timestamp));
            }
        }
        public string RssiSlot2Timestamp
        {
            get { return _rssislot2timestamp; }
            set
            {
                _rssislot2timestamp = value;
                OnPropertyChanged(nameof(RssiSlot2Timestamp));
            }
        }
        public string RssiSlot3Timestamp
        {
            get { return _rssislot3timestamp; }
            set
            {
                _rssislot3timestamp = value;
                OnPropertyChanged(nameof(RssiSlot3Timestamp));
            }
        }
        public string RssiSlot4Timestamp
        {
            get { return _rssislot4timestamp; }
            set
            {
                _rssislot4timestamp = value;
                OnPropertyChanged(nameof(RssiSlot4Timestamp));
            }
        }
        public string RssiSlot5Timestamp
        {
            get { return _rssislot5timestamp; }
            set
            {
                _rssislot5timestamp = value;
                OnPropertyChanged(nameof(RssiSlot5Timestamp));
            }
        }
        public string RssiSlot6Timestamp
        {
            get { return _rssislot6timestamp; }
            set
            {
                _rssislot6timestamp = value;
                OnPropertyChanged(nameof(RssiSlot6Timestamp));
            }
        }
        public string SyncLoss1
        {
            get { return _syncLoss1; }
            set
            {
                _syncLoss1 = value;
                OnPropertyChanged(nameof(SyncLoss1));
            }
        }
        public string SyncLoss2
        {
            get { return _syncLoss2; }
            set
            {
                _syncLoss2 = value;
                OnPropertyChanged(nameof(SyncLoss2));
            }
        }
        public string SyncLoss3
        {
            get { return _syncLoss3; }
            set
            {
                _syncLoss3 = value;
                OnPropertyChanged(nameof(SyncLoss3));
            }
        }
        public string SyncLoss4
        {
            get { return _syncLoss4; }
            set
            {
                _syncLoss4 = value;
                OnPropertyChanged(nameof(SyncLoss4));
            }
        }
        public string SyncLoss5
        {
            get { return _syncLoss5; }
            set
            {
                _syncLoss5 = value;
                OnPropertyChanged(nameof(SyncLoss5));
            }
        }
        public string SyncLoss6
        {
            get { return _syncLoss6; }
            set
            {
                _syncLoss6 = value;
                OnPropertyChanged(nameof(SyncLoss6));
            }
        }
        public string SyncLoss1Indicator
        {
            get { return _syncLoss1indicator; }
            set
            {
                _syncLoss1indicator = value;
                OnPropertyChanged(nameof(SyncLoss1Indicator));
            }
        }
        public string SyncLoss2Indicator
        {
            get { return _syncLoss2indicator; }
            set
            {
                _syncLoss2indicator = value;
                OnPropertyChanged(nameof(SyncLoss2Indicator));
            }
        }
        public string SyncLoss3Indicator
        {
            get { return _syncLoss3indicator; }
            set
            {
                _syncLoss3indicator = value;
                OnPropertyChanged(nameof(SyncLoss3Indicator));
            }
        }
        public string SyncLoss4Indicator
        {
            get { return _syncLoss4indicator; }
            set
            {
                _syncLoss4indicator = value;
                OnPropertyChanged(nameof(SyncLoss4Indicator));
            }
        }
        public string SyncLoss5Indicator
        {
            get { return _syncLoss5indicator; }
            set
            {
                _syncLoss5indicator = value;
                OnPropertyChanged(nameof(SyncLoss5Indicator));
            }
        }
        public string SyncLoss6Indicator
        {
            get { return _syncLoss6indicator; }
            set
            {
                _syncLoss6indicator = value;
                OnPropertyChanged(nameof(SyncLoss6Indicator));
            }
        }
        public string SyncLoss1Timestamp
        {
            get { return _syncLoss1timestamp; }
            set
            {
                _syncLoss1timestamp = value;
                OnPropertyChanged(nameof(SyncLoss1Timestamp));
            }
        }
        public string SyncLoss2Timestamp
        {
            get { return _syncLoss2timestamp; }
            set
            {
                _syncLoss2timestamp = value;
                OnPropertyChanged(nameof(SyncLoss2Timestamp));
            }
        }
        public string SyncLoss3Timestamp
        {
            get { return _syncLoss3timestamp; }
            set
            {
                _syncLoss3timestamp = value;
                OnPropertyChanged(nameof(SyncLoss3Timestamp));
            }
        }
        public string SyncLoss4Timestamp
        {
            get { return _syncLoss4timestamp; }
            set
            {
                _syncLoss4timestamp = value;
                OnPropertyChanged(nameof(SyncLoss4Timestamp));
            }
        }
        public string SyncLoss5Timestamp
        {
            get { return _syncLoss5timestamp; }
            set
            {
                _syncLoss5timestamp = value;
                OnPropertyChanged(nameof(SyncLoss5Timestamp));
            }
        }
        public string SyncLoss6Timestamp
        {
            get { return _syncLoss6timestamp; }
            set
            {
                _syncLoss6timestamp = value;
                OnPropertyChanged(nameof(SyncLoss6Timestamp));
            }
        }
        public string Snr1
        {
            get { return _snr1; }
            set
            {
                _snr1 = value;
                OnPropertyChanged(nameof(Snr1));
            }
        }
        public string Snr2
        {
            get { return _snr2; }
            set
            {
                _snr2 = value;
                OnPropertyChanged(nameof(Snr2));
            }
        }
        public string Snr3
        {
            get { return _snr3; }
            set
            {
                _snr3 = value;
                OnPropertyChanged(nameof(Snr3));
            }
        }
        public string Snr4
        {
            get { return _snr4; }
            set
            {
                _snr4 = value;
                OnPropertyChanged(nameof(Snr4));
            }
        }
        public string Snr5
        {
            get { return _snr5; }
            set
            {
                _snr5 = value;
                OnPropertyChanged(nameof(Snr5));
            }
        }
        public string Snr6
        {
            get { return _snr6; }
            set
            {
                _snr6 = value;
                OnPropertyChanged(nameof(Snr6));
            }
        }
        public string Snr1Timestamp
        {
            get { return _snr1timestamp; }
            set
            {
                _snr1timestamp = value;
                OnPropertyChanged(nameof(Snr1Timestamp));
            }
        }
        public string Snr2Timestamp
        {
            get { return _snr2timestamp; }
            set
            {
                _snr2timestamp = value;
                OnPropertyChanged(nameof(Snr2Timestamp));
            }
        }
        public string Snr3Timestamp
        {
            get { return _snr3timestamp; }
            set
            {
                _snr3timestamp = value;
                OnPropertyChanged(nameof(Snr3Timestamp));
            }
        }
        public string Snr4Timestamp
        {
            get { return _snr4timestamp; }
            set
            {
                _snr4timestamp = value;
                OnPropertyChanged(nameof(Snr4Timestamp));
            }
        }
        public string Snr5Timestamp
        {
            get { return _snr5timestamp; }
            set
            {
                _snr5timestamp = value;
                OnPropertyChanged(nameof(Snr5Timestamp));
            }
        }
        public string Snr6Timestamp
        {
            get { return _snr6timestamp; }
            set
            {
                _snr6timestamp = value;
                OnPropertyChanged(nameof(Snr6Timestamp));
            }
        }
        public string Voltage5VA
        {
            get { return _voltage5VA; }
            set
            {
                _voltage5VA = value;
                OnPropertyChanged(nameof(Voltage5VA));
            }
        }
        public string Voltage5VATimestamp
        {
            get { return _voltage5VAtimestamp; }
            set
            {
                _voltage5VAtimestamp = value;
                OnPropertyChanged(nameof(Voltage5VATimestamp));
            }
        }
        public string Voltage12v
        {
            get { return _voltage12v; }
            set
            {
                _voltage12v = value;
                OnPropertyChanged(nameof(Voltage12v));
            }
        }
        public string Voltage12vTimestamp
        {
            get { return _voltage12vtimestamp; }
            set
            {
                _voltage12vtimestamp = value;
                OnPropertyChanged(nameof(Voltage12vTimestamp));
            }
        }
        public string Voltageneg5v
        {
            get { return _voltageneg5v; }
            set
            {
                _voltageneg5v = value;
                OnPropertyChanged(nameof(Voltageneg5v));
            }
        }
        public string Voltageneg5vTimestamp
        {
            get { return _voltage12vtimestamp; }
            set
            {
                _voltage12vtimestamp = value;
                OnPropertyChanged(nameof(Voltageneg5vTimestamp));
            }
        }
        public string Voltage49v
        {
            get { return _voltage49v; }
            set
            {
                _voltage49v = value;
                OnPropertyChanged(nameof(Voltage49v));
            }
        }
        public string Voltage49vTimestamp
        {
            get { return _voltage49vtimestamp; }
            set
            {
                _voltage49vtimestamp = value;
                OnPropertyChanged(nameof(Voltage49vTimestamp));
            }
        }
        public string Indexhealth
        {
            get { return _indexhealth; }
            set
            {
                _indexhealth = value;
                OnPropertyChanged(nameof(Indexhealth));
            }
        }
        public string IndexhealthTimestamp
        {
            get { return _indexhealthtimestamp; }
            set
            {
                _indexhealthtimestamp = value;
                OnPropertyChanged(nameof(IndexhealthTimestamp));
            }
        }

        //Radio2
        
            string _terminalmodebase_2 = string.Empty;
            string _terminalmoderemote_2 = string.Empty;
            string _terminalmoderepeater_2 = string.Empty;

            string _terminalmodetimestamp_2 = string.Empty;

            string _managerip_2 = string.Empty;
            string _managernetmaskip_2 = string.Empty;

            string _manageriptimestamp_2 = string.Empty;
            string _managernetmasktimestamp_2 = string.Empty;

            string _slotactivate1_2 = string.Empty;
            string _slotactivate2_2 = string.Empty;
            string _slotactivate3_2 = string.Empty;
            string _slotactivate4_2 = string.Empty;
            string _slotactivate5_2 = string.Empty;
            string _slotactivate6_2 = string.Empty;

            string _slotactivate1indicator_2 = string.Empty;
            string _slotactivate2indicator_2 = string.Empty;
            string _slotactivate3indicator_2 = string.Empty;
            string _slotactivate4indicator_2 = string.Empty;
            string _slotactivate5indicator_2 = string.Empty;
            string _slotactivate6indicator_2 = string.Empty;

            string _slotactivate1timestamp_2 = string.Empty;
            string _slotactivate2timestamp_2 = string.Empty;
            string _slotactivate3timestamp_2 = string.Empty;
            string _slotactivate4timestamp_2 = string.Empty;
            string _slotactivate5timestamp_2 = string.Empty;
            string _slotactivate6timestamp_2 = string.Empty;

            string _fec1_2 = string.Empty;
            string _fec2_2 = string.Empty;
            string _fec3_2 = string.Empty;
            string _fec4_2 = string.Empty;
            string _fec5_2 = string.Empty;
            string _fec6_2= string.Empty;

            string _fec1indicator_2 = string.Empty;
            string _fec2indicator_2 = string.Empty;
            string _fec3indicator_2 = string.Empty;
            string _fec4indicator_2 = string.Empty;
            string _fec5indicator_2 = string.Empty;
            string _fec6indicator_2 = string.Empty;

            string _fec1timestamp_2 = string.Empty;
            string _fec2timestamp_2 = string.Empty;
            string _fec3timestamp_2 = string.Empty;
            string _fec4timestamp_2 = string.Empty;
            string _fec5timestamp_2 = string.Empty;
            string _fec6timestamp_2 = string.Empty;


            string _txpwr1_2 = string.Empty;
            string _txpwr2_2 = string.Empty;
            string _txpwr3_2 = string.Empty;
            string _txpwr4_2 = string.Empty;
            string _txpwr5_2 = string.Empty;
            string _txpwr6_2 = string.Empty;

            string _txpwrslot1_2 = string.Empty;
            string _txpwrslot2_2 = string.Empty;
            string _txpwrslot3_2 = string.Empty;
            string _txpwrslot4_2 = string.Empty;
            string _txpwrslot5_2 = string.Empty;
            string _txpwrslot6_2 = string.Empty;

            string _remoteid1_2 = string.Empty;
            string _remoteid2_2 = string.Empty;
            string _remoteid3_2 = string.Empty;
            string _remoteid4_2 = string.Empty;
            string _remoteid5_2 = string.Empty;
            string _remoteid6_2 = string.Empty;

            string _link1_2 = string.Empty;
            string _link2_2 = string.Empty;
            string _link3_2 = string.Empty;
            string _link4_2 = string.Empty;
            string _link5_2 = string.Empty;
            string _link6_2 = string.Empty;

            string _link1indicator_2 = string.Empty;
            string _link2indicator_2 = string.Empty;
            string _link3indicator_2 = string.Empty;
            string _link4indicator_2 = string.Empty;
            string _link5indicator_2 = string.Empty;
            string _link6indicator_2 = string.Empty;

            string _channelno1_2 = string.Empty;
            string _channelno2_2 = string.Empty;
            string _channelno3_2 = string.Empty;
            string _channelno4_2 = string.Empty;
            string _channelno5_2 = string.Empty;
            string _channelno6_2 = string.Empty;


            string _txpwr1timestamp_2 = string.Empty;
            string _txpwr2timestamp_2 = string.Empty;
            string _txpwr3timestamp_2= string.Empty;
            string _txpwr4timestamp_2 = string.Empty;
            string _txpwr5timestamp_2 = string.Empty;
            string _txpwr6timestamp_2 = string.Empty;

            string _rssislot1_2 = string.Empty;
            string _rssislot2_2 = string.Empty;
            string _rssislot3_2 = string.Empty;
            string _rssislot4_2 = string.Empty;
            string _rssislot5_2 = string.Empty;
            string _rssislot6_2 = string.Empty;

            string _rssislot1timestamp_2 = string.Empty;
            string _rssislot2timestamp_2 = string.Empty;
            string _rssislot3timestamp_2 = string.Empty;
            string _rssislot4timestamp_2 = string.Empty;
            string _rssislot5timestamp_2 = string.Empty;
            string _rssislot6timestamp_2 = string.Empty;

            string _syncLoss1_2 = string.Empty;
            string _syncLoss2_2 = string.Empty;
            string _syncLoss3_2 = string.Empty;
            string _syncLoss4_2 = string.Empty;
            string _syncLoss5_2 = string.Empty;
            string _syncLoss6_2 = string.Empty;

            string _syncLoss1indicator_2 = string.Empty;
            string _syncLoss2indicator_2 = string.Empty;
            string _syncLoss3indicator_2 = string.Empty;
            string _syncLoss4indicator_2 = string.Empty;
            string _syncLoss5indicator_2 = string.Empty;
            string _syncLoss6indicator_2 = string.Empty;

            string _syncLoss1timestamp_2 = string.Empty;
            string _syncLoss2timestamp_2 = string.Empty;
            string _syncLoss3timestamp_2 = string.Empty;
            string _syncLoss4timestamp_2 = string.Empty;
            string _syncLoss5timestamp_2 = string.Empty;
            string _syncLoss6timestamp_2 = string.Empty;

            string _snr1_2 = string.Empty;
            string _snr2_2 = string.Empty;
            string _snr3_2 = string.Empty;
            string _snr4_2 = string.Empty;
            string _snr5_2 = string.Empty;
            string _snr6_2 = string.Empty;

            string _snr1timestamp_2 = string.Empty;
            string _snr2timestamp_2 = string.Empty;
            string _snr3timestamp_2 = string.Empty;
            string _snr4timestamp_2 = string.Empty;
            string _snr5timestamp_2 = string.Empty;
            string _snr6timestamp_2 = string.Empty;

            string _voltage5VA_2 = string.Empty;
            string _voltage12v_2 = string.Empty;
            string _voltageneg5v_2 = string.Empty;
            string _voltage49v_2 = string.Empty;

            string _voltage5VAtimestamp_2 = string.Empty;
            string _voltage12vtimestamp_2= string.Empty;
            string _voltageneg5vtimestamp_2 = string.Empty;
            string _voltage49vtimestamp_2 = string.Empty;

            string _indexhealth_2 = string.Empty;
            string _indexhealthtimestamp_2 = string.Empty;


            public string TerminalModeBase_2
            {
                get { return _terminalmodebase_2; }
                set
                {
                    _terminalmodebase_2 = value;
                    OnPropertyChanged(nameof(TerminalModeBase_2));
                }
            }
            public string TerminalModeRemote_2
            {
                get { return _terminalmoderemote_2; }
                set
                {
                    _terminalmoderemote_2 = value;
                    OnPropertyChanged(nameof(TerminalModeRemote_2));
                }
            }
            public string TerminalModeRepeater_2
            {
                get { return _terminalmoderepeater_2; }
                set
                {
                    _terminalmoderepeater_2 = value;
                    OnPropertyChanged(nameof(TerminalModeRepeater_2));
                }
            }
            public string TerminalmodeTimestamp_2
            {
                get { return _terminalmodetimestamp_2; }
                set
                {
                    _terminalmodetimestamp_2 = value;
                    OnPropertyChanged(nameof(TerminalmodeTimestamp_2));
                }
            }
            public string ManagerIp_2
            {
                get { return _managerip_2; }
                set
                {
                    _managerip_2 = value;
                    OnPropertyChanged(nameof(ManagerIp_2));
                }
            }
            public string ManageripTimestamp_2
            {
                get { return _manageriptimestamp_2; }
                set
                {
                    _manageriptimestamp_2 = value;
                    OnPropertyChanged(nameof(ManageripTimestamp_2));
                }
            }
            public string ManagerNetMaskIp_2
            {
                get { return _managernetmaskip_2; }
                set
                {
                    _managernetmaskip_2 = value;
                    OnPropertyChanged(nameof(ManagerNetMaskIp_2));
                }
            }
            public string ManagerNetMaskTimestamp_2
            {
                get { return _managernetmasktimestamp_2; }
                set
                {
                    _managernetmasktimestamp_2 = value;
                    OnPropertyChanged(nameof(ManagerNetMaskTimestamp_2));
                }
            }
            public string SlotActivate1_2
            {
                get { return _slotactivate1_2; }
                set
                {
                    _slotactivate1_2 = value;
                    OnPropertyChanged(nameof(SlotActivate1_2));
                }
            }
            public string SlotActivate2_2
            {
                get { return _slotactivate2_2; }
                set
                {
                    _slotactivate2_2 = value;
                    OnPropertyChanged(nameof(SlotActivate2_2));
                }
            }
            public string SlotActivate3_2
            {
                get { return _slotactivate3_2; }
                set
                {
                    _slotactivate3_2 = value;
                    OnPropertyChanged(nameof(SlotActivate3_2));
                }
            }
            public string SlotActivate4_2
            {
                get { return _slotactivate4_2; }
                set
                {
                    _slotactivate4_2 = value;
                    OnPropertyChanged(nameof(SlotActivate4_2));
                }
            }
            public string SlotActivate5_2
            {
                get { return _slotactivate5_2; }
                set
                {
                    _slotactivate5_2 = value;
                    OnPropertyChanged(nameof(SlotActivate5_2));
                }
            }
            public string SlotActivate6_2
            {
                get { return _slotactivate6_2; }
                set
                {
                    _slotactivate6_2 = value;
                    OnPropertyChanged(nameof(SlotActivate6_2));
                }
            }
            public string SlotActivate1Indicator_2
            {
                get { return _slotactivate1indicator_2; }
                set
                {
                    _slotactivate1indicator_2 = value;
                    OnPropertyChanged(nameof(SlotActivate1Indicator_2));
                }
            }
            public string SlotActivate2Indicator_2
            {
                get { return _slotactivate2indicator_2; }
                set
                {
                    _slotactivate2indicator_2 = value;
                    OnPropertyChanged(nameof(SlotActivate2Indicator_2));
                }
            }
            public string SlotActivate3Indicator_2
            {
                get { return _slotactivate3indicator_2; }
                set
                {
                    _slotactivate3indicator_2 = value;
                    OnPropertyChanged(nameof(SlotActivate3Indicator_2));
                }
            }
            public string SlotActivate4Indicator_2
            {
                get { return _slotactivate4indicator_2; }
                set
                {
                    _slotactivate4indicator_2 = value;
                    OnPropertyChanged(nameof(SlotActivate4Indicator_2));
                }
            }
            public string SlotActivate5Indicator_2
            {
                get { return _slotactivate5indicator_2; }
                set
                {
                    _slotactivate5indicator_2 = value;
                    OnPropertyChanged(nameof(SlotActivate5Indicator_2));
                }
            }
            public string SlotActivate6Indicator_2
            {
                get { return _slotactivate5indicator_2; }
                set
                {
                    _slotactivate5indicator_2 = value;
                    OnPropertyChanged(nameof(SlotActivate6Indicator_2));
                }
            }
            public string SlotActivate1Timestamp_2
            {
                get { return _slotactivate1timestamp_2; }
                set
                {
                    _slotactivate1timestamp_2 = value;
                    OnPropertyChanged(nameof(SlotActivate1Timestamp_2));
                }
            }
            public string SlotActivate2Timestamp_2
            {
                get { return _slotactivate2timestamp_2; }
                set
                {
                    _slotactivate2timestamp_2 = value;
                    OnPropertyChanged(nameof(SlotActivate2Timestamp_2));
                }
            }
            public string SlotActivate3Timestamp_2
            {
                get { return _slotactivate3timestamp_2; }
                set
                {
                    _slotactivate3timestamp_2 = value;
                    OnPropertyChanged(nameof(SlotActivate3Timestamp_2));
                }
            }
            public string SlotActivate4Timestamp_2
            {
                get { return _slotactivate4timestamp_2; }
                set
                {
                    _slotactivate4timestamp_2 = value;
                    OnPropertyChanged(nameof(SlotActivate4Timestamp_2));
                }
            }
            public string SlotActivate5Timestamp_2
            {
                get { return _slotactivate5timestamp_2; }
                set
                {
                    _slotactivate5timestamp_2 = value;
                    OnPropertyChanged(nameof(SlotActivate5Timestamp_2));
                }
            }
            public string SlotActivate6Timestamp_2
            {
                get { return _slotactivate6timestamp_2; }
                set
                {
                    _slotactivate6timestamp_2 = value;
                    OnPropertyChanged(nameof(SlotActivate6Timestamp_2));
                }
            }
            public string Fec1_2
            {
                get { return _fec1_2; }
                set
                {
                    _fec1_2 = value;
                    OnPropertyChanged(nameof(Fec1_2));
                }
            }
            public string Fec2_2
            {
                get { return _fec2_2; }
                set
                {
                    _fec2_2= value;
                    OnPropertyChanged(nameof(Fec2_2));
                }
            }
            public string Fec3_2
            {
                get { return _fec3_2; }
                set
                {
                    _fec3_2 = value;
                    OnPropertyChanged(nameof(Fec3_2));
                }
            }
            public string Fec4_2
            {
                get { return _fec4_2; }
                set
                {
                    _fec4 = value;
                    OnPropertyChanged(nameof(Fec4_2));
                }
            }
            public string Fec5_2
            {
                get { return _fec5_2; }
                set
                {
                    _fec5_2 = value;
                    OnPropertyChanged(nameof(Fec5_2));
                }
            }
            public string Fec6_2
            {
                get { return _fec6_2; }
                set
                {
                    _fec6_2 = value;
                    OnPropertyChanged(nameof(Fec6_2));
                }
            }
            public string Fec1Indicator_2
            {
                get { return _fec1indicator_2; }
                set
                {
                    _fec1indicator_2 = value;
                    OnPropertyChanged(nameof(Fec1Indicator_2));
                }
            }
            public string Fec2Indicator_2
            {
                get { return _fec2indicator_2; }
                set
                {
                    _fec2indicator_2 = value;
                    OnPropertyChanged(nameof(Fec2Indicator_2));
                }
            }
            public string Fec3Indicator_2
            {
                get { return _fec3indicator_2; }
                set
                {
                    _fec3indicator_2 = value;
                    OnPropertyChanged(nameof(Fec3Indicator_2));
                }
            }
            public string Fec4Indicator_2
            {
                get { return _fec4indicator_2; }
                set
                {
                    _fec4indicator_2 = value;
                    OnPropertyChanged(nameof(Fec4Indicator_2));
                }
            }
            public string Fec5Indicator_2
            {
                get { return _fec5indicator_2; }
                set
                {
                    _fec5indicator_2= value;
                    OnPropertyChanged(nameof(Fec5Indicator_2));
                }
            }
            public string Fec6Indicator_2
            {
                get { return _fec6indicator_2; }
                set
                {
                    _fec6indicator_2 = value;
                    OnPropertyChanged(nameof(Fec6Indicator_2));
                }
            }
            public string Fec1Timestamp_2
            {
                get { return _fec1timestamp_2; }
                set
                {
                    _fec1timestamp_2 = value;
                    OnPropertyChanged(nameof(Fec1Timestamp_2));
                }
            }
            public string Fec2Timestamp_2
            {
                get { return _fec2timestamp_2; }
                set
                {
                    _fec2timestamp_2= value;
                    OnPropertyChanged(nameof(Fec2Timestamp_2));
                }
            }
            public string Fec3Timestamp_2
            {
                get { return _fec3timestamp_2; }
                set
                {
                    _fec3timestamp_2 = value;
                    OnPropertyChanged(nameof(Fec3Timestamp_2));
                }
            }
            public string Fec4Timestamp_2
            {
                get { return _fec4timestamp_2; }
                set
                {
                    _fec4timestamp_2 = value;
                    OnPropertyChanged(nameof(Fec4Timestamp_2));
                }
            }
            public string Fec5timestamp_2
            {
                get { return _fec5timestamp_2; }
                set
                {
                    _fec5timestamp_2 = value;
                    OnPropertyChanged(nameof(Fec5timestamp_2));
                }
            }
            public string Fec6Timestamp_2
            {
                get { return _fec6timestamp_2; }
                set
                {
                    _fec6timestamp_2 = value;
                    OnPropertyChanged(nameof(Fec6Timestamp_2));
                }
            }
            public string Txpwr1_2
            {
                get { return _txpwr1_2; }
                set
                {
                    _txpwr1_2 = value;
                    OnPropertyChanged(nameof(Txpwr1_2));
                }
            }
            public string Txpwr2_2
            {
                get { return _txpwr2_2; }
                set
                {
                    _txpwr2_2 = value;
                    OnPropertyChanged(nameof(Txpwr2_2));
                }
            }
            public string Txpwr3_2
            {
                get { return _txpwr3_2; }
                set
                {
                    _txpwr3_2 = value;
                    OnPropertyChanged(nameof(Txpwr3_2));
                }
            }
            public string Txpwr4_2
            {
                get { return _txpwr4_2; }
                set
                {
                    _txpwr4_2 = value;
                    OnPropertyChanged(nameof(Txpwr4_2));
                }
            }
            public string Txpwr5_2
            {
                get { return _txpwr5_2; }
                set
                {
                    _txpwr5_2 = value;
                    OnPropertyChanged(nameof(Txpwr5_2));
                }
            }
            public string Txpwr6_2
            {
                get { return _txpwr6_2; }
                set
                {
                    _txpwr6_2 = value;
                    OnPropertyChanged(nameof(Txpwr6_2));
                }
            }
            public string RemoteId1_2
            {
                get { return _remoteid1_2; }
                set
                {
                    _remoteid1_2 = value;
                    OnPropertyChanged(nameof(RemoteId1_2));
                }
            }
            public string RemoteId2_2
            {
                get { return _remoteid2_2; }
                set
                {
                    _remoteid2_2 = value;
                    OnPropertyChanged(nameof(RemoteId2_2));
                }
            }
            public string RemoteId3_2
            {
                get { return _remoteid3_2; }
                set
                {
                    _remoteid3_2 = value;
                    OnPropertyChanged(nameof(RemoteId3_2));
                }
            }
            public string RemoteId4_2
            {
                get { return _remoteid4_2; }
                set
                {
                    _remoteid4_2 = value;
                    OnPropertyChanged(nameof(RemoteId4_2));
                }
            }
            public string RemoteId5_2
            {
                get { return _remoteid5_2; }
                set
                {
                    _remoteid5_2 = value;
                    OnPropertyChanged(nameof(RemoteId5_2));
                }
            }
            public string RemoteId6_2
            {
                get { return _remoteid6_2; }
                set
                {
                    _remoteid6_2 = value;
                    OnPropertyChanged(nameof(RemoteId6_2));
                }
            }
            public string Link1_2
            {
                get { return _link1_2; }
                set
                {
                    _link1_2 = value;
                    OnPropertyChanged(nameof(Link1_2));
                }
            }
            public string Link2_2
            {
                get { return _link2_2; }
                set
                {
                    _link2_2 = value;
                    OnPropertyChanged(nameof(Link2_2));
                }
            }
            public string Link3_2
            {
                get { return _link3_2; }
                set
                {
                    _link3_2 = value;
                    OnPropertyChanged(nameof(Link3_2));
                }
            }
            public string Link4_2
            {
                get { return _link4_2; }
                set
                {
                    _link4_2 = value;
                    OnPropertyChanged(nameof(Link4_2));
                }
            }
            public string Link5_2
            {
                get { return _link5_2; }
                set
                {
                    _link5_2 = value;
                    OnPropertyChanged(nameof(Link5_2));
                }
            }
            public string Link6_2
            {
                get { return _link6_2; }
                set
                {
                    _link6_2 = value;
                    OnPropertyChanged(nameof(Link6_2));
                }
            }
            public string Channelno1_2
            {
                get { return _channelno1_2; }
                set
                {
                    _channelno1_2 = value;
                    OnPropertyChanged(nameof(Channelno1_2));
                }
            }
            public string Channelno2_2
            {
                get { return _channelno2_2; }
                set
                {
                    _channelno2_2 = value;
                    OnPropertyChanged(nameof(Channelno2_2));
                }

            }
            public string Channelno3_2
            {
                get { return _channelno3_2; }
                set
                {
                    _channelno3_2 = value;
                    OnPropertyChanged(nameof(Channelno3_2));
                }
            }
            public string Channelno4_2
            {
                get { return _channelno4_2; }
                set
                {
                    _channelno4_2 = value;
                    OnPropertyChanged(nameof(Channelno4_2));
                }
            }
            public string Channelno5_2
            {
                get { return _channelno5_2; }
                set
                {
                    _channelno5_2 = value;
                    OnPropertyChanged(nameof(Channelno5_2));
                }
            }
            public string Channelno6_2
            {
                get { return _channelno6_2; }
                set
                {
                    _channelno6_2 = value;
                    OnPropertyChanged(nameof(Channelno6_2));
                }
            }
            public string Link1Indicator_2
            {
                get { return _link1indicator_2; }
                set
                {
                    _link1indicator_2 = value;
                    OnPropertyChanged(nameof(Link1Indicator_2));
                }
            }
            public string Link2Indicator_2
            {
                get { return _link2indicator_2; }
                set
                {
                    _link2indicator_2 = value;
                    OnPropertyChanged(nameof(Link2Indicator_2));
                }
            }
            public string Link3Indicator_2
            {
                get { return _link3indicator_2; }
                set
                {
                    _link3indicator_2 = value;
                    OnPropertyChanged(nameof(Link3Indicator_2));
                }
            }
            public string Link4Indicator_2
            {
                get { return _link4indicator_2; }
                set
                {
                    _link4indicator_2 = value;
                    OnPropertyChanged(nameof(Link4Indicator_2));
                }
            }
            public string Link5Indicator_2
            {
                get { return _link5indicator_2; }
                set
                {
                    _link5indicator_2 = value;
                    OnPropertyChanged(nameof(Link5Indicator_2));
                }
            }
            public string Link6Indicator_2
            {
                get { return _link6indicator_2; }
                set
                {
                    _link6indicator_2 = value;
                    OnPropertyChanged(nameof(Link6Indicator_2));
                }
            }
            public string Txpwr1Timestamp_2
            {
                get { return _txpwr1timestamp_2; }
                set
                {
                    _txpwr1timestamp_2 = value;
                    OnPropertyChanged(nameof(Txpwr1Timestamp_2));
                }
            }
            public string Txpwr2Timestamp_2
            {
                get { return _txpwr2timestamp_2; }
                set
                {
                    _txpwr2timestamp_2 = value;
                    OnPropertyChanged(nameof(Txpwr2Timestamp_2));
                }
            }
            public string Txpwr3Timestamp_2
            {
                get { return _txpwr3timestamp_2; }
                set
                {
                    _txpwr3timestamp_2 = value;
                    OnPropertyChanged(nameof(Txpwr3Timestamp_2));
                }
            }
            public string Txpwr4Timestamp_2
            {
                get { return _txpwr4timestamp_2; }
                set
                {
                    _txpwr4timestamp_2 = value;
                    OnPropertyChanged(nameof(Txpwr4Timestamp_2));
                }
            }
            public string Txpwr5Timestamp_2
            {
                get { return _txpwr5timestamp_2; }
                set
                {
                    _txpwr5timestamp_2 = value;
                    OnPropertyChanged(nameof(Txpwr5Timestamp_2));
                }
            }
            public string Txpwr6Timestamp_2
            {
                get { return _txpwr6timestamp_2; }
                set
                {
                    _txpwr6timestamp_2 = value;
                    OnPropertyChanged(nameof(Txpwr6Timestamp_2));
                }
            }
            public string Txpwrslot1_2
            {
                get { return _txpwrslot1_2; }
                set
                {
                    _txpwrslot1_2 = value;
                    OnPropertyChanged(nameof(Txpwrslot1_2));
                }
            }
            public string Txpwrslot2_2
            {
                get { return _txpwrslot2_2; }
                set
                {
                    _txpwrslot2_2 = value;
                    OnPropertyChanged(nameof(Txpwrslot2_2));
                }
            }
            public string Txpwrslot3_2
            {
                get { return _txpwrslot3_2; }
                set
                {
                    _txpwrslot3_2 = value;
                    OnPropertyChanged(nameof(Txpwrslot3_2));
                }
            }
            public string Txpwrslot4_2
            {
                get { return _txpwrslot4_2; }
                set
                {
                    _txpwrslot4_2 = value;
                    OnPropertyChanged(nameof(Txpwrslot4_2));
                }
            }
            public string Txpwrslot5_2
            {
                get { return _txpwrslot5_2; }
                set
                {
                    _txpwrslot5_2 = value;
                    OnPropertyChanged(nameof(Txpwrslot5_2));
                }
            }
            public string Txpwrslot6_2
            {
                get { return _txpwrslot6_2; }
                set
                {
                    _txpwrslot6_2 = value;
                    OnPropertyChanged(nameof(Txpwrslot6_2));
                }
            }
            public string RssiSlot1_2
            {
                get { return _rssislot1_2; }
                set
                {
                    _rssislot1_2 = value;
                    OnPropertyChanged(nameof(RssiSlot1_2));
                }
            }
            public string RssiSlot2_2
            {
                get { return _rssislot2_2; }
                set
                {
                    _rssislot2_2 = value;
                    OnPropertyChanged(nameof(RssiSlot2_2));
                }
            }
            public string RssiSlot3_2
            {
                get { return _rssislot3_2; }
                set
                {
                    _rssislot3_2 = value;
                    OnPropertyChanged(nameof(RssiSlot3_2));
                }
            }
            public string RssiSlot4_2
            {
                get { return _rssislot4_2; }
                set
                {
                    _rssislot4_2 = value;
                    OnPropertyChanged(nameof(RssiSlot4_2));
                }
            }
            public string RssiSlot5_2
            {
                get { return _rssislot5_2; }
                set
                {
                    _rssislot5_2 = value;
                    OnPropertyChanged(nameof(RssiSlot5_2));
                }
            }
            public string RssiSlot6_2
            {
                get { return _rssislot6_2; }
                set
                {
                    _rssislot6_2 = value;
                    OnPropertyChanged(nameof(RssiSlot6_2));
                }
            }
            public string RssiSlot1Timestamp_2
            {
                get { return _rssislot1timestamp_2; }
                set
                {
                    _rssislot1timestamp_2 = value;
                    OnPropertyChanged(nameof(RssiSlot1Timestamp_2));
                }
            }
            public string RssiSlot2Timestamp_2
            {
                get { return _rssislot2timestamp_2; }
                set
                {
                    _rssislot2timestamp_2 = value;
                    OnPropertyChanged(nameof(RssiSlot2Timestamp_2));
                }
            }
            public string RssiSlot3Timestamp_2
            {
                get { return _rssislot3timestamp_2; }
                set
                {
                    _rssislot3timestamp_2 = value;
                    OnPropertyChanged(nameof(RssiSlot3Timestamp_2));
                }
            }
            public string RssiSlot4Timestamp_2
            {
                get { return _rssislot4timestamp_2; }
                set
                {
                    _rssislot4timestamp_2= value;
                    OnPropertyChanged(nameof(RssiSlot4Timestamp_2));
                }
            }
            public string RssiSlot5Timestamp_2
            {
                get { return _rssislot5timestamp_2; }
                set
                {
                    _rssislot5timestamp_2 = value;
                    OnPropertyChanged(nameof(RssiSlot5Timestamp_2));
                }
            }
            public string RssiSlot6Timestamp_2
            {
                get { return _rssislot6timestamp_2; }
                set
                {
                    _rssislot6timestamp_2= value;
                    OnPropertyChanged(nameof(RssiSlot6Timestamp_2));
                }
            }
            public string SyncLoss1_2
            {
                get { return _syncLoss1_2; }
                set
                {
                    _syncLoss1_2 = value;
                    OnPropertyChanged(nameof(SyncLoss1_2));
                }
            }
            public string SyncLoss2_2
            {
                get { return _syncLoss2_2; }
                set
                {
                    _syncLoss2_2 = value;
                    OnPropertyChanged(nameof(SyncLoss2_2));
                }
            }
            public string SyncLoss3_2
            {
                get { return _syncLoss3_2; }
                set
                {
                    _syncLoss3_2 = value;
                    OnPropertyChanged(nameof(SyncLoss3_2));
                }
            }
            public string SyncLoss4_2
            {
                get { return _syncLoss4_2; }
                set
                {
                    _syncLoss4_2 = value;
                    OnPropertyChanged(nameof(SyncLoss4_2));
                }
            }
            public string SyncLoss5_2
            {
                get { return _syncLoss5_2; }
                set
                {
                    _syncLoss5_2 = value;
                    OnPropertyChanged(nameof(SyncLoss5_2));
                }
            }
            public string SyncLoss6_2
            {
                get { return _syncLoss6_2; }
                set
                {
                    _syncLoss6_2= value;
                    OnPropertyChanged(nameof(SyncLoss6_2));
                }
            }
            public string SyncLoss1Indicator_2
            {
                get { return _syncLoss1indicator_2; }
                set
                {
                    _syncLoss1indicator_2 = value;
                    OnPropertyChanged(nameof(SyncLoss1Indicator_2));
                }
            }
            public string SyncLoss2Indicator_2
            {
                get { return _syncLoss2indicator_2; }
                set
                {
                    _syncLoss2indicator_2 = value;
                    OnPropertyChanged(nameof(SyncLoss2Indicator_2));
                }
            }
            public string SyncLoss3Indicator_2
            {
                get { return _syncLoss3indicator_2; }
                set
                {
                    _syncLoss3indicator_2 = value;
                    OnPropertyChanged(nameof(SyncLoss3Indicator_2));
                }
            }
            public string SyncLoss4Indicator_2
            {
                get { return _syncLoss4indicator_2; }
                set
                {
                    _syncLoss4indicator_2 = value;
                    OnPropertyChanged(nameof(SyncLoss4Indicator_2));
                }
            }
            public string SyncLoss5Indicator_2
            {
                get { return _syncLoss5indicator_2; }
                set
                {
                    _syncLoss5indicator_2 = value;
                    OnPropertyChanged(nameof(SyncLoss5Indicator_2));
                }
            }
            public string SyncLoss6Indicator_2
            {
                get { return _syncLoss6indicator_2; }
                set
                {
                    _syncLoss6indicator_2 = value;
                    OnPropertyChanged(nameof(SyncLoss6Indicator_2));
                }
            }
            public string SyncLoss1Timestamp_2
            {
                get { return _syncLoss1timestamp_2; }
                set
                {
                    _syncLoss1timestamp_2 = value;
                    OnPropertyChanged(nameof(SyncLoss1Timestamp_2));
                }
            }
            public string SyncLoss2Timestamp_2
            {
                get { return _syncLoss2timestamp_2; }
                set
                {
                    _syncLoss2timestamp_2 = value;
                    OnPropertyChanged(nameof(SyncLoss2Timestamp_2));
                }
            }
            public string SyncLoss3Timestamp_2
            {
                get { return _syncLoss3timestamp_2; }
                set
                {
                    _syncLoss3timestamp_2= value;
                    OnPropertyChanged(nameof(SyncLoss3Timestamp_2));
                }
            }
            public string SyncLoss4Timestamp_2
            {
                get { return _syncLoss4timestamp_2; }
                set
                {
                    _syncLoss4timestamp_2= value;
                    OnPropertyChanged(nameof(SyncLoss4Timestamp_2));
                }
            }
            public string SyncLoss5Timestamp_2
            {
                get { return _syncLoss5timestamp_2; }
                set
                {
                    _syncLoss5timestamp_2 = value;
                    OnPropertyChanged(nameof(SyncLoss5Timestamp_2));
                }
            }
            public string SyncLoss6Timestamp_2
            {
                get { return _syncLoss6timestamp_2; }
                set
                {
                    _syncLoss6timestamp_2 = value;
                    OnPropertyChanged(nameof(SyncLoss6Timestamp_2));
                }
            }
            public string Snr1_2
            {
                get { return _snr1_2; }
                set
                {
                    _snr1_2 = value;
                    OnPropertyChanged(nameof(Snr1_2));
                }
            }
            public string Snr2_2
            {
                get { return _snr2_2; }
                set
                {
                    _snr2_2 = value;
                    OnPropertyChanged(nameof(Snr2_2));
                }
            }
            public string Snr3_2
            {
                get { return _snr3_2; }
                set
                {
                    _snr3_2 = value;
                    OnPropertyChanged(nameof(Snr3_2));
                }
            }
            public string Snr4_2
            {
                get { return _snr4_2; }
                set
                {
                    _snr4_2 = value;
                    OnPropertyChanged(nameof(Snr4_2));
                }
            }
            public string Snr5_2
            {
                get { return _snr5_2; }
                set
                {
                    _snr5_2 = value;
                    OnPropertyChanged(nameof(Snr5_2));
                }
            }
            public string Snr6_2
            {
                get { return _snr6_2; }
                set
                {
                    _snr6_2 = value;
                    OnPropertyChanged(nameof(Snr6_2));
                }
            }
            public string Snr1Timestamp_2
            {
                get { return _snr1timestamp_2; }
                set
                {
                    _snr1timestamp_2 = value;
                    OnPropertyChanged(nameof(Snr1Timestamp_2));
                }
            }
            public string Snr2Timestamp_2
            {
                get { return _snr2timestamp_2; }
                set
                {
                    _snr2timestamp_2 = value;
                    OnPropertyChanged(nameof(Snr2Timestamp_2));
                }
            }
            public string Snr3Timestamp_2
            {
                get { return _snr3timestamp_2; }
                set
                {
                    _snr3timestamp_2 = value;
                    OnPropertyChanged(nameof(Snr3Timestamp_2));
                }
            }
            public string Snr4Timestamp_2
            {
                get { return _snr4timestamp_2; }
                set
                {
                    _snr4timestamp_2 = value;
                    OnPropertyChanged(nameof(Snr4Timestamp_2));
                }
            }
            public string Snr5Timestamp_2
            {
                get { return _snr5timestamp_2; }
                set
                {
                    _snr5timestamp_2 = value;
                    OnPropertyChanged(nameof(Snr5Timestamp_2));
                }
            }
            public string Snr6Timestamp_2
            {
                get { return _snr6timestamp_2; }
                set
                {
                    _snr6timestamp_2 = value;
                    OnPropertyChanged(nameof(Snr6Timestamp_2));
                }
            }
            public string Voltage5VA_2
            {
                get { return _voltage5VA_2; }
                set
                {
                    _voltage5VA_2 = value;
                    OnPropertyChanged(nameof(Voltage5VA_2));
                }
            }
            public string Voltage5VATimestamp_2
            {
                get { return _voltage5VAtimestamp_2; }
                set
                {
                    _voltage5VAtimestamp_2 = value;
                    OnPropertyChanged(nameof(Voltage5VATimestamp_2));
                }
            }
            public string Voltage12v_2
            {
                get { return _voltage12v_2; }
                set
                {
                    _voltage12v_2 = value;
                    OnPropertyChanged(nameof(Voltage12v_2));
                }
            }
            public string Voltage12vTimestamp_2
            {
                get { return _voltage12vtimestamp_2; }
                set
                {
                    _voltage12vtimestamp_2 = value;
                    OnPropertyChanged(nameof(Voltage12vTimestamp_2));
                }
            }
            public string Voltageneg5v_2
            {
                get { return _voltageneg5v_2; }
                set
                {
                    _voltageneg5v_2 = value;
                    OnPropertyChanged(nameof(Voltageneg5v_2));
                }
            }
            public string Voltageneg5vTimestamp_2
            {
                get { return _voltageneg5vtimestamp_2; }
                set
                {
                  _voltageneg5vtimestamp_2 = value;
                    OnPropertyChanged(nameof(Voltageneg5vTimestamp_2));
                }
            }
            public string Voltage49v_2
            {
                get { return _voltage49v_2; }
                set
                {
                    _voltage49v_2 = value;
                    OnPropertyChanged(nameof(Voltage49v_2));
                }
            }
            public string Voltage49vTimestamp_2
            {
                get { return _voltage49vtimestamp_2; }
                set
                {
                    _voltage49vtimestamp_2 = value;
                    OnPropertyChanged(nameof(Voltage49vTimestamp_2));
                }
            }
            public string Indexhealth_2
            {
                get { return _indexhealth_2; }
                set
                {
                    _indexhealth_2= value;
                    OnPropertyChanged(nameof(Indexhealth_2));
                }
            }
            public string IndexhealthTimestamp_2
            {
                get { return _indexhealthtimestamp_2; }
                set
                {
                    _indexhealthtimestamp_2 = value;
                    OnPropertyChanged(nameof(IndexhealthTimestamp_2));
                }
            }

          
    }
}
