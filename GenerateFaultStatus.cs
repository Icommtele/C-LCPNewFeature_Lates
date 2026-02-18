using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LCPInfrastructure;
using LCPReportingSystem.DbHelper;
using LCPReportingSystem.View;
using Newtonsoft.Json;
using SnmpSharpNet;

namespace LCPReportingSystem
{
    public static  class GenerateFaultStatus
    {
        private static Queue<string> lineQueueDG = new Queue<string>();
        private static Queue<string> lineQueueUPS = new Queue<string>();
        private static Queue<string> lineQueueRadio = new Queue<string>();
        private static Queue<string> lineQueueSwitch = new Queue<string>();
        private static Dictionary<string, Queue<string>> subsystemOID = new Dictionary<string, Queue<string>>();
        private static Dictionary<string, SubsystemStatus> subsystemStatuses = new Dictionary<string, SubsystemStatus>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileIndex"></param>
        /// <returns></returns>
        public static string GetSystemPath(int FileIndex)
        {
            string Filename = string.Empty;
            try
            {

                switch (FileIndex)
                {
                    case 1:
                        Filename = @"ConfigDgset.txt";
                        break;
                    case 2:
                        Filename = @"UPSNonTrapConfigset.txt";
                        break;
                    case 3:
                        Filename = @"ConfigRadioset.txt";
                        break;
                    case 4:
                        Filename = @"ConfigSwitchset.txt";
                        break;
                }

            }
            catch (Exception ex)
            {
               
                LCPLogUtils.LogException(ex, typeof(GenerateFaultStatus).Name, nameof(GetSystemPath));
            }
            return Filename;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subsystemConfig"></param>
        private static void GetDgData(SnmpConfig subsystemConfig)
        {
            try
            {
                int index = 1;
                string configDir2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings", "ConfigData");
                string configDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Settings\ConfigData";
                if (!Directory.Exists(configDir))
                {
                    Directory.CreateDirectory(configDir);
                }
                string fileName = string.Empty;
                foreach (var sub in subsystemConfig.Subsystems)
                {
                    if (index <= 4)
                    {
                        int a = index++;
                        fileName = Path.Combine(configDir, GetSystemPath(a));
                        if (!File.Exists(fileName))
                            continue;
                    }

                    if (sub.Subsytem.Contains("Diesel"))
                    {
                        if (lineQueueDG.Count == 0)
                        {
                            foreach (var line in File.ReadLines(fileName))
                            {
                                string[] parts = line.Split(',');
                                if (parts.Length == 0) continue;

                                string oid = parts[0].Replace("\t", "").Replace(" ", "");
                                lineQueueDG.Enqueue(oid);
                                subsystemOID[sub.Subsytem] = lineQueueDG;
                                break;
                                //if (parts[0].EndsWith(".1"))
                                //{
                                //    oid = oid.Substring(0, oid.LastIndexOf(".1"));
                                //    lineQueueDG.Enqueue(oid);
                                //    subsystemOID[sub.Subsytem] = lineQueueDG;
                                //}
                            }
                        }
                        else
                        {
                            subsystemOID[sub.Subsytem] = lineQueueDG;
                        }

                    }
                    else if (sub.Subsytem.Contains("UPS"))
                    {
                        if (lineQueueUPS.Count == 0)
                        {
                            foreach (var line in File.ReadLines(fileName))
                            {
                                string[] parts = line.Split(',');
                                if (parts.Length == 0) continue;

                                string oid = parts[0].Replace("\t", "").Replace(" ", "");

                                lineQueueUPS.Enqueue(oid);
                                subsystemOID[sub.Subsytem] = lineQueueUPS;
                                break;

                            }
                        }
                        else
                        {
                            subsystemOID[sub.Subsytem] = lineQueueUPS;
                        }
                    }
                    else if (sub.Subsytem.Contains("Radio"))
                    {
                        if (lineQueueRadio.Count == 0)
                        {
                            foreach (var line in File.ReadLines(fileName))
                            {
                                string[] parts = line.Split(',');
                                if (parts.Length == 0) continue;

                                string oid = parts[0].Replace("\t", "").Replace(" ", "");

                                lineQueueRadio.Enqueue(oid);
                                subsystemOID[sub.Subsytem] = lineQueueRadio;
                                break;

                            }
                        }
                        else
                        {
                            subsystemOID[sub.Subsytem] = lineQueueRadio;
                        }
                        //if (lineQueueRadio.Count == 0)
                        //{
                        //    foreach (var line in File.ReadLines(fileName))
                        //    {
                        //        string[] parts = line.Split(',');
                        //        if (parts.Length == 0) continue;

                        //        string baseOid = parts[0].Replace("\t", "").Replace(" ", "");

                        //        // Scalar (.0) → enqueue directly
                        //        if (baseOid.EndsWith(".0"))
                        //        {
                        //            lineQueueRadio.Enqueue(baseOid);
                        //        }
                        //        else
                        //        {
                        //            // Table → discover valid indices dynamically
                        //            List<string> discoveredOids = DiscoverTableOids(sub.Ip, baseOid);
                        //            foreach (var oid in discoveredOids)
                        //            {
                        //                lineQueueRadio.Enqueue(oid);
                        //            }
                        //        }
                        //        subsystemOID[sub.Subsytem] = lineQueueRadio;
                        //    }
                        //}
                        //else
                        //{
                        //    subsystemOID[sub.Subsytem] = lineQueueRadio;
                        //}
                    }
                    else if (sub.Subsytem.Contains("Switch"))
                    {
                        if (lineQueueSwitch.Count == 0)
                        {
                            foreach (var line in File.ReadLines(fileName))
                            {
                                string[] parts = line.Split(',');
                                if (parts.Length == 0) continue;

                                string oid = parts[0].Replace("\t", "").Replace(" ", "");

                                lineQueueSwitch.Enqueue(oid);
                                subsystemOID[sub.Subsytem] = lineQueueSwitch;
                                    break;
                            }
                        }
                        else
                        {
                            subsystemOID[sub.Subsytem] = lineQueueSwitch;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, typeof(GenerateFaultStatus).Name, nameof(GetDgData));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static async void Start_SNMP_Polling()
        {
            try
            {
               
                var community = new OctetString("public");
                var param = new AgentParameters(community) { Version = SnmpVersion.Ver2 };
                string configPath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings", "ConfigData", "SnmpConfig.json"); //Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configuration", "SnmpConfig.json");
               // string configPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Settings\ConfigData\SnmpConfig.json";
                string json = File.ReadAllText(configPath2);
                var config = JsonConvert.DeserializeObject<SnmpConfig>(json);
                GetDgData(config);

                while (UsageConstants.keepRunning)
                {
                   
                    foreach (var subsystem in config.Subsystems)
                    {
                        bool isReachable = false;
                        try
                        {
                            using (Ping ping = new Ping())
                            {
                                PingReply reply = ping.Send(subsystem.Ip, 2000);
                                if (reply.Status == IPStatus.Success)
                                {
                                    UdpTarget target = new UdpTarget(IPAddress.Parse(subsystem.Ip), 161, 2000, 1);
                                    var oids = subsystemOID[subsystem.Subsytem].ToList();
                                    var snmpOk = await PerformSnmpGetAllAsync(target, param, oids);

                                    if (snmpOk != null && snmpOk.Count > 0 && snmpOk.Values.Any(v => v))
                                        isReachable = true;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LCPLogUtils.LogException(ex, typeof(GenerateFaultStatus).Name, nameof(Start_SNMP_Polling));
                        }

                        if (!subsystemStatuses.ContainsKey(subsystem.Ip))
                        {
                            SubsystemStatus sub = new SubsystemStatus();
                            sub.Ip = subsystem.Ip;
                            sub.IsOnline = true;
                            sub.FaultStartTime = null;
                            sub.ActiveFaultId = null;

                            subsystemStatuses[subsystem.Ip] = sub;
                        }

                        var status = subsystemStatuses[subsystem.Ip];

                        // Subsystem just went down
                        if (!isReachable && status.IsOnline)
                        {
                            status.FaultStartTime = DateTime.Now;
                            status.IsOnline = false;
                            status.ActiveFaultId = InsertFaultToDb(subsystem.Subsytem, subsystem.SubsystemId, status.FaultStartTime.Value, " ");
                        }
                        // Subsystem came back up
                        else if (isReachable && !status.IsOnline)
                        {
                            DateTime faultEndTime = DateTime.Now;
                            int duration = (int)(faultEndTime - status.FaultStartTime.Value).TotalMinutes;
                            UpdateFaultInDb(status.ActiveFaultId.Value, faultEndTime, duration, " ");
                            status.IsOnline = true;
                            status.FaultStartTime = null;
                            status.ActiveFaultId = null;
                        }
                    }
                    await Task.Delay((int)Properties.Settings.Default.DataUpdatingTimepriod_Seconds * 60 * 1000);

                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, typeof(GenerateFaultStatus).Name, nameof(Start_SNMP_Polling));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Subsystem"></param>
        /// <param name="SubsystemId"></param>
        /// <param name="faultStart"></param>
        /// <param name="ErrorLogFilePath"></param>
        /// <returns></returns>
        private static int InsertFaultToDb(string Subsystem, int SubsystemId, DateTime faultStart, string ErrorLogFilePath)
        {
            try
            {
                DbContext _dbContext = new DbContext();
                using (SqlConnection conn = _dbContext.getConnection)
                {
                    var cmd = new SqlCommand("InsertSubsystemFaultStatus", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SubSystem", Subsystem);
                    cmd.Parameters.AddWithValue("@SubsystemId", SubsystemId);
                    cmd.Parameters.AddWithValue("@FaultStartTime", faultStart);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    var insertedId = (int)cmd.ExecuteScalar();
                    return insertedId;
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText(ErrorLogFilePath, $"Worker Error: {ex.Message}{Environment.NewLine}");
            }
            finally
            {               
            }
            return 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="faultId"></param>
        /// <param name="endTime"></param>
        /// <param name="duration"></param>
        /// <param name="ErrorLogFilePath"></param>
        private static void UpdateFaultInDb(int faultId, DateTime endTime, int duration, string ErrorLogFilePath)
        {
            try
            {
                DbContext _dbContext = new DbContext();
                using (SqlConnection conn = _dbContext.getConnection)
                {
                    var cmd = new SqlCommand("UpdateSubsystemFaultStatus", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", faultId);
                    cmd.Parameters.AddWithValue("@FaultEndTime", endTime);
                    cmd.Parameters.AddWithValue("@DurationInMinutes", duration);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(ErrorLogFilePath, $"Worker Error: {ex.Message}{Environment.NewLine}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sharedTarget"></param>
        /// <param name="param"></param>
        /// <param name="oids"></param>
        /// <returns></returns>
        private static async Task<ConcurrentDictionary<string, bool>> PerformSnmpGetAllAsync(UdpTarget sharedTarget, AgentParameters param, List<string> oids)
        {
            try
            {
                var oidStatus = new ConcurrentDictionary<string, bool>();
                var semaphore = new SemaphoreSlim(5);

                var tasks = oids.Select(async oid =>
                {
                    await semaphore.WaitAsync();
                    try
                    {
                        var pdu = new Pdu(PduType.Get);
                        pdu.VbList.Add(oid);

                        var requestTask = Task.Run(() =>
                        {
                            try
                            {
                                using (var localTarget = new UdpTarget(sharedTarget.Address, sharedTarget.Port, sharedTarget.Timeout, sharedTarget.Retry))
                                {
                                    return (SnmpV2Packet)localTarget.Request(pdu, param);
                                }
                            }
                            catch (Exception ex)
                            {
                                return null;
                            }
                        });

                        var completed = await Task.WhenAny(requestTask, Task.Delay(5000));
                        if (completed != requestTask)
                        {
                            oidStatus[oid] = false;
                            return;
                        }

                        var result = await requestTask;
                        if (result != null && result.Pdu.ErrorStatus == 0 && result.Pdu.VbList.Count > 0)
                        {
                            var value = result.Pdu.VbList[0].Value;
                            if (value.Type == SnmpConstants.SMI_ENDOFMIBVIEW ||
                                value.Type == SnmpConstants.SMI_NOSUCHINSTANCE ||
                                value.Type == SnmpConstants.SMI_NOSUCHOBJECT)
                            {
                                oidStatus[oid] = false;
                            }
                            else
                            {
                                oidStatus[oid] = true;
                            }
                        }
                        else
                        {
                            oidStatus[oid] = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        oidStatus[oid] = false;

                    }
                    finally
                    {
                        semaphore.Release();
                    }
                });

                await Task.WhenAll(tasks);
                return oidStatus;
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, typeof(GenerateFaultStatus).Name, nameof(PerformSnmpGetAllAsync));
            }
            return null;
        }

    }
}
