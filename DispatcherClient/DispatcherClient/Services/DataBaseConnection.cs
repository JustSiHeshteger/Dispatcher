using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using DispatcherClient.Model;

namespace DispatcherClient.Services
{
    internal class DataBaseConnection : BaseConnection
    {
        public DataBaseConnection()
        {
            base._sqlConnection = new MySqlConnection(base.ConnectionString);
        }

        public async Task<List<AutobusModel>> GetAllData()
        {
            var autobusList = new List<AutobusModel>();

            await Task.Run(() =>
            {
                try
                {
                    base.ConnectOpen();

                    using (var command = new MySqlCommand())
                    {
                        command.Connection = _sqlConnection;
                        command.CommandText = "SELECT * FROM Autobus";

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var autobusModel = new AutobusModel()
                                {
                                    IdAutobus = int.TryParse(reader[0].ToString(), out _) ? Convert.ToInt32(reader[0].ToString()) : 0,
                                    NumberAutobus = reader[1].ToString()
                                };
                                autobusList.Add(autobusModel);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    base.ConnectClose();
                }
            });

            return autobusList;
        }
    }
}
