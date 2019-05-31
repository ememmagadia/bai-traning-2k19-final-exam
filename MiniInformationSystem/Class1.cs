using System;
using System.Collections.Generic;
using System.Text;

namespace MiniInformationSystem
{
    class Person
    {
        private string id;
        private string firstName;
        private string lastName;

        public string ID
        {
            get { return id; }
            set { id = value; }

        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }

        }
    }
}
