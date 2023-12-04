using EamenDiapps2.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EamenDiapps2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalcularCalorias1();
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
