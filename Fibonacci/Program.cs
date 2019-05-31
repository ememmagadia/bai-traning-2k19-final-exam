using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int numLimit = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 1;
            int result = 0;

           for (int i=0; i<=numLimit-2; i++)
            {
                if (num1==0 && num2==1)
                {
                    Console.Write("{0} {1} ", num1, num2);
                    result = num1 + num2;
                    num1 = num2;
                    num2 = result;
                }
                else
                {
                    Console.Write("{0} ", result);
                    result = num1 + num2;
                    num1 = num2;
                    num2 = result;
                }

                
            }

            
        }

     
    }
}
