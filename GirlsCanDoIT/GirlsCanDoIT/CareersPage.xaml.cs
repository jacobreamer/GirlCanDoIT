using GirlsCanDoIT.ViewModel;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GirlsCanDoIT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CareersPage : ContentPage
    {
        private CareerViewModel vm;

        public CareersPage()
        {
            InitializeComponent();

            vm = new CareerViewModel();
            BindingContext = vm;
        }

        //Allows the app to open outside browser when hyperlinks are clicked

        [Obsolete]
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });
    }

     //Creates hyperlink class

    public class HyperlinkSpan2 : Span
    {
        public static readonly BindableProperty UrlProperty =
            BindableProperty.Create(nameof(Url), typeof(string), typeof(HyperlinkSpan2), null);

        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        //On tap gesture the hyperlink executes

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