using NavigationStyles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace NavigationStyles.ViewModels
{
	public class LoginPageViewModel : INotifyPropertyChanged
	{
		public UserModel userModel { get; set; } = new UserModel();
		public Command ConfirmLoginCommand { get; set; }
		public Command SignUpCommand { get; set; }
		public Command VisibilityCommand { get; set; }

		public LoginPageViewModel()
		{
			userModel.Image = "visibility";
			ConfirmLoginCommand = new Command(async () =>
			{
				if (string.IsNullOrEmpty(userModel.Username) || string.IsNullOrEmpty(userModel.Password))
				{
					await App.Current.MainPage.DisplayAlert("Alert", "Some required fields are empty", "OK");
				}
				else
				{
					await App.Current.MainPage.Navigation.PushAsync(new MenuPage());
				}
			});

			SignUpCommand = new Command(async () =>
			{
				await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
			});

			VisibilityCommand = new Command(() =>
			{
				userModel.IsPassword = !userModel.IsPassword ? true : false;
				if (userModel.IsPassword)
				{
					userModel.Image = "visibility";
				}
				else
				{
					userModel.Image = "novisib";
				}
			});
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
