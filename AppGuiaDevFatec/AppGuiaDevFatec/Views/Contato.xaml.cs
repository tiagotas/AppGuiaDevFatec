using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Essentials;
using Xamarin.Forms.OpenWhatsApp;

namespace AppGuiaDevFatec.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contato : ContentPage
    {
        public Contato()
        {
            InitializeComponent();

            //stk_corpo.BackgroundColor = Color.FromRgba(0, 0, 0, 0.6);
        }

        private void Button_Discar_Clicked(object sender, EventArgs e)
        {
            try 
            {
                Launcher.OpenAsync("tel:+551936565559");
            
            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Email_Clicked(object sender, EventArgs e)
        {
            try
            {
                Launcher.OpenAsync("mailto:f120acad@fatec.sp.gov.br");

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_WhatsApp_Clicked(object sender, EventArgs e)
        {
            try
            {
                Chat.Open("+551936565559", "Pode me ajudar com o curso de ADS?");
            }
            catch (Exception ex)
            {
                string msg = "Não consegui abrir o WhatsApp. Quer ligar para (19) 3656 5559?";

                bool ligacao = await DisplayAlert("Você não tem WhatsApp", msg, "Ligar", "Agora não");

                if (ligacao)
                    await Launcher.OpenAsync("tel:+551936565559");
            }
        }
    }
}