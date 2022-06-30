using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    public partial class App : Application
    {
        //IAuth auth;
        public App()
        {
            IAuth auth;
            InitializeComponent();

            auth = DependencyService.Get<IAuth>();
            if (auth.IsSignIn())
            {
                MainPage = new NavigationPage(new TabbedPage1());
                //MainPage = new TabbedPage1();
            }
            else
            {
                MainPage = new LoginPage();
            }
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
