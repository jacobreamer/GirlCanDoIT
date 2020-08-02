using GirlsCanDoIT.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GirlsCanDoIT.ViewModel
{
    public class CollegeViewModel
    {
        public List<College> Colleges { get; set; }

        public CollegeViewModel()
        {
            Colleges = new College().GetColleges();
        }

    }
}
