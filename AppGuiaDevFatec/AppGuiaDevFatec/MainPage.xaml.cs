using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppGuiaDevFatec.Views;

namespace AppGuiaDevFatec
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Detail = new NavigationPage( (Page) Activator.CreateInstance( typeof(Inicial) ));
            Detail = new NavigationPage(new Inicial());
        }

        private void Button_Inicial_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new Inicial());
                IsPresented = false;

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_BancoDados_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new BancoDeDados());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_ProgramacaoWeb_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new ProgramacaoWeb());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_ProgramacaoMobile_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new ProgramacaoMobile());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_SistemasOperacionais_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new SistemasOperacionais());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_RedesComputadores_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new Redes());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }

        }

        private void Button_Contato_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new Contato());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
