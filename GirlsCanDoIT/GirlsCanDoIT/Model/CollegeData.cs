using System;
using System.Collections.Generic;
using System.Text;
using GirlsCanDoIT.View;
using GirlsCanDoIT.ViewModel;
using GirlsCanDoIT.Model;
using Xamarin.Forms;

namespace GirlsCanDoIT.Model
{
	public static class CollegeData
	{
		public static IList<College> Colleges { get; private set; }

		static CollegeData()
		{
			Colleges = new List<College>();

			Colleges.Add(new College
			{
				Name = "University Of Michigan",
				Location = "Ann Arbor",
				Details = "Computer Science and Computer Engineering",
				ImageUrl = "https://staff.studentlife.umich.edu/files/migroups/field/image/unrestricted_giving.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Michigan State University",
				Location = "East Lansing",
				Details = "Computer Science and Computer Engineering",
				ImageUrl = "https://msutoday.msu.edu/_/img/assets/2019/campus-summer-2.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Ferris State University",
				Location = "Big Rapids",
				Details = "Computer Information Systems and Computer Information Technology ",
				ImageUrl = "https://www.ferris.edu/_all_resources/images/clock-tower.jpg"
			});
		}
	}
}
