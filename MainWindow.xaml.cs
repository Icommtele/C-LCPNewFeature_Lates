using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CommonLib;
using LCPInfrastructure;
using LCPReportingSystem.Model;
using LCPReportingSystem.RsDialogMessageBox;
using LCPReportingSystem.ViewModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static MaterialDesignThemes.Wpf.Theme;
namespace LCPReportingSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mvm;
        string msgEnterUsername = "Please enter a username.";
        string msgEnterValidEmail = "Please enter a valid email address.";    
        string msgSelectUserRole = "Please select a user role.";
        public int ExerciseDataStartId { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Rememberme)
            {
                txtUserName.Text = Properties.Settings.Default.SavedUsername;
                txtUserpassword.Password = Properties.Settings.Default.SavedPassword;
                RememberMe_checkbox.IsChecked = true;
            }
            mvm = new MainWindowViewModel(this);
            mvm.exerciseinsertDataHandler = GetExerciseInfo;
            mvm.GetSavedUserdataHandler = SaveUserSavedDetails;
            mvm.GetPasswordMatchStatusHandler = GetPasswordMatchStatus;
            this.DataContext=mvm;   
            txtUserName.Focus();
        }

        private bool GetPasswordMatchStatus()
        {
            return IsPasswordValid;
        }

        private void SaveUserSavedDetails(string username, string password)
        {
            if (RememberMe_checkbox.IsChecked == true)
            {
                Properties.Settings.Default.SavedUsername = username;
                Properties.Settings.Default.SavedPassword = password;
                Properties.Settings.Default.Rememberme = true;
            }
            else
            {
                Properties.Settings.Default.SavedUsername = string.Empty;
                Properties.Settings.Default.SavedPassword = string.Empty;
                Properties.Settings.Default.Rememberme = false;
            }

            Properties.Settings.Default.Save(); // Apply changes
        }

        private void Exercise_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                ExerciseWindowPopup.Visibility = Visibility.Visible;
                ExerciseWindowPopup.IsOpen = true;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(Exercise_checkbox_Checked));
            }
        }

         public ExerciseDataModel GetExerciseInfo()
         {
            try
            {
                if(ExerciseType.Text.Length>0)
                {
                    ExerciseDataModel EDM = new ExerciseDataModel(ExerciseType.Text, ExerciseDescriptionTextbox.Text, DateTime.Now, null);
                    return EDM;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetExerciseInfo));
            }
            return null;
         }

        private void Save_Exercise_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ExerciseWindowPopup.Visibility = Visibility.Collapsed;
                ExerciseWindowPopup.IsOpen = false;
                if (ExerciseType.Text.Length > 0)
                {
                    if (ExerciseType.Text.Length >= 4)
                    {
                        
                        RsDialogBox.ShowMsg("Data Saved Successfully", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        RsDialogBox.ShowMsg("Enter atleast 4 charecters", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                        ExerciseWindowPopup.Visibility = Visibility.Visible;
                        ExerciseWindowPopup.IsOpen = true;
                    }
                }
                else
                {
                    RsDialogBox.ShowMsg("Please enter Exercise Type", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ExerciseWindowPopup.Visibility = Visibility.Visible;
                    ExerciseWindowPopup.IsOpen = true;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(Save_Exercise_Click));
            }
        }

        private void Skip_Exercise_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ExerciseType.Clear();
                ExerciseDescriptionTextbox.Clear(); 
                ExerciseWindowPopup.Visibility = Visibility.Collapsed;
                ExerciseWindowPopup.IsOpen = false;
                Exercise_checkbox.IsChecked = false;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(Skip_Exercise_Click));
            }
        }
        private static readonly Regex _invalidCharactersRegex = new Regex("[^a-zA-Z0-9 ]");
        private void ExerciseType_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (_invalidCharactersRegex.IsMatch(ExerciseType.Text))
                {
                    MessageBox.Show("Special characters are not allowed.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ExerciseType_TextChanged));
            }       
        }

        private void ToggleVisibilityButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Dispatcher.Invoke(new Action(() => 
            {
                PasswordVisibletextBox.Visibility = Visibility.Visible;
                txtUserpassword.Visibility = Visibility.Collapsed;
                eyeIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;

            }));
          
        }

        private void ToggleVisibilityButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                PasswordVisibletextBox.Visibility = Visibility.Collapsed;
                txtUserpassword.Visibility = Visibility.Visible;
                eyeIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;

            }));
        }

        private void RememberMe_checkbox_Checked(object sender, RoutedEventArgs e)
        {

        }
        public void Login()
        {
            try
            {
                Admin adminfields = new Admin();
                adminfields.UserName = txtUserName.Text;
                adminfields.Password = txtUserpassword.Password;
                mvm.AdminLogin(adminfields);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ExerciseType_TextChanged));
            }
        }
        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            
            Login();
        }
        public bool IsPasswordValid = false;
        private void txtUserpassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordVisibletextBox.Text = txtUserpassword.Password.ToString();
            string password = txtUserpassword.Password;
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

            //// Optional: Sync with visible TextBox if showing password
            //if (PasswordVisibletextBox.Visibility == Visibility.Visible)
            //{
            //    PasswordVisibletextBox.Text = password;
            //}
            IsPasswordValid = isLengthValid && hasLower && hasUpper && hasDigit && hasSpecial;

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Enter)
                {
                    if(mvm==null && mvm.adminfields==null)
                    {
                        return;
                    }

                    if (mvm.adminfields.IsDevicePopupEnable == true)
                    {
                        var devices = mvm.adminfields.DeviceCollection;
                        if (devices.Count > 0)
                        {
                            devices[0].IsChecked = true;
                        }
                        mvm.SelectDevice();
                    }
                    else
                    {
                        Login();
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(Window_KeyDown));
            }
        }

        private void RadioButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                mvm.SelectDevice();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RadioButton_MouseDoubleClick));
            }
        }

        int userRoleID = 0;
        private void CreateNewUser()
        {
            try
            {
                if(IsPasswordValid)
                {
                    if (string.IsNullOrEmpty(txtNewUsernameSuper.Text))
                    {
                        RsDialogBox.ShowMsg(msgEnterUsername, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    if (txtNewUsernameSuper.Text.Length < 4)
                    {
                        RsDialogBox.ShowMsg("Please enter a minimum of 4 characters as a username.", UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(txtNewMail.Text) || !mvm._utility.IsEmailValid(txtNewMail.Text))
                    {
                        RsDialogBox.ShowMsg(msgEnterValidEmail, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                 
                    if (userRoleID == 0)
                    {
                        RsDialogBox.ShowMsg(msgSelectUserRole, UsageConstants.AddNewUser, MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    Admin UsercreatedbySuperAdmin = new Admin
                    {
                        NuserName = txtNewUsernameSuper.Text,
                        Npassword = txtUserpasswordSuper.Password.ToString(),
                        NConformPassword = txtUserpasswordSuper.Password.ToString(),
                        Email = txtNewMail.Text,
                        Userroleid = userRoleID,
                        Isactive = Common.isActive,
                        UserName = txtNewUsernameSuper.Text,
                        Password= txtUserpasswordSuper.Password.ToString()
                        
                    };

                    string isAddUserSuccess = mvm._utility.IsSucessAddNewuser(UsercreatedbySuperAdmin);

                    if (isAddUserSuccess== "Success")
                    {
                        SuperAdminPanel.Visibility = Visibility.Collapsed;    
                        mvm.AdminLogin(UsercreatedbySuperAdmin);
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
        private void btnNewUserCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateNewUser();
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

        private void txtUserpasswordSuper_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordRulesPanelSuper.Visibility = Visibility.Visible;
            PasswordVisibletextBoxSuper.Text = txtUserpasswordSuper.Password.ToString();
            string password = txtUserpasswordSuper.Password;
            bool isLengthValid = password.Length >= 6;
            bool hasLower = Regex.IsMatch(password, "[a-z]");
            bool hasUpper = Regex.IsMatch(password, "[A-Z]");
            bool hasDigit = Regex.IsMatch(password, @"\d");
            bool hasSpecial = Regex.IsMatch(password, @"[@$!%*?]");

            // Update TextBlock colors
            RuleLengthS.Foreground = isLengthValid ? Brushes.Green : Brushes.Red;
            RuleLowerS.Foreground = hasLower ? Brushes.Green : Brushes.Red;
            RuleUpperS.Foreground = hasUpper ? Brushes.Green : Brushes.Red;
            RuleDigitS.Foreground = hasDigit ? Brushes.Green : Brushes.Red;
            RuleSpecialS.Foreground = hasSpecial ? Brushes.Green : Brushes.Red;

            //// Optional: Sync with visible TextBox if showing password
            //if (PasswordVisibletextBox.Visibility == Visibility.Visible)
            //{
            //    PasswordVisibletextBox.Text = password;
            //}
            IsPasswordValid = isLengthValid && hasLower && hasUpper && hasDigit && hasSpecial;
        }

        private void eyeIconSuper_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
         
            Dispatcher.Invoke(new Action(() =>
            {
                PasswordVisibletextBoxSuper.Visibility = Visibility.Visible;
                txtUserpasswordSuper.Visibility = Visibility.Collapsed;
                eyeIconSuper.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;

            }));

        }

        private void eyeIconSuper_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                PasswordVisibletextBoxSuper.Visibility = Visibility.Collapsed;
                txtUserpasswordSuper.Visibility = Visibility.Visible;
                eyeIconSuper.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;

            }));
        }
    }
}
