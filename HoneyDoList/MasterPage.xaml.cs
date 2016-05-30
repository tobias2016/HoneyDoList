using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HoneyDoList
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent ();
//			NavigationPage.SetHasNavigationBar(this, false);
			var masterPageItems = new List<MasterPageItem> ();
			masterPageItems.Add (new MasterPageItem {
				Title = "Home",
				IconSource = "home.png",
				TargetType = typeof(Dashboard)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Create New Todo",
				IconSource = "add.png",
				TargetType = typeof(CreateTodo)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "My Todos",
				IconSource = "mytodo.png",
				TargetType = typeof(MyTodo)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Friends",
				IconSource = "friends.png",
				TargetType = typeof(Friends)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Settings",
				IconSource = "setting.png",
				TargetType = typeof(SettingPage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "My Profile",
				IconSource = "profile.png",
				TargetType = typeof(ProfilePage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Change Password",
				IconSource = "change.png",
				TargetType = typeof(ChangePassword)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}

