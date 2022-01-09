using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Android.App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtNume.Text == "Georgiana" && txtParola.Text == "12345")
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Alertă", "Nume sau parolă incorecte!", "Ok");
            }
        }

        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new RegisterPage());
        //}
    }
}