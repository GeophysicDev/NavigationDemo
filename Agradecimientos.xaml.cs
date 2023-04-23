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
	public partial class Agradecimientos : ContentPage
	{
		public Agradecimientos ()
		{
			InitializeComponent ();
		}

        private void RegresaralInicio(object sender, EventArgs e)
        {
			Navigation.PopToRootAsync();

        }
    }
}
