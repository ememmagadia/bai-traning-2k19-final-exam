using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniInformationSystem
{
    class Program
    {
        List<Person> Persons = new List<Person>
            {
                new Person { ID = "001", FirstName = "Aaron", LastName = "Custodio" },
                new Person { ID = "002", FirstName = "Dennis", LastName = "Lumagui" },
                new Person { ID = "003", FirstName = "Jayson", LastName = "Santos" },
                new Person { ID = "004", FirstName = "Jann", LastName = "Mendoza" },
                new Person { ID = "005", FirstName = "Raphael", LastName = "Herrera" }
            };
        static void Main(string[] args)
        {
            Program p = new Program();

            while (true)
            {
                Console.WriteLine("Choose a command. Enter 'x' to exit the program.");
                Console.WriteLine("[1] Add Person, [2] Delete Person, [3] View all Persons, [4] Search");
                Console.Write(">>  "); string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddPerson(p);
                }
                if (choice == "2")
                {
                    Delete(p);
                }
                if (choice == "3")
                {
                    ViewAll(p);
                }
                if (choice == "4")
                {
                    Search(p);
                }
                if (choice == "x")
                {
                    break;
                }
            }
        }
        static void Delete(Program p)
        {
            Console.Write("Enter ID: "); string id = Console.ReadLine();
            Console.WriteLine();

            foreach (var i in p.Persons)
            {
                if (i.ID == id)
                {
                    p.Persons.Remove(i); break;
                }
            }
        }

        static void AddPerson(Program p)
        {
            Console.Write("Enter ID: "); string id = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter First name: "); string fn = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Last name: "); string ln = Console.ReadLine();
            Console.WriteLine();

            p.Persons.Add(new Person { ID = id, FirstName = fn, LastName = ln });
        }

        static void ViewAll(Program p)
        {
            //Get all
            //IEnumerable<Person> result = p.Persons.Where()
            foreach (var i in p.Persons)
            {
                Console.WriteLine("ID: {0}\t\tFirst Name: {1}\t\t\tLast Name: {2}", i.ID, i.FirstName, i.LastName);
            }
        }

        static void Search(Program p)
        {
            Console.Write("Enter First name to search: "); string fn = Console.ReadLine();
            Console.WriteLine();

            foreach (var i in p.Persons)
            {
                if (i.FirstName == fn)
                {
                    Console.WriteLine("ID: {0}\t\tFirst Name: {1}\t\t\tLast Name: {2}", i.ID, i.FirstName, i.LastName);
                }
            }
        }
    }
}

