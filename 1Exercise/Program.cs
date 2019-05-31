using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
        int id, i=0;
        string firstname, lastname;
            IList<PersonInformation> List = new List<PersonInformation>();

                Console.WriteLine("Enter your ID ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Firstname");
                firstname = Console.ReadLine();
                Console.WriteLine("Enter Your Lastname");
                lastname = Console.ReadLine();

                List = new List<PersonInformation>()
            {
                new PersonInformation(){ID = id, Firstname = firstname, Lastname = lastname}
            };

            

            Console.WriteLine("List Of All Person that Add");
            var listAll = List.Select(s => s);
            listAll.ToList().ForEach(s => Console.WriteLine($" List Of Students ID{ s.ID} Firstname {s.Firstname} Lastname {s.Lastname}"));

            Console.WriteLine("Search Using Lastname");
            lastname = Console.ReadLine();
            var search = List.Where(s => s.Lastname.Equals(lastname))
                .Select(s => s);
            search.ToList().ForEach(s => Console.WriteLine($" List Of Students ID{ s.ID} Firstname {s.Firstname} Lastname {s.Lastname}"));

        
            Console.WriteLine("Delete Using ID");
            id = int.Parse(Console.ReadLine());
            var deleteDetails = List.Where(s => s.ID == id)
            .Select(s => s);
            deleteDetails.ToList().ForEach(s => Console.WriteLine($" List Of Students ID{ s.ID} Firstname {s.Firstname} Lastname {s.Lastname}"));





        }
    }
}
