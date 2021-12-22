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
    public partial class CasePage : ContentPage
    {
        StackLayout saleList;
        string isOpen = "Close";
        public CasePage()
        {

            InitializeComponent();
            saleList = SaleList;
           

        }
        private async void Visible(object sender, System.EventArgs e)
        {
            
            Button button = (Button)sender;
            if (isOpen == "Open")
            {
                button.ImageSource = "icon_arrowclose.png";
                isOpen = "Close";
                saleList.IsVisible= !saleList.IsVisible;
            }
            else
            {
                button.ImageSource = "icon_arrowopen.png";
                isOpen = "Open";
                saleList.IsVisible = !saleList.IsVisible;
            }


        }

    }
}