using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.Model
{
    public enum IsSubSystem
    {
        DieselGenerator = 1,
        UPS = 2,
        Radio = 3,
        Switch = 4,
        Router = 5,

        DieselGenerator2 = 6,
        UPS2 = 7,
        Radio2 = 8,
        Switch2 = 9,
        Router2= 10,

    }
    public enum ArchiveSubSystem
    {
        DieselGenerator = 1,
        Router = 5,
        Radio = 3,
        Switch = 4,
        UPS =2,
        DieselGenerator2 = 6,
        Router2 = 7,
        Radio2 = 8,
        Switch2 = 9,
        UPS2 = 10,
    }
    public enum IsMenuActiveStatus
    {
        Active = 0,
        Inactive = 1,
    }
    public enum IsSqlFlag
    {
        GetArchiveCollection = 0,
        GetParameters = 1,
        GetLineGraphData = 2
    }
    public enum IsRequestType
    {
        BindByCombo = 0
    }
    public enum IsAppService
    {
        Maintenance = 0,
        Production = 1
    }
    public enum IsConfigFilename
    {
        ConfigDgset_txt = 0,
        ConfigRouterset_txt = 1,
        ConfigRadioset_txt = 2,
        ConfigSwitchset_txt = 3,
        ConfigUPSset_txt = 4
    }
    public enum IsConfigTrap
    {
        DgTrapConfig_txt = 0,
        RouterTrapConfig_txt = 1,
        RadioTrapConfig_txt = 2,
        SwitchTrapConfig_txt = 3,
        UPSTrapConfig_txt = 4
    }
    public enum RouterStatus
    {
        UP = 0,
        DOWN = 1,
    }
    public enum SwitchStatus
    {
        UP = 0,
        DOWN = 1,
    }
    public enum IsIndicatorColors
    {
        red = 0,
        green = 1,
        amber = 2,
        gray = 3
    }
    public enum IsDbConString
    {
        SqlAuthentication = 0,
        WindowsAuthentication = 1
    }
}
