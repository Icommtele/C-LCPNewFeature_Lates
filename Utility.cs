using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using LCPReportingSystem.DAL;
using LCPReportingSystem.Model;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Diagnostics.Eventing.Reader;
using DashboardCommonDataLib;
using LCPInfrastructure;
using System.Runtime.InteropServices.ComTypes;

namespace LCPReportingSystem
{
    public class Utility
    {
        public DataAccessLayer _layer;
        public Utility()
        {
            _layer = new DataAccessLayer();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        //public bool userLogin(string username, string password)
        //{
        //    bool? IsloginSucess = null;
        //    try
        //    {
        //        string LoginMessage = _layer.userAuthendication(username, password);
        //        if (!string.IsNullOrEmpty(LoginMessage))
        //        {
        //            if (LoginMessage == "Success")
        //            {
        //                IsloginSucess = true;
        //            }
        //            else
        //            {
        //                IsloginSucess = false;
        //            }
        //        }
        //        return Convert.ToBoolean(IsloginSucess);
        //    }
        //    catch (Exception ex)
        //    {
        //        LCPLogUtils.LogException(ex, GetType().Name, nameof(userLogin));
        //        return false;
        //    }

        //}





        public string userLogin(string username, string password)
        {           
            try
            {
                string LoginMessage = _layer.userAuthendication(username, password);
               
                return LoginMessage;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(userLogin));
               
            }
            return string.Empty;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exerciseType"></param>
        /// <param name="description"></param>
        /// <param name="startTime"></param>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public int ExerciseDataSave(string exerciseType, string description, DateTime startTime, string UserName)
        {

            try
            {
                int ExerciseId = _layer.ExerciseInfoSave(exerciseType, description, startTime, UserName);

                return ExerciseId;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ExerciseDataSave));

            }
            return 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exerciseId"></param>
        /// <param name="endTime"></param>
        public void ExerciseEndDataSave(int exerciseId, DateTime endTime)
        {
            try
            {
                _layer.ExerciseEndInfoUpdate(exerciseId, endTime);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ExerciseEndDataSave));

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> Getexercisetypes()
        {
            var list = _layer.GetAllExerciseTypes();
            return list;
        }
         /// <summary>
         /// 
         /// </summary>
         /// <param name="exerciseType"></param>
         /// <returns></returns>
        public List<ExerciseTimeRange> GetexercisetypeTimeRange(string exerciseType)
        {
            var list = _layer.GetTimeRange_ExerciseType(exerciseType);
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsadminUser(string username, string password)
        {
            bool? IsAdmin = null;
            try
            {
                string getUserRole = _layer.getUserRole(username, password);
                if (!string.IsNullOrEmpty(getUserRole))
                {
                    if (getUserRole == "Admin")
                    {
                        IsAdmin = true;
                    }
                    else
                    {
                        IsAdmin = false;
                    }
                }
                return Convert.ToBoolean(IsAdmin);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IsadminUser));
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsUserExists(string username, string password)
        {
            bool? IsUserExists = null;
            try
            {
                string IsResultMessage = _layer.CheckUserExists(username, password);
                if (!string.IsNullOrEmpty(IsResultMessage))
                {
                    if (IsResultMessage != "Exists")
                    {
                        IsUserExists = true;
                    }
                    else
                    {
                        IsUserExists = false;
                    }
                }
                return Convert.ToBoolean(IsUserExists);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IsUserExists));
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public string IsSucessAddNewuser(Admin admin)
        {
            
            try
            {
                string getMessage = _layer.CreateNewUser(admin);
                
                
                return getMessage;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IsSucessAddNewuser));
                return string.Empty;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Userid"></param>
        /// <param name="Username"></param>
        /// <returns></returns>
        public bool IsDeleteUserData(string Userid, string Username)
        {
            string IsMessage;
            bool? IsDeleted = null;
            try
            {
                IsMessage = _layer.DeleteUserData(Userid, Username);
                if (!string.IsNullOrEmpty(IsMessage))
                {
                    if (IsMessage == "Success")
                    {
                        IsDeleted = true;
                    }
                    else
                    {
                        IsDeleted = false;
                    }
                }
                return Convert.ToBoolean(IsDeleted);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IsDeleteUserData));
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public bool IsSaveUserData(ManageUserEntity mode)
        {
            string IsMessage;
            bool? IsDeleted = null;
            try
            {
                IsMessage = _layer.SaveUserData(mode);
                if (!string.IsNullOrEmpty(IsMessage))
                {
                    if (IsMessage == "Success")
                    {
                        IsDeleted = true;
                    }
                    else
                    {
                        IsDeleted = false;
                    }
                }
                return Convert.ToBoolean(IsDeleted);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IsDeleteUserData));
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<ManageUserEntity> getUserCollection()
        {
            ObservableCollection<ManageUserEntity> _usercollection = null;
            try
            {
                if (_usercollection == null)
                {
                    _usercollection = new ObservableCollection<ManageUserEntity>();
                    DataTable UserDt = new DataTable();
                    UserDt = _layer.getAllUserData();
                    if (UserDt != null)
                    {
                        foreach (DataRow row in UserDt.Rows)
                        {
                            string UserID = Convert.ToString(row["UserId"]);
                            string Username = row["Username"].ToString();
                            string Password = row["Password"].ToString();
                            string UserType = row["UserType"].ToString();
                            string Email = row["Email"].ToString();
                            string IsActive = row["IsActive"].ToString();

                            string CreationDate = Convert.ToDateTime(row["CreationDate"].ToString()).ToString("dd/MM/yyyy");

                            _usercollection.Add(new ManageUserEntity(UserID, Username, Password, UserType, Email, IsActive, CreationDate));
                        }
                    }
                }
                return _usercollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getUserCollection));
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dashBoard"></param>
        /// <returns></returns>
        public bool SaveSubSystemArchiveLastData(DashBoard dashBoard)
        {
            bool? isSaveConform = null;
            try
            {
                string IsSaveStatus = _layer.SaveSubSystemArchiveData(dashBoard);
                if (!string.IsNullOrEmpty(IsSaveStatus))
                {
                    if (IsSaveStatus == "Sucess")
                    {
                        isSaveConform = true;
                    }
                    else
                    {
                        isSaveConform = false;
                    }
                }
                return Convert.ToBoolean(isSaveConform);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SaveSubSystemArchiveLastData));
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="newpassword"></param>
        /// <returns></returns>
        public bool IsResetPassword(string username, string password, string newpassword)
        {
            bool? IsRestPass = null;
            try
            {
                string resetMsg = _layer.RestPassword(username, password, newpassword);
                if (!string.IsNullOrEmpty(resetMsg))
                {
                    if (resetMsg == "Success")
                    {
                        IsRestPass = true;
                    }
                    else
                    {
                        IsRestPass = false;
                    }
                }
                return Convert.ToBoolean(IsRestPass);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IsResetPassword));
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <param name="conformpassword"></param>
        /// <returns></returns>
        public bool IsConformPassword(string password, string conformpassword)
        {
            bool? IsPasswordMach = null;
            try
            {
                if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(conformpassword))
                {
                    if (password == conformpassword)
                    {
                        IsPasswordMach = true;
                    }
                    else
                    {
                        IsPasswordMach = false;
                    }
                }
                return Convert.ToBoolean(IsPasswordMach);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IsConformPassword));
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="conformpassword"></param>
        /// <returns></returns>
        public bool IsCredential(string username, string password, string conformpassword)
        {
            bool? IsResult;
            try
            {
                if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password) && string.IsNullOrEmpty(conformpassword))
                {
                    IsResult = true;
                }
                else
                {
                    IsResult = false;
                }
                return Convert.ToBoolean(IsResult);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IsCredential));
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsEmailValid(string email)
        {
            bool? IsEmailValid;
            if (!string.IsNullOrEmpty(email))
            {
                Regex regex = new Regex(_layer.getEmailChar());
                Match match = regex.Match(email);
                if (match.Success)
                {
                    IsEmailValid = true;
                }
                else
                {
                    IsEmailValid = false;
                }
            }
            else
            {
                IsEmailValid = false;
            }
            return Convert.ToBoolean(IsEmailValid);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdu"></param>
        /// <param name="_subsysIp"></param>
        /// <param name="isSubSystem"></param>
        /// <returns></returns>
        public Dictionary<string, ParameterSetConfig> getLoadSnmplastLivedata(byte[] pdu, string _subsysIp, IsSubSystem isSubSystem)
        {
            Dictionary<string, ParameterSetConfig> keyValuePairs;
            try
            {
                keyValuePairs = new Dictionary<string, ParameterSetConfig>();
                keyValuePairs = _layer.getSnmpNonTrapLastLiveMessage(pdu, _subsysIp, isSubSystem);
                return keyValuePairs;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getLoadSnmplastLivedata));
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdu"></param>
        /// <param name="subsysIp"></param>
        /// <param name="isSubSystem"></param>
        /// <param name="SubSystemOid"></param>
        /// <returns></returns>
        public ObservableCollection<TrapInfo> LoadSnmpTrap(byte[] pdu, string subsysIp, IsSubSystem isSubSystem, string SubSystemOid)
        {
            ObservableCollection<TrapInfo> TrapResult;
            try
            {
                TrapResult = new ObservableCollection<TrapInfo>();
                _layer.getLoadSnmpTrap(pdu, subsysIp, isSubSystem, SubSystemOid);
                TrapResult = _layer.getTrap();

                return TrapResult;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(LoadSnmpTrap));
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <returns></returns>
        public ObservableCollection<SubSysParameterConfig> getSubSystemConfig(IsSubSystem isSubSystem)
        {
            ObservableCollection<SubSysParameterConfig> _subsystemcollection = null;
            try
            {
                if (_subsystemcollection == null)
                {
                    _subsystemcollection = new ObservableCollection<SubSysParameterConfig>();
                    _subsystemcollection = _layer.getSubSystemConfiguration(isSubSystem);
                }
                return _subsystemcollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSubSystemConfig));
                return null;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <returns></returns>
        public string loadSubsystemConfigPath(IsSubSystem isSubSystem)
        {
            string getFilePath = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(getFilePath))
                {
                    getFilePath = _layer.getSubSystemConfigPath(isSubSystem);
                }
                return getFilePath;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(loadSubsystemConfigPath));
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isMenuActiveStatus"></param>
        /// <returns></returns>
        public string IsMenuActiveStatus(IsMenuActiveStatus isMenuActiveStatus)
        {
            int IsIndex = (int)isMenuActiveStatus;
            string getStatus = string.Empty;
            switch (IsIndex)
            {
                case 0:
                    getStatus = "MenuActive";
                    break;
                case 1:
                    getStatus = "MenuInactive";
                    break;
            }
            return getStatus;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <returns></returns>
        public string GetSubsystemName(IsSubSystem isSubSystem)
        {
            int IsSubSysIndex = (int)isSubSystem;
            string SubsystemName = string.Empty;
            switch (IsSubSysIndex)
            {
                case 1:
                    SubsystemName = "DieselGenerator";
                    break;
                case 2:
                    SubsystemName = "UPS";
                    break;
                case 3:
                    SubsystemName = "Radio";
                    break;
                case 4:
                    SubsystemName = "Switch";
                    break;
                case 5:
                    SubsystemName = "Router";
                    break;
                case 6:
                    SubsystemName = "DieselGenerator2";
                    break;
                case 7:
                    SubsystemName = "UPS2";
                    break;
                case 8:
                    SubsystemName = "Radio2";
                    break;
                case 9:
                    SubsystemName = "Switch2";
                    break;
                case 10:
                    SubsystemName = "Router2";
                    break;
            }
            return SubsystemName;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="isSqlFlag"></param>
        /// <returns></returns>
        public ObservableCollection<ArchiveEntity> getArchiveCollection(IsSubSystem isSubSystem, IsSqlFlag isSqlFlag, int SubsystemId)
        {
            ObservableCollection<ArchiveEntity> _archivecollection = null;
            try
            {
                if (_archivecollection == null)
                {
                    _archivecollection = new ObservableCollection<ArchiveEntity>();
                    DataTable ArchiveDt = new DataTable();
                    ArchiveDt = _layer.getSubsystemArchiveData(isSubSystem, isSqlFlag, SubsystemId);
                    if (ArchiveDt != null)
                    {

                        foreach (DataRow row in ArchiveDt.Rows)
                        {
                            string RecordID = row["RecordID"].ToString();
                            string SubSystemIP = row["SubsystemId"].ToString();
                            string SystemName = row["SystemName"].ToString();
                            string PrameterName = row["PrameterName"].ToString();
                            string PrameterValue = row["PrameterValue"].ToString();
                            string DateTimeStamp = row["DateTimeStamp"].ToString();
                            string CurrentDate = Convert.ToDateTime(row["CurrentDate"].ToString()).ToString("dd/MM/yyyy");

                            _archivecollection.Add(new ArchiveEntity(RecordID, SubSystemIP, SystemName, PrameterName, PrameterValue, DateTimeStamp, CurrentDate));
                        }
                    }
                }
                return _archivecollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getArchiveCollection));
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="isSqlFlag"></param>
        /// <returns></returns>
        public ObservableCollection<ArchiveData> getArchiveCollection2(IsSubSystem isSubSystem, IsSqlFlag isSqlFlag, int SubsystemId)
        {
            ObservableCollection<ArchiveData> _archivecollection = null;
            StringBuilder ArchiveJsion = new StringBuilder();
            try
            {
                if (_archivecollection == null)
                {
                    _archivecollection = new ObservableCollection<ArchiveData>();
                    DataTable ArchiveDt = new DataTable();
                    ArchiveDt = _layer.getSubsystemArchiveData(isSubSystem, isSqlFlag, SubsystemId);
                    if (ArchiveDt != null && ArchiveDt.Rows.Count > 0)
                    {
                        ArchiveJsion.Append(JsonConvert.SerializeObject(ArchiveDt));
                        _archivecollection = JsonConvert.DeserializeObject<ObservableCollection<ArchiveData>>(ArchiveJsion.ToString());
                    }
                }
                return _archivecollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getArchiveCollection2));
                return null;
            }
            finally
            {
                _archivecollection = null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="isSqlFlag"></param>
        /// <param name="isRequestType"></param>
        /// <returns></returns>
        public ObservableCollection<ArchiveEntity> getArchiveCollection(IsSubSystem isSubSystem, IsSqlFlag isSqlFlag, IsRequestType isRequestType, int SubsystemId)
        {
            ObservableCollection<ArchiveEntity> _paramsCollection = null;
            try
            {
                if (_layer.GetRequestType(isRequestType).Equals("BindByCombo"))
                {
                    _paramsCollection = new ObservableCollection<ArchiveEntity>();
                    DataTable DtParams = new DataTable();
                    DtParams = _layer.getSubsystemArchiveData(isSubSystem, isSqlFlag, SubsystemId);
                    if (DtParams != null)
                    {
                        foreach (DataRow row in DtParams.Rows)
                        {
                            string ParamsId = Convert.ToString(row["ParamsId"]);
                            string ParameterName = Convert.ToString(row["ParameterName"]);
                            string SystemName = Convert.ToString(row["SystemName"]);

                            _paramsCollection.Add(new ArchiveEntity(ParamsId, string.Empty, SystemName, ParameterName, string.Empty, string.Empty, string.Empty));
                        }
                    }
                }
                return _paramsCollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getArchiveCollection));
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        /// 
        public ObservableCollection<ActivityReportData> GetActivityData_Collection(string FromDate, string ToDate)
        {
            try
            {
                var _activityReportCollection = new ObservableCollection<ActivityReportData>();
                var filterDt = _layer.GetActivityData_DB(FromDate, ToDate);

                if (filterDt == null || filterDt.Rows.Count == 0)
                    return _activityReportCollection;

                DataTable FilterDt = new DataTable();
                FilterDt = _layer.GetActivityData_DB(FromDate, ToDate);
                if (FilterDt != null)
                {
                    if (FilterDt.Rows.Count > 0)
                    {
                        int a = 0;
                        foreach (DataRow row in FilterDt.Rows)
                        {
                            ++a;
                            int activityId = a;
                            string activityType = row["Activity_Type"]?.ToString() ?? string.Empty;
                            DateTime activityDatetime = row["Activity_Datetime"] != DBNull.Value ? Convert.ToDateTime(row["Activity_Datetime"]) : DateTime.Now;
                            string activityInfo = row["Activity_Info"]?.ToString() ?? string.Empty;
                            string username = row["Username"]?.ToString() ?? string.Empty;
                            _activityReportCollection.Add(new ActivityReportData(
                                activityType,
                                activityDatetime,
                                activityInfo,
                                username,
                                 activityId
                            ));
                        }
                    }
                }
                return _activityReportCollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetActivityData_Collection));
                return null;
            }
        }       
        public ObservableCollection<SnmpFaultData> GetFaultData_Collection(IsSubSystem isSubSystem, string fromDate, string toDate)
        {
            try
            {
                var archiveFaultCollection = new ObservableCollection<SnmpFaultData>();
                var filterDt = _layer.GetFaultData_DB(isSubSystem, fromDate, toDate);

                if (filterDt == null || filterDt.Rows.Count == 0)
                    return archiveFaultCollection;
                int a = 0;

                foreach (DataRow row in filterDt.Rows)
                {

                    string subsystem = row["SubSystem"]?.ToString() ?? string.Empty;
                    DateTime faultStartTime = row.Field<DateTime>("FaultStartTime");
                    DateTime faultEndTime = row["FaultEndTime"] == DBNull.Value? DateTime.Now: row.Field<DateTime>("FaultEndTime");
                    int duration = row["DurationInMinutes"] == DBNull.Value? (int)(faultEndTime - faultStartTime).TotalMinutes: row.Field<int>("DurationInMinutes");
                    string status = row["Status"]?.ToString() ?? string.Empty;

                    archiveFaultCollection.Add(new SnmpFaultData(subsystem,
                        string.Empty,          // SubsystemIp is skipped
                        faultStartTime,
                        faultEndTime,
                        duration,
                        status,
                        ++a                     // Assuming Id is not required
                    ));
                }

                return archiveFaultCollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetFaultData_Collection));
                return new ObservableCollection<SnmpFaultData>();
            }
        }
     /// <summary>
     /// 
     /// </summary>
     /// <param name="isSubSystem"></param>
     /// <param name="FromDate"></param>
     /// <param name="ToDate"></param>
     /// <returns></returns>
        public ObservableCollection<ArchiveEntity> GetNonTrapReportData_Collection(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            ObservableCollection<ArchiveEntity> _archivefiltercollection = null;
            try
            {
                if (_archivefiltercollection == null)
                {
                    _archivefiltercollection = new ObservableCollection<ArchiveEntity>();
                    DataTable FilterDt = new DataTable();
                    FilterDt = _layer.GetNonTrapReportData_DB(isSubSystem, FromDate, ToDate);
                    if (FilterDt != null)
                    {
                        int a = 0;
                        foreach (DataRow row in FilterDt.Rows)
                        {
                            int id = ++a;
                            string RecordID = id.ToString();//row["RecordID"].ToString();
                            string SubSystemIP = row["SubSystemIP"].ToString();
                            string SystemName = row["SystemName"].ToString();
                            string PrameterName = row["PrameterName"].ToString();
                            string PrameterValue = row["PrameterValue"].ToString();
                            string DateTimeStamp = row["DateTimestamp"].ToString();
                            string CurrentDate = Convert.ToDateTime(row["CurrentDate"].ToString()).ToString("dd/MM/yyyy");

                            _archivefiltercollection.Add(new ArchiveEntity(RecordID, SubSystemIP, SystemName, PrameterName, PrameterValue, DateTimeStamp, CurrentDate));
                        }
                    }
                }
                return _archivefiltercollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetNonTrapReportData_Collection));
                return null;
            }
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="isSubSystem"></param>
       /// <param name="IsInitialData"></param>
       /// <param name="FromDate"></param>
       /// <param name="IsTrap"></param>
       /// <param name="ToDate"></param>
       /// <param name="CurrentPage"></param>
       /// <param name="TotalPages"></param>
       /// <param name="isFirst"></param>
       /// <param name="IsLast"></param>
       /// <param name="isNextbutton"></param>
       /// <param name="isPreviousbutton"></param>
       /// <returns></returns>
        public ObservableCollection<ArchiveData> FilterArchiveDataAllInOne(IsSubSystem isSubSystem,bool IsInitialData, string FromDate,bool IsTrap, string ToDate,int CurrentPage 
            ,int TotalPages,bool isFirst,bool IsLast,bool isNextbutton,bool isPreviousbutton)
        {
            ObservableCollection<ArchiveData> _archivefiltercollection  = new ObservableCollection<ArchiveData>();
            DataTable FilterDt = new DataTable();
            int sysid = (int)isSubSystem;

            try
            {
                if (IsInitialData)
                {
                    FilterDt = _layer.GetFirstPage(isSubSystem, FromDate, ToDate, isTrap: IsTrap);
                }
                else
                {
                    if (isFirst)
                    {
                        FilterDt = _layer.GetArchiveDataPages(FromDate, ToDate, sysid.ToString(), isSubSystem.ToString(), 100, ref CurrentPage, TotalPages, isFirst: true, isTrap: IsTrap);
                    }
                    else if (IsLast)
                    {
                        FilterDt = _layer.GetArchiveDataPages(FromDate, ToDate, sysid.ToString(), isSubSystem.ToString(), 100, ref CurrentPage, TotalPages, isLast: true, isTrap: IsTrap);
                    }
                    else if (isNextbutton)
                    {
                        FilterDt = _layer.GetArchiveDataPages(FromDate, ToDate, sysid.ToString(), isSubSystem.ToString(), 100, ref CurrentPage, TotalPages, isNext: true, isTrap: IsTrap);
                    }
                    else if (isPreviousbutton)
                    {
                        FilterDt = _layer.GetArchiveDataPages(FromDate, ToDate, sysid.ToString(), isSubSystem.ToString(), 100, ref CurrentPage, TotalPages, isPrev: true, isTrap: IsTrap);
                    }
                }

                if (FilterDt != null)
                {
                    if (IsTrap)
                    {
                        foreach (DataRow row in FilterDt.Rows)
                        {
                            string RecordID = row["RecordID"].ToString();
                            string SubSystemId = Convert.ToString(row["SubsystemId"]);
                            string SystemName = Convert.ToString(row["SystemName"]);
                            string TrapName = Convert.ToString(row["TrapName"]);
                            string TrapDescription = Convert.ToString(row["TrapDesc"]);
                            string TrapTimeStamp = Convert.ToString(row["TrapTimeStamp"]);
                            string TrapValue = Convert.ToString(row["TrapValue"]);
                            string TrapGroup = Convert.ToString(row["TrapGroup"]);
                            string DateTimeStamp = Convert.ToString(row["DateTimeStamp"]);
                            DateTimeStamp = Convert.ToDateTime(row["CurrentDate"].ToString()).ToString("dd/MM/yyyy");

                            _archivefiltercollection.Add(new ArchiveData(RecordID, SubSystemId, isSubSystem.ToString(), TrapName, TrapDescription, TrapTimeStamp, DateTimeStamp, " ", "Trap Name", "Trap Group"));
                        }
                    }
                    else
                    {
                        foreach (DataRow row in FilterDt.Rows)
                        {
                            string RecordID = row["RecordID"].ToString();
                            string SubSystemIP = row["SubSystemId"].ToString();
                            string SystemName = row["SystemName"].ToString();
                            string PrameterName = row["PrameterName"].ToString();
                            string PrameterValue = row["PrameterValue"].ToString();
                            string DateTimeStamp = row["DateTimestamp"].ToString();
                            string CurrentDate = Convert.ToDateTime(row["CurrentDate"].ToString()).ToString("dd/MM/yyyy");

                            _archivefiltercollection.Add(new ArchiveData(RecordID, SubSystemIP, SystemName, PrameterName, PrameterValue, DateTimeStamp, CurrentDate, " ", "Prameter Name", " Prameter Value"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(FilterArchiveDataAllInOne));
            }
            return _archivefiltercollection;
        }
           /// <summary>
           /// 
           /// </summary>
           /// <param name="isSubSystem"></param>
           /// <param name="FromDate"></param>
           /// <param name="ToDate"></param>
           /// <param name="isSqlFlag"></param>
           /// <param name="ParamName"></param>
           /// <returns></returns>
        public ObservableCollection<ArchiveData> ArchiveFilterCollection(IsSubSystem isSubSystem, string FromDate, string ToDate, IsSqlFlag isSqlFlag, string ParamName)
        {
            ObservableCollection<ArchiveData> _linegraphCollection = null;
            try
            {
                if (_linegraphCollection == null)
                {
                    _linegraphCollection = new ObservableCollection<ArchiveData>();
                    DataTable DtLineGraph = new DataTable();
                    DtLineGraph = _layer.getArchiveFilterData(isSubSystem, isSqlFlag, FromDate, ToDate, ParamName);

                    if (DtLineGraph != null)
                    {
                        foreach (DataRow row in DtLineGraph.Rows)
                        {
                            string SystemName = Convert.ToString(row["SystemName"]);
                            string ParameterName = Convert.ToString(row["ParameterName"]);
                            string ParameterValue = Convert.ToString(row["ParameterValue"]);
                            string DateTimeStamp = Convert.ToString(row["DateTimeStamp"]);
                            string CurrentDate = Convert.ToDateTime(row["CurrentDate"].ToString()).ToString("dd/MM/yyyy");

                            _linegraphCollection.Add(new ArchiveData("", "", SystemName, ParameterName, ParameterValue, DateTimeStamp, CurrentDate," "," "," "));
                        }
                    }
                }
                return _linegraphCollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ArchiveFilterCollection));
                return null;
            }
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="isSubSystem"></param>
       /// <param name="FromDate"></param>
       /// <param name="ToDate"></param>
       /// <returns></returns>
        public ObservableCollection<TrapTypeSummary> TrapTypeSummaryCollection(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            ObservableCollection<TrapTypeSummary> _TrapTypeSummaryCollection = null;
            try
            {
                if (_TrapTypeSummaryCollection == null)
                {
                    _TrapTypeSummaryCollection = new ObservableCollection<TrapTypeSummary>();

                    var list = _layer.GetTrapTypeSummary(FromDate, ToDate, (int)isSubSystem);
                    foreach (var item in list)
                    {
                        _TrapTypeSummaryCollection.Add(item);
                    }
                }
                return _TrapTypeSummaryCollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(TrapTypeSummaryCollection));
                return null;
            }
        }
      
        //public ObservableCollection<TrapEntity> GetSubsystemTrapCollection(IsSubSystem isSubSystem)
        //{
        //    ObservableCollection<ArchiveData> TrapFilterCollection = null;
        //    TrapFilterCollection = new ObservableCollection<ArchiveData>();
        //    ObservableCollection<TrapEntity> TrapCollection = null;
        //    try
        //    {
        //        if (TrapCollection == null)
        //        {
        //            TrapCollection = new ObservableCollection<TrapEntity>();
        //            DataTable DtTrapData = new DataTable();
        //            string upsTrapNameconfigduration = string.Empty;
        //            string upsconfigminduration = string.Empty;
        //            string upssecondonbattry = string.Empty;
        //            string upsTrapNameconfigdurationValue = string.Empty;
        //            string upsconfigmindurationValue = string.Empty;
        //            string upssecondonbattryValue = string.Empty;

        //            string[] Trapresult;
        //            string[] TrapValueresult;
        //            string SubSystem = isSubSystem.ToString();

        //            DtTrapData = _layer.GetSubsystemTrapData(isSubSystem);
        //            if (DtTrapData != null)
        //            {
        //                if (DtTrapData.Rows.Count > 0)
        //                {
        //                    foreach (DataRow traps in DtTrapData.Rows)
        //                    {
        //                        string RecordID = Convert.ToString(traps["RecordID"]);
        //                        string SubSystemIP = Convert.ToString(traps["SubSystemIP"]);
        //                        string SystemName = Convert.ToString(traps["SystemName"]);
        //                        string TrapName = Convert.ToString(traps["TrapName"]);
        //                        string TrapDescription = Convert.ToString(traps["TrapDesc"]);
        //                        string TrapTimeStamp = Convert.ToString(traps["TrapTimeStamp"]);
        //                        string TrapValue = Convert.ToString(traps["TrapValue"]);
        //                        string TrapGroup = Convert.ToString(traps["TrapGroup"]);
        //                        string DateTimeStamp = Convert.ToString(traps["DateTimeStamp"]);

        //                        if (SubSystem == "UPS")
        //                        {

        //                            Trapresult = TrapName.Split(',');
        //                            int trapCount = Trapresult.Length;
        //                            upsTrapNameconfigduration = Trapresult[0];
        //                            upsconfigminduration = Trapresult[1];
        //                            upssecondonbattry = Trapresult[2];

        //                            TrapValueresult = TrapValue.Split(',');
        //                            upsTrapNameconfigdurationValue = TrapValueresult[0];
        //                            upsconfigmindurationValue = TrapValueresult[1];
        //                            upssecondonbattryValue = TrapValueresult[2];

        //                            TrapCollection.Add(new TrapEntity(RecordID, SubSystemIP, SystemName, upsTrapNameconfigduration, TrapTimeStamp, TrapValue,
        //                                TrapGroup, DateTimeStamp, DateTimeStamp, upsconfigminduration, upssecondonbattry, upssecondonbattry,
        //                                upsTrapNameconfigdurationValue, upsconfigmindurationValue, upssecondonbattryValue));
        //                        }
        //                        else if (SubSystem == "DieselGenerator")
        //                        {
        //                            string TrapDesc = Convert.ToString(traps["TrapDesc"]);
        //                            DashboardCommonData.PortInterface = "Current State";

        //                            TrapCollection.Add(new TrapEntity(RecordID, SubSystemIP, SystemName, DashboardCommonData.NotificationDescription, DateTimeStamp, TrapGroup, TrapGroup, TrapTimeStamp, "NA1",
        //                                DashboardCommonData.PortInterface, DashboardCommonData.TrapDescr, "NA", TrapDesc, TrapValue, TrapName));
        //                        }
        //                        else if (SubSystem == "Radio")
        //                        {

        //                            DashboardCommonData.PortInterface = "Notification Name";
        //                            DashboardCommonData.TrapDescr = "Notification Description";
        //                            TrapCollection.Add(new TrapEntity(RecordID, SubSystemIP, SystemName, DashboardCommonData.NotificationDescription, DateTimeStamp, TrapGroup, TrapGroup, TrapTimeStamp, "NA1",
        //                                DashboardCommonData.TrapDescr, DashboardCommonData.PortInterface, "NA4", SystemName, TrapValue.TrimEnd(), TrapName));
        //                        }
        //                        else
        //                        {

        //                            TrapCollection.Add(new TrapEntity(RecordID, SubSystemIP, SystemName, DashboardCommonData.NotificationDescription, DateTimeStamp, TrapGroup, TrapGroup, TrapTimeStamp, "NA1",
        //                                DashboardCommonData.EventType, DashboardCommonData.PortInterface, "NA", SystemName, TrapValue, TrapName));
        //                        }
        //                    }

        //                }
        //            }
        //        }
        //        return TrapCollection;
        //    }
        //    catch (Exception ex)
        //    {
        //        LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSubsystemTrapCollection));
        //        return null;
        //    }
        //}
        /// <param name="isSubSystem"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public ObservableCollection<TrapEntity> GetTrapReportData_Collection(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            ObservableCollection<TrapEntity> TrapFilterCollection = null;
            try
            {

                if (TrapFilterCollection == null)
                {
                    string upsTrapNameconfigduration = string.Empty;
                    string upsconfigminduration = string.Empty;
                    string upssecondonbattry = string.Empty;
                    string upsTrapNameconfigdurationValue = string.Empty;
                    string upsconfigmindurationValue = string.Empty;
                    string upssecondonbattryValue = string.Empty;
                    string[] Trapresult;
                    string[] TrapValueresult;
                    TrapFilterCollection = new ObservableCollection<TrapEntity>();
                    DataTable TrapTable = new DataTable();
                    TrapTable = _layer.GetTrapReportData_DB(isSubSystem, FromDate, ToDate);
                    if (TrapTable != null)
                    {
                        if (TrapTable.Rows.Count > 0)
                        {
                            foreach (DataRow traps in TrapTable.Rows)
                            {
                                string RecordID = Convert.ToString(traps["RecordID"]);
                                string SubSystemId = Convert.ToString(traps["SubsystemId"]);
                                string SubSystemIP = Convert.ToString(traps["SubSystemIP"]);
                                string SystemName = Convert.ToString(traps["SystemName"]);
                                string TrapName = Convert.ToString(traps["TrapName"]);
                                string TrapTimeStamp = Convert.ToString(traps["TrapTimeStamp"]);
                                string TrapDescription = Convert.ToString(traps["TrapDesc"]);
                                string TrapValue = Convert.ToString(traps["TrapValue"]);
                                string TrapGroup = Convert.ToString(traps["TrapGroup"]);
                                string DateTimeStamp = Convert.ToString(traps["DateTimeStamp"]);
                                DateTimeStamp = Convert.ToDateTime(traps["CurrentDate"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                                //string Alarmid = "NA";

                                if (isSubSystem.ToString() == "UPS")
                                {
                                    Trapresult = TrapName.Split(',');
                                    int trapCount = Trapresult.Length;
                                    upsTrapNameconfigduration = Trapresult[0];
                                    upsconfigminduration = Trapresult[1];
                                    upssecondonbattry = Trapresult[2];

                                    TrapValueresult = TrapValue.Split(',');
                                    upsTrapNameconfigdurationValue = TrapValueresult[0];
                                    upsconfigmindurationValue = TrapValueresult[1];
                                    upssecondonbattryValue = TrapValueresult[2];


                                    TrapFilterCollection.Add(new TrapEntity(upsTrapNameconfigduration, upsTrapNameconfigdurationValue, upsconfigminduration, upsconfigmindurationValue,
                                                                           upssecondonbattry, upssecondonbattryValue, TrapTimeStamp, DateTimeStamp, TrapGroup));
                                    
                                }
                                else if (isSubSystem.ToString() == "DieselGenerator")
                                {
                                    TrapFilterCollection.Add(new TrapEntity("SubSystem", SystemName, "Trap Name", TrapName,
                                                                           "Trap Description", TrapDescription, TrapTimeStamp, DateTimeStamp, TrapGroup));
                                   
                                }
                                else if (isSubSystem.ToString() == "Radio")
                                {
                                    TrapFilterCollection.Add(new TrapEntity("SubSystem", SystemName, "Trap Name", TrapName,
                                                                           "Trap Description", TrapDescription, TrapTimeStamp, DateTimeStamp, TrapGroup));                                    
                                }
                                else
                                {
                                    TrapFilterCollection.Add(new TrapEntity("SubSystem", SystemName, "Trap Name", TrapName,
                                                                           "Trap Description", TrapDescription, TrapTimeStamp, DateTimeStamp, TrapGroup));
                                    
                                }
                            }
                        }
                    }
                }
                return TrapFilterCollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetTrapReportData_Collection));
                return null;
            }
        }
        /// <param name="isSubSystem"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public bool IsDeleteArchiveData(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            string IsMessage;
            bool? IsDeleted = null;
            try
            {
                IsMessage = _layer.DeleteArchiveData(isSubSystem, FromDate, ToDate);
                if (!string.IsNullOrEmpty(IsMessage))
                {
                    if (IsMessage == "Success")
                    {
                        IsDeleted = true;
                    }
                    else
                    {
                        IsDeleted = false;
                    }
                }
                return Convert.ToBoolean(IsDeleted);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(IsDeleteArchiveData));
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Ip"></param>
        /// <returns></returns>
        public string LoadSubsystemName(string Ip)
        {
            string Result = string.Empty;
            if (!string.IsNullOrEmpty(Ip))
            {
                Result = _layer.GetSubsystemName(Ip);
            }
            return Result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        public void CreateLogFile(Exception exception)
        {
            _layer.GenerateErrorLog(exception);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isAppService"></param>
        /// <returns></returns>
        public string getSubSystemDirectory(IsAppService isAppService)
        {
            string GetSystemFilePath = string.Empty;
            if (string.IsNullOrEmpty(GetSystemFilePath))
            {
                GetSystemFilePath = _layer.getSubSystemFilePath(isAppService);
            } 
            return GetSystemFilePath;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SysName"></param>
        /// <param name="ParmsName"></param>
        /// <param name="value"></param>
        /// <param name="timestamp"></param>
        public void GenerateSubsystemNonTrapText(string SysName, string ParmsName, string value, string timestamp)
        {
            _layer.GenerateTrapNonTrapTxt(SysName, ParmsName, value, timestamp);
        }
    }
}
