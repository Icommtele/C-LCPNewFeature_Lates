using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCPReportingSystem.ViewModel;

namespace LCPReportingSystem.Model
{
    public class ManageArchive : ViewModelBase
    {
        private string _isdgactive = string.Empty;
        private string _isrouteractive = string.Empty;
        private string _isradioactive = string.Empty;
        private string _isswitchactive = string.Empty;
        private string _isupsactive = string.Empty;
        private string _pagedetails = string.Empty;

        private int _currentPage;
        private int _totalPages;
        private int _goToPageNumber;
        bool _isnontrap=true;
        bool _istrap;

        private bool? _isarchivehelpopupopen;
        private bool? _isarchiveFileExplorerpopupopen;

        private bool? _isnextpageenable;
        private bool? _ispreviouspageenable;
        bool _isarchiveviewenable;
        bool _isarchivenontrap;
        bool _isarchivetrap;

        private DateTime _seletedfromdate;
        private DateTime _seletedtodate;

        private DateTime _setfromdate;
        private DateTime _settodate;

        private ObservableCollection<ArchiveData> _archive = new ObservableCollection<ArchiveData>();
        //public ObservableCollection<FileExplorerModel> listFileExplorerData=new ObservableCollection<FileExplorerModel>();

        public string IsDgActive
        {
            get { return _isdgactive; }
            set
            {
                _isdgactive = value;
                OnPropertyChanged(nameof(IsDgActive));
            }
        }
        public string IsRouterActive
        {
            get { return _isrouteractive; }
            set
            {
                _isrouteractive = value;
                OnPropertyChanged(nameof(IsRouterActive));
            }
        }
        public string IsRadioActive
        {
            get { return _isradioactive; }
            set
            {
                _isradioactive = value;
                OnPropertyChanged(nameof(IsRadioActive));
            }
        }
        public string IsSwitchActive
        {
            get { return _isswitchactive; }
            set
            {
                _isswitchactive = value;
                OnPropertyChanged(nameof(IsSwitchActive));
            }
        }
        public string IsUpsActive
        {
            get { return _isupsactive; }
            set
            {
                _isupsactive = value;
                OnPropertyChanged(nameof(IsUpsActive));
            }
        }
        public string PageDetails
        {
            get { return _pagedetails; }
            set
            {
                _pagedetails = value;
                OnPropertyChanged(nameof(PageDetails));
            }
        }

        public int CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }
        public int TotalPage
        {
            get { return _totalPages; }
            set
            {
                _totalPages = value;
                OnPropertyChanged(nameof(TotalPage));
            }
        }

        
        public int GoToPageNumber
        {
            get { return _goToPageNumber; }
            set
            {
                _goToPageNumber = value;
                OnPropertyChanged(nameof(GoToPageNumber));
            }
        }
        public bool? IsArchiveHelPopupOpen
        {
            get { return _isarchivehelpopupopen; }
            set
            {
                _isarchivehelpopupopen = value;
                OnPropertyChanged(nameof(IsArchiveHelPopupOpen));
            }
        }
        //_isarchiveFileExplorerpopupopen


        public bool? IsArchiveFileExplorerPopupOpen
        {
            get { return _isarchiveFileExplorerpopupopen; }
            set
            {
                _isarchiveFileExplorerpopupopen = value;
                OnPropertyChanged(nameof(IsArchiveFileExplorerPopupOpen));
            }
        }



        public bool? IsNextPageEnable
        {
            get { return _isnextpageenable; }
            set
            {
                _isnextpageenable = value;
                OnPropertyChanged(nameof(IsNextPageEnable));
            }
        }
        public bool? IsPreviousPageEnable
        {
            get { return _ispreviouspageenable; }
            set
            {
                _ispreviouspageenable = value;
                OnPropertyChanged(nameof(IsPreviousPageEnable));
            }
        }
        public bool IsArchiveNonTrap
        {
            get { return _isarchivenontrap; }
            set
            {
                _isarchivenontrap = value;
                OnPropertyChanged(nameof(IsArchiveNonTrap));
            }
        }
        public bool IsArchiveTrap
        {
            get { return _isarchivetrap; }
            set
            {
                _isarchivetrap = value;
                OnPropertyChanged(nameof(IsArchiveTrap));
            }
        }
        public bool IsArchiveViewEnable
        {
            get { return _isarchiveviewenable; }
            set
            {
                _isarchiveviewenable = value;
                OnPropertyChanged(nameof(IsArchiveViewEnable));
            }
        }
        public bool IsNonTrap
        {
            get { return _isnontrap; }
            set
            {
                _isnontrap = value;
                OnPropertyChanged(nameof(IsNonTrap));
            }
        }
        public bool IsTrap
        {
            get { return _istrap; }
            set
            {
                _istrap = value;
                OnPropertyChanged(nameof(IsTrap));
            }
        }
        public DateTime SeletedFromDate
        {
            get { return _seletedfromdate; }
            set
            {
                _seletedfromdate = value;
                OnPropertyChanged(nameof(SeletedFromDate));
            }
        }

        public DateTime SeletedToDate
        {
            get { return _seletedtodate; }
            set
            {
                _seletedtodate = value;
                OnPropertyChanged(nameof(SeletedToDate));
            }
        }

        public DateTime SetTodate
        {
            get { return _settodate; }
            set
            {
                _settodate = value;
                OnPropertyChanged(nameof(SetTodate));
            }
        }
        public DateTime SetFromDate
        {
            get { return _setfromdate; }
            set
            {
                _setfromdate = value;
                OnPropertyChanged(nameof(SetFromDate));
            }
        }
        public ObservableCollection<ArchiveData> ArchiveCollection
        {
            get { return _archive; }
            set
            {
                _archive = value;
                OnPropertyChanged(nameof(ArchiveCollection));
            }
        }
       
       
    }
}
