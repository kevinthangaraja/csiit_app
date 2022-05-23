using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
namespace csiit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        { //var client = new HttpClient();
            //string url = string.Format("http://netflixroulette.net/api/api.php?actor={0}", ator);
            //   var response = client.("http://cms.csiit.ac.in/api/login_api.php?user_name=admin&password=welcome121");
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://cms.csiit.ac.in/");
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // List all Names.

            HttpResponseMessage response = client.GetAsync("api/login_api.php?user_name=" + Username.Text + "&password=" + Password.Text).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                var r1 = response.Content.ReadAsStringAsync().Result;
                if (r1.Contains("null"))
                {
                    DisplayAlert("oops", "user name or password is incorrect", "OK");
                }

                else
                {
                    Application.Current.Properties["Username"] = Username.Text;
                    Application.Current.Properties["Password"] = Password.Text;
                    //DisplayAlert("Welcome", "you are authenticated", "OK");
                    Navigation.PushAsync(new welcome());
                    /// h.GetPropertyIfSet
                }
               
                //Console.WriteLine("Request Message Information:- \n\n" + response.RequestMessage + "\n");
                ///Console.WriteLine("Response Message Header \n\n" + response.Content.Headers + "\n");
            }
            else
            {
                //   Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
           





        }
    }
}
