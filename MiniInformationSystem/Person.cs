using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace MiniInformationSystem
{
	public class Person
	{
		public int ID { get; set; }
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public Person (int id=0, string fname="No Name", string lname= "No Last")
		{
			ID = id;
			FirstName = fname;
			LastName = lname;
		}

		public ArrayList Add(ArrayList personlist, int id, string fname, string lname)
		{
			personlist.Add(
				new Person{
					ID = id, FirstName =  fname, LastName = lname });
			Console.WriteLine("Added");
			Console.ReadKey();
			return personlist;

		}

		public ArrayList Delete(ArrayList personlist, int id)
		{
			personlist.Remove(id);

			Console.Write("Removed");
			Console.ReadKey();

			return personlist;
		}

		public void View(ArrayList personlist)
		{
			var personlistenum = personlist.ToArray();
			var query = from person in personlistenum select person;
			foreach (Person s in query)
			{
				Console.WriteLine("ID : {0}\nFirsname : {1}\nLastname : {2}\n", s.ID, s.FirstName, s.LastName);
			}
			Console.ReadKey();

		}

		public void ViewPerson(ArrayList personlist, string lname)
		{ 
			var personlistenum = personlist.ToArray();
			var query = from person in personlistenum where LastName == lname select person;
			foreach (Person s in query)
			{
				Console.WriteLine("ID : {0}\nFirsname : {1}\nLastname : {2}\n", s.ID, s.FirstName, s.LastName);
			}
			Console.ReadKey();
		}
	}
}

