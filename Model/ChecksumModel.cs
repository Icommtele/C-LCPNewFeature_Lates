using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.Model
{
    public class ChecksumModel :INotifyPropertyChanged
    {
        private string _checksum;
        private string _status;

        public string Name { get; set; }
        public string FilePath { get; set; }

        public string Checksum
        {
            get => _checksum;
            set { _checksum = value; OnPropertyChanged(nameof(Checksum)); }
        }

        public string Status
        {
            get => _status;
            set { _status = value; OnPropertyChanged(nameof(Status)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
