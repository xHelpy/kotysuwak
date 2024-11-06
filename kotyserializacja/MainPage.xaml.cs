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
        }

        async private void OnCounterClicked(object sender, EventArgs e)
        {
            string Link = "https://cataas.com/cat";
            
            
            

                Cat.Source = Link;
            

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string Link = "https://cataas.com/cat/says/" + input.Text;


            Cat.Source = Link;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string Link = "https://cataas.com/cat/gif";

            Cat.Source = Link;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            string Link = "https://cataas.com/cat/gif/says/" + input2.Text;


            Cat.Source = Link;
        }
    }

}
