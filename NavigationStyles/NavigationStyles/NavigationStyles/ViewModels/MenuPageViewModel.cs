using NavigationStyles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace NavigationStyles.ViewModels
{
	public class MenuPageViewModel : INotifyPropertyChanged
	{
        public MenuElements HotelElements { get; set; } = new MenuElements();
        public MenuElements FineElements { get; set; } = new MenuElements();
        public MenuElements CafeElements { get; set; } = new MenuElements();
        public MenuElements MapElements { get; set; } = new MenuElements();
        public MenuElements FastElements { get; set; } = new MenuElements();
        public MenuElements FoodElements { get; set; } = new MenuElements();
        public Command ChangeColorCommand { get; set; }
        public MenuPageViewModel()
        {
            HotelElements.Title = "Bar & Hotels";
            HotelElements.ImageSource = "hotel";

            FineElements.Title = "Fine Dining";
            FineElements.ImageSource = "waiter";

            CafeElements.Title = "Cafes";
            CafeElements.ImageSource = "restaurant";

            MapElements.Title = "Nearby";
            MapElements.ImageSource = "map";

            FastElements.Title = "Fast Foods";
            FastElements.ImageSource = "fastfood";

            FoodElements.Title = "Featured Foods";
            FoodElements.ImageSource = "burger";
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
