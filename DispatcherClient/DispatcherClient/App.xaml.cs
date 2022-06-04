using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FreshMvvm;
using DispatcherClient.PageModels;
using DispatcherClient.Services.Interfaces;
using DispatcherClient.Services;

namespace DispatcherClient
{
    public partial class App : Application
    {
        private ICustomNotification _notification;
        private  ServerService _serverService;

        public App()
        {
            InitializeComponent();

            var page = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
            var navigationPage = new FreshNavigationContainer(page);

            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            GetNotification();
        }

        protected override void OnSleep()
        {
            GetNotification();
        }

        protected override void OnResume()
        {
            GetNotification();
        }

        private void GetNotification()
        {
            _notification = DependencyService.Get<ICustomNotification>();
            _serverService = new ServerService(_notification);
            _serverService.ConnectAsync();
        }
    }
}
