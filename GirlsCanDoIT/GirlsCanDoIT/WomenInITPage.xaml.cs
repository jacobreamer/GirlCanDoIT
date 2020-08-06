
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GirlsCanDoIT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WomenInITPage : ContentPage
    {
        public WomenInITPage()
        {
            InitializeComponent();
        }

        private void WomenInFieldButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Subpages.WomenInFieldPage());
        }

        private void Top50WomenButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Top50WomenPage());
        }
    }
}