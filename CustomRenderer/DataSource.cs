using System;
using System.Collections.Generic;

namespace CustomRenderer
{
	public class DataSource
	{
		public string Name { get; set; }

		public string Category { get; set; }

		public string ImageFilename { get; set; }

        public string Passport { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string Joining { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }


		public DataSource (string name, string category, string imageFilename,string passport,string dob,string gender,string joining,string religion,string department,string nationality ,string designation)
		{
			Name = name;
			Category = category;
			ImageFilename = imageFilename;
            Passport = passport;
            Dob = dob;
            Gender = gender;
            Joining = joining;
            Nationality = nationality;
            Department = department;
            Designation = designation;
            Religion = religion;
		}

		public static List<DataSource> GetList ()
		{
			var l = new List<DataSource> ();

			l.Add (new DataSource ("Aboobakkar ", "Manager", "abu","aboobakar p s","22/06/1991" , "male", "22/07/2014", "islam","IT","Indian","Developer"));
			l.Add (new DataSource ("sarath", "engineer", "abu","sarathkumar", "22/06/1991", "male", "22/07/2013", "islam", "IT", "Indian", "Developer"));
			l.Add (new DataSource ("gokul", "engineer", "abu","gokul", "22/06/1991", "male", "22/07/2014", "islam", "IT", "Indian", "Developer"));
			l.Add (new DataSource ("sreelakshmi", "engineer", "abu","gokul", "22/06/1991", "female", "22/07/2014", "islam", "IT", "Indian", "Developer"));
			l.Add (new DataSource ("ninju", "analyst", "abu","gokul", "22/06/1991", "female", "22/07/2014", "christian", "IT", "Indian", "Developer"));
			l.Add (new DataSource ("priya ", "analyst", "abu", "reethu", "22/06/1991", "female", "22/07/2014", "christian", "IT", "Indian", "analyst"));
			l.Add (new DataSource ("ajith", "BDM", "abu", "gokul", "22/06/1991", "male", "22/07/2014", "hindu", "IT", "Indian", "Developer"));
			l.Add (new DataSource ("aysha", "BDM", "abu", "gokul", "22/06/1991", "female", "22/07/2014", "islam", "IT", "Indian", "analyst"));
			l.Add (new DataSource ("shaharban", "BDM", "abu", "reethu", "22/06/1991", "female", "22/07/2013", "islam", "IT", "Indian", "Developer"));
			l.Add (new DataSource ("emma", "developer", "abu", "gokul", "22/06/1991", "female", "22/07/2014", "christian", "IT", "Indian", "analyst"));
			l.Add (new DataSource ("vineeth", "developer", "abu", "gokul", "22/06/1991", "male", "22/07/2013", "islam", "IT", "Indian", "Developer"));
			l.Add (new DataSource ("thabsheera", "developer", "abu", "gokul", "22/06/1991", "female", "22/07/2014", "islam", "IT", "Indian", "analyst"));
			l.Add (new DataSource ("ahad", "developer", "abu", "gokul", "22/06/1991", "female", "22/07/2014", "islam", "IT", "Indian", "Developer"));
			l.Add (new DataSource ("dinsha", "analyst", "abu", "gokul", "22/06/1991", "female", "22/07/2014", "islam", "IT", "Indian", "Developer"));
            l.Add(new DataSource("reethu", "BDM", "abu", "reethu", "22/06/1991", "female", "22/07/2014", "islam", "IT", "Indian", "Developer"));
            l.Add(new DataSource("daya elsa", "BDM", "abu", "gokul", "22/06/1991", "female", "22/07/2014", "christian", "IT", "Indian", "admin"));
            l.Add(new DataSource("mariya", "developer", "abu", "gokul", "22/06/1991", "female", "22/07/2014", "christian", "IT", "Indian", "admin"));
            l.Add(new DataSource("anumol", "developer", "abu", "gokul", "22/06/1991", "female", "22/07/2014", "islam", "IT", "Indian", "admin"));
            l.Add(new DataSource("fazil", "developer", "abu", "gokul", "22/06/1991", "male", "22/07/2014", "islam", "IT", "Indian", "Developer"));
            l.Add(new DataSource("nahas", "developer", "abu", "gokul", "22/06/1991", "male", "22/07/2014", "islam", "IT", "Indian", "Developer"));
            l.Add(new DataSource("adrian", "analyst", "abu", "gokul", "22/06/1991", "male", "22/07/2014", "christian", "IT", "Indian", "Developer"));


            return l;
		}
	}
}
