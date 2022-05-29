using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ClientAndroid.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        public Command OpenLogin { get; set; }

        public MainPageModel()
        {
            OpenLogin = new Command(async () =>
            {
                await CoreMethods.PushPageModel<LoginPageModel>();
            });
        }
    }
}
