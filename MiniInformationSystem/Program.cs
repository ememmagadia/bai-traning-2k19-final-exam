using System;
using MiniInformationSystem;
using System.Collections;

namespace MiniInformationSystem
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();
			ArrayList personlist = new ArrayList()
			{
				new Person()
				{
					ID = 1,
					FirstName = "Mermellah",
					LastName = "Angni"
				},
				new Person()
				{
					ID = 2,
					FirstName = "Aaron",
					LastName = "Custodio"
				},
				new Person()
				{
					ID = 3,
					FirstName = "Arnold",
					LastName = "Mendoza"
				}
			};

			Console.Write("Mini Information System\nA\t Add Person\nB\t Delete Person\nC\t View All\nD\t View Person\n\nChoice :");
			var choice = Console.ReadLine();

			switch(choice)
			{
				case "A":
					Console.Write("Enter ID : ");
					int id = Convert.ToInt32(Console.ReadLine());
					Console.Write("Enter First Name : ");
					string fname = Console.ReadLine();
					Console.Write("Enter Last Name : ");
					string lname = Console.ReadLine();
					personlist = person.Add(personlist, id, fname, lname);
					break;
				case "B":
					Console.Write("Enter ID to Delete : ");
					int idDelete = Convert.ToInt32(Console.ReadLine());
					personlist = person.Delete(personlist, idDelete);
					break;
				case "C":
					person.View(personlist);
					break;
				case "D":
					Console.Write("Enter Last Name : ");
					string lastname = Console.ReadLine();
					person.ViewPerson(personlist,lastname);
					break;
			}

		}

	}
}
