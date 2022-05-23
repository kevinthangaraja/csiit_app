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
    public partial class attendance_entry : ContentPage
    {
        public attendance_entry()
        {
            InitializeComponent();


            MainPicker.Items.Add("ODD");

            MainPicker.Items.Add("EVEN");
        }

        private void MainPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = MainPicker.Items[MainPicker.SelectedIndex];
            DisplayAlert(name, "selected value", "ok");  
           
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Recalculate();
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            Recalculate();
        }

        void Recalculate()
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date +
                (includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);

            resultLabel.Text = String.Format("{0} day{1} between dates",
                                                timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new attendance_enty_detail());
        }
    }
}