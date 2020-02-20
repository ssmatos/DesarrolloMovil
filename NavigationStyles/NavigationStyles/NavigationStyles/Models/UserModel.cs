using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NavigationStyles.Models
{
	public class UserModel : INotifyPropertyChanged
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public bool IsPassword { get; set; }
		public string Image { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
