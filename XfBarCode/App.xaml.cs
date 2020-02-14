using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XfBarCode
{
    public partial class App : Application
    {
        public handler hx;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
