using GirlsCanDoIT.Classes;
using GirlsCanDoIT.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace GirlsCanDoIT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CareersPage : ContentPage
    {
        CollegeViewModel vm;
        public CareersPage()
        {
            InitializeComponent();

            vm = new CollegeViewModel();
            // listSpeakers.ItemsSource = vm.College;
            BindingContext = vm;

        }




        [Obsolete]
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });
    }

    public class HyperlinkSpan2 : Span
    {
        public static readonly BindableProperty UrlProperty =
            BindableProperty.Create(nameof(Url), typeof(string), typeof(HyperlinkSpan2), null);

        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        [Obsolete]
        public HyperlinkSpan2()
        {

            TextColor = Color.White;
            FontSize = 20;




            GestureRecognizers.Add(new TapGestureRecognizer
            {
                // Launcher.OpenAsync is provided by Xamarin.Essentials.
                Command = new Command(async () => await Launcher.OpenAsync(Url))
            });
        }


    }
}




