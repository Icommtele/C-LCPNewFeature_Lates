using LCPReportingSystem.ViewModel;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.Model
{
    public class ManageUser : ViewModelBase
    {
        string _userid;
        string _username;
        private bool _isselected;
        private bool _isCreateUserPopupOpen;


        public ObservableCollection<ManageUserEntity> _manageUserCollection = new ObservableCollection<ManageUserEntity>();
        public ManageUserEntity _selectedUser = new ManageUserEntity();
        public string UserId
        {
            get { return _userid; }
            set
            {
                _userid = value;
                OnPropertyChanged(nameof(UserId));
            }
        }
        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public bool IsSelected
        {
            get { return _isselected; }
            set 
            {
                _isselected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }
        public bool IsCreateUserPopupOpen
        {
            get { return _isCreateUserPopupOpen; }
            set
            {
                _isCreateUserPopupOpen = value;
                OnPropertyChanged(nameof(IsCreateUserPopupOpen));
            }
        }
        public ObservableCollection<ManageUserEntity> ManageUserCollection
        {
            get { return _manageUserCollection; }
            set
            {
                _manageUserCollection = value;
                OnPropertyChanged(nameof(ManageUserCollection));
            }
        }
        public ObservableCollection<ManageUserEntity> ManageUserCollections
        {
            get => _manageUserCollection;
            set { _manageUserCollection = value; OnPropertyChanged(nameof(ManageUserCollections)); }
        }

        public ManageUserEntity SelectedUser
        {
            get => _selectedUser;
            set { _selectedUser = value; OnPropertyChanged(nameof(SelectedUser)); }
        }
    }
}
