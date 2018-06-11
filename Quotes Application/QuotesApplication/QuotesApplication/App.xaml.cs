using QuotesApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonServiceLocator;
using QuotesApplication.Interfaces;
using QuotesApplication.Services;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;

namespace QuotesApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<IQuotes, QuotesApi>();
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(unityContainer));

            MainPage = new QuotesPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
