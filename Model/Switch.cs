using LCPReportingSystem.ViewModel;
using PacketDotNet.Utils.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.Model
{
    public partial class DashBoard : ViewModelBase
    {

        #region Switch Adminstatus

        string _ifadminstatus1switch = string.Empty;
        string _ifadminstatus2switch = string.Empty;
        string _ifadminstatus3switch = string.Empty;
        string _ifadminstatus4switch = string.Empty;
        string _ifadminstatus5switch = string.Empty;
        string _ifadminstatus6switch = string.Empty;
        string _ifadminstatus7switch = string.Empty;
        string _ifadminstatus8switch = string.Empty;
        string _ifadminstatus9switch = string.Empty;
        string _ifadminstatus10switch = string.Empty;
        string _ifadminstatus11switch = string.Empty;
        string _ifadminstatus12switch = string.Empty;
        string _ifadminstatus13switch = string.Empty;
        string _ifadminstatus14switch = string.Empty;
        string _ifadminstatus15switch = string.Empty;
        string _ifadminstatus16switch = string.Empty;
        string _ifadminstatus17switch = string.Empty;
        string _ifadminstatus18switch = string.Empty;
        string _ifadminstatus19switch = string.Empty;
        string _ifadminstatus20switch = string.Empty;
        string _ifadminstatus21switch = string.Empty;
        string _ifadminstatus22switch = string.Empty;
        string _ifadminstatus23switch = string.Empty;
        string _ifadminstatus24switch = string.Empty;

        string _ifadminstatus1switchindicator = string.Empty;
        string _ifadminstatus2switchindicator = string.Empty;
        string _ifadminstatus3switchindicator = string.Empty;
        string _ifadminstatus4switchindicator = string.Empty;
        string _ifadminstatus5switchindicator = string.Empty;
        string _ifadminstatus6switchindicator = string.Empty;
        string _ifadminstatus7switchindicator = string.Empty;
        string _ifadminstatus8switchindicator = string.Empty;
        string _ifadminstatus9switchindicator = string.Empty;
        string _ifadminstatus10switchindicator = string.Empty;
        string _ifadminstatus11switchindicator = string.Empty;
        string _ifadminstatus12switchindicator = string.Empty;
        string _ifadminstatus13switchindicator = string.Empty;
        string _ifadminstatus14switchindicator = string.Empty;
        string _ifadminstatus15switchindicator = string.Empty;
        string _ifadminstatus16switchindicator = string.Empty;
        string _ifadminstatus17switchindicator = string.Empty;
        string _ifadminstatus18switchindicator = string.Empty;
        string _ifadminstatus19switchindicator = string.Empty;
        string _ifadminstatus20switchindicator = string.Empty;
        string _ifadminstatus21switchindicator = string.Empty;
        string _ifadminstatus22switchindicator = string.Empty;
        string _ifadminstatus23switchindicator = string.Empty;
        string _ifadminstatus24switchindicator = string.Empty;

        string _ifadminstatus1switchtimestamp = string.Empty;
        string _ifadminstatus2switchtimestamp = string.Empty;
        string _ifadminstatus3switchtimestamp = string.Empty;
        string _ifadminstatus4switchtimestamp = string.Empty;
        string _ifadminstatus5switchtimestamp = string.Empty;
        string _ifadminstatus6switchtimestamp = string.Empty;
        string _ifadminstatus7switchtimestamp = string.Empty;
        string _ifadminstatus8switchtimestamp = string.Empty;
        string _ifadminstatus9switchtimestamp = string.Empty;
        string _ifadminstatus10switchtimestamp = string.Empty;
        string _ifadminstatus11switchtimestamp = string.Empty;
        string _ifadminstatus12switchtimestamp = string.Empty;
        string _ifadminstatus13switchtimestamp = string.Empty;
        string _ifadminstatus14switchtimestamp = string.Empty;
        string _ifadminstatus15switchtimestamp = string.Empty;
        string _ifadminstatus16switchtimestamp = string.Empty;
        string _ifadminstatus17switchtimestamp = string.Empty;
        string _ifadminstatus18switchtimestamp = string.Empty;
        string _ifadminstatus19switchtimestamp = string.Empty;
        string _ifadminstatus20switchtimestamp = string.Empty;
        string _ifadminstatus21switchtimestamp = string.Empty;
        string _ifadminstatus22switchtimestamp = string.Empty;
        string _ifadminstatus23switchtimestamp = string.Empty;
        string _ifadminstatus24switchtimestamp = string.Empty;
        #endregion

        #region Switch Adminstatus2

        string _ifadminstatus1switch2 = string.Empty;
        string _ifadminstatus2switch2 = string.Empty;
        string _ifadminstatus3switch2 = string.Empty;
        string _ifadminstatus4switch2 = string.Empty;
        string _ifadminstatus5switch2 = string.Empty;
        string _ifadminstatus6switch2 = string.Empty;
        string _ifadminstatus7switch2 = string.Empty;
        string _ifadminstatus8switch2 = string.Empty;
        string _ifadminstatus9switch2 = string.Empty;
        string _ifadminstatus10switch2 = string.Empty;
        string _ifadminstatus11switch2 = string.Empty;
        string _ifadminstatus12switch2 = string.Empty;
        string _ifadminstatus13switch2 = string.Empty;
        string _ifadminstatus14switch2 = string.Empty;
        string _ifadminstatus15switch2 = string.Empty;
        string _ifadminstatus16switch2 = string.Empty;
        string _ifadminstatus17switch2 = string.Empty;
        string _ifadminstatus18switch2 = string.Empty;
        string _ifadminstatus19switch2 = string.Empty;
        string _ifadminstatus20switch2 = string.Empty;
        string _ifadminstatus21switch2 = string.Empty;
        string _ifadminstatus22switch2 = string.Empty;
        string _ifadminstatus23switch2 = string.Empty;
        string _ifadminstatus24switch2 = string.Empty;

        string _ifadminstatus1switchindicator2 = string.Empty;
        string _ifadminstatus2switchindicator2 = string.Empty;
        string _ifadminstatus3switchindicator2 = string.Empty;
        string _ifadminstatus4switchindicator2 = string.Empty;
        string _ifadminstatus5switchindicator2 = string.Empty;
        string _ifadminstatus6switchindicator2 = string.Empty;
        string _ifadminstatus7switchindicator2 = string.Empty;
        string _ifadminstatus8switchindicator2 = string.Empty;
        string _ifadminstatus9switchindicator2 = string.Empty;
        string _ifadminstatus10switchindicator2 = string.Empty;
        string _ifadminstatus11switchindicator2 = string.Empty;
        string _ifadminstatus12switchindicator2 = string.Empty;
        string _ifadminstatus13switchindicator2 = string.Empty;
        string _ifadminstatus14switchindicator2 = string.Empty;
        string _ifadminstatus15switchindicator2 = string.Empty;
        string _ifadminstatus16switchindicator2 = string.Empty;
        string _ifadminstatus17switchindicator2 = string.Empty;
        string _ifadminstatus18switchindicator2 = string.Empty;
        string _ifadminstatus19switchindicator2 = string.Empty;
        string _ifadminstatus20switchindicator2 = string.Empty;
        string _ifadminstatus21switchindicator2 = string.Empty;
        string _ifadminstatus22switchindicator2 = string.Empty;
        string _ifadminstatus23switchindicator2 = string.Empty;
        string _ifadminstatus24switchindicator2 = string.Empty;

        string _ifadminstatus1switchtimestamp2 = string.Empty;
        string _ifadminstatus2switchtimestamp2 = string.Empty;
        string _ifadminstatus3switchtimestamp2 = string.Empty;
        string _ifadminstatus4switchtimestamp2 = string.Empty;
        string _ifadminstatus5switchtimestamp2 = string.Empty;
        string _ifadminstatus6switchtimestamp2 = string.Empty;
        string _ifadminstatus7switchtimestamp2 = string.Empty;
        string _ifadminstatus8switchtimestamp2 = string.Empty;
        string _ifadminstatus9switchtimestamp2 = string.Empty;
        string _ifadminstatus10switchtimestamp2 = string.Empty;
        string _ifadminstatus11switchtimestamp2 = string.Empty;
        string _ifadminstatus12switchtimestamp2 = string.Empty;
        string _ifadminstatus13switchtimestamp2 = string.Empty;
        string _ifadminstatus14switchtimestamp2 = string.Empty;
        string _ifadminstatus15switchtimestamp2 = string.Empty;
        string _ifadminstatus16switchtimestamp2 = string.Empty;
        string _ifadminstatus17switchtimestamp2 = string.Empty;
        string _ifadminstatus18switchtimestamp2 = string.Empty;
        string _ifadminstatus19switchtimestamp2 = string.Empty;
        string _ifadminstatus20switchtimestamp2 = string.Empty;
        string _ifadminstatus21switchtimestamp2 = string.Empty;
        string _ifadminstatus22switchtimestamp2 = string.Empty;
        string _ifadminstatus23switchtimestamp2 = string.Empty;
        string _ifadminstatus24switchtimestamp2 = string.Empty;
        #endregion


        #region Switch OperStatus

        string _ifoperstatus1switch = string.Empty;
        string _ifoperstatus2switch = string.Empty;
        string _ifoperstatus3switch = string.Empty;
        string _ifoperstatus4switch = string.Empty;
        string _ifoperstatus5switch = string.Empty;
        string _ifoperstatus6switch = string.Empty;
        string _ifoperstatus7switch = string.Empty;
        string _ifoperstatus8switch = string.Empty;
        string _ifoperstatus9switch = string.Empty;
        string _ifoperstatus10switch = string.Empty;
        string _ifoperstatus11switch = string.Empty;
        string _ifoperstatus12switch = string.Empty;
        string _ifoperstatus13switch = string.Empty;
        string _ifoperstatus14switch = string.Empty;
        string _ifoperstatus15switch = string.Empty;
        string _ifoperstatus16switch = string.Empty;
        string _ifoperstatus17switch = string.Empty;
        string _ifoperstatus18switch = string.Empty;
        string _ifoperstatus19switch = string.Empty;
        string _ifoperstatus20switch = string.Empty;
        string _ifoperstatus21switch = string.Empty;
        string _ifoperstatus22switch = string.Empty;
        string _ifoperstatus23switch = string.Empty;
        string _ifoperstatus24switch = string.Empty;

        string _ifoperstatus1switchindicator = string.Empty;
        string _ifoperstatus2switchindicator = string.Empty;
        string _ifoperstatus3switchindicator = string.Empty;
        string _ifoperstatus4switchindicator = string.Empty;
        string _ifoperstatus5switchindicator = string.Empty;
        string _ifoperstatus6switchindicator = string.Empty;
        string _ifoperstatus7switchindicator = string.Empty;
        string _ifoperstatus8switchindicator = string.Empty;
        string _ifoperstatus9switchindicator = string.Empty;
        string _ifoperstatus10switchindicator = string.Empty;
        string _ifoperstatus11switchindicator = string.Empty;
        string _ifoperstatus12switchindicator = string.Empty;
        string _ifoperstatus13switchindicator = string.Empty;
        string _ifoperstatus14switchindicator = string.Empty;
        string _ifoperstatus15switchindicator = string.Empty;
        string _ifoperstatus16switchindicator = string.Empty;
        string _ifoperstatus17switchindicator = string.Empty;
        string _ifoperstatus18switchindicator = string.Empty;
        string _ifoperstatus19switchindicator = string.Empty;
        string _ifoperstatus20switchindicator = string.Empty;
        string _ifoperstatus21switchindicator = string.Empty;
        string _ifoperstatus22switchindicator = string.Empty;
        string _ifoperstatus23switchindicator = string.Empty;
        string _ifoperstatus24switchindicator = string.Empty;

        string _ifoperstatus1switchtimestamp = string.Empty;
        string _ifoperstatus2switchtimestamp = string.Empty;
        string _ifoperstatus3switchtimestamp = string.Empty;
        string _ifoperstatus4switchtimestamp = string.Empty;
        string _ifoperstatus5switchtimestamp = string.Empty;
        string _ifoperstatus6switchtimestamp = string.Empty;
        string _ifoperstatus7switchtimestamp = string.Empty;
        string _ifoperstatus8switchtimestamp = string.Empty;
        string _ifoperstatus9switchtimestamp = string.Empty;
        string _ifoperstatus10switchtimestamp = string.Empty;
        string _ifoperstatus11switchtimestamp = string.Empty;
        string _ifoperstatus12switchtimestamp = string.Empty;
        string _ifoperstatus13switchtimestamp = string.Empty;
        string _ifoperstatus14switchtimestamp = string.Empty;
        string _ifoperstatus15switchtimestamp = string.Empty;
        string _ifoperstatus16switchtimestamp = string.Empty;
        string _ifoperstatus17switchtimestamp = string.Empty;
        string _ifoperstatus18switchtimestamp = string.Empty;
        string _ifoperstatus19switchtimestamp = string.Empty;
        string _ifoperstatus20switchtimestamp = string.Empty;
        string _ifoperstatus21switchtimestamp = string.Empty;
        string _ifoperstatus22switchtimestamp = string.Empty;
        string _ifoperstatus23switchtimestamp = string.Empty;
        string _ifoperstatus24switchtimestamp = string.Empty;

        #endregion

        #region Switch OperStatus2

        string _ifoperstatus1switch2 = string.Empty;
        string _ifoperstatus2switch2 = string.Empty;
        string _ifoperstatus3switch2 = string.Empty;
        string _ifoperstatus4switch2 = string.Empty;
        string _ifoperstatus5switch2 = string.Empty;
        string _ifoperstatus6switch2 = string.Empty;
        string _ifoperstatus7switch2 = string.Empty;
        string _ifoperstatus8switch2 = string.Empty;
        string _ifoperstatus9switch2 = string.Empty;
        string _ifoperstatus10switch2 = string.Empty;
        string _ifoperstatus11switch2 = string.Empty;
        string _ifoperstatus12switch2 = string.Empty;
        string _ifoperstatus13switch2 = string.Empty;
        string _ifoperstatus14switch2 = string.Empty;
        string _ifoperstatus15switch2 = string.Empty;
        string _ifoperstatus16switch2 = string.Empty;
        string _ifoperstatus17switch2 = string.Empty;
        string _ifoperstatus18switch2 = string.Empty;
        string _ifoperstatus19switch2 = string.Empty;
        string _ifoperstatus20switch2 = string.Empty;
        string _ifoperstatus21switch2 = string.Empty;
        string _ifoperstatus22switch2 = string.Empty;
        string _ifoperstatus23switch2 = string.Empty;
        string _ifoperstatus24switch2 = string.Empty;

        string _ifoperstatus1switchindicator2 = string.Empty;
        string _ifoperstatus2switchindicator2 = string.Empty;
        string _ifoperstatus3switchindicator2 = string.Empty;
        string _ifoperstatus4switchindicator2 = string.Empty;
        string _ifoperstatus5switchindicator2 = string.Empty;
        string _ifoperstatus6switchindicator2 = string.Empty;
        string _ifoperstatus7switchindicator2 = string.Empty;
        string _ifoperstatus8switchindicator2 = string.Empty;
        string _ifoperstatus9switchindicator2 = string.Empty;
        string _ifoperstatus10switchindicator2 = string.Empty;
        string _ifoperstatus11switchindicator2 = string.Empty;
        string _ifoperstatus12switchindicator2 = string.Empty;
        string _ifoperstatus13switchindicator2 = string.Empty;
        string _ifoperstatus14switchindicator2 = string.Empty;
        string _ifoperstatus15switchindicator2 = string.Empty;
        string _ifoperstatus16switchindicator2 = string.Empty;
        string _ifoperstatus17switchindicator2 = string.Empty;
        string _ifoperstatus18switchindicator2 = string.Empty;
        string _ifoperstatus19switchindicator2 = string.Empty;
        string _ifoperstatus20switchindicator2 = string.Empty;
        string _ifoperstatus21switchindicator2 = string.Empty;
        string _ifoperstatus22switchindicator2 = string.Empty;
        string _ifoperstatus23switchindicator2 = string.Empty;
        string _ifoperstatus24switchindicator2 = string.Empty;

        string _ifoperstatus1switchtimestamp2 = string.Empty;
        string _ifoperstatus2switchtimestamp2 = string.Empty;
        string _ifoperstatus3switchtimestamp2 = string.Empty;
        string _ifoperstatus4switchtimestamp2 = string.Empty;
        string _ifoperstatus5switchtimestamp2 = string.Empty;
        string _ifoperstatus6switchtimestamp2 = string.Empty;
        string _ifoperstatus7switchtimestamp2 = string.Empty;
        string _ifoperstatus8switchtimestamp2 = string.Empty;
        string _ifoperstatus9switchtimestamp2 = string.Empty;
        string _ifoperstatus10switchtimestamp2 = string.Empty;
        string _ifoperstatus11switchtimestamp2 = string.Empty;
        string _ifoperstatus12switchtimestamp2 = string.Empty;
        string _ifoperstatus13switchtimestamp2 = string.Empty;
        string _ifoperstatus14switchtimestamp2 = string.Empty;
        string _ifoperstatus15switchtimestamp2 = string.Empty;
        string _ifoperstatus16switchtimestamp2 = string.Empty;
        string _ifoperstatus17switchtimestamp2 = string.Empty;
        string _ifoperstatus18switchtimestamp2 = string.Empty;
        string _ifoperstatus19switchtimestamp2 = string.Empty;
        string _ifoperstatus20switchtimestamp2 = string.Empty;
        string _ifoperstatus21switchtimestamp2 = string.Empty;
        string _ifoperstatus22switchtimestamp2 = string.Empty;
        string _ifoperstatus23switchtimestamp2 = string.Empty;
        string _ifoperstatus24switchtimestamp2 = string.Empty;

        #endregion


        #region Environment Temperature
        string _ciscoenvmontemperaturestatusdescr = string.Empty;
        string _ciscoenvmontemperaturestatusvalue = string.Empty;
        string _ciscoenvmontemperaturethreshold = string.Empty;
        string _ciscoenvmontemperaturelastshutdown = string.Empty;
        string _ciscoenvmontemperaturestate = string.Empty;
        string _ciscoenvmontemperaturestatusvaluerev1 = string.Empty;

        string _environmenttimestamp0 = string.Empty;
        string _environmenttimestamp1 = string.Empty;
        string _environmenttimestamp2 = string.Empty;
        string _environmenttimestamp3 = string.Empty;
        string _environmenttimestamp4 = string.Empty;
        string _environmenttimestamp5 = string.Empty;
        #endregion

        #region Environment2
        string _ciscoenvmontemperaturestatusdescr2 = string.Empty;
        string _ciscoenvmontemperaturestatusvalue2 = string.Empty;
        string _ciscoenvmontemperaturethreshold2 = string.Empty;
        string _ciscoenvmontemperaturelastshutdown2 = string.Empty;
        string _ciscoenvmontemperaturestate2 = string.Empty;
        string _ciscoenvmontemperaturestatusvaluerev1_2 = string.Empty;

        string _environmenttimestamp0_2 = string.Empty;
        string _environmenttimestamp1_2 = string.Empty;
        string _environmenttimestamp2_2 = string.Empty;
        string _environmenttimestamp3_2 = string.Empty;
        string _environmenttimestamp4_2 = string.Empty;
        string _environmenttimestamp5_2 = string.Empty;
        #endregion

        #region Switch Paramater

        string _geSwitch101Status = string.Empty;
        string _geSwitch102Status = string.Empty;
        string _geSwitch103Status = string.Empty;
        string _geSwitch104Status = string.Empty;
        string _geSwitch105Status = string.Empty;
        string _geSwitch106Status = string.Empty;
        string _geSwitch107Status = string.Empty;
        string _geSwitch108Status = string.Empty;
        string _geSwitch109Status = string.Empty;
        string _geSwitch1010Status = string.Empty;
        string _geSwitch1011Status = string.Empty;
        string _geSwitch1012Status = string.Empty;
        string _geSwitch1013Status = string.Empty;
        string _geSwitch1014Status = string.Empty;
        string _geSwitch1015Status = string.Empty;
        string _geSwitch1016Status = string.Empty;
        string _geSwitch1017Status = string.Empty;
        string _geSwitch1018Status = string.Empty;
        string _geSwitch1019Status = string.Empty;
        string _geSwitch1020Status = string.Empty;
        string _geSwitch1021Status = string.Empty;
        string _geSwitch1022Status = string.Empty;
        string _geSwitch1023Status = string.Empty;
        string _geSwitch1024Status = string.Empty;

        string _geSwitch101Statusindicator = string.Empty;
        string _geSwitch102Statusindicator = string.Empty;
        string _geSwitch103Statusindicator = string.Empty;
        string _geSwitch104Statusindicator = string.Empty;
        string _geSwitch105Statusindicator = string.Empty;
        string _geSwitch106Statusindicator = string.Empty;
        string _geSwitch107Statusindicator = string.Empty;
        string _geSwitch108Statusindicator = string.Empty;
        string _geSwitch109Statusindicator = string.Empty;
        string _geSwitch1010Statusindicator = string.Empty;
        string _geSwitch1011Statusindicator = string.Empty;
        string _geSwitch1012Statusindicator = string.Empty;
        string _geSwitch1013Statusindicator = string.Empty;
        string _geSwitch1014Statusindicator = string.Empty;
        string _geSwitch1015Statusindicator = string.Empty;
        string _geSwitch1016Statusindicator = string.Empty;
        string _geSwitch1017Statusindicator = string.Empty;
        string _geSwitch1018Statusindicator = string.Empty;
        string _geSwitch1019Statusindicator = string.Empty;
        string _geSwitch1020Statusindicator = string.Empty;
        string _geSwitch1021Statusindicator = string.Empty;
        string _geSwitch1022Statusindicator = string.Empty;
        string _geSwitch1023Statusindicator = string.Empty;
        string _geSwitch1024Statusindicator = string.Empty;

        #endregion


        #region Switch giga2
        string _geSwitch101Status2 = string.Empty;
        string _geSwitch102Status2 = string.Empty;
        string _geSwitch103Status2 = string.Empty;
        string _geSwitch104Status2 = string.Empty;
        string _geSwitch105Status2 = string.Empty;
        string _geSwitch106Status2 = string.Empty;
        string _geSwitch107Status2 = string.Empty;
        string _geSwitch108Status2 = string.Empty;
        string _geSwitch109Status2 = string.Empty;
        string _geSwitch1010Status2 = string.Empty;
        string _geSwitch1011Status2 = string.Empty;
        string _geSwitch1012Status2 = string.Empty;
        string _geSwitch1013Status2 = string.Empty;
        string _geSwitch1014Status2 = string.Empty;
        string _geSwitch1015Status2 = string.Empty;
        string _geSwitch1016Status2 = string.Empty;
        string _geSwitch1017Status2 = string.Empty;
        string _geSwitch1018Status2 = string.Empty;
        string _geSwitch1019Status2 = string.Empty;
        string _geSwitch1020Status2 = string.Empty;
        string _geSwitch1021Status2 = string.Empty;
        string _geSwitch1022Status2 = string.Empty;
        string _geSwitch1023Status2 = string.Empty;
        string _geSwitch1024Status2 = string.Empty;

        string _geSwitch101Statusindicator2 = string.Empty;
        string _geSwitch102Statusindicator2 = string.Empty;
        string _geSwitch103Statusindicator2 = string.Empty;
        string _geSwitch104Statusindicator2 = string.Empty;
        string _geSwitch105Statusindicator2 = string.Empty;
        string _geSwitch106Statusindicator2 = string.Empty;
        string _geSwitch107Statusindicator2 = string.Empty;
        string _geSwitch108Statusindicator2 = string.Empty;
        string _geSwitch109Statusindicator2 = string.Empty;
        string _geSwitch1010Statusindicator2 = string.Empty;
        string _geSwitch1011Statusindicator2 = string.Empty;
        string _geSwitch1012Statusindicator2 = string.Empty;
        string _geSwitch1013Statusindicator2 = string.Empty;
        string _geSwitch1014Statusindicator2 = string.Empty;
        string _geSwitch1015Statusindicator2 = string.Empty;
        string _geSwitch1016Statusindicator2 = string.Empty;
        string _geSwitch1017Statusindicator2 = string.Empty;
        string _geSwitch1018Statusindicator2 = string.Empty;
        string _geSwitch1019Statusindicator2 = string.Empty;
        string _geSwitch1020Statusindicator2 = string.Empty;
        string _geSwitch1021Statusindicator2 = string.Empty;
        string _geSwitch1022Statusindicator2 = string.Empty;
        string _geSwitch1023Statusindicator2 = string.Empty;
        string _geSwitch1024Statusindicator2 = string.Empty;

        #endregion

        #region Switch AdminStatus Property
        public string IfAdminStatus1Switch
        {
            get { return _ifadminstatus1switch; }
            set
            {
                _ifadminstatus1switch = value;
                OnPropertyChanged(nameof(IfAdminStatus1Switch));
            }
        }
        public string IfAdminStatus2Switch
        {
            get { return _ifadminstatus2switch; }
            set
            {
                _ifadminstatus2switch = value;
                OnPropertyChanged(nameof(IfAdminStatus2Switch));
            }
        }
        public string IfAdminStatus3Switch
        {
            get { return _ifadminstatus3switch; }
            set
            {
                _ifadminstatus3switch = value;
                OnPropertyChanged(nameof(IfAdminStatus3Switch));
            }
        }
        public string IfAdminStatus4Switch
        {
            get { return _ifadminstatus4switch; }
            set
            {
                _ifadminstatus4switch = value;
                OnPropertyChanged(nameof(IfAdminStatus4Switch));
            }
        }
        public string IfAdminStatus5Switch
        {
            get { return _ifadminstatus5switch; }
            set
            {
                _ifadminstatus5switch = value;
                OnPropertyChanged(nameof(IfAdminStatus5Switch));
            }
        }
        public string IfAdminStatus6Switch
        {
            get { return _ifadminstatus6switch; }
            set
            {
                _ifadminstatus6switch = value;
                OnPropertyChanged(nameof(IfAdminStatus6Switch));
            }
        }
        public string IfAdminStatus7Switch
        {
            get { return _ifadminstatus7switch; }
            set
            {
                _ifadminstatus7switch = value;
                OnPropertyChanged(nameof(IfAdminStatus7Switch));
            }
        }
        public string IfAdminStatus8Switch
        {
            get { return _ifadminstatus8switch; }
            set
            {
                _ifadminstatus8switch = value;
                OnPropertyChanged(nameof(IfAdminStatus8Switch));
            }
        }
        public string IfAdminStatus9Switch
        {
            get { return _ifadminstatus9switch; }
            set
            {
                _ifadminstatus9switch = value;
                OnPropertyChanged(nameof(IfAdminStatus9Switch));
            }
        }
        public string IfAdminStatus10Switch
        {
            get { return _ifadminstatus10switch; }
            set
            {
                _ifadminstatus10switch = value;
                OnPropertyChanged(nameof(IfAdminStatus10Switch));
            }
        }
        public string IfAdminStatus11Switch
        {
            get { return _ifadminstatus11switch; }
            set
            {
                _ifadminstatus11switch = value;
                OnPropertyChanged(nameof(IfAdminStatus11Switch));
            }
        }
        public string IfAdminStatus12Switch
        {
            get { return _ifadminstatus12switch; }
            set
            {
                _ifadminstatus12switch = value;
                OnPropertyChanged(nameof(IfAdminStatus12Switch));
            }
        }
        public string IfAdminStatus13Switch
        {
            get { return _ifadminstatus13switch; }
            set
            {
                _ifadminstatus13switch = value;
                OnPropertyChanged(nameof(IfAdminStatus13Switch));
            }
        }
        public string IfAdminStatus14Switch
        {
            get { return _ifadminstatus14switch; }
            set
            {
                _ifadminstatus14switch = value;
                OnPropertyChanged(nameof(IfAdminStatus14Switch));
            }
        }
        public string IfAdminStatus15Switch
        {
            get { return _ifadminstatus15switch; }
            set
            {
                _ifadminstatus15switch = value;
                OnPropertyChanged(nameof(IfAdminStatus15Switch));
            }
        }
        public string IfAdminStatus16Switch
        {
            get { return _ifadminstatus16switch; }
            set
            {
                _ifadminstatus16switch = value;
                OnPropertyChanged(nameof(IfAdminStatus16Switch));
            }
        }
        public string IfAdminStatus17Switch
        {
            get { return _ifadminstatus17switch; }
            set
            {
                _ifadminstatus17switch = value;
                OnPropertyChanged(nameof(IfAdminStatus17Switch));
            }
        }
        public string IfAdminStatus18Switch
        {
            get { return _ifadminstatus18switch; }
            set
            {
                _ifadminstatus18switch = value;
                OnPropertyChanged(nameof(IfAdminStatus18Switch));
            }
        }
        public string IfAdminStatus19Switch
        {
            get { return _ifadminstatus19switch; }
            set
            {
                _ifadminstatus19switch = value;
                OnPropertyChanged(nameof(IfAdminStatus19Switch));
            }
        }
        public string IfAdminStatus20Switch
        {
            get { return _ifadminstatus20switch; }
            set
            {
                _ifadminstatus20switch = value;
                OnPropertyChanged(nameof(IfAdminStatus20Switch));
            }
        }
        public string IfAdminStatus21Switch
        {
            get { return _ifadminstatus21switch; }
            set
            {
                _ifadminstatus21switch = value;
                OnPropertyChanged(nameof(IfAdminStatus21Switch));
            }
        }
        public string IfAdminStatus22Switch
        {
            get { return _ifadminstatus22switch; }
            set
            {
                _ifadminstatus22switch = value;
                OnPropertyChanged(nameof(IfAdminStatus22Switch));
            }
        }
        public string IfAdminStatus23Switch
        {
            get { return _ifadminstatus23switch; }
            set
            {
                _ifadminstatus23switch = value;
                OnPropertyChanged(nameof(IfAdminStatus23Switch));
            }
        }
        public string IfAdminStatus24Switch
        {
            get { return _ifadminstatus24switch; }
            set
            {
                _ifadminstatus24switch = value;
                OnPropertyChanged(nameof(IfAdminStatus24Switch));
            }
        }
        public string IfAdminStatus1SwitchIndicator
        {
            get { return _ifadminstatus1switchindicator; }
            set
            {
                _ifadminstatus1switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus1SwitchIndicator));
            }
        }
        public string IfAdminStatus2SwitchIndicator
        {
            get { return _ifadminstatus2switchindicator; }
            set
            {
                _ifadminstatus2switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus2SwitchIndicator));
            }
        }
        public string IfAdminStatus3SwitchIndicator
        {
            get { return _ifadminstatus3switchindicator; }
            set
            {
                _ifadminstatus3switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus3SwitchIndicator));
            }
        }
        public string IfAdminStatus4SwitchIndicator
        {
            get { return _ifadminstatus4switchindicator; }
            set
            {
                _ifadminstatus4switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus4SwitchIndicator));
            }
        }
        public string IfAdminStatus5SwitchIndicator
        {
            get { return _ifadminstatus5switchindicator; }
            set
            {
                _ifadminstatus5switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus5SwitchIndicator));
            }
        }
        public string IfAdminStatus6SwitchIndicator
        {
            get { return _ifadminstatus6switchindicator; }
            set
            {
                _ifadminstatus6switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus6SwitchIndicator));
            }
        }
        public string IfAdminStatus7SwitchIndicator
        {
            get { return _ifadminstatus7switchindicator; }
            set
            {
                _ifadminstatus7switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus7SwitchIndicator));
            }
        }
        public string IfAdminStatus8SwitchIndicator
        {
            get { return _ifadminstatus8switchindicator; }
            set
            {
                _ifadminstatus8switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus8SwitchIndicator));
            }
        }
        public string IfAdminStatus9SwitchIndicator
        {
            get { return _ifadminstatus9switchindicator; }
            set
            {
                _ifadminstatus9switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus9SwitchIndicator));
            }
        }
        public string IfAdminStatus10SwitchIndicator
        {
            get { return _ifadminstatus10switchindicator; }
            set
            {
                _ifadminstatus10switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus10SwitchIndicator));
            }
        }
        public string IfAdminStatus11SwitchIndicator
        {
            get { return _ifadminstatus11switchindicator; }
            set
            {
                _ifadminstatus11switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus11SwitchIndicator));
            }
        }
        public string IfAdminStatus12SwitchIndicator
        {
            get { return _ifadminstatus12switchindicator; }
            set
            {
                _ifadminstatus12switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus12SwitchIndicator));
            }
        }
        public string IfAdminStatus13SwitchIndicator
        {
            get { return _ifadminstatus13switchindicator; }
            set
            {
                _ifadminstatus13switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus13SwitchIndicator));
            }
        }
        public string IfAdminStatus14SwitchIndicator
        {
            get { return _ifadminstatus14switchindicator; }
            set
            {
                _ifadminstatus14switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus14SwitchIndicator));
            }
        }
        public string IfAdminStatus15SwitchIndicator
        {
            get { return _ifadminstatus15switchindicator; }
            set
            {
                _ifadminstatus15switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus15SwitchIndicator));
            }
        }
        public string IfAdminStatus16SwitchIndicator
        {
            get { return _ifadminstatus16switchindicator; }
            set
            {
                _ifadminstatus16switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus16SwitchIndicator));
            }
        }
        public string IfAdminStatus17SwitchIndicator
        {
            get { return _ifadminstatus17switchindicator; }
            set
            {
                _ifadminstatus17switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus17SwitchIndicator));
            }
        }
        public string IfAdminStatus18SwitchIndicator
        {
            get { return _ifadminstatus18switchindicator; }
            set
            {
                _ifadminstatus18switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus18SwitchIndicator));
            }
        }
        public string IfAdminStatus19SwitchIndicator
        {
            get { return _ifadminstatus19switchindicator; }
            set
            {
                _ifadminstatus19switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus19SwitchIndicator));
            }
        }
        public string IfAdminStatus20SwitchIndicator
        {
            get { return _ifadminstatus20switchindicator; }
            set
            {
                _ifadminstatus20switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus20SwitchIndicator));
            }
        }
        public string IfAdminStatus21SwitchIndicator
        {
            get { return _ifadminstatus21switchindicator; }
            set
            {
                _ifadminstatus21switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus21SwitchIndicator));
            }
        }
        public string IfAdminStatus22SwitchIndicator
        {
            get { return _ifadminstatus22switchindicator; }
            set
            {
                _ifadminstatus22switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus22SwitchIndicator));
            }
        }
        public string IfAdminStatus23SwitchIndicator
        {
            get { return _ifadminstatus23switchindicator; }
            set
            {
                _ifadminstatus23switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus23SwitchIndicator));
            }
        }
        public string IfAdminStatus24SwitchIndicator
        {
            get { return _ifadminstatus24switchindicator; }
            set
            {
                _ifadminstatus24switchindicator = value;
                OnPropertyChanged(nameof(IfAdminStatus24SwitchIndicator));
            }
        }
        public string IfAdminStatus1SwitchTimestamp
        {
            get { return _ifadminstatus1switchtimestamp; }
            set
            {
                _ifadminstatus1switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus1SwitchTimestamp));
            }
        }
        public string IfAdminStatus2SwitchTimestamp
        {
            get { return _ifadminstatus2switchtimestamp; }
            set
            {
                _ifadminstatus2switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus2SwitchTimestamp));
            }
        }
        public string IfAdminStatus3SwitchTimestamp
        {
            get { return _ifadminstatus3switchtimestamp; }
            set
            {
                _ifadminstatus3switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus3SwitchTimestamp));
            }
        }
        public string IfAdminStatus4SwitchTimestamp
        {
            get { return _ifadminstatus4switchtimestamp; }
            set
            {
                _ifadminstatus4switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus4SwitchTimestamp));
            }
        }
        public string IfAdminStatus5SwitchTimestamp
        {
            get { return _ifadminstatus5switchtimestamp; }
            set
            {
                _ifadminstatus5switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus5SwitchTimestamp));
            }
        }
        public string IfAdminStatus6SwitchTimestamp
        {
            get { return _ifadminstatus6switchtimestamp; }
            set
            {
                _ifadminstatus6switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus6SwitchTimestamp));
            }
        }
        public string IfAdminStatus7SwitchTimestamp
        {
            get { return _ifadminstatus7switchtimestamp; }
            set
            {
                _ifadminstatus7switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus7SwitchTimestamp));
            }
        }
        public string IfAdminStatus8SwitchTimestamp
        {
            get { return _ifadminstatus8switchtimestamp; }
            set
            {
                _ifadminstatus8switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus8SwitchTimestamp));
            }
        }
        public string IfAdminStatus9SwitchTimestamp
        {
            get { return _ifadminstatus9switchtimestamp; }
            set
            {
                _ifadminstatus9switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus9SwitchTimestamp));
            }
        }
        public string IfAdminStatus10SwitchTimestamp
        {
            get { return _ifadminstatus10switchtimestamp; }
            set
            {
                _ifadminstatus10switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus10SwitchTimestamp));
            }
        }
        public string IfAdminStatus11SwitchTimestamp
        {
            get { return _ifadminstatus11switchtimestamp; }
            set
            {
                _ifadminstatus11switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus11SwitchTimestamp));
            }
        }
        public string IfAdminStatus12SwitchTimestamp
        {
            get { return _ifadminstatus12switchtimestamp; }
            set
            {
                _ifadminstatus12switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus12SwitchTimestamp));
            }
        }
        public string IfAdminStatus13SwitchTimestamp
        {
            get { return _ifadminstatus13switchtimestamp; }
            set
            {
                _ifadminstatus13switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus13SwitchTimestamp));
            }
        }
        public string IfAdminStatus14SwitchTimestamp
        {
            get { return _ifadminstatus14switchtimestamp; }
            set
            {
                _ifadminstatus14switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus14SwitchTimestamp));
            }
        }
        public string IfAdminStatus15SwitchTimestamp
        {
            get { return _ifadminstatus15switchtimestamp; }
            set
            {
                _ifadminstatus15switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus15SwitchTimestamp));
            }
        }
        public string IfAdminStatus16SwitchTimestamp
        {
            get { return _ifadminstatus16switchtimestamp; }
            set
            {
                _ifadminstatus16switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus16SwitchTimestamp));
            }
        }
        public string IfAdminStatus17SwitchTimestamp
        {
            get { return _ifadminstatus17switchtimestamp; }
            set
            {
                _ifadminstatus17switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus17SwitchTimestamp));
            }
        }
        public string IfAdminStatus18SwitchTimestamp
        {
            get { return _ifadminstatus18switchtimestamp; }
            set
            {
                _ifadminstatus18switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus18SwitchTimestamp));
            }
        }
        public string IfAdminStatus19SwitchTimestamp
        {
            get { return _ifadminstatus19switchtimestamp; }
            set
            {
                _ifadminstatus19switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus19SwitchTimestamp));
            }
        }
        public string IfAdminStatus20SwitchTimestamp
        {
            get { return _ifadminstatus20switchtimestamp; }
            set
            {
                _ifadminstatus20switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus20SwitchTimestamp));
            }
        }
        public string IfAdminStatus21SwitchTimestamp
        {
            get { return _ifadminstatus21switchtimestamp; }
            set
            {
                _ifadminstatus21switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus21SwitchTimestamp));
            }
        }
        public string IfAdminStatus22SwitchTimestamp
        {
            get { return _ifadminstatus22switchtimestamp; }
            set
            {
                _ifadminstatus22switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus22SwitchTimestamp));
            }
        }
        public string IfAdminStatus23SwitchTimestamp
        {
            get { return _ifadminstatus23switchtimestamp; }
            set
            {
                _ifadminstatus23switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus23SwitchTimestamp));
            }
        }
        public string IfAdminStatus24SwitchTimestamp
        {
            get { return _ifadminstatus24switchtimestamp; }
            set
            {
                _ifadminstatus24switchtimestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus24SwitchTimestamp));
            }
        }
        #endregion

        #region Admin2
        public string IfAdminStatus1Switch2
        {
            get { return _ifadminstatus1switch2; }
            set
            {
                _ifadminstatus1switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus1Switch2));
            }
        }
        public string IfAdminStatus2Switch2
        {
            get { return _ifadminstatus2switch2; }
            set
            {
                _ifadminstatus2switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus2Switch2));
            }
        }
        public string IfAdminStatus3Switch2
        {
            get { return _ifadminstatus3switch2; }
            set
            {
                _ifadminstatus3switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus3Switch2));
            }
        }
        public string IfAdminStatus4Switch2
        {
            get { return _ifadminstatus4switch2; }
            set
            {
                _ifadminstatus4switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus4Switch2));
            }
        }
        public string IfAdminStatus5Switch2
        {
            get { return _ifadminstatus5switch2; }
            set
            {
                _ifadminstatus5switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus5Switch2));
            }
        }
        public string IfAdminStatus6Switch2
        {
            get { return _ifadminstatus6switch2; }
            set
            {
                _ifadminstatus6switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus6Switch2));
            }
        }
        public string IfAdminStatus7Switch2
        {
            get { return _ifadminstatus7switch2; }
            set
            {
                _ifadminstatus7switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus7Switch2));
            }
        }
        public string IfAdminStatus8Switch2
        {
            get { return _ifadminstatus8switch2; }
            set
            {
                _ifadminstatus8switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus8Switch2));
            }
        }
        public string IfAdminStatus9Switch2
        {
            get { return _ifadminstatus9switch2; }
            set
            {
                _ifadminstatus9switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus9Switch2));
            }
        }
        public string IfAdminStatus10Switch2
        {
            get { return _ifadminstatus10switch2; }
            set
            {
                _ifadminstatus10switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus10Switch2));
            }
        }
        public string IfAdminStatus11Switch2
        {
            get { return _ifadminstatus11switch2; }
            set
            {
                _ifadminstatus11switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus11Switch2));
            }
        }
        public string IfAdminStatus12Switch2
        {
            get { return _ifadminstatus12switch2; }
            set
            {
                _ifadminstatus12switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus12Switch2));
            }
        }
        public string IfAdminStatus13Switch2
        {
            get { return _ifadminstatus13switch2; }
            set
            {
                _ifadminstatus13switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus13Switch2));
            }
        }
        public string IfAdminStatus14Switch2
        {
            get { return _ifadminstatus14switch2; }
            set
            {
                _ifadminstatus14switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus14Switch2));
            }
        }
        public string IfAdminStatus15Switch2
        {
            get { return _ifadminstatus15switch2; }
            set
            {
                _ifadminstatus15switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus15Switch2));
            }
        }
        public string IfAdminStatus16Switch2
        {
            get { return _ifadminstatus16switch2; }
            set
            {
                _ifadminstatus16switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus16Switch2));
            }
        }
        public string IfAdminStatus17Switch2
        {
            get { return _ifadminstatus17switch2; }
            set
            {
                _ifadminstatus17switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus17Switch2));
            }
        }
        public string IfAdminStatus18Switch2
        {
            get { return _ifadminstatus18switch2; }
            set
            {
                _ifadminstatus18switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus18Switch2));
            }
        }
        public string IfAdminStatus19Switch2
        {
            get { return _ifadminstatus19switch2; }
            set
            {
                _ifadminstatus19switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus19Switch2));
            }
        }
        public string IfAdminStatus20Switch2
        {
            get { return _ifadminstatus20switch2; }
            set
            {
                _ifadminstatus20switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus20Switch2));
            }
        }
        public string IfAdminStatus21Switch2
        {
            get { return _ifadminstatus21switch2; }
            set
            {
                _ifadminstatus21switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus21Switch2));
            }
        }
        public string IfAdminStatus22Switch2
        {
            get { return _ifadminstatus22switch2; }
            set
            {
                _ifadminstatus22switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus22Switch2));
            }
        }
        public string IfAdminStatus23Switch2
        {
            get { return _ifadminstatus23switch2; }
            set
            {
                _ifadminstatus23switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus23Switch2));
            }
        }
        public string IfAdminStatus24Switch2
        {
            get { return _ifadminstatus24switch2; }
            set
            {
                _ifadminstatus24switch2 = value;
                OnPropertyChanged(nameof(IfAdminStatus24Switch2));
            }
        }
        public string IfAdminStatus1SwitchIndicator2
        {
            get { return _ifadminstatus1switchindicator2; }
            set
            {
                _ifadminstatus1switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus1SwitchIndicator2));
            }
        }
        public string IfAdminStatus2SwitchIndicator2
        {
            get { return _ifadminstatus2switchindicator2; }
            set
            {
                _ifadminstatus2switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus2SwitchIndicator2));
            }
        }
        public string IfAdminStatus3SwitchIndicator2
        {
            get { return _ifadminstatus3switchindicator2; }
            set
            {
                _ifadminstatus3switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus3SwitchIndicator2));
            }
        }
        public string IfAdminStatus4SwitchIndicator2
        {
            get { return _ifadminstatus4switchindicator2; }
            set
            {
                _ifadminstatus4switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus4SwitchIndicator2));
            }
        }
        public string IfAdminStatus5SwitchIndicator2
        {
            get { return _ifadminstatus5switchindicator2; }
            set
            {
                _ifadminstatus5switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus5SwitchIndicator2));
            }
        }
        public string IfAdminStatus6SwitchIndicator2
        {
            get { return _ifadminstatus6switchindicator2; }
            set
            {
                _ifadminstatus6switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus6SwitchIndicator2));
            }
        }
        public string IfAdminStatus7SwitchIndicator2
        {
            get { return _ifadminstatus7switchindicator2; }
            set
            {
                _ifadminstatus7switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus7SwitchIndicator2));
            }
        }
        public string IfAdminStatus8SwitchIndicator2
        {
            get { return _ifadminstatus8switchindicator2; }
            set
            {
                _ifadminstatus8switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus8SwitchIndicator2));
            }
        }
        public string IfAdminStatus9SwitchIndicator2
        {
            get { return _ifadminstatus9switchindicator2; }
            set
            {
                _ifadminstatus9switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus9SwitchIndicator2));
            }
        }
        public string IfAdminStatus10SwitchIndicator2
        {
            get { return _ifadminstatus10switchindicator2; }
            set
            {
                _ifadminstatus10switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus10SwitchIndicator2));
            }
        }
        public string IfAdminStatus11SwitchIndicator2
        {
            get { return _ifadminstatus11switchindicator2; }
            set
            {
                _ifadminstatus11switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus11SwitchIndicator2));
            }
        }
        public string IfAdminStatus12SwitchIndicator2
        {
            get { return _ifadminstatus12switchindicator2; }
            set
            {
                _ifadminstatus12switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus12SwitchIndicator2));
            }
        }
        public string IfAdminStatus13SwitchIndicator2
        {
            get { return _ifadminstatus13switchindicator2; }
            set
            {
                _ifadminstatus13switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus13SwitchIndicator2));
            }
        }
        public string IfAdminStatus14SwitchIndicator2
        {
            get { return _ifadminstatus14switchindicator2; }
            set
            {
                _ifadminstatus14switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus14SwitchIndicator2));
            }
        }
        public string IfAdminStatus15SwitchIndicator2
        {
            get { return _ifadminstatus15switchindicator2; }
            set
            {
                _ifadminstatus15switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus15SwitchIndicator2));
            }
        }
        public string IfAdminStatus16SwitchIndicator2
        {
            get { return _ifadminstatus16switchindicator2; }
            set
            {
                _ifadminstatus16switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus16SwitchIndicator2));
            }
        }
        public string IfAdminStatus17SwitchIndicator2
        {
            get { return _ifadminstatus17switchindicator2; }
            set
            {
                _ifadminstatus17switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus17SwitchIndicator2));
            }
        }
        public string IfAdminStatus18SwitchIndicator2
        {
            get { return _ifadminstatus18switchindicator2; }
            set
            {
                _ifadminstatus18switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus18SwitchIndicator2));
            }
        }
        public string IfAdminStatus19SwitchIndicator2
        {
            get { return _ifadminstatus19switchindicator2; }
            set
            {
                _ifadminstatus19switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus19SwitchIndicator2));
            }
        }
        public string IfAdminStatus20SwitchIndicator2
        {
            get { return _ifadminstatus20switchindicator2; }
            set
            {
                _ifadminstatus20switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus20SwitchIndicator2));
            }
        }
        public string IfAdminStatus21SwitchIndicator2
        {
            get { return _ifadminstatus21switchindicator2; }
            set
            {
                _ifadminstatus21switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus21SwitchIndicator2));
            }
        }
        public string IfAdminStatus22SwitchIndicator2
        {
            get { return _ifadminstatus22switchindicator2; }
            set
            {
                _ifadminstatus22switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus22SwitchIndicator2));
            }
        }
        public string IfAdminStatus23SwitchIndicator2
        {
            get { return _ifadminstatus23switchindicator2; }
            set
            {
                _ifadminstatus23switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus23SwitchIndicator2));
            }
        }
        public string IfAdminStatus24SwitchIndicator2
        {
            get { return _ifadminstatus24switchindicator2; }
            set
            {
                _ifadminstatus24switchindicator2 = value;
                OnPropertyChanged(nameof(IfAdminStatus24SwitchIndicator2));
            }
        }
        public string IfAdminStatus1SwitchTimestamp2
        {
            get { return _ifadminstatus1switchtimestamp2; }
            set
            {
                _ifadminstatus1switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus1SwitchTimestamp2));
            }
        }
        public string IfAdminStatus2SwitchTimestamp2
        {
            get { return _ifadminstatus2switchtimestamp2; }
            set
            {
                _ifadminstatus2switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus2SwitchTimestamp2));
            }
        }
        public string IfAdminStatus3SwitchTimestamp2
        {
            get { return _ifadminstatus3switchtimestamp2; }
            set
            {
                _ifadminstatus3switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus3SwitchTimestamp2));
            }
        }
        public string IfAdminStatus4SwitchTimestamp2
        {
            get { return _ifadminstatus4switchtimestamp2; }
            set
            {
                _ifadminstatus4switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus4SwitchTimestamp2));
            }
        }
        public string IfAdminStatus5SwitchTimestamp2
        {
            get { return _ifadminstatus5switchtimestamp2; }
            set
            {
                _ifadminstatus5switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus5SwitchTimestamp2));
            }
        }
        public string IfAdminStatus6SwitchTimestamp2
        {
            get { return _ifadminstatus6switchtimestamp2; }
            set
            {
                _ifadminstatus6switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus6SwitchTimestamp2));
            }
        }
        public string IfAdminStatus7SwitchTimestamp2
        {
            get { return _ifadminstatus7switchtimestamp2; }
            set
            {
                _ifadminstatus7switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus7SwitchTimestamp2));
            }
        }
        public string IfAdminStatus8SwitchTimestamp2
        {
            get { return _ifadminstatus8switchtimestamp2; }
            set
            {
                _ifadminstatus8switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus8SwitchTimestamp2));
            }
        }
        public string IfAdminStatus9SwitchTimestamp2
        {
            get { return _ifadminstatus9switchtimestamp2; }
            set
            {
                _ifadminstatus9switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus9SwitchTimestamp2));
            }
        }
        public string IfAdminStatus10SwitchTimestamp2
        {
            get { return _ifadminstatus10switchtimestamp2; }
            set
            {
                _ifadminstatus10switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus10SwitchTimestamp2));
            }
        }
        public string IfAdminStatus11SwitchTimestamp2
        {
            get { return _ifadminstatus11switchtimestamp2; }
            set
            {
                _ifadminstatus11switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus11SwitchTimestamp2));
            }
        }
        public string IfAdminStatus12SwitchTimestamp2
        {
            get { return _ifadminstatus12switchtimestamp2; }
            set
            {
                _ifadminstatus12switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus12SwitchTimestamp2));
            }
        }
        public string IfAdminStatus13SwitchTimestamp2
        {
            get { return _ifadminstatus13switchtimestamp2; }
            set
            {
                _ifadminstatus13switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus13SwitchTimestamp2));
            }
        }
        public string IfAdminStatus14SwitchTimestamp2
        {
            get { return _ifadminstatus14switchtimestamp2; }
            set
            {
                _ifadminstatus14switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus14SwitchTimestamp2));
            }
        }
        public string IfAdminStatus15SwitchTimestamp2
        {
            get { return _ifadminstatus15switchtimestamp2; }
            set
            {
                _ifadminstatus15switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus15SwitchTimestamp2));
            }
        }
        public string IfAdminStatus16SwitchTimestamp2
        {
            get { return _ifadminstatus16switchtimestamp2; }
            set
            {
                _ifadminstatus16switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus16SwitchTimestamp2));
            }
        }
        public string IfAdminStatus17SwitchTimestamp2
        {
            get { return _ifadminstatus17switchtimestamp2; }
            set
            {
                _ifadminstatus17switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus17SwitchTimestamp2));
            }
        }
        public string IfAdminStatus18SwitchTimestamp2
        {
            get { return _ifadminstatus18switchtimestamp2; }
            set
            {
                _ifadminstatus18switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus18SwitchTimestamp2));
            }
        }
        public string IfAdminStatus19SwitchTimestamp2
        {
            get { return _ifadminstatus19switchtimestamp2; }
            set
            {
                _ifadminstatus19switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus19SwitchTimestamp2));
            }
        }
        public string IfAdminStatus20SwitchTimestamp2
        {
            get { return _ifadminstatus20switchtimestamp2; }
            set
            {
                _ifadminstatus20switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus20SwitchTimestamp2));
            }
        }
        public string IfAdminStatus21SwitchTimestamp2
        {
            get { return _ifadminstatus21switchtimestamp2; }
            set
            {
                _ifadminstatus21switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus21SwitchTimestamp2));
            }
        }
        public string IfAdminStatus22SwitchTimestamp2
        {
            get { return _ifadminstatus22switchtimestamp2; }
            set
            {
                _ifadminstatus22switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus22SwitchTimestamp2));
            }
        }
        public string IfAdminStatus23SwitchTimestamp2
        {
            get { return _ifadminstatus23switchtimestamp2; }
            set
            {
                _ifadminstatus23switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus23SwitchTimestamp2));
            }
        }
        public string IfAdminStatus24SwitchTimestamp2
        {
            get { return _ifadminstatus24switchtimestamp2; }
            set
            {
                _ifadminstatus24switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfAdminStatus24SwitchTimestamp2));
            }
        }
        #endregion



        #region Switch OperStatus Property

        public string IfOperStatus1Switch
        {
            get { return _ifoperstatus1switch; }
            set
            {
                _ifoperstatus1switch = value;
                OnPropertyChanged(nameof(IfOperStatus1Switch));
            }
        }
        public string IfOperStatus2Switch
        {
            get { return _ifoperstatus2switch; }
            set
            {
                _ifoperstatus2switch = value;
                OnPropertyChanged(nameof(IfOperStatus2Switch));
            }
        }
        public string IfOperStatus3Switch
        {
            get { return _ifoperstatus3switch; }
            set
            {
                _ifoperstatus3switch = value;
                OnPropertyChanged(nameof(IfOperStatus3Switch));
            }
        }
        public string IfOperStatus4Switch
        {
            get { return _ifoperstatus4switch; }
            set
            {
                _ifoperstatus4switch = value;
                OnPropertyChanged(nameof(IfOperStatus4Switch));
            }
        }
        public string IfOperStatus5Switch
        {
            get { return _ifoperstatus5switch; }
            set
            {
                _ifoperstatus5switch = value;
                OnPropertyChanged(nameof(IfOperStatus5Switch));
            }
        }
        public string IfOperStatus6Switch
        {
            get { return _ifoperstatus6switch; }
            set
            {
                _ifoperstatus6switch = value;
                OnPropertyChanged(nameof(IfOperStatus6Switch));
            }
        }
        public string IfOperStatus7Switch
        {
            get { return _ifoperstatus7switch; }
            set
            {
                _ifoperstatus7switch = value;
                OnPropertyChanged(nameof(IfOperStatus7Switch));
            }
        }
        public string IfOperStatus8Switch
        {
            get { return _ifoperstatus8switch; }
            set
            {
                _ifoperstatus8switch = value;
                OnPropertyChanged(nameof(IfOperStatus8Switch));
            }
        }
        public string IfOperStatus9Switch
        {
            get { return _ifoperstatus9switch; }
            set
            {
                _ifoperstatus9switch = value;
                OnPropertyChanged(nameof(IfOperStatus9Switch));
            }
        }
        public string IfOperStatus10Switch
        {
            get { return _ifoperstatus10switch; }
            set
            {
                _ifoperstatus10switch = value;
                OnPropertyChanged(nameof(IfOperStatus10Switch));
            }
        }
        public string IfOperStatus11Switch
        {
            get { return _ifoperstatus11switch; }
            set
            {
                _ifoperstatus11switch = value;
                OnPropertyChanged(nameof(IfOperStatus11Switch));
            }
        }
        public string IfOperStatus12Switch
        {
            get { return _ifoperstatus12switch; }
            set
            {
                _ifoperstatus12switch = value;
                OnPropertyChanged(nameof(IfOperStatus12Switch));
            }
        }
        public string IfOperStatus13Switch
        {
            get { return _ifoperstatus13switch; }
            set
            {
                _ifoperstatus13switch = value;
                OnPropertyChanged(nameof(IfOperStatus13Switch));
            }
        }
        public string IfOperStatus14Switch
        {
            get { return _ifoperstatus14switch; }
            set
            {
                _ifoperstatus14switch = value;
                OnPropertyChanged(nameof(IfOperStatus14Switch));
            }
        }
        public string IfOperStatus15Switch
        {
            get { return _ifoperstatus15switch; }
            set
            {
                _ifoperstatus15switch = value;
                OnPropertyChanged(nameof(IfOperStatus15Switch));
            }
        }
        public string IfOperStatus16Switch
        {
            get { return _ifoperstatus16switch; }
            set
            {
                _ifoperstatus16switch = value;
                OnPropertyChanged(nameof(IfOperStatus16Switch));
            }
        }
        public string IfOperStatus17Switch
        {
            get { return _ifoperstatus17switch; }
            set
            {
                _ifoperstatus17switch = value;
                OnPropertyChanged(nameof(IfOperStatus17Switch));
            }
        }
        public string IfOperStatus18Switch
        {
            get { return _ifoperstatus18switch; }
            set
            {
                _ifoperstatus18switch = value;
                OnPropertyChanged(nameof(IfOperStatus18Switch));
            }
        }
        public string IfOperStatus19Switch
        {
            get { return _ifoperstatus19switch; }
            set
            {
                _ifoperstatus19switch = value;
                OnPropertyChanged(nameof(IfOperStatus19Switch));
            }
        }
        public string IfOperStatus20Switch
        {
            get { return _ifoperstatus20switch; }
            set
            {
                _ifoperstatus20switch = value;
                OnPropertyChanged(nameof(IfOperStatus20Switch));
            }
        }
        public string IfOperStatus21Switch
        {
            get { return _ifoperstatus21switch; }
            set
            {
                _ifoperstatus21switch = value;
                OnPropertyChanged(nameof(IfOperStatus21Switch));
            }
        }
        public string IfOperStatus22Switch
        {
            get { return _ifoperstatus22switch; }
            set
            {
                _ifoperstatus22switch = value;
                OnPropertyChanged(nameof(IfOperStatus22Switch));
            }
        }
        public string IfOperStatus23Switch
        {
            get { return _ifoperstatus23switch; }
            set
            {
                _ifoperstatus23switch = value;
                OnPropertyChanged(nameof(IfOperStatus23Switch));
            }
        }
        public string IfOperStatus24Switch
        {
            get { return _ifoperstatus24switch; }
            set
            {
                _ifoperstatus24switch = value;
                OnPropertyChanged(nameof(IfOperStatus24Switch));
            }
        }
        public string IfOperStatus1SwitchIndicator
        {
            get { return _ifoperstatus1switchindicator; }
            set
            {
                _ifoperstatus1switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus1SwitchIndicator));
            }
        }
        public string IfOperStatus2SwitchIndicator
        {
            get { return _ifoperstatus2switchindicator; }
            set
            {
                _ifoperstatus2switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus2SwitchIndicator));
            }
        }
        public string IfOperStatus3SwitchIndicator
        {
            get { return _ifoperstatus3switchindicator; }
            set
            {
                _ifoperstatus3switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus3SwitchIndicator));
            }
        }
        public string IfOperStatus4SwitchIndicator
        {
            get { return _ifoperstatus4switchindicator; }
            set
            {
                _ifoperstatus4switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus4SwitchIndicator));
            }
        }
        public string IfOperStatus5SwitchIndicator
        {
            get { return _ifoperstatus5switchindicator; }
            set
            {
                _ifoperstatus5switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus5SwitchIndicator));
            }
        }
        public string IfOperStatus6SwitchIndicator
        {
            get { return _ifoperstatus6switchindicator; }
            set
            {
                _ifoperstatus6switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus6SwitchIndicator));
            }
        }
        public string IfOperStatus7SwitchIndicator
        {
            get { return _ifoperstatus7switchindicator; }
            set
            {
                _ifoperstatus7switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus7SwitchIndicator));
            }
        }
        public string IfOperStatus8SwitchIndicator
        {
            get { return _ifoperstatus8switchindicator; }
            set
            {
                _ifoperstatus8switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus8SwitchIndicator));
            }
        }
        public string IfOperStatus9SwitchIndicator
        {
            get { return _ifoperstatus9switchindicator; }
            set
            {
                _ifoperstatus9switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus9SwitchIndicator));
            }
        }
        public string IfOperStatus10SwitchIndicator
        {
            get { return _ifoperstatus10switchindicator; }
            set
            {
                _ifoperstatus10switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus10SwitchIndicator));
            }
        }
        public string IfOperStatus11SwitchIndicator
        {
            get { return _ifoperstatus11switchindicator; }
            set
            {
                _ifoperstatus11switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus11SwitchIndicator));
            }
        }
        public string IfOperStatus12SwitchIndicator
        {
            get { return _ifoperstatus12switchindicator; }
            set
            {
                _ifoperstatus12switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus12SwitchIndicator));
            }
        }
        public string IfOperStatus13SwitchIndicator
        {
            get { return _ifoperstatus13switchindicator; }
            set
            {
                _ifoperstatus13switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus13SwitchIndicator));
            }
        }
        public string IfOperStatus14SwitchIndicator
        {
            get { return _ifoperstatus14switchindicator; }
            set
            {
                _ifoperstatus14switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus14SwitchIndicator));
            }
        }
        public string IfOperStatus15SwitchIndicator
        {
            get { return _ifoperstatus15switchindicator; }
            set
            {
                _ifoperstatus15switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus15SwitchIndicator));
            }
        }
        public string IfOperStatus16SwitchIndicator
        {
            get { return _ifoperstatus16switchindicator; }
            set
            {
                _ifoperstatus16switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus16SwitchIndicator));
            }
        }
        public string IfOperStatus17SwitchIndicator
        {
            get { return _ifoperstatus17switchindicator; }
            set
            {
                _ifoperstatus17switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus17SwitchIndicator));
            }
        }
        public string IfOperStatus18SwitchIndicator
        {
            get { return _ifoperstatus18switchindicator; }
            set
            {
                _ifoperstatus18switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus18SwitchIndicator));
            }
        }
        public string IfOperStatus19SwitchIndicator
        {
            get { return _ifoperstatus19switchindicator; }
            set
            {
                _ifoperstatus19switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus19SwitchIndicator));
            }
        }
        public string IfOperStatus20SwitchIndicator
        {
            get { return _ifoperstatus20switchindicator; }
            set
            {
                _ifoperstatus20switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus20SwitchIndicator));
            }
        }
        public string IfOperStatus21SwitchIndicator
        {
            get { return _ifoperstatus21switchindicator; }
            set
            {
                _ifoperstatus21switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus21SwitchIndicator));
            }
        }
        public string IfOperStatus22SwitchIndicator
        {
            get { return _ifoperstatus22switchindicator; }
            set
            {
                _ifoperstatus22switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus22SwitchIndicator));
            }
        }
        public string IfOperStatus23SwitchIndicator
        {
            get { return _ifoperstatus23switchindicator; }
            set
            {
                _ifoperstatus23switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus23SwitchIndicator));
            }
        }
        public string IfOperStatus24SwitchIndicator
        {
            get { return _ifoperstatus24switchindicator; }
            set
            {
                _ifoperstatus24switchindicator = value;
                OnPropertyChanged(nameof(IfOperStatus24SwitchIndicator));
            }
        }

        public string IfOperStatus1SwitchTimestamp
        {
            get { return _ifoperstatus1switchtimestamp; }
            set
            {
                _ifoperstatus1switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus1SwitchTimestamp));
            }
        }
        public string IfOperStatus2SwitchTimestamp
        {
            get { return _ifoperstatus2switchtimestamp; }
            set
            {
                _ifoperstatus2switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus2SwitchTimestamp));
            }
        }
        public string IfOperStatus3SwitchTimestamp
        {
            get { return _ifoperstatus3switchtimestamp; }
            set
            {
                _ifoperstatus3switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus3SwitchTimestamp));
            }
        }
        public string IfOperStatus4SwitchTimestamp
        {
            get { return _ifoperstatus4switchtimestamp; }
            set
            {
                _ifoperstatus4switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus4SwitchTimestamp));
            }
        }
        public string IfOperStatus5SwitchTimestamp
        {
            get { return _ifoperstatus5switchtimestamp; }
            set
            {
                _ifoperstatus5switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus5SwitchTimestamp));
            }
        }
        public string IfOperStatus6SwitchTimestamp
        {
            get { return _ifoperstatus6switchtimestamp; }
            set
            {
                _ifoperstatus6switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus6SwitchTimestamp));
            }
        }
        public string IfOperStatus7SwitchTimestamp
        {
            get { return _ifoperstatus7switchtimestamp; }
            set
            {
                _ifoperstatus7switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus7SwitchTimestamp));
            }
        }
        public string IfOperStatus8SwitchTimestamp
        {
            get { return _ifoperstatus8switchtimestamp; }
            set
            {
                _ifoperstatus8switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus8SwitchTimestamp));
            }
        }
        public string IfOperStatus9SwitchTimestamp
        {
            get { return _ifoperstatus9switchtimestamp; }
            set
            {
                _ifoperstatus9switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus9SwitchTimestamp));
            }
        }
        public string IfOperStatus10SwitchTimestamp
        {
            get { return _ifoperstatus10switchtimestamp; }
            set
            {
                _ifoperstatus10switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus10SwitchTimestamp));
            }
        }
        public string IfOperStatus11SwitchTimestamp
        {
            get { return _ifoperstatus11switchtimestamp; }
            set
            {
                _ifoperstatus11switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus11SwitchTimestamp));
            }
        }
        public string IfOperStatus12SwitchTimestamp
        {
            get { return _ifoperstatus12switchtimestamp; }
            set
            {
                _ifoperstatus12switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus12SwitchTimestamp));
            }
        }
        public string IfOperStatus13SwitchTimestamp
        {
            get { return _ifoperstatus13switchtimestamp; }
            set
            {
                _ifoperstatus13switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus13SwitchTimestamp));
            }
        }
        public string IfOperStatus14SwitchTimestamp
        {
            get { return _ifoperstatus14switchtimestamp; }
            set
            {
                _ifoperstatus14switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus14SwitchTimestamp));
            }
        }
        public string IfOperStatus15SwitchTimestamp
        {
            get { return _ifoperstatus15switchtimestamp; }
            set
            {
                _ifoperstatus15switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus15SwitchTimestamp));
            }
        }
        public string IfOperStatus16SwitchTimestamp
        {
            get { return _ifoperstatus16switchtimestamp; }
            set
            {
                _ifoperstatus16switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus16SwitchTimestamp));
            }
        }
        public string IfOperStatus17SwitchTimestamp
        {
            get { return _ifoperstatus17switchtimestamp; }
            set
            {
                _ifoperstatus17switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus17SwitchTimestamp));
            }
        }
        public string IfOperStatus18SwitchTimestamp
        {
            get { return _ifoperstatus18switchtimestamp; }
            set
            {
                _ifoperstatus18switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus18SwitchTimestamp));
            }
        }
        public string IfOperStatus19SwitchTimestamp
        {
            get { return _ifoperstatus19switchtimestamp; }
            set
            {
                _ifoperstatus19switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus19SwitchTimestamp));
            }
        }
        public string IfOperStatus20SwitchTimestamp
        {
            get { return _ifoperstatus20switchtimestamp; }
            set
            {
                _ifoperstatus20switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus20SwitchTimestamp));
            }
        }
        public string IfOperStatus21SwitchTimestamp
        {
            get { return _ifoperstatus21switchtimestamp; }
            set
            {
                _ifoperstatus21switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus21SwitchTimestamp));
            }
        }
        public string IfOperStatus22SwitchTimestamp
        {
            get { return _ifoperstatus22switchtimestamp; }
            set
            {
                _ifoperstatus22switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus22SwitchTimestamp));
            }
        }
        public string IfOperStatus23SwitchTimestamp
        {
            get { return _ifoperstatus23switchtimestamp; }
            set
            {
                _ifoperstatus23switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus23SwitchTimestamp));
            }
        }
        public string IfOperStatus24SwitchTimestamp
        {
            get { return _ifoperstatus24switchtimestamp; }
            set
            {
                _ifoperstatus24switchtimestamp = value;
                OnPropertyChanged(nameof(IfOperStatus24SwitchTimestamp));
            }
        }
        #endregion
        #region Operational2
        public string IfOperStatus1Switch2
        {
            get { return _ifoperstatus1switch2; }
            set
            {
                _ifoperstatus1switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus1Switch2));
            }
        }
        public string IfOperStatus2Switch2
        {
            get { return _ifoperstatus2switch2; }
            set
            {
                _ifoperstatus2switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus2Switch2));
            }
        }
        public string IfOperStatus3Switch2
        {
            get { return _ifoperstatus3switch2; }
            set
            {
                _ifoperstatus3switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus3Switch2));
            }
        }
        public string IfOperStatus4Switch2
        {
            get { return _ifoperstatus4switch2; }
            set
            {
                _ifoperstatus4switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus4Switch2));
            }
        }
        public string IfOperStatus5Switch2
        {
            get { return _ifoperstatus5switch2; }
            set
            {
                _ifoperstatus5switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus5Switch2));
            }
        }
        public string IfOperStatus6Switch2
        {
            get { return _ifoperstatus6switch2; }
            set
            {
                _ifoperstatus6switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus6Switch2));
            }
        }
        public string IfOperStatus7Switch2
        {
            get { return _ifoperstatus7switch2; }
            set
            {
                _ifoperstatus7switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus7Switch2));
            }
        }
        public string IfOperStatus8Switch2
        {
            get { return _ifoperstatus8switch2; }
            set
            {
                _ifoperstatus8switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus8Switch2));
            }
        }
        public string IfOperStatus9Switch2
        {
            get { return _ifoperstatus9switch2; }
            set
            {
                _ifoperstatus9switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus9Switch2));
            }
        }
        public string IfOperStatus10Switch2
        {
            get { return _ifoperstatus10switch2; }
            set
            {
                _ifoperstatus10switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus10Switch2));
            }
        }
        public string IfOperStatus11Switch2
        {
            get { return _ifoperstatus11switch2; }
            set
            {
                _ifoperstatus11switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus11Switch2));
            }
        }
        public string IfOperStatus12Switch2
        {
            get { return _ifoperstatus12switch2; }
            set
            {
                _ifoperstatus12switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus12Switch2));
            }
        }
        public string IfOperStatus13Switch2
        {
            get { return _ifoperstatus13switch2; }
            set
            {
                _ifoperstatus13switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus13Switch2));
            }
        }
        public string IfOperStatus14Switch2
        {
            get { return _ifoperstatus14switch2; }
            set
            {
                _ifoperstatus14switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus14Switch2));
            }
        }
        public string IfOperStatus15Switch2
        {
            get { return _ifoperstatus15switch2; }
            set
            {
                _ifoperstatus15switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus15Switch2));
            }
        }
        public string IfOperStatus16Switch2
        {
            get { return _ifoperstatus16switch2; }
            set
            {
                _ifoperstatus16switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus16Switch2));
            }
        }
        public string IfOperStatus17Switch2
        {
            get { return _ifoperstatus17switch2; }
            set
            {
                _ifoperstatus17switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus17Switch2));
            }
        }
        public string IfOperStatus18Switch2
        {
            get { return _ifoperstatus18switch2; }
            set
            {
                _ifoperstatus18switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus18Switch2));
            }
        }
        public string IfOperStatus19Switch2
        {
            get { return _ifoperstatus19switch2; }
            set
            {
                _ifoperstatus19switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus19Switch2));
            }
        }
        public string IfOperStatus20Switch2
        {
            get { return _ifoperstatus20switch2; }
            set
            {
                _ifoperstatus20switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus20Switch2));
            }
        }
        public string IfOperStatus21Switch2
        {
            get { return _ifoperstatus21switch2; }
            set
            {
                _ifoperstatus21switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus21Switch2));
            }
        }
        public string IfOperStatus22Switch2
        {
            get { return _ifoperstatus22switch2; }
            set
            {
                _ifoperstatus22switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus22Switch2));
            }
        }
        public string IfOperStatus23Switch2
        {
            get { return _ifoperstatus23switch2; }
            set
            {
                _ifoperstatus23switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus23Switch2));
            }
        }
        public string IfOperStatus24Switch2
        {
            get { return _ifoperstatus24switch2; }
            set
            {
                _ifoperstatus24switch2 = value;
                OnPropertyChanged(nameof(IfOperStatus24Switch2));
            }
        }
        public string IfOperStatus1SwitchIndicator2
        {
            get { return _ifoperstatus1switchindicator2; }
            set
            {
                _ifoperstatus1switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus1SwitchIndicator2));
            }
        }
        public string IfOperStatus2SwitchIndicator2
        {
            get { return _ifoperstatus2switchindicator2; }
            set
            {
                _ifoperstatus2switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus2SwitchIndicator2));
            }
        }
        public string IfOperStatus3SwitchIndicator2
        {
            get { return _ifoperstatus3switchindicator2; }
            set
            {
                _ifoperstatus3switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus3SwitchIndicator2));
            }
        }
        public string IfOperStatus4SwitchIndicator2
        {
            get { return _ifoperstatus4switchindicator2; }
            set
            {
                _ifoperstatus4switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus4SwitchIndicator2));
            }
        }
        public string IfOperStatus5SwitchIndicator2
        {
            get { return _ifoperstatus5switchindicator2; }
            set
            {
                _ifoperstatus5switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus5SwitchIndicator2));
            }
        }
        public string IfOperStatus6SwitchIndicator2
        {
            get { return _ifoperstatus6switchindicator2; }
            set
            {
                _ifoperstatus6switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus6SwitchIndicator2));
            }
        }
        public string IfOperStatus7SwitchIndicator2
        {
            get { return _ifoperstatus7switchindicator2; }
            set
            {
                _ifoperstatus7switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus7SwitchIndicator2));
            }
        }
        public string IfOperStatus8SwitchIndicator2
        {
            get { return _ifoperstatus8switchindicator2; }
            set
            {
                _ifoperstatus8switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus8SwitchIndicator2));
            }
        }
        public string IfOperStatus9SwitchIndicator2
        {
            get { return _ifoperstatus9switchindicator2; }
            set
            {
                _ifoperstatus9switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus9SwitchIndicator2));
            }
        }
        public string IfOperStatus10SwitchIndicator2
        {
            get { return _ifoperstatus10switchindicator2; }
            set
            {
                _ifoperstatus10switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus10SwitchIndicator2));
            }
        }
        public string IfOperStatus11SwitchIndicator2
        {
            get { return _ifoperstatus11switchindicator2; }
            set
            {
                _ifoperstatus11switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus11SwitchIndicator2));
            }
        }
        public string IfOperStatus12SwitchIndicator2
        {
            get { return _ifoperstatus12switchindicator2; }
            set
            {
                _ifoperstatus12switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus12SwitchIndicator2));
            }
        }
        public string IfOperStatus13SwitchIndicator2
        {
            get { return _ifoperstatus13switchindicator2; }
            set
            {
                _ifoperstatus13switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus13SwitchIndicator2));
            }
        }
        public string IfOperStatus14SwitchIndicator2
        {
            get { return _ifoperstatus14switchindicator2; }
            set
            {
                _ifoperstatus14switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus14SwitchIndicator2));
            }
        }
        public string IfOperStatus15SwitchIndicator2
        {
            get { return _ifoperstatus15switchindicator2; }
            set
            {
                _ifoperstatus15switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus15SwitchIndicator2));
            }
        }
        public string IfOperStatus16SwitchIndicator2
        {
            get { return _ifoperstatus16switchindicator2; }
            set
            {
                _ifoperstatus16switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus16SwitchIndicator2));
            }
        }
        public string IfOperStatus17SwitchIndicator2
        {
            get { return _ifoperstatus17switchindicator2; }
            set
            {
                _ifoperstatus17switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus17SwitchIndicator2));
            }
        }
        public string IfOperStatus18SwitchIndicator2
        {
            get { return _ifoperstatus18switchindicator2; }
            set
            {
                _ifoperstatus18switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus18SwitchIndicator2));
            }
        }
        public string IfOperStatus19SwitchIndicator2
        {
            get { return _ifoperstatus19switchindicator2; }
            set
            {
                _ifoperstatus19switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus19SwitchIndicator2));
            }
        }
        public string IfOperStatus20SwitchIndicator2
        {
            get { return _ifoperstatus20switchindicator2; }
            set
            {
                _ifoperstatus20switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus20SwitchIndicator2));
            }
        }
        public string IfOperStatus21SwitchIndicator2
        {
            get { return _ifoperstatus21switchindicator2; }
            set
            {
                _ifoperstatus21switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus21SwitchIndicator2));
            }
        }
        public string IfOperStatus22SwitchIndicator2
        {
            get { return _ifoperstatus22switchindicator2; }
            set
            {
                _ifoperstatus22switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus22SwitchIndicator2));
            }
        }
        public string IfOperStatus23SwitchIndicator2
        {
            get { return _ifoperstatus23switchindicator2; }
            set
            {
                _ifoperstatus23switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus23SwitchIndicator2));
            }
        }
        public string IfOperStatus24SwitchIndicator2
        {
            get { return _ifoperstatus24switchindicator2; }
            set
            {
                _ifoperstatus24switchindicator2 = value;
                OnPropertyChanged(nameof(IfOperStatus24SwitchIndicator2));
            }
        }

        public string IfOperStatus1SwitchTimestamp2
        {
            get { return _ifoperstatus1switchtimestamp2; }
            set
            {
                _ifoperstatus1switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus1SwitchTimestamp2));
            }
        }
        public string IfOperStatus2SwitchTimestamp2
        {
            get { return _ifoperstatus2switchtimestamp2; }
            set
            {
                _ifoperstatus2switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus2SwitchTimestamp2));
            }
        }
        public string IfOperStatus3SwitchTimestamp2
        {
            get { return _ifoperstatus3switchtimestamp2; }
            set
            {
                _ifoperstatus3switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus3SwitchTimestamp2));
            }
        }
        public string IfOperStatus4SwitchTimestamp2
        {
            get { return _ifoperstatus4switchtimestamp2; }
            set
            {
                _ifoperstatus4switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus4SwitchTimestamp2));
            }
        }
        public string IfOperStatus5SwitchTimestamp2
        {
            get { return _ifoperstatus5switchtimestamp2; }
            set
            {
                _ifoperstatus5switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus5SwitchTimestamp2));
            }
        }
        public string IfOperStatus6SwitchTimestamp2
        {
            get { return _ifoperstatus6switchtimestamp2; }
            set
            {
                _ifoperstatus6switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus6SwitchTimestamp2));
            }
        }
        public string IfOperStatus7SwitchTimestamp2
        {
            get { return _ifoperstatus7switchtimestamp2; }
            set
            {
                _ifoperstatus7switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus7SwitchTimestamp2));
            }
        }
        public string IfOperStatus8SwitchTimestamp2
        {
            get { return _ifoperstatus8switchtimestamp2; }
            set
            {
                _ifoperstatus8switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus8SwitchTimestamp2));
            }
        }
        public string IfOperStatus9SwitchTimestamp2
        {
            get { return _ifoperstatus9switchtimestamp2; }
            set
            {
                _ifoperstatus9switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus9SwitchTimestamp2));
            }
        }
        public string IfOperStatus10SwitchTimestamp2
        {
            get { return _ifoperstatus10switchtimestamp2; }
            set
            {
                _ifoperstatus10switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus10SwitchTimestamp2));
            }
        }
        public string IfOperStatus11SwitchTimestamp2
        {
            get { return _ifoperstatus11switchtimestamp2; }
            set
            {
                _ifoperstatus11switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus11SwitchTimestamp2));
            }
        }
        public string IfOperStatus12SwitchTimestamp2
        {
            get { return _ifoperstatus12switchtimestamp2; }
            set
            {
                _ifoperstatus12switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus12SwitchTimestamp2));
            }
        }
        public string IfOperStatus13SwitchTimestamp2
        {
            get { return _ifoperstatus13switchtimestamp2; }
            set
            {
                _ifoperstatus13switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus13SwitchTimestamp2));
            }
        }
        public string IfOperStatus14SwitchTimestamp2
        {
            get { return _ifoperstatus14switchtimestamp2; }
            set
            {
                _ifoperstatus14switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus14SwitchTimestamp2));
            }
        }
        public string IfOperStatus15SwitchTimestamp2
        {
            get { return _ifoperstatus15switchtimestamp2; }
            set
            {
                _ifoperstatus15switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus15SwitchTimestamp2));
            }
        }
        public string IfOperStatus16SwitchTimestamp2
        {
            get { return _ifoperstatus16switchtimestamp2; }
            set
            {
                _ifoperstatus16switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus16SwitchTimestamp2));
            }
        }
        public string IfOperStatus17SwitchTimestamp2
        {
            get { return _ifoperstatus17switchtimestamp2; }
            set
            {
                _ifoperstatus17switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus17SwitchTimestamp2));
            }
        }
        public string IfOperStatus18SwitchTimestamp2
        {
            get { return _ifoperstatus18switchtimestamp2; }
            set
            {
                _ifoperstatus18switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus18SwitchTimestamp2));
            }
        }
        public string IfOperStatus19SwitchTimestamp2
        {
            get { return _ifoperstatus19switchtimestamp2; }
            set
            {
                _ifoperstatus19switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus19SwitchTimestamp2));
            }
        }
        public string IfOperStatus20SwitchTimestamp2
        {
            get { return _ifoperstatus20switchtimestamp2; }
            set
            {
                _ifoperstatus20switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus20SwitchTimestamp2));
            }
        }
        public string IfOperStatus21SwitchTimestamp2
        {
            get { return _ifoperstatus21switchtimestamp2; }
            set
            {
                _ifoperstatus21switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus21SwitchTimestamp2));
            }
        }
        public string IfOperStatus22SwitchTimestamp2
        {
            get { return _ifoperstatus22switchtimestamp2; }
            set
            {
                _ifoperstatus22switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus22SwitchTimestamp2));
            }
        }
        public string IfOperStatus23SwitchTimestamp2
        {
            get { return _ifoperstatus23switchtimestamp2; }
            set
            {
                _ifoperstatus23switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus23SwitchTimestamp2));
            }
        }
        public string IfOperStatus24SwitchTimestamp2
        {
            get { return _ifoperstatus24switchtimestamp2; }
            set
            {
                _ifoperstatus24switchtimestamp2 = value;
                OnPropertyChanged(nameof(IfOperStatus24SwitchTimestamp2));
            }
        }
        #endregion

        #region Switch Parameters Status        

        public string GeSwitch101Status
        {
            get { return _geSwitch101Status; }
            set
            {
                _geSwitch101Status = value;
                OnPropertyChanged(nameof(GeSwitch101Status));
            }
        }
        public string GeSwitch102Status
        {
            get { return _geSwitch102Status; }
            set
            {
                _geSwitch102Status = value;
                OnPropertyChanged(nameof(GeSwitch102Status));
            }
        }
        public string GeSwitch103Status
        {
            get { return _geSwitch103Status; }
            set
            {
                _geSwitch103Status = value;
                OnPropertyChanged(nameof(GeSwitch103Status));
            }
        }
        public string GeSwitch104Status
        {
            get { return _geSwitch104Status; }
            set
            {
                _geSwitch104Status = value;
                OnPropertyChanged(nameof(GeSwitch104Status));
            }
        }

        public string GeSwitch105Status
        {
            get { return _geSwitch105Status; }
            set
            {
                _geSwitch105Status = value;
                OnPropertyChanged(nameof(GeSwitch105Status));
            }
        }

        public string GeSwitch106Status
        {
            get { return _geSwitch106Status; }
            set
            {
                _geSwitch106Status = value;
                OnPropertyChanged(nameof(GeSwitch106Status));
            }
        }
        public string GeSwitch107Status
        {
            get { return _geSwitch107Status; }
            set
            {
                _geSwitch107Status = value;
                OnPropertyChanged(nameof(GeSwitch107Status));
            }
        }

        public string GeSwitch108Status
        {
            get { return _geSwitch108Status; }
            set
            {
                _geSwitch108Status = value;
                OnPropertyChanged(nameof(GeSwitch108Status));
            }
        }

        public string GeSwitch109Status
        {
            get { return _geSwitch109Status; }
            set
            {
                _geSwitch109Status = value;
                OnPropertyChanged(nameof(GeSwitch109Status));
            }
        }

        public string GeSwitch1010Status
        {
            get { return _geSwitch1010Status; }
            set
            {
                _geSwitch1010Status = value;
                OnPropertyChanged(nameof(GeSwitch1010Status));
            }
        }

        public string GeSwitch1011Status
        {
            get { return _geSwitch1011Status; }
            set
            {
                _geSwitch1011Status = value;
                OnPropertyChanged(nameof(GeSwitch1011Status));
            }
        }

        public string GeSwitch1012Status
        {
            get { return _geSwitch1012Status; }
            set
            {
                _geSwitch1012Status = value;
                OnPropertyChanged(nameof(GeSwitch1012Status));
            }
        }


        public string GeSwitch1013Status
        {
            get { return _geSwitch1013Status; }
            set
            {
                _geSwitch1013Status = value;
                OnPropertyChanged(nameof(GeSwitch1013Status));
            }
        }


        public string GeSwitch1014Status
        {
            get { return _geSwitch1014Status; }
            set
            {
                _geSwitch1014Status = value;
                OnPropertyChanged(nameof(GeSwitch1014Status));
            }
        }

        public string GeSwitch1015Status
        {
            get { return _geSwitch1015Status; }
            set
            {
                _geSwitch1015Status = value;
                OnPropertyChanged(nameof(GeSwitch1015Status));
            }
        }

        public string GeSwitch1016Status
        {
            get { return _geSwitch1016Status; }
            set
            {
                _geSwitch1016Status = value;
                OnPropertyChanged(nameof(GeSwitch1016Status));
            }
        }

        public string GeSwitch1017Status
        {
            get { return _geSwitch1017Status; }
            set
            {
                _geSwitch1017Status = value;
                OnPropertyChanged(nameof(GeSwitch1017Status));
            }
        }
        public string GeSwitch1018Status
        {
            get { return _geSwitch1018Status; }
            set
            {
                _geSwitch1018Status = value;
                OnPropertyChanged(nameof(GeSwitch1018Status));
            }
        }
        public string GeSwitch1019Status
        {
            get { return _geSwitch1019Status; }
            set
            {
                _geSwitch1019Status = value;
                OnPropertyChanged(nameof(GeSwitch1019Status));
            }
        }
        public string GeSwitch1020Status
        {
            get { return _geSwitch1020Status; }
            set
            {
                _geSwitch1020Status = value;
                OnPropertyChanged(nameof(GeSwitch1020Status));
            }
        }
        public string GeSwitch1021Status
        {
            get { return _geSwitch1021Status; }
            set
            {
                _geSwitch1021Status = value;
                OnPropertyChanged(nameof(GeSwitch1021Status));
            }
        }
        public string GeSwitch1022Status
        {
            get { return _geSwitch1022Status; }
            set
            {
                _geSwitch1022Status = value;
                OnPropertyChanged(nameof(GeSwitch1022Status));
            }
        }
        public string GeSwitch1023Status
        {
            get { return _geSwitch1023Status; }
            set
            {
                _geSwitch1023Status = value;
                OnPropertyChanged(nameof(GeSwitch1023Status));
            }
        }

        public string GeSwitch1024Status
        {
            get { return _geSwitch1024Status; }
            set
            {
                _geSwitch1024Status = value;
                OnPropertyChanged(nameof(GeSwitch1024Status));
            }
        }


        //switch Indicator 
        public string GeSwitch101StatusIndicator
        {
            get { return _geSwitch101Statusindicator; }
            set
            {
                _geSwitch101Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch101StatusIndicator));
            }
        }


        public string GeSwitch102StatusIndicator
        {
            get { return _geSwitch102Statusindicator; }
            set
            {
                _geSwitch102Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch102StatusIndicator));
            }
        }
        public string GeSwitch103StatusIndicator
        {
            get { return _geSwitch103Statusindicator; }
            set
            {
                _geSwitch103Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch103StatusIndicator));
            }
        }
        public string GeSwitch104StatusIndicator
        {
            get { return _geSwitch104Statusindicator; }
            set
            {
                _geSwitch104Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch104StatusIndicator));
            }
        }
        public string GeSwitch105StatusIndicator
        {
            get { return _geSwitch105Statusindicator; }
            set
            {
                _geSwitch105Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch105StatusIndicator));
            }
        }
        public string GeSwitch106StatusIndicator
        {
            get { return _geSwitch106Statusindicator; }
            set
            {
                _geSwitch106Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch106StatusIndicator));
            }
        }

        public string GeSwitch107StatusIndicator
        {
            get { return _geSwitch107Statusindicator; }
            set
            {
                _geSwitch107Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch107StatusIndicator));
            }
        }
        public string GeSwitch108StatusIndicator
        {
            get { return _geSwitch108Statusindicator; }
            set
            {
                _geSwitch108Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch108StatusIndicator));
            }
        }
        public string GeSwitch109StatusIndicator
        {
            get { return _geSwitch109Statusindicator; }
            set
            {
                _geSwitch109Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch109StatusIndicator));
            }
        }
        public string GeSwitch1010StatusIndicator
        {
            get { return _geSwitch1010Statusindicator; }
            set
            {
                _geSwitch1010Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1010StatusIndicator));
            }
        }
        public string GeSwitch1011StatusIndicator
        {
            get { return _geSwitch1011Statusindicator; }
            set
            {
                _geSwitch1011Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1011StatusIndicator));
            }
        }
        public string GeSwitch1012StatusIndicator
        {
            get { return _geSwitch1012Statusindicator; }
            set
            {
                _geSwitch1012Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1012StatusIndicator));
            }
        }
        public string GeSwitch1013StatusIndicator
        {
            get { return _geSwitch1013Statusindicator; }
            set
            {
                _geSwitch1013Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1013StatusIndicator));
            }
        }
        public string GeSwitch1014StatusIndicator
        {
            get { return _geSwitch1014Statusindicator; }
            set
            {
                _geSwitch1014Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1014StatusIndicator));
            }
        }
        public string GeSwitch1015StatusIndicator
        {
            get { return _geSwitch1015Statusindicator; }
            set
            {
                _geSwitch1015Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1015StatusIndicator));
            }
        }
        public string GeSwitch1016StatusIndicator
        {
            get { return _geSwitch1016Statusindicator; }
            set
            {
                _geSwitch1016Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1016StatusIndicator));
            }
        }
        public string GeSwitch1017StatusIndicator
        {
            get { return _geSwitch1017Statusindicator; }
            set
            {
                _geSwitch1017Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1017StatusIndicator));
            }
        }
        public string GeSwitch1018StatusIndicator
        {
            get { return _geSwitch1018Statusindicator; }
            set
            {
                _geSwitch1018Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1018StatusIndicator));
            }
        }
        public string GeSwitch1019StatusIndicator
        {
            get { return _geSwitch1019Statusindicator; }
            set
            {
                _geSwitch1019Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1019StatusIndicator));
            }
        }
        public string GeSwitch1020StatusIndicator
        {
            get { return _geSwitch1020Statusindicator; }
            set
            {
                _geSwitch1020Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1020StatusIndicator));
            }
        }
        public string GeSwitch1021StatusIndicator
        {
            get { return _geSwitch1021Statusindicator; }
            set
            {
                _geSwitch1021Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1021StatusIndicator));
            }
        }
         public string GeSwitch1022StatusIndicator
        {
            get { return _geSwitch1022Statusindicator; }
            set
            {
                _geSwitch1022Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1022StatusIndicator));
            }
        }
         public string GeSwitch1023StatusIndicator
        {
            get { return _geSwitch1023Statusindicator; }
            set
            {
                _geSwitch1023Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1023StatusIndicator));
            }
        }
        public string GeSwitch1024StatusIndicator
        {
            get { return _geSwitch1024Statusindicator; }
            set
            {
                _geSwitch1024Statusindicator = value;
                OnPropertyChanged(nameof(GeSwitch1024StatusIndicator));
            }
        }

        #endregion

        #region Giga2
        public string GeSwitch101Status2
        {
            get { return _geSwitch101Status2; }
            set
            {
                _geSwitch101Status2 = value;
                OnPropertyChanged(nameof(GeSwitch101Status2));
            }
        }
        public string GeSwitch102Status2
        {
            get { return _geSwitch102Status2; }
            set
            {
                _geSwitch102Status2 = value;
                OnPropertyChanged(nameof(GeSwitch102Status2));
            }
        }
        public string GeSwitch103Status2
        {
            get { return _geSwitch103Status2; }
            set
            {
                _geSwitch103Status2 = value;
                OnPropertyChanged(nameof(GeSwitch103Status2));
            }
        }
        public string GeSwitch104Status2
        {
            get { return _geSwitch104Status2; }
            set
            {
                _geSwitch104Status2 = value;
                OnPropertyChanged(nameof(GeSwitch104Status2));
            }
        }

        public string GeSwitch105Status2
        {
            get { return _geSwitch105Status2; }
            set
            {
                _geSwitch105Status2 = value;
                OnPropertyChanged(nameof(GeSwitch105Status2));
            }
        }

        public string GeSwitch106Status2
        {
            get { return _geSwitch106Status2; }
            set
            {
                _geSwitch106Status2 = value;
                OnPropertyChanged(nameof(GeSwitch106Status2));
            }
        }
        public string GeSwitch107Status2
        {
            get { return _geSwitch107Status2; }
            set
            {
                _geSwitch107Status2 = value;
                OnPropertyChanged(nameof(GeSwitch107Status2));
            }
        }

        public string GeSwitch108Status2
        {
            get { return _geSwitch108Status2; }
            set
            {
                _geSwitch108Status2 = value;
                OnPropertyChanged(nameof(GeSwitch108Status2));
            }
        }

        public string GeSwitch109Status2
        {
            get { return _geSwitch109Status2; }
            set
            {
                _geSwitch109Status2 = value;
                OnPropertyChanged(nameof(GeSwitch109Status2));
            }
        }

        public string GeSwitch1010Status2
        {
            get { return _geSwitch1010Status2; }
            set
            {
                _geSwitch1010Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1010Status2));
            }
        }

        public string GeSwitch1011Status2
        {
            get { return _geSwitch1011Status2; }
            set
            {
                _geSwitch1011Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1011Status2));
            }
        }

        public string GeSwitch1012Status2
        {
            get { return _geSwitch1012Status2; }
            set
            {
                _geSwitch1012Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1012Status2));
            }
        }


        public string GeSwitch1013Status2
        {
            get { return _geSwitch1013Status2; }
            set
            {
                _geSwitch1013Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1013Status2));
            }
        }


        public string GeSwitch1014Status2
        {
            get { return _geSwitch1014Status2; }
            set
            {
                _geSwitch1014Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1014Status2));
            }
        }

        public string GeSwitch1015Status2
        {
            get { return _geSwitch1015Status2; }
            set
            {
                _geSwitch1015Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1015Status2));
            }
        }

        public string GeSwitch1016Status2
        {
            get { return _geSwitch1016Status2; }
            set
            {
                _geSwitch1016Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1016Status2));
            }
        }

        public string GeSwitch1017Status2
        {
            get { return _geSwitch1017Status2; }
            set
            {
                _geSwitch1017Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1017Status2));
            }
        }
        public string GeSwitch1018Status2
        {
            get { return _geSwitch1018Status2; }
            set
            {
                _geSwitch1018Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1018Status2));
            }
        }
        public string GeSwitch1019Status2
        {
            get { return _geSwitch1019Status2; }
            set
            {
                _geSwitch1019Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1019Status2));
            }
        }
        public string GeSwitch1020Status2
        {
            get { return _geSwitch1020Status2; }
            set
            {
                _geSwitch1020Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1020Status2));
            }
        }
        public string GeSwitch1021Status2
        {
            get { return _geSwitch1021Status2; }
            set
            {
                _geSwitch1021Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1021Status2));
            }
        }
        public string GeSwitch1022Status2
        {
            get { return _geSwitch1022Status2; }
            set
            {
                _geSwitch1022Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1022Status2));
            }
        }
        public string GeSwitch1023Status2
        {
            get { return _geSwitch1023Status2; }
            set
            {
                _geSwitch1023Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1023Status2));
            }
        }

        public string GeSwitch1024Status2
        {
            get { return _geSwitch1024Status2; }
            set
            {
                _geSwitch1024Status2 = value;
                OnPropertyChanged(nameof(GeSwitch1024Status2));
            }
        }


        //switch Indicator 
        public string GeSwitch101StatusIndicator2
        {
            get { return _geSwitch101Statusindicator2; }
            set
            {
                _geSwitch101Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch101StatusIndicator2));
            }
        }


        public string GeSwitch102StatusIndicator2
        {
            get { return _geSwitch102Statusindicator2; }
            set
            {
                _geSwitch102Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch102StatusIndicator2));
            }
        }
        public string GeSwitch103StatusIndicator2
        {
            get { return _geSwitch103Statusindicator2; }
            set
            {
                _geSwitch103Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch103StatusIndicator2));
            }
        }
        public string GeSwitch104StatusIndicator2
        {
            get { return _geSwitch104Statusindicator2; }
            set
            {
                _geSwitch104Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch104StatusIndicator2));
            }
        }
        public string GeSwitch105StatusIndicator2
        {
            get { return _geSwitch105Statusindicator2; }
            set
            {
                _geSwitch105Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch105StatusIndicator2));
            }
        }
        public string GeSwitch106StatusIndicator2
        {
            get { return _geSwitch106Statusindicator2; }
            set
            {
                _geSwitch106Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch106StatusIndicator2));
            }
        }

        public string GeSwitch107StatusIndicator2
        {
            get { return _geSwitch107Statusindicator2; }
            set
            {
                _geSwitch107Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch107StatusIndicator2));
            }
        }
        public string GeSwitch108StatusIndicator2
        {
            get { return _geSwitch108Statusindicator2; }
            set
            {
                _geSwitch108Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch108StatusIndicator2));
            }
        }
        public string GeSwitch109StatusIndicator2
        {
            get { return _geSwitch109Statusindicator2; }
            set
            {
                _geSwitch109Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch109StatusIndicator2));
            }
        }
        public string GeSwitch1010StatusIndicator2
        {
            get { return _geSwitch1010Statusindicator2; }
            set
            {
                _geSwitch1010Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1010StatusIndicator2));
            }
        }
        public string GeSwitch1011StatusIndicator2
        {
            get { return _geSwitch1011Statusindicator2; }
            set
            {
                _geSwitch1011Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1011StatusIndicator2));
            }
        }
        public string GeSwitch1012StatusIndicator2
        {
            get { return _geSwitch1012Statusindicator2; }
            set
            {
                _geSwitch1012Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1012StatusIndicator2));
            }
        }
        public string GeSwitch1013StatusIndicator2
        {
            get { return _geSwitch1013Statusindicator2; }
            set
            {
                _geSwitch1013Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1013StatusIndicator2));
            }
        }
        public string GeSwitch1014StatusIndicator2
        {
            get { return _geSwitch1014Statusindicator2; }
            set
            {
                _geSwitch1014Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1014StatusIndicator2));
            }
        }
        public string GeSwitch1015StatusIndicator2
        {
            get { return _geSwitch1015Statusindicator2; }
            set
            {
                _geSwitch1015Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1015StatusIndicator2));
            }
        }
        public string GeSwitch1016StatusIndicator2
        {
            get { return _geSwitch1016Statusindicator2; }
            set
            {
                _geSwitch1016Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1016StatusIndicator2));
            }
        }
        public string GeSwitch1017StatusIndicator2
        {
            get { return _geSwitch1017Statusindicator2; }
            set
            {
                _geSwitch1017Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1017StatusIndicator2));
            }
        }
        public string GeSwitch1018StatusIndicator2
        {
            get { return _geSwitch1018Statusindicator2; }
            set
            {
                _geSwitch1018Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1018StatusIndicator2));
            }
        }
        public string GeSwitch1019StatusIndicator2
        {
            get { return _geSwitch1019Statusindicator2; }
            set
            {
                _geSwitch1019Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1019StatusIndicator2));
            }
        }
        public string GeSwitch1020StatusIndicator2
        {
            get { return _geSwitch1020Statusindicator2; }
            set
            {
                _geSwitch1020Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1020StatusIndicator2));
            }
        }
        public string GeSwitch1021StatusIndicator2
        {
            get { return _geSwitch1021Statusindicator2; }
            set
            {
                _geSwitch1021Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1021StatusIndicator2));
            }
        }
        public string GeSwitch1022StatusIndicator2
        {
            get { return _geSwitch1022Statusindicator2; }
            set
            {
                _geSwitch1022Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1022StatusIndicator2));
            }
        }
        public string GeSwitch1023StatusIndicator2
        {
            get { return _geSwitch1023Statusindicator2; }
            set
            {
                _geSwitch1023Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1023StatusIndicator2));
            }
        }
        public string GeSwitch1024StatusIndicator2
        {
            get { return _geSwitch1024Statusindicator2; }
            set
            {
                _geSwitch1024Statusindicator2 = value;
                OnPropertyChanged(nameof(GeSwitch1024StatusIndicator2));
            }
        }
        #endregion
        public string ciscoEnvMonTemperatureStatusDescr
        {
            get { return _ciscoenvmontemperaturestatusdescr; }
            set
            {
                _ciscoenvmontemperaturestatusdescr = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureStatusDescr));
            }
        }
        public string ciscoEnvMonTemperatureStatusValue
        {
            get { return _ciscoenvmontemperaturestatusvalue; }
            set
            {
                _ciscoenvmontemperaturestatusvalue = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureStatusValue));
            }
        }
        public string ciscoEnvMonTemperatureThreshold
        {
            get { return _ciscoenvmontemperaturethreshold; }
            set
            {
                _ciscoenvmontemperaturethreshold = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureThreshold));
            }
        }
        public string ciscoEnvMonTemperatureLastShutdown
        {
            get { return _ciscoenvmontemperaturelastshutdown; }
            set
            {
                _ciscoenvmontemperaturelastshutdown = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureLastShutdown));
            }
        }

        public string ciscoEnvMonTemperatureState
        {
            get { return _ciscoenvmontemperaturestate; }
            set
            {
                _ciscoenvmontemperaturestate = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureState));
            }
        }
        public string ciscoEnvMonTemperatureStatusValueRev1
        {
            get { return _ciscoenvmontemperaturestatusvaluerev1; }
            set
            {
                _ciscoenvmontemperaturestatusvaluerev1 = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureStatusValueRev1));
            }
        }
        public string EnvironmentTimestamp0
        {
            get { return _environmenttimestamp0; }
            set
            {
                _environmenttimestamp0 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp0));
            }
        }
        public string EnvironmentTimestamp1
        {
            get { return _environmenttimestamp1; }
            set
            {
                _environmenttimestamp1 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp1));
            }
        }
        public string EnvironmentTimestamp2
        {
            get { return _environmenttimestamp2; }
            set
            {
                _environmenttimestamp2 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp2));
            }
        }
        public string EnvironmentTimestamp3
        {
            get { return _environmenttimestamp3; }
            set
            {
                _environmenttimestamp3 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp3));
            }
        }
        public string EnvironmentTimestamp4
        {
            get { return _environmenttimestamp4; }
            set
            {
                _environmenttimestamp4 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp4));
            }
        }
        public string EnvironmentTimestamp5
        {
            get { return _environmenttimestamp5; }
            set
            {
                _environmenttimestamp5 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp5));
            }
        }
        #region Environment param2
        public string ciscoEnvMonTemperatureStatusDescr2
        {
            get { return _ciscoenvmontemperaturestatusdescr2; }
            set
            {
                _ciscoenvmontemperaturestatusdescr2 = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureStatusDescr2));
            }
        }
        public string ciscoEnvMonTemperatureStatusValue2
        {
            get { return _ciscoenvmontemperaturestatusvalue2; }
            set
            {
                _ciscoenvmontemperaturestatusvalue2 = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureStatusValue2));
            }
        }
        public string ciscoEnvMonTemperatureThreshold2
        {
            get { return _ciscoenvmontemperaturethreshold2; }
            set
            {
                _ciscoenvmontemperaturethreshold2 = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureThreshold2));
            }
        }
        public string ciscoEnvMonTemperatureLastShutdown2
        {
            get { return _ciscoenvmontemperaturelastshutdown2; }
            set
            {
                _ciscoenvmontemperaturelastshutdown2 = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureLastShutdown2));
            }
        }

        public string ciscoEnvMonTemperatureState2
        {
            get { return _ciscoenvmontemperaturestate2; }
            set
            {
                _ciscoenvmontemperaturestate2 = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureState2));
            }
        }
        public string ciscoEnvMonTemperatureStatusValueRev1_2
        {
            get { return _ciscoenvmontemperaturestatusvaluerev1_2; }
            set
            {
                _ciscoenvmontemperaturestatusvaluerev1_2 = value;
                OnPropertyChanged(nameof(ciscoEnvMonTemperatureStatusValueRev1_2));
            }
        }
        public string EnvironmentTimestamp0_2
        {
            get { return _environmenttimestamp0_2; }
            set
            {
                _environmenttimestamp0_2 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp0_2));
            }
        }
        public string EnvironmentTimestamp1_2
        {
            get { return _environmenttimestamp1_2; }
            set
            {
                _environmenttimestamp1_2 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp1_2));
            }
        }
        public string EnvironmentTimestamp2_2
        {
            get { return _environmenttimestamp2_2; }
            set
            {
                _environmenttimestamp2_2 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp2_2));
            }
        }
        public string EnvironmentTimestamp3_2
        {
            get { return _environmenttimestamp3_2; }
            set
            {
                _environmenttimestamp3_2 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp3_2));
            }
        }
        public string EnvironmentTimestamp4_2
        {
            get { return _environmenttimestamp4_2; }
            set
            {
                _environmenttimestamp4_2 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp4_2));
            }
        }
        public string EnvironmentTimestamp5_2
        {
            get { return _environmenttimestamp5_2; }
            set
            {
                _environmenttimestamp5_2 = value;
                OnPropertyChanged(nameof(EnvironmentTimestamp5_2));
            }
        }
        #endregion
    }
}
