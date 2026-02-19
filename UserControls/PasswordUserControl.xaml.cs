using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using static MaterialDesignThemes.Wpf.Theme;

namespace LCPReportingSystem.UserControls
{
    /// <summary>
    /// Interaction logic for PasswordUserControl.xaml
    /// </summary>
    public partial class PasswordUserControl : UserControl
    {
        public string UserPassword
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("UserPassword", typeof(string), typeof(PasswordUserControl), new PropertyMetadata(string.Empty));
        public PasswordUserControl()
        {
            InitializeComponent();
        }
        private bool isSyncing = false;
        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            UserPassword = txtPassword.Password.ToString();
            txtPassword.Focus();
            txtPassword.TabIndex = 1;
           PasswordVisibletextBox.Text= txtPassword.Password.ToString();
        }

        private void ToggleVisibilityButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PasswordVisibletextBox.Visibility = Visibility.Visible;
            txtPassword.Visibility = Visibility.Collapsed;
            eyeIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;
        }

        private void ToggleVisibilityButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PasswordVisibletextBox.Visibility = Visibility.Collapsed;
            txtPassword.Visibility = Visibility.Visible;
            eyeIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;
        }

        
    }
}
