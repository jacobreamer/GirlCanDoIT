using System;
using System.Collections.Generic;
using System.Text;

namespace GirlsCanDoIT.Model
{
   

    public class Women
    {
        public string name { get; set; }
        public string image { get; set; }
        public string website { get; set; }
        public string description { get; set; }
    }

    public class WomenList
    {
        public List<Women> women { get; set; }
    }
}