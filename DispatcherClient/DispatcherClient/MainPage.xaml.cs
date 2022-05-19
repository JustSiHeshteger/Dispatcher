using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DispatcherClient
{
    public partial class MainPage : ContentPage
    {
        ICustomNotification notification;
        public MainPage()
        {
            InitializeComponent();
            notification = DependencyService.Get<ICustomNotification>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(5000);
                notification.Send("Title", "message");
            });
            t.Wait();
        }
    }
    public interface ICustomNotification
    {
        void Send(string title, string message);
    }
}