using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int max = int.Parse(Console.ReadLine());
            fibonacci(0, 1, max, 0);
        }

        static void fibonacci(int firstNum, int secondNum, int max, int cycle)
        {
            int temp = 0;

            cycle++;
            Console.Write("{0} ", firstNum);
            temp = firstNum;
            firstNum = secondNum;
            secondNum = firstNum + temp;

            if (cycle != max)
            {
                fibonacci(firstNum, secondNum, max, cycle);
            }
        }
    }
}
