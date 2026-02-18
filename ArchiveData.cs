using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem
{
    public class ArchiveData
    {
        private string _recordid;
        private string _subsystemip;
        private string _systemname;
        private string _prametername;
        private string _prametervalue;
        private string _datetimestamp;
        private string _currentdate;
        private string _alarmid;



        public ArchiveData()
        {

        }

        public ArchiveData(string recordid, string subsystemid, string susbsystemname, string parametername,
            string parametervalue, string timestamp, string recorddate, string Alarmid, string PrameterOrTrapName_, string PrameterValueOrTrapGroupName_)
        {
            _recordid = recordid;
            _subsystemip = subsystemid;
            _systemname = susbsystemname;
            _prametername = parametername;
            _prametervalue = parametervalue;
            _datetimestamp = timestamp;
            _currentdate = recorddate;
            _alarmid = Alarmid;          
        }
        public string Alarmid
        {
            get { return this._alarmid; }
            set
            {
                this._alarmid = value;
            }
        }

        public string RecordID 
        {
            get {  return _recordid; }
            set { _recordid = value; }
        }
        public string SubSystemIP
        {
            get { return _subsystemip; }
            set { _subsystemip = value; }
        }
        public string SystemName
        {
            get { return _systemname; }
            set { _systemname = value; }
        }
        public string PrameterName
        {
            get { return _prametername; }
            set { _prametername = value; }
        }
        public string PrameterValue
        {
            get { return _prametervalue; }
            set { _prametervalue = value; }
        }
        public string DateTimeStamp
        {
            get { return _datetimestamp; }
            set { _datetimestamp = value; }
        }
        public string CurrentDate
        {
            //get 
            //{ 
            //    return Convert.ToDateTime(_currentdate.ToString()).ToString("dd/MM/yyyy"); 
            //}
            //set { _currentdate = value; }
            get
            {

                if (string.IsNullOrEmpty(_currentdate))
                {
                   
                    return DateTime.Now.ToString("dd/MM/yyyy");
                }

              
                return Convert.ToDateTime(_currentdate).ToString("dd/MM/yyyy");
            }
            set { _currentdate = value; }
        }
    }
}
