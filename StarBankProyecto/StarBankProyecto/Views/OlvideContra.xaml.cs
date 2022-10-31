﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarBankProyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OlvideContra : ContentPage
    {
        public OlvideContra()
        {
            InitializeComponent();
        }

        private async void changeContra(Object sender, EventArgs e)
        {
            //Agregar metodo para enviar codigo al correo 
            await Navigation.PushAsync(new Views.CambiarContra());
        }

    }
}