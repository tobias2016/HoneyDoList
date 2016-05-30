using System;

using Xamarin.Forms;

namespace HoneyDoList
{
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();
		}

		void OnLoginClicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new MainPage ());
			this.SetValue(NavigationPage.BarTextColorProperty, Color.White);
		}

		void OnSignUpClicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new SignUpPage ());
		}

		void OnForgotClicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new ForgetPassword ());
		}

	}
}
