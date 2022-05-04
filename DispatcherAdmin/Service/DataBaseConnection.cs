using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatcherAdmin.Service
{
    internal class DataBaseConnection
    {
        protected SqlConnection _connection;
        protected SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                    throw new Exception("Нет доступного подключения");
                return _connection;
            }
            set => _connection = value;
        }

        protected virtual void ConnectionOpen()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        protected virtual void ConnectionClose()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }
    }
}
