using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LCPInfrastructure;
using LCPReportingSystem.Model;

using System.Windows.Data;
using LCPReportingSystem.WindowForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

namespace LCPReportingSystem.DbHelper
{

    public static class ActivityReportDataInsertModel
    {
        static string UsersName = string.Empty;
        public static void SetActivityReport(string activityType, string activityInfo, string username)
        {
            if(UsersName.Length==0)
            {
                UsersName = username;
            }
   
            SqlCommand cmd = new SqlCommand();
            DbContext _dbContext = new DbContext();

            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.InsertActivityReport;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Activity_Type", SqlDbType.VarChar, 100).Value = activityType;
                cmd.Parameters.Add("@Activity_Datetime", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@Activity_Info", SqlDbType.VarChar, 500).Value = activityInfo;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = UsersName;

                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                LCPLogUtils.LogException(ex, "SetActivityReport", nameof(ActivityReportDataInsertModel));
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }             
                cmd.Dispose();
            }
        }
    }
}
