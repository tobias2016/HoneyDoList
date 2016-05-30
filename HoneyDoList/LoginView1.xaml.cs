using System;

using Xamarin.Forms;

namespace HoneyDoList
{
	public partial class LoginView : ContentPage
	{
		bool originalTemplate = true;
		ControlTemplate tealTemplate;
		ControlTemplate aquaTemplate;

		public static readonly BindableProperty HeaderTextProperty = BindableProperty.Create ("HeaderText", typeof(string), typeof(LoginView), null);
		public static readonly BindableProperty FooterTextProperty = BindableProperty.Create ("FooterText", typeof(string), typeof(LoginView), null);

		public string HeaderText {
			get { return (string)GetValue (HeaderTextProperty); }
		}

		public string FooterText {
			get { return (string)GetValue (FooterTextProperty); }
		}

		public LoginView ()
		{
			InitializeComponent ();
			tealTemplate = (ControlTemplate)Application.Current.Resources ["TealTemplate"];
			aquaTemplate = (ControlTemplate)Application.Current.Resources ["AquaTemplate"];
		}

		void OnButtonClicked (object sender, EventArgs e)
		{
			originalTemplate = !originalTemplate;
			contentView.ControlTemplate = (originalTemplate) ? tealTemplate : aquaTemplate;
		}

	}
}

