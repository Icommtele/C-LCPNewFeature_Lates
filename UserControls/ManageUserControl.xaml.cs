using CommonLib;
using LCPInfrastructure;
using LCPReportingSystem.Model;
using LCPReportingSystem.RsDialogMessageBox;
using LCPReportingSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Controls.Button;

namespace LCPReportingSystem.UserControls
{
    /// <summary>
    /// Interaction logic for ManageUserControl.xaml
    /// </summary>
    public partial class ManageUserControl : UserControl
    {
        #region
        public ManageUserViewModel muvm;
        string msgEnterUsername = "Please enter a username.";
        string msgEnterValidEmail = "Please enter a valid email address.";
        string msgEnterConfirmPassword = "Please enter and confirm the password.";
        string msgPasswordsMismatch = "Passwords do not match.";
        string msgPasswordPolicy = "Password must contain uppercase, lowercase, a number, and a special character.";
        string msgSelectUserRole = "Please select a user role.";
        string msgUserCreated = "User created successfully.";
        string msgUserFailed = "Failed to create the user. \n Please Check Username or Password or Email are already exist.";
        string msgUserUpdated = "User Data Updated successfully.";
        string msgUserUpdateFailed = "Failed to update user data.\n email id  already exist.";

        int userRoleID = 0;
        #endregion

        public ManageUserControl()
        {
            InitializeComponent();
            muvm  = new ManageUserViewModel();
            this.DataContext = muvm;
           
        }      
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EditButton.Content.ToString() == "Set Default")
                {
                   
                    PasswordTextBox.IsEnabled = false;
                    EmailTextBox.IsEnabled = false;
                    UsertypeTextBox.IsEnabled = false;
                    EditButton.Content = "Edit";
                    
                    var selectedUser = UserNameListBox.SelectedItem as ManageUserEntity;
                    if (selectedUser != null)
                    {
                        UsernameTextBox.Text = selectedUser.Username;
                        PasswordTextBox.Text = selectedUser.Password;
                        EmailTextBox.Text = selectedUser.Email;
                        UsertypeTextBox.Text = selectedUser.UserType;
                        IsActiveTextBox.Text = selectedUser.Isactive;
                        CreationDateTextBox.Text = selectedUser.Creationdate;
                    }
                }
                else
                {
                   
                    PasswordTextBox.IsEnabled = true;
                    EmailTextBox.IsEnabled = true;
                    UsertypeTextBox.IsEnabled = true;
                    EditButton.Content = "Set Default";
                }
               
            }
            catch (Exception ex)
            {

                LCPLogUtils.LogException(ex, GetType().Name, nameof(EditButton_Click));
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UsernameTextBox.IsEnabled = false;
                PasswordTextBox.IsEnabled = false;
                EmailTextBox.IsEnabled = false;
                UsertypeTextBox.IsEnabled = false;
                EditButton.Content = "Edit";
                foreach (var item in UserNameListBox.Items)
                {
                    var selectedUser = item as ManageUserEntity;
                    if (selectedUser != null)
                    {
                        if (selectedUser.IsSelected)
                        {
                            //var selectedUser = UserNameListBox.SelectedItem as ManageUserEntity;
                            selectedUser.Password = PasswordTextBox.Text;
                            if (UsertypeTextBox.SelectedItem is ComboBoxItem selectedItem)
                            {
                                selectedUser.UserType=selectedItem.Content.ToString();
                            }                           
                            selectedUser.Email = EmailTextBox.Text;
                            selectedUser.Username = UsernameTextBox.Text;
                            //SaveAndDeleteHandler(selectedUser);
                            bool _status = muvm.SaveFunction(selectedUser);
                            if (_status)
                            {
                                
                                RsDialogBox.ShowMsg(msgUserUpdated, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Information);
                                var selectedUsers = UserNameListBox.SelectedItem as ManageUserEntity;
                                if (selectedUsers != null)
                                {
                                    foreach (var a in muvm.DefaultUserData)
                                    {
                                        if (a.Username.Equals(selectedUsers.Username))
                                        {
                                            UsernameTextBox.Text = selectedUsers.Username;
                                            PasswordTextBox.Text = selectedUsers.Password;
                                            EmailTextBox.Text = selectedUsers.Email;
                                            UsertypeTextBox.Text = selectedUsers.UserType;
                                            IsActiveTextBox.Text = selectedUsers.Isactive;
                                            CreationDateTextBox.Text = selectedUsers.Creationdate;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                RsDialogBox.ShowMsg(msgUserUpdateFailed, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Error);

                              
                                var selectedUsers = UserNameListBox.SelectedItem as ManageUserEntity;
                                if (selectedUsers != null)
                                {
                                    foreach(var a in muvm.DefaultUserData)
                                    {
                                        if(a.Username.Equals(selectedUsers.Username))
                                        {
                                            UsernameTextBox.Text = a.Username;
                                            PasswordTextBox.Text = a.Password;
                                            EmailTextBox.Text = a.Email;
                                            UsertypeTextBox.Text = a.UserType;
                                            IsActiveTextBox.Text = a.Isactive;
                                            CreationDateTextBox.Text = a.Creationdate;
                                        }
                                    }
                                    
                                }
                            }
                           // UserNameListBox.SelectedItem = selectedUser;
                        }
                    }

                    
                }
                if (muvm.manageUser.ManageUserCollections != null && muvm.manageUser.ManageUserCollections.Any())
                {
                    int index = muvm.manageUser.ManageUserCollections
                    .Select((item, i) => new { item, i })
                    .Where(x => x.item.IsSelected)
                    .Select(x => x.i)
                    .FirstOrDefault();
                    UserNameListBox.SelectedIndex = index;
                }
                                


            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SaveButton_Click));
            }
        }     

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               bool deleteStstus= muvm.DeleteFunction();
                if (deleteStstus)
                {
                    RsDialogBox.ShowMsg("User Data Deleted successfully.", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Information);
                    if (muvm.manageUser.ManageUserCollections != null && muvm.manageUser.ManageUserCollections.Any())
                    {
                        int index = muvm.manageUser.ManageUserCollections
                        .Select((item, i) => new { item, i })
                        .Where(x => x.item.IsSelected)
                        .Select(x => x.i)
                        .FirstOrDefault();
                        UserNameListBox.SelectedIndex = index;
                    }
                }
                else
                {
                    RsDialogBox.ShowMsg("Failed to Delete user data.", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(DeleteButton_Click));
            }
        }

        private void UserNameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                UserdataBorder.Visibility= Visibility.Visible;
                var selectedUser = UserNameListBox.SelectedItem as ManageUserEntity;
                
                if (selectedUser != null)
                {
                    UsernameTextBox.Text = selectedUser.Username;
                    PasswordTextBox.Text = selectedUser.Password;
                    EmailTextBox.Text = selectedUser.Email;
                    if(selectedUser.UserType.Contains("User"))
                    {
                        UsertypeTextBox.SelectedIndex = 0;   // Selects "User"                        
                    }
                    else
                    {
                        UsertypeTextBox.SelectedIndex = 1;   // Selects "Admin"
                    }                      

                    IsActiveTextBox.Text = selectedUser.Isactive;
                    CreationDateTextBox.Text = selectedUser.Creationdate;
                    selectedUser.IsSelected = true;
                    txtSelectedUser.Text = selectedUser.Username;
                    foreach (var a in muvm.manageUser.ManageUserCollections)
                    {
                        if (a.Username == selectedUser.Username)
                        {
                            a.IsSelected = true;
                        }
                        else
                        {
                            a.IsSelected = false;
                        }
                    }

                    PasswordTextBox.IsEnabled = false;
                    EmailTextBox.IsEnabled = false;
                    UsertypeTextBox.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(UserNameListBox_SelectionChanged));
            }
        }
    
        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateUserBorder.Visibility = Visibility.Visible;
                BtnCreateUser.Visibility = Visibility.Collapsed;
                PasswordRulesPanelSuper.Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(BtnCreateUser_Click));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                if ((string)btn.Content == "Cancel")
                {
                    ResetNewUserFields();
                    BtnCreateUser.Visibility = Visibility.Visible;
                    CreateUserBorder.Visibility = Visibility.Collapsed;
                    PasswordRulesPanelSuper.Visibility = Visibility.Collapsed;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(Button_Click));
            }
           
        }
        
        private void CreateNewUser()
        {
            try
            {
                if (IsPasswordValid)
                {
                    if (string.IsNullOrEmpty(txtNewUsername.Text))
                    {
                        RsDialogBox.ShowMsg(msgEnterUsername, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    if (txtNewUsername.Text.Length < 4)
                    {
                        RsDialogBox.ShowMsg("Please enter a minimum of 4 characters as a username.", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(txtNewMail.Text) || !muvm._utility.IsEmailValid(txtNewMail.Text))
                    {
                        RsDialogBox.ShowMsg(msgEnterValidEmail, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(txtNewPassword.Password.ToString()) ||
                        string.IsNullOrEmpty(txtNewConfirmPassword.Password.ToString()))
                    {
                        RsDialogBox.ShowMsg(msgEnterConfirmPassword, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    if (!muvm._utility.IsConformPassword(txtNewPassword.Password.ToString(),
                                                         txtNewConfirmPassword.Password.ToString()))
                    {
                        RsDialogBox.ShowMsg(msgPasswordsMismatch, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    if (!HasUpperAndLowerCase(txtNewPassword.Password.ToString()))
                    {
                        RsDialogBox.ShowMsg(msgPasswordPolicy, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    if (userRoleID == 0)
                    {
                        RsDialogBox.ShowMsg(msgSelectUserRole, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    Admin a = new Admin
                    {
                        NuserName = txtNewUsername.Text,
                        Npassword = txtNewPassword.Password.ToString(),
                        NConformPassword = txtNewConfirmPassword.Password.ToString(),
                        Email = txtNewMail.Text,
                        Userroleid = userRoleID,
                        Isactive = Common.isActive
                    };

                    string isAddUserSuccess = muvm._utility.IsSucessAddNewuser(a);

                    if (isAddUserSuccess == "Success")
                    {
                        RsDialogBox.ShowMsg(msgUserCreated, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Information);
                        ResetNewUserFields();
                        muvm.LoadUserData();
                        UserNameListBox.Items.Refresh();
                        CreateUserBorder.Visibility = Visibility.Collapsed;
                        if (muvm.manageUser.ManageUserCollections != null && muvm.manageUser.ManageUserCollections.Any())
                        {
                            UserNameListBox.SelectedIndex = muvm.manageUser.ManageUserCollections.Count - 1;
                        }
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
                        RsDialogBox.ShowMsg("Failed Create User", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
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
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(CreateNewUser));
            }
        }

        private bool HasUpperAndLowerCase(string Npassword)
        {
            try
            {
                if (string.IsNullOrEmpty(Npassword)) return false;

                bool hasUpper = Npassword.Any(char.IsUpper);
                bool hasLower = Npassword.Any(char.IsLower);
                bool hasNumber = Npassword.Any(char.IsNumber);
                bool hasSpecial = Npassword.Any(ch => char.IsPunctuation(ch) || char.IsSymbol(ch));

                return hasUpper && hasLower && hasNumber && hasSpecial;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(HasUpperAndLowerCase));
            }
            return false;
        }
        private void ResetNewUserFields()
        {
            try
            {
                txtNewUsername.Text = string.Empty;
                txtNewMail.Text = string.Empty;
                txtNewPassword.Password = string.Empty;
                txtNewPassword.Password = string.Empty;
                txtNewConfirmPassword.Password = string.Empty;
               
                RadiobuttonAdmin.IsChecked = false;
                RadiobuttonUser.IsChecked = false;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ResetNewUserFields));
            }
        }

        private void btnNewUserCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateNewUser();
            BtnCreateUser.Visibility = Visibility.Visible;
        }
            
      
        private void RadiobuttonAdmin_Checked(object sender, RoutedEventArgs e)
        {
            userRoleID = 101;
        }

        private void RadiobuttonUser_Checked(object sender, RoutedEventArgs e)
        {
            userRoleID = 102;
        }

        private void RadiobuttonAdmin_Unchecked(object sender, RoutedEventArgs e)
        {
            userRoleID = 0;
        }

        private void RadiobuttonUser_Unchecked(object sender, RoutedEventArgs e)
        {
            userRoleID = 0;
        }

        private void eyeIconSuper_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                PasswordVisibletextBoxSuper.Visibility = Visibility.Visible;
                txtNewPassword.Visibility = Visibility.Collapsed;
                eyeIconSuper.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;

            }));
        }

        private void eyeIconSuper_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           
            Dispatcher.Invoke(new Action(() =>
            {
                PasswordVisibletextBoxSuper.Visibility = Visibility.Collapsed;
                txtNewPassword.Visibility = Visibility.Visible;
                eyeIconSuper.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;

            }));
        }

      
        private void eyeIconConfirm_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                PasswordVisibleConfirmPassword.Visibility = Visibility.Visible;
                txtNewConfirmPassword.Visibility = Visibility.Collapsed;
                eyeIconSuper.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;

            }));
        }

        private void eyeIconConfirm_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                PasswordVisibleConfirmPassword.Visibility = Visibility.Collapsed;
                txtNewConfirmPassword.Visibility = Visibility.Visible;
                eyeIconSuper.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;

            }));
        }

        public bool IsPasswordValid = false;
       
        private void txtNewPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            try
            {
                PasswordVisibletextBoxSuper.Text = txtNewPassword.Password.ToString();
                PasswordRulesPanelSuper.Visibility = Visibility.Visible;
                string password = txtNewPassword.Password;
                bool isLengthValid = password.Length >= 6;
                bool hasLower = Regex.IsMatch(password, "[a-z]");
                bool hasUpper = Regex.IsMatch(password, "[A-Z]");
                bool hasDigit = Regex.IsMatch(password, @"\d");
                bool hasSpecial = Regex.IsMatch(password, @"[@$!%*?]");

                // Update TextBlock colors
                RuleLength.Foreground = isLengthValid ? Brushes.Green : Brushes.Red;
                RuleLower.Foreground = hasLower ? Brushes.Green : Brushes.Red;
                RuleUpper.Foreground = hasUpper ? Brushes.Green : Brushes.Red;
                RuleDigit.Foreground = hasDigit ? Brushes.Green : Brushes.Red;
                RuleSpecial.Foreground = hasSpecial ? Brushes.Green : Brushes.Red;

                IsPasswordValid = isLengthValid && hasLower && hasUpper && hasDigit && hasSpecial;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(txtNewPassword_PasswordChanged));
            }
        }

        private void txtUserpasswordSuper_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordVisibleConfirmPassword.Text = txtNewConfirmPassword.Password.ToString();
        }
    }
}
