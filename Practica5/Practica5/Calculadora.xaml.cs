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
	public partial class Calculadora : ContentPage
	{
		public Calculadora ()
		{
			InitializeComponent ();
		}

        private void Porcentaje_Clicked(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + "%";
        }
        private void Raiz_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(Caja.Text);
            if (a <= 0)
            {
                double b = Math.Sqrt(a);
                Caja3.Text = "" + b;
                Caja.Text = "";
            }
            else
            {
                Caja3.Text = "No hay raiz Negativa";
            }


            //DisplayAlert("","R: "+b,"OK");
            /*int x = 0;
            borrado = Pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            Pantalla.Text = borrado;*/
        }
        private void Exponente_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(Caja.Text);
            double b = a * a;
            Caja3.Text = "" + b;
            Caja.Text = "";
        }

        private void Divx_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(Caja.Text);
            double b = 1 / a;
            Caja3.Text = "" + b;
            Caja.Text = "";
        }
        private void Punto_Clicked(object sender, EventArgs e)
        {
            Caja.Text = Caja.Text + ".";
        }

        private void Cero_Clicked(object sender, EventArgs e)
        {
            //Caja.Text = "";
            Caja.Text = Caja.Text + "0";
        }

        private void Mas_Clicked(object sender, EventArgs e)
        {
            if (Caja2.Text != "")
            {
                Caja2.Text = "+";
            }
            else
            {
                Caja2.Text = "+";
            }

            if (Caja.Text != "")
            {
                Caja3.Text = Caja.Text;
                Caja.Text = "";
            }

        }

        private void Tres_Clicked(object sender, EventArgs e)
        {
            //.Text = "";
            Caja.Text = Caja.Text + "3";
        }

        private void Dos_Clicked(object sender, EventArgs e)
        {
            //Caja.Text = "";
            Caja.Text = Caja.Text + "2";
        }

        private void Uno_Clicked(object sender, EventArgs e)
        {
            //Caja.Text = "";
            Caja.Text = Caja.Text + "1";
        }

        private void Menos_Clicked(object sender, EventArgs e)
        {

            if (Caja2.Text != "")
            {
                Caja2.Text = "-";
            }
            else
            {
                Caja2.Text = "-";
            }

            if (Caja.Text != "")
            {
                Caja3.Text = Caja.Text;
                Caja.Text = "";
            }
        }

        private void Seis_Clicked(object sender, EventArgs e)
        {
            //Caja.Text = "";
            Caja.Text = Caja.Text + "6";
        }

        private void Cinco_Clicked(object sender, EventArgs e)
        {
            //Caja.Text = "";
            Caja.Text = Caja.Text + "5";
        }

        private void Cuatro_Clicked(object sender, EventArgs e)
        {
            //Caja.Text = "";
            Caja.Text = Caja.Text + "4";
        }

        private void Por_Clicked(object sender, EventArgs e)
        {

            if (Caja2.Text != "")
            {
                Caja2.Text = "*";
            }
            else
            {
                Caja2.Text = "*";
            }

            if (Caja.Text != "")
            {
                Caja3.Text = Caja.Text;
                Caja.Text = "";
            }
        }

        private void Nueve_Clicked(object sender, EventArgs e)
        {
            //Caja.Text = "";
            Caja.Text = Caja.Text + "9";
        }

        private void Ocho_Clicked(object sender, EventArgs e)
        {
            //Caja.Text = "";
            Caja.Text = Caja.Text + "8";
        }

        private void Siete_Clicked(object sender, EventArgs e)
        {
            //Caja.Text = "";
            Caja.Text = Caja.Text + "7";
        }

        private void Entre_Clicked(object sender, EventArgs e)
        {
            if (Caja2.Text != "")
            {
                Caja2.Text = "/";
            }
            else
            {
                Caja2.Text = "/";
            }

            if (Caja.Text != "")
            {
                Caja3.Text = Caja.Text;
                //Caja4.Text =Caja.Text+"/";
                Caja.Text = "";
            }
        }

        private void NegativoPos_Clicked(object sender, EventArgs e)
        {
            if (Caja.Text == "")
            {

            }
            else if (Caja.Text == "0")
            {

            }
            else
            {
                Caja.Text = "-" + Caja.Text;
                mm.IsEnabled = false;
            }
        }

        private void Br1a1_Clicked(object sender, EventArgs e)
        {
            if (Caja.Text == "")
            {

            }
            else
            {
                int x = 0;
                string borrado = Caja.Text;
                x = borrado.Length - 1;
                borrado = borrado.Substring(0, x);
                Caja.Text = borrado;

            }
        }
        private void BorrarT_Clicked(object sender, EventArgs e)
        {
            Caja.Text = "";
            Caja2.Text = "";
            Caja3.Text = "";
        }
        private void R_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void Igual_Clicked(object sender, EventArgs e)
        {
            mm.IsEnabled = true;
            if (Caja2.Text == "+")
            {

                if (Caja.Text == "")
                {

                }
                else if (Caja3.Text == "")
                {

                }
                else
                {
                    //try
                    //{

                    float d1 = float.Parse(Caja3.Text);
                    float d2 = float.Parse(Caja.Text);
                    float r = d1 + d2;
                    Caja.Text = "";
                    Caja2.Text = "";
                    Caja3.Text = "" + r;
                    //}
                    //catch (ArgumentNullException ex)
                    //{
                    //DisplayAlert("Error", "Excetion Validar campos vacios", "OK");
                    //Caja.Text = "";
                    //Caja2.Text = "";
                    // }

                }

            }
            else if (Caja2.Text == "-")
            {
                if (Caja.Text == "")
                {

                }
                else if (Caja3.Text == "")
                {

                }
                else
                {
                    //try
                    //{
                    float d1 = float.Parse(Caja3.Text);
                    float d2 = float.Parse(Caja.Text);
                    float r = d1 - d2;
                    Caja.Text = "";
                    Caja2.Text = "";
                    Caja3.Text = "" + r;
                    //    }
                    //    catch (ArgumentNullException ex)
                    //    {
                    //        DisplayAlert("Error", "Excetion Validar campos vacios", "OK");
                    //        Caja.Text = "";
                    //        Caja2.Text = "";
                    //}
                }

            }
            else if (Caja2.Text == "*")
            {
                if (Caja.Text == "")
                {

                }
                else if (Caja3.Text == "")
                {
                }
                else
                {

                    //try
                    //{
                    float d1 = float.Parse(Caja3.Text);
                    float d2 = float.Parse(Caja.Text);
                    float r = d1 * d2;
                    Caja.Text = "";
                    Caja2.Text = "";
                    Caja3.Text = "" + r;
                    //}
                    //catch (ArgumentNullException ex)
                    //{
                    //    DisplayAlert("Error", "Excetion Validar campos vacios", "OK");
                    //    Caja.Text = "";
                    //    Caja2.Text = "";
                    //}

                }
            }
            else if (Caja2.Text == "/")
            {

                if (Caja.Text == "0")
                {
                    Caja3.Text = "Error no puedes Dividir entre 0";
                    Caja.Text = "";
                    Caja2.Text = "";

                }
                else if (Caja.Text == "")
                {

                }
                else if (Caja3.Text == "")
                {

                }
                else
                {
                    //try
                    //{
                    float d1 = float.Parse(Caja3.Text);
                    float d2 = float.Parse(Caja.Text);
                    float r = d1 / d2;
                    Caja.Text = "";
                    Caja2.Text = "";
                    Caja3.Text = "" + r;
                    //}
                    //catch (ArgumentNullException ex)
                    //{
                    //    DisplayAlert("Error", "Excetion Validar campos vacios", "OK");
                    //    Caja.Text = "";
                    //    Caja2.Text = "";
                    //}
                }
            }
        }
     }
 }