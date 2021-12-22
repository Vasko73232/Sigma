using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sigma.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private async void Login(object sender, System.EventArgs e)
        {
            string loginStatus = "isSuccess";



            if (loginStatus == "isSuccess") {
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                DisplayAlert("Sorry", "Something went wrong in server.", "Ok");
            }
        }
        private async void Registration(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}