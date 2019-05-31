using System;
using System.Collections;

namespace Exercise1
{

    public class Action
    {
        public void Add(int Id, string Fname, string Lname)
        {
             Person[] person = 
            {
                new Person( Fname,   Lname, Id )
            };
        }
        public void Delete()
        {

        }
        public void Search()
        {

        }

    }
