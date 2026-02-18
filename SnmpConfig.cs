using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem
{
    public class SnmpConfig
    {
        public string Community { get; set; }
        public string Version { get; set; }
        public List<SubsystemModel> Subsystems { get; set; }
    }
}
