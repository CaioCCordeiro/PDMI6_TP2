﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDMI6_TP2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutroProdutoFormPage : ContentPage
    {
        public OutroProdutoFormPage()
        {
            InitializeComponent();
        }

        async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}