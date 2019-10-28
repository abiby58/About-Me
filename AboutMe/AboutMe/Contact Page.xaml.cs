using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact_Page : ContentPage
    {
        public Contact_Page()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Thank you", "Your message has been delivered", "OK");
        }
        

        
    }
}