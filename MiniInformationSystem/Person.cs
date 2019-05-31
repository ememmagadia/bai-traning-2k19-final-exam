using System;

public class Person
{
    public int id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string Fname ,
        string Lname ,
        int  Id )
    {
        FirstName = Fname ;
        LastName = Lname;
        id = Id;
    }
}
