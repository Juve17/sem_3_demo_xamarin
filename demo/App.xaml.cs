using Xamarin.Forms;

namespace demo
{
    public partial class App : Application
    {
        public static FlyoutPage MasterDet { get; set; }
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
