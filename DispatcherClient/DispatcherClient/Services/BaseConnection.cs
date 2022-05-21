using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace DispatcherClient.Services
{
    internal class BaseConnection
    {
        private static string ServerName = "mymicrosoftsqluniversalserver.cuc2nmc64bpx.eu-central-1.rds.amazonaws.com";
        private static string DataBaseName = "AutobusDataBase";
        private static string UserName = "andrey";
        private static string Password = "12345678";

        protected string ConnectionString = $"Data Source={ServerName};Initial Catalog={DataBaseName};User Id={UserName};Password={Password};Trusted_Connection=true";

        protected string Connect = "Data Source=;Initial Catalog=;"
                                 + "user id=andrey;password=12345678";
        protected MySqlConnection _sqlConnection;
        protected virtual void ConnectOpen()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
                _sqlConnection.Open();
        }

        public virtual void ConnectClose()
        {
            if (_sqlConnection.State == ConnectionState.Open)
                _sqlConnection.Close();
        }
    }
}
