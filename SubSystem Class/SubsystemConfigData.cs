using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.SystemConfig
{
    public class SubsystemConfigData
    {

        public string Source_Ip { get; set; }
        public string Destination_Ip { get; set; }
        public int port { get; set; }
        public int portTrap { get; set; }
        public string SubsystemName { get; set; }
        public string Oid { get; set; }
        public string SubsystemId { get; set; }
        public string SubsystemFile { get; set; }

        //private string _ipaddress;
        //private string _destination;
        //private string _filename;
        //private Int32 _port;
        //private Int32 _portTrap;

    }
}
