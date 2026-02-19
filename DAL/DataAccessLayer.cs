using LCPReportingSystem.DbHelper;
using LCPReportingSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using RsSnmp = LCPReportingSystem.SnmpNetServices;
using System.Data;
using System.Linq;
using SnmpSharpNet;
using System.Net;
using System.Windows.Threading;
using System.Windows;
using System.IO;
using System.Text;
using System.Media;
using System.Security.Cryptography;
using Oid = SnmpSharpNet.Oid;
using System.Windows.Input;
using System.Collections;
using CommonLib;
using LiveCharts.Maps;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Newtonsoft.Json.Linq;
using DashboardCommonDataLib;
using Microsoft.Xaml.Behaviors.Layout;
using LiveCharts.Helpers;
using System.ComponentModel;
using System.Windows.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using LCPInfrastructure;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.IO.Compression;
using Microsoft.ReportingServices.Diagnostics.Internal;
using LCPReportingSystem.SystemConfig;
using System.Runtime.InteropServices.ComTypes;
using System.Globalization;



namespace LCPReportingSystem.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class DataAccessLayer
    {
        private DbContext _dbContext;
        public static ObservableCollection<TrapInfo> _trapCollection;
        private ParameterSetConfig setConfig;
        private TrapConfig setTrapConfig;
        private TrapConfig setupsTrapConfig;
        private TrapConfig setupsTrapConfigest;
        private DashBoard _dashbord;
        public int PageSize { get; set; } = 100;
        int j = 1;
        int insertedId = 0;
        Dictionary<string, string> FilenameOidDictionaty = new Dictionary<string, string>();
        bool isFirst = false;
        public string SysName { get; set; }
        public string TrapName { get; set; }
        public string Timestamp { get; set; }

        public DataAccessLayer()
        {

            _dbContext = new DbContext();
            setConfig = new ParameterSetConfig();
            _dashbord = new DashBoard();
            _trapCollection = new ObservableCollection<TrapInfo>();
            Common.LoadUPSTrapInfo();
            Common.LoadNotificationInfo();
            DashboardCommonData.DigitalGeneratorLoadNotificationInfo();
            DashboardCommonData.RadioLoadNotificationInfo();
            DashboardCommonData.DgTrapstateInfo();
            GetBaseOidFromConfigFileFirstLine();
        }

        #region Login Region

        public string userAuthendication(string username, string password)
        {
            SqlCommand cmd = new SqlCommand();
            string loginMessage = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = "Check_User_Password";// _dbContext.User_Authentication;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = username;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = password;
                cmd.Connection.Open();
                object LoginStatus = cmd.ExecuteScalar();
                if (LoginStatus != null)
                {
                    loginMessage = Convert.ToString(LoginStatus);
                }
                return loginMessage;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(userAuthendication));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
        }
        public string CheckUserExists(string username, string password)
        {
            SqlCommand cmd = new SqlCommand();
            string IsUserExists = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.Check_User_Exists;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = username;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = password;
                cmd.Connection.Open();
                object getUserResult = cmd.ExecuteScalar();

                if (getUserResult != null)
                {
                    IsUserExists = Convert.ToString(getUserResult);
                }
                return IsUserExists;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(CheckUserExists));
                return null;
            }
        }
        public string getUserRole(string username, string password)
        {
            if (password == null)
            {
                return string.Empty;
            }
            SqlCommand cmd = new SqlCommand();
            string UserRole = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.get_User_Role;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = username;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = password;
                cmd.Connection.Open();
                object get_UserRole = cmd.ExecuteScalar();
                if (get_UserRole != null)
                {
                    UserRole = Convert.ToString(get_UserRole);
                }
                return UserRole;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getUserRole));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
        }
        public DataTable getAllUserData()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.getAllUsers;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IsRecord", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@IsRecord"].Value);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getAllUserData));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                adapter.Dispose();
            }
        }
        public string DeleteUserData(string Userid, string Username)
        {
            SqlCommand cmd = new SqlCommand();
            string resultMessage = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.DeleteUserAccount;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = int.Parse(Userid);
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 100).Value = Username;
                cmd.Parameters.Add("@IsDeleteSucess", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                int Data = cmd.ExecuteNonQuery();
                if (string.IsNullOrEmpty(resultMessage))
                {
                    resultMessage = Convert.ToString(cmd.Parameters["@IsDeleteSucess"].Value);
                }
                return resultMessage;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(DeleteUserData));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
        }
        public string SaveUserData(ManageUserEntity mode)
        {
            SqlCommand cmd = new SqlCommand();
            string resultMessage = string.Empty;
            try
            {

                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.Update_User;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", mode.Userid);
                cmd.Parameters.AddWithValue("@UserName", mode.Username);
                cmd.Parameters.AddWithValue("@Password", mode.Password);
                cmd.Parameters.AddWithValue("@Email", mode.Email);
                cmd.Parameters.AddWithValue("@IsActive", mode.Isactive);
                cmd.Parameters.AddWithValue("@UserType", mode.UserType);

                SqlParameter output = new SqlParameter("@IsResultMsg", SqlDbType.VarChar, 50)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);

                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                cmd.ExecuteNonQuery();
                resultMessage = output.Value.ToString();

                return resultMessage;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SaveUserData));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
        }
        public string CreateNewUser(Admin admin)
        {
            SqlCommand cmd = new SqlCommand();
            string IsaddUserMsg = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.Create_NewUser;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = admin.NuserName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = admin.Npassword;
                cmd.Parameters.Add("@UserRoleId", SqlDbType.Int).Value = admin.Userroleid;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = admin.Email;
                cmd.Parameters.Add("@IsActive", SqlDbType.VarChar, 10).Value = admin.Isactive;

                // ✅ Match the output size with stored procedure (200)
                var outputParam = cmd.Parameters.Add("@IsResultMsg", SqlDbType.VarChar, 200);
                outputParam.Direction = ParameterDirection.Output;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                // ✅ Read output parameter after execution
                IsaddUserMsg = Convert.ToString(outputParam.Value);
                return IsaddUserMsg;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(CreateNewUser));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
        }
        public string RestPassword(string username, string password, string NewPassword)
        {


            SqlCommand cmd = new SqlCommand();
            string resetPasswordMsg = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.user_forget_password;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = username;
              //  cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = password;
                cmd.Parameters.Add("@updatePassword", SqlDbType.VarChar, 50).Value = password;
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                object get_resetPasswordMsg = cmd.ExecuteScalar();
                if (get_resetPasswordMsg != null)
                {
                    resetPasswordMsg = Convert.ToString(get_resetPasswordMsg);
                }
                return resetPasswordMsg;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(RestPassword));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

           

        }

        #region Exercise Region
        public int ExerciseInfoSave(string exerciseType, string description, DateTime startTime, string UserName)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.InsertExerciseLog;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ExerciseType", exerciseType);
                cmd.Parameters.AddWithValue("@ExerciseDescription", description);
                cmd.Parameters.AddWithValue("@ExerciseStartTime", startTime);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Connection.Open();
                SqlParameter outParam = new SqlParameter("@InsertedId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);
                cmd.ExecuteNonQuery();
                insertedId = (int)outParam.Value;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ExerciseInfoSave));

            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return insertedId;
        }
        public void ExerciseEndInfoUpdate(int _id, DateTime endTime)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.UpdateExerciseEndTime;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Parameters.AddWithValue("@ExerciseEndTime", endTime);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ExerciseEndInfoUpdate));

            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

        }
        public List<string> GetAllExerciseTypes()
        {
            SqlCommand cmd = new SqlCommand();
            List<string> exerciseTypes = new List<string>();

            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetAllExerciseTypes; // or _dbContext.GetAllExerciseTypes if you define it
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string type = reader["ExerciseType"]?.ToString();
                    if (!string.IsNullOrWhiteSpace(type))
                    {
                        exerciseTypes.Add(type);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetAllExerciseTypes));
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return exerciseTypes;
        }
        public List<ExerciseTimeRange> GetTimeRange_ExerciseType(string exerciseType)
        {
            SqlCommand cmd = new SqlCommand();
            List<ExerciseTimeRange> timeRanges = new List<ExerciseTimeRange>();

            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetExerciseStartEndTimesByType; // or _dbContext.GetAllExerciseTypes if you define it
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ExerciseType", exerciseType);
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ExerciseTimeRange range = new ExerciseTimeRange
                    {
                        ExerciseStartTime = Convert.ToDateTime(reader["ExerciseStartTime"]),
                        ExerciseEndTime = reader["ExerciseEndTime"] != DBNull.Value
                            ? Convert.ToDateTime(reader["ExerciseEndTime"])
                            : (DateTime?)null
                    };

                    timeRanges.Add(range);
                }

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetTimeRange_ExerciseType));
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return timeRanges;
        }
        #endregion

        #endregion

        #region SNMP Region
        /// <summary>
        /// Get Live Date
        /// </summary>
        /// <param name="pdu"></param>
        /// <param name="_subsysIp"></param>
        /// <param name="isSubSystem"></param>
        /// <returns></returns>
        public Dictionary<string, ParameterSetConfig> getSnmpNonTrapLastLiveMessage(byte[] pdu, string _subsysIp, IsSubSystem isSubSystem)
        {
            Dictionary<string, ParameterSetConfig> resultCollection = new Dictionary<string, ParameterSetConfig>();

            string rqOID = string.Empty;
            string EliminaterqOID = string.Empty;
            byte[] byteData = new byte[4096];

            try
            {

                byteData = pdu;
                List<Vb> vbs = new List<Vb>();

                OctetString community = new OctetString("public");

                // Define agent parameters class
                AgentParameters param = new AgentParameters(community);

                IpAddress agent = new IpAddress(_subsysIp);
                // Construct target

                RsSnmp.UdpTarget target = new RsSnmp.UdpTarget((IPAddress)agent, 161, 5000, 1);

                // Set SNMP version to 1 (or 2)
                int protocolVersion = SnmpPacket.GetProtocolVersion(pdu, pdu.Length);

                Pdu pduResult = new Pdu();

                if (protocolVersion == (int)SnmpVersion.Ver1)
                {
                    param.Version = SnmpVersion.Ver1;
                    SnmpV1Packet result1 = (SnmpV1Packet)target.ResponseOffline(pdu, param);
                    if (result1 != null)
                    {
                        pduResult = result1.Pdu;
                    }
                }

                else if (protocolVersion == (int)SnmpVersion.Ver2)
                {
                    param.Version = SnmpVersion.Ver2;
                    SnmpV2Packet result2 = (SnmpV2Packet)target.ResponseOffline(pdu, param);
                    if (result2 != null)
                    {
                        pduResult = result2.Pdu;

                    }

                }

                if (pduResult.ErrorStatus == 0)
                {
                    int countPramsrequest = pduResult.VbCount;
                    const int MIN_OID_LENGTH = 11;
                    const int MID_OID_LENGTH = 15;
                    const int MAX_OID_LENGTH = 19;
                    const int ACTIVE_SLOT_INDEX = 16;
                    const int FALLBACK_SLOT_INDEX = 19;
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, (Action)delegate
                    {
                        if (countPramsrequest > 0)
                        {
                            float rqParmsValue = 0.0f;
                            vbs = pduResult.ToList();
                            Dictionary<string, ParameterSetConfig> keyValueDgCollection = new Dictionary<string, ParameterSetConfig>();

                            keyValueDgCollection = getSubSysParameterConfig(isSubSystem);
                            //var x = vbs[0].Oid.ToString();

                            int rqOID1 = vbs[0].Oid.Length;
                            if (rqOID1 >= MIN_OID_LENGTH && rqOID1 <= MID_OID_LENGTH)
                            {
                                rqOID = vbs[0].Oid.ToString();
                            }
                            else if (rqOID1 == 10 && rqOID1 <= 11)
                            {
                                rqOID = vbs[0].Oid.ToString();
                            }
                            else if (rqOID1 >= MID_OID_LENGTH && rqOID1 <= MAX_OID_LENGTH)
                            {
                                string Activesloat = string.Empty;
                                rqOID = vbs[0].Oid.ToString();

                                if (vbs[0].Oid.Length > ACTIVE_SLOT_INDEX)
                                    Activesloat = vbs[0].Oid[ACTIVE_SLOT_INDEX].ToString().Trim();

                                rqOID = vbs[0].Oid.ToString().Substring(0, Common.txpwrslot.Length - 8 + Common.ActiveSloat);
                                rqOID = rqOID + Activesloat;
                            }
                            else if (isSubSystem == IsSubSystem.Radio)
                            {
                                string Activesloat = string.Empty;
                                var oidParts = vbs[0].Oid.ToString().Split('.');
                                if (oidParts.ToString().Length >= 15)
                                {
                                    Activesloat = vbs[0].Oid[FALLBACK_SLOT_INDEX].ToString().Trim();
                                }
                                rqOID = vbs[0].Oid.ToString().Substring(0, rqOID1 + Common.ActiveSloat);
                                rqOID = rqOID + "." + Activesloat;

                            }
                            else
                            {
                                rqOID = vbs[0].Oid.ToString();
                            }
                            string rqType = SnmpConstants.GetTypeName(vbs[0].Value.Type);


                            string rqValue = string.Empty;
                            rqValue = vbs[0].Value.ToString();


                            if (keyValueDgCollection.ContainsKey(rqOID))
                            {
                                if (rqType.Equals("Opaque") || rqType.Equals("Unknown"))
                                {

                                    setConfig = keyValueDgCollection[rqOID];
                                    string FullrqOID = vbs[0].Oid.ToString();
                                    rqParmsValue = ConverASN_ToFloat(rqValue);
                                    string getValue = rqParmsValue.ToString();
                                    string getTimestamp = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                                    resultCollection.Add(rqOID, new ParameterSetConfig(FullrqOID, rqOID, setConfig.ParameterName, getValue, setConfig.MinValue,
                                        setConfig.MaxValue, setConfig.Redcolor, setConfig.Ambercolor, setConfig.Greencolor, getTimestamp));
                                }
                                else if (rqType.Equals("Gauge32") || rqType.Equals("Integer32") || rqType.Equals("Counter32") || rqType.Equals("IPAddress"))
                                {
                                    setConfig = keyValueDgCollection[rqOID];
                                    string FullrqOID = vbs[0].Oid.ToString();
                                    string getValue = rqValue;
                                    string getTimestamp = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                                    resultCollection.Add(FullrqOID, new ParameterSetConfig(FullrqOID, rqOID, setConfig.ParameterName, getValue, setConfig.MinValue,
                                        setConfig.MaxValue, setConfig.Redcolor, setConfig.Ambercolor, setConfig.Greencolor, getTimestamp));
                                }
                                else if (rqType.Equals("OctetString"))
                                {
                                    setConfig = keyValueDgCollection[rqOID];
                                    string FullrqOID = vbs[0].Oid.ToString();
                                    string getValue = rqValue;
                                    string getTimestamp = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                                    resultCollection.Add(rqOID, new ParameterSetConfig(FullrqOID, rqOID, setConfig.ParameterName, getValue, setConfig.MinValue,
                                        setConfig.MaxValue, setConfig.Redcolor, setConfig.Ambercolor, setConfig.Greencolor, getTimestamp));
                                }
                            }
                        }

                    });
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSnmpNonTrapLastLiveMessage));
            }
            return resultCollection;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subSystem"></param>
        /// <param name="target"></param>
        /// <param name="param"></param>
        public void getSnmpWalkNonTrapLastLiveMessage(SubSystem subSystem, UdpTarget target, AgentParameters param)
        {
            try
            {
                string startOid = FilenameOidDictionaty[subSystem.Filename];
                Oid rootOid = new Oid(startOid);
                Oid lastOid = (Oid)rootOid.Clone();

                while (true)
                {
                    Pdu pdu = new Pdu(PduType.GetNext);
                    pdu.VbList.Add(lastOid);

                    SnmpV2Packet result = (SnmpV2Packet)target.Request(pdu, param);

                    if (result == null || result.Pdu.ErrorStatus != 0 || result.Pdu.VbList.Count == 0)
                        break;

                    Vb vb = result.Pdu.VbList[0];

                    if (!rootOid.IsRootOf(vb.Oid))
                        break;

                    lastOid = vb.Oid;
                }
            }
            catch (SnmpException ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSnmpWalkNonTrapLastLiveMessage));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdu"></param>
        /// <param name="subsysIp"></param>
        /// <param name="isSubSystem"></param>
        /// <param name="SubSystemOid"></param>
        public void getLoadSnmpTrap(byte[] pdu, string subsysIp, IsSubSystem isSubSystem, string SubSystemOid)
        {

            byte[] byteData = new byte[4096];
            try
            {
                string[] genericTrap = { "coldStart", "warmStart", "linkDown", "linkUp", "authenticationFailure", "egpNeighborLoss", "enterpriseSpecific" };
                byteData = pdu;
                Oid entOid = new Oid(SubSystemOid);//41385-DG  // 21025
                List<Vb> vbs = new List<Vb>();
                OctetString community = new OctetString("public");
                //var entOidList = entOid.ToList();

                // Define agent parameters class
                AgentParameters param = new AgentParameters(community);

                IpAddress agent = new IpAddress(subsysIp);
                // Construct target

                RsSnmp.UdpTarget target = new RsSnmp.UdpTarget((IPAddress)agent, 162, 5000, 1);

                // Set SNMP version to 1 (or 2)
                int protocolVersion = SnmpPacket.GetProtocolVersion(pdu, pdu.Length);
                TrapEntity ObjTrap = new TrapEntity();

                if (protocolVersion == (int)SnmpVersion.Ver1)
                {
                    param.Version = SnmpVersion.Ver1;
                    param.DisableReplySourceCheck = true;
                    SnmpV1TrapPacket result = (SnmpV1TrapPacket)target.ResponseOffline(pdu, param);

                    string TrapType = string.Empty;
                    string TrapName = string.Empty;
                    string TrapValue = string.Empty;
                    string Traptime = string.Empty;
                    string ResultofTrap = string.Empty;
                    string SystemName = string.Empty;
                    string Alarmid = string.Empty;
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, (Action)delegate
                    {
                        string TrapDescvalue = string.Empty;
                        string TrapnotificationDescvalue = string.Empty;
                        if (result != null)
                            if (result != null)
                            {
                                if (result.Pdu.Enterprise.Equals(entOid))
                                {
                                    int trapNo = result.Pdu.Generic;
                                    if (trapNo >= 0 && trapNo <= 5)
                                    {
                                        Alarmid = result.Pdu.VbList[0].Value.ToString();
                                        int CountofSpecificTrap = result.Pdu.VbCount;
                                        if (CountofSpecificTrap == 0)
                                        {
                                            TrapType = "GenericTrap";
                                            TrapName = genericTrap[trapNo];
                                            TrapValue = result.Pdu.TimeStamp.ToString();
                                            Traptime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                                            ObjTrap.SubsystemIP = subsysIp;
                                            ObjTrap.TrapName = TrapName;
                                            ObjTrap.TrapTimeStamp = ConvertTrapTimestamp(TrapValue);
                                            //ObjTrap.TrapValue = ConvertTrapTimestamp(TrapValue);
                                            ObjTrap.TrapValue = string.Empty;
                                            ObjTrap.TrapGroup = TrapName;
                                            ObjTrap.DateTimestamp = Traptime;
                                            int TrapSpecificValueInt = int.Parse(result.Pdu.Specific.ToString());
                                            TrapDescvalue = Common.TrapConfigData[TrapSpecificValueInt];
                                            ObjTrap.Alarmid = Alarmid;
                                            SystemName = GetSubsystemName(subsysIp);
                                            GenerateTrapNonTrapTxt(SystemName, TrapName, TrapType, ConvertTrapTimestamp(TrapValue), string.Empty, Traptime, TrapDescvalue, Common.Nontrap, "", "", null, null);

                                            GenerateSubsystemTrapText(SystemName, TrapName, TrapType, ConvertTrapTimestamp(TrapValue), string.Empty, Traptime, TrapDescvalue,
                                                 Alarmid, Common.Trap, null, null, null, null);
                                            _trapCollection = GetTrapTextCollection();
                                            bool IsStatus = SaveSubSystemTrapData(ObjTrap);
                                        }
                                        if (CountofSpecificTrap > 0)
                                        {
                                            TrapName = genericTrap[trapNo];
                                            TrapType = "SpecificTrap";
                                            for (int i = 0; i < CountofSpecificTrap; i++)
                                            {
                                                string rxOID = result.Pdu.VbList[i].Oid.ToString();
                                                string rxType = SnmpConstants.GetTypeName(result.Pdu.VbList[i].Value.Type);
                                                TrapValue = ConvertTrapTimestamp(result.Pdu.TimeStamp.ToString());
                                                string TrapSpecificValue = result.Pdu.VbList[i].Value.ToString();
                                                Traptime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                                                ObjTrap.SubsystemIP = subsysIp;
                                                ObjTrap.TrapName = TrapName;
                                                ObjTrap.TrapTimeStamp = TrapValue;
                                                ObjTrap.TrapValue = TrapSpecificValue;
                                                ObjTrap.TrapGroup = TrapName;
                                                ObjTrap.DateTimestamp = Traptime;
                                                ObjTrap.Alarmid = Alarmid;
                                                int TrapSpecificValueInt = int.Parse(result.Pdu.Specific.ToString());
                                                TrapDescvalue = Common.TrapConfigData[TrapSpecificValueInt];
                                                SystemName = GetSubsystemName(subsysIp);
                                                GenerateTrapNonTrapTxt(SystemName, TrapName, TrapType, TrapValue, TrapSpecificValue, Traptime, TrapDescvalue, Common.Nontrap, "", "", null, null);

                                                GenerateSubsystemTrapText(SystemName, TrapName, TrapType, TrapValue, TrapSpecificValue, Traptime, TrapDescvalue, Alarmid, Common.Trap, null, null, null, null);
                                                _trapCollection = GetTrapTextCollection();
                                                bool IsStatus = SaveSubSystemTrapData(ObjTrap);
                                            }
                                        }
                                    }
                                    if (trapNo == Common.SpecificTrap)
                                    {

                                        TrapType = "SpecificTrap";
                                        TrapName = genericTrap[trapNo];

                                        int CountofSpecificTrap = result.Pdu.VbCount;
                                        if (CountofSpecificTrap > 0)
                                        {
                                            string rxOID = result.Pdu.VbList[0].Oid.ToString();
                                            string rxType = SnmpConstants.GetTypeName(result.Pdu.VbList[0].Value.Type);
                                            TrapValue = ConvertTrapTimestamp(result.Pdu.Specific.ToString());
                                            string TrapSpecificValue = result.Pdu.VbList[0].Value.ToString();
                                            string TrapSpecificValue1 = result.Pdu.VbList[1].Value.ToString();
                                            Alarmid = result.Pdu.VbList[0].Value.ToString();

                                            var oid = result.Pdu.VbList[1].Oid.ToString();  // Check if this gives access to the OID object
                                            string[] parts = oid.Split('.');
                                            string lastPart = parts[parts.Length - 1];

                                            // Print the last part
                                            Console.WriteLine("Last part of OID: " + lastPart);

                                            Traptime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                                            ObjTrap.SubsystemIP = subsysIp;
                                            ObjTrap.TrapName = TrapName;
                                            ObjTrap.TrapTimeStamp = TrapValue;
                                            ObjTrap.TrapValue = TrapSpecificValue;
                                            ObjTrap.TrapGroup = TrapName;
                                            ObjTrap.DateTimestamp = Traptime;
                                            ObjTrap.Alarmid = Alarmid;
                                            ObjTrap.SubsystemId = "2";
                                            SystemName = GetSubsystemName(ObjTrap.SubsystemId);
                                            int TrapSpecificValueInt = int.Parse(result.Pdu.Specific.ToString());
                                            TrapDescvalue = Common.TrapConfigData[TrapSpecificValueInt];
                                            TrapType = Common.TrapNotificationConfigData[TrapSpecificValueInt];

                                            GenerateTrapNonTrapTxt(SystemName, TrapName, TrapType, TrapValue, TrapDescvalue, Traptime, TrapDescvalue, Common.Trap, null, null, null, null);
                                            GenerateSubsystemTrapText(SystemName, TrapType, TrapType, TrapValue, TrapSpecificValue, Traptime, TrapDescvalue, Alarmid, Common.Trap, null, null, null, null);
                                            _trapCollection = GetTrapTextCollection();
                                            bool IsStatus = SaveSubSystemTrapData(ObjTrap);
                                        }

                                    }
                                }
                            }
                    });
                }

                if (protocolVersion == (int)SnmpVersion.Ver2)
                {
                    param.Version = SnmpVersion.Ver2;
                    Pdu GetPduRequestTrap = new Pdu();

                    int CountTrpaRequest = GetPduRequestTrap.VbCount;
                    SnmpV2Packet result = (SnmpV2Packet)target.ResponseOffline(pdu, param);
                    Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, (Action)delegate
                    {
                        var deviceID = string.Empty;

                        if (result != null)
                        {
                            string TrapOid = string.Empty;
                            string TrapOid1 = string.Empty;
                            string TrapOid2 = string.Empty;
                            GetPduRequestTrap = result.Pdu;

                            var trapObjectIDsList = GetPduRequestTrap.TrapObjectID.ToList();
                            if (trapObjectIDsList.Count > 6)
                            {

                                deviceID = trapObjectIDsList[6].ToString();
                            }
                            if (deviceID == Common.UPSDeviceID)
                            {
                                try
                                {
                                    string TrapNotification = GetPduRequestTrap.TrapObjectID.ToString();
                                    int tmp = GetPduRequestTrap.VbCount;
                                    vbs = GetPduRequestTrap.ToList();

                                    Dictionary<string, TrapConfig> keyValueTrapCollection = new Dictionary<string, TrapConfig>();
                                    keyValueTrapCollection = getSubSysTrapConfig(isSubSystem);
                                    setTrapConfig = keyValueTrapCollection[TrapNotification];

                                    if (vbs.Count > 0)
                                    {
                                        string TrapType = setTrapConfig.TrapName;
                                        TrapOid = vbs[0].Oid.ToString();
                                        TrapOid1 = vbs[1].Oid.ToString();
                                        TrapOid2 = vbs[2].Oid.ToString();
                                        setTrapConfig = keyValueTrapCollection[TrapOid];
                                        setupsTrapConfig = keyValueTrapCollection[TrapOid1];
                                        setupsTrapConfigest = keyValueTrapCollection[TrapOid2];


                                        if (keyValueTrapCollection.ContainsKey(TrapOid))
                                        {
                                            string upsSecondsOnBattory = ((SnmpSharpNet.Integer32)(vbs[1].Value)).Value.ToString() + Common.Seconds;
                                            string RemainingUpsTime = ((SnmpSharpNet.Integer32)(vbs[2].Value)).Value.ToString() + DashboardCommonData.Minutes;
                                            string Mainvalue = string.Empty;
                                            string TrapValue = ((SnmpSharpNet.Integer32)(vbs[0].Value)).Value.ToString() + Common.Seconds;
                                            string TrapUpsname = setupsTrapConfig.TrapName;
                                            string TimeStamp = result.Pdu.TrapSysUpTime.ToString();
                                            string Traptime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                                            Mainvalue = !setTrapConfig.TrapName.Equals("dse74xxTrapState") ? Mainvalue = TrapValue : Mainvalue = Mainvalue.GetDgTrapStatus(TrapValue);

                                            ObjTrap.SubsystemIP = subsysIp;
                                            ObjTrap.TrapName = setTrapConfig.TrapName + "," + TrapUpsname + "," + setupsTrapConfigest.TrapName;
                                            ObjTrap.TrapTimeStamp = TimeStamp;
                                            ObjTrap.TrapValue = RemainingUpsTime + "," + Mainvalue + "," + upsSecondsOnBattory;
                                            ObjTrap.TrapGroup = TrapType;
                                            ObjTrap.DateTimestamp = Traptime;
                                            // ObjTrap.SubsystemId = "2";
                                            if (SubsytemInfo.AllSubSystemInfoDictionary["UPS2"] == subsysIp)
                                            {
                                                ObjTrap.SubsystemId = "7";
                                            }
                                            else if (SubsytemInfo.AllSubSystemInfoDictionary["UPS"] == subsysIp)
                                            {
                                                ObjTrap.SubsystemId = "2";
                                            }
                                            ObjTrap.TrapDesc = "NA";
                                            string SystemName = GetSubsystemName(ObjTrap.SubsystemId);
                                            GenerateTrapNonTrapTxt(SystemName, setTrapConfig.TrapName, TrapType, TimeStamp, Mainvalue, Traptime,
                                                null, Common.Nontrap, RemainingUpsTime, upsSecondsOnBattory, TrapUpsname, setupsTrapConfigest.TrapName);

                                            GenerateSubsystemTrapText(SystemName, setTrapConfig.TrapName, TrapType, TimeStamp, Mainvalue, Traptime, null, null,
                                            Common.Nontrap, RemainingUpsTime, upsSecondsOnBattory, TrapUpsname, setupsTrapConfigest.TrapName);
                                            _trapCollection = GetTrapTextCollection();

                                            bool IsStatus = SaveSubSystemTrapData(ObjTrap);
                                        }

                                    }
                                }
                                catch (Exception ex)
                                {
                                    LCPLogUtils.LogException(ex, GetType().Name, nameof(getLoadSnmpTrap));
                                }
                            }
                            ///DG event handling
                            else if (deviceID == Common.DigitalGrenratorDeviceID)
                            {
                                try
                                {

                                    string TrapNotification = GetPduRequestTrap.TrapObjectID.ToString();
                                    int tmp = GetPduRequestTrap.VbCount;
                                    vbs = GetPduRequestTrap.ToList();
                                    List<Vb> vbList = vbs.ToList();

                                    Dictionary<string, TrapConfig> keyValueTrapCollection = new Dictionary<string, TrapConfig>();
                                    keyValueTrapCollection = getSubSysTrapConfig(isSubSystem);

                                    setTrapConfig = keyValueTrapCollection[TrapNotification];
                                    if (vbs.Count > 0)
                                    {
                                        string TrapType = setTrapConfig.TrapName;
                                        setTrapConfig = keyValueTrapCollection[TrapNotification];
                                        //setupsTrapConfig = keyValueTrapCollection[TrapOid1];

                                        if (keyValueTrapCollection.ContainsKey(TrapNotification))
                                        {
                                            Vb Vbdse74xxlarmKeyID = vbList[0];
                                            Vb Vbdse74xxSeqNr = vbList[1];
                                            Vb Vbdse74xxTrapState = vbList[2];

                                            string dse74xxAlarmKeyID = Vbdse74xxlarmKeyID.Value.ToString();
                                            string dse74xxSeqNr = Vbdse74xxSeqNr.Value.ToString();
                                            int dse74xxTrapState = Convert.ToInt32(Vbdse74xxTrapState.Value.ToString());
                                            int DeviceTapinfo = Convert.ToInt32(trapObjectIDsList[9].ToString());
                                            string Mainvalue = string.Empty; string TrapValue = string.Empty;
                                            //string TrapValue = ((SnmpSharpNet.Integer32)(vbs[0].Value)).Value.ToString();
                                            if (vbs[0].Value is SnmpSharpNet.Counter32)
                                            {

                                                TrapValue = ((SnmpSharpNet.Counter32)(vbs[0].Value)).Value.ToString();
                                            }
                                            else if (vbs[0].Value is SnmpSharpNet.Integer32)
                                            {
                                                TrapValue = ((SnmpSharpNet.Integer32)(vbs[0].Value)).Value.ToString();
                                            }
                                            else
                                            {
                                                TrapValue = ((SnmpSharpNet.Integer32)(vbs[0].Value)).Value.ToString();
                                            }
                                            string TimeStamp = result.Pdu.TrapSysUpTime.ToString();
                                            string Traptime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                                            Mainvalue = !setTrapConfig.TrapName.Equals("dse74xxTrapState") ? Mainvalue = TrapValue : Mainvalue = Mainvalue.GetDgTrapStatus(TrapValue);
                                            ObjTrap.SubsystemIP = subsysIp;
                                            ObjTrap.TrapName = setTrapConfig.TrapName;
                                            ObjTrap.TrapTimeStamp = TimeStamp;
                                            //ObjTrap.TrapValue = Mainvalue;
                                            ObjTrap.TrapGroup = TrapType;
                                            ObjTrap.DateTimestamp = Traptime;
                                            if (SubsytemInfo.AllSubSystemInfoDictionary["Diesel Generator2"] == subsysIp)
                                            {
                                                ObjTrap.SubsystemId = "6";
                                            }
                                            else if (SubsytemInfo.AllSubSystemInfoDictionary["Diesel Generator"] == subsysIp)
                                            {
                                                ObjTrap.SubsystemId = "1";
                                            }

                                            string Trapdesc1 = DashboardCommonData.DgTrapNotificationDescInfo[DeviceTapinfo];
                                            string TrapStateDesc = DashboardCommonData.DgTrapStateInfo[dse74xxTrapState];
                                            string SystemName = GetSubsystemName(ObjTrap.SubsystemId);
                                            ObjTrap.TrapValue = TrapStateDesc;
                                            ObjTrap.TrapDesc = Trapdesc1;
                                            GenerateTrapNonTrapTxt(SystemName, setTrapConfig.TrapName, TrapType, TimeStamp, Mainvalue, Traptime,
                                                null, Common.Nontrap, dse74xxAlarmKeyID, dse74xxSeqNr, TrapStateDesc, Trapdesc1);

                                            GenerateSubsystemTrapText(SystemName, setTrapConfig.TrapName, TrapType, TimeStamp, Mainvalue, Traptime, null, null,
                                            Common.Nontrap, dse74xxAlarmKeyID, dse74xxSeqNr, TrapStateDesc, Trapdesc1);
                                            _trapCollection = GetTrapTextCollection();

                                            bool IsStatus = SaveSubSystemTrapData(ObjTrap);

                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    LCPLogUtils.LogException(ex, GetType().Name, nameof(getLoadSnmpTrap));
                                }
                            }
                            else if (deviceID == Common.RadioDeviceID)
                            {
                                try
                                {
                                    string TrapNotification = GetPduRequestTrap.TrapObjectID.ToString();
                                    int tmp = GetPduRequestTrap.VbCount;
                                    vbs = GetPduRequestTrap.ToList();
                                    List<Vb> vbList = vbs.ToList();

                                    Dictionary<string, TrapConfig> keyValueTrapCollection = new Dictionary<string, TrapConfig>();
                                    keyValueTrapCollection = getSubSysTrapConfig(isSubSystem);
                                    setTrapConfig = keyValueTrapCollection[TrapNotification];

                                    if (vbs.Count > 0)
                                    {
                                        string TrapType = setTrapConfig.TrapName;
                                        setTrapConfig = keyValueTrapCollection[TrapNotification];

                                        if (keyValueTrapCollection.ContainsKey(TrapNotification))
                                        {

                                            string Mainvalue = string.Empty;
                                            string TrapValue = ((SnmpSharpNet.OctetString)(vbs[0].Value)).ToString();
                                            string TimeStamp = result.Pdu.TrapSysUpTime.ToString();
                                            string Traptime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                                            ObjTrap.SubsystemIP = subsysIp;
                                            ObjTrap.TrapName = setTrapConfig.TrapName;
                                            ObjTrap.TrapTimeStamp = TimeStamp;
                                            ObjTrap.TrapValue = Mainvalue;
                                            ObjTrap.TrapGroup = TrapType;
                                            ObjTrap.DateTimestamp = Traptime;

                                            ObjTrap.TrapDesc = DashboardCommonData.RadioNotificationDescInfo[setTrapConfig.TrapName];// "NA";
                                            // ObjTrap.SubsystemId = "3";
                                            if (SubsytemInfo.AllSubSystemInfoDictionary["Radio2"] == subsysIp)
                                            {
                                                ObjTrap.SubsystemId = "8";
                                            }
                                            else if (SubsytemInfo.AllSubSystemInfoDictionary["Radio"] == subsysIp)
                                            {
                                                ObjTrap.SubsystemId = "3";
                                            }
                                            //ObjTrap.TrapName = DashboardCommonData.RadioNotificationDescInfo[TrapType];

                                            string SystemName = GetSubsystemName(ObjTrap.SubsystemId);
                                            GenerateTrapNonTrapTxt(SystemName, ObjTrap.TrapName, TrapType, TimeStamp, Mainvalue, Traptime,
                                                                                ObjTrap.TrapDesc, Common.Nontrap, ObjTrap.TrapName, null, null, null);
                                            GenerateSubsystemTrapText(SystemName, ObjTrap.TrapName, TrapType, TimeStamp, Mainvalue, Traptime, ObjTrap.TrapName, null, null, null, null,
                                            Common.Nontrap, null);
                                            _trapCollection = GetTrapTextCollection();

                                            bool IsStatus = SaveSubSystemTrapData(ObjTrap);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {

                                    LCPLogUtils.LogException(ex, GetType().Name, nameof(getLoadSnmpTrap));
                                }

                            }
                        }
                    });

                    Dictionary<string, ParameterSetConfig> loadDgCollection = new Dictionary<string, ParameterSetConfig>();

                    Pdu pduResult = new Pdu();

                    if (protocolVersion == (int)SnmpVersion.Ver1)
                    {
                        param.Version = SnmpVersion.Ver1;
                        SnmpV1Packet result1 = (SnmpV1Packet)target.ResponseOffline(pdu, param);
                        if (result1 != null)
                        {
                            pduResult = result1.Pdu;
                        }
                    }
                    else if (protocolVersion == (int)SnmpVersion.Ver2)
                    {
                        param.Version = SnmpVersion.Ver2;
                        SnmpV2Packet result2 = (SnmpV2Packet)target.ResponseOffline(pdu, param);
                        if (result2 != null)
                        {
                            pduResult = result2.Pdu;
                        }
                    }

                    if (pduResult.ErrorStatus == 0)
                    {
                        try
                        {

                            int countPramsrequest = pduResult.VbCount;

                            Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal, (Action)delegate
                            {
                                string rqOID = string.Empty;
                                if (countPramsrequest > 0)
                                {
                                    vbs = pduResult.ToList();
                                    var trapObjectIDsList = GetPduRequestTrap.TrapObjectID.ToList();
                                    rqOID = GetPduRequestTrap.TrapObjectID.ToString().Substring(0, 17);
                                    if (rqOID == "1.3.6.1.6.3.1.1.5" || rqOID == "1.3.6.1.6.3.1.1.4")
                                    {
                                        if (DashboardCommonData.SwitchwsOid == rqOID && subsysIp == DashboardCommonData.SwitchIp)
                                        {
                                            string TrapNotification = GetPduRequestTrap.TrapObjectID.ToString();
                                            int tmp = GetPduRequestTrap.VbCount;
                                            vbs = GetPduRequestTrap.ToList();
                                            List<Vb> vbList = vbs.ToList();

                                            Vb SwitchSubSystemUpTime = vbList[0];
                                            Vb SwitchSubSystemName = vbList[1];
                                            Vb SwitchSubSystemStatus = vbList[2];

                                            string TrapName = SwitchSubSystemName.Value.ToString();
                                            string EventName = TrapName.ToString() + " : " +
                                            DashboardCommonData.SwitchLink + vbList[3].Value.ToString().ToUpperInvariant().ToUpper();
                                            string Uptime = GetPduRequestTrap.TrapSysUpTime.ToString();

                                            string TimeStamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                                            ObjTrap.SubsystemIP = subsysIp;
                                            ObjTrap.TrapName = SwitchSubSystemName.Value.ToString();
                                            ObjTrap.TrapTimeStamp = TimeStamp;
                                            ObjTrap.DateTimestamp = Uptime;
                                            //ObjTrap.SubsystemId = "4";
                                            if (SubsytemInfo.AllSubSystemInfoDictionary["Switch2"] == subsysIp)
                                            {
                                                ObjTrap.SubsystemId = "9";
                                            }
                                            else if (SubsytemInfo.AllSubSystemInfoDictionary["Switch"] == subsysIp)
                                            {
                                                ObjTrap.SubsystemId = "4";
                                            }
                                            string SystemName = GetSubsystemName(ObjTrap.SubsystemId);
                                            if (DashboardCommonData.SwitchDataeleminate == TrapName.ToString())
                                            {
                                                return;
                                            }
                                            GenerateTrapNonTrapTxt(SystemName, TrapName, EventName, Uptime, "NA", TimeStamp,
                                                        null, "4", "NA", "NA", "NA", "NA");

                                            GenerateSubsystemTrapText(SystemName, TrapName, EventName, Uptime, TimeStamp, TimeStamp,
                                                        null, "4", "NA", "NA", "NA", "NA", "NA");

                                            _trapCollection = GetTrapTextCollection();


                                            bool IsStatus = SaveSubSystemTrapData(ObjTrap);
                                        }

                                        //else if (DashboardCommonData.SwitchwsOid == rqOID && subsysIp == DashboardCommonData.SwitchIp)
                                        //{
                                        //    //MessageBox.Show(GetPduRequestTrap.TrapObjectID.ToString());

                                        //    string TrapNotification = GetPduRequestTrap.TrapObjectID.ToString();
                                        //    int tmp = GetPduRequestTrap.VbCount;
                                        //    vbs = GetPduRequestTrap.ToList();
                                        //    List<Vb> vbList = vbs.ToList();

                                        //    Vb RouterSubSystemUpTime = vbList[0];
                                        //    Vb RouterSubSystemName = vbList[1];
                                        //    Vb RouterSubSystemStatus = vbList[2];
                                        //    string TrapName = RouterSubSystemName.Value.ToString();
                                        //    string EventName = vbList[3].Value.ToString().ToUpperInvariant().ToUpper();
                                        //    string Uptime = GetPduRequestTrap.TrapSysUpTime.ToString();

                                        //    string TimeStamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                                        //    ObjTrap.SubsystemIP = subsysIp;
                                        //    ObjTrap.TrapName = RouterSubSystemName.Value.ToString();
                                        //    ObjTrap.TrapTimeStamp = TimeStamp;
                                        //    ObjTrap.DateTimestamp = Uptime;
                                        //    ObjTrap.TrapValue = EventName;
                                        //    ObjTrap.Alarmid = "5";
                                        //    ObjTrap.SubsystemId = "5";
                                        //    string SystemName = GetSubsystemName(ObjTrap.SubsystemId);
                                        //    if (DashboardCommonData.RouterDataeleminate == TrapName.ToString())
                                        //    {
                                        //        return;
                                        //    }
                                        //    GenerateTrapNonTrapTxt(SystemName, TrapName, EventName, Uptime, "NA4", TimeStamp,
                                        //                "NA2", ObjTrap.SubsystemId, "NA1", "NA3", "NA5", "NA6");

                                        //    GenerateSubsystemTrapText(SystemName, TrapName, EventName, Uptime, TimeStamp, TimeStamp,
                                        //                "NA7", ObjTrap.SubsystemId, "NA8", "NA9", "NA10", "NA11", "NA12");

                                        //    _trapCollection = GetTrapTextCollection();
                                        //    bool IsStatus = SaveSubSystemTrapData(ObjTrap);

                                        //}
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                            });
                        }
                        catch (Exception ex)
                        {
                            LCPLogUtils.LogException(ex, GetType().Name, nameof(getLoadSnmpTrap));
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getLoadSnmpTrap));
            }
        }
        #endregion

        #region Configuration Region

        public string getEmailChar()
        {
            return _dbContext.CharEmail;
        }
        public List<string> ExtractTxtFileNames(string filePath)
        {
            var fileNames = new List<string>();

            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = line.Split(',');
                    if (parts.Length >= 5) // Ensure the 5th column contains the file name
                    {
                        string fileName = parts[4].Trim();  // The file name is at index 4
                        if (!string.IsNullOrWhiteSpace(fileName) && fileName.EndsWith(".txt"))
                        {
                            fileNames.Add(fileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ExtractTxtFileNames));
            }
            return fileNames;
        }
        public void GetBaseOidFromConfigFileFirstLine()
        {
            try
            {
                if (!isFirst)
                {
                    isFirst = true;
                    if (FilenameOidDictionaty.Count > 0)
                        FilenameOidDictionaty.Clear();

                    //string ConfigSubsystemPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName +
                    //    @"\SystemConfig\ConfigSubsystem.txt";
                    string ConfigSubsystemPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings","ConfigData", "ConfigSubsystem.txt");
                    var files = ExtractTxtFileNames(ConfigSubsystemPath);
                    var subsystems = new List<IsSubSystem>
                    {
                        IsSubSystem.DieselGenerator,
                        IsSubSystem.UPS,
                        IsSubSystem.Router,
                        IsSubSystem.Radio,
                        IsSubSystem.Switch
                    };

                    var pathMap = subsystems
                                  .Select(s => getSubSystemConfigPath(s))
                                  .Where(path => !string.IsNullOrWhiteSpace(path))
                                  .ToDictionary(path => Path.GetFileName(path), path => path);

                    foreach (var fileName in files)
                    {
                        if (pathMap.TryGetValue(fileName, out string filePath))
                        {
                            if (filePath != null && !string.IsNullOrWhiteSpace(filePath))
                            {
                                try
                                {
                                    string firstLine = File.ReadLines(filePath).FirstOrDefault();

                                    if (!string.IsNullOrWhiteSpace(firstLine))
                                    {
                                        var fullOid = firstLine.Split(',').FirstOrDefault()?.Trim();
                                        if (!string.IsNullOrWhiteSpace(fullOid))
                                        {
                                            var oidRoot = string.Join(".", fullOid.Split('.').Take(7));
                                            FilenameOidDictionaty[fileName] = oidRoot;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    LCPLogUtils.LogException(ex, GetType().Name, nameof(GetBaseOidFromConfigFileFirstLine));
                                }
                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetBaseOidFromConfigFileFirstLine));
            }
        }
        public string getSubSystemName(IsSubSystem isSubSystem)
        {
            try
            {
                string subsystemid = string.Empty;
                int Result = (int)isSubSystem;
                switch (Result)
                {
                    case 0:
                        subsystemid = "192.168.10.156,1";
                        break;
                    case 1:
                        subsystemid = "192.168.10.120,5";
                        break;
                    case 2:
                        subsystemid = "192.168.20.137,3";
                        break;
                    case 3:
                        subsystemid = "192.168.10.150,4";
                        break;
                    case 4:
                        subsystemid = "192.168.10.137,2";
                        break;
                }
                return subsystemid;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSubSystemName));
            }
            return string.Empty;
        }
        public string getSubSystemConfigPath(IsSubSystem isSubSystem)
        {
            string fullPath = string.Empty;
            string workingDirectory;
            try
            {
                int Result = (int)isSubSystem;
                switch (Result)
                {
                    case 1:
                        workingDirectory = _dbContext.GetAppConfigPath(IsAppService.Maintenance, IsConfigFilename.ConfigDgset_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            fullPath = workingDirectory;
                        }
                        break;
                    case 2:
                        workingDirectory = _dbContext.GetAppConfigPath(IsAppService.Maintenance, IsConfigFilename.ConfigUPSset_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            fullPath = workingDirectory;
                        }
                        break;
                    case 3:
                        workingDirectory = _dbContext.GetAppConfigPath(IsAppService.Maintenance, IsConfigFilename.ConfigRadioset_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            fullPath = workingDirectory;
                        }
                        break;
                    case 4:
                        workingDirectory = _dbContext.GetAppConfigPath(IsAppService.Maintenance, IsConfigFilename.ConfigSwitchset_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            fullPath = workingDirectory;
                        }
                        break;
                    case 5:
                        workingDirectory = _dbContext.GetAppConfigPath(IsAppService.Maintenance, IsConfigFilename.ConfigRouterset_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            fullPath = workingDirectory;
                        }
                        break;
                    case 6:
                        workingDirectory = _dbContext.GetAppConfigPath(IsAppService.Maintenance, IsConfigFilename.ConfigDgset_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            fullPath = workingDirectory;
                        }
                        break;
                    case 7:
                        workingDirectory = _dbContext.GetAppConfigPath(IsAppService.Maintenance, IsConfigFilename.ConfigUPSset_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            fullPath = workingDirectory;
                        }
                        break;
                    case 8:
                        workingDirectory = _dbContext.GetAppConfigPath(IsAppService.Maintenance, IsConfigFilename.ConfigRadioset_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            fullPath = workingDirectory;
                        }
                        break;
                    case 9:
                        workingDirectory = _dbContext.GetAppConfigPath(IsAppService.Maintenance, IsConfigFilename.ConfigSwitchset_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            fullPath = workingDirectory;
                        }
                        break;
                    case 10:
                        workingDirectory = _dbContext.GetAppConfigPath(IsAppService.Maintenance, IsConfigFilename.ConfigRouterset_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            fullPath = workingDirectory;
                        }
                        break;
                }
                return fullPath;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSubSystemConfigPath));
                return null;
            }
        }
        public string getSubSystemConfigTrap(IsSubSystem isSubSystem)
        {
            string TrapfullPath = string.Empty;
            string workingDirectory;
            try
            {
                int Result = (int)isSubSystem;
                switch (Result)
                {
                    case 1:
                        workingDirectory = _dbContext.GetAppConfigTrapPath(IsAppService.Maintenance, IsConfigTrap.DgTrapConfig_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            TrapfullPath = workingDirectory;
                        }
                        break;
                    case 2:
                        workingDirectory = _dbContext.GetAppConfigTrapPath(IsAppService.Maintenance, IsConfigTrap.UPSTrapConfig_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            TrapfullPath = workingDirectory;
                        }
                        break;
                    case 3:
                        workingDirectory = _dbContext.GetAppConfigTrapPath(IsAppService.Maintenance, IsConfigTrap.RadioTrapConfig_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            TrapfullPath = workingDirectory;
                        }
                        break;
                    case 4:
                        workingDirectory = _dbContext.GetAppConfigTrapPath(IsAppService.Maintenance, IsConfigTrap.SwitchTrapConfig_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            TrapfullPath = workingDirectory;
                        }
                        break;
                    case 5:
                        workingDirectory = _dbContext.GetAppConfigTrapPath(IsAppService.Maintenance, IsConfigTrap.RouterTrapConfig_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            TrapfullPath = workingDirectory;
                        }
                        break;
                    case 6:
                        workingDirectory = _dbContext.GetAppConfigTrapPath(IsAppService.Maintenance, IsConfigTrap.DgTrapConfig_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            TrapfullPath = workingDirectory;
                        }
                        break;
                    case 7:
                        workingDirectory = _dbContext.GetAppConfigTrapPath(IsAppService.Maintenance, IsConfigTrap.UPSTrapConfig_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            TrapfullPath = workingDirectory;
                        }
                        break;
                    case 8:
                        workingDirectory = _dbContext.GetAppConfigTrapPath(IsAppService.Maintenance, IsConfigTrap.RadioTrapConfig_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            TrapfullPath = workingDirectory;
                        }
                        break;
                    case 9:
                        workingDirectory = _dbContext.GetAppConfigTrapPath(IsAppService.Maintenance, IsConfigTrap.SwitchTrapConfig_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            TrapfullPath = workingDirectory;
                        }
                        break;
                    case 10:
                        workingDirectory = _dbContext.GetAppConfigTrapPath(IsAppService.Maintenance, IsConfigTrap.RouterTrapConfig_txt);
                        if (!string.IsNullOrEmpty(workingDirectory))
                        {
                            TrapfullPath = workingDirectory;
                        }
                        break;
                }
                return TrapfullPath;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSubSystemConfigTrap));
                return null;
            }
        }
        public string getSubSystemFilePath(IsAppService isAppService)
        {
            int? AppServiceIndex;
            string AppConfigPath = string.Empty;
            try
            {
                AppServiceIndex = (int)isAppService;
                switch (AppServiceIndex)
                {
                    case 0:
                        AppConfigPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\SystemConfig\ConfigSubsystem.txt";
                        break;
                    case 1:
                        AppConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                            + @"\LCPReportingSystem\LCPReportingSystem\SystemConfig\ConfigSubsystem.txt";
                        break;
                }
                return AppConfigPath;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSubSystemFilePath));
                return null;
            }
        }
        public ObservableCollection<SubSysParameterConfig> getSubSystemConfiguration(IsSubSystem isSubSystem)
        {
            ObservableCollection<SubSysParameterConfig> _subsystemConfigCollection = new ObservableCollection<SubSysParameterConfig>();
            try
            {
                string[] SubSysConfigCollection = File.ReadAllLines(getSubSystemConfigPath(isSubSystem));
                if (SubSysConfigCollection.Length > 0)
                {
                    foreach (string subSysItem in SubSysConfigCollection)
                    {
                        string[] LineItem = subSysItem.Split(',');
                        if (LineItem.Length > 0)
                        {
                            string Oid = LineItem.Length > 0 ? LineItem[0].Trim() : "NA";
                            string DataType = LineItem.Length > 1 ? LineItem[1].Trim() : "NA";
                            string ParamName = LineItem.Length > 2 ? LineItem[2].Trim() : "NA";
                            string MinValue = LineItem.Length > 3 ? LineItem[3].Trim() : "NA";
                            string Maxvalue = LineItem.Length > 4 ? LineItem[4].Trim() : "NA";
                            string RedRange = LineItem.Length > 5 ? LineItem[5].Trim() : "NA";
                            string AmberRange = LineItem.Length > 6 ? LineItem[6].Trim() : "NA";
                            string Greenrange = LineItem.Length > 7 ? LineItem[7].Trim() : "NA";
                            _subsystemConfigCollection.Add(new SubSysParameterConfig(Oid, DataType, ParamName, MinValue, Maxvalue, RedRange, AmberRange, Greenrange));
                        }
                    }
                }
                return _subsystemConfigCollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSubSystemConfiguration));
                return null;
            }

        }
        private Dictionary<string, ParameterSetConfig> getSubSysParameterConfig(IsSubSystem isSubSystem)
        {
            Dictionary<string, ParameterSetConfig> dgCollection = new Dictionary<string, ParameterSetConfig>();
            try
            {
                string[] subsysPramsLines = File.ReadAllLines(getSubSystemConfigPath(isSubSystem));

                if (subsysPramsLines.Length > 0)
                {
                    foreach (string items in subsysPramsLines)
                    {
                        string[] paramItems = items.Split(',');
                        if (paramItems.Length > 0)
                        {
                            string oid = paramItems.Length > 0 ? paramItems[0].Trim() : "NA";
                            string dataType = paramItems.Length > 1 ? paramItems[1].Trim() : "NA";
                            string paramName = paramItems.Length > 2 ? paramItems[2].Trim() : "NA";
                            string minValue = paramItems.Length > 3 ? paramItems[3].Trim() : "NA";
                            string maxValue = paramItems.Length > 4 ? paramItems[4].Trim() : "NA";
                            string redIndicater = paramItems.Length > 5 ? paramItems[5].Trim() : "NA";
                            string amberIndicater = paramItems.Length > 6 ? paramItems[6].Trim() : "NA";
                            string greenIndicater = paramItems.Length > 7 ? paramItems[7].Trim() : "NA";

                            dgCollection.Add(oid, new ParameterSetConfig("", oid, paramName, string.Empty, minValue, maxValue, redIndicater, amberIndicater, greenIndicater));
                        }
                    }
                }
                return dgCollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSubSysParameterConfig));
                return null;
            }
        }
        private Dictionary<string, TrapConfig> getSubSysTrapConfig(IsSubSystem isSubSystem)
        {
            Dictionary<string, TrapConfig> TrapConfigData = new Dictionary<string, TrapConfig>();
            try
            {
                string[] subsysTrapLines = File.ReadAllLines(getSubSystemConfigTrap(isSubSystem));
                if (subsysTrapLines.Length > 0)
                {
                    foreach (string items in subsysTrapLines)
                    {
                        string[] TrapItems = items.Split(',');

                        string oid = TrapItems.Length > 0 ? TrapItems[0].Trim() : "NA";
                        string dataType = TrapItems.Length > 1 ? TrapItems[1].Trim() : "NA";
                        string TrapName = TrapItems.Length > 2 ? TrapItems[2].Trim() : "NA";
                        string Units = TrapItems.Length > 3 ? TrapItems[3].Trim() : "NA";

                        TrapConfigData.Add(oid, new TrapConfig(oid, dataType, TrapName, Units));
                        //MessageBox.Show(items);
                    }
                }
                return TrapConfigData;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSubSysTrapConfig));
                return null;
            }
        }

        #endregion

        #region Trap Region
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<TrapInfo> GetTrapTextCollection()
        {
            ObservableCollection<TrapInfo> trapcollection = new ObservableCollection<TrapInfo>();
            try
            {
                string[] subsysTrapLines = File.ReadAllLines(@"C:\ASSCII\SubsystemTrap.txt");

                if (subsysTrapLines.Length > 0)
                {
                    foreach (string items in subsysTrapLines)
                    {
                        string[] TrapItems = items.Split(',');
                        string SysName = TrapItems.Length > 0 ? TrapItems[0].Trim() : "NA";
                        string Pname = TrapItems.Length > 1 ? TrapItems[1].Trim() : "NA";
                        string Group = TrapItems.Length > 2 ? TrapItems[2].Trim() : "NA";
                        string uptimee = TrapItems.Length > 3 ? TrapItems[3].Trim() : "NA";
                        string othervalue = TrapItems.Length > 4 ? TrapItems[4].Trim() : "NA";
                        string timestamp = TrapItems.Length > 5 ? TrapItems[5].Trim() : "NA";
                        try
                        {
                            if (DateTime.TryParse(timestamp, out DateTime trapDateTime))
                            {
                                if (trapDateTime.Date != DateTime.Today)
                                    continue;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                        string trapdescr = TrapItems.Length > 6 ? TrapItems[6].Trim() : "NA";
                        string alarmid = TrapItems.Length > 7 ? TrapItems[7].Trim() : "NA";
                        string trapid = TrapItems.Length > 8 ? TrapItems[8].Trim() : "NA";
                        string RemainingUpsTime = TrapItems.Length > 9 ? TrapItems[9].Trim() : "NA";
                        string upsSecondsOnBattory = TrapItems.Length > 10 ? TrapItems[10].Trim() : "NA";
                        string upsTrapName = TrapItems.Length > 11 ? TrapItems[11].Trim() : "NA";
                        string upsLowBatteryTrapName = TrapItems.Length > 12 ? TrapItems[12].Trim() : "NA";

                        if (TrapItems[7] == "4")
                        {
                            Common.TrapDesc = string.Empty;
                        }
                        else if (TrapItems[0] == "Radio")
                        {
                            Common.TrapDesc = string.Empty;
                        }

                        if (trapid == Common.Nontrap)
                        {
                            string notificationDesc = Common.NotificationValue;
                            trapcollection.Add(new TrapInfo(SysName, Pname, Group, uptimee, othervalue, timestamp, RemainingUpsTime, upsSecondsOnBattory, Pname, upsLowBatteryTrapName, "",
                                notificationDesc, upsTrapName, Common.TrapparameterName, Common.TrapparameterValue, upsLowBatteryTrapName));
                        }
                        else
                        {
                            string notificationDesc = Common.NotificationDesc;
                            trapcollection.Add(new TrapInfo(SysName, Pname + Common.TrapDesc, Group, uptimee, othervalue, timestamp, trapdescr, null,
                                "NA", "NA", "NA", notificationDesc, null, Common.TrapparName, Common.TrapparValue, Common.UpsAlarmid));
                        }
                    }
                }
                return trapcollection;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetTrapTextCollection));
                return null;
            }
        }
        public DataTable GetSubsystemTrapData(IsSubSystem isSubSystem)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable DtTrapinfo = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetSubsystemTrapInfo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubsystemName", SqlDbType.VarChar, 100).Value = _dbContext.getSubSystemType(isSubSystem);
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(DtTrapinfo);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                if (string.IsNullOrWhiteSpace(Message))
                {
                    SystemSounds.Beep.Play();
                }
                return DtTrapinfo;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSubsystemTrapData));
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="trapEntity"></param>
        /// <returns></returns>
        private bool SaveSubSystemTrapData(TrapEntity trapEntity)
        {
            SqlCommand cmd = new SqlCommand();
            string IsSaveRecord = string.Empty;
            bool? IsStatus = null;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.SaveSubSystemTrapInfo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubSystemIP", SqlDbType.VarChar, 50).Value = trapEntity.SubsystemIP.Trim();
                cmd.Parameters.Add("@TrapName", SqlDbType.VarChar, 500).Value = trapEntity.TrapName.Trim();
                cmd.Parameters.Add("@TrapTimeStamp", SqlDbType.VarChar, 200).Value = trapEntity.TrapTimeStamp.Trim();
                cmd.Parameters.Add("@TrapValue", SqlDbType.VarChar, 500).Value = trapEntity.TrapValue.Trim();
                cmd.Parameters.Add("@TrapGroup", SqlDbType.VarChar, 500).Value = trapEntity.TrapGroup.Trim();
                cmd.Parameters.Add("@DateTimeStamp", SqlDbType.VarChar, 100).Value = trapEntity.DateTimestamp.Trim();
                cmd.Parameters.Add("@SubsystemId", SqlDbType.Int, 5).Value = trapEntity.SubsystemId;
                cmd.Parameters.Add("@TrapDesc", SqlDbType.VarChar, 500).Value = trapEntity.TrapDesc;
                cmd.Parameters.Add("@IsSaveRecord", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output;
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                int data = cmd.ExecuteNonQuery();

                if (string.IsNullOrEmpty(IsSaveRecord))
                {
                    IsSaveRecord = Convert.ToString(cmd.Parameters["@IsSaveRecord"].Value);
                    if (IsSaveRecord == "Success")
                    {
                        IsStatus = true;
                    }
                    else
                    {
                        IsStatus = false;
                    }
                }
                return (bool)IsStatus;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SaveSubSystemTrapData));
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        private string ConvertTrapTimestamp(string InputValue)
        {
            string Result = string.Empty;

            try
            {
                int TotalTime = Convert.ToInt32(InputValue);
                int hours = ((TotalTime / 100) / 60) / 60;
                int remainingSeconds = TotalTime % 3600;
                int minutes = remainingSeconds / 60;
                int seconds = remainingSeconds % 60;

                Result = $"{hours.ToString()} Hr : {minutes.ToString()} Min : {seconds.ToString()} Sec";
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ConvertTrapTimestamp));
            }
            return Result.ToString();
        }

        #endregion

        #region Archive Region

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="isSubSystem"></param>
        /// <param name="isTrap"></param>
        /// <returns></returns>
        public int GetArchiveDataTotalCount(string fromDate, string toDate, IsSubSystem isSubSystem, bool isTrap = false)
        {
            int Count = 0;
            int totalCount = 0;
            try
            {
                using (SqlConnection conn = _dbContext.getConnection)
                using (SqlCommand cmd = new SqlCommand(isTrap ? _dbContext.getArchiveTrapTotalCount : _dbContext.getArchiveTotalCount, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);
                    cmd.Parameters.AddWithValue("@SubsystemName", isSubSystem.ToString());
                    if (!isTrap)
                    {
                        cmd.Parameters.AddWithValue("@SubsystemId", (int)isSubSystem);
                    }

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        Count = Convert.ToInt32(result);
                }
                totalCount = (int)Math.Ceiling((double)Count / PageSize);
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetArchiveDataTotalCount));
            }
            return totalCount;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="isTrap"></param>
        /// <returns></returns>
        public DataTable GetFirstPage(IsSubSystem isSubSystem, string fromDate, string toDate, bool isTrap = false)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = _dbContext.getConnection)
            using (SqlCommand cmd = new SqlCommand(isTrap ? "GetArchiveTrapFirstPage" : "GetArchiveFirstPage", conn))
            {
                if (!isTrap)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FromDate", DateTime.Parse(fromDate));
                    cmd.Parameters.AddWithValue("@ToDate", DateTime.Parse(toDate));
                    cmd.Parameters.AddWithValue("@SubsystemId", (int)isSubSystem);
                    cmd.Parameters.AddWithValue("@SubsystemName", isSubSystem.ToString());
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FromDate", DateTime.Parse(fromDate));
                    cmd.Parameters.AddWithValue("@ToDate", DateTime.Parse(toDate));
                    cmd.Parameters.AddWithValue("@SubsystemName", isSubSystem.ToString());
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="subsystemId"></param>
        /// <param name="subsystemName"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="totalPages"></param>
        /// <param name="isFirst"></param>
        /// <param name="isInitial"></param>
        /// <param name="isLast"></param>
        /// <param name="isNext"></param>
        /// <param name="isPrev"></param>
        /// <param name="gotoPage"></param>
        /// <param name="isTrap"></param>
        /// <returns></returns>
        public DataTable GetArchiveDataPages(string fromDate, string toDate, string subsystemId, string subsystemName, int pageSize, ref int currentPage,
        int totalPages, bool isFirst = false, bool isInitial = false, bool isLast = false, bool isNext = false, bool isPrev = false, int? gotoPage = null, bool isTrap = false)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = _dbContext.getConnection)
                {
                    conn.Open();

                    // 1. Decide currentPage based on flags
                    if (gotoPage.HasValue) currentPage = gotoPage.Value;
                    else if (isInitial || isFirst) currentPage = 1;
                    else if (isLast) currentPage = totalPages;
                    else if (isNext && currentPage < totalPages)
                    {
                        if (!UsageConstants.IsGoToPage)
                        {
                            currentPage++;
                        }
                    }
                    else if (isPrev && currentPage > 1) currentPage--;

                    using (SqlCommand cmd = new SqlCommand(isTrap ? _dbContext.getArchiveTrapPage : _dbContext.getArchivePage, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
                        cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
                        cmd.Parameters.AddWithValue("@SubsystemName", subsystemName);
                        cmd.Parameters.AddWithValue("@PageSize", pageSize);
                        cmd.Parameters.AddWithValue("@PageNumber", currentPage);
                        if (!isTrap)
                        {
                            cmd.Parameters.AddWithValue("@SubsystemId", subsystemId);
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetArchiveDataPages));
            }

            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="isSqlFlag"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="ParamName"></param>
        /// <returns></returns>
        public DataTable getArchiveFilterData(IsSubSystem isSubSystem, IsSqlFlag isSqlFlag, string FromDate, string ToDate, string ParamName)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.getArchiveDataDatewise;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubSystemName", SqlDbType.VarChar, 50).Value = _dbContext.getSubSystemType(isSubSystem);
                cmd.Parameters.Add("@ParameterName", SqlDbType.VarChar, 100).Value = ParamName;
                cmd.Parameters.Add("@ProcedureFlag", SqlDbType.VarChar, 50).Value = _dbContext.GetSqlFlag(isSqlFlag);
                cmd.Parameters.Add("@Fromdate", SqlDbType.VarChar, 50).Value = FromDate;
                cmd.Parameters.Add("@ToDate", SqlDbType.VarChar, 50).Value = ToDate;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getArchiveFilterData));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                adapter.Dispose();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public string DeleteArchiveData(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            SqlCommand cmd = new SqlCommand();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.RemoveArciveData;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubSystemName", SqlDbType.VarChar, 50).Value = _dbContext.getSubSystemType(isSubSystem);
                cmd.Parameters.Add("@Fromdate", SqlDbType.VarChar, 50).Value = FromDate;
                cmd.Parameters.Add("@ToDate", SqlDbType.VarChar, 50).Value = ToDate;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                int Data = cmd.ExecuteNonQuery();

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                return Message;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(DeleteArchiveData));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedItems"></param>
        /// <param name="IsTrap"></param>
        /// <returns></returns>
        public async Task DeleteArchiveData(List<ArchiveData> selectedItems, bool IsTrap)
        {
            using (SqlConnection conn = _dbContext.getConnection)
            using (SqlCommand cmd = new SqlCommand("DeleteMultipleSelectedArchiveData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Create DataTable matching TVP
                DataTable tvp = new DataTable();
                tvp.Columns.Add("RecordID", typeof(int));
                tvp.Columns.Add("IsTrap", typeof(bool));

                foreach (var item in selectedItems)
                {
                    tvp.Rows.Add(item.RecordID, IsTrap); // ArchiveData should have IsTrap property
                }

                SqlParameter tvpParam = cmd.Parameters.AddWithValue("@Records", tvp);
                tvpParam.SqlDbType = SqlDbType.Structured;
                tvpParam.TypeName = "dbo.RecordIdTable";  // must match your TVP name

                SqlParameter messageParam = new SqlParameter("@Message", SqlDbType.VarChar, 200)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(messageParam);

                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                string resultMessage = (string)cmd.Parameters["@Message"].Value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dashBoard"></param>
        /// <returns></returns>
        public string SaveSubSystemArchiveData(DashBoard dashBoard)
        {
            SqlCommand cmd = new SqlCommand();
            string IsSaveRecord = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.SaveSubSystemInfo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubSystemIP", SqlDbType.VarChar, 50).Value = dashBoard.SubSystemIP;
                cmd.Parameters.Add("@PrameterName", SqlDbType.VarChar, 200).Value = dashBoard.PrameterName;
                cmd.Parameters.Add("@PrameterValue", SqlDbType.VarChar, 100).Value = dashBoard.PrameterValue;
                cmd.Parameters.Add("@DateTimeStamp", SqlDbType.VarChar, 100).Value = dashBoard.TimeStamp;
                cmd.Parameters.Add("@Units", SqlDbType.VarChar, 100).Value = dashBoard.UnitName;
                cmd.Parameters.Add("@SubsystemId", SqlDbType.Int).Value = dashBoard.SubsystemId;
                cmd.Parameters.Add("@IsSaveRecord", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output;
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                int data = cmd.ExecuteNonQuery();

                if (string.IsNullOrEmpty(IsSaveRecord))
                {
                    IsSaveRecord = Convert.ToString(cmd.Parameters["@IsSaveRecord"].Value);
                }
                return IsSaveRecord;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SaveSubSystemArchiveData));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="isSqlFlag"></param>
        /// <param name="SubsystemId"></param>
        /// <returns></returns>
        public DataTable getSubsystemArchiveData(IsSubSystem isSubSystem, IsSqlFlag isSqlFlag, int SubsystemId)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.getSubSystemArchiveData;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ProcedureFlag", SqlDbType.VarChar, 50).Value = _dbContext.GetSqlFlag(isSqlFlag);
                cmd.Parameters.Add("@SubsystemName", SqlDbType.VarChar, 50).Value = isSubSystem.ToString();// _dbContext.getSubSystemType(isSubSystem);
                cmd.Parameters.Add("@SubsystemId", SqlDbType.VarChar).Value = SubsystemId.ToString();
                cmd.Parameters.Add("@IsMessage", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);

                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@IsMessage"].Value);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSubsystemArchiveData));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                adapter.Dispose();
            }
        }

        #endregion

        #region GenerateFiles Region
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        public void GenerateErrorLog(Exception ex)
        {
            LCPLogUtils.LogException(ex, GetType().Name, nameof(GenerateErrorLog));
        }
        public void GenerateSubsystemTrapText(string SysName, string trapname, string traptype,
            string systemuptime, string additionalvalue, string timestamp, string trapdescription,
            string alarmid, string Trapid, string Remainingtime, string upsSecondsOnBattory, string TrapUpsname, string upsBackupTrapName)
        {

            StringBuilder sb = new StringBuilder();
            try
            {
                string folderPath = @"C:\ASSCII";
                string filePath = Path.Combine(folderPath, "SubsystemTrap.txt");

                sb.Append($"{SysName},{trapname},{traptype},{systemuptime},{additionalvalue},{timestamp}," +
                    $"{trapdescription},{alarmid},{Trapid},{Remainingtime},{upsSecondsOnBattory},{TrapUpsname},{upsBackupTrapName}");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(sb.ToString().TrimEnd());
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GenerateTrapNonTrapTxt));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SysName"></param>
        /// <param name="ParmsName"></param>
        /// <param name="value"></param>
        /// <param name="timestamp"></param>
        public void GenerateTrapNonTrapTxt(string SysName, string ParmsName, string value, string timestamp)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string folderPath = @"C:\ASSCII";
                string filePath = Path.Combine(folderPath, "Subsystem.txt");

                sb.AppendLine($"{SysName} , {ParmsName} , {value} , {timestamp}");
                sb.AppendLine($"----------------------------------------------------------------------------");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(sb.ToString().TrimEnd());
                }
                // Correct: Check if folder size exceeds 1MB
                long folderSize = GetFolderSize(folderPath);
                int FolderSizevalue = (int)Properties.Settings.Default.ZipFolderSize;
                long sizeLimit = 4L * FolderSizevalue * FolderSizevalue * FolderSizevalue; // 1 MB = 1048576 bytes

                if (folderSize >= sizeLimit)
                {
                    string timestampStr = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string backupBasePath = @"C:\NonTrap";
                    string duplicatePath = Path.Combine(backupBasePath, $"ASSCII_Copy_{timestampStr}");
                    string zipPath = Path.Combine(backupBasePath, $"ASSCII_{timestampStr}.zip");

                    Directory.CreateDirectory(backupBasePath);

                    CopyDirectory(folderPath, duplicatePath);
                    ZipFile.CreateFromDirectory(duplicatePath, zipPath, CompressionLevel.Optimal, false);

                    Directory.Delete(duplicatePath, true);
                    Directory.Delete(folderPath, true);
                    Directory.CreateDirectory(folderPath);
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GenerateTrapNonTrapTxt));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        private long GetFolderSize(string folderPath)
        {
            return Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories)
                            .Sum(file => new FileInfo(file).Length);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        private float ConverASN_ToFloat(string test)
        {
            float f = 0.00F;
            try
            {
                if (test == null)
                {
                    return 0.0f;
                }
                //-------------------------------------------------
                string test1 = test.Substring(9);
                string test2 = test1.Replace(" ", "");
                //-------------------------------------------------
                string test4 = test.Replace(" ", "");
                string test3 = test4.Substring(0, 4);

                //Validity
                uint asnType = uint.Parse(test3, System.Globalization.NumberStyles.AllowHexSpecifier);
                test3 = test4.Substring(4, 2);
                uint asnCount = uint.Parse(test3, System.Globalization.NumberStyles.AllowHexSpecifier);
                if (!((asnType == 0x9f78) && (asnCount == 4)))
                {
                    Console.WriteLine("Not Valid asnType float");
                    return 0.0f;
                }
                //-------------------------------------------------
                uint num = uint.Parse(test2, System.Globalization.NumberStyles.AllowHexSpecifier);
                byte[] floatVals = BitConverter.GetBytes(num);
                f = BitConverter.ToSingle(floatVals, 0);

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(ConverASN_ToFloat));
            }
            return f;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceDir"></param>
        /// <param name="destDir"></param>
        private void CopyDirectory(string sourceDir, string destDir)
        {
            Directory.CreateDirectory(destDir);

            foreach (var file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destDir, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }

            foreach (var dir in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = Path.Combine(destDir, Path.GetFileName(dir));
                CopyDirectory(dir, destSubDir);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SysName"></param>
        /// <param name="trapname"></param>
        /// <param name="traptype"></param>
        /// <param name="systemuptime"></param>
        /// <param name="additionalvalue"></param>
        /// <param name="timestamp"></param>
        /// <param name="trapdescription"></param>
        /// <param name="TrapType"></param>
        /// <param name="Remainingtime"></param>
        /// <param name="upsSecondsOnBattory"></param>
        /// <param name="TrapName1"></param>
        /// <param name="upsBackupTrapName"></param>
        public void GenerateTrapNonTrapTxt(string SysName, string trapname, string traptype, string systemuptime, string additionalvalue,
            string timestamp, string trapdescription, string TrapType, string Remainingtime, string upsSecondsOnBattory, string TrapName1, string upsBackupTrapName)
        {

            StringBuilder sb = new StringBuilder();
            try
            {
                string folderPath = @"C:\ASSCII";
                string filePath = Path.Combine(folderPath, "SubsystemTrap.txt");

                sb.AppendLine($"{SysName},{trapname},{traptype},{systemuptime},{additionalvalue}," +
                    $"{timestamp},{trapdescription},{TrapType},{Remainingtime},{upsSecondsOnBattory},{TrapName1},{upsBackupTrapName}");
                //sb.AppendLine($"-------------------------------------------------------------------------------------------------------------------------");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    //writer.WriteLine(sb.ToString().TrimEnd());
                }
                // Check folder size
                long folderSize = GetFolderSize(folderPath);
                int FolderSizevalue = (int)Properties.Settings.Default.ZipFolderSize;
                long sizeLimit = 4L * FolderSizevalue * FolderSizevalue * FolderSizevalue; // 1 MB = 1048576 bytes               

                if (folderSize >= sizeLimit)
                {
                    string timestampStr = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string backupBasePath = @"C:\Trap";
                    string duplicatePath = Path.Combine(backupBasePath, $"ASSCII_Copy_{timestampStr}");
                    string zipPath = Path.Combine(backupBasePath, $"ASSCII_{timestampStr}.zip");

                    if (!Directory.Exists(backupBasePath))
                        Directory.CreateDirectory(backupBasePath);

                    CopyDirectory(folderPath, duplicatePath);
                    ZipFile.CreateFromDirectory(duplicatePath, zipPath, CompressionLevel.Optimal, false);
                    Directory.Delete(duplicatePath, true);
                    Directory.Delete(folderPath, true);
                    Directory.CreateDirectory(folderPath);
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(getSubSystemFilePath));
            }
        }

        #endregion

        #region GetData Region
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<TrapInfo> getTrap()
        {
            return _trapCollection;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubSystemIP"></param>
        /// <param name="SubsystemId"></param>
        /// <param name="Parameterinfo"></param>
        /// <returns></returns>
        public Boolean SetSubsystemParmsDetailsInfo(string SubSystemIP, string SubsystemId, params string[] Parameterinfo)
        {
            SqlCommand cmd = new SqlCommand();
            string IsSaveRecord = string.Empty;
            bool? IsStatus = null;
            // Declare and initialize

            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.SaveSubsystemParmsDetails;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ParamsId", SqlDbType.Int, 50).Value = j;
                cmd.Parameters.Add("@SubSystemIP", SqlDbType.VarChar, 50).Value = SubSystemIP;
                cmd.Parameters.Add("@PrameterOid", SqlDbType.VarChar, 500).Value = Parameterinfo[0].Trim();
                cmd.Parameters.Add("@ParameterType", SqlDbType.VarChar, 200).Value = Parameterinfo[1].Trim();
                cmd.Parameters.Add("@PrameterName", SqlDbType.VarChar, 500).Value = Parameterinfo[2].Trim();
                cmd.Parameters.Add("@ParamsMinValue", SqlDbType.VarChar, 500).Value = Parameterinfo[3].Trim();
                cmd.Parameters.Add("@ParamsMaxValue", SqlDbType.VarChar, 500).Value = Parameterinfo[4].Trim();

                cmd.Parameters.Add("@RedColor", SqlDbType.Decimal, 100).Value = Parameterinfo[5].Trim();//decimal
                cmd.Parameters.Add("@AmberColor", SqlDbType.Decimal, 500).Value = Parameterinfo[6].Trim();//decimal
                cmd.Parameters.Add("@GreenColor", SqlDbType.Decimal, 500).Value = Parameterinfo[7].Trim();//decimal
                                                                                                          //cmd.Parameters.Add("@CurrentDate", SqlDbType.DateTime, 500).Value = DateTime.Now;//decimal

                cmd.Parameters.Add("@SubsystemId", SqlDbType.Int, 5).Value = SubsystemId;
                cmd.Parameters.Add("@IsSaveRecord", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                int data = cmd.ExecuteNonQuery();
                j++;
                if (string.IsNullOrEmpty(IsSaveRecord))
                {
                    IsSaveRecord = Convert.ToString(cmd.Parameters["@IsSaveRecord"].Value);
                    if (IsSaveRecord == "Success")
                    {
                        IsStatus = true;
                    }
                    else
                    {
                        IsStatus = false;
                    }
                }
                return (bool)IsStatus;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(SetSubsystemParmsDetailsInfo));
                return false;
            }

            //return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sysip"></param>
        /// <returns></returns>
        public string GetSubsystemName(string sysip)
        {
            SqlCommand cmd = new SqlCommand();
            string SubsystemName = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetSubSystemName;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@SubsystemId", SqlDbType.VarChar, 100).Value = sysip;
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                if (string.IsNullOrEmpty(SubsystemName))
                {
                    SubsystemName = cmd.ExecuteScalar().ToString();
                }
                return SubsystemName;

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSubsystemName));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public DataTable GetActivityData_DB(string FromDate, string ToDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetActivityReportByDate;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Fromdate", SqlDbType.DateTime).Value = Convert.ToDateTime(FromDate);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = Convert.ToDateTime(ToDate);
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetActivityData_DB));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                adapter.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public DataTable GetFaultData_DB(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string Message = string.Empty;
            try
            {
                int Subsystemid = (int)isSubSystem;
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.getFaultDataDatewise;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Fromdate", SqlDbType.DateTime).Value = Convert.ToDateTime(FromDate);
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = Convert.ToDateTime(ToDate);
                cmd.Parameters.Add("@SubsystemId", SqlDbType.VarChar, 100).Value = Subsystemid;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetFaultData_DB));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                adapter.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public DataTable GetNonTrapReportData_DB(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            DateTime fromDate = DateTime.ParseExact(FromDate, "dd-MM-yyyy HH:mm:ss", CultureInfo.CurrentCulture);
            DateTime toDate = DateTime.ParseExact(ToDate, "dd-MM-yyyy HH:mm:ss", CultureInfo.CurrentCulture);
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.getArchiveDataDatewise;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubSystemName", SqlDbType.VarChar, 50).Value = isSubSystem.ToString();// _dbContext.getSubSystemType(isSubSystem);
                cmd.Parameters.Add("@Fromdate", SqlDbType.DateTime).Value = fromDate;
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetNonTrapReportData_DB));
                return null;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
                adapter.Dispose();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSubSystem"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public DataTable GetTrapReportData_DB(IsSubSystem isSubSystem, string FromDate, string ToDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable DtTrapinfoDatewise = new DataTable();
            DateTime fromDate = DateTime.ParseExact(FromDate, "dd-MM-yyyy HH:mm:ss", CultureInfo.CurrentCulture);
            DateTime toDate = DateTime.ParseExact(ToDate, "dd-MM-yyyy HH:mm:ss", CultureInfo.CurrentCulture);
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetSubsystemTrapInfoDatewise;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubsystemName", SqlDbType.VarChar, 100).Value = _dbContext.getSubSystemType(isSubSystem).Trim();
                cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate;
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(DtTrapinfoDatewise);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                return DtTrapinfoDatewise;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetTrapReportData_DB));
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="subsystemId"></param>
        /// <returns></returns>
        public List<TrapTypeSummary> GetTrapTypeSummary(string startDate, string endDate, int subsystemId)
        {
            var result = new List<TrapTypeSummary>();
            DateTime fromDate = DateTime.ParseExact(startDate, "dd-MM-yyyy HH:mm:ss", CultureInfo.CurrentCulture);
            DateTime toDate = DateTime.ParseExact(endDate, "dd-MM-yyyy HH:mm:ss", CultureInfo.CurrentCulture);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = _dbContext.getConnection;
            cmd.CommandText = _dbContext.GetTrapNameCount;
            cmd.CommandType = CommandType.StoredProcedure;
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();

            cmd.Parameters.AddWithValue("@FromDate", fromDate);
            cmd.Parameters.AddWithValue("@ToDate", toDate);
            cmd.Parameters.AddWithValue("@SubsystemId", subsystemId);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new TrapTypeSummary
                {
                    TrapType = reader["TrapGroup"].ToString(),
                    Count = Convert.ToInt32(reader["TrapCount"])
                });
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isRequestType"></param>
        /// <returns></returns>
        public string GetRequestType(IsRequestType isRequestType)
        {
            string RequestType = string.Empty;
            try
            {

                int IsRequtIdex = (int)isRequestType;
                switch (IsRequtIdex)
                {
                    case 0:
                        RequestType = "BindByCombo";
                        break;
                }
                return RequestType;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, GetType().Name, nameof(GetRequestType));
            }
            return RequestType;
        }

        #endregion

        #region Separate Types Region
        public enum SortDirection
        {
            Ascending,
            Descending
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class SortableObservableCollection<T> : ObservableCollection<T>
        {
            public void Sort<TKey>(Func<T, TKey> keySelector, SortDirection direction)
            {
                switch (direction)
                {
                    case SortDirection.Ascending:
                        ApplySort(Items.OrderBy(keySelector));
                        break;
                    case SortDirection.Descending:
                        ApplySort(Items.OrderByDescending(keySelector));
                        break;
                }
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="sortedItems"></param>
            private void ApplySort(IEnumerable<T> sortedItems)
            {
                var sortedList = sortedItems.ToList();
                for (int i = 0; i < sortedList.Count; i++)
                {
                    Move(IndexOf(sortedList[i]), i);
                }
            }
        }

        #endregion

    }
}
