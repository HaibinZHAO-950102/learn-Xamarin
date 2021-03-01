using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //var stakelayout = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.Center,
            //    HorizontalOptions = LayoutOptions.Center,
            //    Orientation = StackOrientation.Vertical
            //};

            //stakelayout.Children.Add(new Label { Text = "Welcome to Xamarin!", FontSize = 26 });
            //stakelayout.Children.Add(new Label { Text = "I am Haibin" });
            //stakelayout.Children.Add(new Button { Text = "Log in"} );
            //stakelayout.Children.Add(new Button { Text = "Registration" });

            //Content = stakelayout;
        }
    }
}
