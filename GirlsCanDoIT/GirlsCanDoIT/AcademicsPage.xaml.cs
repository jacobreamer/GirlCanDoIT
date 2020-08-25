using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GirlsCanDoIT;
using GirlsCanDoIT.View;
using GirlsCanDoIT.ViewModel;
using GirlsCanDoIT.Model;

namespace GirlsCanDoIT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcademicsPage : ContentPage
    {

        public AcademicsPage()
        {
            InitializeComponent();
            BindingContext = new AcademicPageViewModel();   
        }

        private void MichiganButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CollegeStates());
        }
    
    }
}