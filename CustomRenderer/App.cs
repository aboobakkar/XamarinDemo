using Xamarin.Forms;

namespace CustomRenderer
{
	public class App : Application
	{
		public static string Description { get; set; }
        public static bool IsUserLoggedIn { get; set; }
        public App ()
		{
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }

            //MainPage = new MainPage ();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

