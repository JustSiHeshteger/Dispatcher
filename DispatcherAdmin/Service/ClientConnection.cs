using DispatcherAdmin.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DispatcherAdmin.Service
{
    internal class ClientConnection : DataBaseConnection
    {
        public ClientConnection(string connection)
        {
            this.Connection = new SqlConnection(connection);
        }
        public IEnumerable<AutobusModel> GetAllAutobus()
        {
            var autobusList = new List<AutobusModel>();

            try
            {
                ConnectionOpen();

                using (var command = new SqlCommand())
                {
                    command.Connection = _connection;
                    command.CommandText = "SELECT * FROM Autobus ORDER BY id_autobus";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var autobusModel = new AutobusModel()
                            {
                                IdAutobus = int.TryParse(reader[0].ToString(), out _) ? Convert.ToInt32(reader[0]) : 0,
                                NumberAutobus = reader[1].ToString(),
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
                ConnectionClose();
            }

            return autobusList;
        }

        public IEnumerable<ClientModel> GetAllClients()
        {
            var clientList = new List<ClientModel>();

            try
            {
                ConnectionOpen();   
                using (var command = new SqlCommand())
                {
                    command.Connection = _connection;
                    command.CommandText = "SELECT * FROM Client ORDER BY id";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var clientModel = new ClientModel
                            {
                                Id = int.TryParse(reader[0].ToString(), out _) ? Convert.ToInt32(reader[0]) : 0,
                                NumberPhone = reader[1].ToString(),
                                Name = reader[2].ToString(),
                                Surname = reader[3].ToString()
                            };

                            clientList.Add(clientModel);
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
                ConnectionClose();
            }

            return clientList;
        }
    }
}
