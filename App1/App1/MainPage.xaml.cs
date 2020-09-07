using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnOk(object sender, EventArgs e)
        {
            if (entryUser.Text == "admin" && entryPassword.Text == "123456")
            {
                DisplayAlert("", "Login realizado com sucesso", "Ok");
            }
            else
            {
                DisplayAlert("", "Login falhou", "Ok");
            }
        }

        private void btnClean(object sender, EventArgs e)
        {
            entryPassword.Text = "";
            entryUser.Text = "";
        }

        private async void btnCredits(object sender, EventArgs e)
        {
            await DisplayAlert("Créditos", "Feito por Guilherme Borges Cunha", "Fechar");
        }
    }
}
