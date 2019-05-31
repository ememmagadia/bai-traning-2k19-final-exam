using System;
using System.Collections.Generic;
using System.Text;

namespace MiniInformationSystem
{
    public class DeletePerson
    {
        public List<Person> Delete(List<Person> personList, Person person)
        {
            personList.Remove(person);
            return personList;
        }
    }
}
