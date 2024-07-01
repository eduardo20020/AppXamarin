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
    public partial class PaginaConfiguracion : ContentPage
    {
        public PaginaConfiguracion()
        {
            InitializeComponent();
            Title = "Configuracion";
            // Obtén el nombre de usuario almacenado en las preferencias
            string username = Preferences.Get("username", "sinNombre");

            // Verifica si el nombre de usuario es válido (no es el valor predeterminado ni está vacío)
            if (!string.IsNullOrEmpty(username) && username != "sinNombre")
            {
                // Establece el texto del componente nombre con el valor del nombre de usuario
                nombre.Text = username;
            }
            else
            {
                // Opcional: maneja el caso donde no hay un nombre de usuario válido
                nombre.Text = "Nombre no configurado";
            }
        }


        private void GuardarConfig(object sender, EventArgs e)
        {
            Preferences.Set("username", nombre.Text);
            Navigation.PushAsync(new PaginaPrincipal());
        }

    }
}