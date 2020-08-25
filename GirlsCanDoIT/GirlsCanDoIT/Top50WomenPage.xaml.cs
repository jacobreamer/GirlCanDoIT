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
    public partial class Top50WomenPage : ContentPage
    {
        public Top50WomenPage()
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
            string jsonFileName = "JsonFiles.women.json";
            WomenList ObjWomenList = new WomenList();
            var assembly = typeof(Top50WomenPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();

                //Converting JSON Array Objects into generic list
                ObjWomenList = JsonConvert.DeserializeObject<WomenList>(jsonString);
            }
            //Binding listview with json string
            listviewWomen.ItemsSource = ObjWomenList.women;
        }
    }
}
