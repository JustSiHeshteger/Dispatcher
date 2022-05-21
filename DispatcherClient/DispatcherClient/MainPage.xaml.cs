using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

using DispatcherClient.Services;

namespace DispatcherClient
{
    public partial class MainPage : ContentPage
    {
        private readonly ICustomNotification _notification;
        private ServerService _serverService;
        private DataBaseConnection _dataBaseConnection;

        public MainPage()
        {
            InitializeComponent();

            _notification = DependencyService.Get<ICustomNotification>();
            SetConnections();
        }

        private async void SetConnections()
        {
            try
            {
                _serverService = new ServerService(_notification);
                _serverService.ConnectAsync();

                _dataBaseConnection = new DataBaseConnection();
                await _dataBaseConnection.GetAllData();
            }
            catch(Exception ex)
            {
                _notification.Send("Ошибка", ex.Message);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var t = Task.Run(async delegate
            {
                
                _notification.Send("Title", "message");
                await Task.Delay(5000);
            });
            t.Wait();
        }
    }
    public interface ICustomNotification
    {
        void Send(string title, string message);
    }
}