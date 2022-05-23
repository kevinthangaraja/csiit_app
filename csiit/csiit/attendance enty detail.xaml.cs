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
    public partial class attendance_enty_detail : ContentPage
    {
        public attendance_enty_detail()
        {
            InitializeComponent();
            MainPicker.Items.Add("Cyber Forensics");

            MainPicker.Items.Add("Information Retrieval Techniques");
        }

        private void MainPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = MainPicker.Items[MainPicker.SelectedIndex];
            DisplayAlert(name, "selected value", "ok");

        }

        
    }
}