using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Maps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Maps_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(Latitudetxt.Text, out double lat))
                return;
            if (!double.TryParse(Longitudetxt.Text, out double lng))
                return;
            await Map.OpenAsync(lat, lng, new MapLaunchOptions{
                NavigationMode = NavigationMode.None
            });
            
        }
    }
}
