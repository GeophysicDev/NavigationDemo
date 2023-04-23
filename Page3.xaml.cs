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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}
        private void RegresarPagina(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

		private void RegresarAlInicio(object sender, EventArgs e)
		{
			Navigation.PopToRootAsync();
		}

        private void TomarEncuesta(object sender, EventArgs e)
        {
			Navigation.PushAsync(new Cuestionario());
        }
    }
}
