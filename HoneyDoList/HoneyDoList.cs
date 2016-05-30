using System;
using Xamarin.Forms;

namespace HoneyDoList
{
	public class App : Application
	{
		public static TodoItemManager TodoManager { get; set; }
		public static ITextToSpeech Speech { get; set; }

		public App()
		{
			MainPage = new NavigationPage (new LoginView ());
			MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);
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
