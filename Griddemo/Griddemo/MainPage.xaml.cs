using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Griddemo
{
    public partial class MainPage : ContentPage
    {
        public int flag = 0;

        void Handle_Clicked(System.Object sender, System.EventArgs e)
        {
            var numberButton = (sender as Button);
            var number = numberButton.Text;
            if (flag != 0)
            {
                phonenumber.Text = "";
                flag = 0;
            }
            phonenumber.Text += number;
        }

        void Handle_Clicked_Delete(System.Object sender, System.EventArgs e)
        {
            if (phonenumber.Text.Length > 0)
            {
                phonenumber.Text = phonenumber.Text.Substring(0, phonenumber.Text.Length - 1);
            }
            
        }

        void Handle_Clicked_Calling(System.Object sender, System.EventArgs e)
        {
            phonenumber.Text = "Calling " + phonenumber.Text;
            flag = 1;
        }

        public MainPage()
        {
            InitializeComponent();

            phonenumber.Text = "";
        }

        
    }
}
