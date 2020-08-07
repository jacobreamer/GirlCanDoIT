using GirlsCanDoIT.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GirlsCanDoIT;

namespace GirlsCanDoIT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcademicsPage : ContentPage
    {
        private CareerViewModel vm;

        public AcademicsPage()
        {
            InitializeComponent();

            vm = new CareerViewModel();
            // listSpeakers.ItemsSource = vm.College;
            BindingContext = vm;
        }


        async void MichiganButton_Clicked(object sender, EventArgs e)
        {
            
            var contact = new Contact
            {
                Name = "Jane Doe",
                Age = 30,
                Occupation = "Developer",
                Country = "USA"
            };

           
            var collegeStates = new CollegeStates();
            collegeStates.BindingContext = contact;
            await Navigation.PushAsync(collegeStates);
        }
    }
}