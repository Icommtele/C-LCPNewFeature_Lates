using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem
{
    public class TrapConfig
    {
        private readonly string _oid;
        private readonly string _datatype;
        private readonly string trapname;
        //private readonly string trapname1;
        private readonly string   _unit;
        public TrapConfig(string oid, string datatype, string trapname,  string unit)
        {
            _oid = oid;
            _datatype = datatype;
            this.trapname = trapname;
            _unit = unit;
        }
        public string Oid
        {
            get { return _oid; }
        }
        public string Datatype
        {
            get { return _datatype; }
        }
        public string TrapName
        {
            get { return trapname; }
        }
        //public string TrapName1
        //{
        //    get { return trapname1; }
        //}
        public string Unit
        {
            get { return _unit; }
        }
    }
}
