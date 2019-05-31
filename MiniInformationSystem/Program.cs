using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniInformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            List<Person> people = new List<Person>();
            people = person.PopulatePerson();

            while(true)
            {
                Console.Write("ADD, DELETE OR VIEW? ");
                string command = Console.ReadLine().ToUpper();

                if (command == "ADD")
                {
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();

                    // Update people list
                    people = person.AddPerson(people, firstName, lastName);
                }
                else if (command == "DELETE")
                {
                    // Do something
                    Console.Write("Enter Last Name of record to be deleted: ");
                    string lastName = Console.ReadLine();

                    // Delete from people list
                    people = person.DeletePerson(people, lastName); ;
                }
                else if (command == "VIEW")
                {
                    Console.WriteLine("Type ALL to view all records./n Type a person's last name to view a specific record.");
                    string specific = Console.ReadLine().ToUpper();
                    if (specific == "ALL")
                    {
                        PrintArray(people);
                    }
                    else
                    {
                        var records = person.ViewPerson(people, specific);
                        PrintArray(records);
                    }
                }
                else
                {
                    Console.Write("Please enter ADD/DELETE/VIEW.");
                }
            }
            
        }

        static void PrintArray(List<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine("Record {0}: {1} {2}", person.UserId, person.FirstName, person.LastName);
            }
        }
    }
}
