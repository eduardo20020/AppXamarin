using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CopaAmerica.Views;
using Xamarin.Essentials;

namespace CopaAmerica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Preferences.Get("username", string.Empty) == string.Empty)
            {
                MainPage = new NavigationPage(new PaginaConfiguracion());
            }
            else
            {
                MainPage = new NavigationPage(new PaginaPrincipal());
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
