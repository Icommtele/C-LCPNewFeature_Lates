using LCPReportingSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LCPInfrastructure;

namespace LCPReportingSystem.DbHelper
{
    public class DbContext
    {
        public DbContext()
        {

        }
        private string _connectionstring;
        private string _charemail;

        public SqlConnection getConnection
        {
            get
            {
                string dbConnection = string.Empty;
                string dbConnectionString = dbConnection.GetSqlConString(IsDbConString.WindowsAuthentication);
                this._connectionstring = ConfigurationManager.ConnectionStrings[dbConnectionString].ToString();
                SqlConnection connection = new SqlConnection(this._connectionstring);
                return connection;
            }
        }
        public string CharEmail
        {
            get
            {
                this._charemail = ConfigurationManager.AppSettings["charEmail"].ToString();
                return this._charemail;
            }
        }
        public string User_Authentication
        {
            get
            {
                return "User_Authentication";
            }
        }
        public string Create_NewUser
        {
            get
            {
                return "Create_NewUser";
            }
        }
        public string get_User_Role
        {
            get
            {
                return "get_User_Role";
            }
        }
        public string user_forget_password
        {
            get
            {
                return "user_forget_password";
            }
        }
        public string Check_User_Exists
        {
            get
            {
                return "Check_User_Exists";
            }
        }
        public string SaveSubSystemInfo
        {
            get
            {
                return "SaveSubSystemInfo";
            }
        }
        public string getSubSystemArchiveData
        {
            get
            {
                return "getSubSystemArchiveData";
            }
        }
        public string getArchiveDataDatewise
        {
            get
            {
                return "getArchiveDataDatewise";
            }
        }
        public string getArchiveTrapTotalCount
        {
            get
            {
                return "GetArchiveTrapTotalCount";
            }
        }

        public string getArchiveTotalCount
        {
            get
            {
                return "GetArchiveTotalCount";
            }
        }


        public string getArchiveTrapPage
        {
            get
            {
                return "GetArchiveTrapPage";
            }
        }

        public string getArchivePage
        {
            get
            {
                return "GetArchivePage";
            }
        }
        //GetTrapNameCount

        public string GetTrapNameCount
        {
            get
            {
                return "GetTrapNameCount";
            }
        }
        public string getFaultDataDatewise
        {
            get
            {
                return "getFaultDataDatewise";
            }
        }
        public string GetActivityDataDatewise
        {
            get
            {
                return "GetActivityDataDatewise";
            }
        }
        public string InsertExerciseLog
        {
            get
            {
                return "InsertExerciseLog";
            }
        }
        public string UpdateExerciseEndTime
        {
            get
            {
                return "UpdateExerciseEndTime";
            }
        }
        public string GetAllExerciseTypes
        {
            get
            {
                return "GetAllExerciseTypes";
            }
        }
        public string GetExerciseStartEndTimesByType
        {
            get
            {
                return "GetExerciseStartEndTimesByType";
            }
        }
        //GetAllExerciseTypes
        //GetExerciseStartEndTimesByType
        //GetActivityReportByDate
        public string GetActivityReportByDate
        {
            get
            {
                return "GetActivityReportByDate";
            }
        }
        public string RemoveArciveData
        {
            get
            {
                return "RemoveArciveData";
            }
        }
        public string getAllUsers
        {
            get
            {
                return "getAllUsers";
            }
        }
        public string DeleteUserAccount
        {
            get
            {
                return "DeleteUserAccount";
            }
        }
        
        public string Update_User
        {
            get
            {
                return "Update_User";
            }
        }
        public string SaveSubSystemTrapInfo
        {
            get
            {
                return "SaveSubSystemTrapInfo";
            }
        }
        public string GetSubsystemTrapInfo
        {
            get
            {
                return "GetSubsystemTrapInfo";
            }
        }
        public string GetSubsystemTrapInfoDatewise
        {
            get
            {
                return "GetSubsystemTrapInfoDatewise";
            }
        }
        public string GetSubSystemName
        {
            get
            {
                return "select dbo.GetSubsystemName(@SubsystemId)";
            }
        }

        public string GetDashBoadtrapInfo
        {
            get
            {
                return "GetDashBoadTrapInfo";
            }
        }
        public string GetDashBoadInfo
        {
            get
            {
                return "GetDashBoadInfo";
            }
        }
        public string GetDashBoardUpsTrapInfo
        {
            get
            {
                return "GetDashBoardUpsTrapInfo";
            }
        }
        public string GetDashBoadSwitchTrapInfo
        {
            get
            {
                return "GetDashBoadSwitchTrapInfo";
            }
        }
        public string GetDashBoardRouterTrapInfo
        {
            get
            {
                return "GetDashBoardRouterTrapInfo";
            }
        }
        
        public string GetDashBoardRadioTrapInfo
        {
            get
            {
                return "GetDashBoardRadioTrapInfo";
            }
        }
        public string SaveSubsystemParmsDetails
        {
            get
            {
                return "SaveSubsystemParmsDetails";
            }
        }

        public string InsertActivityReport
        {
            get
            {
                return "InsertActivityReport";
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <returns></returns>
        public string getSubSystemType(IsSubSystem isSubSystem)
        {
            int IsSubSysIndex = (int)isSubSystem;
            string SubSystemName = string.Empty;
            switch (IsSubSysIndex)
            {
                case 1:
                    SubSystemName = "DieselGenerator";
                    break;
                case 2:
                    SubSystemName = "UPS";
                    break;
                case 3:
                    SubSystemName = "Radio";
                    break;
                case 4:
                    SubSystemName = "Switch";
                    break;
                case 5:
                    SubSystemName = "Router";
                    break;
                case 6:
                    SubSystemName = "DieselGenerator2";
                    break;
                case 7:
                    SubSystemName = "UPS2";
                    break;
                case 8:
                    SubSystemName = "Radio2";
                    break;
                case 9:
                    SubSystemName = "Switch2";
                    break;
                case 10:
                    SubSystemName = "Router2";
                    break;
            }
            return SubSystemName;
        }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="isSqlFlag"></param>
    /// <returns></returns>
        public string GetSqlFlag(IsSqlFlag isSqlFlag)
        {
            string getFlag = string.Empty;
            int IsFlagIndex = (int)isSqlFlag;
            switch (IsFlagIndex)
            {
                case 0:
                    getFlag = "GetArchiveCollection";
                    break;
                case 1:
                    getFlag = "GetParameters";
                    break;
                case 2:
                    getFlag = "GetLineGraphData";
                    break;
            }
            return getFlag;
        }

        #region GetAppConfigPath()
        /// <summary>
        /// Used for gt Path
        /// </summary>
        /// <param name="isAppService"></param>
        /// <param name="isConfigFilename"></param>
        /// <returns></returns>
        public string GetAppConfigPath(IsAppService isAppService, IsConfigFilename isConfigFilename)
        {
            int? AppServiceIndex;
            string AppConfigPath = string.Empty;
            try
            {
                AppServiceIndex = (int)isAppService;
                switch (AppServiceIndex)
                {
                    case 0:
                        // AppConfigPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Settings\ConfigData\" + getConfigFilename(isConfigFilename);
                        AppConfigPath = Path.Combine(
                            AppDomain.CurrentDomain.BaseDirectory,
                            "Settings",
                            "ConfigData",
                            getConfigFilename(isConfigFilename)
                        );
                        break;
                    case 1:
                        //AppConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                        //    + @"\LCPReportingSystem\LCPReportingSystem\Settings\ConfigData\" + getConfigFilename(isConfigFilename); 
                        AppConfigPath = Path.Combine(
     AppDomain.CurrentDomain.BaseDirectory,
     "Settings",
     "ConfigData",
     getConfigFilename(isConfigFilename)
 );

                        break;
                }
                return AppConfigPath;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetAppConfigPath));
                return null;
            }
        }
        #endregion

        #region GetAppConfigTrapPath
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isAppService"></param>
        /// <param name="isConfigTrap"></param>
        /// <returns></returns>
        ///
        public string GetAppConfigTrapPath(IsAppService isAppService, IsConfigTrap isConfigTrap)
        {
            int? AppServiceIndex;
            string AppConfigPath = string.Empty;
            try
            {
                AppServiceIndex = (int)isAppService;
                switch (AppServiceIndex)
                {
                    case 0:
                        //AppConfigPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Settings\ConfigData\" + getConfigTrapFilename(isConfigTrap);
                        AppConfigPath = Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory,
    "Settings",
    "ConfigData",
    getConfigTrapFilename(isConfigTrap)
);

                        break;
                    case 1:
                        //AppConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                        //    + @"\LCPReportingSystem\LCPReportingSystem\Settings\ConfigData\" + getConfigTrapFilename(isConfigTrap);
                        AppConfigPath = Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory,
    "Settings",
    "ConfigData",
    getConfigTrapFilename(isConfigTrap));
                        break;
                }
                return AppConfigPath;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetAppConfigTrapPath));
                return null;
            }
        }

        #endregion

        #region getConfigFilename()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isConfigFilename"></param>
        /// <returns></returns>
        public string getConfigFilename(IsConfigFilename isConfigFilename)
        {
            int? FileIndex = null;
            string Filename = string.Empty;
            try
            {
                if (FileIndex == null)
                {
                    FileIndex = (int)isConfigFilename;
                    switch (FileIndex)
                    {
                        case 0:
                            Filename = @"ConfigDgset.txt";
                            break;
                        case 1:
                            Filename = @"ConfigRouterset.txt";
                            break;
                        case 2:
                            Filename = @"ConfigRadioset.txt";
                            break;
                        case 3:
                            Filename = @"ConfigSwitchset.txt";
                            break;
                        case 4:
                            Filename = @"UPSNonTrapConfigset.txt";
                            break;
                    }
                }
                return Filename;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getConfigFilename));
                return null;
            }
        }
        #endregion

        #region getConfigTrapFilename
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isConfigTrap"></param>
        /// <returns></returns>
        public string getConfigTrapFilename(IsConfigTrap isConfigTrap)
        {
            int? FileIndex = null;
            string Filename = string.Empty;
            try
            {
                if (FileIndex == null)
                {
                    FileIndex = (int)isConfigTrap;
                    switch (FileIndex)
                    {
                        case 0:
                            Filename = @"DgTrapConfig.txt";
                            break;
                        case 1:
                            Filename = @"RouterTrapConfig.txt";
                            break;
                        case 2:
                            Filename = @"RadioTrapConfig.txt";
                            break;
                        case 3:
                            Filename = @"SwitchTrapConfig.txt";
                            break;
                        case 4:
                            Filename = @"UPSTrapConfig.txt";
                            break;
                    }
                }
                return Filename;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getConfigTrapFilename));
                return null;
            }
        }
        #endregion

        
    }
}
