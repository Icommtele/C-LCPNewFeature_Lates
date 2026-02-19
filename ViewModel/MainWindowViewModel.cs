using LCPReportingSystem.Command;
using LCPReportingSystem.Model;
using LCPReportingSystem.WindowForm;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Net.NetworkInformation;
using LCPReportingSystem.RsDialogMessageBox;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using CommonLib;
using LCPInfrastructure;
using LCPReportingSystem.DbHelper;
using LCPReportingSystem.SystemConfig;
using Serilog.Context;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LCPReportingSystem.Properties;
using System.ServiceProcess;


namespace LCPReportingSystem.ViewModel
{
    public class MainWindowViewModel
    {
        #region
        private ICommand _logincommand;
        private ICommand _createUserCommand;
        private ICommand _addusercommand;
        private ICommand _cancelcommand;
        private ICommand _saveExercisecommand;
        private ICommand _forgotpasswordcommand;
        private ICommand _resetpasswordcommand;
        private ICommand _exitcommand;
        private ICommand _selectdevicecommand;
        private ICommand _closepopupcommand;
        private ICommand _submitpopupcommand;
        public string PasswordMaskedText = "Your old password is not masked.";
        public string ContactAdminText = "The admin user can create a new user. Please contact to the admin.";
        public string EnterUandPText = "Please enter Username and Password.";
        public string EnterUText = "Please enter Username";
        public string EnterPText = "Please enter Password.";
        public string EnterMailText = "Please enter Email Id.";
        public string EnterValidMailText = "Please enter valid Email Id.";
        public string EnterCPText = "Please enter Confirmation Password.";
        public string CPandPSameText = "Your password and conform password should Same.";
        public string PasswordTemplateText = "Password must include both uppercase and lowercase and Number and Special Characters.";
        public string alreadyUserText = "The user account already exists, Please give some new user name.";
        public string UsertypeText = "Please select the user type.";
        public string UsernotExistText = "User does not exist. Please enter a valid username and password.";
        public string PasswordIncorrectText = "Password is invalid please enter correct password.";
        public string SelectDeviceText = "Please select a device before login.";
        public string LoginedText = "Logined successfully";
        public string InvalidPasswordText = "Invalid Password";
        public string LoginText = "Login";
        public string DeviceSelectText = "Device Selection";
        public string UserCreatText = "New User Creation";

        #endregion

        MainWindow _mwindow;
        ICaptureDevice device = null;
        CaptureDeviceList liveDevices = null;
        public Admin adminfields { get; set; }
        public Utility _utility;
        public int ExerciseId = 0;
        public Func<ExerciseDataModel> exerciseinsertDataHandler;
        public Action<string, string> GetSavedUserdataHandler { get; set; }
        public MainWindowViewModel(MainWindow mwindow)
        {
            adminfields = new Admin();
            _utility = new Utility();
            this._mwindow = mwindow;
            LoadMainWindowDefault();
        }
        public ICommand LoginCommand
        {
            get
            {
                if (_logincommand == null)
                {
                    _logincommand = new RelayCommand(param => AdminLogin(adminfields), null);
                }
                return _logincommand;
            }
        }
        public ICommand CreateUserCommand
        {
            get
            {
                if (_createUserCommand == null)
                {
                    _createUserCommand = new RelayCommand(param => addNewUser(), null);
                }
                return _createUserCommand;
            }
        }
        public ICommand AddUserCommand
        {
            get
            {
                if (_addusercommand == null)
                {
                    _addusercommand = new RelayCommand(param => CreateNewUser(), null);
                }
                return _addusercommand;
            }
        }
        public ICommand CancelCommand
        {
            get
            {
                if (_cancelcommand == null)
                {
                    _cancelcommand = new RelayCommand(param => CancelNewUser(), null);
                }
                return _cancelcommand;
            }
        }
        public ICommand ForgetPasswordCommand
        {
            get
            {
                if (_forgotpasswordcommand == null)
                {
                    _forgotpasswordcommand = new RelayCommand(param => ForgetPassword(), null);
                }
                return _forgotpasswordcommand;
            }
        }
        public ICommand ResetPasswordCommand
        {
            get
            {
                if (_resetpasswordcommand == null)
                {
                    _resetpasswordcommand = new RelayCommand(param => ResetPassword(), null);
                }
                return _resetpasswordcommand;
            }
        }
        public ICommand ExitCommand
        {
            get
            {
                if (_exitcommand == null)
                {
                    _exitcommand = new RelayCommand(param => Exit(), null);
                }
                return _exitcommand;
            }
        }
        public ICommand SelectDeviceCommand
        {
            get
            {
                if (_selectdevicecommand == null)
                {
                    _selectdevicecommand = new RelayCommand(param => SelectDeviceFunction(), null);
                }
                return _selectdevicecommand;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public ICommand ClosePopupCommand
        {
            get
            {
                if (_closepopupcommand == null)
                {
                    _closepopupcommand = new RelayCommand(param => ClosePopUp(), null);
                }
                return _closepopupcommand;
            }
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public ICommand SubmitPopupCommand
        {
            get
            {
                if (_submitpopupcommand == null)
                {
                    _submitpopupcommand = new RelayCommand(param => SubmitPopup(), null);
                }
                return _submitpopupcommand;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void ForgetPassword()
        {
            try
            {
                if (this._mwindow.BtnForgetPassword.Content.ToString() == Common.Gobacktologin)
                {
                    this._mwindow.btnLoginPanel.Visibility = Visibility.Visible;
                    this._mwindow.UserTextPanel.Visibility = Visibility.Visible;
                    this._mwindow.CheckBoxPanel.Visibility = Visibility.Visible;
                    this._mwindow.txtUserPassword.Text = "User Password";
                    adminfields.IsSelectedDeviceBtn = true;
                    adminfields.ConfirmPasswordTextBlock = false;
                    adminfields.ConfirmPasswordInput = false;
                    adminfields.IsLoginButton = true;
                    adminfields.IsNewUserButton = true;
                    adminfields.IsResetButton = false;
                    this._mwindow.BtnForgetPassword.Content = Common.ForgotPassword;
                    this._mwindow.BtnForgetPassword.Visibility = Visibility.Collapsed;
                    this._mwindow.txtResetSuccess.Visibility = Visibility.Collapsed;
                    this._mwindow.txtResetFailed.Visibility = Visibility.Collapsed;
                    this._mwindow.PasswordRulesPanel.Visibility = Visibility.Collapsed;
                }
                else
                {
                    this._mwindow.buttonLogin.Content = "Reset Password";
                    this._mwindow.buttonLogin.Content = "Reset Password";
                    this._mwindow.txtUserPassword.Text = "Enter New Password";
                    this._mwindow.BtnForgetPassword.Content = Common.Gobacktologin;
                    this._mwindow.CheckBoxPanel.Visibility = Visibility.Collapsed;
                    this._mwindow.PasswordRulesPanel.Visibility = Visibility.Visible;
                    this._mwindow.txtUserpassword.Password = string.Empty;
                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ForgetPassword));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void ResetPassword()
        {
            //try
            //{
            //    bool IsCredentialResult = _utility.IsCredential(adminfields.UserName, adminfields.Password, adminfields.ConfirmPassword);
            //    if (IsCredentialResult)
            //    {
            //        RsDialogBox.ShowMsg(Common.PleaseenterUserNameandPassword, Common.ResetPassword, MessageBoxButton.OK, MessageBoxImage.Information);
            //        return;
            //    }
            //    bool IsResetPassword = _utility.IsResetPassword(adminfields.UserName, adminfields.Password, adminfields.ConfirmPassword);

            //    if (IsResetPassword)
            //    {
            //        MessageBoxResult result = RsDialogBox.ShowMsg(Common.PasswordUpdatedsuccessfully, Common.ResetPassword, MessageBoxButton.OK, MessageBoxImage.Information);
            //        if (result == MessageBoxResult.OK)
            //        {
            //            adminfields.IsSelectedDeviceBtn = true;
            //            adminfields.ConfirmPasswordTextBlock = false;
            //            adminfields.ConfirmPasswordInput = false;
            //            adminfields.IsLoginButton = true;
            //            adminfields.IsNewUserButton = true;
            //            adminfields.IsResetButton = false;
            //            adminfields.ForgeTextPass = Common.ForgotPassword;
            //            adminfields.UserName = string.Empty;
            //            adminfields.Password = string.Empty;
            //        }
            //    }
            //    else
            //    {
            //        RsDialogBox.ShowMsg(PasswordMaskedText, Common.ResetPassword, MessageBoxButton.OK, MessageBoxImage.Information);
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    LCPLogUtils.LogException(ex, GetType().Name, nameof(ResetPassword));
            //}


           
            try
            {
                bool isCredentialValid = _utility.IsCredential(
                    adminfields.UserName,
                    adminfields.Password,
                    adminfields.ConfirmPassword
                );

                if (!isCredentialValid)
                {
                    RsDialogBox.ShowMsg(
                        Common.PleaseenterUserNameandPassword,
                        Common.ResetPassword,
                        MessageBoxButton.OK,
                        MessageBoxImage.Information
                    );
                    return;
                }

                bool isResetPassword = _utility.IsResetPassword(
                    adminfields.UserName,
                    adminfields.Password,          // old password
                    adminfields.ConfirmPassword    // new password
                );

                if (isResetPassword)
                {
                    RsDialogBox.ShowMsg(
                        Common.PasswordUpdatedsuccessfully,
                        Common.ResetPassword,
                        MessageBoxButton.OK,
                        MessageBoxImage.Information
                    );

                    adminfields.IsSelectedDeviceBtn = true;
                    adminfields.ConfirmPasswordTextBlock = false;
                    adminfields.ConfirmPasswordInput = false;
                    adminfields.IsLoginButton = true;
                    adminfields.IsNewUserButton = true;
                    adminfields.IsResetButton = false;
                    adminfields.ForgeTextPass = Common.ForgotPassword;

                    adminfields.UserName = string.Empty;
                    adminfields.Password = string.Empty;
                    adminfields.ConfirmPassword = string.Empty;
                }
                else
                {
                    RsDialogBox.ShowMsg(
                        "Invalid username or password.",
                        Common.ResetPassword,
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ResetPassword));
            }
        }


        
        /// <summary>
        /// 
        /// </summary>
        private void addNewUser()
        {
            try
            {
                if (!string.IsNullOrEmpty(adminfields.UserName) && !string.IsNullOrEmpty(adminfields.Password))
                {
                    bool isAdmin = _utility.IsadminUser(adminfields.UserName, adminfields.Password);

                    if (isAdmin)
                    {
                        adminfields.IsLoginView = false;
                        adminfields.IsViewNewUser = true;
                        return;
                    }
                    RsDialogBox.ShowMsg(ContactAdminText, UserCreatText, MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    RsDialogBox.ShowMsg(EnterUandPText, Common.UserLogin, MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(addNewUser));
            }
        }
        /// <summary>
        /// create New User
        /// </summary>
        private void CreateNewUser()
        {
            try
            {
                bool IsPasswordCaseSensitive = HasUpperAndLowerCase(adminfields.Npassword);

                bool IsConformPass = _utility.IsConformPassword(adminfields.Npassword, adminfields.NConformPassword);
                bool IsValidEmail = _utility.IsEmailValid(adminfields.Email);
                bool IsUserExist = _utility.IsUserExists(adminfields.NuserName, adminfields.Npassword);
                if (string.IsNullOrEmpty(adminfields.NuserName))
                {
                    RsDialogBox.ShowMsg(EnterUText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (adminfields.NuserName.Length < 4)
                {
                    RsDialogBox.ShowMsg("Please enter a minimum of 4 characters as a username.", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (string.IsNullOrEmpty(adminfields.Email))
                {
                    RsDialogBox.ShowMsg(EnterMailText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (string.IsNullOrEmpty(adminfields.Npassword))
                {
                    RsDialogBox.ShowMsg(EnterPText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (string.IsNullOrEmpty(adminfields.NConformPassword))
                {
                    RsDialogBox.ShowMsg(EnterCPText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (!IsConformPass)
                {
                    RsDialogBox.ShowMsg(CPandPSameText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (!IsPasswordCaseSensitive)
                {
                    RsDialogBox.ShowMsg(PasswordTemplateText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (!IsValidEmail)
                {
                    RsDialogBox.ShowMsg(EnterValidMailText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (!IsUserExist)
                {
                    RsDialogBox.ShowMsg(alreadyUserText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (adminfields.IsAdminRole == true)
                {
                    adminfields.Userroleid = 101;
                }
                else if (adminfields.IsUserRole == true)
                {
                    adminfields.Userroleid = 102;
                }
                else if (adminfields.Userroleid == 0)
                {
                    RsDialogBox.ShowMsg(UsertypeText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                adminfields.Isactive = Common.isActive;

                string IsAddUserSucess = _utility.IsSucessAddNewuser(adminfields);

                if (IsAddUserSucess == "Success")
                {
                    MessageBoxResult Result = RsDialogBox.ShowMsg(Common.Congratulation, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Information);

                    if (Result == MessageBoxResult.OK)
                    {
                        adminfields.IsViewNewUser = false;
                        adminfields.IsLoginView = true;
                        adminfields.UserName = string.Empty;
                        adminfields.Password = string.Empty;
                        adminfields.NuserName = string.Empty;
                        adminfields.Npassword = string.Empty;
                        adminfields.NConformPassword = string.Empty;
                    }
                }
                else if (IsAddUserSucess.Contains("Email"))
                {
                    RsDialogBox.ShowMsg("Email already existed ,please enter valid Email", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (IsAddUserSucess.Contains("UserName"))
                {
                    RsDialogBox.ShowMsg("UserName already existed ,please enter valid UserName", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    RsDialogBox.ShowMsg("Failed Create User", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(CreateNewUser));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool HasUpperAndLowerCase(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasNumber = password.Any(char.IsNumber);
            bool hasSpecial = password.Any(ch => char.IsPunctuation(ch) || char.IsSymbol(ch));

            return hasUpper && hasLower && hasNumber && hasSpecial;
        }
        public Func<bool> GetPasswordMatchStatusHandler;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="admin"></param>
        public void AdminLogin(Admin admin = null)
        {
            try
            {

                adminfields.UserName = admin?.UserName;
                adminfields.Password = admin?.Password;


                if (GetPasswordMatchStatusHandler() )
                {
                    string superUsername = Properties.Settings.Default.SuperUserName;
                    string superPassword = Properties.Settings.Default.SuperUserPassword;

                    // 🔹 Case 1: First time login with Super Admin
                    if (adminfields.UserName == superUsername && adminfields.Password == superPassword)
                    {
                        this._mwindow.SuperAdminPanel.Visibility = Visibility.Visible;
                        adminfields.IsLoginView = false;
                    }
                    else
                    {
                        if (this._mwindow.buttonLogin.Content.ToString().Contains("Reset"))
                        {
                            this._mwindow.buttonLogin.Content = "Login";
                            if (!ValidatePassword(adminfields.Password))
                            {
                                RsDialogBox.ShowMsg(PasswordIncorrectText,
                                                    InvalidPasswordText, MessageBoxButton.OK, MessageBoxImage.Warning);
                                this._mwindow.btnLoginPanel.Visibility = Visibility.Visible;
                                this._mwindow.UserTextPanel.Visibility = Visibility.Visible;
                                this._mwindow.txtResetSuccess.Visibility = Visibility.Collapsed;
                                this._mwindow.PasswordRulesPanel.Visibility = Visibility.Visible;
                                this._mwindow.BtnForgetPassword.Visibility = Visibility.Visible;
                                this._mwindow.buttonLogin.Content = "Reset Password";
                                return;
                            }


                            bool IsResetPassword = _utility.IsResetPassword(adminfields.UserName, adminfields.Password, adminfields.ConfirmPassword);

                            if (IsResetPassword)
                            {
                                this._mwindow.btnLoginPanel.Visibility = Visibility.Collapsed;
                                this._mwindow.UserTextPanel.Visibility = Visibility.Collapsed;
                                this._mwindow.txtResetSuccess.Visibility = Visibility.Visible;
                                this._mwindow.BtnForgetPassword.Visibility = Visibility.Visible;
                                this._mwindow.PasswordRulesPanel.Visibility = Visibility.Collapsed;

                            }
                        }
                        else
                        {

                            // Check empty username & password
                            if (string.IsNullOrEmpty(adminfields.UserName) && string.IsNullOrEmpty(adminfields.Password))
                            {
                                RsDialogBox.ShowMsg("Please enter both Username and Password.",
                                                    Common.UserLogin, MessageBoxButton.OK, MessageBoxImage.Warning);
                                return;
                            }

                            if (string.IsNullOrEmpty(adminfields.UserName))
                            {
                                RsDialogBox.ShowMsg("Please enter Username.",
                                                    Common.UserLogin, MessageBoxButton.OK, MessageBoxImage.Warning);
                                return;
                            }

                            if (string.IsNullOrEmpty(adminfields.Password))
                            {
                                RsDialogBox.ShowMsg("Please enter Password.", Common.UserLogin, MessageBoxButton.OK, MessageBoxImage.Warning);

                                return;
                            }

                            string loginResult = _utility.userLogin(adminfields.UserName, adminfields.Password);
                            if (loginResult == "No user found")
                            {
                                RsDialogBox.ShowMsg("User does not exist.",
                                                    Common.UserLogin, MessageBoxButton.OK, MessageBoxImage.Error);
                                return;
                            }
                            else if (loginResult == "Password wrong")
                            {
                                RsDialogBox.ShowMsg("Incorrect password. Please try again.", Common.UserLogin, MessageBoxButton.OK, MessageBoxImage.Warning);
                                this._mwindow.BtnForgetPassword.Visibility = Visibility.Visible;

                                return;
                            }
                            else if (loginResult == "Success")
                            {
                                //RsDialogBox.ShowMsg("Login successful.",Common.UserLogin, MessageBoxButton.OK, MessageBoxImage.Information);

                                // Proceed to dashboard or next step
                            }
                            else
                            {
                                RsDialogBox.ShowMsg("Please enter correct username and password " + loginResult,
                                                    Common.UserLogin, MessageBoxButton.OK, MessageBoxImage.Error);
                                return;
                            }

                            GetDeviceDetails();
                        }
                    }


                }
                else
                {
                    if(this._mwindow.buttonLogin.Content == "Reset Password")
                    {
                        RsDialogBox.ShowMsg(
                        "Your password is too weak. Make sure it includes:\n" +
                        "• Uppercase & lowercase letters\n" +
                   "• Numbers\n" +
                      "• Special characters\n" +
                        "• Minimum 6 characters",
                        Common.UserLogin,
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning
                    );
                    }
                        
                }



            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(AdminLogin));
            }
        }



        /// <summary>
        /// Save Excercise Data 
        /// </summary>
        /// <param name="ExerciseType"></param>
        /// <param name="ExerciseDescription"></param>
        /// <param name="ExerciseStartTime"></param>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public int SaveExerciseData(string ExerciseType, string ExerciseDescription, DateTime ExerciseStartTime, string UserName)
        {
            try
            {
                int Exercise_Id = _utility.ExerciseDataSave(ExerciseType, ExerciseDescription, ExerciseStartTime, UserName);
                ExerciseId = Exercise_Id;
                return Exercise_Id;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SaveExerciseData));
            }
            return 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Common.pattern);
        }
        private void CancelNewUser()
        {
            if (adminfields.IsViewNewUser == true)
            {
                adminfields.IsViewNewUser = false;
                adminfields.IsLoginView = true;
                adminfields.UserName = string.Empty;
                adminfields.Password = string.Empty;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void Exit()
        {
            try
            {
                MainWindow IsactiveMainWin = Application.Current.Windows.OfType<MainWindow>().SingleOrDefault(window => window.IsActive);
                IsactiveMainWin.Close();
                UsageConstants.keepRunning = false;
                StopServiceViaProcess();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SaveExerciseData));
            }

        }



        private void StopServiceViaProcess()
        {
            try
            {
                if (Settings.Default.IsStopService)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "sc",
                        Arguments = $"stop {Settings.Default.ServiceName}",
                        Verb = "runas",
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(StopServiceViaProcess));
            }
        }
        /// <summary>
        /// Submmit Popup Data 
        /// </summary>
        private void SubmitPopup()
        {
            SelectDevice();
        }
        private void ClosePopUp()
        {
            adminfields.IsDevicePopupEnable = false;
        }
        public void SelectDevice()
        {
            try
            {
                var devices = adminfields.DeviceCollection;
                if (devices != null && devices.Count > 0)
                {
                    foreach (DeviceInfo device in devices)
                    {
                        if (device.IsChecked != true)
                            continue;

                        //var nic = NetworkInterface.GetAllNetworkInterfaces()
                        //        .FirstOrDefault(item =>
                        //            item.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                        //            !item.Description.ToLower().Contains("virtual") &&
                        //            !item.Description.ToLower().Contains("loopback") &&
                        //            item.Description.Equals(device.DeviceDescription, StringComparison.OrdinalIgnoreCase));


                        // ✅ Only two cases matter to you
                        //if(nic != null )//&& nic.OperationalStatus == OperationalStatus.Up)
                        //{

                        // Extract and assign device info
                        adminfields.DeviceIndex = (int)device.Driverindex;
                        adminfields.DeviceDescription = device.DeviceDescription;
                        adminfields.IsDevicePopupEnable = false;



                        // Insert exercise data if available
                        var exerciseData = exerciseinsertDataHandler();
                        if (exerciseData != null)
                        {
                            SaveExerciseData(exerciseData.ExerciseType, exerciseData.ExerciseDescription, DateTime.Now, adminfields.UserName);
                        }

                        // Insert activity report
                        ActivityReportDataInsertModel.SetActivityReport(LoginText, LoginedText, adminfields.UserName);

                        // Set admin usage flag
                        UsageConstants.isAdmin = _utility.IsadminUser(adminfields.UserName, adminfields.Password);
                        GetSavedUserdataHandler(adminfields.UserName, adminfields.Password);
                        // Load subsystem info
                        SubsytemInfo.GetSubSystemInfo();

                        StartServiceViaProcess();
                        Task.Run(() => { GenerateFaultStatus.Start_SNMP_Polling(); });


                        // Open main window and close previous login windows
                        var loginWindows = Application.Current.Windows.OfType<MainWindow>().ToList();
                        Main mainWindow = new Main(adminfields)
                        {
                            btn_Logout = { Tag = ExerciseId }
                        };

                        if (mainWindow != null)
                        {
                            var nic = NetworkInterface.GetAllNetworkInterfaces()
                                    .FirstOrDefault(item =>
                                        item.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                                        !item.Description.ToLower().Contains("virtual") &&
                                        !item.Description.ToLower().Contains("loopback") &&
                                        item.Description.Equals(device.DeviceDescription, StringComparison.OrdinalIgnoreCase));



                            if (nic != null && nic.OperationalStatus == OperationalStatus.Up)
                            {
                                mainWindow.SetNetworkStatus("Network Connected");
                            }
                            else
                            {
                                mainWindow.SetNetworkStatus("No network connection detected. Please check your Network Connection");
                            }
                        }

                        foreach (var window in loginWindows)
                        {
                            window.Close();
                        }

                        mainWindow.ShowDialog();

                        // Clear credentials
                        adminfields.UserName = string.Empty;
                        adminfields.Password = string.Empty;


                    }
                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SelectDevice));
            }
        }
        private void StartServiceViaProcess()
        {
            try
            {
                // Check service status first
                using (ServiceController sc = new ServiceController(Settings.Default.ServiceName))
                {
                    if (sc.Status == ServiceControllerStatus.Running)
                    {
                        return;
                    }

                    if (sc.Status == ServiceControllerStatus.Stopped ||
                        sc.Status == ServiceControllerStatus.Paused)
                    {
                        // Start service via Process (UAC prompt)
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "sc",
                            Arguments = $"start {Settings.Default.ServiceName}",
                            Verb = "runas",  // Forces UAC prompt
                            UseShellExecute = true
                          //  CreateNoWindow = true

                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while starting service: " + ex.Message);
            }
        }
        /// <summary>
        /// Select Device Data 
        /// </summary>
        private void SelectDeviceFunction()
        {
            // GetDeviceDetails();
        }
        /// <summary>
        /// Get Device Details
        /// </summary>
        private void GetDeviceDetails()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            Dictionary<string, string> networkCollection = new Dictionary<string, string>();
            ObservableCollection<DeviceInfo> devices = new ObservableCollection<DeviceInfo>();

            try
            {
                foreach (NetworkInterface item in networkInterfaces)
                {
                    if (item.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                        !item.Description.ToLower().Contains("virtual") &&
                        !item.Description.ToLower().Contains("loopback"))
                    {
                        // ✅ Only consider NICs that are UP
                        //if (item.OperationalStatus == OperationalStatus.Up)
                        //{
                        string networkDescription = item.Description;
                        string name = item.Name;

                        // Handle duplicate NIC descriptions
                        if (networkCollection.ContainsKey(networkDescription))
                        {
                            int count = 1;
                            string newKey = networkDescription + "_" + count;
                            while (networkCollection.ContainsKey(newKey))
                            {
                                count++;
                                newKey = networkDescription + "_" + count;
                            }
                            networkDescription = newKey;
                        }

                        networkCollection.Add(networkDescription, name);
                        //}
                    }
                }

                //// ✅ Only proceed if at least one NIC is Up
                //if (networkCollection.Count == 0)
                //{
                //    RsDialogBox.ShowMsg("Please check network connection", "Network", MessageBoxButton.OK, MessageBoxImage.Error);
                //    adminfields.IsDevicePopupEnable = false; // disable popup
                //    adminfields.DeviceCollection = new ObservableCollection<DeviceInfo>();
                //    adminfields.DeviceDescription = null;
                //    return;
                //}

                // If NICs available, enable popup
                adminfields.IsDevicePopupEnable = true;

                for (int i = 0; i < liveDevices.Count; i++)
                {
                    if (networkCollection.ContainsKey(liveDevices[i].Description))
                    {
                        int index = i;
                        string description = liveDevices[i].Description;
                        devices.Add(new DeviceInfo(index, description));
                    }
                }

                adminfields.DeviceCollection = devices;

                if (devices.Count == 1)
                {
                    devices[0].IsChecked = true;
                    adminfields.DeviceDescription = devices[0].DeviceDescription;
                }
                else if (devices.Count > 1)
                {
                    foreach (var device in devices)
                    {
                        device.IsChecked = false;
                    }
                    adminfields.DeviceDescription = null;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetDeviceDetails));
            }
        }
        /// <summary>
        /// Load Main Details
        /// </summary>
        private void LoadMainWindowDefault()
        {
            try
            {
                adminfields.IsLoginView = true;
                adminfields.IsViewNewUser = false;
                adminfields.ConfirmPasswordTextBlock = false;
                adminfields.ConfirmPasswordInput = false;
                adminfields.IsLoginButton = true;
                adminfields.IsNewUserButton = true;
                adminfields.IsResetButton = false;
                adminfields.ForgeTextPass = Common.ForgotPassword;
                adminfields.IsSelectedDeviceBtn = true;

                liveDevices = CaptureDeviceList.Instance;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetDeviceDetails));
            }
        }
    }
}
