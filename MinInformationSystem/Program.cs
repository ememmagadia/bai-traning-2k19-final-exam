using System;
using System.Collections.Generic;

namespace MiniInformationSystem
{
    class Program
    {
        List<Person> personList = new List<Person>();

        static void Main(string[] args)
        {
            AddPerson a = new AddPerson();
            DeletePerson d = new DeletePerson();
            Program p = new Program();

            int option = 5;

            while (option != 0)
            {
                Console.Clear();
                Console.WriteLine("Mini Information System");
                Console.WriteLine("1 - Add record");
                Console.WriteLine("2 - View record");
                Console.WriteLine("3 - Delete record");
                Console.WriteLine("0 - Exit program \n");

                Console.Write("Enter option: ");
                option = int.Parse(Console.ReadLine());

                if(option == 1)
                {
                    Console.Write("\nEnter ID: ");
                    string id = Console.ReadLine();
                    Console.Write("\nEnter First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("\nEnter Last Name: ");
                    string lastName = Console.ReadLine();

                    p.personList = a.Add(p.personList, new Person {
                        FirstName = firstName,
                        LastName = lastName,
                        ID = id
                    });

                    Console.WriteLine("Successfully added new person!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                
                }
                else if(option == 2)
                {
                    Console.WriteLine("View record");
                    Console.WriteLine("1 - All records");
                    Console.WriteLine("2 - Search records by last name");

                    Console.Write("Enter view option: ");
                    int view = int.Parse(Console.ReadLine());
                    if (view == 1)
                    {
                        foreach (var person in p.personList)
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("{0} - {1} {2}", person.ID, person.FirstName, person.LastName);
                            Console.WriteLine("----------------------------");

                        }
                    }
                    else
                    {
                        Console.Write("\nEnter Last Name: ");
                        string lastname = Console.ReadLine();
                        int results = 0;
                        foreach (var person in p.personList)
                        {
                            if (person.LastName == lastname)
                            {
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("{0} - {1} {2}", person.ID, person.FirstName, person.LastName);
                                Console.WriteLine("----------------------------");
                                results++;
                            }
                        }
                    
                        if(results == 0)
                        {
                            Console.WriteLine("No results found!");
                        }
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();

                }
                else if(option == 3)
                {
                    Console.WriteLine("Delete record");

                    Console.Write("Enter ID: ");
                    string personID = Console.ReadLine();
                    int results = 0;
                    foreach (var person in p.personList)
                    {
                        if (person.ID == personID)
                        {
                            d.Delete(p.personList, person);
                            results++;
                            Console.WriteLine("Successfully deleted person!");
                            break;
                        }
                    }

                    if(results == 0)
                    {
                        Console.WriteLine("Person not found! Please enter a valid ID.");
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if(option == 0)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}
