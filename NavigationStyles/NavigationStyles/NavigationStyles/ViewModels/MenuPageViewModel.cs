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
        public MenuPageModel HotelElement { get; set; } = new MenuPageModel();
        public MenuPageModel FineElement { get; set; } = new MenuPageModel();
        public MenuPageModel CafeElement { get; set; } = new MenuPageModel();
        public MenuPageModel MapElement { get; set; } = new MenuPageModel();
        public MenuPageModel FastElement { get; set; } = new MenuPageModel();
        public MenuPageModel FoodElement { get; set; } = new MenuPageModel();
        public Command ChangeColorCommand { get; set; }
        public MenuPageViewModel()
        {
            //ChangeColorCommand = new Command<MenuPageModel>((param) =>
            //{
            //    lastElementSelected.Color = Color.White;
            //    param.Color = Color.Gold;
            //    lastElementSelected = param;
            //});

            HotelElement.Title = "Bar & Hotels";
            HotelElement.ImageSource = "hotel";

            FineElement.Title = "Fine Dining";
            FineElement.ImageSource = "waiter";

            CafeElement.Title = "Cafes";
            CafeElement.ImageSource = "restaurant";

            MapElement.Title = "Nearby";
            MapElement.ImageSource = "map";

            FastElement.Title = "Fast Foods";
            FastElement.ImageSource = "fastfood";

            FoodElement.Title = "Featured Foods";
            FoodElement.ImageSource = "burger";
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
