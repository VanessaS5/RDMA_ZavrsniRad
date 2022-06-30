using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        IAuth auth;
        public MainPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserPage(), true);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResultPage(), true);
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LanguagePage(), true);
        }

        async void LogoutButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
            //var signOut = auth.SignOut();
            //if (signOut)
            //{
            //    Application.Current.MainPage = new LoginPage();
            //}
        }
    }
}
