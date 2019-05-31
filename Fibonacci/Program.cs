using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            makeFinacci(input);
        }

        private static void makeFinacci(int input)
        {
            int a = 0, b = 1, c = 0;

            Console.WriteLine(a);

            for (int i = 0; i < input; i++)
            {
                c = a + b;
                Console.WriteLine(c);

                a = b;
                b = c;
            }
           
        }

    }
}
