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
    public partial class LoginPage : ContentPage
    {
        public string loginText;
        public string passwordText;
        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            
            InitializeComponent();
           

        }
        private async void OnButtonClicked(object sender, System.EventArgs e)
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
    }
}