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
    public partial class WomenListByState : ContentPage
    {
        public WomenListByState(string state)
        {
            InitializeComponent();

            Title_Text.Text = "Women in The Field From " + state;
        }
    }
}