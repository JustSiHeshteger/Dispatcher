using DispatcherAdmin.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispatcherAdmin.Service
{
    internal class ClientConnection : DataBaseConnection
    {
        public ClientConnection(string connection)
        {
            this.Connection = new SqlConnection(connection);
        }
        public List<AutobusModel> GetAllAutobus()
        {
            var autobusList = new List<AutobusModel>();

            try
            {
                ConnectionOpen();

                using (var command = new SqlCommand())
                {
                    command.Connection = base.Connection;
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                ConnectionClose();
            }

            return autobusList;
        }

        public void AddNewAutobus(string autobus)
        {
            try
            {
                ConnectionOpen();

                using (var command = new SqlCommand())
                {
                    command.Connection = base.Connection;
                    command.CommandText = "INSERT INTO Autobus VALUES (@numberAutobus)";
                    command.Parameters.Add("@numberAutobus", SqlDbType.NVarChar).Value = autobus;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                ConnectionClose();
            }
        }

        public void DeleteAutobus(string id)
        {
            try
            {
                ConnectionOpen();

                using(var command = new SqlCommand())
                {
                    command.Connection = base.Connection;
                    command.CommandText = "DELETE FROM Autobus WHERE id_autobus=@idAutobus";
                    command.Parameters.Add("@idAutobus", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                ConnectionClose();
            }
        }
    }
}
