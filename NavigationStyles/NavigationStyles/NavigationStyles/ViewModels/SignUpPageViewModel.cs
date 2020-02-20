using NavigationStyles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace NavigationStyles.ViewModels
{
	public class SignUpPageViewModel : INotifyPropertyChanged
	{
        public SignUpModel User { get; set; } = new SignUpModel();
        public Command VisibilityCommand { get; set; }
        public Command LoginCommand { get; set; }
        public Command ConfirmationSignUp { get; set; }

        public SignUpPageViewModel()
        {
            User.Image = "visibility";
            LoginCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            });

            ConfirmationSignUp = new Command(async () =>
            {
                if (string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Username) || string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.RepeatPassword))
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Some required fields are empty", "OK");
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                }
            });
            VisibilityCommand = new Command(() =>
            {
                User.IsPassword = !User.IsPassword ? true : false;
                if (User.IsPassword)
                {
                    User.Image = "visibility";
                }
                else
                {
                    User.Image = "novisib";
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
