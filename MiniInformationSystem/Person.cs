using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniInformationSystem
{
    class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Person> people = new List<Person>();

        public void Add()
        {
            string id, firstname, lastname;

            Console.WriteLine("Enter Id: ");
             id = Console.ReadLine();

            Console.WriteLine("Enter firstname: ");
            firstname = Console.ReadLine();

            Console.WriteLine("Enter lastname: ");
            lastname = Console.ReadLine();

            people.Add(new Person() { FirstName = firstname, LastName = lastname, Id = id } );

            Console.WriteLine("You added {0} {1} with Id {2} ", firstname, lastname, id);
            Console.WriteLine();
        }

        public void Delete()
        {

            Console.WriteLine("Delete User by Id: ");
            string delKey = Console.ReadLine();

            var queryDel = from p in people where p.Id == delKey select p;

            if (queryDel.Count() > 0)
            {
                //people.Remove(new Person { Id = delKey });
                people.RemoveAll(a => a.Id == delKey);

                Console.WriteLine("User deleted with ID {0}", delKey);
            }
            else
            {
                Console.WriteLine("No data found.");
                Console.WriteLine();
            }


        }

        public void ViewAll()
        {
            if (people.Count() > 0)
            {
                Console.WriteLine("Here is the list of users:");
                foreach (var s in people)
                {
                    Console.WriteLine(" Id: {0} \n Name: {1} {2} \n", s.Id, s.FirstName, s.FirstName);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
                Console.WriteLine();
            }
            
        }

        public void ViewByLastName()
        {
            Console.WriteLine("Search by lastname: ");
            string searchInput = Console.ReadLine();

            var queryViewByLastname = from p in people where p.LastName == searchInput select p;

            if(queryViewByLastname.Count() > 0)
            {
                Console.WriteLine("Here is the list of users:");
                foreach (var s in queryViewByLastname)
                {
                    Console.WriteLine("Id: {0} \n Name: {1} {2} \n", s.Id, s.FirstName, s.FirstName);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
                Console.WriteLine();
            }

        }

    }
}
