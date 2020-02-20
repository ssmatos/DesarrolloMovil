using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NavigationStyles.Models
{
	public class SignUpModel : INotifyPropertyChanged
	{
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public string Image { get; set; }
        public bool IsPassword { get; set; } = true;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
