using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationStyles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage(string user="")
		{
			InitializeComponent();
			Entry_Username.Text = user;
	
		}

		async void ToLoginPage(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new LoginPage(Entry_Username.Text));
		}

		private void ChangeVisibility(object sender, EventArgs e)
		{
			Show_Password.Source = !Entry_Password.IsPassword ? "visibility" : "novisib";
			Entry_Password.IsPassword = !Entry_Password.IsPassword;
		}

		private void ChangeVisibility2(object sender, EventArgs e)
		{
			Show_Password2.Source = !Repeat_Password.IsPassword ? "visibility" : "novisib";
			Repeat_Password.IsPassword = !Repeat_Password.IsPassword;
		}

		async void SignUpButton_Clicked(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Entry_Username.Text) || string.IsNullOrEmpty(Entry_Password.Text) || string.IsNullOrEmpty(Entry_Email.Text) || string.IsNullOrEmpty(Repeat_Password.Text))
			{
				await DisplayAlert("Campo(s) vacios", "Por favor llene el/los campo(s)", "OK");
			}
			else
				await Navigation.PushAsync(new MenuPage());
		}
	}
}