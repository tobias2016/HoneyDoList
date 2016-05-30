using System;

using Xamarin.Forms;

namespace HoneyDoList
{
	public class TodoDetailPageCS : ContentPage
	{
		public TodoDetailPageCS ()
		{
			Title = "TodoList Page";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Todo list data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}


