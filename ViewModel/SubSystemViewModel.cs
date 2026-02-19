using LCPReportingSystem.Command;
using LCPReportingSystem.DAL;
using LCPReportingSystem.Model;
using LCPReportingSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LCPReportingSystem.ViewModel
{
    public class SubSystemViewModel
    {
        public static DataTable GetdtTrapData=null;
        public SubSystemViewModel()
        {
            ShowDgBoardInformation();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static DataTable ShowDgBoardInformation()
        {
            GetdtTrapData = new DataTable();
            DataLoadDashboad ShowTrapInfo = new DataLoadDashboad();
            GetdtTrapData = ShowTrapInfo.GetSubsystemdhashboardTrapInfo(1);
            return GetdtTrapData;
        }
        public static DataTable ShowUPSBoardInformation()
        {
            GetdtTrapData = new DataTable();
            DataLoadDashboad ShowTrapInfo = new DataLoadDashboad();
            GetdtTrapData = ShowTrapInfo.GetSubsystemdhashboardupsTrapInfo(2);
            return GetdtTrapData;
        } 
        public static DataTable ShowSwitchBoardInformation()
        {
            GetdtTrapData = new DataTable();
            DataLoadDashboad ShowTrapInfo = new DataLoadDashboad();           
            GetdtTrapData = ShowTrapInfo.GetSubsystemdhashboardSwitchTrapInfo(4);
            return GetdtTrapData;
        }
        public static DataTable ShowRouterBoardInformation()
        {
            GetdtTrapData = new DataTable();
            DataLoadDashboad ShowTrapInfo = new DataLoadDashboad();           
            GetdtTrapData = ShowTrapInfo.GetSubsystemdhashboardRouterTrapInfo(5);
            return GetdtTrapData;
        }
        public static DataTable ShowRadioBoardInformation()
        {
            GetdtTrapData = new DataTable();
            DataLoadDashboad ShowTrapInfo = new DataLoadDashboad();           
            GetdtTrapData = ShowTrapInfo.GetSubsystemdhashboardRadioTrapInfo(3);
            return GetdtTrapData;
        }

    }
}
