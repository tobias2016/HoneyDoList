using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HoneyDoList
{
	public partial class Dashboard : ContentPage
	{
		public Dashboard ()
		{
			InitializeComponent ();
			this.SetValue(NavigationPage.BarTextColorProperty, Color.White);
//			var Users = new List<String> () {
//				FirstName = "Joseph",
//				LastName = "Grimes",
//				Company = "GG Mechanical",
//				JobTitle = "Vice President",
//				PhotoUrl = "josephgrimes.jpg"
//			};
		}

		void ItemTapped (object sender, ItemTappedEventArgs e)
		{

		}
	}
}
