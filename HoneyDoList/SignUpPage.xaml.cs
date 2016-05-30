using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace HoneyDoList
{
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();
		}

		async void OnSignUpClicked (object sender, EventArgs e)
		{
			var user = new User () {
				Firstname = firstnameEntry.Text,
				Lastname = lastnameEntry.Text,
				Fullname = fullnameEntry.Text,
				Email = emailEntry.Text,
				Password = passwordEntry.Text
			};

			var result = await App.TodoManager.SignUpUserAsync (user);
			if (result) {
				Navigation.InsertPageBefore (new CreateTodo (), Navigation.NavigationStack.First ());
				await Navigation.PopToRootAsync ();
			} else {

			}
		}

		void OnTermsClicked (object sender, EventArgs e)
		{

		}

		void OnConditionsClicked (object sender, EventArgs e)
		{

		}

	}
}

