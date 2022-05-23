using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace csiit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class welcome : ContentPage
    {
        public welcome()
        {
            InitializeComponent();

            myname.Text = $"WELCOME {Application.Current.Properties["Username"].ToString()}";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new attendance_entry());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new markentry());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}