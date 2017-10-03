using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DatosDesarrollador : ContentPage
	{
		public DatosDesarrollador ()
		{
			InitializeComponent ();
		}

        private void Regresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Menu()));
        }
        private void Capturar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new CapturarDatos()));
        }
        
            private void Calculadora_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Calculadora()));
        }
    }
}