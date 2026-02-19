using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LCPReportingSystem.Model;
using Path = System.IO.Path;
using System.Reflection;


namespace LCPReportingSystem.View
{
    /// <summary>
    /// Interaction logic for AboutLCPWindow.xaml
    /// </summary>
    public partial class AboutLCPWindow : Window
    {
        public List<ChecksumModel> MibFilesInfo { get; set; }
        private Dictionary<string, string> originalChecksums = new Dictionary<string, string>();
        private Dictionary<string, string> originalChecksumsDefault = new Dictionary<string, string>();
        public AboutLCPWindow()
        {
            InitializeComponent();
            DataContext = this;
            LoadCheckSum();
            LoadMibFiles();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Version.Text = "Version : " + version;
        }
      

        private void LoadCheckSum()
        {
            originalChecksumsDefault["Diesel Generator"] = "5dcf231a5ae43736d3ec0ddafe525713";
            originalChecksumsDefault["UPS"] = "4e8e1b8fbffc992ea86245282800a308";
            originalChecksumsDefault["Radio"] = "88b6c00bcb5c2018d5a580b57c1a0e02";
           // Version=Setting.DefaultStyleKeyProperty.Name;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void LoadMibFiles()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            MibFilesInfo = new List<ChecksumModel>
            {
               // new ChecksumModel { Name = "Diesel Generator", FilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Settings\MIBFiles\DieselGenerator.mib"},
     
               // //new ChecksumModel { Name = "Radio", FilePath = @"C:\MIBs\Radio.mib" },
               // new ChecksumModel { Name = "UPS", FilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Settings\MIBFiles\UPS.mib"}, 
               //// new ChecksumModel { Name = "Switch", FilePath = @"C:\MIBs\Switch.mib" }
               //new ChecksumModel { Name = "Radio", FilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Settings\MIBFiles\Radio.mib"},
               new ChecksumModel
    {
        Name = "Diesel Generator",
        FilePath = Path.Combine(
            baseDir,
            "Settings",
            "MIBFiles",
            "DieselGenerator.mib")
    },

    new ChecksumModel
    {
        Name = "UPS",
        FilePath = Path.Combine(
            baseDir,
            "Settings",
            "MIBFiles",
            "UPS.mib")
    },

    new ChecksumModel
    {
        Name = "Radio",
        FilePath = Path.Combine(
            baseDir,
            "Settings",
            "MIBFiles",
            "Radio.mib")
    }
            };

            foreach (var mib in MibFilesInfo)
            {
                if (File.Exists(mib.FilePath))
                {
                    string checksum = ComputeMD5(mib.FilePath);
                    mib.Checksum = checksum;
                    mib.Status = (originalChecksumsDefault[mib.Name] == mib.Checksum)
                                 ? "OK"
                                 : "Checksum mismatched";
                    originalChecksums[mib.FilePath] = checksum;

                    //// Watch for file changes
                    //FileSystemWatcher watcher = new FileSystemWatcher(Path.GetDirectoryName(mib.FilePath))
                    //{
                    //    Filter = Path.GetFileName(mib.FilePath),
                    //    NotifyFilter = NotifyFilters.LastWrite
                    //};

                    //watcher.Changed += (s, e) =>
                    //{
                    //    Application.Current.Dispatcher.Invoke(() =>
                    //    {
                    //        string newChecksum = ComputeMD5(mib.FilePath);
                    //        mib.Checksum = newChecksum;
                    //        mib.Status = (newChecksum == originalChecksums[mib.FilePath])
                    //                     ? "OK"
                    //                     : "MIB file changed!";
                    //    });
                    //};
                    //watcher.EnableRaisingEvents = true;
                }
                else
                {
                    mib.Checksum = "File not found!";
                    mib.Status = "Missing";
                }
            }
        }
        public  string ComputeMD5(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(stream);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
        //private void Hyperlink_Click(object sender, RoutedEventArgs e)
        //{
        //    if (sender is Hyperlink link && File.Exists(link.NavigateUri.LocalPath))
        //    {
        //        Process.Start(new ProcessStartInfo("notepad.exe", link.NavigateUri.LocalPath) { UseShellExecute = true });
        //    }
        //    else
        //    {
        //        MessageBox.Show("File not found!");
        //    }
        //}
    }
}
