using GirlsCanDoIT.Model;
using System.Collections.Generic;

namespace GirlsCanDoIT.ViewModel
{
    public class CareerViewModel
    {
        public List<Careers> Careers { get; set; }

        public CareerViewModel()
        {
            Careers = new Careers().GetCareers();
        }

    }
}
