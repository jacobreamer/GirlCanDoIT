using System.Collections.Generic;

namespace GirlsCanDoIT.Model
{
    public class Careers
    {
        public string Career_Name { get; set; }
        public string CareerName { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }

        public List<Careers> GetCareers()
        {
            List<Careers> careers = new List<Careers>()
            {

                 new Careers()
                {
                    Career_Name="Computer and Information Research Scientists", Url="https://www.bls.gov/ooh/computer-and-information-technology/computer-and-information-research-scientists.htm", ImageUrl="https://www.iconsdb.com/icons/preview/white/decision-xxl.png", CareerName="Application Support Analyst, Systems Analyst, Systems Designer, etc.", ShortDescription="Computer and Information Research Scientists work at creating and implementing systems that run as efficient as possible. They can look at an overall IT infrastructure and create plans to optimize them to better suit the need at hand."
                },

                new Careers()
                {
                    Career_Name="Computer Network Architects", Url="https://www.bls.gov/ooh/computer-and-information-technology/computer-network-architects.htm", ImageUrl="https://www.iconsdb.com/icons/preview/white/network-xxl.png", CareerName="Computer Network Architect, IT Analyst, Network Architect, etc.", ShortDescription="Network architects set up, support, and maintain networks across the world. This could relate to security, troubleshooting, or installing networks in a given system. "
                },

                new Careers()
                {
                    Career_Name="Computer Support Specialist", Url="https://www.bls.gov/ooh/computer-and-information-technology/computer-support-specialists.htm", ImageUrl="https://www.iconsdb.com/icons/preview/white/online-support-xxl.png", CareerName="Customer Support Admin, Help Desk Technician, Technical Support Engineer, etc.", ShortDescription="Computer support specialists help individual users and organizations with computer related troubleshooting. They may do testing themselves to ensure functionality within a system or by helping people with computer problems. This is a common start and a good entry level position in information technology."
                },

                new Careers()
                {
                    Career_Name="Database Administrator", Url="https://www.bls.gov/ooh/computer-and-information-technology/database-administrators.htm", ImageUrl="https://www.iconsdb.com/icons/preview/white/data-configuration-xxl.png", CareerName="Data Center Support Specialist, Data Quality Manager, Database Administrator, etc.", ShortDescription="Database admins can create and store information in a secure manner in a database for companies/customers. They ensure the database runs smoothly and fix any problems that may arise. "
                },

                new Careers()
                {
                    Career_Name="Information Security Specialist", Url="https://www.bls.gov/ooh/computer-and-information-technology/information-security-analysts.htm", ImageUrl="https://www.iconsdb.com/icons/preview/white/lock-xxl.png", CareerName="Information Security, Security Specialist, Senior Security Specialist, etc.", ShortDescription="Information security analysts help defend an organization or individual’s computer network and systems from unwanted access. This is an extremely fast-growing field as the need for security specialists grows each year. They install software that helps secure systems as well as act as threats to test the levels of their organizations security. "
                },

                new Careers()
                {
                    Career_Name="Software/Application Developer", Url="https://www.bls.gov/ooh/computer-and-information-technology/software-developers.htm", ImageUrl="https://www.iconsdb.com/icons/preview/white/window-apps-xxl.png", CareerName="Application Developer, Java Developer, Programmer Analyst, .NET Developer, etc.", ShortDescription="Software developers create and test computer programs and applications. They typically code these programs themselves and work through any issues that programs may materialize while running."
                },

                new Careers()
                {
                    Career_Name="Web Developer", Url="https://www.bls.gov/ooh/computer-and-information-technology/web-developers.htm", ImageUrl="https://www.iconsdb.com/icons/preview/white/website-design-xxl.png", CareerName="Webmaster, Web Admin, Web Developer, etc.", ShortDescription="Web Developers design, implement, and manage websites. They can create a user friendly interface for the client to easily access to change information found on the site. "
                }




            };
            return careers;
        }

    }
}
