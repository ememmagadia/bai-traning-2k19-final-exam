using System;

namespace _2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter A Number");
            number = int.Parse(Console.ReadLine());
            Recursive recursive = new Recursive();
            recursive.Action(number);

        }
    }
}
