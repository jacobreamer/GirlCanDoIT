using GirlsCanDoIT.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GirlsCanDoIT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcademicsPage : ContentPage
    {
        CareerViewModel vm;

        public AcademicsPage()
        {
            InitializeComponent();



            vm = new CareerViewModel();
            // listSpeakers.ItemsSource = vm.College;
            BindingContext = vm;
        }





    }
}
