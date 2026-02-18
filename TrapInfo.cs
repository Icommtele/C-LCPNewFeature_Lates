using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem
{
    public class TrapInfo
    {
        private string _sysname;
        private string _trapname;
        private string _traptype;
        private string _systemuptime;
        private string _additionalvalue;
        private string _timestamp;
        private string _trapDescr;
        private string _alarmid;
        private string _trapid;
        private string _alarmidDesc;
        private string _remainingUpsTime;
        private string _notification;
        private string _upsTrapName;
        private string _trapparameterName;
        private string _trapparametervalue;
        private string _upsLowBatteryTrapName;
        public bool IsLatest { get; set; }
        public TrapInfo(string sysname ="Test" , string trapname = "trapname Test", string traptype = "traptype Test", string systemuptime = null,
            string additionalvalue = null, string timestamp = null, string trapdescr=null, string alarmid = null, 
            string _trapid=null,string _alarmidDesc = null, string _remainingUpsTime = null,
            string _notification=null, string _upsTrapName = null, string _trapparameterName = null, string _trapparametervalue = null,
            string _upsLowBatteryTrapName=null)
        {
            _sysname = sysname;
            _trapname = trapname;
            _traptype = traptype;
            _systemuptime = systemuptime;
            _additionalvalue = additionalvalue;
            _timestamp = timestamp;
            _trapDescr = trapdescr;
            _alarmid = alarmid;
            IsLatest=false;
            this._trapid = _trapid;
            this._alarmidDesc = _alarmidDesc;
            this._remainingUpsTime = _remainingUpsTime;
            this._notification = _notification;
            this._upsTrapName = _upsTrapName;
            this._upsLowBatteryTrapName = _upsLowBatteryTrapName;
        }
        //public string SysName
        //{
        //    get => _sysname;
        //}
        public string SysName
        {
            get => _sysname; // Getter returns the value of the private field
            set => _sysname = value; // Setter assigns a new value to the private field
        }
        public string TrapName
        {
            get => _trapname;
            set => _trapname = value;
        }
        public string TrapType
        {
            //get => $"{_traptype} ({_timestamp})";
            get =>_traptype; set => _traptype = value;
        }
        public string SystemUpTime
        {
            get => _systemuptime; set => _systemuptime = value;
        }
        public string AdditionalValue
        {
            get => _additionalvalue; set => _additionalvalue = value;
        }
        public string TimeStamp
        {
            get => _timestamp; set => _timestamp = value;
        }
        public string Trapdesc
        {
            get => _trapDescr; set => _trapDescr = value;
        }
        public string Alarmid
        {
            get => _alarmid; set => _alarmid = value;
        }
        public string Trapid
        {
            get => _trapid; set => _trapid = value;
        }
        public string AlarmidDesc
        {
            get => _alarmidDesc; set => _alarmidDesc = value;
        }
        public string RemainingUpsTime
        {
            get => _remainingUpsTime; set => _remainingUpsTime = value;
        }
        public string NotificatiobDesc
        {
            get => this._notification;   
            set => this._notification = value;
        }
        public string Trapname1
        {
            get => this._upsTrapName; set => this._upsTrapName = value;
        }
        public string Trapparametervalue
        {
            get => this._trapparametervalue; set => this._trapparametervalue = value;
        }
        public string TrapparameterName
        {
            get => this._trapparameterName; set => this._trapparameterName = value;
        }
        public string UpsLowBatteryTrapName
        {
            get => this._upsLowBatteryTrapName; set => this._upsLowBatteryTrapName = value; 
        }
        
    }
}
