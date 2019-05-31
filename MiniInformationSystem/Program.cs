using System;
using System.Collections.Generic;

namespace MiniInformationSystem
{
    class Program
    {
        static void Main(string[] args)
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

                if (x.StartsWith("2"))
                {
                    deletePerson();
                }
                if(x.StartsWith("3"))
                {
                    showPerson();
                }

                
                

            }
            
            while(!x.StartsWith("1") || !x.StartsWith("1") || !x.StartsWith("1"));


            static void addPerson()
        {
               
                string strPersonID = string.Empty;
                string strPersonName = string.Empty;


                List<Pips> ListofPeople = personclass.LoadPersonData();
                ListofPeople.Add(new Pips(strPersonID, strPersonName));

                Console.WriteLine("Enter ID:");
                strPersonID = Console.ReadLine();
                
                Console.WriteLine("Enter Name");
                strPersonName= Console.ReadLine();

                 

        }
    }

        private static void showPerson()
        {
            throw new NotImplementedException();
        }

        private static void deletePerson()
        {
            throw new NotImplementedException();
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
