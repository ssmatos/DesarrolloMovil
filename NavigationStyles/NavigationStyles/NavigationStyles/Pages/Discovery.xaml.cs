using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationStyles.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Discovery : ContentPage
	{
		public Discovery()
		{
			InitializeComponent();
		}

		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			
			hotel.BackgroundColor = Color.Gold;
			waiter.BackgroundColor = Color.White;
			res.BackgroundColor = Color.White;
			map.BackgroundColor = Color.White;
			fastfood.BackgroundColor = Color.White;
			burger.BackgroundColor = Color.White;
		}

		private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
		{
			hotel.BackgroundColor = Color.White;
			waiter.BackgroundColor = Color.Gold;
			res.BackgroundColor = Color.White;
			map.BackgroundColor = Color.White;
			fastfood.BackgroundColor = Color.White;
			burger.BackgroundColor = Color.White;
		}

		private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
		{
			hotel.BackgroundColor = Color.White;
			waiter.BackgroundColor = Color.White;
			res.BackgroundColor = Color.Gold;
			map.BackgroundColor = Color.White;
			fastfood.BackgroundColor = Color.White;
			burger.BackgroundColor = Color.White;
		}

		private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
		{
			hotel.BackgroundColor = Color.White;
			waiter.BackgroundColor = Color.White;
			res.BackgroundColor = Color.White;
			map.BackgroundColor = Color.Gold;
			fastfood.BackgroundColor = Color.White;
			burger.BackgroundColor = Color.White;
		}

		private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
		{
			hotel.BackgroundColor = Color.White;
			waiter.BackgroundColor = Color.White;
			res.BackgroundColor = Color.White;
			map.BackgroundColor = Color.White;
			fastfood.BackgroundColor = Color.Gold;
			burger.BackgroundColor = Color.White;
		}

		private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
		{
			hotel.BackgroundColor = Color.White;
			waiter.BackgroundColor = Color.White;
			res.BackgroundColor = Color.White;
			map.BackgroundColor = Color.White;
			fastfood.BackgroundColor = Color.White;
			burger.BackgroundColor = Color.Gold;
		}
	}
}