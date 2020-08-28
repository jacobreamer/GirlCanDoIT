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
				Details = "Computer and Information Sciences, Computer Hardware Engineering, Computer Science, Data Science, Information Science and Network, Database, and System Administration. ",
				ImageUrl = "https://staff.studentlife.umich.edu/files/migroups/field/image/unrestricted_giving.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Michigan Technological University",
				Location = "Houghton",
				Details = "Computer Engineering, Computer Network and System Administration, Computer Science, Cybersecurity, General Computing, Management Information Systems, Math + Computer Science, Robotics Engineering, Scientific and Technical Communication and Software Engineering.",
				ImageUrl = "https://www.investupmi.com/wp-content/uploads/2019/06/Drone-images-of-campus-201810050017-768x432.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Lawrence Technological University",
				Location = "Southfield",
				Details = "Computer Engineering, Computer Science, Embedded Software Engineering, Game Design, Information Technology, Mathematics and Computer Science, Physics and Computer Science and Robotics Engineering. ",
				ImageUrl = "https://www.clickondetroit.com/resizer/yr-hvhQXEHEDOXqNvKvCEFQkz8E=/640x360/smart/filters:format(jpeg):strip_exif(true):strip_icc(true):no_upscale(true):quality(65)/arc-anglerfish-arc2-prod-gmg.s3.amazonaws.com/public/KUOXWKPRKBDWFP5RLRMPK2DVVI.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Ferris State University",
				Location = "Big Rapids",
				Details = "Computer and Information Systems Security, Computer Science, Computer Information Systems, Cybersecurity, Computer Systems Networking and Telecommunications, Computer Networking, Information Science and Computer Information Technology.  ",
				ImageUrl = "https://www.ferris.edu/admissions/Orientation/images/campus-aerial.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Davenport University",
				Location = "Grand Rapids",
				Details = "Computer and Information Systems Security, Computer Programming, Computer Science, Computer Systems Analysis, Computer Systems Networking and Telecommunications and Information Science.",
				ImageUrl = "https://www.commonapp.org/static/e25efad9d4e94f6be4760dfb033c8706-659c67406c716750fb6bcd1fcfc55a91.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Calvin College",
				Location = "Grand Rapids",
				Details = "Computer Science, Computer Systems Analysis, Data Science and Electrical & Computer Engineering Concentration. ",
				ImageUrl = "https://s3-prod.crainsdetroit.com/s3fs-public/styles/width_792/public/Calvin%20College-main_i.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Saginaw Valley State University",
				Location = "University Center",
				Details = "Computer Science, Cybersecurity, and Computer Information Systems. ",
				ImageUrl = "https://www.secondwavemedia.com/mid-michigan/galleries/Features/101414/svsu_edit.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Central Michigan University",
				Location = "Mount Pleasant",
				Details = "Computer Science, Computer Engineering, Information Systems, and Information Technology. ",
				ImageUrl = "https://www.michiganradio.org/sites/michigan/files/styles/medium/public/201108/cmu_campus_0.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Oakland University",
				Location = "Rochester Hills",
				Details = "Computer Science, Computer Engineering and Information Technology. ",
				ImageUrl = "https://www.oakland.edu/Assets/Oakland/oumagazine/graphics/news/admissions/2020/Tower_2200.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Lake Superior State University",
				Location = "Sault Ste Marie",
				Details = "Computer Science, Computer Engineering and Computer Networking. ",
				ImageUrl = "https://i.pinimg.com/originals/10/cd/d7/10cdd741b9218faf6158b4600e6845d9.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Eastern Michigan University",
				Location = "Ypsilanti",
				Details = "Computer Engineering Technology, Computer Information Systems, Computer Science, International Business - Computer Information Systems, Information Technology, Cybersecurity and Information Assurance & Cyber Defense. ",
				ImageUrl = "https://www.commonapp.org/static/6a5e8e269e583362577dd7c8eb3c9523-bed51526a0e1d883f5b14189abd7b6b5.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Northern Michigan University",
				Location = "Marquette",
				Details = "Computer Science, Information Assurance/Cyber Defense and Mobile and Web App Development. ",
				ImageUrl = "https://collegesimply.imgix.net/orig/20200719/northern-michigan-university-171456.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Western Michigan University",
				Location = "Kalamazoo",
				Details = "Computer Engineering, Computer Information Systems, Computer Science and Cybersecurity.  ",
				ImageUrl = "https://mms.businesswire.com/media/20180515005481/en/657587/5/Sangren_Hall.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Adrian College",
				Location = "Adrian",
				Details = "Computer Information Systems. ",
				ImageUrl = "https://diginfootballac.weebly.com/uploads/1/0/8/8/108801053/adriancollege-cainefountainfar-1200x640_1_orig.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Alma College",
				Location = "Alma",
				Details = "Computer Science and Game Design. ",
				ImageUrl = "https://www.alma.edu/live/image/gid/12/width/1260/height/630/crop/1/3202_chapel_panonew2.rev.1386267003.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Aquinas College",
				Location = "Grand Rapids",
				Details = "Computer Information Systems. ",
				ImageUrl = "https://www.aqsoccer.com/images/athletic_field_500px.jpg"
			});


			Colleges.Add(new College
			{
				Name = "Cornerstone University",
				Location = "Grand Rapids",
				Details = "Computer Information Systems.",
				ImageUrl = "https://abound.college/mba/wp-content/uploads/sites/4/2019/02/cornerstone-university-2-1335x888.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Grand Valley State University",
				Location = "Allendale/Grand Rapids",
				Details = "Computer Science, Computer Engineering, Information Technology, Cybersecurity and Information Systems.",
				ImageUrl = "https://www.usnews.com/dims4/USNEWS/d10fe4d/17177859217/resize/800x540%3E/quality/85/?url=https%3A%2F%2Fmedia.beam.usnews.com%2F40%2F6a3bdd16b75f4b28e83d45d7a96198%2Fcollege-photo_33849.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Hope College",
				Location = "Holland",
				Details = "Computer Science. ",
				ImageUrl = "https://www.gannett-cdn.com/presto/2020/03/10/PDTN/19419681-4833-4eba-ad56-ba3e8808c0aa-HopeCollege.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Northwestern Michigan College",
				Location = "Traverse City",
				Details = "Computer Information Technology (Developer, Infrastructure & Security, Office Apps Specialist, Web Developer) ",
				ImageUrl = "https://www.nmc.edu/images/about-images/glc-hero.jpg"
			});

			Colleges.Add(new College
			{
				Name = "Wayne State University",
				Location = "Detroit",
				Details = "Computer Engineering, Computer Science and Computer Technology. ",
				ImageUrl = "https://news.wayne.edu/storage/files/old-main-3.jpg"
			});

			
		}
	}
}
