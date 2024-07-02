using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CopaAmerica.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class seccionUno : ContentPage
	{
		public seccionUno ()
		{
			InitializeComponent ();
			Title = "Introduccion a HTML";
		}

        private void etiquetas(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://carontestudio.com/blog/listado-de-etiquetas-html"));
        }


        private void historiayevolucion(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://keepcoding.io/blog/historia-de-html"));
        }
    }
}