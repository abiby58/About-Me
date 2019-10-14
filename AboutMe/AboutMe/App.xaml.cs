using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            About_Me_Page = new NavigationPage( new About_Me_Page());
            Contact_Page = new NavigationPage( new Contact_Page());
            Skills_Page = new NavigationPage( new Skills_Page());
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
