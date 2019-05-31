using System;
using System.Collections.Generic;

namespace MiniInformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
          }


        private static void MainMenu()
        {
            string x;
            do
            {
                Console.WriteLine("Add || Delete || Show || (1/2/3)");
                x = Console.ReadLine();

                if (x.StartsWith("1"))
                {
                    addPerson();
                }

                else if (x.StartsWith("2"))
                {
                    deletePerson();
                }
                else if (x.StartsWith("3"))
                {
                    showPerson();
                }
            }

            while (!x.StartsWith("1") || !x.StartsWith("1") || !x.StartsWith("1"));

        }
        static void addPerson()
        {

            string strPersonID = string.Empty;
            string strPersonName = string.Empty;

            Console.WriteLine("Enter ID:");

            strPersonID = Console.ReadLine();

            Console.WriteLine("Enter Name");
            strPersonName = Console.ReadLine();


            List<Pips> ListofPeople = personclass.LoadPersonData();
            ListofPeople.Add(new Pips(strPersonID, strPersonName));
            MainMenu();
        }
        private static void showPerson()
        {
            List<Pips> people = personclass.LoadPersonData();

            foreach (var person in people)
            {
                Console.WriteLine("{0}, {1}", person.PersonID, person.PersonName);
            }
            MainMenu();
        }


        private static void deletePerson()
        {
            
        }
        public class personclass
        {
            public static object PersonName { get; private set; }
            public static object PersonID { get; private set; }

            public static List<Pips> LoadPersonData()
            {
                List<Pips> ListofPeople = new List<Pips>();
               // ListofPeople.Add(item: new Pips { PersonID, PersonName });
                return ListofPeople;
            }
        }
    }
}
