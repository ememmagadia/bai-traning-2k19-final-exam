using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniInformationSystem
{
    class Person
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Person> PopulatePerson()
        {
            List<Person> people = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Kyla",
                    LastName = "Calpito",
                    UserId = 0
                },
                new Person()
                {
                    FirstName = "Jelmarose",
                    LastName = "De Vera",
                    UserId = 1
                },
                new Person()
                {
                    FirstName = "Marc",
                    LastName = "Lomio",
                    UserId = 2
                },
                new Person()
                {
                    FirstName = "Lex",
                    LastName = "Carao",
                    UserId = 3
                },
                new Person()
                {
                    FirstName = "Dino",
                    LastName = "Reyes",
                    UserId = 4
                },
                new Person()
                {
                    FirstName = "Charles",
                    LastName = "Nazareno",
                    UserId = 5
                },
                new Person()
                {
                    FirstName = "Arnold",
                    LastName = "Mendoza",
                    UserId = 6
                },
                new Person()
                {
                    FirstName = "Ellah",
                    LastName = "Agni",
                    UserId = 7
                },
                new Person()
                {
                    FirstName = "Melrose",
                    LastName = "Mejidana",
                    UserId = 8
                },
                new Person()
                {
                    FirstName = "Jasper",
                    LastName = "Orilla",
                    UserId = 9
                },
                new Person()
                {
                    FirstName = "Aaron",
                    LastName = "Custodio",
                    UserId = 10
                }
            };

            return people;
        }
        public List<Person> AddPerson(List<Person> people, string firstName, string lastName)
        {
            people.Add(
                    new Person
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        UserId = people.Count()
                    }
                );

            Console.WriteLine("Successfully added record!");
            return people;
        }

        public List<Person> DeletePerson(List<Person> people,string keyword)
        {
            var records = from person in people
                          where String.Equals(person.LastName, keyword, StringComparison.CurrentCultureIgnoreCase)
                          select new
                          {
                              FirstName = person.FirstName,
                              LastName = person.LastName,
                              UserId = person.UserId
                          };

            if(records.Count() > 0)
            {
                foreach (var item in records)
                {
                    Person deletePerson = new Person()
                    {
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        UserId = item.UserId
                    };

                    int index = people.IndexOf(deletePerson);
                    if(index > 0)
                    {
                        people.RemoveAt(index);
                        Console.WriteLine("Successfully deleted {0}.", keyword);
                    }
                    else
                    {
                        Console.WriteLine("No last name found for {0}.", keyword);
                    }
                }
            }
            else
            {
                Console.WriteLine("No last name found for {0}.", keyword);
            }
            return people;
        }

        public List<Person> ViewPerson(List<Person> people, string keyword)
        {
            var records = from person in people
                          where String.Equals(person.LastName, keyword, StringComparison.CurrentCultureIgnoreCase)
                          select new
                          {
                              FirstName = person.FirstName,
                              LastName = person.LastName,
                              UserId = person.UserId
                          };

            if(records.Count() > 0)
            {
                return people;
            }
            else
            {
                Console.WriteLine("No records found for {0}.", keyword);
                return people;
            }
        }
    }
}
