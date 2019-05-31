using System;

namespace MiniInformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Mini Information System");
            Console.WriteLine();
            Console.WriteLine(" * 1 - Add \n * 2 - Delete by Id \n * 3 View All User \n * 4 Search by Lastname");
            Console.WriteLine();

            Person people = new Person();

            while (true)
            {
                Console.WriteLine("What do you want to do? <Press the number>");
                string ans = Console.ReadLine();

                if (ans.ToLower() == "1") { people.Add(); }

                if (ans.ToLower() == "2") { people.Delete(); }

                if (ans.ToLower() == "3") { people.ViewAll(); }

                if (ans.ToLower() == "4") { people.ViewByLastName(); }

            }

        }
    }
}
