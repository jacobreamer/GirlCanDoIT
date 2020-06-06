using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GirlsCanDoIT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcademicsPage : ContentPage
    {
        public AcademicsPage()
        {
            InitializeComponent();
        }

        private void statePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var state = statePicker.Items[statePicker.SelectedIndex];
            DisplayAlert(state, "Selected value", "OK");
        }
    }
}