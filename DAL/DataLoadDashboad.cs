using LCPReportingSystem.DbHelper;
using LCPReportingSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.DAL
{
    public class DataLoadDashboad
    {
        private DbContext _dbContext;

        public DataLoadDashboad() 
        {
            _dbContext = new DbContext();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subsystemID"></param>
        /// <returns></returns>
        public DataTable GetSubsystemdhashboardTrapInfo(int subsystemID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable DtDgdhashboardinfo = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetDashBoadtrapInfo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubsystemId", SqlDbType.Int, 100).Value = subsystemID;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(DtDgdhashboardinfo);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                if (string.IsNullOrWhiteSpace(Message))
                {
                    SystemSounds.Beep.Play();
                }
                return DtDgdhashboardinfo;
            }
            catch (Exception ex)
            {
                LCPInfrastructure.LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSubsystemdhashboardTrapInfo));
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subsystemID"></param>
        /// <returns></returns>
        public DataTable GetSubsystemdhashboardupsTrapInfo(int subsystemID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable DtDgdhashboardinfo = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetDashBoardUpsTrapInfo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubsystemId", SqlDbType.Int, 100).Value = subsystemID;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(DtDgdhashboardinfo);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                if (string.IsNullOrWhiteSpace(Message))
                {
                    SystemSounds.Beep.Play();
                }
                return DtDgdhashboardinfo;
            }
            catch (Exception ex)
            {
                LCPInfrastructure.LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSubsystemdhashboardupsTrapInfo));
                return null;
            }
        } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subsystemID"></param>
        /// <returns></returns>
        public DataTable GetSubsystemdhashboardSwitchTrapInfo(int subsystemID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable DtDgdhashboardinfo = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetDashBoadSwitchTrapInfo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubsystemId", SqlDbType.Int, 100).Value = subsystemID;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(DtDgdhashboardinfo);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                if (string.IsNullOrWhiteSpace(Message))
                {
                    SystemSounds.Beep.Play();
                }
                return DtDgdhashboardinfo;
            }
            catch (Exception ex)
            {
                LCPInfrastructure.LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSubsystemdhashboardSwitchTrapInfo));
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subsystemID"></param>
        /// <returns></returns>
        public DataTable GetSubsystemdhashboardRouterTrapInfo(int subsystemID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable DtDgdhashboardinfo = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetDashBoardRouterTrapInfo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubsystemId", SqlDbType.Int, 100).Value = subsystemID;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(DtDgdhashboardinfo);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                if (string.IsNullOrWhiteSpace(Message))
                {
                    SystemSounds.Beep.Play();
                }
                return DtDgdhashboardinfo;
            }
            catch (Exception ex)
            {
                LCPInfrastructure.LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSubsystemdhashboardRouterTrapInfo));
                return null;
            }
        } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subsystemID"></param>
        /// <returns></returns>
        public DataTable GetSubsystemdhashboardRadioTrapInfo(int subsystemID)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable DtDgdhashboardinfo = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetDashBoardRadioTrapInfo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubsystemId", SqlDbType.Int, 100).Value = subsystemID;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(DtDgdhashboardinfo);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                if (string.IsNullOrWhiteSpace(Message))
                {
                    SystemSounds.Beep.Play();
                }
                return DtDgdhashboardinfo;
            }
            catch (Exception ex)
            {
                LCPInfrastructure.LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSubsystemdhashboardRadioTrapInfo));
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subsystemID"></param>
        /// <returns></returns>
        public  DataTable GetSubsystemdhashboardInfo(int subsystemID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable DtDgdhashboardinfo = new DataTable();
            string Message = string.Empty;
            try
            {
                cmd.Connection = _dbContext.getConnection;
                cmd.CommandText = _dbContext.GetDashBoadInfo;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SubsystemId", SqlDbType.Int, 100).Value = subsystemID;
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                adapter.SelectCommand = cmd;
                adapter.Fill(DtDgdhashboardinfo);

                if (string.IsNullOrEmpty(Message))
                {
                    Message = Convert.ToString(cmd.Parameters["@Message"].Value);
                }
                if (string.IsNullOrWhiteSpace(Message))
                {
                    SystemSounds.Beep.Play();
                }
                return DtDgdhashboardinfo;
            }
            catch (Exception ex)
            {
                LCPInfrastructure.LCPLogUtils.LogException(ex, GetType().Name, nameof(GetSubsystemdhashboardInfo));
                return null;
            }
        }

    }
}
