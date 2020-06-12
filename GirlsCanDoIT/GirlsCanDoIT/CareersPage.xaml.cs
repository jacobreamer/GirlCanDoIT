using GirlsCanDoIT.Classes;
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
    public partial class CareersPage : ContentPage
    {
        public CareersPage()
        {
            InitializeComponent();

            foreach (string allCareers in Careers.CareersArray)
            {
                careerPicker.Items.Add(allCareers);
            }

        }

        private void careerPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var career = careerPicker.Items[careerPicker.SelectedIndex];
            DisplayAlert(career, "Selected value", "OK");
            
        }
    }
}