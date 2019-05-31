using System;
using System.Collections;

namespace MiniInformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList ArrayPerson = new ArrayList();
            Hashtable person = new Hashtable;
            Console.Write("What do you want to do?Add,Delete or Search:");
            string todo = Console.ReadLine();

            if(todo == "Add" || todo == "add")
            {
                Console.Write("Input First Name:");
                string Fname = Console.ReadLine();
                Console.Write("Input Last Name:");
                string Lname = Console.ReadLine();
                Console.Write("Input ID:");
                string Id = Console.ReadLine();

                person.Add("ID", Id);
                person.Add("Lname", Lname);
                person.Add("Fname", Fname);
            }




        }
    }
}
