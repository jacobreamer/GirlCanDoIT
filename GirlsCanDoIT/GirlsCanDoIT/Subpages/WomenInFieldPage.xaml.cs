using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GirlsCanDoIT.Subpages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WomenInFieldPage : ContentPage
    {
        public WomenInFieldPage()
        {
            InitializeComponent();

            Assembly asm = Assembly.GetExecutingAssembly();
            StreamReader reader = new StreamReader(asm.GetManifestResourceStream("GirlsCanDoIT.DataFiles.WomenIT.txt"));
            Text_Label.Text = reader.ReadToEnd();

        }
    }
}