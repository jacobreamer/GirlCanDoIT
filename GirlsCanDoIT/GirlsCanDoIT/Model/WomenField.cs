using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GirlsCanDoIT.Model
{


    public class WomenField
    {
        public string name { get; set; }
        public string state { get; set; }
        public string image { get; set; }
        public string website { get; set; }
        public string description { get; set; }
    }

    public class WomenListField
    {
        public List<WomenField> womenfield { get; set; }
    }
}