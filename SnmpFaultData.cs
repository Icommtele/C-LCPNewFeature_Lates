using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem
{
    public class SnmpFaultData
    {
        public int _id;
        public string _subSystem = string.Empty;
        public string _subsystemIp = string.Empty;
        public DateTime _faultStartTime;
        public DateTime? _faultEndTime;
        public int? _durationInMinutes;
        public string _status = string.Empty;
       // public SnmpFaultData() { }
        public SnmpFaultData(string SubSystem, string subsystemIp = null, DateTime? faultStartTime = null,
                                  DateTime? faultEndTime = null, int? durationInMinutes = null, string status = null, int id = 0)
        {
            _id = id;
            _subSystem = SubSystem;
            _subsystemIp = subsystemIp;
            _faultStartTime = faultStartTime ?? DateTime.MinValue;
            _faultEndTime = faultEndTime;
            _durationInMinutes = durationInMinutes;
            _status = status;
        }

        public int Id
        {
            get { return _id; }
        }
        public string SubSystem
        {
            get { return _subSystem; }
        }

        public string SubsystemIp
        {
            get { return _subsystemIp; }
        }

        public DateTime FaultStartTime
        {
            get { return _faultStartTime; }
        }

        public DateTime? FaultEndTime
        {
            get { return _faultEndTime; }
        }

        public int? DurationInMinutes
        {
            get { return _durationInMinutes; }
        }

        public string Status
        {
            get { return _status; }
        }
    }
}
