using System.Collections.Generic;

namespace GirlsCanDoIT.Classes
{
    public class States
    {
        public static List<string> StatesArray { get; }

        static States()
        {
            StatesArray = new List<string>(50);
            StatesArray.Add("Alabama");
            StatesArray.Add("Alaska");
            StatesArray.Add("Arizona");
            StatesArray.Add("Arkansas");
            StatesArray.Add("California");
            StatesArray.Add("Colorado");
            StatesArray.Add("Connecticut");
            StatesArray.Add("Delaware");
            StatesArray.Add("District Of Columbia");
            StatesArray.Add("Florida");
            StatesArray.Add("Georgia");
            StatesArray.Add("Hawaii");
            StatesArray.Add("Idaho");
            StatesArray.Add("Illinois");
            StatesArray.Add("Indiana");
            StatesArray.Add("Iowa");
            StatesArray.Add("Kansas");
            StatesArray.Add("Kentucky");
            StatesArray.Add("Louisiana");
            StatesArray.Add("Maine");
            StatesArray.Add("Maryland");
            StatesArray.Add("Massachusetts");
            StatesArray.Add("Michigan");
            StatesArray.Add("Minnesota");
            StatesArray.Add("Mississippi");
            StatesArray.Add("Missouri");
            StatesArray.Add("Montana");
            StatesArray.Add("Nebraska");
            StatesArray.Add("Nevada");
            StatesArray.Add("New Hampshire");
            StatesArray.Add("New Jersey");
            StatesArray.Add("New Mexico");
            StatesArray.Add("New York");
            StatesArray.Add("North Carolina");
            StatesArray.Add("North Dakota");
            StatesArray.Add("Ohio");
            StatesArray.Add("Oklahoma");
            StatesArray.Add("Oregon");
            StatesArray.Add("Pennsylvania");
            StatesArray.Add("Rhode Island");
            StatesArray.Add("South Carolina");
            StatesArray.Add("South Dakota");
            StatesArray.Add("Tennessee");
            StatesArray.Add("Texas");
            StatesArray.Add("Utah");
            StatesArray.Add("Vermont");
            StatesArray.Add("Virginia");
            StatesArray.Add("Washington");
            StatesArray.Add("West Virginia");
            StatesArray.Add("Wisconsin");
            StatesArray.Add("Wyoming");
        }

        public static string[] StatesNames()
        {
            List<string> statesList = new List<string>(StatesArray.Count);
            foreach (string state in StatesArray)
            {
                statesList.Add(state);
            }
            return statesList.ToArray();
        }
    }
}

