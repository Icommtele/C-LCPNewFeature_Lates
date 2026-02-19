using CommonLib;
using LCPInfrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DashboardCommonDataLib
{
    /// <summary>
    /// DG Events
    /// </summary>
    /// 
  #region System of Units
    public static class DashboardCommonData
    {

        public static Dictionary<int, string> DgTrapNotificationDescInfo = new Dictionary<int, string>(); 
        public static Dictionary<int, string> DgTrapStateInfo = new Dictionary<int, string>();
        public static Dictionary<int, string> SwitchNotificationDescInfo = new Dictionary<int, string>();
        public static Dictionary<string, string> RadioNotificationDescInfo = new Dictionary<string, string>();
        public static string Minutes = " Min";
        public static string AmpDC = " Amp DC";
        public static string degreesC = " °C";
        public static string Hertz = " Hertz";
        public static string RMSVolts = " RMS Volts";
        public static string RMSAmp = " RMS Amp";
        public static string Watts = " Watts";
        public static string SmallAC = " V AC";
        public static string SmallHz = " Hz";
        public static string SmallAmpA = " A";
        public static string SmallWattw = " W";
        public static string SmallVA = " VA";
        public static string SmallFacter = "";
        public static string SmalloilKPa = " KPa";
        public static string SmallEngineTemp = "°C";
        public static string SmallEngineoilTemp = " °C";
        public static string SmallEngineFualTemp = "";
        public static string SmallEngineAltVoltsTemp = " V";
        public static string SmallbatteryVolts = " V DC";
        public static string SmallEngineModHours = "";
        public static int SmallChangeindecimal = 10;                                
        
        public static string  SwitchDataeleminate = "Vlan100";
        public static string RouterDataeleminate = "Vlan10";
        public static string  SwitchwsOid = "1.3.6.1.6.3.1.1.5";
        public static string SwitchIp = "192.168.10.150"; 
        public static string RouterIp = "192.50.0.1";
        public static string SwitchLink = "LINK  ";
        public static string PortInterface = "Interface Port "; 
        public static string EventType = "EventType";
        public static string NotificationDescription = "Notification Description";
        public static string TrapDescr = "Notification Name ";

        public static int SubsystemStatus = 1;
        public static  DataTable DtCollectTrapInfo = new DataTable();
        public static int DeviceSinglecall = 0;

        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="countinfo"></param>
        public static void DgTrapstateInfo(int countinfo = 1)
        {

            try
            {
                if (DgTrapStateInfo.Count <= countinfo)
                {
                    DashboardCommonData.DgTrapStateInfo.Add(1, "Alarm Normal");
                    DashboardCommonData.DgTrapStateInfo.Add(2, "Alarm Warning");
                    DashboardCommonData.DgTrapStateInfo.Add(3, "Alarm Electrical Trip");
                    DashboardCommonData.DgTrapStateInfo.Add(4, "Alarm Shut down");
                    DashboardCommonData.DgTrapStateInfo.Add(5, "Mode Stop");
                    DashboardCommonData.DgTrapStateInfo.Add(6, "Mode Manual");
                    DashboardCommonData.DgTrapStateInfo.Add(7, "Mode Test");
                    DashboardCommonData.DgTrapStateInfo.Add(8, "Mode Auto");
                    DashboardCommonData.DgTrapStateInfo.Add(9, "Mode Config");
                    DashboardCommonData.DgTrapStateInfo.Add(10, "Single Event Notification");
                    DashboardCommonData.DgTrapStateInfo.Add(11, "EcuLamp Off");
                    DashboardCommonData.DgTrapStateInfo.Add(12, "Ecu Lamp Flash Slow");
                    DashboardCommonData.DgTrapStateInfo.Add(13, "Ecu Lamp Flash Fast");
                    DashboardCommonData.DgTrapStateInfo.Add(14, "Ecu Lamp On Steady");
                    DashboardCommonData.DgTrapStateInfo.Add(15, "Fuel Level Usage Normal");
                    DashboardCommonData.DgTrapStateInfo.Add(16, "Fuel Level End Fill");
                    DashboardCommonData.DgTrapStateInfo.Add(17, "Fuel Level Start Fill");
                    DashboardCommonData.DgTrapStateInfo.Add(18, "Fuel Level Usage Theft Alarm");
                    DashboardCommonData.DgTrapStateInfo.Add(19, "Fuel Level Usage Level Alarm");
                }

            }
            catch (Exception ex)
            {
               LCPLogUtils.LogException(ex, "DgTrapstateInfo", nameof(DgTrapstateInfo));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="countinfo"></param>
        public static void SwitchLoadNotificationInfo(int countinfo = 1)
        {

            try
            {
                if (SwitchNotificationDescInfo.Count <= countinfo)
                {
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(1, "Link Down");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(2, "Cold Start");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(3, "Warm Start");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4, "Link UP");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(5, "Aunthentication failed");
                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, "SwitchLoadNotificationInfo", nameof(SwitchLoadNotificationInfo));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="countinfo"></param>
        public static void RadioLoadNotificationInfo(int countinfo = 1)
        {

            if (DashboardCommonData.RadioNotificationDescInfo.Count <= 1)
            {
                DashboardCommonData.RadioNotificationDescInfo.Add("txpllLock", "Emitted when txPLL  1- lock");
                DashboardCommonData.RadioNotificationDescInfo.Add("rxpllLock", "rxPLL-lock status 0 - unlock");
                DashboardCommonData.RadioNotificationDescInfo.Add("txLowPower", "Transmit power low notification  1- lock");
                DashboardCommonData.RadioNotificationDescInfo.Add("syncLossSlt1", "Synchronization lost notification for slot1");
                DashboardCommonData.RadioNotificationDescInfo.Add("syncLossSlt2", "Synchronization lost notification for slot2");
                DashboardCommonData.RadioNotificationDescInfo.Add("syncLossSlt3", "Synchronization lost notification for slot3");
                DashboardCommonData.RadioNotificationDescInfo.Add("syncLossSlt4", "Synchronization lost notification for slot4");
                DashboardCommonData.RadioNotificationDescInfo.Add("syncLossSlt5", "Synchronization lost notification for slot5");
                DashboardCommonData.RadioNotificationDescInfo.Add("syncLossSlt6", "Synchronization lost notification for slot6");
                DashboardCommonData.RadioNotificationDescInfo.Add("sysVoltagesOutOfLimitminus5V", "abnormal voltages minus 5V");
                DashboardCommonData.RadioNotificationDescInfo.Add("sysVoltagesOutOfLimitplu5V", "abnormal voltages plus 5V");
                DashboardCommonData.RadioNotificationDescInfo.Add("sysVoltagesOutOfLimitplus30V", "abnormal voltages plus 30V");
                DashboardCommonData.RadioNotificationDescInfo.Add("sysVoltagesOutOfLimitplus49V", "abnormal voltages plus 49V");
            }
        }
        #region Dg Notificationb
        /// <summary>
        ///  DG Trap info
        /// </summary>
        public static void DigitalGeneratorLoadNotificationInfo(int countinfo = 1)
        {

            try
            {
                if (DgTrapNotificationDescInfo.Count <= countinfo)
                {
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8192, "Digital Input A");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8193, "Digital Input B");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8194, "Digital Input C");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8195, "Digital Input D");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8196, "Digital Input E");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8197, "Digital Input F");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8198, "Digital Input G");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8199, "Digital Input H");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8696, "Analogue Input A (Digital)");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8589, "Analogue Input B (Digital)");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8590, "Analogue Input C (Digital)");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8670, "Analogue Input D (Digital)");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8712, "Analogue Input E (Digital)");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8714, "Analogue Input F (Digital)");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8224, "2130 Expansion Module ID0 Digital Input A");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8225, "2130 Expansion Module ID0 Digital Input B");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8226, "2130 Expansion Module ID0 Digital Input C");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8211, "2130 Expansion Module ID0 Digital Input D");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8212, "2130 Expansion Module ID0 Digital Input E");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8213, "2130 Expansion Module ID0 Digital Input F");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8214, "2130 Expansion Module ID0 Digital Input G");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8215, "2130 Expansion Module ID0 Digital Input H");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8216, "2130 Expansion Module ID1 Digital Input A");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8217, "2130 Expansion Module ID1 Digital Input B");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8218, "2130 Expansion Module ID1 Digital Input C");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8219, "2130 Expansion Module ID1 Digital Input D");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8220, "2130 Expansion Module ID1 Digital Input E");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8221, "2130 Expansion Module ID1 Digital Input F");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8222, "2130 Expansion Module ID1 Digital Input G");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8223, "2130 Expansion Module ID1 Digital Input H");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8240, "2130 Expansion Module ID2 Digital Input A");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8241, "2130 Expansion Module ID2 Digital Input B");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8242, "2130 Expansion Module ID2 Digital Input C");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8243, "2130 Expansion Module ID2 Digital Input D");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8244, "2130 Expansion Module ID2 Digital Input E");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8245, "2130 Expansion Module ID2 Digital Input F");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8246, "2130 Expansion Module ID2 Digital Input G");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8247, "2130 Expansion Module ID2 Digital Input H");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8248, "2130 Expansion Module ID3 Digital Input A");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8249, "2130 Expansion Module ID3 Digital Input B");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8250, "2130 Expansion Module ID3 Digital Input C");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8251, "2130 Expansion Module ID3 Digital Input D");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8252, "2130 Expansion Module ID3 Digital Input E");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8253, "2130 Expansion Module ID3 Digital Input F");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8254, "2130 Expansion Module ID3 Digital Input G");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8255, "2130 Expansion Module ID3 Digital Input H");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8304, "2130 Expansion Module ID0 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8305, "2130 Expansion Module ID0 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8306, "2130 Expansion Module ID0 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8307, "2130 Expansion Module ID0 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8308, "2130 Expansion Module ID0 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8309, "2130 Expansion Module ID0 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8310, "2130 Expansion Module ID0 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8311, "2130 Expansion Module ID0 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8296, "2130 Expansion Module ID1 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8297, "2130 Expansion Module ID1 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8298, "2130 Expansion Module ID1 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8299, "2130 Expansion Module ID1 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8300, "2130 Expansion Module ID1 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8301, "2130 Expansion Module ID1 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8302, "2130 Expansion Module ID1 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8303, "2130 Expansion Module ID1 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8320, "2130 Expansion Module ID2 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8321, "2130 Expansion Module ID2 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8322, "2130 Expansion Module ID2 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8323, "2130 Expansion Module ID2 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8324, "2130 Expansion Module ID2 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8325, "2130 Expansion Module ID2 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8326, "2130 Expansion Module ID2 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8327, "2130 Expansion Module ID2 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8616, "2130 Expansion Module ID3 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8617, "2130 Expansion Module ID3 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8618, "2130 Expansion Module ID3 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8619, "2130 Expansion Module ID3 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8332, "2130 Expansion Module ID3 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8333, "2130 Expansion Module ID3 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8334, "2130 Expansion Module ID3 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8335, "2130 Expansion Module ID3 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8368, "Flexible Sensor A Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8369, "Flexible Sensor A High");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8370, "Maintenance Alarm 1");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8371, "Maintenance Alarm 2");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8372, "Maintenance Alarm 3");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8373, "PLC Alarm 1");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8374, "PLC Alarm 2");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8375, "PLC Alarm 3");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8376, "PLC Alarm 4");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8377, "PLC Alarm 5");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8378, "PLC Alarm 6");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8379, "PLC Alarm 7");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8380, "PLC Alarm 8");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8381, "PLC Alarm 9");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8382, "PLC Alarm 10");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8383, "PLC Alarm 11");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8384, "PLC Alarm 12");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8385, "PLC Alarm 13");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8410, "PLC Alarm 14");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8411, "PLC Alarm 15");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8412, "PLC Alarm 16");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8413, "PLC Alarm 17");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8414, "PLC Alarm 18");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8415, "PLC Alarm 19");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8392, "PLC Alarm 20");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8742, "Flexible Sensor A Fault");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8386, "Flexible Sensor B Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8387, "Flexible Sensor B High");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8743, "Flexible Sensor B Fault");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8388, "Flexible Sensor C Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8389, "Flexible Sensor C High");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8744, "Flexible Sensor C Fault");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8390, "Flexible Sensor D Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8391, "Flexible Sensor D High");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8745, "Flexible Sensor D Fault");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8721, "Flexible Sensor E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8722, "Flexible Sensor E High");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8746, "Flexible Sensor E Fault");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8723, "Flexible Sensor F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8724, "Flexible Sensor F High");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8747, "Flexible Sensor F Fault");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8524, "2133 Expansion Module ID0 Analogue Input A Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8525, "2133 Expansion Module ID0 Analogue Input A Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8526, "2133 Expansion Module ID0 Analogue Input B Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8527, "2133 Expansion Module ID0 Analogue Input B Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8528, "2133 Expansion Module ID0 Analogue Input C Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8529, "2133 Expansion Module ID0 Analogue Input C Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8530, "2133 Expansion Module ID0 Analogue Input D Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8531, "2133 Expansion Module ID0 Analogue Input D Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8532, "2133 Expansion Module ID0 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8533, "2133 Expansion Module ID0 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8534, "2133 Expansion Module ID0 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8535, "2133 Expansion Module ID0 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8536, "2133 Expansion Module ID0 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8537, "2133 Expansion Module ID0 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8538, "2133 Expansion Module ID0 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8539, "2133 Expansion Module ID0 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8540, "2133 Expansion Module ID1 Analogue Input A Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8541, "2133 Expansion Module ID1 Analogue Input A Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8542, "2133 Expansion Module ID1 Analogue Input B Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8543, "2133 Expansion Module ID1 Analogue Input B Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8544, "2133 Expansion Module ID1 Analogue Input C Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8545, "2133 Expansion Module ID1 Analogue Input C Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8546, "2133 Expansion Module ID1 Analogue Input D Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8547, "2133 Expansion Module ID1 Analogue Input D Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8548, "2133 Expansion Module ID1 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8549, "2133 Expansion Module ID1 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8550, "2133 Expansion Module ID1 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8551, "2133 Expansion Module ID1 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8552, "2133 Expansion Module ID1 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8553, "2133 Expansion Module ID1 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8554, "2133 Expansion Module ID1 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8555, "2133 Expansion Module ID1 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8556, "2133 Expansion Module ID2 Analogue Input A Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8557, "2133 Expansion Module ID2 Analogue Input A Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8558, "2133 Expansion Module ID2 Analogue Input B Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8559, "2133 Expansion Module ID2 Analogue Input B Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8560, "2133 Expansion Module ID2 Analogue Input C Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8562, "2133 Expansion Module ID2 Analogue Input D Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8563, "2133 Expansion Module ID2 Analogue Input D Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8564, "2133 Expansion Module ID2 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8565, "2133 Expansion Module ID2 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8566, "2133 Expansion Module ID2 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8567, "2133 Expansion Module ID2 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8568, "2133 Expansion Module ID2 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8569, "2133 Expansion Module ID2 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8570, "2133 Expansion Module ID2 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8571, "2133 Expansion Module ID2 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8572, "2133 Expansion Module ID3 Analogue Input A Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8573, "2133 Expansion Module ID3 Analogue Input A Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8574, "2133 Expansion Module ID3 Analogue Input B Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8575, "2133 Expansion Module ID3 Analogue Input B Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8576, "2133 Expansion Module ID3 Analogue Input C Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8577, "2133 Expansion Module ID3 Analogue Input C Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8578, "2133 Expansion Module ID3 Analogue Input D Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8579, "2133 Expansion Module ID3 Analogue Input D Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8580, "2133 Expansion Module ID3 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8581, "2133 Expansion Module ID3 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8582, "2133 Expansion Module ID3 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8583, "2133 Expansion Module ID3 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8584, "2133 Expansion Module ID3 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8585, "2133 Expansion Module ID3 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8586, "2133 Expansion Module ID3 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8587, "2133 Expansion Module ID3 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8444, "2131 Expansion Module ID0 Analogue Input A Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8445, "2131 Expansion Module ID0 Analogue Input A Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8446, "2131 Expansion Module ID0 Analogue Input B Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8447, "2131 Expansion Module ID0 Analogue Input B Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8448, "2131 Expansion Module ID0 Analogue Input C Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8449, "2131 Expansion Module ID0 Analogue Input C Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8450, "2131 Expansion Module ID0 Analogue Input D Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8451, "2131 Expansion Module ID0 Analogue Input D Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8452, "2131 Expansion Module ID0 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8453, "2131 Expansion Module ID0 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8454, "2131 Expansion Module ID0 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8455, "2131 Expansion Module ID0 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8456, "2131 Expansion Module ID0 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8457, "2131 Expansion Module ID0 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8458, "2131 Expansion Module ID0 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8459, "Expansion Module ID0 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8460, "2131 Expansion Module ID0 Analogue Input I Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8461, "2131 Expansion Module ID0 Analogue Input I Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8462, "2131 Expansion Module ID0 Analogue Input J Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8463, "2131 Expansion Module ID0 Analogue Input J Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8464, "2131 Expansion Module ID1 Analogue Input A Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8465, "2131 Expansion Module ID1 Analogue Input A Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8466, "2131 Expansion Module ID1 Analogue Input B Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8467, "2131 Expansion Module ID1 Analogue Input B Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8468, "2131 Expansion Module ID1 Analogue Input C Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8469, "2131 Expansion Module ID1 Analogue Input C Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8470, "2131 Expansion Module ID1 Analogue Input D Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8471, "2131 Expansion Module ID1 Analogue Input D Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8472, "2131 Expansion Module ID1 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8473, "2131 Expansion Module ID1 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8474, "2131 Expansion Module ID1 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8475, "2131 Expansion Module ID1 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8476, "2131 Expansion Module ID1 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8477, "2131 Expansion Module ID1 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8478, "2131 Expansion Module ID1 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8479, "2131 Expansion Module ID1 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8480, "2131 Expansion Module ID1 Analogue Input I Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8481, "2131 Expansion Module ID1 Analogue Input I Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8482, "2131 Expansion Module ID1 Analogue Input J Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8483, "2131 Expansion Module ID1 Analogue Input J Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8484, "2131 Expansion Module ID2 Analogue Input A Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8485, "2131 Expansion Module ID2 Analogue Input A Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8486, "2131 Expansion Module ID2 Analogue Input B Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8487, "2131 Expansion Module ID2 Analogue Input B Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8488, "2131 Expansion Module ID2 Analogue Input C Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8489, "2131 Expansion Module ID2 Analogue Input C Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8490, "2131 Expansion Module ID2 Analogue Input D Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8491, "2131 Expansion Module ID2 Analogue Input D Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8492, "2131 Expansion Module ID2 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8493, "2131 Expansion Module ID2 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8494, "2131 Expansion Module ID2 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8495, "2131 Expansion Module ID2 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8496, "2131 Expansion Module ID2 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8497, "2131 Expansion Module ID2 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8498, "2131 Expansion Module ID2 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8499, "2131 Expansion Module ID2 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8500, "2131 Expansion Module ID2 Analogue Input I Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8501, "2131 Expansion Module ID2 Analogue Input I Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8502, "2131 Expansion Module ID2 Analogue Input J Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8503, "2131 Expansion Module ID2 Analogue Input J Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8504, "2131 Expansion Module ID3 Analogue Input A Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8505, "2131 Expansion Module ID3 Analogue Input A Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8506, "2131 Expansion Module ID3 Analogue Input B Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8507, "2131 Expansion Module ID3 Analogue Input B Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8508, "2131 Expansion Module ID3 Analogue Input C Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8509, "2131 Expansion Module ID3 Analogue Input C Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8510, "2131 Expansion Module ID3 Analogue Input D Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8511, "2131 Expansion Module ID3 Analogue Input D Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8512, "2131 Expansion Module ID3 Analogue Input E Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8513, "2131 Expansion Module ID3 Analogue Input E Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8514, "2131 Expansion Module ID3 Analogue Input F Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8515, "2131 Expansion Module ID3 Analogue Input F Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8516, "2131 Expansion Module ID3 Analogue Input G Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8517, "2131 Expansion Module ID3 Analogue Input G Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8518, "2131 Expansion Module ID3 Analogue Input H Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8519, "2131 Expansion Module ID3 Analogue Input H Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8520, "2131 Expansion Module ID3 Analogue Input I Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8521, "2131 Expansion Module ID3 Analogue Input I Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8522, "2131 Expansion Module ID3 Analogue Input J Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8523, "2131 Expansion Module ID3 Analogue Input J Hi");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8256, "2131 Expansion Module ID0 Digital Input A");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8257, "2131 Expansion Module ID0 Digital Input B");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8258, "2131 Expansion Module ID0 Digital Input C");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8259, "2131 Expansion Module ID0 Digital Input D");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8260, "2131 Expansion Module ID0 Digital Input E");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8261, "2131 Expansion Module ID0 Digital Input F");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8262, "2131 Expansion Module ID0 Digital Input G");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8263, "2131 Expansion Module ID0 Digital Input H");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8264, "2131 Expansion Module ID0 Digital Input I");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8265, "2131 Expansion Module ID0 Digital Input J");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8266, "2131 Expansion Module ID1 Digital Input A");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8267, "2131 Expansion Module ID1 Digital Input B");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8268, "2131 Expansion Module ID1 Digital Input C");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8269, "2131 Expansion Module ID1 Digital Input D");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8270, "2131 Expansion Module ID1 Digital Input E");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8271, "2131 Expansion Module ID1 Digital Input F");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8272, "2131 Expansion Module ID1 Digital Input G");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8273, "2131 Expansion Module ID1 Digital Input H");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8274, "2131 Expansion Module ID1 Digital Input I");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8275, "2131 Expansion Module ID1 Digital Input J");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8276, "2131 Expansion Module ID2 Digital Input A");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8277, "2131 Expansion Module ID2 Digital Input B");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8278, "2131 Expansion Module ID2 Digital Input C");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8279, "2131 Expansion Module ID2 Digital Input D");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8280, "2131 Expansion Module ID2 Digital Input E");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8281, "2131 Expansion Module ID2 Digital Input F");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8282, "2131 Expansion Module ID2 Digital Input G");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8283, "2131 Expansion Module ID2 Digital Input H");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8284, "2131 Expansion Module ID2 Digital Input I");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8285, "2131 Expansion Module ID2 Digital Input J");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8286, "2131 Expansion Module ID3 Digital Input A");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8287, "2131 Expansion Module ID3 Digital Input B");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8288, "2131 Expansion Module ID3 Digital Input C");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8289, "2131 Expansion Module ID3 Digital Input D");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8290, "2131 Expansion Module ID3 Digital Input E");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8291, "2131 Expansion Module ID3 Digital Input F");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8292, "2131 Expansion Module ID3 Digital Input G");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8293, "2131 Expansion Module ID3 Digital Input H");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8294, "2131 Expansion Module ID3 Digital Input I");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8295, "2131 Expansion Module ID3 Digital Input J");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8437, "Low Load");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8754, "Charger ID0 Common Shutdown");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8755, "Charger ID0 Common Warning");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8756, "Charger ID1 Common Shutdown");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8757, "Charger ID1 Common Warning");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8758, "Charger ID2 Common Shutdown");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8759, "Charger ID2 Common Warning");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8760, "Charger ID3 Common Shutdown");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8761, "Charger ID3 Common Warning");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8762, "Configurable CAN Instrument 1");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8763, "Configurable CAN Instrument 2");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8764, "Configurable CAN Instrument 3");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8765, "Configurable CAN Instrument 4");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8766, "Configurable CAN Instrument 5");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8767, "Configurable CAN Instrument 6");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8768, "Configurable CAN Instrument 7");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8769, "Configurable CAN Instrument 8");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8770, "Configurable CAN Instrument 9");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(8771, "Configurable CAN Instrument 10");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4096, "Emergency Stop");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4097, "Low Oil Pressure");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4098, "High Coolant Temp");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4099, "Low Coolant Temp");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4100, "Under Speed");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4101, "Over Speed");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4102, "Generator Under Frequency");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4103, "Generator Over Frequency");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4104, "Generator Under Volts");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4105, "Generator Over Volts");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4106, "Battery Under Volts");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4107, "Battery Over Volts");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4108, "Charge Alternator Failure");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4109, "Fail To Start");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4110, "Fail To Stop");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4111, "Generator Failed To Close");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4112, "Mains Failed To Close");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4113, "Oil Pressure Sensor Open Circuit");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4114, "Loss Of Mag Pickup Signal");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4115, "Mag Pickup Open Circuit");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4116, "Generator Over Current");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4117, "Calibration Lost");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4118, "Low Fuel Level");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4119, "ECU Amber");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4120, "ECU Red");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4121, "ECU Data Fail");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4122, "Low Oil Pressure Switch Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4123, "High Temperature Switch Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4124, "Low Fuel Switch Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4125, "Expansion Unit Watchdog Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4126, "kW Overload Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4127, "Negative Phase Sequence Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4128, "Earth Fault Trip");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4129, "Generator Phase Rotation Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4130, "Auto Voltage Sense Fail");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4131, "Maintenance Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4178, "Fail to Reach Loading Frequency");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4133, "Fail to Reach Loading Voltage");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4134, "Fuel Usage Running");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4135, "Fuel Usage Stopped");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4136, "Protections Disabled");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4137, "Shutdown Blocked");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4183, "Generator Short Circuit");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4184, "Mains Over Current");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4185, "Mains Earth Fault");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4186, "Mains Short Circuit");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4199, "ECU Protect");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4200, "ECU Malfunction");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4201, "Indication");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4202, "ECU Red");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4203, "ECU Amber");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4225, "HEST Active");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4226, "DPTC Filter");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4206, "Water in Fuel");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4142, "Generator Reverse Power Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4212, "Positive VAr");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4213, "Negative VAr");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4230, "LCD Heater Low Voltage Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4231, "LCD Heater High Voltage Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4313, "DEF Level Low");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4314, "SCR Inducement");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4159, "MSC Old Version Units On The Bus");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4151, "MSC ID Error");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4156, "MSC Failure");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4149, "Priority Selection Error");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4324, "Fuel Sensor Open Circuit");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4325, "Over Speed Run Away");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4326, "Over Frequency Run Away");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4327, "Coolant Sensor Open Circuit");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4138, "Generator Breaker Failed To Open");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4139, "Mains Breaker Failed To Open");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4145, "Fail To Sync");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4227, "High Fuel Level");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4364, "Inlet Temperature");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4372, "Fuel Tank Bund Level High");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4398, "AVR Data Fail");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4399, "AVR Fault");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4400, "Escape Mode");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4176, "High Coolant Temp Elec Trip Alarm");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(4402, "Remote Display Serial Link Lost");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(16384, "Mode Changed Notification");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(12297, "Module Restart Notification");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(12591, "Engine Starts Notification");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(12299, "Engine Stops Notification");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(12392, "Mains Return Notification");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(12391, "Mains Fail Notification");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(20480, "ECU Lamp Protect Notification");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(20481, "ECU Lamp Malfunction Notification");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(20482, "ECU Lamp Shutdown Notification");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(20483, "ECU Lamp Warning");
                    DashboardCommonData.DgTrapNotificationDescInfo.Add(24576, "Level Status Monitoring Notification");

                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, "DigitalGeneratorLoadNotificationInfo", nameof(DigitalGeneratorLoadNotificationInfo));
            }
            #endregion

        }

    }
}
