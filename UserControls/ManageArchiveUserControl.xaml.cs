using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CommonLib;
using LCPInfrastructure;
using LCPReportingSystem.ViewModel;


namespace LCPReportingSystem.UserControls
{
    /// <summary>
    /// Interaction logic for ManageArchiveUserControl.xaml
    /// </summary>
    public partial class ManageArchiveUserControl : UserControl
    {
       public ManageArchiveViewModel manageArchiveVM;
  
        string saveFilePath = string.Empty;
        public ManageArchiveUserControl()
        {
            InitializeComponent();
            try
            {
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ManageArchive");
                if (Directory.Exists(folderPath))               
                    FileExplorerMenu.Visibility = Visibility.Visible;                
                else                
                    FileExplorerMenu.Visibility = Visibility.Collapsed;
                
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ManageArchiveUserControl));
            }
            manageArchiveVM = new ManageArchiveViewModel();
            manageArchiveVM.ArchiveExploreVisibilityHandler = SetVisibilityForArchiveExplorer;
            manageArchiveVM.SetHeaderHandler = SetHeader;
            manageArchiveVM.GetRowIDHandler= GetSelectedRowId;
            this.DataContext = manageArchiveVM;
            cmbSubsystem.SelectedIndex = 0;
            manageArchiveVM.archive.IsNonTrap = true;
        }
        private List<ArchiveData> GetSelectedRowId()
        {
            List<ArchiveData> selectedItems = new List<ArchiveData>();
            try
            {
                if(ShowReport.SelectedItems!=null && ShowReport.SelectedItems.Count>0)
                {
                    selectedItems = ShowReport.SelectedItems.Cast<ArchiveData>().ToList();
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSelectedRowId));
            }
            return selectedItems;
        }
        private void SetHeader(bool status)
        {
            try
            {
                if (status)
                {
                    ParameterColumn.Header = "Trap Name";
                    ParameterValueColumn.Header = "Trap Group";
                }
                else
                {
                    ParameterColumn.Header = "Parameter Name";
                    ParameterValueColumn.Header = "Parameter Value";
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SetHeader));
            }

        }
        private void SetVisibilityForArchiveExplorer()
        {
            try
            {
                if (FileExplorerMenu.Visibility == Visibility.Collapsed)
                {
                    FileExplorerMenu.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SetVisibilityForArchiveExplorer));
            }
        }      
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is Button button && button.Tag is string filePath && File.Exists(filePath))
                {
                    FileEditor.Clear();
                    txtfileNameLabel.Content = string.Empty;

                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".zip")
                    {
                        try
                        {
                            using (ZipArchive archive = ZipFile.OpenRead(filePath))
                            {
                                ZipArchiveEntry entry = archive.Entries.FirstOrDefault();
                                if (entry != null)
                                {
                                    using (StreamReader reader = new StreamReader(entry.Open()))
                                    {
                                        FileEditor.Text = reader.ReadToEnd();
                                    }

                                    txtfileNameLabel.Content = entry.FullName; // Show file inside ZIP
                                    saveFilePath= entry.FullName;
                                }
                                else
                                {
                                    MessageBox.Show("No files found in the ZIP archive.", "ZIP Archive Check", MessageBoxButton.OK, MessageBoxImage.Warning);
                                    return;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LCPLogUtils.LogException(ex, GetType().Name, nameof(OpenFile_Click));
                            return;
                        }
                    }
                    else
                    {
                        try
                        {
                            FileEditor.Text = File.ReadAllText(filePath);
                            txtfileNameLabel.Content = Path.GetFileName(filePath);
                            saveFilePath = filePath;                                // Show normal file name
                        }
                        catch (Exception ex)
                        {
                            LCPLogUtils.LogException(ex, GetType().Name, nameof(OpenFile_Click));
                            return;
                        }
                    }

                    EdittxtFilePanel.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(OpenFile_Click));
            }

        }
        private void CopyPath_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is Button button && button.Tag is string path)
                {
                    try
                    {
                        Clipboard.SetText(path);
                        MessageBox.Show("Path copied to clipboard:\n" + path, "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to copy path.\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                LCPLogUtils.LogException(ex, GetType().Name, nameof(CopyPath_Click));
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FileExplorerBoarder.Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(btnCancel_Click));
            }
        }
        private void FileExplorerMenu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FileExplorerBoarder.Visibility == Visibility.Visible)
                {
                    FileExplorerBoarder.Visibility = Visibility.Collapsed;
                }
                else
                {

                    FileListView.ItemsSource = null;
                   // string folderPath = @"C:\ManageArchive";
                    string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ManageArchive");
                    if (!Directory.Exists(folderPath))
                    {
                        MessageBox.Show($"Folder not found :{folderPath}", "ZIP Archive Info", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;                       
                    }

                   // var files = Directory.GetFiles(folderPath);
                    var files = Directory.GetFiles(folderPath, "*.txt", SearchOption.AllDirectories);
                    var fileItems = new ObservableCollection<FileExplorerModel>
                    (
                         Directory.GetFiles(folderPath, "*.txt", SearchOption.AllDirectories).Select((path, index) => new FileExplorerModel
                         {
                             SerialNo = index + 1,
                             FileName = Path.GetFileName(path),
                             CopyPath = path,
                             FilePath = path
                         })
                    );

                    FileListView.ItemsSource = fileItems;
                    FileExplorerBoarder.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(FileExplorerMenu_Click));

            }
        }
        private void btnCanceltxtFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EdittxtFilePanel.Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(btnCanceltxtFile_Click));

            }
        }
        private void btnSavetxtFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath = saveFilePath; //txtfileNameLabel.Content?.ToString();
                if (!string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath))
                {
                    File.WriteAllText(filePath, FileEditor.Text);
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Invalid file path or file does not exist.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(btnSavetxtFile_Click));
            }
        }
        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FiltersBorder.Visibility == Visibility.Visible)
                { FiltersBorder.Visibility = Visibility.Collapsed; return; }

                if (FiltersBorder.Visibility == Visibility.Collapsed)
                { FiltersBorder.Visibility = Visibility.Visible; return; }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(FilterButton_Click));
            }
        }   
        private void cmbSubsystem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (cmbSubsystem.SelectedItem != null)
                {
                    var selectedItem = cmbSubsystem.SelectedItem as ComboBoxItem;
                    var viewModel = DataContext as ManageArchiveViewModel;
                    if (string.Equals(selectedItem.Content.ToString(), UsageConstants.DieselGenerator1Text))
                    {
                        if (viewModel?.IDgCommand?.CanExecute(UsageConstants.DieselGenerator1Text) == true)
                        {
                            viewModel.IDgCommand.Execute(UsageConstants.DieselGenerator1Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.DieselGenerator2Text))
                    {
                        if (viewModel?.IDgCommand?.CanExecute(UsageConstants.DieselGenerator2Text) == true)
                        {
                            viewModel.IDgCommand.Execute(UsageConstants.DieselGenerator2Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Radio1Text))
                    {
                        if (viewModel?.IRadioCommand?.CanExecute(UsageConstants.Radio1Text) == true)
                        {
                            viewModel.IRadioCommand.Execute(UsageConstants.Radio1Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Radio2Text))
                    {
                        if (viewModel?.IRadioCommand?.CanExecute(UsageConstants.Radio2Text) == true)
                        {
                            viewModel.IRadioCommand.Execute(UsageConstants.Radio2Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Switch1Text))
                    {
                        if (viewModel?.ISwitchCommand?.CanExecute(UsageConstants.Switch1Text) == true)
                        {
                            viewModel.ISwitchCommand.Execute(UsageConstants.Switch1Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.Switch2Text))
                    {
                        if (viewModel?.ISwitchCommand?.CanExecute(UsageConstants.Switch2Text) == true)
                        {
                            viewModel.ISwitchCommand.Execute(UsageConstants.Switch2Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.UPS1Text))
                    {
                        if (viewModel?.IUpsCommand?.CanExecute(UsageConstants.UPS1Text) == true)
                        {
                            viewModel.IUpsCommand.Execute(UsageConstants.UPS1Text);
                        }
                    }
                    else if (string.Equals(selectedItem.Content.ToString(), UsageConstants.UPS2Text))
                    {
                        if (viewModel?.IUpsCommand?.CanExecute(UsageConstants.UPS2Text) == true)
                        {
                            viewModel.IUpsCommand.Execute(UsageConstants.UPS2Text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(cmbSubsystem_SelectionChanged));
            }
        }
    }
}
