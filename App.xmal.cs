using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App0
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Aquí corregimos la exepción 

            MainPage = new  NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
