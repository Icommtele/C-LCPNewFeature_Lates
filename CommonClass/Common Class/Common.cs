using LCPInfrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CommonLib
{
    public static class Common
    {
        public static Dictionary<int, string> TrapConfigData = new Dictionary<int, string>();
        public static Dictionary<int, string> TrapNotificationConfigData = new Dictionary<int, string>();
        public static Dictionary<string, string> SubsystemCollection = new Dictionary<string, string>();
        public static Dictionary<int, int> SubsystemCollectionNumber = new Dictionary<int, int>();
        public static string NodataDatesText = "No data found for the selected dates.";
        public static string NodataText = "No data found";


        public static string Switch2Text = "Switch2";
        public static string UPS2Text = "UPS2";
        public static string Radio2Text = "Radio2";
        public static string DieselGenerator2Text = "Diesel Generator2";

        public static string SwitchText = "Switch";
        public static string UPSText = "UPS";
        public static string RadioText = "Radio";
        public static string DieselGeneratorText = "Diesel Generator";


        public static string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{6,}$";
        public static string ForgotPassword = "Forgot Password";
        public static string UserLogin = "User Login";
        public static string Forgot = "Forgot";
        public static string Gobacktologin = "Go back to login";
        public static string ResetPassword = "Reset Password";
        public static string PleaseenterUserNameandPassword = "Please enter UserName and Password";
        public static string PasswordUpdatedsuccessfully = "Your password has been successfully updated.";
        public static string AddNewUser = "Add New User";
        public static string Congratulation = "Congratulation, your user accout has been successfully created.";
        public static string isActive = "Y";
        public static string Accountsucceful = "Your user account not created successfully.";
        public static string Projectnotfound = "Project directory not found";
        public static string Projectdirfound = "Working directory not found";
        public static string Trap = "2";
        public static int ArchiveReportSubsystem = 1;
        public static int SpecificTrap = 6;
        public static string targetSubstring = "1.3.6.1.4.1.21025.4.2.2.1.1.1";
        public static string txpwrslot = "1.3.6.1.4.1.21025.4.4.9.1.1";
        public static string txpwrslot7 = "1.3.6.1.4.1.21025.4.4.9.1.1.1";
        public static string txpwrslot6 = "1.3.6.1.4.1.21025.4.4.9.1.1";
        public static int ActiveSloat = 9;
        public static string Nontrap = "1";
        public static string UpsAlarmid = "UpsAlarmId";
        public static string NonTrapInfo = "General - Trap";
        public static string Seconds = "  Seconds";
        public static string NotificationDesc = "Notification Description :";
        public static string NotificationValue = "Notification Value :";
        public static string TrapparameterName = "Param Name";
        public static string TrapparameterValue = "Param Value";
        public static string TrapparName = "Name";
        public static string TrapparValue = "Value";
        public static string TrapDesc = "  Desc";
        public static string TrapSepration = " :";
        public static string UPSDeviceID = "33";
        public static string DigitalGrenratorDeviceID = "41385";
        public static string RadioDeviceID = "21025";
        public static string SwitchDeviceID = "5";

        public static void LoadNotificationInfo(int trapinfo = 1)
        {
            try
            {
                if (TrapNotificationConfigData.Count <= trapinfo)
                {
                    Common.TrapNotificationConfigData.Add(1, "upsAlarmBatteryBad");
                    Common.TrapNotificationConfigData.Add(2, "upsAlarmOnBattery");
                    Common.TrapNotificationConfigData.Add(3, "upsAlarmLowBattery");
                    Common.TrapNotificationConfigData.Add(4, "upsAlarmDepletedBattery");
                    Common.TrapNotificationConfigData.Add(5, "upsAlarmTempBad");
                    Common.TrapNotificationConfigData.Add(6, "upsAlarmInputBad");
                    Common.TrapNotificationConfigData.Add(7, "upsAlarmOutputBad");
                    Common.TrapNotificationConfigData.Add(8, "upsAlarmOutputOverload");
                    Common.TrapNotificationConfigData.Add(9, "upsAlarmOnBypass");
                    Common.TrapNotificationConfigData.Add(11, "upsAlarmOutputOffAsRequested");
                    Common.TrapNotificationConfigData.Add(12, "upsAlarmUpsOffAsRequested");
                    Common.TrapNotificationConfigData.Add(13, "upsAlarmChargerFailed");
                    Common.TrapNotificationConfigData.Add(14, "upsAlarmUpsOutputOff");
                    Common.TrapNotificationConfigData.Add(16, "upsAlarmChargerFailed");
                    Common.TrapNotificationConfigData.Add(18, "upsAlarmGeneralFault");
                    Common.TrapNotificationConfigData.Add(20, "upsAlarmCommunicationsLost");
                    Common.TrapNotificationConfigData.Add(167, "alarmTransferswitchSourceAFailure");
                    Common.TrapNotificationConfigData.Add(168, "alarmTransferswitchSourceBFailure");
                    Common.TrapNotificationConfigData.Add(170, "alarmTransferswitchRedundancyLost");
                    Common.TrapNotificationConfigData.Add(171, "alarmTransferswitchOutputOverload");
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, "LoadNotificationInfo", aMethodName: nameof(LoadNotificationInfo));
            }

        }
        public static void LoadUPSTrapInfo(int Trapinfo = 1)
        {
            try
            {
                if (TrapConfigData.Count <= Trapinfo)
                {
                    Common.TrapConfigData.Add(1, "Batteries have been determined to require.");
                    Common.TrapConfigData.Add(2, "The UPS is drawing power from the batteries.");
                    Common.TrapConfigData.Add(3, "he remaining battery run-time is less than or equal to upsConfigLowBattTime.");
                    Common.TrapConfigData.Add(4, "UPS unable to sustain the present load.");
                    Common.TrapConfigData.Add(5, "Temperature is out of tolerance.");
                    Common.TrapConfigData.Add(6, "An input condition is out of tolerance.");
                    Common.TrapConfigData.Add(7, "An output(other than OutputOverload) is out of tolerance.");
                    Common.TrapConfigData.Add(8, "The output load exceeds the UPS output capacity.");
                    Common.TrapConfigData.Add(9, "The Bypass is presently engaged on the UPS.");
                    Common.TrapConfigData.Add(11, "The UPS has shutdown as requested.");
                    Common.TrapConfigData.Add(12, "The entire UPS has shutdown as commanded.");
                    Common.TrapConfigData.Add(13, "Problem detected within the UPS charger subsystem.");
                    Common.TrapConfigData.Add(14, "The output of the UPS is in the off state.");
                    Common.TrapConfigData.Add(16, "The failure of one or more fans in the UPS has detected");
                    Common.TrapConfigData.Add(18, "General fault in the UPS has been detected.");
                    Common.TrapConfigData.Add(20, "Problem communications between the agent and the UPS.");
                    Common.TrapConfigData.Add(167, "The failure of static Source A has been detected.");
                    Common.TrapConfigData.Add(168, "The failure of static Source B has been detected.");
                    Common.TrapConfigData.Add(170, "Unable to switch to the alternate power source.");
                    Common.TrapConfigData.Add(171, "The output load exceeds the output capacity.");
                }
            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, "LoadTrapInfo", aMethodName: nameof(LoadUPSTrapInfo));
            }

        }
    }
}






