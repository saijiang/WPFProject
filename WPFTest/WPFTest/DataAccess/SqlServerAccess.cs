﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTest.Base;

namespace WPFTest.DataAccess
{
    internal class SqlServerAccess
    {
        // 数据库操作 类
        public SqlConnection Conn { get; set; }
        public SqlCommand Comm { get; set; }
        public SqlDataAdapter Adap { get; set; }


        // 操作完数据库之后将其释放
        private void Dispose()
        {
            if (Adap != null)
            {
                Adap.Dispose();
                Adap = null;
            }



            if (Comm !=null)
            {
                Comm.Dispose();
                Comm = null;
            }


            if (Conn != null)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }

        }

        // 打开数据库

        private bool DBConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["demoDB"].ConnectionString;
            if(Conn == null)
                Conn = new SqlConnection(connStr);

                try
                {
                    Conn.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
        
        }


        public bool CheckUserInfo(string userName, string pwd)
        {


            try
            {
                if (DBConnection())
                {
                    string userSql = "select * form users where user_name=@user_name and passwoed=@password and is_validation=1";
                    Adap = new SqlDataAdapter(userSql, Conn);
                    Adap.SelectCommand.Parameters.Add(new SqlParameter("@user_name", SqlDbType.VarChar) { Value = userName });
                    Adap.SelectCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar) { Value = Md5Provider.GetMD5etring(pwd + "0" + userName.ToLower()) });
                    DataTable dataTable = new DataTable();
                    int count = Adap.Fill(dataTable);

                    if (count <= 0)
                    {
                        throw new Exception("用户名或密码不正确");
                    }

                    DataRow row = dataTable.NewRow();
                    if (row.Field<Int32>("Is_can_Login") == 0)
                    {
                        throw new Exception("当前用户无权限使用此平台");
                    }

                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
             
            }
            finally
            {
                this.Dispose();
            
            }


        }


        // 读取数据库中的内容
        private DataTable GetDatas(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                if (DBConnection())
                {
                    Adap = new SqlDataAdapter(sql, Conn);
                    Adap.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }
            return dt;
        }


        public DataTable GetDevices()
        {
            string strSql = "select * from device";
            return GetDatas(strSql);
        }

        public DataTable GetProtocolSettings(string d_id, int type = 1)
        {
            string strSql = "select * from P_Modbus";
            if(type == 2)
            {
                strSql = "select * from P_S7";
                strSql += "where d_id = '" + d_id + "'";
                return GetDatas(strSql);
            }
            else
            return GetDatas(strSql);
        }

        public DataTable GetMonitorValues(string d_id)
        {
            string strSql = $"select * from monitor_values where d_id='{d_id}' order v_id";
            return GetDatas(strSql);
        }

    }
}
