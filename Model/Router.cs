using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCPReportingSystem.ViewModel;

namespace LCPReportingSystem.Model
{
    public partial class DashBoard : ViewModelBase
    {
        #region Information Current Status

        string _ge000status = string.Empty;
        string _ge001status = string.Empty;
        string _ge002status = string.Empty;
        string _ge020status = string.Empty;
        string _ge100status = string.Empty;
        string _ge101status = string.Empty;
        string _ge102status = string.Empty;
        string _ge103status = string.Empty;
        string _ge104status = string.Empty;
        string _ge105status = string.Empty;

        string _ge000indicator = string.Empty;
        string _ge001indicator = string.Empty;
        string _ge002indicator = string.Empty;
        string _ge020indicator = string.Empty;
        string _ge100indicator = string.Empty;
        string _ge101indicator = string.Empty;
        string _ge102indicator = string.Empty;
        string _ge103indicator = string.Empty;
        string _ge104indicator = string.Empty;
        string _ge105indicator = string.Empty;

        #endregion

        #region Routers Adminstatus
        string _ifadminstatus1 = string.Empty;
        string _ifadminstatus2 = string.Empty;
        string _ifadminstatus3 = string.Empty;
        string _ifadminstatus4 = string.Empty;
        string _ifadminstatus5 = string.Empty;
        string _ifadminstatus6 = string.Empty;
        string _ifadminstatus7 = string.Empty;
        string _ifadminstatus8 = string.Empty;
        string _ifadminstatus9 = string.Empty;
        string _ifadminstatus10 = string.Empty;

        string _ifadminstatus1indicator = string.Empty;
        string _ifadminstatus2indicator = string.Empty;
        string _ifadminstatus3indicator = string.Empty;
        string _ifadminstatus4indicator = string.Empty;
        string _ifadminstatus5indicator = string.Empty;
        string _ifadminstatus6indicator = string.Empty;
        string _ifadminstatus7indicator = string.Empty;
        string _ifadminstatus8indicator = string.Empty;
        string _ifadminstatus9indicator = string.Empty;
        string _ifadminstatus10indicator = string.Empty;

        string _ifadminstatus1timestamp = string.Empty;
        string _ifadminstatus2timestamp = string.Empty;
        string _ifadminstatus3timestamp = string.Empty;
        string _ifadminstatus4timestamp = string.Empty;
        string _ifadminstatus5timestamp = string.Empty;
        string _ifadminstatus6timestamp = string.Empty;
        string _ifadminstatus7timestamp = string.Empty;
        string _ifadminstatus8timestamp = string.Empty;
        string _ifadminstatus9timestamp = string.Empty;
        string _ifadminstatus10timestamp = string.Empty;
        #endregion

        #region Routers OperStatus

        string _ifoperstatus1 = string.Empty;
        string _ifoperstatus2 = string.Empty;
        string _ifoperstatus3 = string.Empty;
        string _ifoperstatus4 = string.Empty;
        string _ifoperstatus5 = string.Empty;
        string _ifoperstatus6 = string.Empty;
        string _ifoperstatus7 = string.Empty;
        string _ifoperstatus8 = string.Empty;
        string _ifoperstatus9 = string.Empty;
        string _ifoperstatus10 = string.Empty;

        string _ifoperstatus1indicator = string.Empty;
        string _ifoperstatus2indicator = string.Empty;
        string _ifoperstatus3indicator = string.Empty;
        string _ifoperstatus4indicator = string.Empty;
        string _ifoperstatus5indicator = string.Empty;
        string _ifoperstatus6indicator = string.Empty;
        string _ifoperstatus7indicator = string.Empty;
        string _ifoperstatus8indicator = string.Empty;
        string _ifoperstatus9indicator = string.Empty;
        string _ifoperstatus10indicator = string.Empty;

        string _ifoperstatus1timestamp = string.Empty;
        string _ifoperstatus2timestamp = string.Empty;
        string _ifoperstatus3timestamp = string.Empty;
        string _ifoperstatus4timestamp = string.Empty;
        string _ifoperstatus5timestamp = string.Empty;
        string _ifoperstatus6timestamp = string.Empty;
        string _ifoperstatus7timestamp = string.Empty;
        string _ifoperstatus8timestamp = string.Empty;
        string _ifoperstatus9timestamp = string.Empty;
        string _ifoperstatus10timestamp = string.Empty;

        #endregion

        #region Information Current Property

        public string Ge000Status
        {
            get { return _ge000status; }
            set
            {
                _ge000status = value;
                OnPropertyChanged(nameof(Ge000Status));
            }
        }
        public string Ge001Status
        {
            get { return _ge001status; }
            set
            {
                _ge001status = value;
                OnPropertyChanged(nameof(Ge001Status));
            }
        }
        public string Ge002Status
        {
            get { return _ge002status; }
            set
            {
                _ge002status = value;
                OnPropertyChanged(nameof(Ge002Status));
            }
        }
        public string Ge020Status
        {
            get { return _ge020status; }
            set
            {
                _ge020status = value;
                OnPropertyChanged(nameof(Ge020Status));
            }
        }
        public string Ge100Status
        {
            get { return _ge100status; }
            set
            {
                _ge100status = value;
                OnPropertyChanged(nameof(Ge100Status));
            }
        }
        public string Ge101Status
        {
            get { return _ge101status; }
            set
            {
                _ge101status = value;
                OnPropertyChanged(nameof(Ge101Status));
            }
        }
        public string Ge102Status
        {
            get { return _ge102status; }
            set
            {
                _ge102status = value;
                OnPropertyChanged(nameof(Ge102Status));
            }
        }
        public string Ge103Status
        {
            get { return _ge103status; }
            set
            {
                _ge103status = value;
                OnPropertyChanged(nameof(Ge103Status));
            }
        }
        public string Ge104Status
        {
            get { return _ge104status; }
            set
            {
                _ge104status = value;
                OnPropertyChanged(nameof(Ge104Status));
            }
        }
        public string Ge105Status
        {
            get { return _ge105status; }
            set
            {
                _ge105status = value;
                OnPropertyChanged(nameof(Ge105Status));
            }
        }
        public string Ge000Indicator
        {
            get { return _ge000indicator; }
            set
            {
                _ge000indicator = value;
                OnPropertyChanged(nameof(Ge000Indicator));
            }
        }
        public string Ge001Indicator
        {
            get { return _ge001indicator; }
            set
            {
                _ge001indicator = value;
                OnPropertyChanged(nameof(Ge001Indicator));
            }
        }
        public string Ge002Indicator
        {
            get { return _ge002indicator; }
            set
            {
                _ge002indicator = value;
                OnPropertyChanged(nameof(Ge002Indicator));
            }
        }
        public string Ge020Indicator
        {
            get { return _ge020indicator; }
            set
            {
                _ge020indicator = value;
                OnPropertyChanged(nameof(Ge020Indicator));
            }
        }
        public string Ge100Indicator
        {
            get { return _ge100indicator; }
            set
            {
                _ge100indicator = value;
                OnPropertyChanged(nameof(Ge100Indicator));
            }
        }
        public string Ge101Indicator
        {
            get { return _ge101indicator; }
            set
            {
                _ge101indicator = value;
                OnPropertyChanged(nameof(Ge101Indicator));
            }
        }
        public string Ge102Indicator
        {
            get { return _ge102indicator; }
            set
            {
                _ge102indicator = value;
                OnPropertyChanged(nameof(Ge102Indicator));
            }
        }
        public string Ge103Indicator
        {
            get { return _ge103indicator; }
            set
            {
                _ge103indicator = value;
                OnPropertyChanged(nameof(Ge103Indicator));
            }
        }
        public string Ge104Indicator
        {
            get { return _ge104indicator; }
            set
            {
                _ge104indicator = value;
                OnPropertyChanged(nameof(Ge104Indicator));
            }
        }
        public string Ge105Indicator
        {
            get { return _ge105indicator; }
            set
            {
                _ge105indicator = value;
                OnPropertyChanged(nameof(Ge105Indicator));
            }
        }
        #endregion

        #region Routers Adminstatus Property

        public string IfAdminStatus1
        {
            get { return _ifadminstatus1; }
            set
            {
                _ifadminstatus1 = value;
                OnPropertyChanged(nameof(IfAdminStatus1));
            }
        }
        public string IfAdminStatus2
        {
            get { return _ifadminstatus2; }
            set
            {
                _ifadminstatus2 = value;
                OnPropertyChanged(nameof(IfAdminStatus2));
            }
        }
        public string IfAdminStatus3
        {
            get { return _ifadminstatus3; }
            set
            {
                _ifadminstatus3 = value;
                OnPropertyChanged(nameof(IfAdminStatus3));
            }
        }
        public string IfAdminStatus4
        {
            get { return _ifadminstatus4; }
            set
            {
                _ifadminstatus4 = value;
                OnPropertyChanged(nameof(IfAdminStatus4));
            }
        }
        public string IfAdminStatus5
        {
            get { return _ifadminstatus5; }
            set
            {
                _ifadminstatus5 = value;
                OnPropertyChanged(nameof(IfAdminStatus5));
            }
        }
        public string IfAdminStatus6
        {
            get { return _ifadminstatus6; }
            set
            {
                _ifadminstatus6 = value;
                OnPropertyChanged(nameof(IfAdminStatus6));
            }
        }
        public string IfAdminStatus7
        {
            get { return _ifadminstatus7; }
            set
            {
                _ifadminstatus7 = value;
                OnPropertyChanged(nameof(IfAdminStatus7));
            }
        }
        public string IfAdminStatus8
        {
            get { return _ifadminstatus8; }
            set
            {
                _ifadminstatus8 = value;
                OnPropertyChanged(nameof(IfAdminStatus8));
            }
        }
        public string IfAdminStatus9
        {
            get { return _ifadminstatus9; }
            set
            {
                _ifadminstatus9 = value;
                OnPropertyChanged(nameof(IfAdminStatus9));
            }
        }
        public string IfAdminStatus10
        {
            get { return _ifadminstatus10; }
            set
            {
                _ifadminstatus10 = value;
                OnPropertyChanged(nameof(IfAdminStatus10));
            }
        }
        public string IfAdminStatus1Indicator
        {
            get { return _ifadminstatus1indicator; }
            set
            {
                _ifadminstatus1indicator = value;
                OnPropertyChanged(nameof(IfAdminStatus1Indicator));
            }
        }
        public string IfAdminStatus2Indicator
        {
            get { return _ifadminstatus2indicator; }
            set
            {
                _ifadminstatus2indicator = value;
                OnPropertyChanged(nameof(IfAdminStatus2Indicator));
            }
        }
        public string IfAdminStatus3Indicator
        {
            get { return _ifadminstatus3indicator; }
            set
            {
                _ifadminstatus3indicator = value;
                OnPropertyChanged(nameof(IfAdminStatus3Indicator));
            }
        }
        public string IfAdminStatus4Indicator
        {
            get { return _ifadminstatus4indicator; }
            set
            {
                _ifadminstatus4indicator = value;
                OnPropertyChanged(nameof(IfAdminStatus4Indicator));
            }
        }
        public string IfAdminStatus5Indicator
        {
            get { return _ifadminstatus5indicator; }
            set
            {
                _ifadminstatus5indicator = value;
                OnPropertyChanged(nameof(IfAdminStatus5Indicator));
            }
        }
        public string IfAdminStatus6Indicator
        {
            get { return _ifadminstatus6indicator; }
            set
            {
                _ifadminstatus6indicator = value;
                OnPropertyChanged(nameof(IfAdminStatus6Indicator));
            }
        }
        public string IfAdminStatus7Indicator
        {
            get { return _ifadminstatus7indicator; }
            set
            {
                _ifadminstatus7indicator = value;
                OnPropertyChanged(nameof(IfAdminStatus7Indicator));
            }
        }
        public string IfAdminStatus8Indicator
        {
            get { return _ifadminstatus8indicator; }
            set
            {
                _ifadminstatus8indicator = value;
                OnPropertyChanged(nameof(IfAdminStatus8Indicator));
            }
        }
        public string IfAdminStatus9Indicator
        {
            get { return _ifadminstatus9indicator; }
            set
            {
                _ifadminstatus9indicator = value;
                OnPropertyChanged(nameof(IfAdminStatus9Indicator));
            }
        }
        public string IfAdminStatus10Indicator
        {
            get { return _ifadminstatus10indicator; }
            set
            {
                _ifadminstatus10indicator = value;
                OnPropertyChanged(nameof(IfAdminStatus10Indicator));
            }
        }
        public string IfAdminStatus1Timestamp
        {
            get { return _ifadminstatus1timestamp; }
            set
            {
                _ifadminstatus1timestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus1Timestamp));
            }
        }
        public string IfAdminStatus2Timestamp
        {
            get { return _ifadminstatus2timestamp; }
            set
            {
                _ifadminstatus2timestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus2Timestamp));
            }
        }
        public string IfAdminStatus3Timestamp
        {
            get { return _ifadminstatus3timestamp; }
            set
            {
                _ifadminstatus3timestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus3Timestamp));
            }
        }
        public string IfAdminStatus4Timestamp
        {
            get { return _ifadminstatus4timestamp; }
            set
            {
                _ifadminstatus4timestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus4Timestamp));
            }
        }
        public string IfAdminStatus5Timestamp
        {
            get { return _ifadminstatus5timestamp; }
            set
            {
                _ifadminstatus5timestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus5Timestamp));
            }
        }
        public string IfAdminStatus6Timestamp
        {
            get { return _ifadminstatus6timestamp; }
            set
            {
                _ifadminstatus6timestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus6Timestamp));
            }
        }
        public string IfAdminStatus7Timestamp
        {
            get { return _ifadminstatus7timestamp; }
            set
            {
                _ifadminstatus7timestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus7Timestamp));
            }
        }
        public string IfAdminStatus8Timestamp
        {
            get { return _ifadminstatus8timestamp; }
            set
            {
                _ifadminstatus8timestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus8Timestamp));
            }
        }
        public string IfAdminStatus9Timestamp
        {
            get { return _ifadminstatus9timestamp; }
            set
            {
                _ifadminstatus9timestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus9Timestamp));
            }
        }
        public string IfAdminStatus10Timestamp
        {
            get { return _ifadminstatus10timestamp; }
            set
            {
                _ifadminstatus10timestamp = value;
                OnPropertyChanged(nameof(IfAdminStatus10Timestamp));
            }
        }
        #endregion

        #region Routers OperStatus Property

        public string IfOperStatus1
        {
            get { return _ifoperstatus1; }
            set
            {
                _ifoperstatus1 = value;
                OnPropertyChanged(nameof(IfOperStatus1));
            }
        }
        public string IfOperStatus2
        {
            get { return _ifoperstatus2; }
            set
            {
                _ifoperstatus2 = value;
                OnPropertyChanged(nameof(IfOperStatus2));
            }
        }
        public string IfOperStatus3
        {
            get { return _ifoperstatus3; }
            set
            {
                _ifoperstatus3 = value;
                OnPropertyChanged(nameof(IfOperStatus3));
            }
        }
        public string IfOperStatus4 
        {
            get { return _ifoperstatus4; } 
            set 
            {
                _ifoperstatus4 = value;
                OnPropertyChanged(nameof(IfOperStatus4));
            } 
        }
        public string IfOperStatus5 
        {
            get { return _ifoperstatus5; }
            set 
            {
                _ifoperstatus5 = value;
                OnPropertyChanged(nameof(IfOperStatus5));
            } 
        }
        public string IfOperStatus6 
        {
            get { return _ifoperstatus6; }
            set 
            {
                _ifoperstatus6 = value;
                OnPropertyChanged(nameof(IfOperStatus6));
            }
        }
        public string IfOperStatus7 
        {
            get { return _ifoperstatus7;} 
            set 
            {
                _ifoperstatus7 = value;
                OnPropertyChanged(nameof(IfOperStatus7));
            }
        }
        public string IfOperStatus8 
        {
            get { return _ifoperstatus8; }
            set 
            {
                _ifoperstatus8 = value;
                OnPropertyChanged(nameof(IfOperStatus8));
            }
        }
        public string IfOperStatus9 
        {
            get { return _ifoperstatus9;}
            set 
            {
                _ifoperstatus9 = value;
                OnPropertyChanged(nameof(IfOperStatus9));
            } 
        }
        public string IfOperStatus10 
        {
            get { return _ifoperstatus10;}
            set
            {
                _ifoperstatus10 = value;
                OnPropertyChanged(nameof(IfOperStatus10));
            }
        }
        public string IfOperStatus1Indicator 
        {
            get { return _ifoperstatus1indicator; }
            set
            {
                _ifoperstatus1indicator = value;
                OnPropertyChanged(nameof(IfOperStatus1Indicator));
            }
        }
        public string IfOperStatus2Indicator
        {
            get { return _ifoperstatus2indicator;}
            set 
            {
                _ifoperstatus2indicator = value;
                OnPropertyChanged(nameof(IfOperStatus2Indicator));
            }
        }
        public string IfOperStatus3Indicator
        {
            get { return _ifoperstatus3indicator;}
            set 
            {
                _ifoperstatus3indicator = value;
                OnPropertyChanged(nameof(IfOperStatus3Indicator));
            }
        }
        public string IfOperStatus4Indicator
        {
            get { return _ifoperstatus4indicator;}
            set 
            {
                _ifoperstatus4indicator = value;
                OnPropertyChanged(nameof(IfOperStatus4Indicator));
            }
        }
        public string IfOperStatus5Indicator
        {
            get { return _ifoperstatus5indicator;}
            set 
            { 
                _ifoperstatus5indicator = value;
                OnPropertyChanged(nameof(IfOperStatus5Indicator));
            }
        }
        public string IfOperStatus6Indicator
        {
            get { return _ifoperstatus6indicator;}
            set 
            {
                _ifoperstatus6indicator = value;
                OnPropertyChanged(nameof(IfOperStatus6Indicator));
            }
        }
        public string IfOperStatus7Indicator 
        {
            get { return _ifoperstatus7indicator; }
            set 
            {
                _ifoperstatus7indicator = value;
                OnPropertyChanged(nameof(IfOperStatus7Indicator));
            }
        }
        public string IfOperStatus8Indicator
        {
            get { return _ifoperstatus8indicator;}
            set 
            {
                _ifoperstatus8indicator = value;
                OnPropertyChanged(nameof(IfOperStatus8Indicator));
            }
        }
        public string IfOperStatus9Indicator
        {
            get { return _ifoperstatus9indicator;}
            set 
            {
                _ifoperstatus9indicator = value;
                OnPropertyChanged(nameof(IfOperStatus9Indicator));
            }
        }
        public string IfOperStatus10Indicator
        {
            get { return _ifoperstatus10indicator;}
            set 
            {
                _ifoperstatus10indicator = value;
                OnPropertyChanged(nameof(IfOperStatus10Indicator));
            }
        }
        public string IfOperStatus1Timestamp 
        {
            get { return _ifoperstatus1timestamp; }
            set
            {
                _ifoperstatus1timestamp = value;
                OnPropertyChanged(nameof(IfOperStatus1Timestamp));
            }
        }
        public string IfOperStatus2Timestamp
        {
            get { return _ifoperstatus2timestamp;}
            set
            {
                _ifoperstatus2timestamp = value;
                OnPropertyChanged(nameof(IfOperStatus2Timestamp));
            }
        }
        public string IfOperStatus3Timestamp
        {
            get { return _ifoperstatus3timestamp;}
            set 
            {
                _ifoperstatus3timestamp = value;
                OnPropertyChanged(nameof(IfOperStatus3Timestamp));
            }
        }
        public string IfOperStatus4Timestamp
        {
            get { return _ifoperstatus4timestamp;}
            set 
            {
                _ifoperstatus4timestamp = value;
                OnPropertyChanged(nameof(IfOperStatus4Timestamp));
            }
        }
        public string IfOperStatus5Timestamp
        {
            get { return _ifoperstatus5timestamp;}
            set
            {
                _ifoperstatus5timestamp = value;
                OnPropertyChanged(nameof(IfOperStatus5Timestamp));
            }
        }
        public string IfOperStatus6Timestamp
        {
            get { return _ifoperstatus6timestamp;}
            set
            {
                _ifoperstatus6timestamp = value;
                OnPropertyChanged(nameof(IfOperStatus6Timestamp));
            }
        }
        public string IfOperStatus7Timestamp
        {
            get { return _ifoperstatus7timestamp;}
            set 
            {
                _ifoperstatus7timestamp = value;
                OnPropertyChanged(nameof(IfOperStatus7Timestamp));
            }
        }
        public string IfOperStatus8Timestamp 
        {
            get { return _ifoperstatus8timestamp;}
            set 
            {
                _ifoperstatus8timestamp = value;
                OnPropertyChanged(nameof(IfOperStatus8Timestamp));
            } 
        }
        public string IfOperStatus9Timestamp 
        {
            get { return _ifoperstatus9timestamp;}
            set 
            {
                _ifoperstatus9timestamp = value;
                OnPropertyChanged(nameof(IfOperStatus9Timestamp));
            } 
        }
        public string IfOperStatus10Timestamp 
        {
            get { return _ifoperstatus10timestamp;}
            set 
            {
                _ifoperstatus10timestamp = value;
                OnPropertyChanged(nameof(IfOperStatus10Timestamp));
            }
        }
        #endregion
    }
}
