using System;
using Xamarin.Forms;
using ControladorManual.Model;


namespace ControladorManual
{
    public partial class MainPage : ContentPage
    {
        private Contador _Contador;

        public MainPage()
        {
            InitializeComponent();
            _Contador = new Contador();
            //ConteoLabel.Text = _Contador.Conteo.ToString();
            ConteoLabel.BindingContext = _Contador;
        }

        private void ContarButton_Clicked(object sender, EventArgs e)
        {
            _Contador.Contar();
            //ConteoLabel.Text = _Contador.Conteo.ToString();
        }

        private void ReiniciarButton_Clicked(object sender, EventArgs e)
        {
            _Contador.ReiniciarConteo();
            //ConteoLabel.Text = _Contador.Conteo.ToString();
        }

    }
}
