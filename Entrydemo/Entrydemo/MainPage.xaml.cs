using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Entrydemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Entry_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            Text1.Text = e.NewTextValue;
        }

        void Entry_Completed(System.Object sender, System.EventArgs e)
        {
            var entry = sender as Entry;
            Text1.Text = entry.Text;
        }
    }
}
