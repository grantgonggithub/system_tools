/*----------------------------------------------------------------
Copyright (C) 2014 宏图会员管理系统（Grant 巩建春）

项目名称： 宏图会员管理系统
创建者：   grant (巩建春 emaill : nnn987@126.com ; QQ:406333743;Tel:+86 15619212255)
CLR版本：  4.0.30319.42000
时间：     2014/8/28 18:16:22

功能描述：本软件为本人业余时间所写，其所有源码都可以进行免费的学习交流，切勿用于商业用途

----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;

namespace DBAccess
{
   public class MySqlAccess:DBAccess
    {
        private string connectionString;
        public MySqlAccess(string _connectionString)
        {
            this.connectionString = _connectionString;
        }

        public int ExecuteNonQuery(string cmdText, System.Data.CommandType commandType, string[] paramsList, object[] values)
        {
            MySqlCommand comd = null;
            try
            {
                comd = new MySqlCommand();
                using (MySqlConnection connection = new MySqlConnection(this.connectionString))
                {
                    PrepareCommand(comd, connection, commandType, cmdText, paramsList,values);
                    int rows = comd.ExecuteNonQuery();
                    comd.Parameters.Clear();
                    return rows;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (comd != null)
                    comd.Dispose();
            }
        }

        public System.Data.DataSet ExecuteDataSet(string cmdText, System.Data.CommandType commandType, string[] paramsList, object[] values)
        {
            MySqlCommand comd = null;
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(this.connectionString);
                comd = new MySqlCommand();
                PrepareCommand(comd, connection, commandType, cmdText, paramsList,values);

                using (MySqlDataAdapter da = new MySqlDataAdapter(comd))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    comd.Parameters.Clear();
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (comd != null)
                    comd.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }

        public void PrepareCommand(IDbCommand cmd, IDbConnection conn, CommandType commandType, string cmdText, string[] paramsList, object[] values)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = commandType;
            if (paramsList == null) return;
            if (paramsList.Length < values.Length) throw new Exception("paramsList.length<values.length error");
            if (paramsList != null && paramsList.Length > 0)
            {
                for(int i=0; i<paramsList.Length;i++)
                {
                    cmd.Parameters.Add(new MySqlParameter() { ParameterName=paramsList[i], Value=values[i] });
                }
            }
            //if (cmdParms != null)
            //{
            //    foreach (IDataParameter parm in cmdParms)
            //        cmd.Parameters.Add(parm);
            //}
        }

    }
}
