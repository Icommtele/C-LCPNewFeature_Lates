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
using System.Windows.Shapes;
using LCPReportingSystem.ViewModel;
using LCPReportingSystem.Model;
using LCPInfrastructure;
using LCPReportingSystem.RsDialogMessageBox;
using System.Windows.Media.Animation;
using LCPReportingSystem.UserControls;
using CommonLib;
using System.ComponentModel;

namespace LCPReportingSystem.WindowForm
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public MainViewModel mn;
        private readonly  Admin adminFields;
        public Main(Admin admin = null)
        {
            InitializeComponent();

            try
            {
                if (UsageConstants.isAdmin)
                {
                    ManageUserMenuItem.Visibility = Visibility.Visible;
                }
                else
                {
                    ManageUserMenuItem.Visibility = Visibility.Collapsed;
                }


                mn = new MainViewModel(admin);
                adminFields = admin;

                mngUserControl.muvm.GetAdminfiledsHandler = sendAdminFields;
                mn.GetManagedArchiveDataHandler = ManageArchivectrl.manageArchiveVM.ManageArchiveLoadDefault;
                mn.GetSubSystemConfigViewHandler = SubsystemConfigctrl.scvm.LoadDefaultConfig;
                mn.GetDefaultGraphicalReportHandler= GraphicalReportCtrl.lineGraphViewModel.SetDeafaultGraphicalReport;
                mn.GetManageUserDataHandler = mngUserControl.muvm.LoadManageUserDefault;
                mn.GetReportUsercontrol = GetReportWindow;
               // mn.SetNetworkStatusHandler = SetNetworkStatus;



                CreateSubSystemCollection();
                this.DataContext = mn; 
                AttachListview();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(Main));
            }
        }

        public void SetNetworkStatus(string obj)
        {
            Dispatcher.Invoke(new Action(() => 
            {
                try
                {
                    networkPanel.Visibility = Visibility.Visible;
                    txtNetworkStatus.Text = obj;
                    if (obj.Contains("Connected"))
                    {
                        Manpagepanel.Opacity = 1;
                        txtNetworkStatus.Foreground=Brushes.White;
                        NetworkIcon.Kind=MaterialDesignThemes.Wpf.PackIconKind.Ethernet;
                        NetworkIcon.Foreground=Brushes.GreenYellow;
                    }
                    else
                    {
                        Manpagepanel.Opacity = 0.7;
                        txtNetworkStatus.Foreground = Brushes.Red;
                        NetworkIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.EthernetOff;
                        NetworkIcon.Foreground = Brushes.Red;
                    }
                }
                catch (Exception ex)
                {
                    LCPLogUtils.LogException(ex, GetType().Name, nameof(SetNetworkStatus));
                }

            }));
            
        }

        public Admin sendAdminFields()
        {
            try
            {
                if (adminFields != null)
                    return this.adminFields;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(sendAdminFields));
            }
            return null;
        }

        private void AttachListview()
        {
            try
            {
                AttachItemsSourceChanged(dgTrapListView);
                AttachItemsSourceChanged(dg2TrapListView);
                AttachItemsSourceChanged(UPS1TrapListView);
                AttachItemsSourceChanged(UPS2TrapListView);
                AttachItemsSourceChanged(Radio1TrapListView);
                AttachItemsSourceChanged(Radio2TrapListView);
                AttachItemsSourceChanged(Switch1TrapListView);
                AttachItemsSourceChanged(Switch2TrapListView);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(AttachListview));
            }

        }
        private void AttachItemsSourceChanged(ListView listView)
        {
            try
            {
                var dpd = DependencyPropertyDescriptor.FromProperty(ItemsControl.ItemsSourceProperty, typeof(ListView));
                if (dpd != null)
                {                   
                   dpd.AddValueChanged(listView, ItemsSourceChanged);                  
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(AttachItemsSourceChanged));
            }
        }
        private void CreateSubSystemCollection()
        {
            try
            {
              
                if (Common.SubsystemCollection.Count == 0)
                {
                    Common.SubsystemCollection["Diesel Generator2"] = "Diesel Generator2";
                    Common.SubsystemCollection["UPS2"] = "UPS2";
                    Common.SubsystemCollection["Radio2"] = "Radio2";
                    Common.SubsystemCollection["Switch2"] = "Switch2";
                }

                if (UsageConstants.SubsystemCollectionNumber.Count == 0)
                {                   

                    UsageConstants.SubsystemCollectionNumber[1] = IsSubSystem.DieselGenerator;
                    UsageConstants.SubsystemCollectionNumber[2]= IsSubSystem.UPS;
                    UsageConstants.SubsystemCollectionNumber[3]= IsSubSystem.Radio;
                    UsageConstants.SubsystemCollectionNumber[4]= IsSubSystem.Switch;
                    UsageConstants.SubsystemCollectionNumber[5]= IsSubSystem.Router;
                    UsageConstants.SubsystemCollectionNumber[6]= IsSubSystem.DieselGenerator2;
                    UsageConstants.SubsystemCollectionNumber[7]=IsSubSystem.UPS2;
                    UsageConstants.SubsystemCollectionNumber[8]= IsSubSystem.Radio2;
                    UsageConstants.SubsystemCollectionNumber[9]= IsSubSystem.Switch2;
                    UsageConstants.SubsystemCollectionNumber[10]=IsSubSystem.Router2;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(CreateSubSystemCollection));
            }


        }
        public void GetReportWindow(string Name,Admin _admin)
        {
            try
            {
                var reportUC = new ReportWindowUserControl(Name);
                ReportHost.Content = reportUC;
                mn.GetDefaultReportHandler = reportUC.reportWindowViewModel.SetDeFaultReport;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetReportWindow));
            }
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                ManageArchivectrl.EdittxtFilePanel.Visibility = Visibility.Collapsed;
                ManageArchivectrl.FileExplorerBoarder.Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(MenuItem_Click_1));
            }
        }

        private void btnTrapInfo_Click(object sender, RoutedEventArgs e)
        {
            TrapListInfo(dgTrapListView);            
        }

        private void btnTrapInfoDG2_Click(object sender, RoutedEventArgs e)
        {
            TrapListInfo(dg2TrapListView);          
        }

        private void btnTrapInfoUPS1_Click(object sender, RoutedEventArgs e)
        {
            TrapListInfo(UPS1TrapListView);           
        }

        private void btnTrapInfoUPS2_Click(object sender, RoutedEventArgs e)
        {
            TrapListInfo(UPS2TrapListView);            
        }

        private void btnTrapInfoRadio1_Click(object sender, RoutedEventArgs e)
        {
            TrapListInfo(Radio1TrapListView);           
        }

        private void btnTrapInfoRadio2_Click(object sender, RoutedEventArgs e)
        {
            TrapListInfo(Radio2TrapListView);           
        }

        private void btnTrapInfoSwitch1_Click(object sender, RoutedEventArgs e)
        {
            TrapListInfo(Switch1TrapListView);           
        }

        private void btnTrapInfoSwitch2_Click(object sender, RoutedEventArgs e)
        {
            TrapListInfo(Switch2TrapListView);
        }
        public void TrapListInfo(ListView lst)
        {
            try
            {
                List<TrapCountInfo> listTrapCountInfo = new List<TrapCountInfo>();

                var view = lst.ItemsSource as CollectionView;
                if (view != null)
                {
                    var trapList = view.Cast<TrapInfo>().ToList();

                    var grouped = trapList
                        .GroupBy(t => t.TrapName)
                        .Select(g => new
                        {
                            NotificationType = g.Key,
                            Count = g.Count()
                        })
                        .OrderByDescending(g => g.Count).ToList();

                    foreach (var item in grouped)
                    {
                        TrapCountInfo tf = new TrapCountInfo();
                        tf.NotificationType = item.NotificationType;
                        tf.TrapCount = item.Count;
                        listTrapCountInfo.Add(tf);
                    }
                    RsDialogBox.ShowMsg(listTrapCountInfo, "Trap Info");

                }
                else
                {
                    RsDialogBox.ShowMsg("Trap list is empty", "TrapInfo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(TrapListInfo));
            }
        }
        private void dgTrapListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //try
            //{
            //    ListView listView = sender as ListView;
            //    string ListvwName = listView.Name;

            //    if (string.Equals("dgTrapListView", ListvwName))
            //    {
            //        btnTrapInfoDG1.Visibility = Visibility.Visible;
            //    }
            //    else if (string.Equals("dg2TrapListView", ListvwName))
            //    {
            //        btnTrapInfoDG2.Visibility = Visibility.Visible;
            //    }
            //    else if (string.Equals("UPS1TrapListView", ListvwName))
            //    {
            //        btnTrapInfoUPS1.Visibility = Visibility.Visible;
            //    }
            //    else if (string.Equals("UPS2TrapListView", ListvwName))
            //    {
            //        btnTrapInfoUPS2.Visibility = Visibility.Visible;
            //    }
            //    else if (string.Equals("Radio1TrapListView", ListvwName))
            //    {
            //        btnTrapInfoRadio1.Visibility = Visibility.Visible;
            //    }
            //    else if (string.Equals("Radio2TrapListView", ListvwName))
            //    {
            //        btnTrapInfoRadio2.Visibility = Visibility.Visible;
            //    }
            //    else if (string.Equals("Switch2TrapListView", ListvwName))
            //    {
            //        btnTrapInfoSwitch2.Visibility = Visibility.Visible;
            //    }
            //    else if (string.Equals("Switch1TrapListView", ListvwName))
            //    {
            //        btnTrapInfoSwitch1.Visibility = Visibility.Visible;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    LCPLogUtils.LogException(ex, GetType().Name, nameof(dgTrapListView_SelectionChanged));
            //}
        }

        private void ItemsSourceChanged(object sender, EventArgs e)
        {
            try
            {
                ListView listView = sender as ListView;
                string ListvwName = listView.Name;

                if (string.Equals("dgTrapListView", ListvwName))
                {
                    btnTrapInfoDG1.Visibility = Visibility.Visible;
                }
                else if (string.Equals("dg2TrapListView", ListvwName))
                {
                    btnTrapInfoDG2.Visibility = Visibility.Visible;
                }
                else if (string.Equals("UPS1TrapListView", ListvwName))
                {
                    btnTrapInfoUPS1.Visibility = Visibility.Visible;
                }
                else if (string.Equals("UPS2TrapListView", ListvwName))
                {
                    btnTrapInfoUPS2.Visibility = Visibility.Visible;
                }
                else if (string.Equals("Radio1TrapListView", ListvwName))
                {
                    btnTrapInfoRadio1.Visibility = Visibility.Visible;
                }
                else if (string.Equals("Radio2TrapListView", ListvwName))
                {
                    btnTrapInfoRadio2.Visibility = Visibility.Visible;
                }
                else if (string.Equals("Switch2TrapListView", ListvwName))
                {
                    btnTrapInfoSwitch2.Visibility = Visibility.Visible;
                }
                else if (string.Equals("Switch1TrapListView", ListvwName))
                {
                    btnTrapInfoSwitch1.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ItemsSourceChanged));
            }
        }


    }
}
