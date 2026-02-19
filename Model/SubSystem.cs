using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.Model
{
    public class SubSystem
    {
        private string _ipaddress;
        private string _destination;
        private string _filename;
        private Int32 _port;
        private Int32 _portTrap;
        private Int32 _version;
        private Int32 _timeout;
        private string _community;
        public SubSystem(string source = null, string destination = null, Int32? port = null, Int32? portTrap = null, string filename = null, Int32? version = null)
        {
            this._ipaddress = source;
            this._destination = destination;
            this._port = Convert.ToInt32(port);
            this._portTrap = Convert.ToInt32(portTrap);
            this._filename = filename;
            this._version = Convert.ToInt32(version);
            this._community = "public";
            this._timeout = 5000;
        }

        #region property
        public string IpAddress
        {
            get { return _ipaddress; }
        }
        public string Destination
        {
            get { return _destination; }
        }
        public Int32 Port
        {
            get { return _port; }
        }
        public Int32 PortTrap
        {
            get { return _portTrap; }
        }
        public string Filename
        {
            get { return _filename; }
        }
        public Int32 Version
        {
            get { return _version; }
        }
        public Int32 Timeout
        {
            get { return _timeout; }
        }
        public string Community
        {
            get { return _community; }
        }
        #endregion
    }
}
