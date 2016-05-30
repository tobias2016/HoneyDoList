using System;

using Xamarin.Forms;

namespace HoneyDoList
{
	public class ReminderPageCS : ContentPage
	{
		public ReminderPageCS ()
		{
			Title = "Reminder Page";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Reminder data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}


