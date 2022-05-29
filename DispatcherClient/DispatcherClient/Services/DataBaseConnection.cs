using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;

using DispatcherClient.Model;
using System.Data;
using DispatcherClient.Services.Interfaces;

namespace DispatcherClient.Services
{
    internal class DataBaseConnection
    {
        private readonly ICustomNotification _notification;

        private static readonly string ServerName = "mymicrosoftsqluniversalserver.cuc2nmc64bpx.eu-central-1.rds.amazonaws.com";
        private static readonly string DataBaseName = "AutobusDataBase";
        private static readonly string UserName = "andrey";
        private static readonly string Password = "12345678";

        protected string ConnectionString = $"Server={ServerName};Database={DataBaseName};User Id={UserName};Password={Password};";

        public DataBaseConnection(ICustomNotification notification)
        {
            this._notification = notification;
        }

        public async Task<List<string>> GetAllDataAsync()
        {
            var autobusList = new List<string>();

            await Task.Run(() =>
            {
                try
                {
                    using (var connection = new SqlConnection(ConnectionString))
                    using (var command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "SELECT number_autobus FROM Autobus";

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var autobusModel = reader[0].ToString();
                                autobusList.Add(autobusModel);
                            }
                        }
                    }
                    
                }
                catch(Exception ex)
                {
                    _notification.Send("Ошибка", ex.Message);
                }
            });

            return autobusList;
        }

        public async Task<bool> CheckAccountAsync(string login, string password)
        {
            DataTable dataTable = new DataTable();

            await Task.Run(() =>
            {
                try
                {
                    using (var connection = new SqlConnection(ConnectionString))
                    using (var command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM Clients WHERE phone_number=@login AND password=@password";
                        command.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
                        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

                        SqlDataAdapter adapter = new SqlDataAdapter
                        {
                            SelectCommand = command
                        };
                        adapter.Fill(dataTable);
                    }

                }
                catch (Exception ex)
                {
                    _notification.Send("Ошибка", ex.Message);
                }
            });

            if (dataTable.Rows.Count == 0)
                return false;
            else
                return true;
        }

        public async Task<bool> AddAccount(string login, string password)
        {
            bool success = false;

            await Task.Run(() => 
            {
                using(var connection = new SqlConnection(ConnectionString))
                using(var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Clients (phone_number, password) VALUES (@login, @password)";
                    command.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

                    success = Convert.ToBoolean(command.ExecuteNonQuery());
                }
            });

            return success;
        }
    }
}
