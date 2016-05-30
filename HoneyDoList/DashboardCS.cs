using System;

using Xamarin.Forms;

namespace HoneyDoList
{
	public class DashboardCS : ContentPage
	{
		public DashboardCS ()
		{
			Title = "Dashboard Page";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Contacts data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}


