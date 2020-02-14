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
	public partial class LoginPage : ContentPage
	{
		public LoginPage(string user = "")
		{
			InitializeComponent();
			Entry_Username.Text = user;
		}

		private void ChangeVisibility(object sender, EventArgs e)
		{
			Show_Password.Source = !Entry_Password.IsPassword ? "visibility" : "novisib";
			Entry_Password.IsPassword = !Entry_Password.IsPassword;
		}

		async void ToSignUpPage(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignUpPage(Entry_Username.Text));
		}

		async void LoginButton_Clicked(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(Entry_Username.Text) || string.IsNullOrEmpty(Entry_Password.Text))
			{
				await DisplayAlert("Campo(s) vacios", "Por favor llene el/los campo(s)", "OK");
			}
			else
				await Navigation.PushAsync(new MenuPage());

		}
	}
}