using GirlsCanDoIT.Classes;
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
    public partial class ProfessionalResourcesPage : ContentPage
    { // Launcher.OpenAsync is provided by Xamarin.Essentials.

        public ProfessionalResourcesPage()
        {
            InitializeComponent();
            BindingContext = this;

            foreach (string allstates in States.StatesArray)
            {
                statePicker.Items.Add(allstates);
            }
        }


        private void statePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var state = statePicker.Items[statePicker.SelectedIndex];
            DisplayAlert(state, "Selected value", "OK");
        }

        public void facebookButton_Clicked(object sender, EventArgs e)
        {
          
        }

        [Obsolete]
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });

    }
    public class HyperlinkSpan : Span
    {
        public static readonly BindableProperty UrlProperty =
            BindableProperty.Create(nameof(Url), typeof(string), typeof(HyperlinkSpan), null);

        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        [Obsolete]
        public HyperlinkSpan()
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