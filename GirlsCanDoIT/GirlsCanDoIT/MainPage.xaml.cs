﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Windows.Input;
using Xamarin.Forms.Xaml;
using GirlsCanDoIT.View;

namespace GirlsCanDoIT
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }


        [Obsolete]
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });



        private void BooksButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AcademicsPage());
        }

        private void laptopButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CareersPage());
        }

        private void womenButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WomenInITPage());
        }

        private void infoButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfessionalResourcesPage());
        }

    }
}
