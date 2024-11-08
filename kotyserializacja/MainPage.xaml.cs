using System.Data.Common;
using static System.Net.WebRequestMethods;

namespace kotyserializacja
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            string Link = "https://cataas.com/cat";

            Cat.Source = Link;
        }

 

        private void catSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Cat.HeightRequest = e.NewValue;
        }
    }

}
