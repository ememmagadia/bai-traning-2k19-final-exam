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
        int id, i=0, input;
        string firstname, lastname;
            Console.WriteLine("How Many User You Want to Add");
            input = int.Parse(Console.ReadLine());
            List<PersonInformation> List = new List<PersonInformation>();
            while (i < input)
            {
                Console.WriteLine("Enter your ID ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Firstname");
                firstname = Console.ReadLine();
                Console.WriteLine("Enter Your Lastname");
                lastname = Console.ReadLine();
                List.Add(new PersonInformation{ ID = id , Firstname = firstname , Lastname = lastname });
                i++;
            }

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
            List.RemoveAll(s => s.ID == id);
            List.ToList().ForEach(s => Console.WriteLine($"{s.ID}, {s.Firstname}, {s.Lastname}"));



        }
    }
}
