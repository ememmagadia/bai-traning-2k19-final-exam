using System;
using System.Collections.Generic;
using System.Text;

namespace MiniInformationSystem
{
    public class AddPerson
    {
        public List<Person> Add (List<Person> personList, Person person)
        {
            personList.Add(person);
            return personList;
        }
    }
}
