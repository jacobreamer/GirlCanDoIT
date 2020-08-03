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
            StreamReader reader = new StreamReader(asm.GetManifestResourceStream("GirlsCanDoIT.DataFiles.WomenInField.txt"));

            List<string[]> WomenList = new List<string[]>();
            string[] Woman = new string[2];

            int count = 1;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                //listA.Add(values[0]);
                //listB.Add(values[1]);
                WomenList.Add(values[0],values[1]);
                //Woman[1] = values[1];

                count = +1;

                
            }
            Text_Label.Text = Woman[0] +" and "+ Woman[1];
            
            //Text_Label.Text = reader.ReadLine();

        }


    }
}