using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VaquitApp.View;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;

namespace VaquitApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AgregarIntegranteView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=10829d6e-ab51-429e-ba55-f1b732e8f317;",
                  typeof(Analytics), typeof(Crashes), typeof(Distribute));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
