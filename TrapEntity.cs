using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem
{
    public class TrapEntity
    {
        string _subsysipset = string.Empty;
        string _trapnameset = string.Empty;
        string _traptimestampset = string.Empty;
        string _trapvalueset = string.Empty;
        string _trapgroupset = string.Empty;
        string _datetimestampset = string.Empty;

        string _recordid = string.Empty;
        string _subsysip = string.Empty;
        string _subsystemname = string.Empty;
        string _trapname = string.Empty;
        string _traptimestamp = string.Empty;
        string _trapvalue = string.Empty;
        string _trapgroup = string.Empty;
        string _datetimestamp = string.Empty;
        string _alarmid = string.Empty;
        string _trapdesc = string.Empty;

        string _upsconfigduration= string.Empty;
        string _upsconfigminduration=string.Empty;
        string _upssecondonbattry=string.Empty;
        string _upsconfigdurationValue = string.Empty;
        string _upsconfigmindurationValue = string.Empty;
        string _upssecondonbattryValue = string.Empty;
        string _SubsystemId= string.Empty;
        public TrapEntity(string RecordID = null, string SubSysIp = null, string SubsystemName = null, string TrapName = null, string TrapTimeStamp = null,
            string TrapValue = null, string TrapGroup = null, string DateTimeStamp = null, string Alarmid = null,
            string upsconfigduration=null, string upsconfigminduration = null, string upssecondonbattry = null,
            string upsconfigdurationValue = null, string upsconfigmindurationValue = null, string upssecondonbattryValue = null,
            string  SubsystemId = null, string TrapDesc = null)
        {
            this._recordid = RecordID;
            this._subsysip = SubSysIp;
            this._subsystemname = SubsystemName;
            this._trapname = TrapName;
            this._traptimestamp = TrapTimeStamp;
            this._trapvalue = TrapValue;
            this._trapgroup = TrapGroup;
            this._datetimestamp = DateTimeStamp;
            this._alarmid = Alarmid;
            this._upsconfigduration = upsconfigduration;
            this._upsconfigminduration = upsconfigminduration;
            this._upssecondonbattry=upssecondonbattry;
            this._upsconfigdurationValue = upsconfigdurationValue;
            this._upsconfigmindurationValue = upsconfigmindurationValue;
            this._upssecondonbattryValue = upssecondonbattryValue;
            this._SubsystemId = SubsystemId;
            
                
        }


        public TrapEntity(string _Trapname, string _UPSConfigdurationValue, string _UPSConfigminduration, string _UPSSecondonbattryValue,
                          string _UPSConfigduration, string _UPSConfigmindurationValue, string _TrapTimeStamp, string _DateTimeStamp, string _TrapGroup)
        {
            this._trapname = _Trapname;
            this._upsconfigdurationValue = _UPSConfigdurationValue;
            this._upsconfigminduration = _UPSConfigminduration;
            this._upssecondonbattryValue = _UPSSecondonbattryValue;
            this._upsconfigduration = _UPSConfigduration;
            this._upsconfigmindurationValue = _UPSConfigmindurationValue;
            this._traptimestamp = _TrapTimeStamp;
            this._datetimestamp = _DateTimeStamp;
            this._trapgroup = _TrapGroup;

        }
        #region Get property 
        public string GetRecordID
        {
            get { return this._recordid; }
        }
        public string GetSubsystemIp
        {
            get { return this._subsysip; }
        }
        public string GetSubsysName
        {
            get { return this._subsystemname; }
        }
        public string GetTrapName
        {
            get { return this._trapname; }
        }
        public string GetTrapTimeStamp
        {
            get { return this._traptimestamp; }
        }
        public string GetTrapValue
        {
            get { return this._trapvalue; }
        }
        public string GetTrapGroup
        {
            get { return this._trapgroup; }
        }
        public string GetDateTimestamp
        {
            get { return this._datetimestamp; }
        }

        #endregion

        public string SubsystemId
        {
            get { return this._SubsystemId; }
            set
            {
                this._SubsystemId = value;
            }
        }
        public string TrapDesc
        {
            get { return this._trapdesc; }
            set
            {
                this._trapdesc = value;
            }
        }
        public string UPSconfigduration
        {
            get { return this._upsconfigduration; }
            set
            {
                this._upsconfigduration = value;
            }
        }
        public string UPSconfigminduration
        {
            get { return this._upsconfigminduration; }
            set
            {
                this._upsconfigminduration = value;
            }
        }
        public string UPSsecondonbattry
        {
            get { return this._upssecondonbattry; }
            set
            {
                this._upssecondonbattry = value;
            }
        }

        public string UPSconfigdurationValue
        {
            get { return this._upsconfigdurationValue; }
            set
            {
                this._upsconfigdurationValue = value;
            }
        }
        public string UPSconfigmindurationValue
        {
            get { return this._upsconfigmindurationValue; }
            set
            {
                this._upsconfigmindurationValue = value;
            }
        }
        public string UPSsecondonbattryValue
        {
            get { return this._upssecondonbattryValue; }
            set
            {
                this._upssecondonbattryValue = value;
            }
        }



        public string SubsystemIP
        {
            get { return this._subsysipset; }
            set
            {
                this._subsysipset = value;
            }
        }
        public string TrapName
        {
            get { return this._trapnameset; }
            set
            {
                this._trapnameset = value;
            }
        }
        public string TrapTimeStamp
        {
            get { return this._traptimestampset; }
            set
            {
                this._traptimestampset = value;
            }
        }
        public string TrapValue
        {
            get { return this._trapvalueset; }
            set
            {
                this._trapvalueset = value;
            }
        }
        public string TrapGroup
        {
            get { return this._trapgroupset; }
            set
            {
                this._trapgroupset = value;
            }
        }
        public string DateTimestamp
        {
            get { return this._datetimestampset; }
            set
            {
                this._datetimestampset = value;
            }
        }


        public string Alarmid
        {
            get { return this._alarmid; }
            set
            {
                this._alarmid = value;
            }
        }

    }
}
