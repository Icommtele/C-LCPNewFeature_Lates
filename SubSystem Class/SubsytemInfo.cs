using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LCPReportingSystem.Model;
using Newtonsoft.Json;

namespace LCPReportingSystem.SystemConfig
{
    public static class SubsytemInfo
    {
        public static Dictionary<string,string>AllSubSystemInfoDictionary=new Dictionary<string,string>();
        public static Dictionary<string, SubsystemConfigData> AllSubSystemInfo = new Dictionary<string, SubsystemConfigData>();

        public static void GetSubSystemInfo()
        {
            //string jsonText = File.ReadAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Settings\ConfigData\SubSystemConfig.json");          
            string jsonText = File.ReadAllText(Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory,
    "Settings",
    "ConfigData",
    "SubSystemConfig.json"
));// File.ReadAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Settings\ConfigData\SubSystemConfig.json");          
            var config = JsonConvert.DeserializeObject<SubsystemsInfo>(jsonText);

            foreach(var _subsystem in config.Subsystems)
            {
                AllSubSystemInfoDictionary[_subsystem.SubsystemName]=_subsystem.Source_Ip;
                AllSubSystemInfo[_subsystem.Source_Ip] = _subsystem;
            }
        }
      
    }
}
