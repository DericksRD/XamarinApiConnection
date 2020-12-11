using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApiConnection.Services;
using XamarinApiConnection.Views;

namespace XamarinApiConnection
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ApiInformationPage();
        }

        protected override async void OnStart()
        {
            //var service = new GmailApiService();
            //var profile = await service.GetProfileAsync();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
