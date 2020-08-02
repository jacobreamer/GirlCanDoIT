using GirlsCanDoIT.ViewModel;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GirlsCanDoIT.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CareerView : ContentPage
    {
        CareerViewModel vm;
        public CareerView()
        {
            InitializeComponent();
            vm = new CareerViewModel();
            // listColleges.ItemsSource = vm.College;
            BindingContext = vm;

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}