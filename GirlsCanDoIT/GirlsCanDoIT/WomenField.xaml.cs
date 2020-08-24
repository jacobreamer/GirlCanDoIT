using System.IO;
using System.Reflection;
using GirlsCanDoIT.Model;
using Newtonsoft.Json;
using Xamarin.Forms;
using GirlsCanDoIT;
using System.Windows.Input;
using System.Security.Cryptography.X509Certificates;

namespace GirlsCanDoIT
{
   
    public partial class WomenField : ContentPage
    {
        public WomenField()
        {
            InitializeComponent();
            GetJsonData();
        }

        [System.Obsolete]
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });

        void GetJsonData()
        {
            string jsonFileName = "TopWomenField.json";
            WomenListField ObjWomenListField = new WomenListField();
            var assembly = typeof(WomenField).GetTypeInfo().Assembly;
            Stream streams = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var readers = new System.IO.StreamReader(streams))
            {
                var jsonString = readers.ReadToEnd();

                //Converting JSON Array Objects into generic list
                ObjWomenListField = JsonConvert.DeserializeObject<WomenListField>(jsonString);
            }
            //Binding listview with json string
            listviewWomenField.ItemsSource = ObjWomenListField.womenfield;
        }
    }
}
