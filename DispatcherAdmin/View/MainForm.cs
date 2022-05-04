using DispatcherAdmin.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispatcherAdmin
{
    public partial class MainForm : Form
    {
        private ClientConnection _dataBaseConnection;
        private ServerConnection _serverConnection;
        public MainForm()
        {
            InitializeComponent();
            ConnectToDataBaseAsync();
            ConnectToServerAsync();
            //CheckConnection();
        }

        private void CheckConnection()
        {
            var label = new Label()
            {
                Font = new Font(FontFamily.GenericSansSerif, 20.0f, FontStyle.Bold),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
            };

            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                label.Text = "Подключение к Интернету отсутствует";
            }
            else
            {
                label.Text = "Подключение к Интернету успешно";
            }
                
            var panel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.LightBlue,
            };
            
            panel.Controls.Add(label);
            this.Controls.Add(panel);
            panel.BringToFront();
        }

        /// <summary>
        /// Подключение к базе данных
        /// </summary>
        private async void ConnectToDataBaseAsync()
        {
            await Task.Run(() =>
            {
                _dataBaseConnection = new ClientConnection(Properties.Settings.Default.ConnectionString);
                ClientDataGridView.DataSource = _dataBaseConnection.GetAllClients();
                AutobusDataGridView.DataSource = _dataBaseConnection.GetAllAutobus();
            });
        }

        /// <summary>
        /// Подключение к серверу
        /// </summary>
        private async void ConnectToServerAsync() 
        {
            await Task.Run(() =>
            {
                _serverConnection = new ServerConnection();
                _serverConnection.ConnectAsync();
            });
        }
    }
}
