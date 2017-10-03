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
	public partial class CapturarDatos : ContentPage
	{
		public CapturarDatos ()
		{
			InitializeComponent ();
		}

        private void Regresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Menu()));
        }

        private void Cal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new Calculadora()));
        }
        private void Des_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new DatosDesarrollador()));
        }
    }
}