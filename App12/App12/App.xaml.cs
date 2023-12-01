using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.Vista();
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
