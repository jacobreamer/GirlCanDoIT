using System;
using System.Collections.Generic;
using System.Text;

namespace GirlsCanDoIT.Classes
{
    public class Careers
    {
        public static List<string> CareersArray { get; }

        static Careers()
        {
            CareersArray = new List<string>(50);
            CareersArray.Add("Software Developer");
            CareersArray.Add("IT Manager");
            CareersArray.Add("Web Developer");
            CareersArray.Add("Database Administrator");
            CareersArray.Add("Information Security Analyst");
            CareersArray.Add("Computer Systems Analyst");
            CareersArray.Add("Computer Network Architect");
        }
        public static string[] CareerNames()
        {
            List<string> careersList = new List<string>(CareersArray.Count);
            foreach (string career in CareersArray)
            {
                careersList.Add(career);
            }
            return careersList.ToArray();
        }
    }
}
