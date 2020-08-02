using GirlsCanDoIT.Classes;
using GirlsCanDoIT.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GirlsCanDoIT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcademicsPage : ContentPage
    {
        CollegeViewModel vm;

        public AcademicsPage()
        {
            InitializeComponent();

            

            vm = new CollegeViewModel();
            // listSpeakers.ItemsSource = vm.College;
            BindingContext = vm;
        }




    
    }
}
