using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace DispatcherClient.Services
{
    internal class BaseConnection
    {
        protected string ConnectionString = "mymicrosoftsqluniversalserver.cuc2nmc64bpx.eu - central - 1.rds.amazonaws.com; Initial Catalog = AutobusDataBase; User ID = andrey; Password=12345678";
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
