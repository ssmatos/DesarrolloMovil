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
		Button lastElementSelected = new Button();
		public Discovery()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			lastElementSelected.BackgroundColor = Color.White;
			var elementSelected = (Button)sender;
			elementSelected.BackgroundColor = Color.Gold;
			lastElementSelected = elementSelected;
		}
	}
}