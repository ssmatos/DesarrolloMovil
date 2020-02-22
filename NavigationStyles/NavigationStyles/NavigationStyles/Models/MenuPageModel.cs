using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NavigationStyles.Models
{
	public class MenuPageModel : INotifyPropertyChanged
	{
		public string Title { get; set; }
		public Object ImageSource { get; set; }
		public Xamarin.Forms.Color Color { get; set; } = Xamarin.Forms.Color.White;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
