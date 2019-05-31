using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniInformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            string choice = "";

            while (true)
            {
                Console.Write("Add, delete or view persons? (A/D/V) 'exit' to exit: ");
                choice = Console.ReadLine();
                if (choice == "a") addPerson(personList);
                else if (choice == "d") deletePerson(personList);
                else if (choice == "v") displayList(personList);
                else if (choice == "exit") break;
            }

        }
            
        private static void deletePerson(List<Person> personList)
        {
            Console.WriteLine("Enter ID of person to delete: " );
            int idRemove = int.Parse(Console.ReadLine());
            personList.RemoveAll(r => r.id == idRemove);
        }

        private static void displayList(List<Person> personList)
        {
            foreach (var list in personList)
            {
                Console.WriteLine("{0}-------{1}-------{2}", list.id, list.firstName, list.lastName);
            }
        }

        private static void addPerson(List<Person> personList)
        {
            Console.WriteLine("Enter ID:");
            int id1 = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lName = Console.ReadLine();

            personList.Add(new Person() { id = id1, firstName = fName, lastName = lName });
        }


    }
}

