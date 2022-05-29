using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using DispatcherClient.Services;
using DispatcherClient.Services.Interfaces;
using FreshMvvm;
using Xamarin.Forms;

namespace DispatcherClient.PageModels
{
    internal class MainPageModel : FreshBasePageModel
    {
        private readonly ICustomNotification _notification;
        private readonly DataBaseConnection _dbConnection;
        private readonly ServerService _serverService;

        public ObservableCollection<string> Autobuses { get; set; }

        public async void GetAutobuses()
        {
            var list = await _dbConnection.GetAllDataAsync();

            Autobuses.Clear();

            foreach(var item in list)
                Autobuses.Add(item);
            
        }

        public Command RefreshAutobuses { get; set; }

        public void SetCommands()
        {
            RefreshAutobuses = new Command(() =>
            {
                GetAutobuses();
            });
        }

        public MainPageModel()
        {
            _notification = DependencyService.Get<ICustomNotification>();
            _dbConnection = new DataBaseConnection(_notification);
            _serverService = new ServerService(_notification);

            _serverService.ConnectAsync();
            Autobuses = new ObservableCollection<string>();

            GetAutobuses();
            SetCommands();
        }
    }
}
