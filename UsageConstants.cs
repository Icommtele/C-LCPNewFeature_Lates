using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCPReportingSystem.Model;

namespace LCPReportingSystem
{
    /// <summary>
    /// 
    /// </summary>
    public static class UsageConstants
    {
        public static bool isAdmin = false;
        public static string UserName = string.Empty;
        public static List<string> exerciseTypes = new List<string>();
        public static Dictionary<int, IsSubSystem> SubsystemCollectionNumber = new Dictionary<int, IsSubSystem>();
        public static bool IsGoToPage = false;
        public static string DefaultExerciseItem = "None";
        public static string AddNewUser = "Add New User";

        public static string SwitchText = "Switch";
        public static string UPSText = "UPS";
        public static string RadioText = "Radio";
        public static string DieselGeneratorText = "Diesel Generator";


        public static string DieselGenerator1Text = "Diesel Generator1";
        public static string Radio1Text = "Radio1";
        public static string UPS1Text = "UPS1";
        public static string Switch1Text = "Switch1";

        public static string Switch2Text = "Switch2";
        public static string UPS2Text = "UPS2";
        public static string Radio2Text = "Radio2";
        public static string DieselGenerator2Text = "Diesel Generator2";


        public static string NodataDatesText = "No data found for the selected dates.";
        public static string NodataText = "No data found";
        public static bool keepRunning = true;
    }
}
