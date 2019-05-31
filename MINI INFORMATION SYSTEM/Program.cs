using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MINI_INFORMATION_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> p = new List<Person>();
            p.Add(new Person
            {
                FirstName = "Jasper",
                LastName = "Orilla",
                ID = "1",
            });
            p.Add(new Person
            {
                FirstName = "Aaron",
                LastName = "Custodio",
                ID = "2",
            });
            p.Add(new Person
            {
                FirstName = "Dino",
                LastName = "Reyes",
                ID = "3",
            });


            Console.WriteLine("Select What to do [1] Add, [2] Delete,[3] View" );
            string x = Console.ReadLine();
            if (x.Equals("1"))
            {
                Console.WriteLine("Enter First Name");
                String a = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                String b = Console.ReadLine();
                Console.WriteLine("Enter ID");
                String c = Console.ReadLine();
                p.Add(new Person
                {
                    FirstName = a,
                    LastName = b,
                    ID = c,
                }
                
                );
                Console.WriteLine("{0} {1} {2} has been added to the List", a, b, c);

                var people = from peer in p
                             select new
                             {
                                 peer.FirstName,
                                 peer.LastName,
                                 peer.ID
                             };
                foreach( var z in people)
                {
                    Console.WriteLine("Name: {0}\nLastName: {1} \nID: {2}", z.FirstName, z.LastName, z.ID);
                }
            }
            else if (x.Equals("2"))
            {
                Console.WriteLine("Enter ID to Delete");
                String a = Console.ReadLine();
                var people = from peer in p
                             where peer.ID.Contains(a)
                             select new
                             {
                                 peer.FirstName,
                                 peer.LastName,
                                 peer.ID
                             };
                foreach (var z in people)
                {
                    Console.WriteLine("{0} {1} with ID: {2} has been Deleted", z.FirstName, z.LastName, z.ID);
                }

                var peoples = from peer in p
                             where !peer.ID.Contains(a)
                             select new
                             {
                                 peer.FirstName,
                                 peer.LastName,
                                 peer.ID
                             };
                Console.WriteLine("Here is the New List");
                foreach (var z in peoples)
                {
                    Console.WriteLine("Name: {0}\nLastName: {1} \nID: {2}", z.FirstName, z.LastName, z.ID);
                }


            }
            else if (x.Equals("3"))
            {
                Console.WriteLine("Search: [1] ALL, [2]Last Name");
                String a = Console.ReadLine();
                if (a.Equals("1"))
                {
                    var people = from peer in p
                                 select new
                                 {
                                     peer.FirstName,
                                     peer.LastName,
                                     peer.ID
                                 };
                    foreach (var z in people)
                    {
                        Console.WriteLine("Name: {0}\nLastName: {1} \nID: {2}", z.FirstName, z.LastName, z.ID);
                    }
                }
                else if (a.Equals("2"))
                {
                    Console.WriteLine("Enter the LastName");

                    String search = Console.ReadLine();
                
                    var people = from peer in p
                                 where peer.LastName.Contains(search)
                                 select new
                                 {
                                     peer.FirstName,
                                     peer.LastName,
                                     peer.ID
                                 };
                    foreach (var z in people)
                    {
                        Console.WriteLine("Name: {0}\nLastName: {1} \nID: {2}", z.FirstName, z.LastName, z.ID);
                    }
                }

            }
        }
    }
}
