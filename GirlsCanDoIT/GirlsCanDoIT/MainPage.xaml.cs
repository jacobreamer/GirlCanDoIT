using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
        }

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
