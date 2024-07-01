using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CopaAmerica.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
            Title = "AprendeAppHTML";
            labelPrincipal.Text = $"Bienvenido {Preferences.Get("username", "sinNombre")}!";
        }

        private void CambiarConfiguracion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaConfiguracion());
        }




        private void seccion1(object sender, EventArgs e)
        {
            content1.IsVisible = !content1.IsVisible;
        }
        private void seccion2(object sender, EventArgs e)
        {
            content2.IsVisible = !content2.IsVisible;
        }
        private void seccion3(object sender, EventArgs e)
        {
            content3.IsVisible = !content3.IsVisible;
        }
        private void seccion4(object sender, EventArgs e)
        {
            content4.IsVisible = !content4.IsVisible;
        }
        private void seccion5(object sender, EventArgs e)
        {
            content5.IsVisible = !content5.IsVisible;
        }




        private void irUno(object sender, EventArgs e)
        {
            Navigation.PushAsync(new seccionUno());
        }
        private void irDos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new seccionDos());
        }
        private void irTres(object sender, EventArgs e)
        {
            Navigation.PushAsync(new seccionTres());
        }
        private void irCuatro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new seccionCuatro());
        }
        private void irCinco(object sender, EventArgs e)
        {
            Navigation.PushAsync(new seccionCinco());
        }



    }
}