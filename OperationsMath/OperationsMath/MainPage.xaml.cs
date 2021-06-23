using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OperationsMath
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Sumar_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(num1.Text) && !String.IsNullOrWhiteSpace(num2.Text))
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int result = n1 + n2;
                await Navigation.PushModalAsync(new Segunda(result));
            }
            else
            {
                await DisplayAlert("Advertencia", "Llene Ambos Campos para Continuar", "Cerrar");
            }
        }

        private async void Dividir_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(num1.Text) && !String.IsNullOrWhiteSpace(num2.Text))
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int result = n1 / n2;
                await Navigation.PushModalAsync(new Segunda(result));
            }
            else
            {
                await DisplayAlert("Advertencia", "Llene Ambos Campos para Continuar", "Cerrar");
            }
        }

        private async void Multiplicar_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(num1.Text) && !String.IsNullOrWhiteSpace(num2.Text))
            {

                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int result = n1 * n2;
                await Navigation.PushModalAsync(new Segunda(result));
            }
            else
            {
                await DisplayAlert("Advertencia", "Llene Ambos Campos para Continuar", "Cerrar");
            }
        }

        private async void Restar_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(num1.Text) && !String.IsNullOrWhiteSpace(num2.Text))
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int result = n1 - n2;
                await Navigation.PushModalAsync(new Segunda(result));
            }
            else
            {
                await DisplayAlert ("Advertencia", "Llene Ambos Campos para Continuar", "Cerrar");
            }
        }
    }
}
