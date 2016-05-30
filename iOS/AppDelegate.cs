using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace HoneyDoList.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			LoadApplication (new App ());

			UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB (134, 22, 237);
			UINavigationBar.Appearance.TintColor = UIColor.White;
			return base.FinishedLaunching (app, options);
			UINavigationBar.Appearance.TitleTextAttributes = new UIStringAttributes { ForegroundColor = UIColor.White };
			UIBarButtonItem.Appearance.SetTitleTextAttributes (new UITextAttributes { TextColor = UIColor.White }, UIControlState.Normal);
		}
	}
}

