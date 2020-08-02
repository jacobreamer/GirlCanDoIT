using GirlsCanDoIT.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GirlsCanDoIT.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollegeView : ContentPage
    {
        CollegeViewModel vm;
        public CollegeView()
        {
            InitializeComponent();
            vm = new CollegeViewModel();
            // listColleges.ItemsSource = vm.College;
            BindingContext = vm;
        
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}