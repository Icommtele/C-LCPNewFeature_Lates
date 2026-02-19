using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.Model
{
    public class ParameterSetConfig
    {
        string _oid;
        string _fulloid;
        string _parametername;
        string _parametervalue;
        string _minvalue;
        string _maxvalue;
        string _redcolor;
        string _ambercolor;
        string _greencolor;
        string _timestamp;
        public ParameterSetConfig(string fulloid = null, string oid = null, string parametername = null, string parmsval = null, string minval = null,
            string maxval = null, string red = null, string amber = null, string green = null, string timestamp = null)
        {
            this._fulloid = fulloid;
            this._oid = oid;            
            this._parametername = parametername;
            this._parametervalue = parmsval;
            this._minvalue = minval;
            this._maxvalue = maxval;
            this._redcolor = red;
            this._ambercolor = amber;
            this._greencolor = green;
            this._timestamp = timestamp;
        }
        #region property

        public string Oid
        {
            get { return _oid; }           
            set { _oid = value; } // Setter
        }
        public string FullOid
        {
            get { return _fulloid; }           
            set { _fulloid = value; } // Setter
        }
        public string ParameterName
        {
            get { return _parametername; }
            set { _parametername = value; }
        }
        public string ParameterValue
        {
            get { return _parametervalue; }
            set { _parametervalue = value; }

        }
        public string MinValue
        {
            get { return _minvalue; }
            set { _minvalue = value; }
        }
        public string MaxValue
        {
            get { return _maxvalue; }
            set { _maxvalue = value; }
        }
        public string Redcolor
        {
            get { return _redcolor; }
            set { _redcolor = value; }
        }
        public string Ambercolor
        {
            get { return _ambercolor; }
            set { _ambercolor = value; }
        }
        public string Greencolor
        {
            get { return _greencolor; }
            set { _greencolor = value; }
        }
        public string TimeStamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }

        #endregion
    }
}
