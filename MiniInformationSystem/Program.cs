using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace MiniInformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList PersonList = new ArrayList();
            PersonList.Add(new Person { FirstName = "Lex", LastName = "Carao", ID = "00" });
            PersonList.Add(new Person { FirstName = "Dino", LastName = "Reyes", ID = "01" });
            PersonList.Add(new Person { FirstName = "Aaron", LastName = "Custodio", ID = "02" });
            while (true)
            {

                Console.Write("What do you want to do? (Add, Delete, or View): ");
                string Inp1 = Console.ReadLine();
                if (Inp1 == "Add")
                {
                    Console.Write("What is your First Name:  ");
                    string newFirstName = Console.ReadLine();
                    Console.Write("What is your Last Name:  ");
                    string newLastName = Console.ReadLine();
                    Console.Write("What is your ID:  ");
                    string newID = Console.ReadLine();
                    PersonList.Add(new Person{FirstName = newFirstName,LastName = newLastName,ID = newID});
                    Console.WriteLine("Your information has been added");
                }
                if (Inp1 == "View")
                {
                    Console.Write("Would you like to view All, or Search by Last Name?(All or Search): ");
                    string viewInput = Console.ReadLine();
                    if (viewInput == "All")
                    {
                        foreach (Person p in PersonList)
                        {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("First Name:{0}  ||  Last Name:{1}  ||  ID:{2}  ", p.FirstName,p.LastName,p.ID);
                        }
                    }
                    else if(viewInput == "Search")
                    {
                        Console.Write("Enter Last Name to be searched:  ");
                        string searchLastName = Console.ReadLine();
                        foreach (Person p in PersonList)
                        {
                            if (p.LastName == searchLastName)
                            {
                                Console.WriteLine("------------------------------------------------------------");
                                Console.WriteLine("First Name:{0}  ||  Last Name:{1}  ||  ID:{2}  ", p.FirstName, p.LastName, p.ID);
                            }
                        }
                    }
                }
                if (Inp1 == "Delete")
                {
                    Console.Write("Enter ID to be deleted:  ");
                    string deleteID = Console.ReadLine();
                    foreach (Person p in PersonList)
                    {
                        if (p.ID == deleteID)
                        {
                            PersonList.Remove(p);
                        }
                    }
                }
                Console.WriteLine("");
                Console.Write("Would you like to exit, or try another operation?(Exit or Try):  ");
                string exitInput = Console.ReadLine();
                if (exitInput == "Exit")
                {
                    break;
                }
            }
        }
    }
}
