using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using CommonLib;
using LCPInfrastructure;
using LCPReportingSystem.Command;
using LCPReportingSystem.Model;
using LCPReportingSystem.RsDialogMessageBox;
using LCPReportingSystem.ViewModel;

namespace LCPReportingSystem.ViewModel
{
    public class ManageUserViewModel
    {
        #region
        private ICommand _deleteusercommand;
        private ICommand _createusercommand;
        public ICommand _opencreateusercommand;
        public ICommand _closecreateuserpopupcommand;
        public ICommand _createaddusercommand;

        public string AdminText = "Admin";
        public string EnterUText = "Please enter Username";
        public string EnterCPText = "Please enter Confirmation Password.";
        public string EnterValidMailText = "Please enter valid Email Id.";
        public string PasswordDonotMatchText = "Passwords do not match.";
        public string PasswordTemplateText = "Password must include both uppercase and lowercase and Number and Special Characters.";
        public string SelectUserRoleText = "Please select a user role.";
        public string UserCreatedText = "User created successfully.";
        public string FailedUserCreatedText = "Failed to create the user.";
        public string ContactAdminText = "The admin user can create a new user. Please contact to the admin.";
        public string EnterUandPText = "Please enter Username and Password.";
        public string NewUserText = "New User Creation";
        public ManageUser manageUser { get; set; }
        public Utility _utility;
        public Admin adminfields { get; set; }
        #endregion
        public ManageUserViewModel()
        {
            manageUser = new ManageUser();
            adminfields = new Admin();
            _utility = new Utility();
        }
        public ICommand DeleteUserCommand
        {
            get
            {
                if (_deleteusercommand == null)
                {
                    _deleteusercommand = new RelayCommand(param => DeleteUsersFunction(), null);
                }
                return _deleteusercommand;
            }
        }
        public ICommand CreateUserCommand
        {
            get
            {
                if (_createusercommand == null)
                {
                    _createusercommand = new RelayCommand(param => CreateNewUser(), null);
                }
                return _createusercommand;
            }
        }
        public ICommand CreateaddUserCommand
        {
            get
            {
                if (_createaddusercommand == null)
                {
                    _createaddusercommand = new RelayCommand(param => addNewUser(), null);
                }
                return _createaddusercommand;
            }
        }
        public ICommand OpenPopupCommand
        {
            get
            {
                if (_opencreateusercommand == null)
                {
                    _opencreateusercommand = new RelayCommand(param => OpenCreateUserPopup(), null);
                }
                return _opencreateusercommand;
            }
        }
        public ICommand ClosePopupCommand
        {
            get
            {
                if (_closecreateuserpopupcommand == null)
                {
                    _closecreateuserpopupcommand = new RelayCommand(param => CloseCreateUserPopup(), null);
                }
                return _closecreateuserpopupcommand;
            }
        }
        private void OpenCreateUserPopup() => manageUser.IsCreateUserPopupOpen = true;

        private void CloseCreateUserPopup() => manageUser.IsCreateUserPopupOpen = false;
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
                    RsDialogBox.ShowMsg(ContactAdminText, NewUserText, MessageBoxButton.OK, MessageBoxImage.Warning);
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
        private void CreateNewUser()
        {
            try
            {
                if (string.IsNullOrEmpty(adminfields.NuserName))
                {
                    RsDialogBox.ShowMsg(EnterUText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (adminfields.NuserName.Length < 4)
                {
                    RsDialogBox.ShowMsg("Please enter a minimum of 4 characters as a username.", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(adminfields.Email) || !_utility.IsEmailValid(adminfields.Email))
                {
                    RsDialogBox.ShowMsg(EnterValidMailText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(adminfields.Npassword) || string.IsNullOrEmpty(adminfields.NConformPassword))
                {
                    RsDialogBox.ShowMsg(EnterCPText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!_utility.IsConformPassword(adminfields.Npassword, adminfields.NConformPassword))
                {
                    RsDialogBox.ShowMsg(PasswordDonotMatchText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!HasUpperAndLowerCase(adminfields.Npassword))
                {
                    RsDialogBox.ShowMsg(PasswordTemplateText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                //if (_utility.IsUserExists(adminfields.NuserName, adminfields.Npassword))
                //{
                //    RsDialogBox.ShowMsg("The username already exists. Please use a different username.", Common.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return;
                //}

                // Assign role ID based on selection
                adminfields.Userroleid = adminfields.IsAdminRole ? 101 : adminfields.IsUserRole ? 102 : 0;

                if (adminfields.Userroleid == 0)
                {
                    RsDialogBox.ShowMsg(SelectUserRoleText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Add the new user
                adminfields.Isactive = Common.isActive;
                string isAddUserSuccess = _utility.IsSucessAddNewuser(adminfields);

                if (isAddUserSuccess == "Success")
                {
                    RsDialogBox.ShowMsg(UserCreatedText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Information);
                    ResetNewUserFields();
                }
                else if (isAddUserSuccess.Contains("Email"))
                {
                    RsDialogBox.ShowMsg("Email already existed ,please enter valid Email", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (isAddUserSuccess.Contains("UserName"))
                {
                    RsDialogBox.ShowMsg("UserName already existed ,please enter valid UserName", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    RsDialogBox.ShowMsg(FailedUserCreatedText, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(CreateNewUser));
            }
        }
        private void ResetNewUserFields()
        {
            adminfields.NuserName = string.Empty;
            adminfields.Npassword = string.Empty;
            adminfields.NConformPassword = string.Empty;
            adminfields.Email = string.Empty;
            adminfields.IsAdminRole = false;
            adminfields.IsUserRole = false;
        }
        private bool HasUpperAndLowerCase(string Npassword)
        {
            if (string.IsNullOrEmpty(Npassword)) return false;

            bool hasUpper = Npassword.Any(char.IsUpper);
            bool hasLower = Npassword.Any(char.IsLower);
            bool hasNumber = Npassword.Any(char.IsNumber);
            bool hasSpecial = Npassword.Any(ch => char.IsPunctuation(ch) || char.IsSymbol(ch));

            return hasUpper && hasLower && hasNumber && hasSpecial;
        }
        public bool DeleteFunction()
        {
            bool IsDelete = false;
            ObservableCollection<ManageUserEntity> userSelectedData = null;
            try
            {
                if (userSelectedData == null)
                {
                    userSelectedData = new ObservableCollection<ManageUserEntity>();
                    userSelectedData = manageUser.ManageUserCollection;
                    if (userSelectedData.Count > 0)
                    {
                        foreach (ManageUserEntity Item in userSelectedData)
                        {
                            if (Item.IsSelected)
                            {
                                string UserId = Item.Userid;
                                string UserName = Item.Username;
                                IsDelete = _utility.IsDeleteUserData(UserId, UserName);
                            }
                        }
                        LoadUserData();
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(DeleteFunction));
            }
            return IsDelete;
        }
        public bool SaveFunction(ManageUserEntity mode)
        {
            bool IsSave = false;
            ObservableCollection<ManageUserEntity> userSelectedData = null;
            try
            {
                if (userSelectedData == null)
                {
                    userSelectedData = new ObservableCollection<ManageUserEntity>();
                    userSelectedData = manageUser.ManageUserCollection;
                    if (userSelectedData.Count > 0)
                    {
                        foreach (ManageUserEntity Item in userSelectedData)
                        {
                            if (Item.IsSelected)
                            {
                                string UserId = Item.Userid;
                                string UserName = Item.Username;
                                IsSave = _utility.IsSaveUserData(mode);
                            }
                        }

                        if (IsSave)
                            LoadUserData();
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SaveFunction));
            }
            return IsSave;
        }
        private void DeleteUsersFunction()
        {
            DeleteFunction();
        }
        private string EncryptPassword(string plainText)
        {
            string encryptionKey = "YourSecureKey12345"; // Use a secure and unique key.
            byte[] keyBytes = Encoding.UTF8.GetBytes(encryptionKey.PadRight(32)); // Ensure 256-bit key length.
            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                aes.GenerateIV();
                byte[] iv = aes.IV;
                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                    byte[] result = new byte[iv.Length + cipherBytes.Length];
                    Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                    Buffer.BlockCopy(cipherBytes, 0, result, iv.Length, cipherBytes.Length);
                    return Convert.ToBase64String(result);
                }
            }
        }
        private ObservableCollection<ManageUserEntity> _manageUserCollection;
        private ManageUserEntity _selectedUser;
        public List<ManageUserEntity> DefaultUserData = new List<ManageUserEntity>();
        public List<ManageUserEntity> DefaultUserData2 = new List<ManageUserEntity>();
        public Func<Admin> GetAdminfiledsHandler { get; set; }
        public void LoadUserData()
        {
            this.adminfields = GetAdminfiledsHandler();
            ObservableCollection<ManageUserEntity> userCollection = null;
            try
            {
                if (userCollection == null)
                {
                    userCollection = new ObservableCollection<ManageUserEntity>();
                    var userCollections = _utility.getUserCollection();
                    if (userCollections.Count > 0)
                    {
                        foreach (var user in userCollections)
                        {
                            //if (string.Equals(user.UserType, AdminText))
                            //{
                            //    if (user.Username == adminfields.UserName)
                            //    {
                            //        userCollection.Add(user);
                            //    }
                            //}
                            if (user.Username == adminfields.UserName)
                            {

                            }
                            else
                            {
                                userCollection.Add(user);
                            }
                        }


                        // Get list of previously selected user IDs
                        var selectedIds = manageUser.ManageUserCollections
                            .Where(u => u.IsSelected)
                            .Select(u => u.Userid)
                            .ToList();


                        // Replace the collection
                        manageUser.ManageUserCollections = userCollection;


                        if (selectedIds.Count > 0)
                        {
                            foreach (var a in manageUser.ManageUserCollections)
                            {
                                if (a.Userid == selectedIds[0])
                                {
                                    a.IsSelected = true;
                                }
                                else
                                {
                                    a.IsSelected = false;
                                }
                            }
                        }


                        if (!manageUser.ManageUserCollections.Any(u => u.IsSelected) && manageUser.ManageUserCollections.Count > 0)
                        {
                            manageUser.ManageUserCollections[0].IsSelected = true;
                        }
                        //if (manageUser.ManageUserCollections.Count>0)
                        //{
                        //    foreach(var a in manageUser.ManageUserCollections)
                        //    {
                        //        if(a.IsSelected == true)
                        //        {
                        //            foreach (var ab in userCollections)
                        //            {
                        //                if (ab.Userid==a.Userid)
                        //                {
                        //                    ab.IsSelected = true;
                        //                }

                        //            }
                        //        }
                        //    }
                        //}

                        //manageUser.ManageUserCollections = userCollections;
                        if(DefaultUserData.Count==0)
                        {
                            DefaultUserData = manageUser.ManageUserCollections
                                                                          .Select(u => new ManageUserEntity
                                                                          {
                                                                              // copy all the properties one by one
                                                                              Username = u.Username,
                                                                              Password = u.Password,
                                                                              Email = u.Email,
                                                                              IsSelected = u.IsSelected,
                                                                              UserType = u.UserType,

                                                                          })
                                                                           .ToList();
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadUserData));
            }
        }
        public void LoadManageUserDefault()
        {
            LoadUserData();
        }
    }
}
