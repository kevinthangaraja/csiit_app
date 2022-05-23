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
    public partial class markentrydetail : ContentPage
    {
        public markentrydetail()
        {
            InitializeComponent();
            MainPicker.Items.Add("Cyber Forensics");

            MainPicker.Items.Add("Information Retrieval Techniques");

            MainPicker1.Items.Add("IAT1");

            MainPicker1.Items.Add("IAT2");
            MainPicker1.Items.Add("IAT3");
        }

        private void MainPicker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = MainPicker1.Items[MainPicker1.SelectedIndex];
            DisplayAlert(name, "selected value", "ok");
        }

        private void MainPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = MainPicker.Items[MainPicker.SelectedIndex];
            DisplayAlert(name, "selected value", "ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new welcome());
        }
    }
}