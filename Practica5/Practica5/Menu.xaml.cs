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
    public partial class Menu : TabbedPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Desarrollador_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new DatosDesarrollador()));
        }

        private void CapturarDatos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new CapturarDatos()));
        }

        private void Calculadora_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new Calculadora()));
        }
    }
}