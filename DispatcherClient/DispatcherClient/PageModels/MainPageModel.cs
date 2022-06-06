using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DispatcherClient.Model;
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
        private string _selectedAutobus;
        private ObservableCollection<AutobusModel> PathAutobus;

        public ObservableCollection<string> Autobuses { get; set; }

        public async void GetAutobuses()
        {
            var list = await _dbConnection.GetAllDataAsync();

            Autobuses.Clear();

            foreach(var item in list)
            {
                Autobuses.Add(item.NumberAutobus);
                PathAutobus.Add(item);
            }

        }

        public Command RefreshAutobuses { get; set; }

        public string SelectedAutobus 
        {
            get => _selectedAutobus;

            set
            {
                if (value != null)
                {
                    var path = PathAutobus.FirstOrDefault(x => x.NumberAutobus == value);
                    Application.Current.MainPage.DisplayAlert(value, path.PathAutobus, "Назад");
                    _selectedAutobus = value;
                }
            }
        }

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
            PathAutobus = new ObservableCollection<AutobusModel>();

            GetAutobuses();
            SetCommands();
        }
    }
}
