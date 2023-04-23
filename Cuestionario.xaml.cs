using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App0
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cuestionario : ContentPage
	{
		public Cuestionario ()
		{
			InitializeComponent ();

		}

        private void FinalizarEncuesta(object sender, EventArgs e)
        {
            DisplayAlert("Aviso", "Encuesta Finalizada", "OK");
			Navigation.PushAsync(new Agradecimientos());
        }
    }
}
