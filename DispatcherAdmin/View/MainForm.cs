using DispatcherAdmin.Model;
using DispatcherAdmin.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispatcherAdmin
{
    public partial class MainForm : Form
    {
        private ClientConnection _dataBaseConnection;
        private ServerConnection _serverConnection;

        private List<AutobusModel> AllAutobuses;

        public MainForm()
        {
            InitializeComponent();
            ConnectToDataBase();
            ConnectToServerAsync();
            //CheckConnection();

            RefreshBtn.Click += (s, e) =>  ConnectToDataBase();
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
        private void ConnectToDataBase()
        {
            _dataBaseConnection = new ClientConnection(Properties.Settings.Default.ConnectionString);
            RefreshData();
        }

        private void RefreshData()
        {
            AllAutobuses = new List<AutobusModel>();
            AllAutobuses = _dataBaseConnection.GetAllAutobus();

            AutobusDataGridView.DataSource = AllAutobuses;

            AutobusLB.Items.Clear();
            foreach (var autobus in AllAutobuses)
                AutobusLB.Items.Add(autobus.NumberAutobus);
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

        private void SendBtn_Click(object sender, EventArgs e)
        {
            var messageModel = new MessageModel() { AutobusNumber = null, Message = MessageTB.Text };

            if (_serverConnection != null && !string.IsNullOrWhiteSpace(MessageTB.Text))
            {
                _serverConnection.SendMessage(messageModel);
                MessageTB.Text = "";
            }
        }

        private void AutobusLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AutobusLB.SelectedItem != null)
                MessageTB.Text += AutobusLB.SelectedItem.ToString() + ", ";
        }

        private void AddAutobusBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AutobusTB.Text))
            {
                _dataBaseConnection.AddNewAutobus(AutobusTB.Text);
                RefreshData();
            }
        }

        private void DeleteAutobusBtn_Click(object sender, EventArgs e)
        {
            string id = AutobusDataGridView[0, AutobusDataGridView.CurrentRow.Index].Value.ToString();
            _dataBaseConnection.DeleteAutobus(id);
            RefreshData();
        }
    }
}
