using intro_to_xamrine_forums;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace intro_to_xamrine_forums
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyPage();

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
