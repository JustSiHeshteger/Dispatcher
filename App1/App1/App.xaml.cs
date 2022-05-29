using App1.ViewModel;
using FreshMvvm;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public class MyPageModelMapper : IFreshPageModelMapper
    {
        public string GetPageTypeName(Type pageModelType)
        {
            var mainpagemodel = typeof(MainViewModel);
            var s = Type.GetType(mainpagemodel.AssemblyQualifiedName);

            var mainviewmodel = typeof(MainViewModel);
            var s2 = Type.GetType(mainviewmodel.AssemblyQualifiedName);

            return pageModelType.AssemblyQualifiedName
                .Replace("PageModel", "Page")
             .Replace("ViewModel", "Page");
        }
    }

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FreshPageModelResolver.PageModelMapper = new MyPageModelMapper();

            var page = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
            var navigationPage = new FreshNavigationContainer(page);
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
