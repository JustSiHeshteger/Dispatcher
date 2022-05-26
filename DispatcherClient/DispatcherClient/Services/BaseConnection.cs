using System.Data;
using System.Data.SqlClient;

namespace DispatcherClient.Services
{
    internal class BaseConnection
    {
        private static readonly string ServerName = "mymicrosoftsqluniversalserver.cuc2nmc64bpx.eu-central-1.rds.amazonaws.com";
        private static readonly string DataBaseName = "AutobusDataBase";
        private static readonly string UserName = "andrey";
        private static readonly string Password = "12345678";

        protected string ConnectionString = $"Data Source={ServerName};Initial Catalog={DataBaseName};User Id={UserName};Password={Password};Trusted_Connection=true";

        protected SqlConnection _sqlConnection;
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
