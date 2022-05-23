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
    public partial class markentry : ContentPage
    {
        public markentry()
        {
            InitializeComponent();

            MainPicker.Items.Add("ODD");

            MainPicker.Items.Add("EVEN");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushModalAsync(new markentrydetail());
        }

        private void MainPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = MainPicker.Items[MainPicker.SelectedIndex];
            DisplayAlert(name, "selected value", "ok");
        }
    }
}