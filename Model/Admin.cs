using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCPReportingSystem.ViewModel;

namespace LCPReportingSystem.Model
{
    public class Admin : ViewModelBase
    {
        private string _userName;
        private string _password;
        private string _nusername;
        private string _npassword;
        private string _conformpassword;
        private string _nconformPassword;
        private string _forgetextpass;
        private string _devicedescription;
        private int _userroleid;
        private int? _deviceindex;
        private string _email;
        private string _isactive;
        private bool _isadminrole;
        private bool _isuserrole;
        private bool _isloginview;
        private bool _isviewnewuser;
        private bool _confirmpasswordtextblock;
        private bool _confirmpasswordinput;
        private bool _isloginbutton;
        private bool _isnewuserbutton;
        private bool _isresetbutton;
        private bool _isselecteddevicebtn;
        private bool _isdevicepopupenable;

        ObservableCollection<DeviceInfo> _devices = new ObservableCollection<DeviceInfo>();
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ConfirmPassword
        {
            get { return _conformpassword; }
            set
            {
                _conformpassword = value;
                OnPropertyChanged(nameof(ConfirmPassword));
            }
        }
        public string NConformPassword
        {
            get { return _nconformPassword; }
            set
            {
                _nconformPassword = value;
                OnPropertyChanged(nameof(NConformPassword));
            }
        }
        public string NuserName
        {
            get { return _nusername; }
            set
            {
                _nusername = value;
                OnPropertyChanged(nameof(NuserName));
            }
        }
        public string Npassword
        {
            get { return _npassword; }
            set
            {
                _npassword = value;
                OnPropertyChanged(nameof(Npassword));
            }
        }
        public int Userroleid
        {
            get { return _userroleid; }
            set
            {
                _userroleid = value;
                OnPropertyChanged(nameof(Userroleid));
            }
        }
        public int? DeviceIndex
        {
            get { return _deviceindex; }
            set
            {
                _deviceindex = value;
                OnPropertyChanged(nameof(DeviceIndex));
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public string Isactive
        {
            get { return _isactive; }
            set
            {
                _isactive = value;
                OnPropertyChanged(nameof(Isactive));
            }
        }
        public string ForgeTextPass
        {
            get { return _forgetextpass; }
            set
            {
                _forgetextpass = value;
                OnPropertyChanged(nameof(ForgeTextPass));
            }
        }
        public string DeviceDescription
        {
            get { return _devicedescription; }
            set
            {
                _devicedescription = value;
                OnPropertyChanged(nameof(DeviceDescription));
            }
        }
        public bool IsAdminRole
        {
            get { return _isadminrole; }
            set
            {
                _isadminrole = value;
                OnPropertyChanged(nameof(IsAdminRole));
            }
        }
        public bool IsUserRole
        {
            get { return _isuserrole; }
            set
            {
                _isuserrole = value;
                OnPropertyChanged(nameof(IsUserRole));
            }
        }
        public bool IsLoginView
        {
            get { return _isloginview; }
            set
            {
                _isloginview = value;
                OnPropertyChanged(nameof(IsLoginView));
            }
        }
        public bool IsViewNewUser
        {
            get { return _isviewnewuser; }
            set
            {
                _isviewnewuser = value;
                OnPropertyChanged(nameof(IsViewNewUser));
            }
        }
        public bool ConfirmPasswordTextBlock
        {
            get { return _confirmpasswordtextblock; }
            set
            {
                _confirmpasswordtextblock = value;
                OnPropertyChanged(nameof(ConfirmPasswordTextBlock));
            }
        }
        public bool ConfirmPasswordInput
        {
            get { return _confirmpasswordinput; }
            set
            {
                _confirmpasswordinput = value;
                OnPropertyChanged(nameof(ConfirmPasswordInput));
            }
        }
        public bool IsLoginButton
        {
            get { return _isloginbutton; }
            set
            {
                _isloginbutton = value;
                OnPropertyChanged(nameof(IsLoginButton));
            }
        }
        public bool IsNewUserButton
        {
            get { return _isnewuserbutton; }
            set
            {
                _isnewuserbutton = value;
                OnPropertyChanged(nameof(IsNewUserButton));
            }
        }
        public bool IsResetButton
        {
            get { return _isresetbutton; }
            set
            {
                _isresetbutton = value;
                OnPropertyChanged(nameof(IsResetButton));
            }
        }
        public bool IsSelectedDeviceBtn
        {
            get { return _isselecteddevicebtn; }
            set
            {
                _isselecteddevicebtn = value;
                OnPropertyChanged(nameof(IsSelectedDeviceBtn));
            }
        }
        public bool IsDevicePopupEnable
        {
            get { return _isdevicepopupenable; }
            set
            {
                _isdevicepopupenable = value;
                OnPropertyChanged(nameof(IsDevicePopupEnable));
            }
        }
        public ObservableCollection<DeviceInfo> DeviceCollection
        {
            get { return _devices; }
            set
            {
                _devices = value;
                OnPropertyChanged(nameof(DeviceCollection));
            }
        }
    }
}
